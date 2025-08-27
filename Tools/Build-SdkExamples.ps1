[CmdletBinding()]
param (
    [Parameter(Mandatory, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()]
    [System.String[]]
    $SDKName
)
$rootPath = "$PSScriptRoot/../"
# examples:
$examples = Get-ChildItem -Path "$rootPath/SDKs/PowerShell/$SDKName/examples" -Filter "*.md"
$functions = Get-ChildItem -Path "$rootPath/SDKs/PowerShell/$SDKName/custom/generated" -Filter "*.ps1"
Import-Module "$rootPath/SDKs/PowerShell/$SDKName/$SDKName.psd1" -Force
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

        # account for clear type verb actions:
        if ($item.functionType -eq "Clear"){
            # find the clear item, so it's not using the default .clear method when we call it
            for ($i = 0; $i -lt $paramInfo.Count; $i++) {
                <# Action that will repeat until the condition is met #>
                if ($paramInfo[$i].Clear){
                    $clearNum = $i
                }
            }
            $parmSetCount = $paramInfo[$clearNum].$Set.Count
        } else {
            $parmSetCount = $paramInfo.$Set.Count
        }
        # $descriptionString = "$($item.functionType) a $($item.functionBaseType) by"

        for ($i = 0; $i -lt $parmSetCount; $i++) {
            <# Action that will repeat until the condition is met #>
            if ($set -eq 'clear'){
                $paramText = $paramInfo[$clearNum].$Set[$i]
            } else {
                $paramText = $paramInfo.$Set[$i]
            }
            if ($paramText.ParameterName) {
                $string += " -$($paramText.ParameterName):(<$($($paramText.parameterValueType))>)"
            }
        }
        # replace internal model name with non-internal model that can be publicly used
        $string = $string.Replace('.Models.I', '.Models.')
        switch ($set) {
            'List' {
                $descriptionString = "List $($item.functionBaseType)s"
                $deatiledDescriptionString = "This function will return a list of all $($item.functionBaseType)s."
                $optionalParams = ($paramInfo.$Set | Where-Object {$_.parameterMandatory -eq $false}).parameterName
                if ($optionalParams.count -eq 1){
                    $deatiledDescriptionString += " $optionalParams is an optional parameter."
                } else {
                    for ($i = 0; $i -lt $optionalParams.Count; $i++) {
                        <# Action that will repeat until the condition is met #>
                        if ($i+1 -eq $optionalParams.Count){
                            $deatiledDescriptionString += " and $($optionalParams[$i]) are optional parameters."

                        } else {
                            $deatiledDescriptionString += " $($optionalParams[$i]),"
                        }
                    }

                }
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
                $deatiledDescriptionString = "This function will $descriptionVerb $a_an $($item.functionBaseType)"
                if ($set -eq 'clear'){
                    $paramText = $paramInfo[$clearNum].$Set | Where-Object {$_.parameterMandatory -eq $true}
                } else {
                    $paramText = $paramInfo.$Set | Where-Object {$_.parameterMandatory -eq $true}
                }
                $ParamTextlist = $($paramText.parameterName)
                if ($ParamTextlist.count -eq 1){
                    $descriptionString += " by $ParamTextlist"
                    $deatiledDescriptionString += " by $ParamTextlist. $ParamTextlist is a required parameter."
                } else {
                    $descriptionString += " by"
                    $deatiledDescriptionString += " by $ParamTextlist."
                    for ($i = 0; $i -lt $ParamTextlist.Count; $i++) {
                        <# Action that will repeat until the condition is met #>
                        if ($i+1 -eq $ParamTextlist.Count){
                            $descriptionString += " and $($ParamTextlist[$i])"
                            $deatiledDescriptionString += " and $($ParamTextlist[$i]) are required parameters."

                        } else {
                            $descriptionString += " $($ParamTextlist[$i]),"
                            $deatiledDescriptionString += " $($ParamTextlist[$i]),"
                        }
                    }

                }
            }
        }
        # build the output string
        # get funcitonContent
        $functionContent = Get-Content $item.functionPath -raw
        $outputRegex = [regex]"(?<=\.Outputs)([\s\S])*?(?=.Notes)"
        $outputRegex = [regex]"(?<=Outputs\n)JumpCloud\.SDK\..*"
        $functionOutputMatch = $functionContent | Select-String -Pattern $outputRegex -AllMatches
        if ($functionOutputMatch){
            $functionOutputModel = ($functionOutputMatch.Matches.Value).Replace('.Models.I', '.Models.')
            # $functionOutputModel

            # Write-Warning "$($item.functionName) model: $functionOutputModel"


            if ($functionOutputModel -match ".Models"){
                if ($functionOutputModel.count -gt 1){
                    $model = invoke-expression "[$($functionOutputModel[0])]::new()"
                } else {
                    $model = invoke-expression "[$($functionOutputModel)]::new()"
                }
                $modelProperties = $model | GM | Where-Object {$_.MemberType -eq 'property'}

                $out = $modelProperties | Select-Object name, Definition | Out-String

                # Replace definition text
                # replace name definition header
                $out = $out -replace ('Name.*Definition', '')
                # string
                $out = $out -replace ('string *.+', 'String')
                # int
                $out = $out -replace ('System.Nullable\[int\] *.+', 'Int')
                # boolean
                $out = $out -replace ('System.Nullable\[bool\] *.+', 'Boolean')
                # datetime
                $out = $out -replace ('System.Nullable\[datetime\] *.+', 'Datetime')
                # finally replace the models
                # remove values on end of strings
                $out = $out -replace ('(JumpCloud\.SDK[^\s]+) .*', '$1')
                # replace the .Models.I internal model def
                $out = $out -Replace ('(JumpCloud\.SDK..*.Models.)I', '$1')
            }
        } else {
            $out = $null
        }

        # build detailed description


        # add the example to the $outputlist variable
        $outputList["$($item.functionName)"].add($set,[PSCustomObject]@{
            example = $string;
            description = "$($descriptionString)";
            output = "$out"
            detailedDescription = $deatiledDescriptionString
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
            $exampleRegex = [regex]"### Example $($i+1)[\s\S]*?{{ Add description here }}"
            $cc = $exampleContent | Select-String -Pattern $exampleRegex
            # content to edit:
            $ContentToEdit = $cc.Matches.Value

            # update example content
            $ReplacedContent = $ContentToEdit -replace ("{{ Add code here }}", $((invoke-expression -command ('$functionexamples.' + $setList[$i])).example))
            # replace output
            if ($((invoke-expression -command ('$functionexamples.' + $setList[$i])).output)){
                $ReplacedContent = $ReplacedContent -replace ("{{ Add output here }}", $((invoke-expression -command ('$functionexamples.' + $setList[$i])).output))
            }
            else {
                $ReplacedContent = $ReplacedContent -replace ("{{ Add output here }}", "")
            }
            # replace detailed description
            $ReplacedContent = $ReplacedContent -replace ("{{ Add description here }}", $((invoke-expression -command ('$functionexamples.' + $setList[$i])).detailedDescription))
            # set the content
            $currentContent = Get-Content -Path $item.examplePath -Raw
            $currentContent -replace ($exampleRegex, $ReplacedContent) | Set-Content -Path $item.examplePath -NoNewline -Force
        }
    }
}