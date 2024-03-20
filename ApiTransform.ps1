#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
)
Set-Location $PSScriptRoot
# Config Status List (used to track new endpoints)
$configStatus = @()
$OutputFilePath = $PSScriptRoot + '/SwaggerSpecs'
# OperationId to Function name mapping - https://github.com/Azure/autorest.powershell/blob/a530bd721c9326a4356fba15638fee236722aca9/powershell/autorest-configuration.md
$TransformConfig = [Ordered]@{
    'JumpCloud.SDK.DirectoryInsights' = [PSCustomObject]@{
        PublicUrl          = "https://docs.jumpcloud.com/api/insights/directory/1.0/index.yaml"
        FindAndReplace     = [Ordered]@{
            '"name":"\w+Body","in":"body"'                                                                                                                                                  = '"name":"body","in":"body"' # Across our APIs the standard is using "body" for the name of the body
            '"search_after":{"description":"Specific query to search after, see x-\* response headers for next values","type":"array","items":{"type":"object"},"x-go-name":"SearchAfter"}' = '"search_after":{"description":"Specific query to search after, see x-* response headers for next values","type":"array","items":{"type":"string"},"x-go-name":"SearchAfter"}';
            '"enum":\["CREATED_AT","EXPIRATION","REQUESTER_EMAIL","STATUS","TYPE","UPDATED_AT","-CREATED_AT","-EXPIRATION","-REQUESTER_EMAIL","-STATUS","-TYPE","-UPDATED_AT"\]'            = '"enum":["CREATED_AT","EXPIRATION","REQUESTER_EMAIL","STATUS","TYPE","UPDATED_AT"]'
        };
        OperationIdMapping = [Ordered]@{
            'directoryInsights_eventsCountPost'    = 'EventCount_Get';
            'directoryInsights_eventsDistinctPost' = 'EventDistinct_Get';
            'directoryInsights_eventsIntervalPost' = 'EventInterval_Get';
            'directoryInsights_eventsPost'         = 'Event_Get';
        };
        ExcludedList       = @();
    }
    'JumpCloud.SDK.V1'                = [PSCustomObject]@{
        PublicUrl          = "https://docs.jumpcloud.com/api/1.0/index.yaml"
        FindAndReplace     = [Ordered]@{
            # Path Issues
            '"#\/definitions\/system"'                                                                                                                                                                                              = '"#/definitions/JcSystem"'; # error CS0426: The type name 'ComponentModel' does not exist in the type 'System'
            '"system":{"properties"'                                                                                                                                                                                                = '"JcSystem":{"properties"'; # error CS0426: The type name 'ComponentModel' does not exist in the type 'System'
            '"title":"System"'                                                                                                                                                                                                      = '"title":"JcSystem"'; # error CS0426: The type name 'ComponentModel' does not exist in the type 'System'
            # V1 Issues
            # Command Result Model for new search endpoint (incorrectly defined in swagger)
            # remove extra filter/ fields param for search endpoints
            '"operationId":"search_systemusers_post","parameters":\[{"in":"body","name":"body","schema":{"\$ref":"#\/definitions\/search"}}.*{"\$ref":"#\/definitions\/systemuserslist"}},"401":{"description":"Unauthorized"}},"security":\[{"x-api-key":\[\]}\],"summary":"Search System Users"'                                           = '"operationId":"search_systemusers_post","parameters":[{"in":"body","name":"body","schema":{"$ref":"#/definitions/search"}},{"$ref":"#/parameters/trait:limit:limit"},{"$ref":"#/parameters/trait:skip:skip"},{"$ref":"#/parameters/trait:multiTenantRequestHeaders:x-org-id"}],"responses":{"200":{"description":"OK","schema":{"$ref":"#/definitions/systemuserslist"}},"401":{"description":"Unauthorized"}},"security":[{"x-api-key":[]}],"summary":"Search System Users"'
            '"operationId":"search_commandresults_post","parameters":\[{"in":"body","name":"body","schema":{"\$ref":"#\/definitions\/search"}}.*{"\$ref":"#\/definitions\/commandresultslist"}}'                                     = '"operationId":"search_commandresults_post","parameters":[{"in":"body","name":"body","schema":{"$ref":"#/definitions/search"}},{"$ref":"#/parameters/trait:limit:limit"},{"$ref":"#/parameters/trait:skip:skip"},{"$ref":"#/parameters/trait:multiTenantRequestHeaders:x-org-id"}],"responses":{"200":{"description":"OK","schema":{"$ref":"#/definitions/commandresultslist"}}'
            '"operationId":"search_commands_post","parameters":\[{"in":"body","name":"body","schema":{"\$ref":"#\/definitions\/search"}}.*{"\$ref":"#\/definitions\/commandslist"}}'                                                 = '"operationId":"search_commands_post","parameters":[{"in":"body","name":"body","schema":{"$ref":"#/definitions/search"}},{"$ref":"#/parameters/trait:limit:limit"},{"$ref":"#/parameters/trait:skip:skip"},{"$ref":"#/parameters/trait:multiTenantRequestHeaders:x-org-id"}],"responses":{"200":{"description":"OK","schema":{"$ref":"#/definitions/commandslist"}}'
            '"operationId":"search_organizations_post","parameters":\[{"in":"body","name":"body","schema":{"\$ref":"#\/definitions\/search"}}.*{"\$ref":"#\/definitions\/organizationslist"}}'                                       = '"operationId":"search_organizations_post","parameters":[{"in":"body","name":"body","schema":{"$ref":"#/definitions/search"}},{"$ref":"#/parameters/trait:limit:limit"},{"$ref":"#/parameters/trait:skip:skip"},{"$ref":"#/parameters/trait:multiTenantRequestHeaders:x-org-id"}],"responses":{"200":{"description":"OK","schema":{"$ref":"#/definitions/organizationslist"}}'
            '"operationId":"search_systems_post","parameters":\[{"in":"body","name":"body","schema":{"\$ref":"#\/definitions\/search"}}.*{"\$ref":"#\/definitions\/systemslist"}},"401":{"description":"Unauthorized"}},"security":\[{"x-api-key":\[\]}\],"summary":"Search Systems"'                                                   = '"operationId":"search_systems_post","parameters":[{"in":"body","name":"body","schema":{"$ref":"#/definitions/search"}},{"$ref":"#/parameters/trait:limit:limit"},{"$ref":"#/parameters/trait:skip:skip"},{"$ref":"#/parameters/trait:multiTenantRequestHeaders:x-org-id"}],"responses":{"200":{"description":"OK","schema":{"$ref":"#/definitions/systemslist"}},"401":{"description":"Unauthorized"}},"security":[{"x-api-key":[]}],"summary":"Search Systems"'
            # new model commandresultssearchlist
            '"title":"CommandResultsList","type":"object"},"commandslist"'                                                                                                                                                          = '"title":"CommandResultsList","type":"object"},"commandresultssearchlist":{"properties":{"results":{"items":{"properties":{"_id":{"description":"The ID of the command result.","type":"string"},"command":{"description":"The command that was executed on the system.","type":"string"},"files":{"description":"An array of file ids that were included in the command","items":{"type":"string"},"type":"array"},"response":{"properties":{"data":{"properties":{"exitCode":{"description":"The stderr output from the command that ran.","type":"integer"},"output":{"description":"The output of the command that was executed.","type":"string"}},"type":"object"},"error":{"description":"The stderr output from the command that ran.","type":"string"},"id":{"description":"ID of the response.","type":"string"}},"type":"object"},"name":{"description":"The name of the command.","type":"string"},"requestTime":{"description":"The time (UTC) that the command was sent.","format":"date-time","type":"string"},"responseTime":{"description":"The time (UTC) that the command was completed.","format":"date-time","type":"string"},"sudo":{"description":"If the user had sudo rights.","type":"boolean"},"system":{"description":"The display name of the system the command was executed on.","type":"string"},"user":{"description":"The user the command ran as.","type":"string"},"workflowId":{"description":"The id for the command that ran on the system.","type":"string"},"workflowInstanceId":{"description":"The workflowInstanceId for the command that ran on the system.","type":"string"}},"type":"object"},"type":"array"},"totalCount":{"description":"The total number of command results.","type":"integer"}},"title":"CommandResultsSearchList","type":"object"},"commandslist"';
            # replace def commandresultslist with commandresultssearchlist
            '{"\$ref":"#\/definitions\/commandresultslist"}},"401":{"description":"Unauthorized"}},"security":\[{"x\-api-key":\[\]}\],"summary":"Search Commands Results"'                 = '{"$ref":"#/definitions/commandresultssearchlist"}},"401":{"description":"Unauthorized"}},"security":[{"x-api-key":[]}],"summary":"Search Commands Results"';
            # Command Result Model for Results by ID (system is erronelously recording systemID)
            # new model CommandResultByCommandID
            '"title":"CommandResult","type":"object"},"commandresultslist"'                                                                                                                                                         = '"title":"CommandResult","type":"object"},"commandresultbycommandid":{"properties":{"_id":{"description":"The ID of the command.","type":"string"},"command":{"description":"The command that was executed on the system.","type":"string"},"files":{"description":"An array of file ids that were included in the command","items":{"type":"string"},"type":"array"},"name":{"description":"The name of the command.","type":"string"},"organization":{"description":"The ID of the organization.","type":"string"},"requestTime":{"description":"The time that the command was sent.","format":"date-time","type":"string"},"response":{"properties":{"data":{"properties":{"exitCode":{"description":"The stderr output from the command that ran.","type":"integer"},"output":{"description":"The output of the command that was executed.","type":"string"}},"type":"object"},"error":{"description":"The stderr output from the command that ran.","type":"string"},"id":{"description":"ID of the response.","type":"string"}},"type":"object"},"responseTime":{"description":"The time that the command was completed.","format":"date-time","type":"string"},"sudo":{"description":"If the user had sudo rights","type":"boolean"},"system":{"description":"The name of the system the command was executed on.","type":"string"},"user":{"description":"The user the command ran as.","type":"string"},"workflowId":{"type":"string"},"workflowInstanceId":{"type":"string"}},"title":"CommandResultByCommandID","type":"object"},"commandresultslist"'
            # replace def commandresult with commandresultbycommandid in
            '{"\$ref":"#\/definitions\/commandresult"},"type":"array"}}},"security":\[{"x-api-key":\[\]}\],"summary":"Get results for a specific command"'                                                                          = '{"$ref":"#/definitions/commandresultbycommandid"},"type":"array"}}},"security":[{"x-api-key":[]}],"summary":"Get results for a specific command"'
            '\/systemuserputpost"}},{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"},{.*?"in":"query"'                                                                                                           = '/systemuserputpost"}},{"in":"query"' # Remove very large query description, it breaks Autorest's ability to build the parameter
            '\/systemuserput"}},{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"},{.*?"in":"query"'                                                                                                               = '/systemuserput"}},{"in":"query"' # Remove very large query description, it breaks Autorest's ability to build the parameter
            '"enrollmentType":{"enum":\["unknown","automated device","device","user"\],"type":"string"},"internal":{"properties":{"deviceId":{"type":"string"},"windowsDeviceId":{"type":"string"}},"type":"object"}'               = '' # error CS0262: Partial declarations of 'IJcSystemMdmInternal' have conflicting accessibility modifiers; error CS0535: 'JcSystemMdm' does not implement interface member 'IJcSystemMdmInternal.DeviceId'
            '"systems":{"description":"Not used. Use \/api\/v2\/commands\/{id}\/associations to bind commands to systems.","items":{"type":"string"},"type":"array"}'                                                               = '' # remove unused commands system param
            '"basePath":"\/api"'                                                                                                                                                                                                    = '"basePath":"/api/"'; # The extra slash at the end is needed to properly build the url.
            '"type":"null"'                                                                                                                                                                                                         = '"type":"string"'; # A type of null is not valid.
            '"type":\["object","null"\]'                                                                                                                                                                                                                                                               = '"type":"object"'
            '{"description":"This is an optional flag that can be enabled on the DELETE call.*?","in":"query","name":"cascade_manager".*?"}'                                                                                        = ''; # TODO: Add this back in eventually - fix to remove the cascade manager param from delete user (autorest thinks multiple matching 'break' parameters are declared in the delete function)
            '"produces":\["application\/json","text\/plain"\]'                                                                                                                                                                      = '';
            '"responses":{"200":{"description":"OK","schema":{"type":"string"}}'                                                                                                                                                    = '"responses":{"200":{"description":""}';
            '{"in":"body","name":"body","schema":{"additionalProperties":true,"type":"object"}}'                                                                                                                                    = ''; # Remove bodies that don't have parameters
            '"operationId":"systemusers_state_activate","parameters":\[{"in":"path","name":"id","required":true,"type":"string"},{"in":"body","name":"body","schema":{"properties":{"email":{"type":"object"}},"type":"object"}}\]' = '"operationId":"systemusers_state_activate","parameters":[{"in":"path","name":"id","required":true,"type":"string"},{"in":"body","name":"body","schema":{"properties":{"email":{"type":"string"}},"type":"object"}}]' # Flatten email type so we can just pass in Initialize-JcSdkUserState -email "alternateEmail@domain.com"
            # Filter Customizations (define filter as list not single string for V1)
            '"in":"query","name":"filter","type":"string"},"trait:limit:limit":'                                                                                                                                                    = '"in":"query","name":"filter","type":"array","items":{"type":"string"},"collectionFormat":"multi","x-ms-skip-url-encoding":true},"trait:limit:limit":'
            # Custom Tweaks
            '{"\$ref":"#\/parameters\/trait:systemContextAuth:Authorization"}'                                                                                                                                                      = ''; # We don't want to support authentication through system context via the SDK
            '{"\$ref":"#\/parameters\/trait:systemContextAuth:Date"}'                                                                                                                                                               = ''; # We don't want to support authentication through system context via the SDK
            '{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"}'                                                                                                                                                   = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            ',,'                                                                                                                                                                                                                    = ',';
            '\[,'                                                                                                                                                                                                                   = '[';
            ',]'                                                                                                                                                                                                                    = ']';
        };
        OverrideDefinitions = @(
            'definitions.application.properties.config'
        )
        OperationIdMapping = [Ordered]@{
            'admin_totpreset_begin'          = 'AdministratorUserTotp_Reset';
            'application_templates_get'      = 'ApplicationTemplate_Get';
            'application_templates_list'     = 'ApplicationTemplate_List';
            'applications_delete'            = 'Application_Delete';
            'applications_get'               = 'Application_Get';
            'applications_list'              = 'Application_List';
            'applications_post'              = 'Application_Create';
            'applications_put'               = 'Application_Set';
            'command_file_get'               = 'CommandFile_Get';
            'command_results_delete'         = 'CommandResult_Delete';
            'command_results_get'            = 'CommandResult_Get';
            'command_results_list'           = 'CommandResult_List';
            'command_trigger_webhook_post'   = 'CommandTrigger_POST';
            'commands_delete'                = 'Command_Delete';
            'commands_get'                   = 'Command_Get';
            'commands_getResults'            = 'CommandResultByCommandID_Get';
            'commands_list'                  = 'Command_List';
            'commands_post'                  = 'Command_Create';
            'commands_put'                   = 'Command_Set';
            'commands_run'                   = 'Commands_Run';
            'organization_list'              = 'Organization_List';
            'organization_put'               = 'Organization_Set';
            'organizations_get'              = 'Organization_Get';
            'radius_servers_delete'          = 'RadiusServer_Delete';
            'radius_servers_get'             = 'RadiusServer_Get';
            'radius_servers_list'            = 'RadiusServer_List';
            'radius_servers_post'            = 'RadiusServer_Create';
            'radius_servers_put'             = 'RadiusServer_Set';
            'search_commands_post'           = 'Commands_Search';
            'search_commandresults_post'     = 'CommandResult_Search';
            'search_organizations_post'      = 'Organization_Search';
            'search_systems_post'            = 'System_Search';
            'search_systemusers_post'        = 'User_Search';
            'sshkey_delete'                  = 'UserSshKey_Delete';
            'sshkey_list'                    = 'UserSshKey_Get';
            'sshkey_post'                    = 'UserSshKey_Create';
            'systems_commandBuiltinErase'    = 'System_Clear';
            'systems_commandBuiltinLock'     = 'System_Lock';
            'systems_commandBuiltinRestart'  = 'System_Restart';
            'systems_commandBuiltinShutdown' = 'System_Stop';
            'systems_delete'                 = 'System_Delete';
            'systems_get'                    = 'System_Get';
            'systems_list'                   = 'System_List';
            'systems_put'                    = 'System_Set';
            'systemusers_delete'             = 'User_Delete';
            'systemusers_expire'             = 'ExpireUserPassword_POST';
            'systemusers_get'                = 'User_Get';
            'systemusers_list'               = 'User_List';
            'systemusers_mfasync'            = 'UserMfa_Sync';
            'systemusers_post'               = 'User_Create';
            'systemusers_put'                = 'User_Set';
            'systemusers_resetmfa'           = 'UserMfa_Reset';
            'systemusers_state_activate'     = 'UserState_Activate';
            'systemusers_unlock'             = 'User_Unlock';
            'users_put'                      = 'AdministratorUser_Set';
            'users_reactivate_get'           = 'AdministratorUserActivation_Reset';
        };
        ExcludedList       = @(); # Excluding for now until we can resolve in SA-2316
    }
    'JumpCloud.SDK.V2'                = [PSCustomObject]@{
        PublicUrl          = "https://docs.jumpcloud.com/api/2.0/index.yaml"
        FindAndReplace     = [Ordered]@{
            # V2 Issues
            '"basePath":"\/api\/v2"'                                                                                                                                  = '"basePath":"/api/v2/"'; # The extra slash at the end is needed to properly build the url.
            '\["object","null"]'                                                                                                                                      = '"object"';
            'software-app-settings'                                                                                                                                   = 'SoftwareAppSettings'; # Error: Collision detected inserting into object: software-app-settings
            '"in":"body","name":"body","schema":{"\$ref":"#\/definitions\/CustomEmail"}'                                                                              = '"in":"body","name":"CustomEmail","schema":{"$ref":"#/definitions/CustomEmail"}'; # The type 'SetJcSdkInternalCustomEmailConfiguration_SetExpanded, SetJcSdkInternalCustomEmailConfiguration_SetViaIdentityExpanded, NewJcSdkInternalCustomEmailConfiguration_CreateExpanded' already contains a definition for 'Body'
            '"format":"uint32"'                                                                                                                                       = '"format":"int64"' # SI code uses uint32 which is larger than int32 . Swagger 2 doesnt have a concept of uint32 . AutoRest defaults to int32 when it sees a type of integer.
            '"produces":\["text\/html"\]'                                                                                                                             = '' # produces text/html is not valid, just remove
            # Filter Customizations (define filter as list)
            # Custom Tweaks
            '"operationId":"gsuites_listImportUsers","parameters":\[{"\$ref":"#\/parameters\/trait:limit:limit"},{"\$ref":"#\/parameters\/trait:gsuite:maxResults"},' = '"operationId":"gsuites_listImportUsers","parameters":[{"$ref":"#/parameters/trait:gsuite:maxResults"},' # Get-JCsdkGsuiteUsersToImport does not require a limit parameter
            '"responses":{"201":{"description":"","schema":{"\$ref":"#\/definitions\/job-id"}}'                                                                       = '"responses":{"200":{"description":"OK","schema":{"$ref":"#/definitions/job-id"}}'; # Workaround incorrectly defined 201 response in swagger should be 200; affects New-JcSdkBulkUser
            '{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"}'                                                                                     = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            # office365 readonly params:
            '"userLockoutAction":{"enum":\["suspend","maintain"\],"readOnly":true,"type":"string"},"userPasswordExpirationAction":{"enum":\["suspend","maintain"\],"readOnly":true,"type":"string"}' = '"userLockoutAction":{"enum":["suspend","maintain"],"type":"string"},"userPasswordExpirationAction":{"enum":["suspend","maintain"],"type":"string"}'
            ',,'                                                                                                                                                      = ',';
            '\[,'                                                                                                                                                     = '[';
            ',]'                                                                                                                                                      = ']';
            '"properties":{"conditions":{"description":.*?"type":"object"}'                                                                                           = '"properties":{"conditions":{"type":"object"}' # Parameter Description is declared in parameter-set 'createExpanded' multiple times in
        };
        OperationIdMapping = [Ordered]@{
            'activedirectories_agentsDelete'                    = 'ActiveDirectoryAgent_Delete';
            'activedirectories_agentsGet'                       = 'ActiveDirectoryAgent_Get';
            'activedirectories_agentsList'                      = 'ActiveDirectoryAgent_List';
            'activedirectories_agentsPost'                      = 'ActiveDirectoryAgent_Create';
            'activedirectories_delete'                          = 'ActiveDirectory_Delete';
            'activedirectories_get'                             = 'ActiveDirectory_Get';
            'activedirectories_list'                            = 'ActiveDirectory_List';
            'activedirectories_post'                            = 'ActiveDirectory_Create';
            'administratorOrganizations_createByAdministrator'  = 'AdministratorOrganization_Create';
            'administratorOrganizations_listByAdministrator'    = 'AdministratorOrganizations_List';
            'administratorOrganizations_listByOrganization'     = 'AdministratorOrganizationLinks_List';
            'administratorOrganizations_removeByAdministrator'  = 'AdministratorOrganization_Delete';
            'applemdms_delete'                                  = 'AppleMDM_Delete';
            'applemdms_deletedevice'                            = 'AppleMDMDevice_Delete'
            'applemdms_devicesClearActivationLock'              = 'AppleMDMDeviceActivationLock_Clear';
            'applemdms_devicesRefreshActivationLockInformation' = 'AppleMDMDeviceLockInformation_Refresh';
            'applemdms_deviceserase'                            = 'AppleMDMDevice_Clear';
            'applemdms_deviceslist'                             = 'AppleMDMDevice_List';
            'applemdms_deviceslock'                             = 'AppleMDMDevice_Lock';
            'applemdms_devicesrestart'                          = 'AppleMDMDevice_Restart';
            'applemdms_devicesshutdown'                         = 'AppleMDMDevice_Stop';
            'applemdms_enrollmentprofileslist'                  = 'AppleMDMEnrollmentProfile_List';
            'applemdms_getdevice'                               = 'AppleMDMDevice_Get';
            'applemdms_list'                                    = 'AppleMDM_List';
            'applemdms_put'                                     = 'AppleMDM_Set';
            'applemdms_refreshdepdevices'                       = 'AppleMDMDevice_Sync';
            'applications_deleteLogo'                           = 'ApplicationLogo_Delete';
            'authnpolicies_delete'                              = 'AuthenticationPolicy_Delete';
            'authnpolicies_get'                                 = 'AuthenticationPolicy_Get';
            'authnpolicies_list'                                = 'AuthenticationPolicy_List';
            'authnpolicies_patch'                               = 'AuthenticationPolicy_Update';
            'authnpolicies_post'                                = 'AuthenticationPolicy_Create';
            'bulk_userStatesCreate'                             = 'BulkUserState_Create';
            'bulk_userStatesDelete'                             = 'BulkUserState_Delete';
            'bulk_userStatesGetNextScheduled'                   = 'NextScheduledBulkUserState_Get';
            'bulk_userStatesList'                               = 'BulkUserStates_List';
            'bulk_usersCreate'                                  = 'BulkUsers_Create';
            'bulk_usersCreateResults'                           = 'BulkUsersResult_Get';
            'bulk_usersUpdate'                                  = 'BulkUsers_Update';
            'customEmails_create'                               = 'CustomEmailConfiguration_Create';
            'customEmails_destroy'                              = 'CustomEmailConfiguration_Delete';
            'customEmails_getTemplates'                         = 'CustomEmailTemplates_List';
            'customEmails_read'                                 = 'CustomEmailConfiguration_Get';
            'customEmails_update'                               = 'CustomEmailConfiguration_Set';
            'directories_list'                                  = 'Directory_List';
            'duo_accountDelete'                                 = 'DuoAccount_Delete';
            'duo_accountGet'                                    = 'DuoAccount_Get';
            'duo_accountList'                                   = 'DuoAccount_List';
            'duo_accountPost'                                   = 'DuoAccount_Create';
            'duo_applicationDelete'                             = 'DuoApplication_Delete';
            'duo_applicationGet'                                = 'DuoApplication_Get';
            'duo_applicationList'                               = 'DuoApplication_List';
            'duo_applicationPost'                               = 'DuoApplication_Create';
            'duo_applicationUpdate'                             = 'DuoApplication_Set';
            'graph_activeDirectoryAssociationsList'             = 'ActiveDirectoryAssociation_Get';
            'graph_activeDirectoryAssociationsPost'             = 'ActiveDirectoryAssociation_Set';
            'graph_activeDirectoryTraverseUser'                 = 'ActiveDirectoryTraverseUser_Get';
            'graph_activeDirectoryTraverseUserGroup'            = 'ActiveDirectoryTraverseUserGroup_Get';
            'graph_applicationAssociationsList'                 = 'ApplicationAssociation_Get';
            'graph_applicationAssociationsPost'                 = 'ApplicationAssociation_Set';
            'graph_applicationTraverseUser'                     = 'ApplicationTraverseUser_Get';
            'graph_applicationTraverseUserGroup'                = 'ApplicationTraverseUserGroup_Get';
            'graph_commandAssociationsList'                     = 'CommandAssociation_Get';
            'graph_commandAssociationsPost'                     = 'CommandAssociation_Set';
            'graph_commandTraverseSystem'                       = 'CommandTraverseSystem_Get';
            'graph_commandTraverseSystemGroup'                  = 'CommandTraverseSystemGroup_Get';
            'graph_gSuiteAssociationsList'                      = 'GSuiteAssociation_Get';
            'graph_gSuiteAssociationsPost'                      = 'GSuiteAssociation_Set';
            'graph_gSuiteTraverseUser'                          = 'GSuiteTraverseUser_Get';
            'graph_gSuiteTraverseUserGroup'                     = 'GSuiteTraverseUserGroup_Get';
            'graph_ldapServerAssociationsList'                  = 'LdapServerAssociation_Get';
            'graph_ldapServerAssociationsPost'                  = 'LdapServerAssociation_Set';
            'graph_ldapServerTraverseUser'                      = 'LdapServerTraverseUser_Get';
            'graph_ldapServerTraverseUserGroup'                 = 'LdapServerTraverseUserGroup_Get';
            'graph_office365AssociationsList'                   = 'Office365Association_Get';
            'graph_office365AssociationsPost'                   = 'Office365Association_Set';
            'graph_office365TraverseUser'                       = 'Office365TraverseUser_Get';
            'graph_office365TraverseUserGroup'                  = 'Office365TraverseUserGroup_Get';
            'graph_policyAssociationsList'                      = 'PolicyAssociation_Get';
            'graph_policyAssociationsPost'                      = 'PolicyAssociation_Set';
            'graph_policyGroupAssociationsList'                 = 'PolicyGroupAssociation_List';
            'graph_policyGroupAssociationsPost'                 = 'PolicyGroupAssociation_Set';
            'graph_policyGroupMembersList'                      = 'PolicyGroupMembers_List';
            'graph_policyGroupMembersPost'                      = 'PolicyGroupMembers_Set';
            'graph_policyGroupMembership'                       = 'PolicyGroupMembership_Get';
            'graph_policyGroupTraverseSystem'                   = 'PolicyGroupTraverseSystem_Get';
            'graph_policyGroupTraverseSystemGroup'              = 'PolicyGroupTraverseSystemGroup_Get';
            'graph_policyMemberOf'                              = 'PolicyGroupMember_Get';
            'graph_policyTraverseSystem'                        = 'PolicyTraverseSystem_Get';
            'graph_policyTraverseSystemGroup'                   = 'PolicyTraverseSystemGroup_Get';
            'graph_radiusServerAssociationsList'                = 'RadiusServerAssociation_Get';
            'graph_radiusServerAssociationsPost'                = 'RadiusServerAssociation_Set';
            'graph_radiusServerTraverseUser'                    = 'RadiusServerTraverseUser_Get';
            'graph_radiusServerTraverseUserGroup'               = 'RadiusServerTraverseUserGroup_Get';
            'graph_softwareappsAssociationsList'                = 'SoftwareAppAssociation_Get';
            'graph_softwareappsAssociationsPost'                = 'SoftwareAppAssociation_Set';
            'graph_softwareappsTraverseSystem'                  = 'SoftwareAppTraverseSystem_Get';
            'graph_softwareappsTraverseSystemGroup'             = 'SoftwareAppTraverseSystemGroup_Get';
            'graph_systemAssociationsList'                      = 'SystemAssociation_Get';
            'graph_systemAssociationsPost'                      = 'SystemAssociation_Set';
            'graph_systemGroupAssociationsList'                 = 'SystemGroupAssociation_Get';
            'graph_systemGroupAssociationsPost'                 = 'SystemGroupAssociation_Set';
            'graph_systemGroupMembersList'                      = 'SystemGroupMembers_Get';
            'graph_systemGroupMembersPost'                      = 'SystemGroupMembers_Set';
            'graph_systemGroupMembership'                       = 'SystemGroupMembership_Get';
            'graph_systemGroupTraverseCommand'                  = 'SystemGroupTraverseCommand_Get';
            'graph_systemGroupTraversePolicy'                   = 'SystemGroupTraversePolicy_Get';
            'graph_systemGroupTraversePolicyGroup'              = 'SystemGroupTraversePolicyGroup_Get';
            'graph_systemGroupTraverseUser'                     = 'SystemGroupTraverseUser_Get';
            'graph_systemGroupTraverseUserGroup'                = 'SystemGroupTraverseUserGroup_Get';
            'graph_systemMemberOf'                              = 'SystemMember_Get';
            'graph_systemTraverseCommand'                       = 'SystemTraverseCommand_Get';
            'graph_systemTraversePolicy'                        = 'SystemTraversePolicy_Get';
            'graph_systemTraversePolicyGroup'                   = 'SystemTraversePolicyGroup_Get';
            'graph_systemTraverseUser'                          = 'SystemTraverseUser_Get';
            'graph_systemTraverseUserGroup'                     = 'SystemTraverseUserGroup_Get';
            'graph_userAssociationsList'                        = 'UserAssociation_Get';
            'graph_userAssociationsPost'                        = 'UserAssociation_Set';
            'graph_userGroupAssociationsList'                   = 'UserGroupAssociation_Get';
            'graph_userGroupAssociationsPost'                   = 'UserGroupAssociation_Set';
            'graph_userGroupMembersList'                        = 'UserGroupMembers_Get';
            'graph_userGroupMembersPost'                        = 'UserGroupMembers_Set';
            'graph_userGroupMembership'                         = 'UserGroupMembership_Get';
            'graph_userGroupTraverseActiveDirectory'            = 'UserGroupTraverseActiveDirectory_Get';
            'graph_userGroupTraverseApplication'                = 'UserGroupTraverseApplication_Get';
            'graph_userGroupTraverseDirectory'                  = 'UserGroupTraverseDirectory_Get';
            'graph_userGroupTraverseGSuite'                     = 'UserGroupTraverseGSuite_Get';
            'graph_userGroupTraverseLdapServer'                 = 'UserGroupTraverseLdapServer_Get';
            'graph_userGroupTraverseOffice365'                  = 'UserGroupTraverseOffice365_Get';
            'graph_userGroupTraverseRadiusServer'               = 'UserGroupTraverseRadiusServer_Get';
            'graph_userGroupTraverseSystem'                     = 'UserGroupTraverseSystem_Get';
            'graph_userGroupTraverseSystemGroup'                = 'UserGroupTraverseSystemGroup_Get';
            'graph_userMemberOf'                                = 'UserMember_Get';
            'graph_userTraverseActiveDirectory'                 = 'UserTraverseActiveDirectory_Get';
            'graph_userTraverseApplication'                     = 'UserTraverseApplication_Get';
            'graph_userTraverseDirectory'                       = 'UserTraverseDirectory_Get';
            'graph_userTraverseGSuite'                          = 'UserTraverseGSuite_Get';
            'graph_userTraverseLdapServer'                      = 'UserTraverseLdapServer_Get';
            'graph_userTraverseOffice365'                       = 'UserTraverseOffice365_Get';
            'graph_userTraverseRadiusServer'                    = 'UserTraverseRadiusServer_Get';
            'graph_userTraverseSystem'                          = 'UserTraverseSystem_Get';
            'graph_userTraverseSystemGroup'                     = 'UserTraverseSystemGroup_Get';
            'groups_list'                                       = 'Group_List';
            'groups_policy_delete'                              = 'PolicyGroup_Delete';
            'groups_policy_get'                                 = 'PolicyGroup_Get';
            'groups_policy_list'                                = 'PolicyGroup_List';
            'groups_policy_post'                                = 'PolicyGroup_Create';
            'groups_policy_put'                                 = 'PolicyGroup_Set';
            'groups_system_delete'                              = 'SystemGroup_Delete';
            'groups_system_get'                                 = 'SystemGroup_Get';
            'groups_system_list'                                = 'SystemGroup_List';
            'groups_system_post'                                = 'SystemGroup_Create';
            'groups_system_put'                                 = 'SystemGroup_Set';
            'groups_user_delete'                                = 'UserGroup_Delete';
            'groups_user_get'                                   = 'UserGroup_Get';
            'groups_user_list'                                  = 'UserGroup_List';
            'groups_user_post'                                  = 'UserGroup_Create';
            'groups_user_put'                                   = 'UserGroup_Set';
            'gsuites_get'                                       = 'GSuite_Get';
            'gsuites_listImportUsers'                           = 'GSuiteUsersToImport_List';
            'gsuites_listImportJumpcloudUsers'                  = 'GsuiteUsersToImportFormatted_List'
            'gsuites_patch'                                     = 'GSuite_Update';
            'import_users'                                      = 'SCIM_Import';
            'iplists_delete'                                    = 'IpList_Delete';
            'iplists_get'                                       = 'IpList_Get';
            'iplists_list'                                      = 'IpList_List';
            'iplists_patch'                                     = 'IpList_Update';
            'iplists_post'                                      = 'IpList_Create';
            'iplists_put'                                       = 'IpList_Set';
            'ldapservers_get'                                   = 'LdapServer_Get';
            'ldapservers_list'                                  = 'LdapServer_List';
            'ldapservers_patch'                                 = 'LdapServer_Update';
            'ldapservers_sambaDomainsDelete'                    = 'LdapServerSambaDomain_Delete';
            'ldapservers_sambaDomainsGet'                       = 'LdapServerSambaDomain_Get';
            'ldapservers_sambaDomainsList'                      = 'LdapServerSambaDomain_List';
            'ldapservers_sambaDomainsPost'                      = 'LdapServerSambaDomain_Create';
            'ldapservers_sambaDomainsPut'                       = 'LdapServerSambaDomain_Set';
            'office365s_get'                                    = 'Office365_Get';
            'office365s_listImportUsers'                        = 'Office365UsersToImport_List';
            'office365s_patch'                                  = 'Office365_Update';
            'policies_delete'                                   = 'Policy_Delete';
            'policies_get'                                      = 'Policy_Get';
            'policies_list'                                     = 'Policy_List';
            'policies_post'                                     = 'Policy_Create';
            'policies_put'                                      = 'Policy_Set';
            'policyresults_get'                                 = 'PolicyResult_Get';
            'policyresults_list'                                = 'PolicyResult_List';
            'policyresults_org_list'                            = 'OrganizationPolicyResult_List';
            'policystatuses_policiesList'                       = 'PolicyStatus_List';
            'policystatuses_systemsList'                        = 'SystemPolicyStatus_List';
            'policytemplates_get'                               = 'PolicyTemplate_Get';
            'policytemplates_list'                              = 'PolicyTemplate_List';
            'providers_listAdministrators'                      = 'ProviderAdministrator_List';
            'providers_listOrganizations'                       = 'ProviderOrganizations_List';
            'providers_postAdmins'                              = 'ProviderAdministrator_Create';
            'providers_removeAdministrator'                     = 'ProviderAdministrator_Delete';
            'providers_retrieveInvoices'                        = 'ProvidersInvoices_Get'
            'pushEndpoints_delete'                              = 'UserPushEndpoint_Delete';
            'pushEndpoints_get'                                 = 'UserPushEndpoint_Get';
            'pushEndpoints_list'                                = 'UserPushEndpoints_List';
            'pushEndpoints_patch'                               = 'UserPushEndpoint_Update';
            'softwareAppStatuses_list'                          = 'SoftwareAppStatus_Get';
            'softwareApps_delete'                               = 'SoftwareApp_Delete';
            'softwareApps_get'                                  = 'SoftwareApp_Get';
            'softwareApps_list'                                 = 'SoftwareApp_List';
            'softwareApps_post'                                 = 'SoftwareApp_Create';
            'softwareApps_reclaimLicenses'                      = 'SoftwareAppLicenses_Reclaim';
            'softwareApps_update'                               = 'SoftwareApp_Set';
            'subscriptions_get'                                 = 'Subscription_Get';
            'systeminsights_list_alf'                           = 'SystemInsightAlf_List';
            'systeminsights_list_alf_exceptions'                = 'SystemInsightAlfException_List';
            'systeminsights_list_alf_explicit_auths'            = 'SystemInsightAlfExplicitAuth_List';
            'systeminsights_list_appcompat_shims'               = 'SystemInsightAppCompatShim_List';
            'systeminsights_list_apps'                          = 'SystemInsightApps_List';
            'systeminsights_list_authorized_keys'               = 'SystemInsightAuthorizedKey_List';
            'systeminsights_list_battery'                       = 'SystemInsightBattery_List';
            'systeminsights_list_bitlocker_info'                = 'SystemInsightBitlockerInfo_List';
            'systeminsights_list_browser_plugins'               = 'SystemInsightBrowserPlugins_List';
            'systeminsights_list_certificates'                  = 'SystemInsightCertificates_List';
            'systeminsights_list_chrome_extensions'             = 'SystemInsightChromeExtensions_List';
            'systeminsights_list_connectivity'                  = 'SystemInsightConnectivity_List';
            'systeminsights_list_crashes'                       = 'SystemInsightCrashes_List';
            'systeminsights_list_cups_destinations'             = 'SystemInsightCupDestination_List';
            'systeminsights_list_disk_encryption'               = 'SystemInsightDiskEncryption_List';
            'systeminsights_list_disk_info'                     = 'SystemInsightDiskInfo_List';
            'systeminsights_list_dns_resolvers'                 = 'SystemInsightDnsResolver_List';
            'systeminsights_list_etc_hosts'                     = 'SystemInsightEtcHosts_List';
            'systeminsights_list_firefox_addons'                = 'SystemInsightFirefoxAddons_List';
            'systeminsights_list_groups'                        = 'SystemInsightGroups_List';
            'systeminsights_list_ie_extensions'                 = 'SystemInsightIEExtensions_List';
            'systeminsights_list_interface_addresses'           = 'SystemInsightInterfaceAddresses_List';
            'systeminsights_list_interface_details'             = 'SystemInsightInterfaceDetails_List';
            'systeminsights_list_kernel_info'                   = 'SystemInsightKernelInfo_List';
            'systeminsights_list_launchd'                       = 'SystemInsightLaunchd_List';
            'systeminsights_list_logged_in_users'               = 'SystemInsightLoggedinUsers_List';
            'systeminsights_list_logical_drives'                = 'SystemInsightLogicalDrives_List';
            'systeminsights_list_managed_policies'              = 'SystemInsightManagedPolicies_List';
            'systeminsights_list_mounts'                        = 'SystemInsightMounts_List';
            'systeminsights_list_os_version'                    = 'SystemInsightOsVersion_List';
            'systeminsights_list_patches'                       = 'SystemInsightPatches_List';
            'systeminsights_list_programs'                      = 'SystemInsightPrograms_List';
            'systeminsights_list_python_packages'               = 'SystemInsightPythonPackages_List';
            'systeminsights_list_safari_extensions'             = 'SystemInsightSafariExtensions_List';
            'systeminsights_list_scheduled_tasks'               = 'SystemInsightScheduledTasks_List';
            'systeminsights_list_services'                      = 'SystemInsightServices_List';
            'systeminsights_list_shadow'                        = 'SystemInsightShadow_List';
            'systeminsights_list_shared_folders'                = 'SystemInsightSharedFolders_List';
            'systeminsights_list_shared_resources'              = 'SystemInsightSharedResources_List';
            'systeminsights_list_sharing_preferences'           = 'SystemInsightSharingPreferences_List';
            'systeminsights_list_sip_config'                    = 'SystemInsightSipConfig_List';
            'systeminsights_list_startup_items'                 = 'SystemInsightStartupItems_List';
            'systeminsights_list_system_controls'               = 'SystemInsightSystemControls_List';
            'systeminsights_list_system_info'                   = 'SystemInsightSystemInfo_List';
            'systeminsights_list_uptime'                        = 'SystemInsightUptime_List';
            'systeminsights_list_usb_devices'                   = 'SystemInsightUSBDevices_List';
            'systeminsights_list_user_groups'                   = 'SystemInsightUserGroups_List';
            'systeminsights_list_user_ssh_keys'                 = 'SystemInsightUserSSHKeys_List';
            'systeminsights_list_users'                         = 'SystemInsightUsers_List';
            'systeminsights_list_wifi_networks'                 = 'SystemInsightWifiNetwork_List';
            'systeminsights_list_wifi_status'                   = 'SystemInsightWifiStatus_List';
            'systeminsights_list_windows_security_products'     = 'SystemInsightWindowsSecurityProduct_List';
            'systeminsights_list_azure_instance_metadata'       = 'SystemInsightAzureInstanceMetadata_List'
            'systeminsights_list_azure_instance_tags'           = 'SystemInsightAzureInstanceTags_List'
            'systeminsights_list_chassis_info'                  = 'SystemInsightChassisInfo_List'
            'systeminsights_list_linux_packages'                = 'SystemInsightLinuxPackages_List'
            'systeminsights_list_secureboot'                    = 'SystemInsightSecureboot_List'
            'systeminsights_list_userassist'                    = 'SystemInsightUserAssist_List'
            'systeminsights_list_windows_security_center'       = 'SystemInsightWindowsSecurityCenter_List'
            'systeminsights_list_tpm_info'                      = 'SystemInsightTpmInfo_List'
            'systems_getFDEKey'                                 = 'SystemFDEKey_Get';
            'translationRules_gSuiteDelete'                     = 'GSuiteTranslationRule_Delete';
            'translationRules_gSuiteGet'                        = 'GSuiteTranslationRule_Get';
            'translationRules_gSuiteList'                       = 'GSuiteTranslationRule_List';
            'translationRules_gSuitePost'                       = 'GSuiteTranslationRule_Create';
            'translationRules_office365Delete'                  = 'Office365TranslationRule_Delete';
            'translationRules_office365Get'                     = 'Office365TranslationRule_Get';
            'translationRules_office365List'                    = 'Office365TranslationRule_List';
            'translationRules_office365Post'                    = 'Office365TranslationRule_Create';
            'workdays_authorize'                                = 'Workday_Authorize';
            'workdays_deauthorize'                              = 'WorkdayAuthorization_Delete';
            'workdays_get'                                      = 'Workday_Get';
            'workdays_import'                                   = 'Workday_Import';
            'workdays_importresults'                            = 'WorkdayResult_Import';
            'workdays_list'                                     = 'Workday_List';
            'workdays_post'                                     = 'Workday_Create';
            'workdays_put'                                      = 'Workday_Set';
            'workdays_workers'                                  = 'WorkdayWorker_Get';
        };
        ExcludedList       = @(
            # Excluded items are listed by Path and do not include opperation type (put, post, get, etc.)
            '/applemdms/{apple_mdm_id}/devices/{device_id}/osUpdateStatus',
            '/applemdms/{apple_mdm_id}/devices/{device_id}/scheduleOSUpdate',
            '/cloudinsights/accounts',
            '/cloudinsights/accounts/{cloud_insights_id}',
            '/cloudinsights/events',
            '/cloudinsights/events/distinct',
            '/cloudinsights/views',
            '/cloudinsights/views/{view_id}',
            '/commandqueue/{workflow_instance_id}',
            '/commandresult/workflows',
            '/integrations/syncro/{UUID}',
            '/integrations/syncro/{UUID}/companies',
            '/integrations/syncro/{UUID}/mappings',
            '/integrations/syncro/{UUID}/settings',
            '/organizations/cases',
            '/providers/{provider_id}/integrations/autotask/alerts/configuration',
            '/providers/{provider_id}/integrations/autotask/alerts/configuration/options',
            '/providers/{provider_id}/integrations/autotask/alerts/{alert_UUID}/configuration',
            '/providers/{provider_id}/integrations/connectwise/alerts/configuration',
            '/providers/{provider_id}/integrations/connectwise/alerts/configuration/options',
            '/providers/{provider_id}/integrations/connectwise/alerts/{alert_UUID}/configuration',
            '/providers/{provider_id}/integrations/syncro',
            '/providers/{provider_id}/integrations/syncro/alerts/configuration',
            '/providers/{provider_id}/integrations/syncro/alerts/configuration/options',
            '/providers/{provider_id}/integrations/syncro/alerts/{alert_UUID}/configuration',
            '/providers/{provider_id}/integrations/ticketing/alerts',
            '/queuedcommand/workflows',
            '/systems/{system_id}/softwareappstatuses',
            '/applications/{application_id}',
            '/providers/{provider_id}'
            '/providers/{provider_id}/organizations/{id}'
            '/providers/{provider_id}/integrations',
            '/providers/{provider_id}/integrations/connectwise',
            '/integrations/connectwise/{UUID}',
            '/integrations/connectwise/{UUID}/settings',
            '/integrations/connectwise/{UUID}/agreements',
            '/integrations/connectwise/{UUID}/agreements/{agreement_ID}/additions',
            '/integrations/connectwise/{UUID}/companies',
            '/integrations/connectwise/{UUID}/companytypes',
            '/integrations/connectwise/{UUID}/mappings',
            '/integrations/autotask/{UUID}',
            '/integrations/autotask/{UUID}/settings',
            '/integrations/autotask/{UUID}/companytypes',
            '/integrations/autotask/{UUID}/companies',
            '/integrations/autotask/{UUID}/contracts',
            '/integrations/autotask/{UUID}/contracts/fields',
            '/integrations/autotask/{UUID}/contracts/services',
            '/integrations/autotask/{UUID}/mappings',
            '/integrations/{integration_type}/{UUID}/errors',
            '/providers/{provider_id}/integrations/autotask',
            '/softwareapps/{software_app_id}/retry-installation',
            '/accessrequests/',
            '/accessrequests/{accessId}',
            '/accessrequests/{accessId}/revoke'
        )
    }
}
Function Get-SwaggerItem {
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'An object representing a swagger file.')]$InputObject
        , $Path
    )
    # Brake up parts of path to iterate through
    If ($Path -match '#') {
        $Path = $Path.Replace('#', '')
    }
    $PathDotSource = $Path.Split('/').Split('.') | Where-Object { $_ }
    # Get contents of swagger file
    $Object = $InputObject
    # Iterate through parts of the path and return the requested model
    $PathDotSource | ForEach-Object {
        $Object = $Object.$_
    }
    Return $Object
}
function Remove-NewEndpoints {
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'An object representing a swagger file.')]$InputObject
    )
    foreach ($path in $InputObject.paths.PSObject.Properties) {
        $paths = $InputObject.paths.$($path.name).PSObject.Properties | Where-object { $_.Name -ne "parameters" }
        foreach ($endpoint in $paths) {
            $opperationID = ($InputObject.paths.$($path.name).$($endpoint.name)).operationId
            $opperationMethod = $($endpoint.name)
            if ($opperationID) {
                If (($opperationID) -notin ($TransformConfig."$($SDKName)".OperationIdMapping.keys)) {
                    $excludePath = "$($path.name)/$opperationMethod"
                    Write-Warning "[status] Excluding New SDK Endpoint: `n    OperationId: $($opperationID) `n    Path: $excludePath"
                    # Remove the object from swagger
                    $InputObject.paths.$($path.name).psObject.Properties.remove($opperationMethod)
                }
            }
        }
    }
    return $InputObject
}
function Remove-ExcludedEndpoints {
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'An object representing a swagger file.')]$InputObject
    )
    foreach ($path in $InputObject.paths.PSObject.Properties) {
        if ($($path.name) -in $TransformConfig."$($SDKName)".ExcludedList) {
            Write-Warning "[status] Excluding Path: `n    Path: $($path.name)"
            # Remove the object from swagger
            $InputObject.paths.PSObject.Properties.Remove($($path.name))
            # update global exclude list variable to valide it was removed later
            $global:ExcludedList.Remove($($path.name))
        }
    }
    return $InputObject
}
Function Update-SwaggerObject {
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'An object representing a swagger file.')]$InputObject
        , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'The name of the object that is being passed in.')]$InputObjectName = ''
        , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Use to disable changes made to the swagger object.')][bool]$NoUpdate = $false
        , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'The original input object which will be used as a reference', DontShow)]$InputObjectOrg
    )

    $InputObject | ForEach-Object {
        $ThisObject = $_
        # # Use for debugging. Specify the attribute path you want to troubleshoot and add break point.
        # If ($InputObjectName -eq '.paths./users/{user_id}/associations.get.parameters')
        # {
        #     Write-Host "Break Point"
        #     $ThisObject.description = 'Test'
        # }
        If ($NoUpdate -eq $false) {
            # Array to print Status for new endpoints
            # TODO: Unsure why leaving as an array wont work with autorest. Convert the enum array to a string.
            # TODO: If left as is in an array autorest throws error "error CS0023: Operator '?' cannot be applied to operand of type 'Items1'"
            If ($InputObjectName -like '.parameters.*') {
                $ThisObjectName = $ThisObject.name
                If ($ThisObject | Get-Member -Name type) {
                    If ($ThisObject | Get-Member -Name name) {
                        If ($ThisObject.name -eq "targets") {
                            $ThisObject.type = 'string'
                            Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:('enum') -Value:($ThisObject.items.enum) -Force
                            $ThisObject.PSObject.Properties.Remove('items')
                        }
                    }
                }
            } Else {
                $ThisObjectName = $InputObjectName.split('.') | Select-Object -Last 1
            }
        }
        # Get child objects
        If (-not [System.String]::IsNullOrEmpty($ThisObject)) {
            $AttributeType = $ThisObject.GetType()
            $AttributeNames = If ($AttributeType.FullName -in ('System.Management.Automation.PSCustomObject')) {
                $ThisObject.PSObject.Properties.Name
            }
        } Else {
            $AttributeNames = $null
        }
        # Iterate through child objects
        If (-not [System.String]::IsNullOrEmpty($AttributeNames)) {
            # Write-Host ("AttributeNames: $AttributeNames")
            $AttributeNames | ForEach-Object {
                $AttributeName = $_
                $AttributePath = (@($InputObjectName, $AttributeName) -join ('.'))
                If ($NoUpdate -eq $false) {
                    # Map operationIds
                    If ($AttributePath -like '*.operationId') {
                        If (($global:OperationIdMapping).Contains($ThisObject.operationId)) {
                            $OperationId = $ThisObject.operationId
                            $ThisObject.operationId = $global:OperationIdMapping.($ThisObject.operationId)
                            $global:OperationIdMapping.Remove($OperationId)
                            $NewOperationId = $ThisObject.operationId
                        } Else {
                            $excludePath = ($InputObjectName -replace '.paths.', '') -replace "\.\w+", ''
                            # Write-Warning "[status] New SDK Endpoint Found: `nOperationId: $($ThisObject.operationId) `nPath: $excludePath"
                            Write-Warning ("In '$($CurrentSDKName)' unknown operationId '$($ThisObject.operationId) - $($InputObjectName)'.")
                        }
                    }

                    # Remove blank values from enum
                    If ($AttributePath -like '*.enum') {
                        If ($ThisObject.enum -contains '') {
                            $ThisObject.enum = $ThisObject.enum | Where-Object { $_ }
                        } # error CS1519: Invalid token '=' in class, struct, or interface member declaration # FATAL: Error: Name is empty!
                    }
                    # Append "x-ms-enum" to "enum" section
                    If ($AttributePath -like '.paths.*.parameters.enum' -or $AttributePath -like '.definitions.GraphOperation-*.enum' -or $AttributePath -like '.parameters.*.enum') {
                        # Determine unique xMsEnum name
                        $xMsEnumNameProperty = If ($ThisObject.name) {
                            $ThisObject.name
                        }
                        $xMsEnumModelName = If ($AttributePath -match [regex]'\.definitions\.(.*?)\.allOf\.properties\.type\.enum') {
                            $matches[1]
                        } ElseIf ($AttributePath -match [regex]'\.parameters\.trait:(.*?)\.items\.enum') {
                            $matches[1].Replace(':', '-')
                        } ElseIf ($AttributePath -match [regex]'\.parameters\.trait:(.*?)\.enum') {
                            $matches[1].Replace(':', '-')
                        }
                        # Else { $ThisObjectName }
                        $xMsEnumName = If (-not [System.String]::IsNullOrEmpty($xMsEnumNameProperty) -and -not [System.String]::IsNullOrEmpty($xMsEnumModelName)) {
                            "$($xMsEnumModelName.Replace($xMsEnumNameProperty,''))$((Get-Culture).TextInfo.ToTitleCase($xMsEnumNameProperty))"
                        } ElseIf (-not [System.String]::IsNullOrEmpty($xMsEnumNameProperty) -and [System.String]::IsNullOrEmpty($xMsEnumModelName)) {
                            "$($xMsEnumNameProperty)"
                        } ElseIf ([System.String]::IsNullOrEmpty($xMsEnumNameProperty) -and -not [System.String]::IsNullOrEmpty($xMsEnumModelName)) {
                            "$($xMsEnumModelName)"
                        } Else {
                            Write-Error ("Unable to determine enum name: $($AttributePath)  $($ThisObject.name)")
                        }
                        $xMsEnum = [PSCustomObject]@{
                            name = $xMsEnumName
                            # modelAsString = $true
                        }
                        # C# does not like it when we use these characters/reserved words so we have to make the "Name" diffrent from the "Value"
                        If ($ThisObject.enum -contains 'system' -or $ThisObject.enum -like '*#*') {
                            $xMsEnumValues = @(
                                $ThisObject.enum | ForEach-Object {
                                    $EnumItem = $_
                                    $EnumItemName = $EnumItem.Replace('#', '').Replace('system', 'systems') # C# does not like it when we use these characters/reserved words
                                    [PSCustomObject]@{
                                        name  = $EnumItemName;
                                        value = $EnumItem | ForEach-Object {
                                            If ($_ -match [regex]'(\#|\s)') {
                                                "'$($_)'"
                                            } Else {
                                                $_
                                            };
                                        };
                                    }
                                }
                            )
                            Add-Member -InputObject:($xMsEnum) -MemberType:('NoteProperty') -Name:('values') -Value:($xMsEnumValues)
                        }
                        Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:('x-ms-enum') -Value:($xMsEnum)
                        # Make x-ms-enum names unique
                        # See if x-ms-enum already exists by name
                        $xMsEnumObjectByName = $global:xMsEnumObject | Where-Object { $_.Name -eq $ThisObjectName }
                        If ([System.String]::IsNullOrEmpty($xMsEnumObjectByName)) {
                            $xMsEnumObjectFilteredId = 0
                            $xMsEnumItem = @{
                                Id   = $xMsEnumObjectFilteredId
                                Name = $ThisObjectName
                                Enum = $ThisObject.enum
                            }
                            $global:xMsEnumObject += $xMsEnumItem
                        } Else {
                            # See if x-ms-enum already exists by name and value
                            $xMsEnumObjectByNameValue = $global:xMsEnumObject | Where-Object { $_.Name -eq $ThisObjectName -and [String]$_.Enum -eq [String]$ThisObject.enum }
                            If ([System.String]::IsNullOrEmpty($xMsEnumObjectByNameValue)) {
                                $xMsEnumObjectFilteredId = [int](($xMsEnumObjectByName | Measure-Object -Property Id -Maximum).maximum) + 1
                                $xMsEnumItem = @{
                                    Id   = $xMsEnumObjectFilteredId
                                    Name = $ThisObjectName
                                    Enum = $ThisObject.enum
                                }
                                $global:xMsEnumObject += $xMsEnumItem
                            } Else {
                                $xMsEnumObjectFilteredId = $xMsEnumObjectByNameValue.Id
                            }
                        }
                        If ($xMsEnumObjectFilteredId -gt 0) {
                            $ThisObject.'x-ms-enum'.name = "$($ThisObject.'x-ms-enum'.name)$($xMsEnumObjectFilteredId)"
                        }
                        # Write-Host ("$($CurrentSDKName)|$($NewOperationId)|$($AttributePath)|$($xMsEnumObjectFilteredId)|$($ThisObject.enum -join ',')")
                    }
                    # Check for when type is object without defined properties
                    If ($AttributePath -like '*.type') {
                        If ('object' -in $ThisObject.type -and 'properties' -notin $ThisObject.PSObject.Properties.Name -and 'allOf' -notin $ThisObject.PSObject.Properties.Name -and 'additionalProperties' -notin $ThisObject.PSObject.Properties.Name) {
                            Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:('additionalProperties') -Value:($true)
                        }
                    }
                    # Exclude $ref
                    If ($AttributeName -eq '$ref' -and (($ThisObject.$AttributeName).split('/') | Select-Object -Last 1) -in $global:ExcludedListOrg) {
                        Write-Host "$($AttributeName): $($ThisObject.$AttributeName)"
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                        Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:('type') -Value:('string')
                    }
                    # # Generalize responses for when operation returns an object or an array of objects
                    # If ($AttributePath -like '*.responses.200.schema')
                    # {

                    #     If ($ThisObject.$AttributeName.type -eq 'array')
                    #     {
                    #         $GeneralObject = [PSCustomObject]@{
                    #             additionalProperties = $true
                    #             type                 = 'object'
                    #         }
                    #         $ThisObject.$AttributeName.PSObject.Properties.Remove('items')
                    #         Add-Member -InputObject:($ThisObject.$AttributeName) -MemberType:('NoteProperty') -Name:('items') -Value:($GeneralObject)
                    #         Add-Member -InputObject:($ThisObject.$AttributeName) -MemberType:('NoteProperty') -Name:('title') -Value:("$(($NewOperationId).Split('-')[1].Replace('JcSdk',''))$(($NewOperationId).Split('-')[0])ApplicationJsonResponse")
                    #     }
                    #     Else
                    #     {
                    #         $GeneralObject = [PSCustomObject]@{
                    #             additionalProperties = $true
                    #             title                = "$(($NewOperationId).Split('-')[1].Replace('JcSdk',''))$(($NewOperationId).Split('-')[0])ApplicationJsonResponse"
                    #             type                 = 'object'
                    #         }
                    #         $ThisObject.PSObject.Properties.Remove($AttributeName)
                    #         Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:('schema') -Value:($GeneralObject)
                    #     }
                    # }
                    # Remove non 2XX response so that autorest returns correct errors to PowerShell
                    If ($AttributePath -like '.paths.*.responses.*' -and $AttributePath -notlike '.paths.*.responses.2*') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove endpoints that are not AutoRest compatible or that should be hidden from the public
                    If ($AttributePath -match '(.paths.)([a-zA-Z0-9\/\{\}\-_]+$|.*\.xml$)') {
                        $ThisObject.$AttributeName.PSObject.Properties.Name | ForEach-Object {
                            $Method = $_
                            # Remove endpoint where "consumes" and "produces" does not contain "application/json" or "text/plain"
                            If (
                                ('produces' -in $ThisObject.$AttributeName.$Method.PSObject.Properties.Name -and $ThisObject.$AttributeName.$Method.produces -notcontains 'application/json' -and $ThisObject.$AttributeName.$Method.produces -notcontains 'text/plain') `
                                    -or ('consumes' -in $ThisObject.$AttributeName.$Method.PSObject.Properties.Name -and $ThisObject.$AttributeName.$Method.consumes -notcontains 'application/json' -and $ThisObject.$AttributeName.$Method.consumes -notcontains 'text/plain')
                            ) {
                                # Write-Warning ("Removing: $($AttributeName) - $($Method.ToUpper())")
                                $ThisObject.$AttributeName.PSObject.Properties.Remove($Method)
                            }
                        }
                    }
                    # Remove x-swagger-jumpcloud-auto-insert
                    If ($AttributePath -like '*.x-swagger-jumpcloud-auto-insert*') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove x-jumpcloud
                    If ($AttributePath -like '*.x-jumpcloud*') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove x-scopes
                    If ($AttributePath -like '*.x-scopes') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove x-tagGroups
                    If ($AttributePath -eq '.x-tagGroups') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove x-tests
                    If ($AttributePath -eq '.x-tests') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove x-go-package
                    If ($AttributePath -like '*.x-go-package') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove tags
                    If ($AttributePath -like '*.tags') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove x-tags
                    If ($AttributePath -like '*.x-tags*') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove tagnames
                    If ($AttributePath -like '*.tagnames') {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # If ($AttributePath -like '*.enum') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    If ($ThisObject.$AttributeName) {
                        $ModifiedObject = Update-SwaggerObject -InputObject:($ThisObject.$AttributeName) -InputObjectName:($AttributePath) -NoUpdate:($NoUpdate) -InputObjectOrg:($InputObjectOrg)
                        # If it was an array of objects before reapply the parent array.
                        # accounting for objects which may have been removed, check that thisobject is not null
                        If (($ThisObject.$AttributeName.GetType()).FullName -eq 'System.Object[]') {
                            $ModifiedObject = @($ModifiedObject)
                        }
                        $ThisObject.$AttributeName = $ModifiedObject
                    }
                } Else {
                    If ($ThisObject.$AttributeName) {
                        $ModifiedObject = Update-SwaggerObject -InputObject:($ThisObject.$AttributeName) -InputObjectName:($AttributePath) -NoUpdate:($NoUpdate) -InputObjectOrg:($InputObjectOrg)
                        # If it was an array of objects before reapply the parent array.
                        If (($ThisObject.$AttributeName.GetType()).FullName -eq 'System.Object[]') {
                            $ModifiedObject = @($ModifiedObject)
                        }
                        $ThisObject.$AttributeName = $ModifiedObject
                    }
                }
            }
        }
    }
    # Return modified object
    Return $InputObject
}

# Start script
$SDKName | ForEach-Object {
    $SDKNameItem = $_
    $global:xMsEnumObject = @()
    If ($TransformConfig.Contains($SDKNameItem)) {
        $Config = $TransformConfig.($SDKNameItem)
        $CurrentSDKName = $SDKNameItem
        $global:OperationIdMapping = $Config.OperationIdMapping

        # Create output file path
        $OutputFullPathJson = "$($OutputFilePath)/$($SDKNameItem).json"
        If (-not (Test-Path -Path:($OutputFilePath))) {
            New-Item -Path:($OutputFilePath) -ItemType:('Directory')
        }
        # Get OAS content from Public URL
        $SwaggerUrl = $Config.PublicUrl
        $OASContent = If ($SwaggerUrl -like '*https*') {
            (Invoke-WebRequest -Uri:($SwaggerUrl)).Content
        } Else {
            Get-Content -Path:($SwaggerUrl) -Raw
        }
        If ([System.String]::IsNullOrEmpty($OASContent)) {
            Write-Error ("No content was returned from: $($SwaggerUrl)")
        }
        If ([System.String]::IsNullOrEmpty($OASContent)) {
            Write-Error ("No content was returned from: $($SwaggerUrl)")
        } Else {
            # Prep json for find and replace by flattening string
            $SwaggerObjectContent = If ($SwaggerUrl -like '*.yaml*') {
                $OASContent | ConvertFrom-Yaml -Ordered # | ConvertTo-Yaml -JsonCompatible
            } Else {
                $OASContent | ConvertFrom-Json -Depth:(100)
            }
            # Find and replace on file
            $SwaggerObject = $SwaggerObjectContent | ConvertTo-Json -Depth:(100) -Compress
            # Perform find and replace
            If (-not [System.String]::IsNullOrEmpty($Config.FindAndReplace)) {
                ($Config.FindAndReplace).GetEnumerator() | ForEach-Object {
                    $PatternMatch = $SwaggerObject | Select-String -Pattern:([regex]($_.Name))
                    If (-not [System.String]::IsNullOrEmpty($PatternMatch)) {
                        Do {
                            $SwaggerObject = $SwaggerObject -Replace ([regex]$_.Name, [string]$_.Value)
                            $PatternExists = $SwaggerObject | Select-String -Pattern:([regex]($_.Name))
                        } While ($PatternExists -and $PatternExists.Matches.Value -ne $_.Value)
                    } Else {
                        Write-Error ("Unable to find a match in '$CurrentSDKName' for:$($_.Name)")
                    }
                }
            }
            # replace override definitions
            if ($config.OverrideDefinitions){
                foreach ($overrideDef in $config.OverrideDefinitions){
                    write-warning "$overrideDef"
                    $SwaggerObject = $SwaggerObject | ConvertFrom-Json -depth 100
                    # check that a coresponding def exists in /Custom directory
                    if (Test-Path -Path "$PSScriptRoot/CustomDefinitions/$($overrideDef).json") {
                        $configContent = Get-Content -Path ("$PSScriptRoot/CustomDefinitions/$($overrideDef).json")
                        $configOverride = ($configContent | ConvertFrom-Json)
                        Invoke-Expression -Command ('$SwaggerObject.' + "$($overrideDef)" + '=' + '$configOverride' )
                    } else {
                        Write-Warning "$overrideDef not found in /CustomDefinitions directory, did you forget to define the json file?"
                    }
                }
            } else{
                $SwaggerObject = $SwaggerObject | ConvertFrom-Json -Depth:(100)
            }
            #######################################################################
            # # Resolve the swagger references ($ref)/flatten
            # $SwaggerObjectRefMatches = $SwaggerObject | ConvertFrom-Json -Depth:(100)
            # Do
            # {
            #     $RefMatches = $SwaggerObject | Select-String -Pattern:('(\{"\$ref":")(.*?)("\})') -AllMatches
            #     $RefMatches.Matches | ForEach-Object {
            #         $RefItem = Get-SwaggerItem -InputObject:($SwaggerObjectRefMatches) -Path:($_.Groups[2].Value)
            #         $SwaggerObject = $SwaggerObject.Replace($_.Groups[0].Value, ($RefItem | ConvertTo-Json -Depth:(100) -Compress))
            #     }
            # } While ($SwaggerObject | Select-String -Pattern:('(\{"\$ref":")(.*?)("\})') -AllMatches)
            # $SwaggerObject = $SwaggerObject | ConvertFrom-Json -Depth:(100)
            # $SwaggerObject.definitions = @{}
            # $SwaggerObject = $SwaggerObject | ConvertTo-Json -Depth:(100)
            #######################################################################
            # Update swagger object
            # $SwaggerObject = $SwaggerObject | ConvertFrom-Json -Depth:(100)
            # Exclude New SDK Endpoints (Automatically exclude newly added endpoints)
            $SwaggerObject = Remove-NewEndpoints -InputObject:($SwaggerObject)
            # Define Exclude Lists
            $global:ExcludedList = [System.Collections.ArrayList]$Config.ExcludedList
            $global:ExcludedListOrg = [System.Collections.ArrayList]$Config.ExcludedList
            # Excluded Endpoints specifed by API Transform Exclude List
            $SwaggerObject = Remove-ExcludedEndpoints -InputObject:($SwaggerObject)
            # Find new SDK Endpoints
            $UpdatedSwagger = Update-SwaggerObject -InputObject:($SwaggerObject) -InputObjectOrg:($SwaggerObject)
            Do {
                $UsedRefs = ($UpdatedSwagger | ConvertTo-Json -Depth:(100) -Compress | Select-String -Pattern:('(\{"\$ref":")(.*?)("\})') -AllMatches).Matches
                If (-not [System.String]::IsNullOrEmpty($UsedRefs)) {
                    $UsedDefinitions = ($UsedRefs | ForEach-Object { $_.Groups[2].Value.Where( { $_ -like '*definitions*' }) }) | ForEach-Object { $_.Split('/') | Select-Object -Last 1 } | Select-Object -Unique | Sort-Object
                    $UsedParameters = ($UsedRefs | ForEach-Object { $_.Groups[2].Value.Where( { $_ -like '*parameters*' }) }) | ForEach-Object { $_.Split('/') | Select-Object -Last 1 } | Select-Object -Unique | Sort-Object
                }
                # Remove unused definitions
                $AllDefinitions = $UpdatedSwagger.definitions.PSObject.Properties.Name | Select-Object -Unique | Sort-Object
                $AllDefinitions | ForEach-Object {
                    If ($UsedDefinitions -notcontains $_) {
                        # Write-Warning ("Removing unused definition: $_")
                        $UpdatedSwagger.definitions.PSObject.Properties.Remove($_)
                    }
                }
                $DefinitionResults = If (-not [System.String]::IsNullOrEmpty($UsedDefinitions) -and -not [System.String]::IsNullOrEmpty($AllDefinitions)) {
                    Compare-Object -ReferenceObject $UsedDefinitions -DifferenceObject $AllDefinitions
                }
                # Remove unused parameters
                $AllParameters = $UpdatedSwagger.parameters.PSObject.Properties.Name | Select-Object -Unique | Sort-Object
                $AllParameters | ForEach-Object {
                    If ($UsedParameters -notcontains $_) {
                        # Write-Warning ("Removing unused parameter: $_")
                        $UpdatedSwagger.parameters.PSObject.Properties.Remove($_)
                    }
                }
                $ParameterResults = If (-not [System.String]::IsNullOrEmpty($UsedParameters) -and -not [System.String]::IsNullOrEmpty($AllParameters)) {
                    Compare-Object -ReferenceObject $UsedParameters -DifferenceObject $AllParameters
                }
            } While ($DefinitionResults -or $ParameterResults)
            #endregion
            $SwaggerString = $UpdatedSwagger | ConvertTo-Json -Depth:(100)
            # TODO: Validate that all "enum" locations have been updated to add "x-ms-enum"
            # TODO: Replace with Get-OperationIDs on Swagger object / Ensure all documented operationIDs have been accounted for
            # Validate that all operationIds in mapping have been found in spec
            If (-not [System.String]::IsNullOrEmpty($global:OperationIdMapping)) {
                ($global:OperationIdMapping).GetEnumerator() | ForEach-Object {
                    Write-Error ("In '$($CurrentSDKName)' unable to find operationId '$($_.Key)'.")
                }
            }
            # TODO: Replace with Get-ExcludedPaths / Ensure all documented Excludes are not in swaggerObject
            # Validate that all "ExcludedList" in mapping have been removed from spec
            # If (-not [System.String]::IsNullOrEmpty($global:ExcludedList)) {
            #     $global:ExcludedList | ForEach-Object {
            #         Write-Error ("In '$($CurrentSDKName)' unable to find ExcludedPath '$($_)'.")
            #     }
            # }
            $global:ExcludedListOrg | ForEach-Object {
                If ($SwaggerString -match """$($_)""" -or $SwaggerString -match [regex]("(""\`$ref"": ""\#\/)(.*?)($($_)"")")) {
                    Write-Error ("In '$($CurrentSDKName)' the item '$($_)' has not been excluded.")
                }
            }
            # Validate that "tags" have been removed
            $Tags = $SwaggerString | Select-String -Pattern:('"Tags"')
            If ($Tags.Matches.Value) {
                Write-Error ("In '$($CurrentSDKName)' still has '$($Tags.Matches.Value)' in it.")
            }
            # Compare current spec to old spec and if they are diffrent then export the new file
            $UpdatedSpec = $false
            If (Test-Path -Path:($OutputFullPathJson)) {
                $OldSpec = Get-Content -Path:($OutputFullPathJson) -Raw | ConvertFrom-Json -Depth:(100) | ConvertTo-Json -Depth:(100)
                If (-not [System.String]::IsNullOrEmpty($OldSpec)) {
                    $CompareResults = Compare-Object -ReferenceObject:($OldSpec.Trim()) -DifferenceObject:($SwaggerString.Trim())
                    If (-not [System.String]::IsNullOrEmpty($CompareResults)) {
                        $UpdatedSpec = $true
                    }
                } Else {
                    $UpdatedSpec = $true
                }
            } Else {
                $UpdatedSpec = $true
            }
            # Output new file
            $SwaggerString | Out-File -Path:($OutputFullPathJson) -Force
            # # For comparing before and after
            # $SwaggerObjectContent | ConvertTo-Json -Depth:(100) -Compress | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.FindAndReplace")) -Force # For Debugging to compare before and after
            # $SwaggerObjectContent | ConvertTo-Json -Depth:(100) | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.Before")) -Force # For Debugging to compare before and after
            # # $SwaggerObjectContent | ConvertTo-Json -Depth:(100) -Compress | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.Before")) -Force # For Debugging to compare before and after
            # $UpdatedSwagger | ConvertTo-Json -Depth:(100) | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.After")) -Force # For Debugging to compare before and after
            # Return variable to Azure Pipelines
            Return $UpdatedSpec
        }
    } Else {
        Write-Error ("Config 'TransformConfig' does not contain an SDK called '$($SDKNameItem)'.")
    }
}
