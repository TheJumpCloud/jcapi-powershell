#Requires -Version 7.0
<#
.SYNOPSIS
    Fill empty Expanded body parameter sets from generated Initialize-* models.

.DESCRIPTION
    OpenAPI Generator's PowerShell generator does not populate bodyParam.vars for allOf
    (and some composed) request-body schemas, so api.mustache emits Expanded/ByBody cmdlets
    with an empty $LocalExpandedBodyKeyMap and no Expanded property parameters.

    This post-processor detects those empty maps, resolves the request-body schema from the
    OAS (via the operationId in the ByBody validation throw), copies Expanded parameters and
    the name→baseName map from the matching Initialize-* model, and mirrors the Expanded
    parameter list into API docs.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$GeneratedRoot,

    [Parameter(Mandatory)]
    [string]$SpecPath
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

if (-not (Test-Path -LiteralPath $GeneratedRoot)) {
    throw "GeneratedRoot not found: $GeneratedRoot"
}
if (-not (Test-Path -LiteralPath $SpecPath)) {
    throw "SpecPath not found: $SpecPath"
}

$oas = Get-Content -LiteralPath $SpecPath -Raw | ConvertFrom-Json -AsHashtable

$srcDir = Join-Path $GeneratedRoot 'src'
if (-not (Test-Path -LiteralPath $srcDir)) {
    Write-Warning "Missing src directory under $GeneratedRoot"
    exit 0
}

$packageDir = Get-ChildItem -LiteralPath $srcDir -Directory | Select-Object -First 1
if (-not $packageDir) {
    Write-Warning "No package directory under $srcDir"
    exit 0
}

$apiDir = Join-Path $packageDir.FullName 'Api'
$modelDir = Join-Path $packageDir.FullName 'Model'
$docsDir = Join-Path $GeneratedRoot 'docs'

if (-not (Test-Path -LiteralPath $apiDir)) {
    Write-Warning "Missing Api directory under $($packageDir.FullName)"
    exit 0
}

function Resolve-OasNode {
    param([hashtable]$Root, [object]$Node, [int]$Depth = 0)
    $current = $Node
    while ($current -is [System.Collections.IDictionary] -and $current.ContainsKey('$ref') -and $Depth -lt 12) {
        $ref = [string]$current['$ref']
        if ($ref -notmatch '^#/(?<path>.+)$') { return @{} }
        $current = $Root
        foreach ($segment in ($Matches['path'] -split '/')) {
            $decoded = [uri]::UnescapeDataString($segment)
            if ($current -isnot [System.Collections.IDictionary] -or -not $current.ContainsKey($decoded)) {
                return @{}
            }
            $current = $current[$decoded]
        }
        $Depth++
    }
    if ($current -is [System.Collections.IDictionary]) { return $current }
    return @{}
}

function Get-OperationById {
    param([hashtable]$Root, [string]$OperationId)

    foreach ($pathEntry in $Root['paths'].GetEnumerator()) {
        $pathItem = $pathEntry.Value
        if ($pathItem -isnot [System.Collections.IDictionary]) { continue }
        foreach ($methodEntry in $pathItem.GetEnumerator()) {
            if ($methodEntry.Key -notmatch '^(get|put|post|delete|patch)$') { continue }
            $op = $methodEntry.Value
            if ($op -is [System.Collections.IDictionary] -and [string]$op['operationId'] -eq $OperationId) {
                return $op
            }
        }
    }
    return $null
}

function Get-RequestBodySchemaNode {
    param([hashtable]$Root, [hashtable]$Operation)

    if (-not $Operation.ContainsKey('requestBody') -or $null -eq $Operation['requestBody']) {
        return $null
    }

    $requestBody = Resolve-OasNode -Root $Root -Node $Operation['requestBody']
    $content = $requestBody['content']
    if ($content -isnot [System.Collections.IDictionary]) { return $null }

    $schemaNode = $null
    foreach ($mediaKey in @('application/json', 'application/*+json')) {
        if ($content.ContainsKey($mediaKey) -and $content[$mediaKey] -is [System.Collections.IDictionary]) {
            $schemaNode = $content[$mediaKey]['schema']
            break
        }
    }
    if ($null -eq $schemaNode) {
        foreach ($media in $content.Values) {
            if ($media -is [System.Collections.IDictionary] -and $media.ContainsKey('schema')) {
                $schemaNode = $media['schema']
                break
            }
        }
    }
    return $schemaNode
}

