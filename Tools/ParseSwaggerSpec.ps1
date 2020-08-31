Function Get-SwaggerItem($FilePath, $JsonPath)
{
    # Brake up parts of path to iterate through
    If ($JsonPath -match '#')
    {
        $JsonPath = $JsonPath.Replace('#', '')
    }
    $JsonPathDotSource = $JsonPath.Split('/') | Where-Object { $_ }
    # Get contents of swagger file
    $SwaggerJson = Get-Content -Path:($FilePath) -Raw
    $Swagger = $SwaggerJson | ConvertFrom-Json -Depth 99
    $Definition = $Swagger
    # Iterate through parts of the path and return the requested model
    $JsonPathDotSource | ForEach-Object {
        $Definition = $Definition.$_
    }
    Return $Definition
}
# Load swagger file
$SwaggerFilePath = '..\SwaggerSpecs\JumpCloud.SDK.V2.json'
$OutputObject = @()
$SwaggerJson = Get-Content -Path:($SwaggerFilePath) -Raw
$Swagger = $SwaggerJson | ConvertFrom-Json -Depth 99
# Parse swagger spec
$Paths = $Swagger.paths
$Paths.PSObject.Properties.Name | ForEach-Object {
    $PathName = $_
    $PathProperties = $Paths.$_
    $PathProperties.PSObject.Properties.Name | ForEach-Object {
        If ($_ -in ('delete', 'get', 'put', 'post', 'patch'))
        {
            $MethodName = $_
            $MethodProperties = $PathProperties.$_
            $operationId = $MethodProperties.operationId
            $AssociationEndpoints = $MethodProperties | Where-Object { $_.operationId -like '*Association*' `
                    -or $_.operationId -like '*Membership*' `
                    -or $_.operationId -like '*MemberOf*' `
                    -or $_.operationId -like '*Member*' `
                    -or $_.operationId -like '*Traverse*' }
            # $AssociationEndpoints = $MethodProperties | Where-Object { $_.operationId -like '*Set*Association*' }
            If ($AssociationEndpoints)
            {
                If ($MethodName -eq 'get')
                {
                    # Extract "op" parameter
                    $Targets = $AssociationEndpoints.parameters | Where-Object { $_.name -eq 'targets' }
                    $OutputObject += [PSCustomObject]@{
                        Path          = $PathName
                        Method        = $MethodName
                        operationId   = $operationId
                        ParameterName = $Targets.name
                        enum          = $Targets.items.enum
                    }
                }
                ElseIf ($MethodName -eq 'post')
                {
                    $EndpointParameters = Get-SwaggerItem -FilePath:($SwaggerFilePath) -JsonPath:($AssociationEndpoints.parameters.schema.'$ref')
                    $EndpointParametersProperties = $EndpointParameters.properties
                    # $EndpointParametersProperties.PSObject.Properties.Name | ForEach-Object {
                    #     $PropertyName = $_
                    #     # Extract all parameters with enum
                    #     If ($EndpointParametersProperties.$PropertyName.PSObject.Properties.Name | Where-Object { $_ -eq 'enum' })
                    #     {
                    #         # If ($EndpointParametersProperties.$PropertyName.PSObject.Properties.Name | Where-Object { $_ -in ('type', 'op') })
                    #         # {
                    #         $RecordObject = [PSCustomObject]@{
                    #             Path          = $PathName
                    #             Method        = $MethodName
                    #             operationId   = $operationId
                    #             ParameterName = $EndpointParametersProperties.PSObject.Properties.Name | Where-Object { $_ -eq $PropertyName }
                    #         }
                    #         $EnumValue = If ($EndpointParametersProperties.$PropertyName.PSObject.Properties.Name | Where-Object { $_ -eq '$ref' })
                    #         {
                    #             (Get-SwaggerItem -FilePath:($SwaggerFilePath) -JsonPath:($EndpointParametersProperties.$PropertyName.'$ref')).enum;
                    #         }
                    #         Else
                    #         {
                    #             $EndpointParametersProperties.$PropertyName.enum;
                    #         };
                    #         $RecordObject | Add-Member -MemberType:('NoteProperty') -Name:('enum') -Value:($EnumValue)
                    #         $OutputObject += $RecordObject
                    #         # }
                    #     }
                    # }
                    # Extract "op" parameter
                    $OutputObject += [PSCustomObject]@{
                        Path          = $PathName
                        Method        = $MethodName
                        operationId   = $operationId
                        ParameterName = $EndpointParametersProperties.PSObject.Properties.Name | Where-Object { $_ -eq 'op' }
                        enum          = $EndpointParametersProperties.op.enum
                    }
                    # Extract "type" parameter
                    $OutputObject += [PSCustomObject]@{
                        Path          = $PathName
                        Method        = $MethodName
                        operationId   = $operationId
                        ParameterName = $EndpointParametersProperties.PSObject.Properties.Name | Where-Object { $_ -eq 'type' }
                        enum          = If ($EndpointParametersProperties.type.PSObject.Properties.Name | Where-Object { $_ -eq '$ref' })
                        {
                            (Get-SwaggerItem -FilePath:($SwaggerFilePath) -JsonPath:($EndpointParametersProperties.type.'$ref')).enum;
                        }
                        Else
                        {
                            $EndpointParametersProperties.type.enum;
                        };
                    }
                }
                Else
                {
                    Write-Error ("Unknown method: $MethodName")
                }
            }
        }
        ElseIf ($_ -in ('parameters'))
        {
            # Need to document?
        }
        Else
        {
            Write-Error "Unknown child path property:$($_)"
        }
    }
}

