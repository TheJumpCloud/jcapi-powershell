#Requires -Version 7.0
<#
.SYNOPSIS
    OpenAPI Generator file post-processor: injects automatic pagination into generated API functions.

.DESCRIPTION
    Reads OASMapping.{SDKName}.json and, for each mapped function with paginate=true,
    rewrites the generated cmdlet to aggregate paged results (matching BuildCustomFunctions.ps1).

.PARAMETER FilePath
    Path to a single generated .ps1 file (OpenAPI Generator passes this as the first argument).

.PARAMETER GeneratedRoot
    Root of a generated SDK (e.g. OpenAPI/PowerShell/JumpCloud.SDK.DirectoryInsights).

.PARAMETER SdkName
    SDK short name matching OASMapping.{SdkName}.json (e.g. DirectoryInsights).
#>
[CmdletBinding(DefaultParameterSetName = 'File')]
param(
    [Parameter(ParameterSetName = 'File', Position = 0)]
    [string]$FilePath,

    [Parameter(ParameterSetName = 'Batch', Mandatory)]
    [string]$GeneratedRoot,

    [Parameter(ParameterSetName = 'Batch', Mandatory)]
    [string]$SdkName
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

$ScriptRoot = $PSScriptRoot
$Indent = '    '

function Get-OasMappingByFunctionName {
    param([string]$MappingPath)

    if (-not (Test-Path -LiteralPath $MappingPath)) {
        Write-Verbose "No mapping file at $MappingPath"
        return @{}
    }

    $mapping = Get-Content -LiteralPath $MappingPath -Raw | ConvertFrom-Json -AsHashtable
    $byFunction = @{}
    foreach ($entry in $mapping.GetEnumerator()) {
        $functionName = $entry.Value['x-powershell-method-name']
        if ([string]::IsNullOrWhiteSpace($functionName)) { continue }
        $byFunction[$functionName] = $entry.Value
    }
    return $byFunction
}

function Get-SdkShortNameFromPath {
    param([string]$Path)
    if ($Path -match 'JumpCloud\.SDK\.([^.\\/]+)') {
        return $Matches[1]
    }
    return $null
}

function Get-PowerShellFunctions {
    param([string]$Text)

    $results = [System.Collections.Generic.List[object]]::new()
    $regex = [regex]'(?m)^function\s+(\S+)\s*\{'
    $functionMatches = $regex.Matches($Text)
    for ($i = 0; $i -lt $functionMatches.Count; $i++) {
        $start = $functionMatches[$i].Index
        $name = $functionMatches[$i].Groups[1].Value
        $braceStart = $Text.IndexOf('{', $start)
        if ($braceStart -lt 0) { continue }

        $depth = 0
        $pos = $braceStart
        while ($pos -lt $Text.Length) {
            $char = $Text[$pos]
            if ($char -eq '{') { $depth++ }
            elseif ($char -eq '}') {
                $depth--
                if ($depth -eq 0) {
                    $length = $pos - $start + 1
                    $results.Add([PSCustomObject]@{
                            Name   = $name
                            Text   = $Text.Substring($start, $length)
                            Start  = $start
                            Length = $length
                        })
                    break
                }
            }
            $pos++
        }
    }
    return $results
}

function Get-PaginationMode {
    param(
        [string]$FunctionText,
        [string]$SdkShortName
    )

    $hasEventQuery = $FunctionText -match '\$\{EventQuery\}'
    $hasSkip = $FunctionText -match '\$\{Skip\}'
    $hasLimit = $FunctionText -match '\$\{Limit\}'

    if ($SdkShortName -eq 'DirectoryInsights' -and ($hasEventQuery -or $hasSkip -or $hasLimit)) {
        return 'DirectoryInsights'
    }
    if ($hasSkip -or $hasLimit) {
        return 'SkipLimit'
    }
    return 'None'
}

function Add-PaginateParameter {
    param([string]$FunctionText)

    if ($FunctionText -match '\$Paginate\s*=') {
        return $FunctionText
    }

    $insert = @"
$Indent    [Parameter(DontShow)]
$Indent    [System.Boolean]
$Indent    # Set to `$true to return all results. This will overwrite any skip and limit parameter.
$Indent    `$Paginate = `$true,

"@

    if ($FunctionText -match '(?ms)(Param\s*\(.*?)((\r?\n\s*\[Switch\]\s*\r?\n\s*\$WithHttpInfo))') {
        return $FunctionText.Replace($Matches[0], ($Matches[1].TrimEnd() + ",`n" + $insert.TrimEnd() + "`n" + $Matches[2]))
    }

    if ($FunctionText -match '(?ms)(Param\s*\(.*)(\r?\n\s*\)\s*)') {
        return $FunctionText.Replace($Matches[0], ($Matches[1].TrimEnd() + ",`n" + $insert.TrimEnd() + "`n" + $Matches[2]))
    }

    return $FunctionText
}

function Get-InvokeAndReturnBlock {
    param([string]$ProcessBody)

    $returnPattern = '(?ms)\s*if\s*\(\$WithHttpInfo\.IsPresent\)\s*\{\s*return\s+\$LocalVarResult\s*\}\s*else\s*\{\s*return\s+\$LocalVarResult\["Response"\]\s*\}\s*$'
    if ($ProcessBody -notmatch $returnPattern) {
        return $null
    }

    $invokeBlock = ($ProcessBody -replace $returnPattern, '').TrimEnd()
    return $invokeBlock
}

function Get-RetryWrapper {
    param([string]$InvokeBlock)

    @"
            `$maxRetries = 4
            `$resultCounter = 0
            :retryLoop do {
                `$resultCounter++
                `$sdkError = `$null
                try {
$InvokeBlock
                    `$Result = `$LocalVarResult['Response']
                } catch {
                    `$sdkError = `$_
                }
                If (`$sdkError) {
                    If (`$resultCounter -eq `$maxRetries) {
                        throw `$sdkError
                    }
                    `$statusCode = `$null
                    if (`$LocalVarResult -and `$LocalVarResult.StatusCode) { `$statusCode = `$LocalVarResult.StatusCode }
                    If (`$statusCode -eq 503) {
                        Write-Warning ("503: Service Unavailable - retrying in " + (`$resultCounter * 5) + " seconds.")
                    } else {
                        throw `$sdkError
                    }
                } else {
                    break retryLoop
                }
                Start-Sleep -Seconds (`$resultCounter * 5)
            } while (`$resultCounter -lt `$maxRetries)
"@
}

function Get-DirectoryInsightsPaginateBlock {
    param(
        [string]$InvokeBlock,
        [string]$FunctionText
    )

    $retry = Get-RetryWrapper -InvokeBlock $InvokeBlock

    $limitBranch = if ($FunctionText -match '\$\{EventQuery\}') {
        'if ($EventQuery -and $EventQuery.limit) {'
    } elseif ($FunctionText -match '\$\{Limit\}') {
        'if ($Limit) {'
    } else {
        'if ($false) {'
    }
    $limitBranch = $limitBranch.Replace('$', '`$')

    $searchAfterUpdate = if ($FunctionText -match '\$\{EventQuery\}') {
        @"
                    if (`$null -ne `$XResultSearchAfter) {
                        `$EventQuery.search_after = `$XResultSearchAfter
                        `$LocalVarBodyParameter = `$EventQuery | ConvertTo-Json -Depth 100
                    }
"@
    } else {
        @"
                    if (`$null -ne `$XResultSearchAfter) {
                        if ([string]::IsNullOrEmpty(`$PSBoundParameters.SearchAfter)) {
                            `$PSBoundParameters.Add('SearchAfter', `$XResultSearchAfter)
                        } else {
                            `$PSBoundParameters.SearchAfter = `$XResultSearchAfter
                        }
                    }
"@
    }

    @"
        If (`$Paginate -and -not `$WithHttpInfo.IsPresent) {
            `$PSBoundParameters.Remove('Paginate') | Out-Null
            `$XResultCount = 0
            `$XLimit = 0
            Do {
$retry
                $limitBranch
                    `$Results += `$Result
                    break
                } elseif (`$LocalVarResult.Headers -and `$LocalVarResult.Headers.Contains('X-Search_after')) {
                    If (-not [System.String]::IsNullOrEmpty(`$Result)) {
                        `$searchAfterRaw = `$LocalVarResult.Headers['X-Search_after']
                        if (`$searchAfterRaw -is [array]) { `$searchAfterRaw = `$searchAfterRaw[0] }
                        `$XResultSearchAfter = (`$searchAfterRaw | ConvertFrom-Json)
$searchAfterUpdate
                        `$countRaw = `$LocalVarResult.Headers['X-Result-Count']
                        `$limitRaw = `$LocalVarResult.Headers['X-Limit']
                        if (`$countRaw -is [array]) { `$countRaw = `$countRaw[0] }
                        if (`$limitRaw -is [array]) { `$limitRaw = `$limitRaw[0] }
                        `$XResultCount = [int]`$countRaw
                        `$XLimit = [int]`$limitRaw
                        `$Results += `$Result
                        Write-Debug ("ResultCount: `$(`$XResultCount); Limit: `$(`$XLimit); XResultSearchAfter: `$(`$XResultSearchAfter); ")
                    }
                } else {
                    `$Results += `$Result
                    break
                }
            }
            While (`$XResultCount -eq `$XLimit -and -not [System.String]::IsNullOrEmpty(`$Result))
            return
        } else {
            `$PSBoundParameters.Remove('Paginate') | Out-Null
$retry
            if (`$WithHttpInfo.IsPresent) {
                return `$LocalVarResult
            } elseif (-not [System.String]::IsNullOrEmpty(`$Result)) {
                return `$Result
            }
        }
"@
}

function Get-SkipLimitPaginateBlock {
    param(
        [string]$InvokeBlock,
        [string]$FunctionText
    )

    $retry = Get-RetryWrapper -InvokeBlock $InvokeBlock

    $initLimit = if ($FunctionText -match '\$\{Limit\}') {
        @"
            If ([string]::IsNullOrEmpty(`$PSBoundParameters.Limit)) {
                `$PSBoundParameters.Add('Limit', 100)
            }
"@
    } else { '' }

    $initSkip = if ($FunctionText -match '\$\{Skip\}') {
        @"
            If ([string]::IsNullOrEmpty(`$PSBoundParameters.Skip)) {
                `$PSBoundParameters.Add('Skip', 0)
            }
"@
    } else { '' }

    $skipAdvance = if ($FunctionText -match '\$\{Skip\}') {
        '                $PSBoundParameters.Skip += $ResultCount'
    } else { '' }

    $whileCondition = if ($FunctionText -match '\$\{Limit\}') {
        'While ($ResultCount -eq $PSBoundParameters.Limit -and -not [System.String]::IsNullOrEmpty($Result))'
    } else {
        'While (-not [System.String]::IsNullOrEmpty($Result))'
    }

    @"
        If (`$Paginate -and -not `$WithHttpInfo.IsPresent) {
            `$PSBoundParameters.Remove('Paginate') | Out-Null
$initLimit
$initSkip
            Do {
                if (`$PSBoundParameters.Limit) { Write-Debug ("Limit: `$(`$PSBoundParameters.Limit); ") }
                if (`$PSBoundParameters.Skip) { Write-Debug ("Skip: `$(`$PSBoundParameters.Skip); ") }
$retry
                `$Result = If ('results' -in `$Result.PSObject.Properties.Name) {
                    `$Result.results
                } Else {
                    `$Result
                }
                If (-not [System.String]::IsNullOrEmpty(`$Result)) {
                    `$ResultCount = (`$Result | Measure-Object).Count
                    `$Results += `$Result
$skipAdvance
                }
            }
            $whileCondition
            return
        } else {
            `$PSBoundParameters.Remove('Paginate') | Out-Null
$retry
            `$Result = If ('results' -in `$Result.PSObject.Properties.Name) {
                `$Result.results
            } Else {
                `$Result
            }
            if (`$WithHttpInfo.IsPresent) {
                return `$LocalVarResult
            } elseif (-not [System.String]::IsNullOrEmpty(`$Result)) {
                return `$Result
            }
        }
"@
}

function ConvertTo-PaginatedFunction {
    param(
        [string]$FunctionText,
        [string]$Mode
    )

    if ($FunctionText -match '\$Paginate\s*=' -and $FunctionText -match 'Begin\s*\{') {
        Write-Verbose 'Function already paginated; skipping.'
        return $FunctionText
    }

    if ($FunctionText -notmatch '(?ms)(?<head>.*?)(?<process>Process\s*\{(?<processBody>.*)\})\s*\}\s*$') {
        Write-Verbose 'Function has no Process block; skipping pagination rewrite.'
        return $FunctionText
    }

    $head = $Matches['head']
    $processBody = $Matches['processBody'].TrimEnd()
    $invokeBlock = Get-InvokeAndReturnBlock -ProcessBody $processBody
    if ($null -eq $invokeBlock) {
        Write-Verbose 'Function Process block does not match expected return pattern; skipping.'
        return $FunctionText
    }

    $paginateBlock = switch ($Mode) {
        'DirectoryInsights' { Get-DirectoryInsightsPaginateBlock -InvokeBlock $invokeBlock -FunctionText $FunctionText }
        'SkipLimit' { Get-SkipLimitPaginateBlock -InvokeBlock $invokeBlock -FunctionText $FunctionText }
        default { return $FunctionText }
    }

    $head = Add-PaginateParameter -FunctionText $head

    $wrapperStart = @"

    Begin {
        `$Results = @()
    }
    Process {
"@
    $wrapperEnd = @"

    }
    End {
        Return `$Results
    }
}
"@

    return ($head.TrimEnd() + $wrapperStart + $paginateBlock + $wrapperEnd)
}

function Update-ApiFilePagination {
    param(
        [string]$Path,
        [hashtable]$MappingByFunction,
        [string]$SdkShortName
    )

    if ($Path -notmatch '[\\/]Api[\\/]') {
        Write-Verbose "Skipping non-API file: $Path"
        return $false
    }

    $content = Get-Content -LiteralPath $Path -Raw
    $functions = @(Get-PowerShellFunctions -Text $content)
    if ($functions.Length -eq 0) {
        return $false
    }

    $changed = $false
    $newContent = $content

    foreach ($fn in ($functions | Sort-Object Start -Descending)) {
        $mappingEntry = $MappingByFunction[$fn.Name]
        if ($null -eq $mappingEntry) { continue }
        if ($mappingEntry.paginate -ne $true) { continue }

        $mode = Get-PaginationMode -FunctionText $fn.Text -SdkShortName $SdkShortName
        if ($mode -eq 'None') {
            Write-Verbose "[pagination] $($fn.Name): paginate=true in mapping but no skip/limit/EventQuery; skipping."
            continue
        }

        $updated = ConvertTo-PaginatedFunction -FunctionText $fn.Text -Mode $mode
        if ($updated -eq $fn.Text) { continue }

        $newContent = $newContent.Remove($fn.Start, $fn.Length).Insert($fn.Start, $updated)
        $changed = $true
        Write-Host "[pagination] Applied $mode pagination to $($fn.Name) in $Path"
    }

    if ($changed) {
        $utf8 = New-Object System.Text.UTF8Encoding $true
        [System.IO.File]::WriteAllText($Path, $newContent.Replace("`r`n", "`n"), $utf8)
    }

    return $changed
}

function Invoke-OasPaginationPostProcess {
    param(
        [string]$Path,
        [string]$SdkShortName
    )

    $resolved = $ExecutionContext.SessionState.Path.GetUnresolvedProviderPathFromPSPath($Path)
    if (-not (Test-Path -LiteralPath $resolved)) {
        Write-Warning "File not found: $resolved"
        return
    }

    $sdkName = if ([string]::IsNullOrWhiteSpace($SdkShortName)) {
        Get-SdkShortNameFromPath -Path $resolved
    } else {
        $SdkShortName
    }

    if ([string]::IsNullOrWhiteSpace($sdkName)) {
        Write-Warning "Could not determine SDK name from path: $resolved"
        return
    }

    $mappingPath = Join-Path $ScriptRoot "../OAS/mapping/OASMapping.$sdkName.json"
    $mappingByFunction = Get-OasMappingByFunctionName -MappingPath $mappingPath
    if (@($mappingByFunction.Keys).Count -eq 0) {
        Write-Verbose "No mapping entries for SDK $sdkName"
        return
    }

    [void](Update-ApiFilePagination -Path $resolved -MappingByFunction $mappingByFunction -SdkShortName $sdkName)
}

if ($PSCmdlet.ParameterSetName -eq 'Batch') {
    $rootResolved = $ExecutionContext.SessionState.Path.GetUnresolvedProviderPathFromPSPath($GeneratedRoot)
    $apiFiles = Get-ChildItem -Path $rootResolved -Recurse -Filter '*.ps1' |
        Where-Object { $_.FullName -match '[\\/]Api[\\/]' }

    foreach ($file in $apiFiles) {
        Invoke-OasPaginationPostProcess -Path $file.FullName -SdkShortName $SdkName
    }
    exit 0
}

if ([string]::IsNullOrWhiteSpace($FilePath) -and @($args).Length -gt 0) {
    $FilePath = $args[0]
}

if ([string]::IsNullOrWhiteSpace($FilePath)) {
    throw 'FilePath is required (pass as -FilePath or first positional argument).'
}

Invoke-OasPaginationPostProcess -Path $FilePath