function Get-RequestBodySchemaName {
    param([hashtable]$Root, [hashtable]$Operation)

    $schemaNode = Get-RequestBodySchemaNode -Root $Root -Operation $Operation
    if ($null -eq $schemaNode) { return $null }

    if ($schemaNode -is [System.Collections.IDictionary] -and $schemaNode.ContainsKey('$ref')) {
        $ref = [string]$schemaNode['$ref']
        if ($ref -match '#/components/schemas/(?<name>[^/]+)$') {
            return $Matches['name']
        }
    }

    # Inline schema — cannot map to an Initialize-* model by name
    return $null
}

function Get-SchemaRequiredBaseNames {
    param([hashtable]$Root, [object]$Schema, [System.Collections.Generic.HashSet[string]]$Visited = $null)

    if ($null -eq $Visited) {
        $Visited = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    }

    $required = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    $schema = Resolve-OasNode -Root $Root -Node $Schema
    if ($schema -isnot [System.Collections.IDictionary]) { return $required }

    if ($schema.ContainsKey('$ref')) {
        $ref = [string]$schema['$ref']
        if (-not $Visited.Add($ref)) { return $required }
        foreach ($name in (Get-SchemaRequiredBaseNames -Root $Root -Schema $schema -Visited $Visited)) {
            [void]$required.Add($name)
        }
        return $required
    }

    if ($schema.ContainsKey('required') -and $null -ne $schema['required']) {
        foreach ($name in @($schema['required'])) {
            [void]$required.Add([string]$name)
        }
    }

    if ($schema.ContainsKey('allOf') -and $null -ne $schema['allOf']) {
        foreach ($sub in @($schema['allOf'])) {
            foreach ($name in (Get-SchemaRequiredBaseNames -Root $Root -Schema $sub -Visited $Visited)) {
                [void]$required.Add($name)
            }
        }
    }

    return $required
}

function ConvertTo-DocTypeName {
    param([string]$TypeLine)

    if ([string]::IsNullOrWhiteSpace($TypeLine)) { return 'PSCustomObject' }
    $trimmed = $TypeLine.Trim()
    # Strip a single outer [ ... ] attribute wrapper without truncating nested brackets.
    if ($trimmed.StartsWith('[') -and $trimmed.EndsWith(']')) {
        return $trimmed.Substring(1, $trimmed.Length - 2)
    }
    return $trimmed
}

function Get-ModelFileForSchema {
    param([string]$ModelDir, [string]$SchemaName)

    $candidates = @(
        ($SchemaName -replace '-', '')
        ($SchemaName -replace '[^A-Za-z0-9]', '')
        $SchemaName
    ) | Select-Object -Unique

    foreach ($candidate in $candidates) {
        $path = Join-Path $ModelDir "$candidate.ps1"
        if (Test-Path -LiteralPath $path) { return $path }
    }
    return $null
}

function Get-InitializeModelInfo {
    param([string]$ModelPath)

    $text = Get-Content -LiteralPath $ModelPath -Raw
    if ($text -notmatch '(?ms)^function\s+(?<fn>Initialize-\S+)\s*\{(?<body>.*?)^\}') {
        return $null
    }

    $initBody = $Matches['body']
    if ($initBody -notmatch '(?ms)Param\s*\((?<params>.*?)\)\s*\r?\n\s*Process') {
        return $null
    }
    $paramBlock = $Matches['params']

    if ($initBody -notmatch '(?ms)\$LocalNameToBaseName\s*=\s*@\{(?<map>.*?)\n\s*\}') {
        return $null
    }
    $mapText = $Matches['map']

    $map = [ordered]@{}
    foreach ($line in ($mapText -split "`n")) {
        if ($line -match "^\s*'(?<ps>[^']+)'\s*=\s*'(?<json>[^']+)'\s*,?\s*$") {
            $map[$Matches['ps']] = $Matches['json']
        }
    }
    if ($map.Count -eq 0) { return $null }

    # Split Initialize Param() into per-parameter attribute chunks ending at ${Name}
    $paramChunks = [System.Collections.Generic.List[hashtable]]::new()
    $chunkLines = [System.Collections.Generic.List[string]]::new()
    foreach ($line in ($paramBlock -replace '\r\n', "`n" -split "`n")) {
        if ([string]::IsNullOrWhiteSpace($line) -and $chunkLines.Count -eq 0) { continue }
        $chunkLines.Add($line)
        if ($line -match '^\s*\$\{?(?<name>[A-Za-z_][A-Za-z0-9_]*)\}?\s*,?\s*$') {
            $name = $Matches['name']
            if ($map.Contains($name)) {
                $attrs = @($chunkLines | Where-Object {
                        $_ -notmatch '^\s*\[Parameter\(' -and
                        $_ -notmatch '^\s*\$\{?'
                    })
                $paramChunks.Add(@{
                        Name       = $name
                        BaseName   = $map[$name]
                        AttrLines  = $attrs
                    })
            }
            $chunkLines.Clear()
        }
    }

    return [pscustomobject]@{
        Map    = $map
        Params = $paramChunks
    }
}

