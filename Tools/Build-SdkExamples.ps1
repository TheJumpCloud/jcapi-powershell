[CmdletBinding()]
param (
    [Parameter(Mandatory = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()]
    [System.String[]]
    $SDKName #= 'JumpCloud.SDK.V1'
)
$rootPath = "$PSScriptRoot/../"
# examples:
$examples = Get-ChildItem -Path "$rootPath/SDKs/PowerShell/$SDKName/examples" -Filter "*.md"
$functions = Get-ChildItem -Path "$rootPath/SDKs/PowerShell/$SDKName/custom/generated" -Filter "*.ps1"

$list = New-Object System.Collections.ArrayList
function get-verb {
    [CmdletBinding()]
    param (
        $string
    )

    begin {
        $VerbMap = @{
            'New' = 'Create'
        }

    }

    process {
        if ($string -in $VerbMap.Keys){
            $matchedVerb = $VerbMap["$string"]
        } else {
            $matchedVerb = $string
        }

    }

    end {
        return $matchedVerb
    }
}

function Get-WordStartsWithVowel {
    [CmdletBinding()]
    param (
        $string
    )

    begin {
        $firstLetter = $string[0]
    }

    process {
        if (($firstLetter -eq 'a') -or ($firstLetter -eq 'e') -or ($firstLetter -eq 'i') -or ($firstLetter -eq 'o') -or ($firstLetter -eq 'u') -or ($firstLetter -eq 'y')){
            $startsWithVowel = $true
        } else {
            $startsWithVowel = $false
        }
    }

    end {
        return $startsWithVowel
    }
}

function Get-FunctionInformation {
    [CmdletBinding()]
    param (
        $CommandName
    )

    begin {
        $command = (Get-Command -Name $CommandName);
        $functionHelpParams = Get-Help $CommandName -Parameter *
        $functionMandatoryParams = $functionHelpParams | Where-Object {$_.required -eq $true}

    }

    process {
        $parameterList = New-Object System.Collections.ArrayList
        foreach ($item in $command.parameters.keys){
            if ($item -in $functionMandatoryParams.name){
                $parameterList.Add(
                    [PSCustomObject]@{
                        Name = $item;
                        Required = $true
                        ParameterSets = $command.parameters.$item.ParameterSets
                        ParameterType = $command.parameters.$item.ParameterType
                    }
                ) | Out-Null
            } else {
                $parameterList.Add(
                    [PSCustomObject]@{
                        Name = $item;
                        Required = $false
                        ParameterSets = $command.parameters.$item.ParameterSets
                        ParameterType = $command.parameters.$item.ParameterType
                    }
                ) | Out-Null
            }
        }
        $commandInfo = [PSCustomObject]@{
            parameterSets = $command.ParameterSets.Name
            parameters = $parameterList
        }
    }

    end {
        return $commandInfo
    }
}

foreach ($item in $functions){
    $functionName = $item.BaseName -replace ".ps1", ""
    $functionItem = [PSCustomObject]@{
        functionName = $functionName
        functionType = ($functionName -split ('-'))[0]
        functionBaseType = ($functionName -split ('-'))[1].Replace('JcSdk','')
        functionPath = $item.FullName
        examplePath = ($examples | Where-Object {$_.Name -eq "$($functionName).md"}).FullName
        functionInfo = Get-FunctionInformation -CommandName $functionName;
    }
    $list.Add($functionItem) | Out-Null
}


$outputList = New-Object System.Collections.Hashtable

foreach ($item in $list) {
    write-warning "Building SDK Documentation: $($item.functionName)"
    $outputList.add($item.functionName, (New-Object System.Collections.Hashtable))
    $paramInfo = New-Object system.Collections.ArrayList
    foreach ($set in $item.functionInfo.parameterSets | Where-Object {$_ -notmatch "ViaIdentity"}){
        # Write-Warning $set
        $setList = New-Object system.Collections.ArrayList
        $item.functionInfo.parameters.GetEnumerator() | ForEach-Object {
            $paramName = $_ | Where-Object {$_.ParameterSets.Keys -eq $set}
            if ($paramName){
                $setList.Add(
                    [PSCustomObject]@{
                        parameterName = $paramName.name
                        parameterValueType = $_.ParameterType
                        parameterMandatory = $_.Required
                    }
                ) | Out-Null
            }
        }
        $paramInfo.Add(
            [PSCustomObject]@{
                $set = $setList
            }
        ) | Out-Null

        # Build the example string for the set
        $string = "$($item.functionName)"
        # $descriptionString = "$($item.functionType) a $($item.functionBaseType) by"
        for ($i = 0; $i -lt $paramInfo.$Set.Count; $i++) {
            <# Action that will repeat until the condition is met #>
            if ($set -eq 'clear'){
                $paramText = $paramInfo[0].$Set[$i]
            } else {
                $paramText = $paramInfo.$Set[$i]
            }
            if ($paramText.ParameterName) {
                $string += " -$($paramText.ParameterName):(<$($($paramText.parameterValueType))>)"
            }
        }
        # replace internal model name with non-internal model that can be publically used
        $string = $string.Replace('.Models.I', '.Models.')
        switch ($set) {
            'List' {
                $descriptionString = "List $($item.functionBaseType)s"
            }
            Default {
                # an vs a
                $vowel = Get-WordStartsWithVowel $($item.functionBaseType)
                switch ($vowel) {
                    $true { $a_an = "an" }
                    $false { $a_an = "a" }
                }
                $descriptionVerb = get-verb "$($item.functionType)"
                $descriptionString = "$descriptionVerb $a_an $($item.functionBaseType)"
                if ($set -eq 'clear'){
                    $paramText = $paramInfo[0].$Set | Where-Object {$_.parameterMandatory -eq $true}
                } else {
                    $paramText = $paramInfo.$Set | Where-Object {$_.parameterMandatory -eq $true}
                }
                $ParamTextlist = $($paramText.parameterName)
                if ($ParamTextlist.count -eq 1){
                    $descriptionString += " by $ParamTextlist"
                } else {
                    $descriptionString += " by"
                    for ($i = 0; $i -lt $ParamTextlist.Count; $i++) {
                        <# Action that will repeat until the condition is met #>
                        if ($i+1 -eq $ParamTextlist.Count){
                            $descriptionString += " and $($ParamTextlist[$i])"

                        } else {
                            $descriptionString += " $($ParamTextlist[$i]),"
                        }
                    }

                }
            }
        }
        # add the example to the $outputlist variable
        $outputList["$($item.functionName)"].add($set,[PSCustomObject]@{
            example = $string;
            description = "$($descriptionString)";
        })
    }
}

# Write the examples
foreach ($item in $list){
    $functionExamples = $outputList["$($item.functionName)"]

    # Get the content of the example file:
    $exampleContent = Get-Content $item.examplePath -Raw
    # Set Names
    $setList = New-Object System.Collections.ArrayList
    $setNames = $functionExamples.getEnumerator().name
    foreach ($set in $setNames){
        $setLIst.Add($set) | Out-Null
    }

    If ($setLIst.count -eq 1) {
        $array = New-Object System.Collections.ArrayList
        $array.add($setLIst) | Out-Null
        $setLIst = $array
    }

    for ($i = 0; $i -lt $setList.Count; $i++) {
        # TODO: figure out cases with > 2 sets
        <# Action that will repeat until the condition is met #>
        if ($exampleContent -match "\#\#\# Example $($i+1): {{ Add title here }}") {
            $exampleContent = $exampleContent.replace("### Example $($i+1): {{ Add title here }}", "### Example $($i+1): $((invoke-expression -command ('$functionexamples.' + $setList[$i])).description)")

            $exampleRegex = [regex]"### Example $($i+1)[\s\S]*?(?={{ Add description here }})"
            $cc = $exampleContent | Select-String -Pattern $exampleRegex
            # content to edit:
            $ContentToEdit = $cc.Matches.Value
            $ReplacedContent = $ContentToEdit -replace ("{{ Add code here }}", $((invoke-expression -command ('$functionexamples.' + $setList[$i])).example))
            # update example:
            $currentContent = Get-Content -Path $item.examplePath -Raw
            $currentContent -replace ($exampleRegex, $ReplacedContent) | Set-Content -Path $item.examplePath -NoNewline -Force

        }
    }
}