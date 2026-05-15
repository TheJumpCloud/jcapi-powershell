Function Update-OasSpecMapping {
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

        # Compare the newly created newOasSpec with existing mapping files, if they exist
        $existingMapping = Get-ChildItem -Path "$PSScriptRoot/../OAS/mapping" -Filter "OASMapping.$($oas.Name)"
        if (!$existingMapping) {
            # The mapping does not exist - create mapping file.
            $newOasSpec | ConvertTo-Json -Depth 99 | Set-Content -Path "$PSScriptRoot/../OAS/mapping/OASMapping.$($oas.Name)"
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
                $existingMappingContent | ConvertTo-Json -Depth 99 | Set-Content -Path "$PSScriptRoot/../OAS/mapping/OASMapping.$($oas.Name)"
            } else {
                Write-Host "[status] No new operationIds found in $($existingMapping.Name)"
            }
        }
    }
}