function Test-MapIsEmpty {
    param([string]$FunctionText)
    return [bool]($FunctionText -match '(?ms)\$LocalExpandedBodyKeyMap\s*=\s*@\{\s*\}')
}

function Build-ExpandedParamBlock {
    param(
        [System.Collections.IEnumerable]$Params,
        [System.Collections.Generic.HashSet[string]]$RequiredBaseNames = $null
    )

    $lines = [System.Collections.Generic.List[string]]::new()
    foreach ($p in $Params) {
        $mandatory = if ($RequiredBaseNames -and $RequiredBaseNames.Contains([string]$p.BaseName)) { '$true' } else { '$false' }
        [void]$lines.Add("        [Parameter(ParameterSetName = 'Expanded', ValueFromPipelineByPropertyName = `$true, Mandatory = $mandatory)]")
        foreach ($attr in $p.AttrLines) {
            $trimmed = $attr.TrimEnd()
            if ([string]::IsNullOrWhiteSpace($trimmed)) { continue }
            # Normalize indentation to match api.mustache Expanded params
            [void]$lines.Add(('        ' + $trimmed.TrimStart()))
        }
        [void]$lines.Add("        `${$($p.Name)},")
    }
    return ($lines -join "`n")
}

function Build-ExpandedKeyMap {
    param([System.Collections.IDictionary]$Map)

    $entries = foreach ($key in $Map.Keys) {
        "            '$key' = '$($Map[$key])'"
    }
    return @(
        '        $LocalExpandedBodyKeyMap = @{'
        ($entries -join "`n")
        '        }'
    ) -join "`n"
}

function Get-ExpandedExampleSnippet {
    param(
        [string]$FunctionName,
        [System.Collections.IEnumerable]$Params,
        [System.Collections.Generic.HashSet[string]]$RequiredBaseNames = $null
    )

    $assignments = [System.Collections.Generic.List[string]]::new()
    $callArgs = [System.Collections.Generic.List[string]]::new()
    $bodyProps = [System.Collections.Generic.List[string]]::new()

    foreach ($p in $Params) {
        $isRequired = $RequiredBaseNames -and $RequiredBaseNames.Contains([string]$p.BaseName)
        # Keep Expanded examples short: required props + Limit when present.
        if (-not $isRequired -and $p.Name -ne 'Limit') { continue }

        $typeName = ConvertTo-DocTypeName -TypeLine (($p.AttrLines | Where-Object { $_ -match '^\s*\[' } | Select-Object -Last 1))
        $exampleValue = switch -Regex ($typeName) {
            'String\[\]' { '@("all")' }
            'DateTime' { '(Get-Date).ToUniversalTime().AddDays(-7)' }
            'Int64|Int32|Int16' { '100' }
            'Boolean' { '$false' }
            'String$' { '"example"' }
            default { '$null' }
        }
        if ($p.Name -eq 'Service') { $exampleValue = '@("all")' }
        if ($p.Name -eq 'StartTime') { $exampleValue = '(Get-Date).ToUniversalTime().AddDays(-7)' }
        if ($p.Name -eq 'Limit') { $exampleValue = '100' }

        [void]$assignments.Add("`$$($p.Name) = $exampleValue")
        [void]$callArgs.Add("-$($p.Name) `$$($p.Name)")
        [void]$bodyProps.Add("    $($p.BaseName) = $exampleValue")
    }

    if ($assignments.Count -eq 0) {
        # Fall back to first few Expanded params
        foreach ($p in @($Params | Select-Object -First 3)) {
            [void]$assignments.Add("`$$($p.Name) = `$null # $($p.Name)")
            [void]$callArgs.Add("-$($p.Name) `$$($p.Name)")
            [void]$bodyProps.Add("    $($p.BaseName) = `$null")
        }
    }

    $lines = [System.Collections.Generic.List[string]]::new()
    [void]$lines.Add('# Expanded parameter set (default)')
    foreach ($a in $assignments) { [void]$lines.Add($a) }
    [void]$lines.Add('')
    [void]$lines.Add('try {')
    [void]$lines.Add("    `$Result = $FunctionName $($callArgs -join ' ')")
    [void]$lines.Add('} catch {')
    [void]$lines.Add("    Write-Host (`"Exception occurred when calling ${FunctionName}: {0}`" -f (`$_.ErrorDetails | ConvertFrom-Json))")
    [void]$lines.Add('    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))')
    [void]$lines.Add('}')
    [void]$lines.Add('')
    [void]$lines.Add('# ByBody parameter set (optional)')
    [void]$lines.Add('$Body = [PSCustomObject]@{')
    foreach ($b in $bodyProps) { [void]$lines.Add($b) }
    [void]$lines.Add('}')
    [void]$lines.Add("`$Result = $FunctionName -Body `$Body")
    return $lines
}

