#Requires -Version 7.0
<#
.SYNOPSIS
    Remove expanded body parameters that collide with other parameters on the same cmdlet.

.DESCRIPTION
    Collision rule: the api.mustache Expanded parameter set emits path/query/header/form
    parameters first, then the request-body model properties. When a body property maps to a
    PowerShell name already declared on the cmdlet, PowerShell fails to parse the function
    ("Duplicate parameter"). This script keeps the first declaration and drops the later
    Expanded-only duplicate, along with its entry in $LocalExpandedBodyKeyMap. The property
    stays reachable through the ByBody parameter set.

    Deduplication works directly on the generated files so it also covers collisions the OAS
    scan cannot see (request bodies and parameters declared via $ref, allOf composition, etc).
    CollisionsFile is optional and used only for reporting.
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$GeneratedRoot,

    [Parameter()]
    [string]$CollisionsFile
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

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
if (-not (Test-Path -LiteralPath $apiDir)) {
    Write-Warning "Missing Api directory under $($packageDir.FullName)"
    exit 0
}

if ($CollisionsFile -and (Test-Path -LiteralPath $CollisionsFile)) {
    $manifest = Get-Content -LiteralPath $CollisionsFile -Raw | ConvertFrom-Json -AsHashtable
    Write-Verbose "Collision manifest lists $($manifest.Count) operation(s) from the OAS scan."
}

# Matches the closing line of a single parameter declaration, e.g. "        ${Firstname}," or "        $WithHttpInfo"
$paramNameLinePattern = '^\s*\$\{?(?<name>[A-Za-z_][A-Za-z0-9_]*)\}?\s*,?\s*$'

function Repair-FunctionParameters {
    param(
        [Parameter(Mandatory)][AllowEmptyString()][string[]]$Lines,
        [Parameter(Mandatory)][string]$FunctionName
    )

    $paramStart = -1
    $paramEnd = -1
    for ($i = 0; $i -lt $Lines.Count; $i++) {
        if ($paramStart -lt 0) {
            if ($Lines[$i] -match '^\s*Param\s*\(\s*$') { $paramStart = $i }
            continue
        }
        if ($Lines[$i] -match '^\s*\)\s*$') {
            $paramEnd = $i
            break
        }
    }

    if ($paramStart -lt 0 -or $paramEnd -lt 0) {
        return [pscustomobject]@{ Lines = $Lines; Changes = @(); Renames = @(); Removed = @() }
    }

    $seen = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::OrdinalIgnoreCase)
    $linesToRemove = [System.Collections.Generic.HashSet[int]]::new()
    $removedNames = [System.Collections.Generic.List[string]]::new()
    $renames = @{}

    $chunkStart = $paramStart + 1
    for ($i = $paramStart + 1; $i -lt $paramEnd; $i++) {
        if ($Lines[$i] -notmatch $paramNameLinePattern) { continue }

        $name = $Matches['name']
        $chunkText = ($Lines[$chunkStart..$i] -join "`n")
        $inExpanded = $chunkText -match "ParameterSetName\s*=\s*'Expanded'"
        $inByBody = $chunkText -match "ParameterSetName\s*=\s*'ByBody'"

        if (-not $seen.Add($name)) {
            if ($inExpanded -and -not $inByBody) {
                # Body property duplicating a path/query/header/form parameter: drop it from
                # Expanded, the value is already supplied by the other parameter.
                for ($k = $chunkStart; $k -le $i; $k++) { [void]$linesToRemove.Add($k) }
                $removedNames.Add($name)
            } elseif ($inByBody -and -not $inExpanded) {
                # The whole-object container duplicating a real body property of the same name
                # (e.g. a model with a "body" property). Rename the container, keep the property.
                $newName = "${name}Object"
                $suffix = 2
                while (-not $seen.Add($newName)) {
                    $newName = "${name}Object${suffix}"
                    $suffix++
                }
                $renames[$i] = @{ Old = $name; New = $newName }
            } else {
                Write-Warning "[expand-body] $FunctionName declares duplicate parameter `$$name in both parameter sets; left unchanged."
            }
        }

        $chunkStart = $i + 1
    }

    if ($linesToRemove.Count -eq 0 -and $renames.Count -eq 0) {
        return [pscustomobject]@{ Lines = $Lines; Changes = @(); Renames = @(); Removed = @() }
    }

    $mapPatterns = @($removedNames | ForEach-Object { "^\s*'$([regex]::Escape($_))'\s*=\s*'[^']*'\s*,?\s*$" })
    $changes = [System.Collections.Generic.List[string]]::new()
    foreach ($name in $removedNames) { $changes.Add("removed `$$name") }

    $output = [System.Collections.Generic.List[string]]::new()
    for ($i = 0; $i -lt $Lines.Count; $i++) {
        if ($linesToRemove.Contains($i)) { continue }

        $line = $Lines[$i]

        if ($renames.ContainsKey($i)) {
            $rename = $renames[$i]
            $line = $line -replace "\`$\{?$([regex]::Escape($rename.Old))\}?", "`${$($rename.New)}"
            $changes.Add("renamed `$$($rename.Old) container to `$$($rename.New)")
            $output.Add($line)
            continue
        }

        if ($i -gt $paramEnd) {
            $isMapEntry = $false
            foreach ($pattern in $mapPatterns) {
                if ($line -match $pattern) { $isMapEntry = $true; break }
            }
            if ($isMapEntry) { continue }

            # Retarget container references in the ByBody branch to the renamed variable.
            foreach ($rename in $renames.Values) {
                $line = $line -replace "(?<![\w])\`$\{?$([regex]::Escape($rename.Old))\}?(?![\w])", "`$$($rename.New)"
            }
        }

        $output.Add($line)
    }

    return [pscustomobject]@{
        Lines   = $output.ToArray()
        Changes = $changes.ToArray()
        Renames = @($renames.Values)
        Removed = $removedNames.ToArray()
    }
}

