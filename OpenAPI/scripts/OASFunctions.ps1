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
        $oasContent = Get-Content -Path $oas.FullName | ConvertFrom-Json -Depth 99

        # Loop through the properties of the OAS Content
        $oasContent.paths.PSObject.Properties | ForEach-Object {
            $path = $_.Name
            $_.Value.PSObject.Properties | ForEach-Object {
                # Check if the method is a valid method (sometimes there are parameter values specified here - we do not need)
                if ($_.Name -notmatch 'get|put|post|delete|patch') {
                    return
                } else {
                    Write-Verbose "[status] Processing method $($_.Name) for operationId $($_.Value.operationId)"
                    $method = $_.Name
                    $operationId = $_.Value.operationId
                    $newOasSpec.Add($operationId, @{
                        "path" = $path
                        "method" = $method
                        "x-powershell-method-name" = ""
                        "paginate" = if ($method -eq "get") { $true } else { $false }
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
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('DirectoryInsights', 'V1', 'V2')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    )

    $SDKName | ForEach-Object {
        switch ($_) {
            'DirectoryInsights' {
                $oasURL = 'https://docs.jumpcloud.com/api/insights/directory/1.0/index.yaml'
            }
            'V1' {
                $oasURL = 'https://docs.jumpcloud.com/api/1.0/index.yaml'
            }
            'V2' {
                $oasURL = 'https://docs.jumpcloud.com/api/2.0/index.yaml'
            }
        }
        $oasContent = (Invoke-WebRequest -Uri $oasURL -Method Get).Content
        if ($oasContent -eq $null) {
            Write-Error "Failed to get OAS content from $oasURL"
            return
        } else {
            Write-Host "[status] Saving OAS content to $PSScriptRoot/../OAS/JumpCloud.SDK.$($_).json"
            $oasContent | ConvertFrom-Yaml -Ordered | ConvertTo-Json -Depth 99 | Set-Content -Path "$PSScriptRoot/../OAS/JumpCloud.SDK.$($_).json"
        }
    }
}
}