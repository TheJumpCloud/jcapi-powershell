#Requires -Modules powershell-yaml

Function Resolve-OasRef {
    <#
    .SYNOPSIS
        Resolves a local OpenAPI $ref (e.g. #/components/schemas/EventQuery) against the root document.
    #>
    Param(
        [Parameter(Mandatory)][hashtable]$OasRoot,
        [Parameter(Mandatory)][AllowNull()][object]$Node
    )

    if ($null -eq $Node) { return $null }
    if ($Node -isnot [System.Collections.IDictionary]) { return $Node }
    if (-not $Node.ContainsKey('$ref') -or [string]::IsNullOrWhiteSpace([string]$Node['$ref'])) {
        return $Node
    }

    $ref = [string]$Node['$ref']
    if ($ref -notmatch '^#/(?<path>.+)$') {
        Write-Warning "Unsupported external or non-local `$ref: $ref"
        return $Node
    }

    $current = $OasRoot
    foreach ($segment in ($Matches['path'] -split '/')) {
        $decoded = [uri]::UnescapeDataString($segment)
        if ($null -eq $current -or -not ($current -is [System.Collections.IDictionary]) -or -not $current.ContainsKey($decoded)) {
            Write-Warning "Unable to resolve `$ref: $ref"
            return $Node
        }
        $current = $current[$decoded]
    }
    return $current
}

Function Get-OasSchemaPropertyNames {
    <#
    .SYNOPSIS
        Collects property names from a schema, including allOf / oneOf / anyOf and $ref targets.
    #>
    Param(
        [Parameter(Mandatory)][hashtable]$OasRoot,
        [Parameter(Mandatory)][AllowNull()][object]$Schema,
        [System.Collections.Generic.HashSet[string]]$Visited = $null
    )

    if ($null -eq $Visited) {
        $Visited = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    }

    $names = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    if ($null -eq $Schema) { return $names }

    if ($Schema -is [System.Collections.IDictionary] -and $Schema.ContainsKey('$ref') -and -not [string]::IsNullOrWhiteSpace([string]$Schema['$ref'])) {
        $ref = [string]$Schema['$ref']
        if (-not $Visited.Add($ref)) { return $names }
        $resolved = Resolve-OasRef -OasRoot $OasRoot -Node $Schema
        foreach ($name in (Get-OasSchemaPropertyNames -OasRoot $OasRoot -Schema $resolved -Visited $Visited)) {
            [void]$names.Add($name)
        }
        return $names
    }

    if ($Schema -isnot [System.Collections.IDictionary]) { return $names }

    if ($Schema.ContainsKey('properties') -and $Schema['properties'] -is [System.Collections.IDictionary]) {
        foreach ($propName in $Schema['properties'].Keys) {
            [void]$names.Add([string]$propName)
        }
    }

    foreach ($combiner in @('allOf', 'oneOf', 'anyOf')) {
        if (-not $Schema.ContainsKey($combiner) -or $null -eq $Schema[$combiner]) { continue }
        foreach ($subSchema in @($Schema[$combiner])) {
            foreach ($name in (Get-OasSchemaPropertyNames -OasRoot $OasRoot -Schema $subSchema -Visited $Visited)) {
                [void]$names.Add($name)
            }
        }
    }

    return $names
}

Function Test-OasOperationHasPagination {
    <#
    .SYNOPSIS
        Returns $true when the operation exposes skip or limit (query/path/header params or request body schema properties).
    #>
    Param(
        [Parameter(Mandatory)][hashtable]$OasRoot,
        [Parameter(Mandatory)][hashtable]$Operation
    )

    $paginationNames = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::OrdinalIgnoreCase)
    foreach ($n in @('skip', 'limit')) { [void]$paginationNames.Add($n) }

    # Operation-level and path-level parameters (caller may merge path params into the operation before calling)
    if ($Operation.ContainsKey('parameters') -and $null -ne $Operation['parameters']) {
        foreach ($param in @($Operation['parameters'])) {
            $resolvedParam = Resolve-OasRef -OasRoot $OasRoot -Node $param
            if ($resolvedParam -is [System.Collections.IDictionary] -and $resolvedParam.ContainsKey('name')) {
                if ($paginationNames.Contains([string]$resolvedParam['name'])) {
                    return $true
                }
            }
        }
    }

    # Request body schema properties (common for Directory Insights EventQuery)
    if ($Operation.ContainsKey('requestBody') -and $null -ne $Operation['requestBody']) {
        $requestBody = Resolve-OasRef -OasRoot $OasRoot -Node $Operation['requestBody']
        if ($requestBody -is [System.Collections.IDictionary] -and $requestBody.ContainsKey('content') -and $requestBody['content'] -is [System.Collections.IDictionary]) {
            foreach ($mediaType in $requestBody['content'].Values) {
                if ($mediaType -isnot [System.Collections.IDictionary] -or -not $mediaType.ContainsKey('schema')) { continue }
                $propertyNames = Get-OasSchemaPropertyNames -OasRoot $OasRoot -Schema $mediaType['schema']
                foreach ($name in $propertyNames) {
                    if ($paginationNames.Contains($name)) {
                        return $true
                    }
                }
            }
        }
    }

    return $false
}