function Update-DocExpandedParameters {
    param(
        [string]$DocsDir,
        [string]$FunctionName,
        [System.Collections.IEnumerable]$Params,
        [System.Collections.Generic.HashSet[string]]$RequiredBaseNames = $null
    )

    if (-not (Test-Path -LiteralPath $DocsDir)) { return }

    foreach ($doc in Get-ChildItem -LiteralPath $DocsDir -Filter '*.md') {
        $raw = Get-Content -LiteralPath $doc.FullName -Raw
        if ($raw -notmatch [regex]::Escape("# **$FunctionName**")) { continue }

        # Repair collapsed Sample Request notes: restore fences and undo doubled JSON quotes.
        $fence = '```'
        $raw = $raw -replace ' #### Sample Request ``` ', "`n`n#### Sample Request`n${fence}`n"
        $raw = $raw -replace (' ```' + "(\r?\n)"), "`n${fence}`$1`n"
        $raw = $raw -replace '""', '"'
        # Clean up any prior bad replacements that produced literal ```n
        $raw = $raw -replace '```n', "${fence}`n"

        $lines = [System.Collections.Generic.List[string]]::new()
        $lines.AddRange([string[]]($raw -replace '\r\n', "`n" -split "`n"))
        $heading = "# **$FunctionName**"
        $start = -1
        for ($i = 0; $i -lt $lines.Count; $i++) {
            if ($lines[$i] -eq $heading) { $start = $i; break }
        }
        if ($start -lt 0) { continue }

        $end = $lines.Count - 1
        for ($i = $start + 1; $i -lt $lines.Count; $i++) {
            if ($lines[$i] -match '^# \*\*') { $end = $i - 1; break }
        }

        $listStart = -1
        for ($i = $start; $i -le $end; $i++) {
            if ($lines[$i] -match '^Expanded request body parameters:') {
                $listStart = $i
                break
            }
        }

        $docLines = foreach ($p in $Params) {
            $typeLine = ($p.AttrLines | Where-Object { $_ -match '^\s*\[' } | Select-Object -Last 1)
            $typeName = ConvertTo-DocTypeName -TypeLine $typeLine
            "> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-$($p.Name)] <$typeName><br>"
        }

        if ($listStart -ge 0) {
            # Replace existing (possibly empty) list until the next non-list line
            $replaceEnd = $listStart
            for ($i = $listStart + 1; $i -le $end; $i++) {
                if ($lines[$i] -match '^>') { $replaceEnd = $i; continue }
                break
            }
            $count = $replaceEnd - $listStart
            $null = $lines.RemoveRange($listStart, $count + 1)
            $insert = @('Expanded request body parameters:') + @($docLines)
            for ($j = 0; $j -lt $insert.Count; $j++) {
                $lines.Insert($listStart + $j, $insert[$j])
            }
            $end = $end - ($count + 1) + $insert.Count
        } else {
            # Insert after the ByBody/Expanded blurb if present, else after heading
            $insertAt = $start + 1
            for ($i = $start; $i -le $end; $i++) {
                if ($lines[$i] -match 'ByBody') { $insertAt = $i + 1 }
            }
            $insert = @('', 'Expanded request body parameters:') + @($docLines) + @('')
            for ($j = 0; $j -lt $insert.Count; $j++) {
                $lines.Insert($insertAt + $j, $insert[$j])
            }
            $end += $insert.Count
        }

        # Replace ### Example fenced block with Expanded-first examples (no Initialize-*).
        $exampleStart = -1
        for ($i = $start; $i -le $end; $i++) {
            if ($lines[$i] -match '^### Example\s*$') { $exampleStart = $i; break }
        }
        if ($exampleStart -ge 0) {
            $fenceStart = -1
            $fenceEnd = -1
            for ($i = $exampleStart + 1; $i -le $end; $i++) {
                if ($fenceStart -lt 0 -and $lines[$i] -match '^```') { $fenceStart = $i; continue }
                if ($fenceStart -ge 0 -and $lines[$i] -match '^```') { $fenceEnd = $i; break }
            }
            if ($fenceStart -ge 0 -and $fenceEnd -gt $fenceStart) {
                $authLines = [System.Collections.Generic.List[string]]::new()
                for ($i = $fenceStart + 1; $i -lt $fenceEnd; $i++) {
                    if ($lines[$i] -match 'Initialize-') { break }
                    if ($lines[$i] -match '^\s*$' -and $authLines.Count -gt 0 -and $authLines[-1] -match 'ApiKey|Configuration|Bearer|authorization') {
                        [void]$authLines.Add($lines[$i])
                        # Keep a single trailing blank after auth block
                        if ($i + 1 -lt $fenceEnd -and $lines[$i + 1] -notmatch 'Configuration|ApiKey|Bearer|authorization|general setting') {
                            break
                        }
                        continue
                    }
                    if ($lines[$i] -match 'Configuration|ApiKey|Bearer|authorization|general setting|Username|Password|AccessToken|HttpSigning') {
                        [void]$authLines.Add($lines[$i])
                    } elseif ($authLines.Count -eq 0) {
                        [void]$authLines.Add($lines[$i])
                    } else {
                        break
                    }
                }

                $snippet = Get-ExpandedExampleSnippet -FunctionName $FunctionName -Params $Params -RequiredBaseNames $RequiredBaseNames
                $replacement = [System.Collections.Generic.List[string]]::new()
                [void]$replacement.Add('```powershell')
                foreach ($l in $authLines) { [void]$replacement.Add($l) }
                if ($authLines.Count -eq 0 -or $authLines[-1] -ne '') { [void]$replacement.Add('') }
                foreach ($l in $snippet) { [void]$replacement.Add($l) }
                [void]$replacement.Add('```')

                $null = $lines.RemoveRange($fenceStart, $fenceEnd - $fenceStart + 1)
                for ($j = 0; $j -lt $replacement.Count; $j++) {
                    $lines.Insert($fenceStart + $j, $replacement[$j])
                }
            }
        }

        # Parameters table: list Expanded props, keep Body
        $paramsHeading = -1
        for ($i = $start; $i -lt $lines.Count; $i++) {
            if ($i -gt $end + 40) { break }
            if ($lines[$i] -match '^### Parameters\s*$') { $paramsHeading = $i; break }
        }
        if ($paramsHeading -ge 0) {
            $tableEnd = $paramsHeading + 1
            while ($tableEnd -lt $lines.Count -and $lines[$tableEnd] -notmatch '^### ') { $tableEnd++ }
            $paramRows = [System.Collections.Generic.List[string]]::new()
            [void]$paramRows.Add('Name | Type | Description  | Notes')
            [void]$paramRows.Add('------------- | ------------- | ------------- | -------------')
            foreach ($p in $Params) {
                $typeName = ConvertTo-DocTypeName -TypeLine (($p.AttrLines | Where-Object { $_ -match '^\s*\[' } | Select-Object -Last 1))
                $reqNote = if ($RequiredBaseNames -and $RequiredBaseNames.Contains([string]$p.BaseName)) { '' } else { '[optional] ' }
                [void]$paramRows.Add(" **$($p.Name)** | **$typeName**|  | $reqNote")
            }
            [void]$paramRows.Add(' **Body** | [**PSCustomObject**](#)| Whole request body (ByBody parameter set) | [optional] ')
            [void]$paramRows.Add('')
            $null = $lines.RemoveRange($paramsHeading + 1, [Math]::Max(0, $tableEnd - $paramsHeading - 1))
            for ($j = 0; $j -lt $paramRows.Count; $j++) {
                $lines.Insert($paramsHeading + 1 + $j, $paramRows[$j])
            }
        }

        Set-Content -LiteralPath $doc.FullName -Value $lines -Encoding utf8NoBOM
        Write-Host "[expand-fill] Updated docs for $FunctionName in $($doc.Name)"
        break
    }
}