# Export CSV
$AssociationCommands = $OutputObject | Select-Object -Property:*, `
@{Name = 'FunctionType'; Expression = { ($_.operationId | Select-String -Pattern:('(^.*?-)(.*?)(Association|Membership|Member|Traverse)(.*?$)')).Matches.Groups[2].Value } }, `
@{Name = 'FunctionTargetType'; Expression = { ($_.operationId | Select-String -Pattern:('(^.*?-)(.*?)(Traverse)(.*?$)')).Matches.Groups[4].Value } }
# # $AssociationCommands | ForEach-Object { $_.enum = $_.enum -join ', ' }
# # $AssociationCommands | Export-Csv -Path:('temp.csv') -Force

# Build list of types and target types from the SDK
$SDKOutputObject = @()
$AssociationCommands | Where-Object { $_.ParameterName -ne 'op' } | ForEach-Object {
    $Command = $_
    $Command.FunctionType = $Command.FunctionType.Replace('ActiveDirectory', 'active_directory').Replace('GSuite', 'g_suite').Replace('LdapServer', 'ldap_server').Replace('Office365', 'office_365').Replace('RadiusServer', 'radius_server').Replace('SystemGroup', 'system_group').Replace('UserGroup', 'user_group').ToLower()
    If ($Command.FunctionTargetType)
    {
        $Command.FunctionTargetType = $Command.FunctionTargetType.Replace('ActiveDirectory', 'active_directory').Replace('GSuite', 'g_suite').Replace('LdapServer', 'ldap_server').Replace('Office365', 'office_365').Replace('RadiusServer', 'radius_server').Replace('SystemGroup', 'system_group').Replace('UserGroup', 'user_group').ToLower()
    }
    If ($_.enum)
    {
        $_.enum | ForEach-Object {
            $SDKOutputObject += [PSCustomObject]@{
                Method     = $Command.Method
                Type       = $Command.FunctionType
                TargetType = $_
            }
        }
    }
    Else
    {
        $SDKOutputObject += [PSCustomObject]@{
            Method     = $Command.Method
            Type       = $Command.FunctionType
            TargetType = $Command.FunctionTargetType
        }
    }
}
$SDKOutputObject | Select-Object -Unique Type, TargetType | Sort-Object Type, TargetType | Export-Csv -Path:('Combos-SDK.csv') -Force

# # Build list of types and target types from the JumpCloud module
# $PSModuleOutputObject = @()
# $JCTypePath = '\support\PowerShell\JumpCloud Module\Private\NestedFunctions\JCTypes.json'
# $JCTypes = Get-Content -Path:($JCTypePath) -Raw | ConvertFrom-Json -Depth:99
# ForEach ($JCType In $JCTypes | Where-Object { $_.Category -eq 'JumpCloud' })
# {
#     $JCType.Targets.TargetSingular | ForEach-Object {
#         $PSModuleOutputObject += [PSCustomObject]@{
#             Method     = $null
#             Type       = $JCType.TypeName.TypeNameSingular
#             TargetType = $_
#         }
#     }
# }
# $PSModuleOutputObject | Select-Object -Unique Type, TargetType | Sort-Object Type, TargetType | Export-Csv -Path:('Combos-PSModule.csv') -Force

# # Update JCTypes from SDK function names
# $JCTypePath = '\support\PowerShell\JumpCloud Module\Private\NestedFunctions\JCTypes.json'
# $JCType = Get-Content -Path:($JCTypePath) -Raw | ConvertFrom-Json -Depth:99
# $JCType | ForEach-Object {
#     $_.PSObject.Properties.Remove('Targets')
#     $_.PSObject.Properties.Remove('TargetsExcluded')
#     $_ | Add-Member -MemberType:('NoteProperty') -Name:('Targets') -Value:(@())
# }
# ForEach ($SDKOutputRecord In $SDKOutputObject)
# {
#     $JCType | Where-Object { $_.TypeName.TypeNameSingular -eq $SDKOutputRecord.Type } | ForEach-Object {
#         $_.Targets += [PSCustomObject]@{
#             TargetSingular = $SDKOutputRecord.TargetType
#             TargetPlural   = ($JCType.TypeName | Where-Object { $_.TypeNameSingular -eq $SDKOutputRecord.TargetType } ).TypeNamePlural
#         }
#     }
# }
# $JCType | ConvertTo-Json -Depth:99 | Out-File -FilePath:($JCTypePath) -Force