Function Update-OasMapping {
    $scriptsRoot = if (-not [string]::IsNullOrWhiteSpace($PSScriptRoot)) {
        $PSScriptRoot
    } else {
        Split-Path -Parent $MyInvocation.MyCommand.Path
    }
    $oasDir = Join-Path $scriptsRoot '../OAS'
    $mappingDir = Join-Path $oasDir 'mapping'

    if (-not (Test-Path -LiteralPath $mappingDir)) {
        New-Item -Path $mappingDir -ItemType Directory | Out-Null
    }

    # Get the OAS Spec Files
    $OAS = Get-ChildItem -Path $oasDir -Filter 'JumpCloud.SDK.*.json'

    # Loop through each OAS Spec File
    foreach ($oas in $OAS) {

        # Sorted List Variable to store the mappings
        $newOasSpec = [System.Collections.SortedList]::new()

        Write-Host "[status] Processing $($oas.FullName)"

        # Get the OAS Content and convert from json
        $oasContent = Get-Content -Path $oas.FullName -Raw | ConvertFrom-Json -Depth 99 -AsHashtable

        # Loop through the properties of the OAS Content
        $oasContent.paths.GetEnumerator() | ForEach-Object {
            $path = $_.Name
            $pathItem = $_.Value
            $pathParameters = @()
            if ($pathItem -is [System.Collections.IDictionary] -and $pathItem.ContainsKey('parameters') -and $null -ne $pathItem['parameters']) {
                $pathParameters = @($pathItem['parameters'])
            }

            $pathItem.GetEnumerator() | ForEach-Object {
                # Check if the method is a valid method (sometimes there are parameter values specified here - we do not need)
                if ($_.Name -notmatch '^(get|put|post|delete|patch)$') {
                    return
                }

                Write-Host "[status] Processing method $($_.Name) for operationId $($_.Value.operationId)"
                $method = $_.Name
                $operationId = $_.Value.operationId
                $operation = $_.Value

                # Merge path-level parameters into a shallow copy used only for pagination detection
                $operationForPagination = @{}
                foreach ($key in $operation.Keys) {
                    $operationForPagination[$key] = $operation[$key]
                }
                $opParams = @()
                if ($operation.ContainsKey('parameters') -and $null -ne $operation['parameters']) {
                    $opParams += @($operation['parameters'])
                }
                $opParams += $pathParameters
                $operationForPagination['parameters'] = $opParams

                $paginate = Test-OasOperationHasPagination -OasRoot $oasContent -Operation $operationForPagination
                Write-Verbose "[status] operationId $operationId paginate=$paginate"

                $newOasSpec.Add($operationId, @{
                        'path'                     = $path
                        'method'                   = $method
                        'x-powershell-method-name' = ''
                        'paginate'                 = $paginate
                    })
            }
        }

        $OasSpecFileName = [regex]::Match($oas.Name, 'SDK\.([^.]+)\.json').Groups[1].Value
        $OasMappingFileName = "OASMapping.$($OasSpecFileName).json"
        $mappingOutputPath = Join-Path $mappingDir $OasMappingFileName

        # Compare the newly created newOasSpec with existing mapping files, if they exist
        $existingMapping = Get-ChildItem -Path $mappingDir -Filter $OasMappingFileName -ErrorAction SilentlyContinue
        if (!$existingMapping) {
            # The mapping does not exist - create mapping file.
            Write-Host "[status] Creating mapping file $OasMappingFileName"
            $newOasSpec | ConvertTo-Json -Depth 99 | Set-Content -Path $mappingOutputPath
        } else {
            # Preserve existing method names; sync path/method/paginate from the OAS; add new operationIds;
            # remove operationIds that no longer exist in the OAS.
            $existingMappingContent = Get-Content -Path $existingMapping.FullName -Raw | ConvertFrom-Json -Depth 99 -AsHashtable
            $added = 0
            $updatedPaginate = 0
            $updatedMeta = 0
            $removed = 0

            $newOasSpec.GetEnumerator() | ForEach-Object {
                $operationId = $_.Key
                $fresh = $_.Value
                if ($existingMappingContent.Contains($operationId)) {
                    $existing = $existingMappingContent[$operationId]
                    # Keep manually assigned PowerShell method names
                    if ($existing.ContainsKey('x-powershell-method-name') -and -not [string]::IsNullOrWhiteSpace([string]$existing['x-powershell-method-name'])) {
                        $fresh['x-powershell-method-name'] = $existing['x-powershell-method-name']
                    }
                    if ([bool]$existing['paginate'] -ne [bool]$fresh['paginate']) {
                        Write-Host "[status] Updating paginate for $operationId : $($existing['paginate']) -> $($fresh['paginate'])"
                        $updatedPaginate++
                    }
                    if ([string]$existing['path'] -ne [string]$fresh['path'] -or [string]$existing['method'] -ne [string]$fresh['method']) {
                        Write-Host "[status] Updating path/method for $operationId"
                        $updatedMeta++
                    }
                    $existingMappingContent[$operationId] = $fresh
                } else {
                    Write-Host "[status] Adding new operationId $operationId (paginate=$($fresh['paginate']))"
                    $existingMappingContent.Add($operationId, $fresh)
                    $added++
                }
            }

            @($existingMappingContent.Keys) | ForEach-Object {
                if (-not $newOasSpec.Contains($_)) {
                    Write-Host "[status] Removing stale operationId $_"
                    $existingMappingContent.Remove($_)
                    $removed++
                }
            }

            if ($added -gt 0 -or $updatedPaginate -gt 0 -or $updatedMeta -gt 0 -or $removed -gt 0) {
                Write-Host "[status] Wrote $OasMappingFileName (added=$added, paginateUpdated=$updatedPaginate, metaUpdated=$updatedMeta, removed=$removed)"
                $existingMappingContent | ConvertTo-Json -Depth 99 | Set-Content -Path $mappingOutputPath
            } else {
                Write-Host "[status] No mapping changes for $($existingMapping.Name)"
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