function Repair-EmptyExpandedFunction {
    param(
        [string]$FunctionText,
        [string]$FunctionName,
        [hashtable]$OasRoot,
        [string]$ModelDir
    )

    if (-not (Test-MapIsEmpty -FunctionText $FunctionText)) {
        return $null
    }
    if ($FunctionText -notmatch "ParameterSetName\s*=\s*'ByBody'" -or $FunctionText -notmatch '\$\{?Body\}?') {
        return $null
    }

    if ($FunctionText -notmatch 'missing when calling (?<op>[A-Za-z0-9_]+)\.') {
        Write-Warning "[expand-fill] ${FunctionName}: empty Expanded map but no operationId in ByBody throw; skipping."
        return $null
    }
    $operationId = $Matches['op']

    $operation = Get-OperationById -Root $OasRoot -OperationId $operationId
    if ($null -eq $operation) {
        Write-Warning "[expand-fill] ${FunctionName}: operationId '$operationId' not found in OAS; skipping."
        return $null
    }

    $schemaName = Get-RequestBodySchemaName -Root $OasRoot -Operation $operation
    if ([string]::IsNullOrWhiteSpace($schemaName)) {
        Write-Warning "[expand-fill] ${FunctionName}: could not resolve request body schema for '$operationId'; skipping."
        return $null
    }

    $modelPath = Get-ModelFileForSchema -ModelDir $ModelDir -SchemaName $schemaName
    if (-not $modelPath) {
        Write-Warning "[expand-fill] ${FunctionName}: model file for schema '$schemaName' not found; skipping."
        return $null
    }

    $modelInfo = Get-InitializeModelInfo -ModelPath $modelPath
    if ($null -eq $modelInfo -or $modelInfo.Params.Count -eq 0) {
        Write-Warning "[expand-fill] ${FunctionName}: Initialize-* for '$schemaName' has no expandable properties; skipping."
        return $null
    }

    $schemaNode = Get-RequestBodySchemaNode -Root $OasRoot -Operation $operation
    $requiredBaseNames = Get-SchemaRequiredBaseNames -Root $OasRoot -Schema $schemaNode

    # Skip properties that would collide with existing non-Expanded parameters already on the cmdlet
    $existingParamNames = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    foreach ($m in [regex]::Matches($FunctionText, '(?m)^\s*\$\{?(?<n>[A-Za-z_][A-Za-z0-9_]*)\}?\s*,?\s*$')) {
        [void]$existingParamNames.Add($m.Groups['n'].Value)
    }

    $usable = [System.Collections.Generic.List[hashtable]]::new()
    $map = [ordered]@{}
    foreach ($p in $modelInfo.Params) {
        if ($existingParamNames.Contains($p.Name) -and $p.Name -ne 'Body') {
            # Path/query/header already owns this name; leave it for ByBody only (collision fixer pattern).
            continue
        }
        $usable.Add($p)
        $map[$p.Name] = $p.BaseName
    }
    if ($usable.Count -eq 0) {
        Write-Warning "[expand-fill] ${FunctionName}: all body properties collide with existing parameters; leaving map empty."
        return $null
    }

    $expandedBlock = Build-ExpandedParamBlock -Params $usable -RequiredBaseNames $requiredBaseNames
    $keyMapBlock = Build-ExpandedKeyMap -Map $map

    $updated = $FunctionText

    # Insert Expanded params immediately before the ByBody -Body parameter declaration
    $bodyParamPattern = "(?ms)(?<indent>[ \t]*)\[Parameter\(ParameterSetName = 'ByBody',[^\]]*\)\]\s*\r?\n\s*\[PSCustomObject\]\s*\r?\n\s*\$\{Body\},"
    $bodyMatch = [regex]::Match($updated, $bodyParamPattern)
    if (-not $bodyMatch.Success) {
        Write-Warning "[expand-fill] ${FunctionName}: could not locate ByBody `${Body} parameter; skipping."
        return $null
    }
    $updated = $updated.Substring(0, $bodyMatch.Index) + $expandedBlock + "`n" + $updated.Substring($bodyMatch.Index)

    # Replace empty key map
    $updated = [regex]::Replace(
        $updated,
        '(?ms)[ \t]*\$LocalExpandedBodyKeyMap\s*=\s*@\{\s*\}',
        $keyMapBlock,
        1
    )

    # Guard against posting an empty JSON body on Expanded when nothing was bound.
    if ($updated -notmatch 'No Expanded body parameters were provided') {
        $updated = [regex]::Replace(
            $updated,
            '(?ms)(if \(\$LocalExpandedBody\.Count -gt 0\) \{\s*\$LocalVarBodyParameter = \$LocalExpandedBody \| ConvertTo-Json -Depth 100\s*\})',
            "`$1 else {`n                throw `"Error! No Expanded body parameters were provided when calling $operationId. Supply required body properties or use -Body.`"`n            }",
            1
        )
    }

    if ($updated -eq $FunctionText) {
        return $null
    }

    return [pscustomobject]@{
        Text               = $updated
        Params             = $usable
        Schema             = $schemaName
        RequiredBaseNames  = $requiredBaseNames
    }
}

