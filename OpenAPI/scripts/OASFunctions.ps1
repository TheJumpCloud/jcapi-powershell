#Requires -Modules powershell-yaml
Function Update-OasMapping {
    # Get the OAS Spec Files
    $OAS = Get-ChildItem -Path "$PSScriptRoot/../OAS" -Filter "*.json"

    # Loop through each OAS Spec File
    foreach ($oas in $OAS) {

        # Sorted List Variable to store the mappings
        $newOasSpec = [System.Collections.SortedList]::new()

        Write-Host "[status] Processing $($oas.FullName)"

        # Get the OAS Content and convert from json
        $oasContent = Get-Content -Path $oas.FullName | ConvertFrom-Json -Depth 99 -AsHashtable

        # Loop through the properties of the OAS Content
        $oasContent.paths.GetEnumerator() | ForEach-Object {
            $path = $_.Name
            $_.Value.GetEnumerator() | ForEach-Object {
                # Check if the method is a valid method (sometimes there are parameter values specified here - we do not need)
                if ($_.Name -notmatch 'get|put|post|delete|patch') {
                    return
                } else {
                    Write-Host "[status] Processing method $($_.Name) for operationId $($_.Value.operationId)"
                    $method = $_.Name
                    $operationId = $_.Value.operationId
                    if (!$_.Value.parameters) {
                        $paginate = $false
                    } else {
                        $parameters = $_.Value.parameters.GetEnumerator() | ForEach-Object {
                            $_.name
                        }
                        $paginate = [bool]($parameters -match 'limit|skip')
                    }

                    $newOasSpec.Add($operationId, @{
                        "path" = $path
                        "method" = $method
                        "x-powershell-method-name" = ""
                        "paginate" = $paginate
                    })
                }
            }
        }

        $OasSpecFileName = [regex]::Match($oas.Name, 'SDK\.([^.]+)\.json').Groups[1].Value
        $OasMappingFileName = "OASMapping.$($OasSpecFileName).json"

        # Compare the newly created newOasSpec with existing mapping files, if they exist
        $existingMapping = Get-ChildItem -Path "$PSScriptRoot/../OAS/mapping" -Filter $OasMappingFileName
        if (!$existingMapping) {
            # The mapping does not exist - create mapping file.
            $newOasSpec | ConvertTo-Json -Depth 99 | Set-Content -Path "$PSScriptRoot/../OAS/mapping/$OasMappingFileName"
        } else {
            # The mapping files exists - compare the newly created newOasSpec with the existing mapping file and only add new operationIds to the newOasSpec file.
            $existingMappingContent = Get-Content -Path $existingMapping.FullName | ConvertFrom-Json -Depth 99 -AsHashtable
            $existingMappingContent.GetEnumerator() | ForEach-Object {
                if ($newOasSpec.Contains($_.Key)) {
                    Write-Verbose "[status] operationID: $($_.Key) already exists in mapping file - removing from new newOasSpec"
                    $newOasSpec.Remove($_.Key)
                }
            }
            # We need to concat $newOasSpec into existingMappingContent
            if ($newOasSpec.Count -gt 0) {
                Write-Host "[status] Added $($newOasSpec.Count) new operationIds to $($existingMapping.Name)"
                $newOasSpec.GetEnumerator() | ForEach-Object {
                    $existingMappingContent.Add($_.Key, $_.Value)
                }
                $existingMappingContent | ConvertTo-Json -Depth 99 | Set-Content -Path "$PSScriptRoot/../OAS/mapping/$OasMappingFileName"
            } else {
                Write-Host "[status] No new operationIds found in $($existingMapping.Name)"
            }
        }
    }
}

Function Get-OasFile {
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('DirectoryInsights', 'Console')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    )

    $SDKName | ForEach-Object {
        switch ($_) {
            'DirectoryInsights' {
                $oasURL = 'https://docs.jumpcloud.com/new/api/insights/directory/index.yaml'
            }
            'Console' {
                $oasURL = 'https://docs.jumpcloud.com/new/api/console/index.yaml'
            }
        }
        $oasContent = (Invoke-WebRequest -Uri $oasURL -Method Get).Content
        if ($null -eq $oasContent) {
            Write-Error "Failed to get OAS content from $oasURL"
            return
        } else {
            Write-Host "[status] Saving OAS content to $PSScriptRoot/../OAS/JumpCloud.SDK.$($_).json"
            $oasContent | ConvertFrom-Yaml -Ordered | ConvertTo-Json -Depth 99 | Set-Content -Path "$PSScriptRoot/../OAS/JumpCloud.SDK.$($_).json"
        }
    }
}
Function Add-OasMethodName {
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('DirectoryInsights', 'Console')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    )

    $SDKName | ForEach-Object {
        # Get the mapping file for the specified SDKName
        $mappingFile = Get-ChildItem -Path "$PSScriptRoot/../OAS/mapping" -Filter "OASMapping.$($SDKName).json"
        $mappingFileContent = Get-Content -Path $mappingFile.FullName | ConvertFrom-Json -Depth 99 -AsHashtable

        # Get the OAS Spec for the specified SDKName
        $oasSpecFile = Get-ChildItem -Path "$PSScriptRoot/../OAS" -Filter "JumpCloud.SDK.$SDKName.json"
        $oasSpecFileContent = Get-Content -Path $oasSpecFile.FullName | ConvertFrom-Json -Depth 99

        # Loop through the mapping file content and add the functionName to the OAS Spec
        $mappingFileContent.GetEnumerator() | ForEach-Object {
            $operationID = $_.Key
            $path = $_.Value.path
            $method = $_.Value.method
            $functionName = $_.Value.'x-powershell-method-name'

            # Check to see if the x-powershell-method-name already matches, if it doesn't change or add it to the OAS Spec
            if ($oasSpecFileContent.paths.$path.$method.'x-powershell-method-name' -ne $functionName) {
                Write-Host "[status] Adding x-powershell-method-name $functionName for $($operationID)"
                $oasSpecFileContent.paths.$path.$method | Add-Member -MemberType NoteProperty -Name 'x-powershell-method-name' -Value $functionName -Force
            } else {
                Write-Verbose "[status] x-powershell-method-name $functionName already exists for $($operationID)"
            }
        }

        # Save the updated OAS Spec
        $oasSpecFileContent | ConvertTo-Json -Depth 99 | Set-Content -Path $oasSpecFile.FullName
    }
}