<#
.SYNOPSIS
    Locate the documentation section for a cmdlet, returning its lines and bounds.
#>
function Get-DocSection {
    param(
        [Parameter(Mandatory)][string]$DocPath,
        [Parameter(Mandatory)][string]$FunctionName
    )

    $lines = @(Get-Content -LiteralPath $DocPath)
    $heading = "# **$FunctionName**"
    $startIndex = -1
    for ($i = 0; $i -lt $lines.Count; $i++) {
        if ($lines[$i] -eq $heading) { $startIndex = $i; break }
    }
    if ($startIndex -lt 0) { return $null }

    $endIndex = $lines.Count - 1
    for ($i = $startIndex + 1; $i -lt $lines.Count; $i++) {
        if ($lines[$i] -match '^# \*\*') { $endIndex = $i - 1; break }
    }

    return [pscustomobject]@{ Lines = $lines; Start = $startIndex; End = $endIndex }
}

<#
.SYNOPSIS
    Drop a parameter from the "Expanded request body parameters" list in the generated docs.
#>
function Remove-DocExpandedParameter {
    param(
        [Parameter(Mandatory)][string]$DocsDir,
        [Parameter(Mandatory)][string]$FunctionName,
        [Parameter(Mandatory)][string]$Name
    )

    if (-not (Test-Path -LiteralPath $DocsDir)) { return }

    foreach ($doc in Get-ChildItem -LiteralPath $DocsDir -Filter '*.md') {
        $section = Get-DocSection -DocPath $doc.FullName -FunctionName $FunctionName
        if (-not $section) { continue }

        $lines = $section.Lines
        $listStart = -1
        for ($i = $section.Start; $i -le $section.End; $i++) {
            if ($lines[$i] -match '^Expanded request body parameters:') { $listStart = $i; break }
        }
        if ($listStart -lt 0) { continue }

        $pattern = "^>\s*(?:&nbsp;)*\[-$([regex]::Escape($Name))\]\s*<"
        $kept = [System.Collections.Generic.List[string]]::new()
        $changed = $false
        for ($i = 0; $i -lt $lines.Count; $i++) {
            if ($i -gt $listStart -and $i -le $section.End -and $lines[$i] -match $pattern) {
                $changed = $true
                continue
            }
            $kept.Add($lines[$i])
        }

        if ($changed) {
            Set-Content -LiteralPath $doc.FullName -Value $kept -Encoding utf8NoBOM
        }
    }
}

<#
.SYNOPSIS
    Mirror a container parameter rename into the generated API markdown docs.