$totalPatched = 0
$docUpdates = [System.Collections.Generic.List[hashtable]]::new()

foreach ($apiFile in Get-ChildItem -LiteralPath $apiDir -Filter '*.ps1') {
    $content = Get-Content -LiteralPath $apiFile.FullName -Raw
    $original = $content

    $functionMatches = [regex]::Matches($content, '(?m)^function\s+(?<name>[A-Za-z][\w-]*)\s*\{')
    for ($m = $functionMatches.Count - 1; $m -ge 0; $m--) {
        $funcMatch = $functionMatches[$m]
        $functionName = $funcMatch.Groups['name'].Value

        $start = $funcMatch.Index
        $pos = $funcMatch.Index + $funcMatch.Length
        $brace = 1
        while ($pos -lt $content.Length -and $brace -gt 0) {
            if ($content[$pos] -eq '{') { $brace++ }
            elseif ($content[$pos] -eq '}') { $brace-- }
            $pos++
        }
        if ($brace -ne 0) {
            Write-Warning "[expand-fill] Unbalanced braces in $($apiFile.Name) for $functionName; skipping."
            continue
        }

        $funcText = $content.Substring($start, $pos - $start)
        $result = Repair-EmptyExpandedFunction -FunctionText $funcText -FunctionName $functionName -OasRoot $oas -ModelDir $modelDir
        if ($null -eq $result) { continue }

        $content = $content.Remove($start, $pos - $start).Insert($start, $result.Text)
        Write-Host "[expand-fill] ${functionName}: filled Expanded map from $($result.Schema) ($($result.Params.Count) properties)"
        $docUpdates.Add(@{
                Function           = $functionName
                Params             = $result.Params
                RequiredBaseNames  = $result.RequiredBaseNames
            })
    }

    if ($content -ne $original) {
        Set-Content -LiteralPath $apiFile.FullName -Value ($content.Replace("`r`n", "`n")) -Encoding utf8NoBOM
        $totalPatched++
    }
}

foreach ($update in $docUpdates) {
    Update-DocExpandedParameters -DocsDir $docsDir -FunctionName $update.Function -Params $update.Params -RequiredBaseNames $update.RequiredBaseNames
}

Write-Host "[expand-fill] Patched $totalPatched file(s); filled $($docUpdates.Count) function(s)."

# Fail loudly if any generated API file still cannot be parsed.
$parseFailures = @()
foreach ($apiFile in Get-ChildItem -LiteralPath $apiDir -Filter '*.ps1') {
    $errors = $null
    $null = [System.Management.Automation.Language.Parser]::ParseFile($apiFile.FullName, [ref]$null, [ref]$errors)
    if ($errors -and $errors.Count -gt 0) {
        $parseFailures += "$($apiFile.Name): $($errors[0].Message)"
    }
}
if ($parseFailures.Count -gt 0) {
    throw "Expanded-body fill left unparseable API file(s): $($parseFailures -join '; ')"
}
