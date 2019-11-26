#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('V1', 'V2')][ValidateNotNullOrEmpty()][System.String[]]$APIName
)
.($PSScriptRoot + '/Invoke-Git.ps1')
Set-Location $PSScriptRoot
$ApiHash = [Ordered]@{
    # 'Url_V1' = 'https://api.stoplight.io/v1/versions/sNtcAibbBX7Nizrmd/export/oas.yaml'; # StopLight
    # 'Url_V2' = 'https://api.stoplight.io/v1/versions/JWvycPWBDeEZ3R5dF/export/oas.yaml'; # StopLight
    'Url_V1' = 'https://api.stoplight.io/v1/versions/MeLBYr6CGg2f4g9Qh/export/oas.yaml' # Docs
    'Url_V2' = 'https://api.stoplight.io/v1/versions/kP6fw2Ppd9ZbbfNmT/export/oas.yaml' # Docs
    # 'Url_V1' = 'https://raw.githubusercontent.com/TheJumpCloud/SI/master/routes/webui/api/index.yaml?token=AK5FVUOCYLGLDFEW32YPIKS52VTCS'
    # 'Url_V2' = 'https://raw.githubusercontent.com/TheJumpCloud/SI/master/routes/webui/api/v2/index.yaml?token=AK5FVUKXH6FIFU45LMFJIEC52VTEM'
}
$UpdatedSpec = $false
$OutputFilePath = $PSScriptRoot + '/SwaggerSpecs/'
# Build Find and Replace table
$FindReplaceHash = [Ordered]@{
    # V1 Issues
    ',"/tags/{name}": {"parameters": [{"name": "name","in": "path","required": true,"type": "string"}],"delete": {"operationId": "tags_delete","summary": "Delete a Tag","tags": ["Tags"],"description": "Hidden as Tags is deprecated\n\nDelete a Tag.","parameters": [{"$ref": "#/parameters/trait:requestHeaders:Content-Type"},{"$ref": "#/parameters/trait:requestHeaders:Accept"}],"responses": {"200": {"description": "","schema": {"$ref": "#/definitions/tag"}}},"security": [{"x-api-key": []}]}}' = '' # Prevents PowerShell from parsing json. Within the "paths" section there is "/tags/{name}" and "/Tags/{name}" which causes a duplication error.
    # V2 Issues
    '"": {"domain": "veniam"}'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                = ''; # Prevents PowerShell from parsing json. # Property name can not be blank.
    # Path Issues
    '"#/definitions/system"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  = '"#/definitions/JcSystem"'; # The "system" class is a reserved word.
    '"system": {"title": "System"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                            = '"JcSystem": {"title": "System"'; # The "system" class is a reserved word.
    '"system": {"properties": {"_id"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                         = '"JcSystem": {"properties": {"_id"';
    # Issues with pulling from Docs - Adding missing definitions
    '"definitions": {"sshkeylist"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                            = '"definitions": {"UserGroupGraphManagementReq": {"title": "UserGroupGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes."},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","description": "The graph type","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","system","system_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"SystemGroupGraphManagementReq": {"title": "SystemGroupGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes."},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","user","user_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"bulk-user-create": {"title": "Bulk User Create","type": "object","description": "See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.","properties": {"username": {"type": "string"},"firstname": {"type": "string"},"lastname": {"type": "string"},"email": {"type": "string"},"attributes": {"type": "array","description": "Map of additional attributes.","items": {"type": "object"}}}},"gsuite-patch-input": {"title": "GSuite Patch Input","type": "object","properties": {"userLockoutAction": {"type": "string","enum": ["suspend","maintain"]},"userPasswordExpirationAction": {"type": "string","enum": ["suspend","maintain"]}}},"UserGraphManagementReq": {"title": "UserGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes","properties": {"sudo": {"type": "object","properties": {"enabled": {"type": "boolean"},"withoutPassword": {"type": "boolean"}}}}},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","system","system_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"organizationslist": {"title": "OrganizationList","type": "object","properties": {"totalCount": {"type": "integer","description": "The total number of organizations. "},"results": {"type": "array","description": "The list of organizations.","items": {"type": "object","properties": {"_id": {"type": "string","description": "The ID of the organization."},"displayName": {"type": "string","description": "The name of the organization."},"logoUrl": {"type": "string","description": "The organization logo image URL. "}}}}}},"active-directory-input": {"title": "Active Directory Input","type": "object","properties": {"domain": {"type": "string","description": "Domain name for this Active Directory instance."}}},"sshkeylist"'
    # V1 Issues
    '"basePath": "/api"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = '"basePath": "/api/"'; # The extra slash at the end is needed to properly build the url.
    '"type": "object","organization": {"type": "string","description": "The ID of the organization."}'                                                                                                                                                                                                                                                                                                                                                                                                        = '"type":"object"'; # This section is in the wrong place within the json.
    '"command": {"title": "Command", "type": "object", "organization": {"type": "string", "description": "The ID of the organization."},'                                                                                                                                                                                                                                                                                                                                                                     = '"command": {"title": "Command", "type": "object",'
    '"command": {"organization": {"description": "The ID of the organization.", "type": "string"},'                                                                                                                                                                                                                                                                                                                                                                                                           = '"command": {';
    '"type": "null"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          = '"type": "string"'; # A type of null is not valid.
    '"type": ["null","integer"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                              = '"type": "integer"'; # A type of null is not valid.
    '"type": ["null", "integer"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                             = '"type": "integer"'
    # V2 Issues
    '"basePath": "/api/v2"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   = '"basePath": "/api/v2/"'; # The extra slash at the end is needed to properly build the url.
    '["object","null"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       = '"object"'; # A type of null is not valid.
    '["string","null"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       = '"string"'; # A type of null is not valid.
    '["string","number","boolean","null"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                    = '"string"'; # A type of null is not valid.
    '["string","number","boolean"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                           = '"string"'; # Error: Invalid type 'string,number,boolean' in schema
    '["string", "number", "boolean"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                         = '"string"';
    '["string", "number", "boolean", "null"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                 = '"string"';
    '["object", "null"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = '"object"';
    '["string", "null"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = '"string"';
    '["null", "integer"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     = '"integer"';
    '"jobId"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 = '"id"'; # The transform removes the "-" in the parent objects name, "job-id", which makes the parent name the same as the child.
    '"collection_time": ''2019-05-16T12:58:15.6730000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-05-16T12:58:15.6730000-06:00"';
    '"collection_time": ''2019-06-03T13:41:29.7100000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:29.7100000-06:00"';
    '"collection_time": ''2019-06-03T13:41:30.7710000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:30.7710000-06:00"';
    '"collection_time": ''2019-06-03T13:41:31.5570000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:31.5570000-06:00"';
    '"collection_time": ''2019-06-03T13:41:30.6580000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:30.6580000-06:00"';
    '"collection_time": ''2019-06-03T13:41:30.8580000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:30.8580000-06:00"';
    '"collection_time": ''2019-06-03T13:41:30.9330000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:30.9330000-06:00"';
    '"collection_time": ''2019-06-03T13:41:31.0080000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:31.0080000-06:00"';
    '"collection_time": ''2019-06-03T13:41:31.2040000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:31.2040000-06:00"';
    '"collection_time": ''2019-06-03T13:41:31.1250000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:31.1250000-06:00"';
    '"collection_time": ''2019-06-03T13:41:31.6730000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:31.6730000-06:00"';
    '"collection_time": ''2019-06-03T13:41:31.7460000-06:00'''                                                                                                                                                                                                                                                                                                                                                                                                                                                = '"collection_time": "2019-06-03T13:41:31.7460000-06:00"';
    # Custom Tweaks
    '"tags": ["Systemusers"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 = '"tags": ["SystemUsers"]'; # Change casing for pretty cmdlet names
    '{"$ref": "#/parameters/trait:requestHeaders:Content-Type"}'                                                                                                                                                                                                                                                                                                                                                                                                                                              = ''; # This will be passed in later through the Module.cs file.
    '{"$ref": "#/parameters/trait:requestHeaders:Accept"}'                                                                                                                                                                                                                                                                                                                                                                                                                                                    = ''; # This will be passed in later through the Module.cs file.
    '{"$ref": "#/parameters/trait:multiTenantRequestHeaders:x-org-id"}'                                                                                                                                                                                                                                                                                                                                                                                                                                       = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
    '{"name": "Content-Type","in": "header","type": "string"},'                                                                                                                                                                                                                                                                                                                                                                                                                                               = '';
    '{"name": "Accept","in": "header","type": "string"},'                                                                                                                                                                                                                                                                                                                                                                                                                                                     = '';
    '{"name": "x-org-id","in": "header","type": "string"}'                                                                                                                                                                                                                                                                                                                                                                                                                                                    = '';
    ',,'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = ',';
    ', ,'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     = ',';
    '{,'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = '{';
    '{ ,'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     = '{';
    ',}'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = '}';
    ', }'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     = '}';
    '[,'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = '[';
    '[ ,'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     = '[';
    ',]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = ']';
    ', ]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     = ']';
    "`t"                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      = '\t';
    ',"format": "ipv4"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       = ''; # Remove StopLight syntax
}
$OperationIdHash = [Ordered]@{
    # OperationId to Function name mapping - https://github.com/Azure/autorest.powershell/blob/a530bd721c9326a4356fba15638fee236722aca9/powershell/autorest-configuration.md
    'POST_applications'                                          = 'Application_Create';
    'applications_post'                                          = 'Application_Create';
    'applications_delete'                                        = 'Application_Delete';
    'DELETE_applications-id'                                     = 'Application_Delete';
    'applications_get'                                           = 'Application_Get';
    'GET_applications-id'                                        = 'Application_Get';
    'GET_applications'                                           = 'Application_List';
    'applications_list'                                          = 'Application_List';
    'applications_put'                                           = 'Application_Put';
    'PUT_applications-id'                                        = 'Application_Put';
    'application_templates_get'                                  = 'ApplicationTemplate_Get';
    'GET_application-templates-id'                               = 'ApplicationTemplate_Get';
    'GET_application-templates'                                  = 'ApplicationTemplate_List';
    'application_templates_list'                                 = 'ApplicationTemplate_List';
    'POST_commands'                                              = 'Command_Create';
    'commands_post'                                              = 'Command_Create';
    'commands_delete'                                            = 'Command_Delete';
    'DELETE_commands-id'                                         = 'Command_Delete';
    'commands_get'                                               = 'Command_Get';
    'GET_commands-id'                                            = 'Command_Get';
    'GET_commands'                                               = 'Command_List';
    'commands_list'                                              = 'Command_List';
    'commands_put'                                               = 'Command_Put';
    'PUT_commands-id'                                            = 'Command_Put';
    'command_file_get'                                           = 'CommandFile_Get';
    'GET_files-command-id'                                       = 'CommandFile_Get';
    'command_results_delete'                                     = 'CommandResult_Delete';
    'DELETE_commandresults-id'                                   = 'CommandResult_Delete';
    'command_results_get'                                        = 'CommandResult_Get';
    'GET_commandresults-id'                                      = 'CommandResult_Get';
    'GET_commandresults'                                         = 'CommandResult_List';
    'command_results_list'                                       = 'CommandResult_List';
    'command_trigger_webhook_post'                               = 'CommandTriggerWebhook_Start';
    'POST_command-trigger-triggername'                           = 'CommandTriggerWebhook_Start';
    'GET_organizations'                                          = 'Organization_List';
    'organization_list'                                          = 'Organization_List';
    'search_organizations_post'                                  = 'Organization_Search';
    'POST_search-organizations'                                  = 'Organization_Search';
    'radius_servers_post'                                        = 'RadiusServer_Create';
    'POST_radiusservers'                                         = 'RadiusServer_Create';
    'GET_radiusservers'                                          = 'RadiusServer_List';
    'radius_servers_list'                                        = 'RadiusServer_List';
    'radius_servers_put'                                         = 'RadiusServer_Put';
    'PUT_radiusservers-id'                                       = 'RadiusServer_Put';
    'sshkey_post'                                                = 'SshKey_Create';
    'POST_systemusers-id-sshkeys'                                = 'SshKey_Create';
    'sshkey_delete'                                              = 'SshKey_Delete';
    'DELETE_systemusers-systemuser_id-sshkeys-id'                = 'SshKey_Delete';
    'GET_systemusers-id-sshkeys'                                 = 'SshKey_List';
    'sshkey_list'                                                = 'SshKey_List';
    'systems_delete'                                             = 'System_Delete';
    'DELETE_systems-id'                                          = 'System_Delete';
    'systems_get'                                                = 'System_Get';
    'GET_systems-id'                                             = 'System_Get';
    'GET_systems'                                                = 'System_List';
    'systems_list'                                               = 'System_List';
    'systems_put'                                                = 'System_Put';
    'PUT_systems-id'                                             = 'System_Put';
    'search_systems_post'                                        = 'System_Search';
    'POST_search-systems'                                        = 'System_Search';
    'POST_systemusers'                                           = 'SystemUser_Create';
    'systemusers_post'                                           = 'SystemUser_Create';
    'systemusers_delete'                                         = 'SystemUser_Delete';
    'DELETE_systemusers-id'                                      = 'SystemUser_Delete';
    'systemusers_get'                                            = 'SystemUser_Get';
    'GET_systemusers-id'                                         = 'SystemUser_Get';
    'GET_systemusers'                                            = 'SystemUser_List';
    'systemusers_list'                                           = 'SystemUser_List';
    'systemusers_put'                                            = 'SystemUser_Put';
    'PUT_systemusers-id'                                         = 'SystemUser_Put';
    'search_systemusers_post'                                    = 'SystemUser_Search';
    'POST_search-systemusers'                                    = 'SystemUser_Search';
    'POST_systemusers-id-unlock'                                 = 'SystemUser_Unlock';
    'systemusers_unlock'                                         = 'SystemUser_Unlock';
    'POST_systemusers-id-resetmfa'                               = 'SystemUserMfa_Reset';
    'systemusers_resetmfa'                                       = 'SystemUserMfa_Reset';
    'organizations_get'                                          = 'Organization_Get';
    'organization_put'                                           = 'Organization_Put';
    'POST_case'                                                  = 'SupportCase_New';
    'systems_systemusers_binding_list'                           = 'SystemsSystemUserBinding_List';
    'systems_systemusers_binding_put'                            = 'SystemsSystemUserBinding_Put';
    'systemusers_systems_binding_list'                           = 'SystemUsersSystemBinding_List';
    'systemusers_systems_binding_put'                            = 'SystemUsersSystemBinding_Put';
    'tags_post'                                                  = 'Tag_Create';
    'tags_delete'                                                = 'Tag_Delete';
    'tags_get'                                                   = 'Tag_Get';
    'tags_list'                                                  = 'Tag_List';
    'tags_put'                                                   = 'Tag_Put';
    'activedirectories_get'                                      = 'ActiveDirectory_Get';
    'GET_activedirectories-id'                                   = 'ActiveDirectory_Get';
    'activedirectories_list'                                     = 'ActiveDirectory_List';
    'GET_activedirectories'                                      = 'ActiveDirectory_List';
    'GET_activedirectories-activedirectory_id-associations'      = 'ActiveDirectoryAssociation_List';
    'graph_activeDirectoryAssociationsList'                      = 'ActiveDirectoryAssociation_List';
    'GET_activedirectories-activedirectory_id-usergroups'        = 'ActiveDirectoryTraverseUserGroup_List';
    'graph_activeDirectoryTraverseUserGroup'                     = 'ActiveDirectoryTraverseUserGroup_List';
    'GET_applications-application_id-associations'               = 'ApplicationAssociation_List';
    'graph_applicationAssociationsList'                          = 'ApplicationAssociation_List';
    'POST_applications-application_id-associations'              = 'ApplicationAssociation_Set';
    'graph_applicationAssociationsPost'                          = 'ApplicationAssociation_Set';
    'GET_applications-application_id-users'                      = 'ApplicationTraverseUser_List';
    'graph_applicationTraverseUser'                              = 'ApplicationTraverseUser_List';
    'GET_applications-application_id-usergroups'                 = 'ApplicationTraverseUserGroup_List';
    'graph_applicationTraverseUserGroup'                         = 'ApplicationTraverseUserGroup_List';
    'bulk_usersCreate'                                           = 'BulkUsers_Create';
    'POST_bulk-users'                                            = 'BulkUsers_Create';
    'bulk_usersUpdate'                                           = 'BulkUsers_Update';
    'PATCH_bulk-users'                                           = 'BulkUsers_Update';
    'bulk_usersCreateResults'                                    = 'BulkUsersResult_Get';
    'GET_bulk-users-job_id-results'                              = 'BulkUsersResult_Get';
    'GET_commands-command_id-associations'                       = 'CommandAssociation_List';
    'graph_commandAssociationsList'                              = 'CommandAssociation_List';
    'POST_commands-command_id-associations'                      = 'CommandAssociation_Set';
    'graph_commandAssociationsPost'                              = 'CommandAssociation_Set';
    'GET_commands-command_id-systems'                            = 'CommandTraverseSystem_List';
    'graph_commandTraverseSystem'                                = 'CommandTraverseSystem_List';
    'GET_commands-command_id-systemgroups'                       = 'CommandTraverseSystemGroup_List';
    'graph_commandTraverseSystemGroup'                           = 'CommandTraverseSystemGroup_List';
    'GET_directories'                                            = 'Directory_List';
    'directories_list'                                           = 'Directory_List';
    'duo_accountPost'                                            = 'DuoAccount_Create';
    'POST_duo-accounts'                                          = 'DuoAccount_Create';
    'duo_accountDelete'                                          = 'DuoAccount_Delete';
    'DELETE_duo-accounts-id'                                     = 'DuoAccount_Delete';
    'duo_accountGet'                                             = 'DuoAccount_Get';
    'GET_duo-accounts-id'                                        = 'DuoAccount_Get';
    'GET_duo-accounts'                                           = 'DuoAccount_List';
    'duo_accountList'                                            = 'DuoAccount_List';
    'duo_applicationPost'                                        = 'DuoApplication_Create';
    'POST_duo-accounts-account_id-applications'                  = 'DuoApplication_Create';
    'duo_applicationDelete'                                      = 'DuoApplication_Delete';
    'DELETE_duo-accounts-account_id-applications-application_id' = 'DuoApplication_Delete';
    'duo_applicationGet'                                         = 'DuoApplication_Get';
    'GET_duo-accounts-account_id-applications-application_id'    = 'DuoApplication_Get';
    'GET_duo-accounts-account_id-applications'                   = 'DuoApplication_List';
    'duo_applicationList'                                        = 'DuoApplication_List';
    'PUT_duo-accounts-account_id-applications-application_id'    = 'DuoApplication_Update';
    'duo_applicationUpdate'                                      = 'DuoApplication_Update';
    'GET_groups'                                                 = 'Group_List';
    'groups_list'                                                = 'Group_List';
    'gsuites_get'                                                = 'GSuite_Get';
    'GET_gsuites-id'                                             = 'GSuite_Get';
    'gsuites_patch'                                              = 'GSuite_Patch';
    'PATCH_gsuites-id'                                           = 'GSuite_Patch';
    'graph_gSuiteAssociationsList'                               = 'GSuiteAssociation_List';
    'GET_gsuites-gsuite_id-associations'                         = 'GSuiteAssociation_List';
    'graph_gSuiteAssociationsPost'                               = 'GSuiteAssociation_Set';
    'POST_gsuites-gsuite_id-associations'                        = 'GSuiteAssociation_Set';
    'POST_gsuites-gsuite_id-translationrules'                    = 'GSuiteTranslationRule_Create';
    'translationRules_gSuitePost'                                = 'GSuiteTranslationRule_Create';
    'DELETE_gsuites-gsuite_id-translationrules-id'               = 'GSuiteTranslationRule_Delete';
    'translationRules_gSuiteDelete'                              = 'GSuiteTranslationRule_Delete';
    'GET_gsuites-gsuite_id-translationrules-id'                  = 'GSuiteTranslationRule_Get';
    'translationRules_gSuiteGet'                                 = 'GSuiteTranslationRule_Get';
    'GET_gsuites-gsuite_id-translationrules'                     = 'GSuiteTranslationRule_List';
    'translationRules_gSuiteList'                                = 'GSuiteTranslationRule_List';
    'graph_gSuiteTraverseUser'                                   = 'GSuiteTraverseUser_List';
    'GET_gsuites-gsuite_id-users'                                = 'GSuiteTraverseUser_List';
    'graph_gSuiteTraverseUserGroup'                              = 'GSuiteTraverseUserGroup_List';
    'GET_gsuites-gsuite_id-usergroups'                           = 'GSuiteTraverseUserGroup_List';
    'ldapservers_get'                                            = 'LdapServer_Get';
    'GET_ldapservers-id'                                         = 'LdapServer_Get';
    'GET_ldapservers'                                            = 'LdapServer_List';
    'ldapservers_list'                                           = 'LdapServer_List';
    'ldapservers_patch'                                          = 'LdapServer_Patch';
    'PATCH_ldapservers-id'                                       = 'LdapServer_Patch';
    'graph_ldapServerAssociationsList'                           = 'LdapServerAssociation_List';
    'GET_ldapservers-ldapserver_id-associations'                 = 'LdapServerAssociation_List';
    'graph_ldapServerAssociationsPost'                           = 'LdapServerAssociation_Set';
    'POST_ldapservers-ldapserver_id-associations'                = 'LdapServerAssociation_Set';
    'ldapservers_sambaDomainsPost'                               = 'LdapServerSambaDomain_Create';
    'POST_ldapservers-ldapserver_id-sambadomains'                = 'LdapServerSambaDomain_Create';
    'ldapservers_sambaDomainsDelete'                             = 'LdapServerSambaDomain_Delete';
    'DELETE_ldapservers-ldapserver_id-sambadomains-id'           = 'LdapServerSambaDomain_Delete';
    'ldapservers_sambaDomainsGet'                                = 'LdapServerSambaDomain_Get';
    'GET_ldapservers-ldapserver_id-sambadomains-id'              = 'LdapServerSambaDomain_Get';
    'ldapservers_sambaDomainsList'                               = 'LdapServerSambaDomain_List';
    'GET_ldapservers-ldapserver_id-sambadomains'                 = 'LdapServerSambaDomain_List';
    'ldapservers_sambaDomainsPut'                                = 'LdapServerSambaDomain_Put';
    'PUT_ldapservers-ldapserver_id-sambadomains-id'              = 'LdapServerSambaDomain_Put';
    'graph_ldapServerTraverseUser'                               = 'LdapServerTraverseUser_List';
    'GET_ldapservers-ldapserver_id-users'                        = 'LdapServerTraverseUser_List';
    'graph_ldapServerTraverseUserGroup'                          = 'LdapServerTraverseUserGroup_List';
    'GET_ldapservers-ldapserver_id-usergroups'                   = 'LdapServerTraverseUserGroup_List';
    'graph_office365AssociationsList'                            = 'Office365Association_List';
    'GET_office365s-office365_id-associations'                   = 'Office365Association_List';
    'graph_office365AssociationsPost'                            = 'Office365Association_Set';
    'POST_office365s-office365_id-associations'                  = 'Office365Association_Set';
    'POST_office365s-office365_id-translationrules'              = 'Office365TranslationRule_Create';
    'translationRules_office365Post'                             = 'Office365TranslationRule_Create';
    'DELETE_office365s-office365_id-translationrules-id'         = 'Office365TranslationRule_Delete';
    'translationRules_office365Delete'                           = 'Office365TranslationRule_Delete';
    'GET_office365s-office365_id-translationrules-id'            = 'Office365TranslationRule_Get';
    'translationRules_office365Get'                              = 'Office365TranslationRule_Get';
    'GET_office365s-office365_id-translationrules'               = 'Office365TranslationRule_List';
    'translationRules_office365List'                             = 'Office365TranslationRule_List';
    'graph_office365TraverseUser'                                = 'Office365TraverseUser_List';
    'GET_office365s-office365_id-users'                          = 'Office365TraverseUser_List';
    'graph_office365TraverseUserGroup'                           = 'Office365TraverseUserGroup_List';
    'GET_office365s-office365_id-usergroups'                     = 'Office365TraverseUserGroup_List';
    'GET_policyresults'                                          = 'OrgPolicyResult_List';
    'policyresults_org_list'                                     = 'OrgPolicyResult_List';
    'POST_policies'                                              = 'Policy_Create';
    'policies_post'                                              = 'Policy_Create';
    'policies_delete'                                            = 'Policy_Delete';
    'DELETE_policies-id'                                         = 'Policy_Delete';
    'policies_get'                                               = 'Policy_Get';
    'GET_policies-id'                                            = 'Policy_Get';
    'GET_policies'                                               = 'Policy_List';
    'policies_list'                                              = 'Policy_List';
    'policies_put'                                               = 'Policy_Put';
    'PUT_policies-id'                                            = 'Policy_Put';
    'graph_policyAssociationsList'                               = 'PolicyAssociation_List';
    'GET_policies-policy_id-associations'                        = 'PolicyAssociation_List';
    'graph_policyAssociationsPost'                               = 'PolicyAssociation_Set';
    'POST_policies-policy_id-associations'                       = 'PolicyAssociation_Set';
    'policyresults_get'                                          = 'PolicyResult_Get';
    'GET_policyresults-id'                                       = 'PolicyResult_Get';
    'GET_policies-policy_id-policyresults'                       = 'PolicyResult_List';
    'policyresults_list'                                         = 'PolicyResult_List';
    'GET_policies-policy_id-policystatuses'                      = 'PolicyStatus_List';
    'policystatuses_list'                                        = 'PolicyStatus_List';
    'GET_systems-system_id-policystatuses'                       = 'PolicyStatus_List';
    'policytemplates_get'                                        = 'PolicyTemplate_Get';
    'GET_policytemplates-id'                                     = 'PolicyTemplate_Get';
    'GET_policytemplates'                                        = 'PolicyTemplate_List';
    'policytemplates_list'                                       = 'PolicyTemplate_List';
    'graph_policyTraverseSystem'                                 = 'PolicyTraverseSystem_List';
    'GET_policies-policy_id-systems'                             = 'PolicyTraverseSystem_List';
    'graph_policyTraverseSystemGroup'                            = 'PolicyTraverseSystemGroup_List';
    'GET_policies-policy_id-systemgroups'                        = 'PolicyTraverseSystemGroup_List';
    'providers_postAdmins'                                       = 'ProviderAdmin_Create';
    'POST_providers-provider_id-administrators'                  = 'ProviderAdmin_Create';
    'providers_listAdministrators'                               = 'ProviderAdministrator_List';
    'GET_providers-provider_id-administrators'                   = 'ProviderAdministrator_List';
    'graph_radiusServerAssociationsList'                         = 'RadiusServerAssociation_List';
    'GET_radiusservers-radiusserver_id-associations'             = 'RadiusServerAssociation_List';
    'graph_radiusServerAssociationsPost'                         = 'RadiusServerAssociation_Set';
    'POST_radiusservers-radiusserver_id-associations'            = 'RadiusServerAssociation_Set';
    'graph_radiusServerTraverseUser'                             = 'RadiusServerTraverseUser_List';
    'GET_radiusservers-radiusserver_id-users'                    = 'RadiusServerTraverseUser_List';
    'graph_radiusServerTraverseUserGroup'                        = 'RadiusServerTraverseUserGroup_List';
    'GET_radiusservers-radiusserver_id-usergroups'               = 'RadiusServerTraverseUserGroup_List';
    'graph_systemAssociationsList'                               = 'SystemAssociation_List';
    'GET_systems-system_id-associations'                         = 'SystemAssociation_List';
    'graph_systemAssociationsPost'                               = 'SystemAssociation_Set';
    'POST_systems-system_id-associations'                        = 'SystemAssociation_Set';
    'systems_getFDEKey'                                          = 'SystemFDEKey_Get';
    'GET_systems-system_id-fdekey'                               = 'SystemFDEKey_Get';
    'groups_system_post'                                         = 'SystemGroup_Create';
    'POST_systemgroups'                                          = 'SystemGroup_Create';
    'groups_system_delete'                                       = 'SystemGroup_Delete';
    'DELETE_systemgroups-id'                                     = 'SystemGroup_Delete';
    'groups_system_get'                                          = 'SystemGroup_Get';
    'GET_systemgroups-id'                                        = 'SystemGroup_Get';
    'groups_system_list'                                         = 'SystemGroup_List';
    'GET_systemgroups'                                           = 'SystemGroup_List';
    'groups_system_put'                                          = 'SystemGroup_Put';
    'PUT_systemgroups-id'                                        = 'SystemGroup_Put';
    'graph_systemGroupAssociationsList'                          = 'SystemGroupAssociation_List';
    'GET_systemgroups-group_id-associations'                     = 'SystemGroupAssociation_List';
    'graph_systemGroupAssociationsPost'                          = 'SystemGroupAssociation_Set';
    'POST_systemgroups-group_id-associations'                    = 'SystemGroupAssociation_Set';
    'graph_systemGroupMembersList'                               = 'SystemGroupMembers_List';
    'GET_systemgroups-group_id-members'                          = 'SystemGroupMembers_List';
    'graph_systemGroupMembersPost'                               = 'SystemGroupMembers_Set';
    'POST_systemgroups-group_id-members'                         = 'SystemGroupMembers_Set';
    'graph_systemGroupMembership'                                = 'SystemGroupMembership_List';
    'GET_systemgroups-group_id-membership'                       = 'SystemGroupMembership_List';
    'graph_systemGroupTraverseCommand'                           = 'SystemGroupTraverseCommand_List';
    'GET_systemgroups-group_id-commands'                         = 'SystemGroupTraverseCommand_List';
    'graph_systemGroupTraversePolicy'                            = 'SystemGroupTraversePolicy_List';
    'GET_systemgroups-group_id-policies'                         = 'SystemGroupTraversePolicy_List';
    'graph_systemGroupTraverseUser'                              = 'SystemGroupTraverseUser_List';
    'GET_systemgroups-group_id-users'                            = 'SystemGroupTraverseUser_List';
    'graph_systemGroupTraverseUserGroup'                         = 'SystemGroupTraverseUserGroup_List';
    'GET_systemgroups-group_id-usergroups'                       = 'SystemGroupTraverseUserGroup_List';
    'systeminsights_list_apps'                                   = 'SystemInsightsApps_List';
    'GET_systeminsights-apps'                                    = 'SystemInsightsApps_List';
    'systeminsights_list_bitlocker_info'                         = 'SystemInsightsBitlockerInfo_List';
    'GET_systeminsights-bitlocker_info'                          = 'SystemInsightsBitlockerInfo_List';
    'systeminsights_list_browser_plugins'                        = 'SystemInsightsBrowserPlugins_List';
    'GET_systeminsights-browser_plugins'                         = 'SystemInsightsBrowserPlugins_List';
    'systeminsights_list_chrome_extensions'                      = 'SystemInsightsChromeExtensions_List';
    'GET_systeminsights-chrome_extensions'                       = 'SystemInsightsChromeExtensions_List';
    'systeminsights_list_disk_encryption'                        = 'SystemInsightsDiskEncryption_List';
    'GET_systeminsights-disk_encryption'                         = 'SystemInsightsDiskEncryption_List';
    'systeminsights_list_disk_info'                              = 'SystemInsightsDiskInfo_List';
    'GET_systeminsights-disk_info'                               = 'SystemInsightsDiskInfo_List';
    'systeminsights_list_etc_hosts'                              = 'SystemInsightsEtcHosts_List';
    'GET_systeminsights-etc_hosts'                               = 'SystemInsightsEtcHosts_List';
    'systeminsights_list_firefox_addons'                         = 'SystemInsightsFirefoxAddons_List';
    'GET_systeminsights-firefox_addons'                          = 'SystemInsightsFirefoxAddons_List';
    'systeminsights_list_groups'                                 = 'SystemInsightsGroups_List';
    'GET_systeminsights-groups'                                  = 'SystemInsightsGroups_List';
    'systeminsights_list_interface_addresses'                    = 'SystemInsightsInterfaceAddresses_List';
    'GET_systeminsights-interface_addresses'                     = 'SystemInsightsInterfaceAddresses_List';
    'systeminsights_list_kernel_info'                            = 'SystemInsightsKernelInfo_List';
    'GET_systeminsights-kernel_info'                             = 'SystemInsightsKernelInfo_List';
    'systeminsights_list_logical_drives'                         = 'SystemInsightsLogicalDrives_List';
    'GET_systeminsights-logical_drives'                          = 'SystemInsightsLogicalDrives_List';
    'systeminsights_list_mounts'                                 = 'SystemInsightsMounts_List';
    'GET_systeminsights-mounts'                                  = 'SystemInsightsMounts_List';
    'systeminsights_list_os_version'                             = 'SystemInsightsOsVersion_List';
    'GET_systeminsights-os_version'                              = 'SystemInsightsOsVersion_List';
    'systeminsights_list_patches'                                = 'SystemInsightsPatches_List';
    'GET_systeminsights-patches'                                 = 'SystemInsightsPatches_List';
    'systeminsights_list_programs'                               = 'SystemInsightsPrograms_List';
    'GET_systeminsights-programs'                                = 'SystemInsightsPrograms_List';
    'systeminsights_list_safari_extensions'                      = 'SystemInsightsSafariExtensions_List';
    'GET_systeminsights-safari_extensions'                       = 'SystemInsightsSafariExtensions_List';
    'systeminsights_list_system_apps'                            = 'SystemInsightsSystemApps_List';
    'GET_systeminsights-system_id-apps'                          = 'SystemInsightsSystemApps_List';
    'systeminsights_list_system_bitlocker_info'                  = 'SystemInsightsSystemBitlockerInfo_List';
    'GET_systeminsights-system_id-bitlocker_info'                = 'SystemInsightsSystemBitlockerInfo_List';
    'systeminsights_list_system_browser_plugins'                 = 'SystemInsightsSystemBrowserPlugins_List';
    'GET_systeminsights-system_id-browser_plugins'               = 'SystemInsightsSystemBrowserPlugins_List';
    'systeminsights_list_system_chrome_extensions'               = 'SystemInsightsSystemChromeExtensions_List';
    'GET_systeminsights-system_id-chrome_extensions'             = 'SystemInsightsSystemChromeExtensions_List';
    'systeminsights_list_system_controls'                        = 'SystemInsightsSystemControls_List';
    'GET_systeminsights-system_controls'                         = 'SystemInsightsSystemControls_List';
    'systeminsights_list_system_disk_encryption'                 = 'SystemInsightsSystemDiskEncryption_List';
    'GET_systeminsights-system_id-disk_encryption'               = 'SystemInsightsSystemDiskEncryption_List';
    'systeminsights_list_system_disk_info'                       = 'SystemInsightsSystemDiskInfo_List';
    'GET_systeminsights-system_id-disk_info'                     = 'SystemInsightsSystemDiskInfo_List';
    'systeminsights_list_system_etc_hosts'                       = 'SystemInsightsSystemEtcHosts_List';
    'GET_systeminsights-system_id-etc_hosts'                     = 'SystemInsightsSystemEtcHosts_List';
    'systeminsights_list_system_firefox_addons'                  = 'SystemInsightsSystemFirefoxAddons_List';
    'GET_systeminsights-system_id-firefox_addons'                = 'SystemInsightsSystemFirefoxAddons_List';
    'systeminsights_list_system_groups'                          = 'SystemInsightsSystemGroups_List';
    'GET_systeminsights-system_id-groups'                        = 'SystemInsightsSystemGroups_List';
    'systeminsights_list_system_info'                            = 'SystemInsightsSystemInfo_List';
    'GET_systeminsights-system_info'                             = 'SystemInsightsSystemInfo_List';
    'GET_systeminsights-system_id-interface_addresses'           = 'SystemInsightsSystemInterfaceAddresses_List';
    'systeminsights_list_system_interface_addresses'             = 'SystemInsightsSystemInterfaceAddresses_List';
    'GET_systeminsights-system_id-kernel_info'                   = 'SystemInsightsSystemKernelInfo_List';
    'systeminsights_list_system_kernel_info'                     = 'SystemInsightsSystemKernelInfo_List';
    'GET_systeminsights-system_id-logical_drives'                = 'SystemInsightsSystemLogicalDrives_List';
    'systeminsights_list_system_logical_drives'                  = 'SystemInsightsSystemLogicalDrives_List';
    'GET_systeminsights-system_id-mounts'                        = 'SystemInsightsSystemLogicalMounts_List';
    'systeminsights_list_system_mounts'                          = 'SystemInsightsSystemLogicalMounts_List';
    'GET_systeminsights-system_id-os_version'                    = 'SystemInsightsSystemOSVersion_List';
    'systeminsights_list_system_os_version'                      = 'SystemInsightsSystemOSVersion_List';
    'GET_systeminsights-system_id-patches'                       = 'SystemInsightsSystemPatches_List';
    'systeminsights_list_system_patches'                         = 'SystemInsightsSystemPatches_List';
    'GET_systeminsights-system_id-programs'                      = 'SystemInsightsSystemPrograms_List';
    'systeminsights_list_system_programs'                        = 'SystemInsightsSystemPrograms_List';
    'GET_systeminsights-system_id-safari_extensions'             = 'SystemInsightsSystemSafariExtensions_List';
    'systeminsights_list_system_safari_extensions'               = 'SystemInsightsSystemSafariExtensions_List';
    'GET_systeminsights-system_id-system_controls'               = 'SystemInsightsSystemSystemControls_List';
    'systeminsights_list_system_system_controls'                 = 'SystemInsightsSystemSystemControls_List';
    'GET_systeminsights-system_id-system_info'                   = 'SystemInsightsSystemSystemInfo_List';
    'systeminsights_list_system_system_info'                     = 'SystemInsightsSystemSystemInfo_List';
    'GET_systeminsights-system_id-uptime'                        = 'SystemInsightsSystemUptime_List';
    'systeminsights_list_system_uptime'                          = 'SystemInsightsSystemUptime_List';
    'GET_systeminsights-system_id-users'                         = 'SystemInsightsSystemUsers_List';
    'systeminsights_list_system_users'                           = 'SystemInsightsSystemUsers_List';
    'systeminsights_list_uptime'                                 = 'SystemInsightsUptime_List';
    'GET_systeminsights-uptime'                                  = 'SystemInsightsUptime_List';
    'systeminsights_list_users'                                  = 'SystemInsightsUsers_List';
    'GET_systeminsights-users'                                   = 'SystemInsightsUsers_List';
    'graph_systemMemberOf'                                       = 'SystemMemberOf_List';
    'GET_systems-system_id-memberof'                             = 'SystemMemberOf_List';
    'graph_systemTraverseCommand'                                = 'SystemTraverseCommand_List';
    'GET_systems-system_id-commands'                             = 'SystemTraverseCommand_List';
    'graph_systemTraversePolicy'                                 = 'SystemTraversePolicy_List';
    'GET_systems-system_id-policies'                             = 'SystemTraversePolicy_List';
    'graph_systemTraverseUser'                                   = 'SystemTraverseUser_List';
    'GET_systems-system_id-users'                                = 'SystemTraverseUser_List';
    'graph_systemTraverseUserGroup'                              = 'SystemTraverseUserGroup_List';
    'GET_systems-system_id-usergroups'                           = 'SystemTraverseUserGroup_List';
    'graph_userAssociationsList'                                 = 'UserAssociation_List';
    'GET_users-user_id-associations'                             = 'UserAssociation_List';
    'graph_userAssociationsPost'                                 = 'UserAssociation_Set';
    'POST_users-user_id-associations'                            = 'UserAssociation_Set';
    'groups_user_post'                                           = 'UserGroup_Create';
    'POST_usergroups'                                            = 'UserGroup_Create';
    'groups_user_delete'                                         = 'UserGroup_Delete';
    'DELETE_usergroups-id'                                       = 'UserGroup_Delete';
    'groups_user_get'                                            = 'UserGroup_Get';
    'GET_usergroups-id'                                          = 'UserGroup_Get';
    'groups_user_list'                                           = 'UserGroup_List';
    'GET_usergroups'                                             = 'UserGroup_List';
    'groups_user_put'                                            = 'UserGroup_Put';
    'PUT_usergroups-id'                                          = 'UserGroup_Put';
    'graph_userGroupAssociationsList'                            = 'UserGroupAssociation_List';
    'GET_usergroups-group_id-associations'                       = 'UserGroupAssociation_List';
    'graph_userGroupAssociationsPost'                            = 'UserGroupAssociation_Set';
    'POST_usergroups-group_id-associations'                      = 'UserGroupAssociation_Set';
    'graph_userGroupMembersList'                                 = 'UserGroupMembers_List';
    'GET_usergroups-group_id-members'                            = 'UserGroupMembers_List';
    'graph_userGroupMembersPost'                                 = 'UserGroupMembers_Set';
    'POST_usergroups-group_id-members'                           = 'UserGroupMembers_Set';
    'graph_userGroupMembership'                                  = 'UserGroupMembership_List';
    'GET_usergroups-group_id-membership'                         = 'UserGroupMembership_List';
    'graph_userGroupTraverseApplication'                         = 'UserGroupTraverseApplication_List';
    'GET_usergroups-group_id-applications'                       = 'UserGroupTraverseApplication_List';
    'graph_userGroupTraverseDirectory'                           = 'UserGroupTraverseDirectory_List';
    'GET_usergroups-group_id-directories'                        = 'UserGroupTraverseDirectory_List';
    'graph_userGroupTraverseGSuite'                              = 'UserGroupTraverseGSuite_List';
    'GET_usergroups-group_id-gsuites'                            = 'UserGroupTraverseGSuite_List';
    'graph_userGroupTraverseLdapServer'                          = 'UserGroupTraverseLdapServer_List';
    'GET_usergroups-group_id-ldapservers'                        = 'UserGroupTraverseLdapServer_List';
    'graph_userGroupTraverseOffice365'                           = 'UserGroupTraverseOffice365_List';
    'GET_usergroups-group_id-office365s'                         = 'UserGroupTraverseOffice365_List';
    'graph_userGroupTraverseRadiusServer'                        = 'UserGroupTraverseRadiusServer_List';
    'GET_usergroups-group_id-radiusservers'                      = 'UserGroupTraverseRadiusServer_List';
    'graph_userGroupTraverseSystem'                              = 'UserGroupTraverseSystem_List';
    'GET_usergroups-group_id-systems'                            = 'UserGroupTraverseSystem_List';
    'graph_userGroupTraverseSystemGroup'                         = 'UserGroupTraverseSystemGroup_List';
    'GET_usergroups-group_id-systemgroups'                       = 'UserGroupTraverseSystemGroup_List';
    'graph_userMemberOf'                                         = 'UserMemberOf_List';
    'GET_users-user_id-memberof'                                 = 'UserMemberOf_List';
    'graph_userTraverseApplication'                              = 'UserTraverseApplication_List';
    'GET_users-user_id-applications'                             = 'UserTraverseApplication_List';
    'graph_userTraverseDirectory'                                = 'UserTraverseDirectory_List';
    'GET_users-user_id-directories'                              = 'UserTraverseDirectory_List';
    'graph_userTraverseGSuite'                                   = 'UserTraverseGSuite_List';
    'GET_users-user_id-gsuites'                                  = 'UserTraverseGSuite_List';
    'graph_userTraverseLdapServer'                               = 'UserTraverseLdapServer_List';
    'GET_users-user_id-ldapservers'                              = 'UserTraverseLdapServer_List';
    'graph_userTraverseOffice365'                                = 'UserTraverseOffice365_List';
    'GET_users-user_id-office365s'                               = 'UserTraverseOffice365_List';
    'graph_userTraverseRadiusServer'                             = 'UserTraverseRadiusServer_List';
    'GET_users-user_id-radiusservers'                            = 'UserTraverseRadiusServer_List';
    'graph_userTraverseSystem'                                   = 'UserTraverseSystem_List';
    'GET_users-user_id-systems'                                  = 'UserTraverseSystem_List';
    'graph_userTraverseSystemGroup'                              = 'UserTraverseSystemGroup_List';
    'GET_users-user_id-systemgroups'                             = 'UserTraverseSystemGroup_List';
    'workdays_authorize'                                         = 'Workday_Authorize';
    'POST_workdays-workday_id-auth'                              = 'Workday_Authorize';
    'POST_workdays'                                              = 'Workday_Create';
    'workdays_post'                                              = 'Workday_Create';
    'workdays_get'                                               = 'Workday_Get';
    'GET_workdays-id'                                            = 'Workday_Get';
    'workdays_import'                                            = 'Workday_Import';
    'POST_workdays-workday_id-import'                            = 'Workday_Import';
    'GET_workdays'                                               = 'Workday_List';
    'workdays_list'                                              = 'Workday_List';
    'workdays_put'                                               = 'Workday_Put';
    'PUT_workdays-id'                                            = 'Workday_Put';
    'DELETE_workdays-workday_id-auth'                            = 'WorkdayAuthorization_Remove';
    'workdays_deauthorize'                                       = 'WorkdayAuthorization_Remove';
    'GET_workdays-id-import-job_id-results'                      = 'WorkdayResult_Import';
    'workdays_importresults'                                     = 'WorkdayResult_Import';
    'workdays_workers'                                           = 'WorkdayWorker_List';
    'GET_workdays-workday_id-workers'                            = 'WorkdayWorker_List';
    'activedirectories_post'                                     = 'ActiveDirectory_Create';
    'activedirectories_delete'                                   = 'ActiveDirectory_Delete';
    'activedirectories_agentsPost'                               = 'ActiveDirectoryAgent_Create';
    'activedirectories_agentsDelete'                             = 'ActiveDirectoryAgent_Delete';
    'activedirectories_agentsGet'                                = 'ActiveDirectoryAgent_Get';
    'activedirectories_agentsList'                               = 'ActiveDirectoryAgent_List';
    'graph_activeDirectoryAssociationsPost'                      = 'ActiveDirectoryAssociation_Set';
    'graph_activeDirectoryTraverseUser'                          = 'ActiveDirectoryTraverseUser_List';
    'applemdms_post'                                             = 'AppleMdm_Create';
    'applemdms_delete'                                           = 'AppleMdm_Delete';
    'applemdms_list'                                             = 'AppleMdm_List';
    'applemdms_put'                                              = 'AppleMdm_Put';
    'enrollmentprofiles_get'                                     = 'EnrollmentProfiles_Get';
    'enrollmentprofiles_list'                                    = 'EnrollmentProfiles_List';
    'jcEnrollmentProfiles_post'                                  = 'JCEnrollmentProfiles_Create';
    'jcEnrollmentProfiles_delete'                                = 'JCEnrollmentProfiles_Delete';
    'jcEnrollmentProfiles_get'                                   = 'JCEnrollmentProfiles_Get';
    'jcEnrollmentProfiles_list'                                  = 'JCEnrollmentProfiles_List';
    'jcEnrollmentProfiles_put'                                   = 'JCEnrollmentProfiles_Put';
    'jobs_get'                                                   = 'Job_Get';
    'jobs_results'                                               = 'JobResult_List';
    'org_crypto_get'                                             = 'OrgCrypto_Get';
    'org_crypto_put'                                             = 'OrgCrypto_Put';
    'knowledge_salesforceList'                                   = 'SalesForceKnowledge_List';
    'groups_system_patch'                                        = 'SystemGroup_Patch';
    'graph_systemGroupMemberOf'                                  = 'SystemGroupMemberOf_List';
    'systeminsights_list_alf'                                    = 'SystemInsightsAlf_List';
    'systeminsights_list_battery'                                = 'SystemInsightsBattery_List';
    'systeminsights_list_crashes'                                = 'SystemInsightsCrashes_List';
    'systeminsights_list_ie_extensions'                          = 'SystemInsightsIEExtensions_List';
    'systeminsights_list_launchd'                                = 'SystemInsightsLaunchd_List';
    'systeminsights_list_logged_in_users'                        = 'SystemInsightsLoggedInUsers_List';
    'systeminsights_list_managed_policies'                       = 'SystemInsightsManagedPolicies_List';
    'systeminsights_list_shadow'                                 = 'SystemInsightsShadow_List';
    'systeminsights_list_shared_folders'                         = 'SystemInsightsSharedFolders_List';
    'systeminsights_list_shared_resources'                       = 'SystemInsightsSharedResources_List';
    'systeminsights_list_sharing_preferences'                    = 'SystemInsightsSharingPreferences_List';
    'systeminsights_list_sip_config'                             = 'SystemInsightsSipConfig_List';
    'systeminsights_list_usb_devices'                            = 'SystemInsightsUSBDevices_List';
    'systeminsights_list_user_groups'                            = 'SystemInsightsUserGroups_List';
    'systeminsights_list_user_ssh_keys'                          = 'SystemInsightsUserSSHKeys_List';
    'systeminsights_list_windows_crashes'                        = 'SystemInsightsWindowsCrashes_List';
    'users_sendEmails'                                           = 'UserEmail_Send';
    'groups_user_patch'                                          = 'UserGroup_Patch';
    'graph_userGroupMemberOf'                                    = 'UserGroupMemberOf_List';
    'graph_userGroupTraverseActiveDirectory'                     = 'UserGroupTraverseActiveDirectory_List';
    'graph_userTraverseActiveDirectory'                          = 'UserTraverseActiveDirectory_List';
    'workdays_delete'                                            = 'Workday_Delete';
    'workdays_settings'                                          = 'WorkdaySetting_Get';
}
$ApiHash.GetEnumerator() | ForEach-Object {
    If ($_.Name.Replace('Url_', '') -in $APIName)
    {
        $OutputFileNameJson = ($_.Name).Split('_')[1] + '.json'
        $OutputFileNameYaml = ($_.Name).Split('_')[1] + '.yaml'
        $OutputFullPathJson = $OutputFilePath + $OutputFileNameJson
        $OutputFullPathYaml = $OutputFilePath + $OutputFileNameYaml
        If (-not (Test-Path -Path:($OutputFilePath)))
        {
            New-Item -Path:($OutputFilePath) -ItemType:('Directory')
        }
        $WebRequest = If ($_.Name -like 'Url_*')
        {
            (Invoke-WebRequest -Uri:($_.Value)).Content
        }
        Else
        {
            Get-Content -Path:($_.Value) -Raw
        }
        If ([System.String]::IsNullOrEmpty($WebRequest))
        {
            Write-Error ('No content was returned from: ' + $_.Value)
        }
        Else
        {
            # Prep json for find and replace by flattening string
            $ReadyForConvert = If ($_.Value -like '*.yaml*')
            {
                $WebRequest | ConvertFrom-Yaml -Ordered | ConvertTo-Yaml -JsonCompatible
            }
            Else
            {
                $WebRequest
            }
            # Manipulate JSON
            While ($ReadyForConvert -match "`n ")
            {
                $ReadyForConvert = $ReadyForConvert.Replace("`n ", "`n")
            }
            $ReadyForConvert = $ReadyForConvert.Replace("`n", "")
            While ($ReadyForConvert -match "`r ")
            {
                $ReadyForConvert = $ReadyForConvert.Replace("`r ", "`r")
            }
            $ReadyForConvert = $ReadyForConvert.Replace("`r", "")
            # Update operationIds
            $OperationIdTemplate = '"operationId": "{0}"'
            $OperationIdMatches = Select-String -InputObject:($ReadyForConvert) -Pattern:([regex]'(?s)(?<=operationId": ")(.*?)(?=".*?$)') -AllMatches
            $OperationIdMatchesValues = $OperationIdMatches.Matches.Value
            ForEach ($OperationIdMatchesValue In $OperationIdMatchesValues)
            {
                If ($OperationIdHash.Contains([System.String]$OperationIdMatchesValue))
                {
                    $Find = $OperationIdTemplate -f [System.String]$OperationIdMatchesValue
                    $Replace = $OperationIdTemplate -f $OperationIdHash.Item($OperationIdMatchesValue)
                    $ReadyForConvert = $ReadyForConvert.Replace($Find, $Replace)
                }
                Else
                {
                    Write-Warning ('Unknown ' + $_.Name + ' operationId: ' + $OperationIdMatchesValue + ';')
                }
            }
            # Make fixes to file
            $FindReplaceHash.GetEnumerator() | ForEach-Object {
                $PatternMatch = $ReadyForConvert | Select-String -Pattern:([regex]::Escape($_.Name))
                If (-not [System.String]::IsNullOrEmpty($PatternMatch))
                {
                    $ReadyForConvert = $ReadyForConvert.Replace([string]$_.Name, [string]$_.Value)
                    $ReadyForConvert = $ReadyForConvert.Replace([string]$PatternMatch.Matches.Value, [string]$_.Value)
                }
            }
            # Convert json string to object
            $ReadyForConvert | Out-File -FilePath:($OutputFilePath + ($_.Name).Split('_')[1] + '_ReadyForConvert.json')
            $JsonExport = $ReadyForConvert | ConvertFrom-Json -Depth:(99);
            # Remove tag elements
            $JsonExport.paths = $JsonExport.paths | Select-Object * -ExcludeProperty:('/tags', '/Tag/{name}', '/Tags/{name}');
            # Exclude stoplight sections where the property is hidden
            If ($JsonExport | Get-Member -MemberType NoteProperty | Where-Object { $_.Name -eq 'x-stoplight' })
            {
                # Remove "public": false elements
                $PathNames = ($JsonExport.paths | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } )
                ForEach ($PathName In $PathNames)
                {
                    $PathChildNames = ($JsonExport.paths.$PathName | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } )
                    ForEach ($PathChildName In $PathChildNames)
                    {
                        If ($JsonExport.paths.$PathName.$PathChildName.'x-stoplight'.public -eq $false)
                        {
                            Write-Warning ('Excluding "Path" "' + $PathName + '" "' + $PathChildName + '"')
                            $JsonExport.paths = $JsonExport.paths | Select-Object * -ExcludeProperty:($PathName)
                        }
                    }
                }
                $DefinitionNames = ($JsonExport.definitions | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } )
                ForEach ($DefinitionName In $DefinitionNames)
                {
                    If ($JsonExport.definitions.$DefinitionName.$DefinitionChildName.'x-stoplight'.public -eq $false)
                    {
                        Write-Warning ('Excluding "Definition" "' + $DefinitionName + '"')
                        $JsonExport.definitions = $JsonExport.definitions | Select-Object * -ExcludeProperty:($DefinitionName)
                    }
                }
                $TextSectionNames = ($JsonExport.'x-stoplight'.TextSections | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } )
                ForEach ($TextSectionName In $TextSectionNames)
                {
                    $TextSectionChildNames = ($JsonExport.'x-stoplight'.TextSections.$TextSectionName | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } )
                    ForEach ($TextSectionChildName In $TextSectionChildNames)
                    {
                        If ($JsonExport.'x-stoplight'.TextSections.$TextSectionName.$TextSectionChildName.'x-stoplight'.public -eq $false)
                        {
                            Write-Warning ('Excluding "TextSection" "' + $TextSectionName + '"')
                            $JsonExport.'x-stoplight'.TextSections = $JsonExport.'x-stoplight'.TextSections | Select-Object * -ExcludeProperty:($TextSectionName)
                        }
                    }
                }
            }

            # Sort the json properties
            $pathsHash = [ordered]@{ }
            $pathNames = ($JsonExport.paths | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } | Sort-Object)
            $pathsHash = [ordered]@{ }
            $pathNames | ForEach-Object {
                $pathName = $_
                $MethodHash = [ordered]@{ }
                $MethodNames = ($JsonExport.paths.$PathName | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name }) | Sort-Object
                $MethodNames | ForEach-Object {
                    $MethodName = $_
                    $Method = $JsonExport.paths.$PathName.$MethodName
                    $MethodHash.Add($MethodName, $Method)
                }
                $JsonExport.paths.$PathName = $MethodHash
                $pathsHash.Add($pathName, $JsonExport.paths.$pathName)
            }
            $JsonExport.paths = $pathsHash

            $parametersHash = [ordered]@{ }
            $parameterNames = ($JsonExport.parameters | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } | Sort-Object)
            $parametersHash = [ordered]@{ }
            $parameterNames | ForEach-Object {
                $parameterName = $_
                $parametersHash.Add($parameterName, $JsonExport.parameters.$parameterName)
            }
            $JsonExport.parameters = $parametersHash


            $definitionsHash = [ordered]@{ }
            $definitionsNames = ($JsonExport.definitions | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } | Sort-Object)
            $definitionsHash = [ordered]@{ }
            $definitionsNames | ForEach-Object {
                $definitionsName = $_
                $definitionsHash.Add($definitionsName, $JsonExport.definitions.$definitionsName)
            }
            $JsonExport.definitions = $definitionsHash

            # Export file
            # $WebRequest | Out-File -FilePath:($OutputFilePath + ($_.Name).Split('_')[1] + '_Org.json')
            $NewSpec = $JsonExport | ConvertTo-Json -Depth:(99)
            If (Test-Path -Path:($OutputFullPathJson))
            {
                $CurrentSpec = Get-Content -Path:($OutputFullPathJson) -Raw
                $CurrentSpecCompare = [System.String]$CurrentSpec.Trim() -split "`r"
                $NewSpecCompare = [System.String]$NewSpec.Trim() -split "`r"
                $CompareResults = Compare-Object -ReferenceObject:($CurrentSpecCompare) -DifferenceObject:($NewSpecCompare)
                $NewSpec | Out-File -FilePath:($OutputFullPathJson)
                If (-not [System.String]::IsNullOrEmpty($CompareResults))
                {
                    $UpdatedSpec = $true
                    $NewSpec | ConvertFrom-Json -Depth:(99) | ConvertTo-Yaml | Out-File -FilePath:($OutputFullPathYaml) -Force
                    # If ($env:USERNAME -eq 'VssAdministrator')
                    # {
                    #     Try
                    #     {
                    #         Invoke-Git -Arguments:('config user.email "' + $env:BUILD_REQUESTEDFOREMAIL + '";')
                    #         Invoke-Git -Arguments:('config user.name "' + $env:BUILD_REQUESTEDFOR + '";')
                    #         Invoke-Git -Arguments:('add -A')
                    #         Invoke-Git -Arguments:('status')
                    #         Invoke-Git -Arguments:('commit -m ' + '"Updating OAS spec: ' + $OutputFileNameJson + ';[skip ci]";')
                    #         Invoke-Git -Arguments:('push origin HEAD:refs/heads/' + $env:BUILD_SOURCEBRANCHNAME + ';')
                    #     }
                    #     Catch
                    #     {
                    #         Write-Error $_
                    #     }
                    # }
                }
            }
            Else
            {
                $UpdatedSpec = $true
                $NewSpec | Out-File -FilePath:($OutputFullPathJson)
                $NewSpec | ConvertFrom-Json -Depth:(99) | ConvertTo-Yaml | Out-File -FilePath:($OutputFullPathYaml) -Force
            }
        }
    }
}
Write-Host ("##vso[task.setvariable variable=UpdatedSpec]$UpdatedSpec")
Return $UpdatedSpec

# Invoke-Git [[-Arguments] <Object>] [-NoWindow <Object>] [-RedirectStandardError <Object>] [-RedirectStandardOutput  <Object>] [-UseShellExecute <Object>] [-Path <Object>] [-Quiet <Object>] [-Split <Object>] [-Raw <Object>] [-GitPath <String>] [<CommonParameters>]
# Publish-GithubRelease [-AccessToken] <String> [-RepositoryOwner] <String> [[-RepositoryName] <String>] [-TagName]    <String> [[-TargetCommit] <String>] [[-Name] <String>] [[-ReleaseText] <String>] [-Draft] [-PreRelease] [[-Artifact] <String[]>] [<CommonParameters>]
# Get-GitChangedFile [[-Path] <Object>] [[-Commit] <Object>] [[-Include] <String[]>] [[-Exclude] <String[]>] [-Resolve] [<CommonParameters>]

# Get-GitChangedFile -Path:('C:\Users\epanipinto\Documents\GitHub\jcapi-powershell')