#>
function Update-DocParameterName {
    param(
        [Parameter(Mandatory)][string]$DocsDir,
        [Parameter(Mandatory)][string]$FunctionName,
        [Parameter(Mandatory)][string]$OldName,
        [Parameter(Mandatory)][string]$NewName
    )

    if (-not (Test-Path -LiteralPath $DocsDir)) { return }

    foreach ($doc in Get-ChildItem -LiteralPath $DocsDir -Filter '*.md') {
        $section = Get-DocSection -DocPath $doc.FullName -FunctionName $FunctionName
        if (-not $section) { continue }

        $lines = $section.Lines
        $startIndex = $section.Start
        $endIndex = $section.End
        $old = [regex]::Escape($OldName)
        $changed = $false
        for ($i = $startIndex; $i -le $endIndex; $i++) {
            $line = $lines[$i]
            # Syntax list entry for the whole-object container
            $line = $line -replace "\[-$old\] <PSCustomObject>", "[-$NewName] <PSCustomObject>"
            # Example invocation
            $line = $line -replace "(?<=\s)-$old(?=\s+\$)", "-$NewName"
            # Parameters table row
            $line = $line -replace "^(\s*)\*\*$old\*\*(\s*\|)", "`${1}**$NewName**`${2}"
            # Inline mention in the parameter-set description
            $line = $line -replace "``-$old``", "``-$NewName``"
            if ($line -ne $lines[$i]) {
                $lines[$i] = $line
                $changed = $true
            }
        }

        if ($changed) {
            Set-Content -LiteralPath $doc.FullName -Value $lines -Encoding utf8NoBOM
        }
    }
}

$docsDir = Join-Path $GeneratedRoot 'docs'
$docRenames = [System.Collections.Generic.List[hashtable]]::new()
$docRemovals = [System.Collections.Generic.List[hashtable]]::new()
$totalPatched = 0

foreach ($apiFile in Get-ChildItem -LiteralPath $apiDir -Filter '*.ps1') {
    $content = Get-Content -LiteralPath $apiFile.FullName -Raw
    $original = $content

    $functionMatches = [regex]::Matches($content, '(?m)^function\s+(?<name>[A-Za-z][\w-]*)\s*\{')
    # Rewrite back-to-front so earlier match offsets stay valid.
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
            Write-Warning "[expand-body] Unbalanced braces in $($apiFile.Name) for $functionName; skipping."
            continue
        }

        $funcText = $content.Substring($start, $pos - $start)
        $result = Repair-FunctionParameters -Lines ($funcText -split "\r?\n") -FunctionName $functionName
        if ($result.Changes.Count -eq 0) { continue }

        $content = $content.Remove($start, $pos - $start).Insert($start, ($result.Lines -join "`n"))
        Write-Host "[expand-body] ${functionName}: $($result.Changes -join '; ')"

        foreach ($rename in $result.Renames) {
            $docRenames.Add(@{ Function = $functionName; Old = $rename.Old; New = $rename.New })
        }
        foreach ($name in $result.Removed) {
            $docRemovals.Add(@{ Function = $functionName; Name = $name })
        }
    }

    if ($content -ne $original) {
        Set-Content -LiteralPath $apiFile.FullName -Value $content -Encoding utf8NoBOM
        $totalPatched++
    }
}

Write-Host "[expand-body] Patched $totalPatched file(s) for duplicate expanded parameters."

foreach ($rename in $docRenames) {
    Update-DocParameterName -DocsDir $docsDir -FunctionName $rename.Function -OldName $rename.Old -NewName $rename.New
}
foreach ($removal in $docRemovals) {
    Remove-DocExpandedParameter -DocsDir $docsDir -FunctionName $removal.Function -Name $removal.Name
}
if ($docRenames.Count -gt 0 -or $docRemovals.Count -gt 0) {
    Write-Host "[expand-body] Mirrored $($docRenames.Count) rename(s) and $($docRemovals.Count) removal(s) into docs."
}

# Fail loudly if any generated API file still cannot be parsed.
$parseFailures = @()
foreach ($apiFile in Get-ChildItem -LiteralPath $apiDir -Filter '*.ps1') {
    $errors = $null
    $null = [System.Management.Automation.Language.Parser]::ParseFile($apiFile.FullName, [ref]$null, [ref]$errors)
    if ($errors.Count -gt 0) {
        $parseFailures += "$($apiFile.Name): $($errors[0].Message)"
    }
}

if ($parseFailures.Count -gt 0) {
    Write-Error "[expand-body] Generated API files still have parse errors:`n$($parseFailures -join "`n")"
    exit 1
}

Write-Host '[expand-body] All generated API files parse cleanly.'
