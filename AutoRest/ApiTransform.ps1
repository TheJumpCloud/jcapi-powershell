#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('V1', 'V2')][ValidateNotNullOrEmpty()][System.String[]]$APIName
)
Set-Location $PSScriptRoot
$ApiHash = [Ordered]@{
    # 'V1' = 'https://api.stoplight.io/v1/versions/sNtcAibbBX7Nizrmd/export/oas.yaml'; # StopLight
    # 'V2' = 'https://api.stoplight.io/v1/versions/JWvycPWBDeEZ3R5dF/export/oas.yaml'; # StopLight
    'V1' = 'https://api.stoplight.io/v1/versions/MeLBYr6CGg2f4g9Qh/export/oas.yaml' # Docs
    'V2' = 'https://api.stoplight.io/v1/versions/kP6fw2Ppd9ZbbfNmT/export/oas.yaml' # Docs
    # 'V1' = 'https://raw.githubusercontent.com/TheJumpCloud/SI/master/routes/webui/api/index.yaml?token=AK5FVUOCYLGLDFEW32YPIKS52VTCS'
    # 'V2' = 'https://raw.githubusercontent.com/TheJumpCloud/SI/master/routes/webui/api/v2/index.yaml?token=AK5FVUKXH6FIFU45LMFJIEC52VTEM'
}
$OutputFilePath = $PSScriptRoot + '/SwaggerSpecs/'
# Build Find and Replace table
$FindReplaceHash = [Ordered]@{
    # V1 Issues
    ',"/tags/{name}": {"parameters": [{"name": "name","in": "path","required": true,"type": "string"}],"delete": {"operationId": "tags_delete","summary": "Delete a Tag","tags": ["Tags"],"description": "Hidden as Tags is deprecated\n\nDelete a Tag.","parameters": [{"$ref": "#/parameters/trait:requestHeaders:Content-Type"},{"$ref": "#/parameters/trait:requestHeaders:Accept"}],"responses": {"200": {"description": "","schema": {"$ref": "#/definitions/tag"}}},"security": [{"x-api-key": []}]}}' = '' # Prevents PowerShell from parsing json. Within the "paths" section there is "/tags/{name}" and "/Tags/{name}" which causes a duplication error.
    '"": {"type": "string"}'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  = ''; # Prevents PowerShell from parsing json. # Property name can not be blank.
    # V2 Issues
    '"": {"domain": "veniam"}'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                = ''; # Prevents PowerShell from parsing json. # Property name can not be blank.
    # Path Issues
    '"#/definitions/system"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  = '"#/definitions/JcSystem"'; # The "system" class is a reserved word.
    '"system": {"title": "System"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                            = '"JcSystem": {"title": "System"'; # The "system" class is a reserved word.
    '"system": {"properties": {"_id"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                         = '"JcSystem": {"properties": {"_id"';
    # Issues with pulling from Docs - Adding missing definitions
    '"definitions": {"sshkeylist"'                                                                                                                                                                                                                                                                                                                                                                                                                                                                            = '"definitions": {"UserGroupGraphManagementReq": {"title": "UserGroupGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes."},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","description": "The graph type","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","system","system_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"SystemGroupGraphManagementReq": {"title": "SystemGroupGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes."},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","user","user_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"bulk-user-create": {"title": "Bulk User Create","type": "object","description": "See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.","properties": {"username": {"type": "string"},"firstname": {"type": "string"},"lastname": {"type": "string"},"email": {"type": "string"},"attributes": {"type": "array","description": "Map of additional attributes.","items": {"type": "object"}}}},"gsuite-patch-input": {"title": "GSuite Patch Input","type": "object","properties": {"userLockoutAction": {"type": "string","enum": ["suspend","maintain"]},"userPasswordExpirationAction": {"type": "string","enum": ["suspend","maintain"]}}},"UserGraphManagementReq": {"title": "UserGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes","properties": {"sudo": {"type": "object","properties": {"enabled": {"type": "boolean"},"withoutPassword": {"type": "boolean"}}}}},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","system","system_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"active-directory-input": {"title": "Active Directory Input","type": "object","properties": {"domain": {"type": "string","description": "Domain name for this Active Directory instance."}}},"sshkeylist"'
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
    '["boolean", "null"]'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     = '"boolean"';
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
$OperationIdMapping = [Ordered]@{
    # OperationId to Function name mapping - https://github.com/Azure/autorest.powershell/blob/a530bd721c9326a4356fba15638fee236722aca9/powershell/autorest-configuration.md
    'POST_applications'                                          = 'Create-Application'; # V1
    'applications_post'                                          = 'Create-Application'; # V1
    'applications_delete'                                        = 'Delete-Application'; # V1
    'DELETE_applications-id'                                     = 'Delete-Application'; # V1
    'applications_get'                                           = 'Get-Application'; # V1
    'GET_applications-id'                                        = 'Get-Application'; # V1
    'GET_applications'                                           = 'List-Application'; # V1
    'applications_list'                                          = 'List-Application'; # V1
    'applications_put'                                           = 'Put-Application'; # V1
    'PUT_applications-id'                                        = 'Put-Application'; # V1
    'application_templates_get'                                  = 'Get-ApplicationTemplate'; # V1
    'GET_application-templates-id'                               = 'Get-ApplicationTemplate'; # V1
    'GET_application-templates'                                  = 'List-ApplicationTemplate'; # V1
    'application_templates_list'                                 = 'List-ApplicationTemplate'; # V1
    'POST_commands'                                              = 'Create-Command'; # V1
    'commands_post'                                              = 'Create-Command'; # V1
    'commands_delete'                                            = 'Delete-Command'; # V1
    'DELETE_commands-id'                                         = 'Delete-Command'; # V1
    'commands_get'                                               = 'Get-Command'; # V1
    'GET_commands-id'                                            = 'Get-Command'; # V1
    'GET_commands'                                               = 'List-Command'; # V1
    'commands_list'                                              = 'List-Command'; # V1
    'commands_put'                                               = 'Put-Command'; # V1
    'PUT_commands-id'                                            = 'Put-Command'; # V1
    'command_file_get'                                           = 'Get-CommandFile'; # V1
    'GET_files-command-id'                                       = 'Get-CommandFile'; # V1
    'command_results_delete'                                     = 'Delete-CommandResult'; # V1
    'DELETE_commandresults-id'                                   = 'Delete-CommandResult'; # V1
    'command_results_get'                                        = 'Get-CommandResult'; # V1
    'GET_commandresults-id'                                      = 'Get-CommandResult'; # V1
    'GET_commandresults'                                         = 'List-CommandResult'; # V1
    'command_results_list'                                       = 'List-CommandResult'; # V1
    'command_trigger_webhook_post'                               = 'Start-CommandTriggerWebhook'; # V1
    'POST_command-trigger-triggername'                           = 'Start-CommandTriggerWebhook'; # V1
    'organizations_get'                                          = 'Get-Organization'; # V1
    'GET_organizations-id'                                       = 'Get-Organization'; # V1
    'GET_organizations'                                          = 'List-Organization'; # V1
    'organization_list'                                          = 'List-Organization'; # V1
    'organization_put'                                           = 'Put-Organization'; # V1
    'PUT_organizations-id'                                       = 'Put-Organization'; # V1
    'search_organizations_post'                                  = 'Search-Organization'; # V1
    'POST_search-organizations'                                  = 'Search-Organization'; # V1
    'radius_servers_post'                                        = 'Create-RadiusServer'; # V1
    'POST_radiusservers'                                         = 'Create-RadiusServer'; # V1
    'GET_radiusservers'                                          = 'List-RadiusServer'; # V1
    'radius_servers_list'                                        = 'List-RadiusServer'; # V1
    'radius_servers_put'                                         = 'Put-RadiusServer'; # V1
    'PUT_radiusservers-id'                                       = 'Put-RadiusServer'; # V1
    'sshkey_post'                                                = 'Create-SshKey'; # V1
    'POST_systemusers-id-sshkeys'                                = 'Create-SshKey'; # V1
    'sshkey_delete'                                              = 'Delete-SshKey'; # V1
    'DELETE_systemusers-systemuser_id-sshkeys-id'                = 'Delete-SshKey'; # V1
    'GET_systemusers-id-sshkeys'                                 = 'List-SshKey'; # V1
    'sshkey_list'                                                = 'List-SshKey'; # V1
    'systems_delete'                                             = 'Delete-System'; # V1
    'DELETE_systems-id'                                          = 'Delete-System'; # V1
    'systems_get'                                                = 'Get-System'; # V1
    'GET_systems-id'                                             = 'Get-System'; # V1
    'GET_systems'                                                = 'List-System'; # V1
    'systems_list'                                               = 'List-System'; # V1
    'systems_put'                                                = 'Put-System'; # V1
    'PUT_systems-id'                                             = 'Put-System'; # V1
    'search_systems_post'                                        = 'Search-System'; # V1
    'POST_search-systems'                                        = 'Search-System'; # V1
    'POST_systemusers'                                           = 'Create-SystemUser'; # V1
    'systemusers_post'                                           = 'Create-SystemUser'; # V1
    'systemusers_delete'                                         = 'Delete-SystemUser'; # V1
    'DELETE_systemusers-id'                                      = 'Delete-SystemUser'; # V1
    'systemusers_get'                                            = 'Get-SystemUser'; # V1
    'GET_systemusers-id'                                         = 'Get-SystemUser'; # V1
    'GET_systemusers'                                            = 'List-SystemUser'; # V1
    'systemusers_list'                                           = 'List-SystemUser'; # V1
    'systemusers_put'                                            = 'Put-SystemUser'; # V1
    'PUT_systemusers-id'                                         = 'Put-SystemUser'; # V1
    'search_systemusers_post'                                    = 'Search-SystemUser'; # V1
    'POST_search-systemusers'                                    = 'Search-SystemUser'; # V1
    'POST_systemusers-id-unlock'                                 = 'Unlock-SystemUser'; # V1
    'systemusers_unlock'                                         = 'Unlock-SystemUser'; # V1
    'POST_systemusers-id-resetmfa'                               = 'Reset-SystemUserMfa'; # V1
    'systemusers_resetmfa'                                       = 'Reset-SystemUserMfa'; # V1
    'POST_systemusers-id-expire'                                 = 'POST-ExpireSystemUserPassword'; # V1
    'GET_radiusservers-id'                                       = 'Get-RadiusServer'; # V1
    'POST_case'                                                  = 'New-SupportCase'; # V1
    'systems_systemusers_binding_list'                           = 'List-SystemsSystemUserBinding'; # V1
    'systems_systemusers_binding_put'                            = 'Put-SystemsSystemUserBinding'; # V1
    'systemusers_systems_binding_list'                           = 'List-SystemUsersSystemBinding'; # V1
    'systemusers_systems_binding_put'                            = 'Put-SystemUsersSystemBinding'; # V1
    'tags_post'                                                  = 'Create-Tag'; # V1
    'tags_delete'                                                = 'Delete-Tag'; # V1
    'tags_get'                                                   = 'Get-Tag'; # V1
    'tags_list'                                                  = 'List-Tag'; # V1
    'tags_put'                                                   = 'Put-Tag'; # V1
    'activedirectories_get'                                      = 'Get-ActiveDirectory'; # V2
    'GET_activedirectories-id'                                   = 'Get-ActiveDirectory'; # V2
    'activedirectories_list'                                     = 'List-ActiveDirectory'; # V2
    'GET_activedirectories'                                      = 'List-ActiveDirectory'; # V2
    'GET_activedirectories-activedirectory_id-associations'      = 'List-ActiveDirectoryAssociation'; # V2
    'graph_activeDirectoryAssociationsList'                      = 'List-ActiveDirectoryAssociation'; # V2
    'GET_activedirectories-activedirectory_id-usergroups'        = 'List-ActiveDirectoryTraverseUserGroup'; # V2
    'graph_activeDirectoryTraverseUserGroup'                     = 'List-ActiveDirectoryTraverseUserGroup'; # V2
    'GET_applications-application_id-associations'               = 'List-ApplicationAssociation'; # V2
    'graph_applicationAssociationsList'                          = 'List-ApplicationAssociation'; # V2
    'POST_applications-application_id-associations'              = 'Set-ApplicationAssociation'; # V2
    'graph_applicationAssociationsPost'                          = 'Set-ApplicationAssociation'; # V2
    'GET_applications-application_id-users'                      = 'List-ApplicationTraverseUser'; # V2
    'graph_applicationTraverseUser'                              = 'List-ApplicationTraverseUser'; # V2
    'GET_applications-application_id-usergroups'                 = 'List-ApplicationTraverseUserGroup'; # V2
    'graph_applicationTraverseUserGroup'                         = 'List-ApplicationTraverseUserGroup'; # V2
    'bulk_usersCreate'                                           = 'Create-BulkUsers'; # V2
    'POST_bulk-users'                                            = 'Create-BulkUsers'; # V2
    'bulk_usersCreateResults'                                    = 'Get-BulkUsersResult'; # V2
    'GET_bulk-users-job_id-results'                              = 'Get-BulkUsersResult'; # V2
    'GET_commands-command_id-associations'                       = 'List-CommandAssociation'; # V2
    'graph_commandAssociationsList'                              = 'List-CommandAssociation'; # V2
    'POST_commands-command_id-associations'                      = 'Set-CommandAssociation'; # V2
    'graph_commandAssociationsPost'                              = 'Set-CommandAssociation'; # V2
    'GET_commands-command_id-systems'                            = 'List-CommandTraverseSystem'; # V2
    'graph_commandTraverseSystem'                                = 'List-CommandTraverseSystem'; # V2
    'GET_commands-command_id-systemgroups'                       = 'List-CommandTraverseSystemGroup'; # V2
    'graph_commandTraverseSystemGroup'                           = 'List-CommandTraverseSystemGroup'; # V2
    'GET_directories'                                            = 'List-Directory'; # V2
    'directories_list'                                           = 'List-Directory'; # V2
    'duo_accountPost'                                            = 'Create-DuoAccount'; # V2
    'POST_duo-accounts'                                          = 'Create-DuoAccount'; # V2
    'duo_accountDelete'                                          = 'Delete-DuoAccount'; # V2
    'DELETE_duo-accounts-id'                                     = 'Delete-DuoAccount'; # V2
    'duo_accountGet'                                             = 'Get-DuoAccount'; # V2
    'GET_duo-accounts-id'                                        = 'Get-DuoAccount'; # V2
    'GET_duo-accounts'                                           = 'List-DuoAccount'; # V2
    'duo_accountList'                                            = 'List-DuoAccount'; # V2
    'duo_applicationPost'                                        = 'Create-DuoApplication'; # V2
    'POST_duo-accounts-account_id-applications'                  = 'Create-DuoApplication'; # V2
    'duo_applicationDelete'                                      = 'Delete-DuoApplication'; # V2
    'DELETE_duo-accounts-account_id-applications-application_id' = 'Delete-DuoApplication'; # V2
    'duo_applicationGet'                                         = 'Get-DuoApplication'; # V2
    'GET_duo-accounts-account_id-applications-application_id'    = 'Get-DuoApplication'; # V2
    'GET_duo-accounts-account_id-applications'                   = 'List-DuoApplication'; # V2
    'duo_applicationList'                                        = 'List-DuoApplication'; # V2
    'PUT_duo-accounts-account_id-applications-application_id'    = 'Put-DuoApplication'; # V2
    'duo_applicationUpdate'                                      = 'Put-DuoApplication'; # V2
    'GET_groups'                                                 = 'List-Group'; # V2
    'groups_list'                                                = 'List-Group'; # V2
    'gsuites_get'                                                = 'Get-GSuite'; # V2
    'GET_gsuites-id'                                             = 'Get-GSuite'; # V2
    'gsuites_patch'                                              = 'Patch-GSuite'; # V2
    'PATCH_gsuites-id'                                           = 'Patch-GSuite'; # V2
    'graph_gSuiteAssociationsList'                               = 'List-GSuiteAssociation'; # V2
    'GET_gsuites-gsuite_id-associations'                         = 'List-GSuiteAssociation'; # V2
    'graph_gSuiteAssociationsPost'                               = 'Set-GSuiteAssociation'; # V2
    'POST_gsuites-gsuite_id-associations'                        = 'Set-GSuiteAssociation'; # V2
    'POST_gsuites-gsuite_id-translationrules'                    = 'Create-GSuiteTranslationRule'; # V2
    'translationRules_gSuitePost'                                = 'Create-GSuiteTranslationRule'; # V2
    'DELETE_gsuites-gsuite_id-translationrules-id'               = 'Delete-GSuiteTranslationRule'; # V2
    'translationRules_gSuiteDelete'                              = 'Delete-GSuiteTranslationRule'; # V2
    'GET_gsuites-gsuite_id-translationrules-id'                  = 'Get-GSuiteTranslationRule'; # V2
    'translationRules_gSuiteGet'                                 = 'Get-GSuiteTranslationRule'; # V2
    'GET_gsuites-gsuite_id-translationrules'                     = 'List-GSuiteTranslationRule'; # V2
    'translationRules_gSuiteList'                                = 'List-GSuiteTranslationRule'; # V2
    'graph_gSuiteTraverseUser'                                   = 'List-GSuiteTraverseUser'; # V2
    'GET_gsuites-gsuite_id-users'                                = 'List-GSuiteTraverseUser'; # V2
    'graph_gSuiteTraverseUserGroup'                              = 'List-GSuiteTraverseUserGroup'; # V2
    'GET_gsuites-gsuite_id-usergroups'                           = 'List-GSuiteTraverseUserGroup'; # V2
    'ldapservers_get'                                            = 'Get-LdapServer'; # V2
    'GET_ldapservers-id'                                         = 'Get-LdapServer'; # V2
    'GET_ldapservers'                                            = 'List-LdapServer'; # V2
    'ldapservers_list'                                           = 'List-LdapServer'; # V2
    'ldapservers_patch'                                          = 'Patch-LdapServer'; # V2
    'PATCH_ldapservers-id'                                       = 'Patch-LdapServer'; # V2
    'graph_ldapServerAssociationsList'                           = 'List-LdapServerAssociation'; # V2
    'GET_ldapservers-ldapserver_id-associations'                 = 'List-LdapServerAssociation'; # V2
    'graph_ldapServerAssociationsPost'                           = 'Set-LdapServerAssociation'; # V2
    'POST_ldapservers-ldapserver_id-associations'                = 'Set-LdapServerAssociation'; # V2
    'ldapservers_sambaDomainsPost'                               = 'Create-LdapServerSambaDomain'; # V2
    'POST_ldapservers-ldapserver_id-sambadomains'                = 'Create-LdapServerSambaDomain'; # V2
    'ldapservers_sambaDomainsDelete'                             = 'Delete-LdapServerSambaDomain'; # V2
    'DELETE_ldapservers-ldapserver_id-sambadomains-id'           = 'Delete-LdapServerSambaDomain'; # V2
    'ldapservers_sambaDomainsGet'                                = 'Get-LdapServerSambaDomain'; # V2
    'GET_ldapservers-ldapserver_id-sambadomains-id'              = 'Get-LdapServerSambaDomain'; # V2
    'ldapservers_sambaDomainsList'                               = 'List-LdapServerSambaDomain'; # V2
    'GET_ldapservers-ldapserver_id-sambadomains'                 = 'List-LdapServerSambaDomain'; # V2
    'ldapservers_sambaDomainsPut'                                = 'Put-LdapServerSambaDomain'; # V2
    'PUT_ldapservers-ldapserver_id-sambadomains-id'              = 'Put-LdapServerSambaDomain'; # V2
    'graph_ldapServerTraverseUser'                               = 'List-LdapServerTraverseUser'; # V2
    'GET_ldapservers-ldapserver_id-users'                        = 'List-LdapServerTraverseUser'; # V2
    'graph_ldapServerTraverseUserGroup'                          = 'List-LdapServerTraverseUserGroup'; # V2
    'GET_ldapservers-ldapserver_id-usergroups'                   = 'List-LdapServerTraverseUserGroup'; # V2
    'graph_office365AssociationsList'                            = 'List-Office365Association'; # V2
    'GET_office365s-office365_id-associations'                   = 'List-Office365Association'; # V2
    'graph_office365AssociationsPost'                            = 'Set-Office365Association'; # V2
    'POST_office365s-office365_id-associations'                  = 'Set-Office365Association'; # V2
    'POST_office365s-office365_id-translationrules'              = 'Create-Office365TranslationRule'; # V2
    'translationRules_office365Post'                             = 'Create-Office365TranslationRule'; # V2
    'DELETE_office365s-office365_id-translationrules-id'         = 'Delete-Office365TranslationRule'; # V2
    'translationRules_office365Delete'                           = 'Delete-Office365TranslationRule'; # V2
    'GET_office365s-office365_id-translationrules-id'            = 'Get-Office365TranslationRule'; # V2
    'translationRules_office365Get'                              = 'Get-Office365TranslationRule'; # V2
    'GET_office365s-office365_id-translationrules'               = 'List-Office365TranslationRule'; # V2
    'translationRules_office365List'                             = 'List-Office365TranslationRule'; # V2
    'graph_office365TraverseUser'                                = 'List-Office365TraverseUser'; # V2
    'GET_office365s-office365_id-users'                          = 'List-Office365TraverseUser'; # V2
    'graph_office365TraverseUserGroup'                           = 'List-Office365TraverseUserGroup'; # V2
    'GET_office365s-office365_id-usergroups'                     = 'List-Office365TraverseUserGroup'; # V2
    'GET_policyresults'                                          = 'List-OrgPolicyResult'; # V2
    'policyresults_org_list'                                     = 'List-OrgPolicyResult'; # V2
    'POST_policies'                                              = 'Create-Policy'; # V2
    'policies_post'                                              = 'Create-Policy'; # V2
    'policies_delete'                                            = 'Delete-Policy'; # V2
    'DELETE_policies-id'                                         = 'Delete-Policy'; # V2
    'policies_get'                                               = 'Get-Policy'; # V2
    'GET_policies-id'                                            = 'Get-Policy'; # V2
    'GET_policies'                                               = 'List-Policy'; # V2
    'policies_list'                                              = 'List-Policy'; # V2
    'policies_put'                                               = 'Put-Policy'; # V2
    'PUT_policies-id'                                            = 'Put-Policy'; # V2
    'graph_policyAssociationsList'                               = 'List-PolicyAssociation'; # V2
    'GET_policies-policy_id-associations'                        = 'List-PolicyAssociation'; # V2
    'graph_policyAssociationsPost'                               = 'Set-PolicyAssociation'; # V2
    'POST_policies-policy_id-associations'                       = 'Set-PolicyAssociation'; # V2
    'policyresults_get'                                          = 'Get-PolicyResult'; # V2
    'GET_policyresults-id'                                       = 'Get-PolicyResult'; # V2
    'GET_policies-policy_id-policyresults'                       = 'List-PolicyResult'; # V2
    'policyresults_list'                                         = 'List-PolicyResult'; # V2
    'GET_policies-policy_id-policystatuses'                      = 'List-PolicyStatus'; # V2
    'policystatuses_list'                                        = 'List-PolicyStatus'; # V2
    'GET_systems-system_id-policystatuses'                       = 'List-PolicyStatus'; # V2
    'policytemplates_get'                                        = 'Get-PolicyTemplate'; # V2
    'GET_policytemplates-id'                                     = 'Get-PolicyTemplate'; # V2
    'GET_policytemplates'                                        = 'List-PolicyTemplate'; # V2
    'policytemplates_list'                                       = 'List-PolicyTemplate'; # V2
    'graph_policyTraverseSystem'                                 = 'List-PolicyTraverseSystem'; # V2
    'GET_policies-policy_id-systems'                             = 'List-PolicyTraverseSystem'; # V2
    'graph_policyTraverseSystemGroup'                            = 'List-PolicyTraverseSystemGroup'; # V2
    'GET_policies-policy_id-systemgroups'                        = 'List-PolicyTraverseSystemGroup'; # V2
    'providers_postAdmins'                                       = 'Create-ProviderAdmin'; # V2
    'POST_providers-provider_id-administrators'                  = 'Create-ProviderAdmin'; # V2
    'providers_listAdministrators'                               = 'List-ProviderAdministrator'; # V2
    'GET_providers-provider_id-administrators'                   = 'List-ProviderAdministrator'; # V2
    'graph_radiusServerAssociationsList'                         = 'List-RadiusServerAssociation'; # V2
    'GET_radiusservers-radiusserver_id-associations'             = 'List-RadiusServerAssociation'; # V2
    'graph_radiusServerAssociationsPost'                         = 'Set-RadiusServerAssociation'; # V2
    'POST_radiusservers-radiusserver_id-associations'            = 'Set-RadiusServerAssociation'; # V2
    'graph_radiusServerTraverseUser'                             = 'List-RadiusServerTraverseUser'; # V2
    'GET_radiusservers-radiusserver_id-users'                    = 'List-RadiusServerTraverseUser'; # V2
    'graph_radiusServerTraverseUserGroup'                        = 'List-RadiusServerTraverseUserGroup'; # V2
    'GET_radiusservers-radiusserver_id-usergroups'               = 'List-RadiusServerTraverseUserGroup'; # V2
    'graph_systemAssociationsList'                               = 'List-SystemAssociation'; # V2
    'GET_systems-system_id-associations'                         = 'List-SystemAssociation'; # V2
    'graph_systemAssociationsPost'                               = 'Set-SystemAssociation'; # V2
    'POST_systems-system_id-associations'                        = 'Set-SystemAssociation'; # V2
    'systems_getFDEKey'                                          = 'Get-SystemFDEKey'; # V2
    'GET_systems-system_id-fdekey'                               = 'Get-SystemFDEKey'; # V2
    'groups_system_post'                                         = 'Create-SystemGroup'; # V2
    'POST_systemgroups'                                          = 'Create-SystemGroup'; # V2
    'groups_system_delete'                                       = 'Delete-SystemGroup'; # V2
    'DELETE_systemgroups-id'                                     = 'Delete-SystemGroup'; # V2
    'groups_system_get'                                          = 'Get-SystemGroup'; # V2
    'GET_systemgroups-id'                                        = 'Get-SystemGroup'; # V2
    'groups_system_list'                                         = 'List-SystemGroup'; # V2
    'GET_systemgroups'                                           = 'List-SystemGroup'; # V2
    'groups_system_put'                                          = 'Put-SystemGroup'; # V2
    'PUT_systemgroups-id'                                        = 'Put-SystemGroup'; # V2
    'graph_systemGroupAssociationsList'                          = 'List-SystemGroupAssociation'; # V2
    'GET_systemgroups-group_id-associations'                     = 'List-SystemGroupAssociation'; # V2
    'graph_systemGroupAssociationsPost'                          = 'Set-SystemGroupAssociation'; # V2
    'POST_systemgroups-group_id-associations'                    = 'Set-SystemGroupAssociation'; # V2
    'graph_systemGroupMembersList'                               = 'List-SystemGroupMembers'; # V2
    'GET_systemgroups-group_id-members'                          = 'List-SystemGroupMembers'; # V2
    'graph_systemGroupMembersPost'                               = 'Set-SystemGroupMembers'; # V2
    'POST_systemgroups-group_id-members'                         = 'Set-SystemGroupMembers'; # V2
    'graph_systemGroupMembership'                                = 'List-SystemGroupMembership'; # V2
    'GET_systemgroups-group_id-membership'                       = 'List-SystemGroupMembership'; # V2
    'graph_systemGroupTraverseCommand'                           = 'List-SystemGroupTraverseCommand'; # V2
    'GET_systemgroups-group_id-commands'                         = 'List-SystemGroupTraverseCommand'; # V2
    'graph_systemGroupTraversePolicy'                            = 'List-SystemGroupTraversePolicy'; # V2
    'GET_systemgroups-group_id-policies'                         = 'List-SystemGroupTraversePolicy'; # V2
    'graph_systemGroupTraverseUser'                              = 'List-SystemGroupTraverseUser'; # V2
    'GET_systemgroups-group_id-users'                            = 'List-SystemGroupTraverseUser'; # V2
    'graph_systemGroupTraverseUserGroup'                         = 'List-SystemGroupTraverseUserGroup'; # V2
    'GET_systemgroups-group_id-usergroups'                       = 'List-SystemGroupTraverseUserGroup'; # V2
    'systeminsights_list_alf'                                    = 'List-SystemInsightsAlf'; # V2
    'GET_systeminsights-alf'                                     = 'List-SystemInsightsAlf'; # V2
    'systeminsights_list_apps'                                   = 'List-SystemInsightsApps'; # V2
    'GET_systeminsights-apps'                                    = 'List-SystemInsightsApps'; # V2
    'systeminsights_list_battery'                                = 'List-SystemInsightsBattery'; # V2
    'GET_systeminsights-battery'                                 = 'List-SystemInsightsBattery'; # V2
    'systeminsights_list_bitlocker_info'                         = 'List-SystemInsightsBitlockerInfo'; # V2
    'GET_systeminsights-bitlocker_info'                          = 'List-SystemInsightsBitlockerInfo'; # V2
    'systeminsights_list_browser_plugins'                        = 'List-SystemInsightsBrowserPlugins'; # V2
    'GET_systeminsights-browser_plugins'                         = 'List-SystemInsightsBrowserPlugins'; # V2
    'systeminsights_list_chrome_extensions'                      = 'List-SystemInsightsChromeExtensions'; # V2
    'GET_systeminsights-chrome_extensions'                       = 'List-SystemInsightsChromeExtensions'; # V2
    'systeminsights_list_crashes'                                = 'List-SystemInsightsCrashes'; # V2
    'GET_systeminsights-crashes'                                 = 'List-SystemInsightsCrashes'; # V2
    'systeminsights_list_disk_encryption'                        = 'List-SystemInsightsDiskEncryption'; # V2
    'GET_systeminsights-disk_encryption'                         = 'List-SystemInsightsDiskEncryption'; # V2
    'systeminsights_list_disk_info'                              = 'List-SystemInsightsDiskInfo'; # V2
    'GET_systeminsights-disk_info'                               = 'List-SystemInsightsDiskInfo'; # V2
    'systeminsights_list_etc_hosts'                              = 'List-SystemInsightsEtcHosts'; # V2
    'GET_systeminsights-etc_hosts'                               = 'List-SystemInsightsEtcHosts'; # V2
    'systeminsights_list_firefox_addons'                         = 'List-SystemInsightsFirefoxAddons'; # V2
    'GET_systeminsights-firefox_addons'                          = 'List-SystemInsightsFirefoxAddons'; # V2
    'systeminsights_list_groups'                                 = 'List-SystemInsightsGroups'; # V2
    'GET_systeminsights-groups'                                  = 'List-SystemInsightsGroups'; # V2
    'GET_systeminsights-user_groups'                             = 'List-SystemInsightsGroups'; # V2
    'systeminsights_list_ie_extensions'                          = 'List-SystemInsightsIEExtensions'; # V2
    'GET_systeminsights-ie_extensions'                           = 'List-SystemInsightsIEExtensions'; # V2
    'systeminsights_list_interface_addresses'                    = 'List-SystemInsightsInterfaceAddresses'; # V2
    'GET_systeminsights-interface_addresses'                     = 'List-SystemInsightsInterfaceAddresses'; # V2
    'systeminsights_list_kernel_info'                            = 'List-SystemInsightsKernelInfo'; # V2
    'GET_systeminsights-kernel_info'                             = 'List-SystemInsightsKernelInfo'; # V2
    'systeminsights_list_launchd'                                = 'List-SystemInsightsLaunchd'; # V2
    'GET_systeminsights-launchd'                                 = 'List-SystemInsightsLaunchd'; # V2
    'systeminsights_list_logged_in_users'                        = 'List-SystemInsightsLoggedInUsers'; # V2
    'GET_systeminsights-logged_in_users'                         = 'List-SystemInsightsLoggedInUsers'; # V2
    'systeminsights_list_logical_drives'                         = 'List-SystemInsightsLogicalDrives'; # V2
    'GET_systeminsights-logical_drives'                          = 'List-SystemInsightsLogicalDrives'; # V2
    'systeminsights_list_managed_policies'                       = 'List-SystemInsightsManagedPolicies'; # V2
    'GET_systeminsights-managed_policies'                        = 'List-SystemInsightsManagedPolicies'; # V2
    'systeminsights_list_mounts'                                 = 'List-SystemInsightsMounts'; # V2
    'GET_systeminsights-mounts'                                  = 'List-SystemInsightsMounts'; # V2
    'systeminsights_list_os_version'                             = 'List-SystemInsightsOsVersion'; # V2
    'GET_systeminsights-os_version'                              = 'List-SystemInsightsOsVersion'; # V2
    'systeminsights_list_patches'                                = 'List-SystemInsightsPatches'; # V2
    'GET_systeminsights-patches'                                 = 'List-SystemInsightsPatches'; # V2
    'systeminsights_list_programs'                               = 'List-SystemInsightsPrograms'; # V2
    'GET_systeminsights-programs'                                = 'List-SystemInsightsPrograms'; # V2
    'systeminsights_list_safari_extensions'                      = 'List-SystemInsightsSafariExtensions'; # V2
    'GET_systeminsights-safari_extensions'                       = 'List-SystemInsightsSafariExtensions'; # V2
    'systeminsights_list_shadow'                                 = 'List-SystemInsightsShadow'; # V2
    'GET_systeminsights-shadow'                                  = 'List-SystemInsightsShadow'; # V2
    'systeminsights_list_shared_folders'                         = 'List-SystemInsightsSharedFolders'; # V2
    'GET_systeminsights-shared_folders'                          = 'List-SystemInsightsSharedFolders'; # V2
    'systeminsights_list_shared_resources'                       = 'List-SystemInsightsSharedResources'; # V2
    'GET_systeminsights-shared_resources'                        = 'List-SystemInsightsSharedResources'; # V2
    'systeminsights_list_sharing_preferences'                    = 'List-SystemInsightsSharingPreferences'; # V2
    'GET_systeminsights-sharing_preferences'                     = 'List-SystemInsightsSharingPreferences'; # V2
    'systeminsights_list_sip_config'                             = 'List-SystemInsightsSipConfig'; # V2
    'GET_systeminsights-sip_config'                              = 'List-SystemInsightsSipConfig'; # V2
    'systeminsights_list_system_apps'                            = 'List-SystemInsightsSystemApps'; # V2
    'GET_systeminsights-system_id-apps'                          = 'List-SystemInsightsSystemApps'; # V2
    'systeminsights_list_system_bitlocker_info'                  = 'List-SystemInsightsSystemBitlockerInfo'; # V2
    'GET_systeminsights-system_id-bitlocker_info'                = 'List-SystemInsightsSystemBitlockerInfo'; # V2
    'systeminsights_list_system_browser_plugins'                 = 'List-SystemInsightsSystemBrowserPlugins'; # V2
    'GET_systeminsights-system_id-browser_plugins'               = 'List-SystemInsightsSystemBrowserPlugins'; # V2
    'systeminsights_list_system_chrome_extensions'               = 'List-SystemInsightsSystemChromeExtensions'; # V2
    'GET_systeminsights-system_id-chrome_extensions'             = 'List-SystemInsightsSystemChromeExtensions'; # V2
    'systeminsights_list_system_controls'                        = 'List-SystemInsightsSystemControls'; # V2
    'GET_systeminsights-system_controls'                         = 'List-SystemInsightsSystemControls'; # V2
    'systeminsights_list_system_disk_encryption'                 = 'List-SystemInsightsSystemDiskEncryption'; # V2
    'GET_systeminsights-system_id-disk_encryption'               = 'List-SystemInsightsSystemDiskEncryption'; # V2
    'systeminsights_list_system_disk_info'                       = 'List-SystemInsightsSystemDiskInfo'; # V2
    'GET_systeminsights-system_id-disk_info'                     = 'List-SystemInsightsSystemDiskInfo'; # V2
    'systeminsights_list_system_etc_hosts'                       = 'List-SystemInsightsSystemEtcHosts'; # V2
    'GET_systeminsights-system_id-etc_hosts'                     = 'List-SystemInsightsSystemEtcHosts'; # V2
    'systeminsights_list_system_firefox_addons'                  = 'List-SystemInsightsSystemFirefoxAddons'; # V2
    'GET_systeminsights-system_id-firefox_addons'                = 'List-SystemInsightsSystemFirefoxAddons'; # V2
    'systeminsights_list_system_groups'                          = 'List-SystemInsightsSystemGroups'; # V2
    'GET_systeminsights-system_id-groups'                        = 'List-SystemInsightsSystemGroups'; # V2
    'systeminsights_list_system_info'                            = 'List-SystemInsightsSystemInfo'; # V2
    'GET_systeminsights-system_info'                             = 'List-SystemInsightsSystemInfo'; # V2
    'GET_systeminsights-system_id-interface_addresses'           = 'List-SystemInsightsSystemInterfaceAddresses'; # V2
    'systeminsights_list_system_interface_addresses'             = 'List-SystemInsightsSystemInterfaceAddresses'; # V2
    'GET_systeminsights-system_id-kernel_info'                   = 'List-SystemInsightsSystemKernelInfo'; # V2
    'systeminsights_list_system_kernel_info'                     = 'List-SystemInsightsSystemKernelInfo'; # V2
    'GET_systeminsights-system_id-logical_drives'                = 'List-SystemInsightsSystemLogicalDrives'; # V2
    'systeminsights_list_system_logical_drives'                  = 'List-SystemInsightsSystemLogicalDrives'; # V2
    'GET_systeminsights-system_id-mounts'                        = 'List-SystemInsightsSystemLogicalMounts'; # V2
    'systeminsights_list_system_mounts'                          = 'List-SystemInsightsSystemLogicalMounts'; # V2
    'GET_systeminsights-system_id-os_version'                    = 'List-SystemInsightsSystemOSVersion'; # V2
    'systeminsights_list_system_os_version'                      = 'List-SystemInsightsSystemOSVersion'; # V2
    'GET_systeminsights-system_id-patches'                       = 'List-SystemInsightsSystemPatches'; # V2
    'systeminsights_list_system_patches'                         = 'List-SystemInsightsSystemPatches'; # V2
    'GET_systeminsights-system_id-programs'                      = 'List-SystemInsightsSystemPrograms'; # V2
    'systeminsights_list_system_programs'                        = 'List-SystemInsightsSystemPrograms'; # V2
    'GET_systeminsights-system_id-safari_extensions'             = 'List-SystemInsightsSystemSafariExtensions'; # V2
    'systeminsights_list_system_safari_extensions'               = 'List-SystemInsightsSystemSafariExtensions'; # V2
    'GET_systeminsights-system_id-system_controls'               = 'List-SystemInsightsSystemSystemControls'; # V2
    'systeminsights_list_system_system_controls'                 = 'List-SystemInsightsSystemSystemControls'; # V2
    'GET_systeminsights-system_id-system_info'                   = 'List-SystemInsightsSystemSystemInfo'; # V2
    'systeminsights_list_system_system_info'                     = 'List-SystemInsightsSystemSystemInfo'; # V2
    'GET_systeminsights-system_id-uptime'                        = 'List-SystemInsightsSystemUptime'; # V2
    'systeminsights_list_system_uptime'                          = 'List-SystemInsightsSystemUptime'; # V2
    'GET_systeminsights-system_id-users'                         = 'List-SystemInsightsSystemUsers'; # V2
    'systeminsights_list_system_users'                           = 'List-SystemInsightsSystemUsers'; # V2
    'systeminsights_list_uptime'                                 = 'List-SystemInsightsUptime'; # V2
    'GET_systeminsights-uptime'                                  = 'List-SystemInsightsUptime'; # V2
    'systeminsights_list_usb_devices'                            = 'List-SystemInsightsUSBDevices'; # V2
    'GET_systeminsights-usb_devices'                             = 'List-SystemInsightsUSBDevices'; # V2
    'systeminsights_list_users'                                  = 'List-SystemInsightsUsers'; # V2
    'GET_systeminsights-users'                                   = 'List-SystemInsightsUsers'; # V2
    'systeminsights_list_user_ssh_keys'                          = 'List-SystemInsightsUserSSHKeys'; # V2
    'GET_systeminsights-user_ssh_keys'                           = 'List-SystemInsightsUserSSHKeys'; # V2
    'systeminsights_list_windows_crashes'                        = 'List-SystemInsightsWindowsCrashes'; # V2
    'GET_systeminsights-windows_crashes'                         = 'List-SystemInsightsWindowsCrashes'; # V2
    'graph_systemMemberOf'                                       = 'List-SystemMemberOf'; # V2
    'GET_systems-system_id-memberof'                             = 'List-SystemMemberOf'; # V2
    'graph_systemTraverseCommand'                                = 'List-SystemTraverseCommand'; # V2
    'GET_systems-system_id-commands'                             = 'List-SystemTraverseCommand'; # V2
    'graph_systemTraversePolicy'                                 = 'List-SystemTraversePolicy'; # V2
    'GET_systems-system_id-policies'                             = 'List-SystemTraversePolicy'; # V2
    'graph_systemTraverseUser'                                   = 'List-SystemTraverseUser'; # V2
    'GET_systems-system_id-users'                                = 'List-SystemTraverseUser'; # V2
    'graph_systemTraverseUserGroup'                              = 'List-SystemTraverseUserGroup'; # V2
    'GET_systems-system_id-usergroups'                           = 'List-SystemTraverseUserGroup'; # V2
    'graph_userAssociationsList'                                 = 'List-UserAssociation'; # V2
    'GET_users-user_id-associations'                             = 'List-UserAssociation'; # V2
    'graph_userAssociationsPost'                                 = 'Set-UserAssociation'; # V2
    'POST_users-user_id-associations'                            = 'Set-UserAssociation'; # V2
    'groups_user_post'                                           = 'Create-UserGroup'; # V2
    'POST_usergroups'                                            = 'Create-UserGroup'; # V2
    'groups_user_delete'                                         = 'Delete-UserGroup'; # V2
    'DELETE_usergroups-id'                                       = 'Delete-UserGroup'; # V2
    'groups_user_get'                                            = 'Get-UserGroup'; # V2
    'GET_usergroups-id'                                          = 'Get-UserGroup'; # V2
    'groups_user_list'                                           = 'List-UserGroup'; # V2
    'GET_usergroups'                                             = 'List-UserGroup'; # V2
    'groups_user_put'                                            = 'Put-UserGroup'; # V2
    'PUT_usergroups-id'                                          = 'Put-UserGroup'; # V2
    'graph_userGroupAssociationsList'                            = 'List-UserGroupAssociation'; # V2
    'GET_usergroups-group_id-associations'                       = 'List-UserGroupAssociation'; # V2
    'graph_userGroupAssociationsPost'                            = 'Set-UserGroupAssociation'; # V2
    'POST_usergroups-group_id-associations'                      = 'Set-UserGroupAssociation'; # V2
    'graph_userGroupMembersList'                                 = 'List-UserGroupMembers'; # V2
    'GET_usergroups-group_id-members'                            = 'List-UserGroupMembers'; # V2
    'graph_userGroupMembersPost'                                 = 'Set-UserGroupMembers'; # V2
    'POST_usergroups-group_id-members'                           = 'Set-UserGroupMembers'; # V2
    'graph_userGroupMembership'                                  = 'List-UserGroupMembership'; # V2
    'GET_usergroups-group_id-membership'                         = 'List-UserGroupMembership'; # V2
    'graph_userGroupTraverseApplication'                         = 'List-UserGroupTraverseApplication'; # V2
    'GET_usergroups-group_id-applications'                       = 'List-UserGroupTraverseApplication'; # V2
    'graph_userGroupTraverseDirectory'                           = 'List-UserGroupTraverseDirectory'; # V2
    'GET_usergroups-group_id-directories'                        = 'List-UserGroupTraverseDirectory'; # V2
    'graph_userGroupTraverseGSuite'                              = 'List-UserGroupTraverseGSuite'; # V2
    'GET_usergroups-group_id-gsuites'                            = 'List-UserGroupTraverseGSuite'; # V2
    'graph_userGroupTraverseLdapServer'                          = 'List-UserGroupTraverseLdapServer'; # V2
    'GET_usergroups-group_id-ldapservers'                        = 'List-UserGroupTraverseLdapServer'; # V2
    'graph_userGroupTraverseOffice365'                           = 'List-UserGroupTraverseOffice365'; # V2
    'GET_usergroups-group_id-office365s'                         = 'List-UserGroupTraverseOffice365'; # V2
    'graph_userGroupTraverseRadiusServer'                        = 'List-UserGroupTraverseRadiusServer'; # V2
    'GET_usergroups-group_id-radiusservers'                      = 'List-UserGroupTraverseRadiusServer'; # V2
    'graph_userGroupTraverseSystem'                              = 'List-UserGroupTraverseSystem'; # V2
    'GET_usergroups-group_id-systems'                            = 'List-UserGroupTraverseSystem'; # V2
    'graph_userGroupTraverseSystemGroup'                         = 'List-UserGroupTraverseSystemGroup'; # V2
    'GET_usergroups-group_id-systemgroups'                       = 'List-UserGroupTraverseSystemGroup'; # V2
    'graph_userMemberOf'                                         = 'List-UserMemberOf'; # V2
    'GET_users-user_id-memberof'                                 = 'List-UserMemberOf'; # V2
    'graph_userTraverseApplication'                              = 'List-UserTraverseApplication'; # V2
    'GET_users-user_id-applications'                             = 'List-UserTraverseApplication'; # V2
    'graph_userTraverseDirectory'                                = 'List-UserTraverseDirectory'; # V2
    'GET_users-user_id-directories'                              = 'List-UserTraverseDirectory'; # V2
    'graph_userTraverseGSuite'                                   = 'List-UserTraverseGSuite'; # V2
    'GET_users-user_id-gsuites'                                  = 'List-UserTraverseGSuite'; # V2
    'graph_userTraverseLdapServer'                               = 'List-UserTraverseLdapServer'; # V2
    'GET_users-user_id-ldapservers'                              = 'List-UserTraverseLdapServer'; # V2
    'graph_userTraverseOffice365'                                = 'List-UserTraverseOffice365'; # V2
    'GET_users-user_id-office365s'                               = 'List-UserTraverseOffice365'; # V2
    'graph_userTraverseRadiusServer'                             = 'List-UserTraverseRadiusServer'; # V2
    'GET_users-user_id-radiusservers'                            = 'List-UserTraverseRadiusServer'; # V2
    'graph_userTraverseSystem'                                   = 'List-UserTraverseSystem'; # V2
    'GET_users-user_id-systems'                                  = 'List-UserTraverseSystem'; # V2
    'graph_userTraverseSystemGroup'                              = 'List-UserTraverseSystemGroup'; # V2
    'GET_users-user_id-systemgroups'                             = 'List-UserTraverseSystemGroup'; # V2
    'workdays_authorize'                                         = 'Authorize-Workday'; # V2
    'POST_workdays-workday_id-auth'                              = 'Authorize-Workday'; # V2
    'POST_workdays'                                              = 'Create-Workday'; # V2
    'workdays_post'                                              = 'Create-Workday'; # V2
    'workdays_get'                                               = 'Get-Workday'; # V2
    'GET_workdays-id'                                            = 'Get-Workday'; # V2
    'workdays_import'                                            = 'Import-Workday'; # V2
    'POST_workdays-workday_id-import'                            = 'Import-Workday'; # V2
    'GET_workdays'                                               = 'List-Workday'; # V2
    'workdays_list'                                              = 'List-Workday'; # V2
    'workdays_put'                                               = 'Put-Workday'; # V2
    'PUT_workdays-id'                                            = 'Put-Workday'; # V2
    'DELETE_workdays-workday_id-auth'                            = 'Remove-WorkdayAuthorization'; # V2
    'workdays_deauthorize'                                       = 'Remove-WorkdayAuthorization'; # V2
    'GET_workdays-id-import-job_id-results'                      = 'Import-WorkdayResult'; # V2
    'workdays_importresults'                                     = 'Import-WorkdayResult'; # V2
    'workdays_workers'                                           = 'List-WorkdayWorker'; # V2
    'GET_workdays-workday_id-workers'                            = 'List-WorkdayWorker'; # V2
    'activedirectories_post'                                     = 'Create-ActiveDirectory'; # V2
    'activedirectories_delete'                                   = 'Delete-ActiveDirectory'; # V2
    'activedirectories_agentsPost'                               = 'Create-ActiveDirectoryAgent'; # V2
    'activedirectories_agentsDelete'                             = 'Delete-ActiveDirectoryAgent'; # V2
    'activedirectories_agentsGet'                                = 'Get-ActiveDirectoryAgent'; # V2
    'activedirectories_agentsList'                               = 'List-ActiveDirectoryAgent'; # V2
    'graph_activeDirectoryAssociationsPost'                      = 'Set-ActiveDirectoryAssociation'; # V2
    'graph_activeDirectoryTraverseUser'                          = 'List-ActiveDirectoryTraverseUser'; # V2
    'applemdms_post'                                             = 'Create-AppleMdm'; # V2
    'applemdms_delete'                                           = 'Delete-AppleMdm'; # V2
    'applemdms_list'                                             = 'List-AppleMdm'; # V2
    'applemdms_put'                                              = 'Put-AppleMdm'; # V2
    'PATCH_bulk-users'                                           = 'Patch-BulkUsers'; # V2
    'bulk_usersUpdate'                                           = 'Put-BulkUsers'; # V2
    'enrollmentprofiles_get'                                     = 'Get-EnrollmentProfiles'; # V2
    'enrollmentprofiles_list'                                    = 'List-EnrollmentProfiles'; # V2
    'jcEnrollmentProfiles_post'                                  = 'Create-JCEnrollmentProfiles'; # V2
    'jcEnrollmentProfiles_delete'                                = 'Delete-JCEnrollmentProfiles'; # V2
    'jcEnrollmentProfiles_get'                                   = 'Get-JCEnrollmentProfiles'; # V2
    'jcEnrollmentProfiles_list'                                  = 'List-JCEnrollmentProfiles'; # V2
    'jcEnrollmentProfiles_put'                                   = 'Put-JCEnrollmentProfiles'; # V2
    'jobs_get'                                                   = 'Get-Job'; # V2
    'jobs_results'                                               = 'List-JobResult'; # V2
    'GET_office365s-office365_id'                                = 'Get-Office365'; # V2
    'PATCH_office365s-office365_id'                              = 'Patch-Office365'; # V2
    'org_crypto_get'                                             = 'Get-OrgCrypto'; # V2
    'org_crypto_put'                                             = 'Put-OrgCrypto'; # V2
    'knowledge_salesforceList'                                   = 'List-SalesForceKnowledge'; # V2
    'groups_system_patch'                                        = 'Patch-SystemGroup'; # V2
    'graph_systemGroupMemberOf'                                  = 'List-SystemGroupMemberOf'; # V2
    'systeminsights_list_user_groups'                            = 'List-SystemInsightsUserGroups'; # V2
    'users_sendEmails'                                           = 'Send-UserEmail'; # V2
    'groups_user_patch'                                          = 'Patch-UserGroup'; # V2
    'graph_userGroupMemberOf'                                    = 'List-UserGroupMemberOf'; # V2
    'graph_userGroupTraverseActiveDirectory'                     = 'List-UserGroupTraverseActiveDirectory'; # V2
    'graph_userTraverseActiveDirectory'                          = 'List-UserTraverseActiveDirectory'; # V2
    'workdays_delete'                                            = 'Delete-Workday'; # V2
    'workdays_settings'                                          = 'Get-WorkdaySetting'; # V2
}
$ApiHash.GetEnumerator() | ForEach-Object {
    If ($_.Name -in $APIName)
    {
        # Create output file path
        $OutputFileNameJson = $_.Name + '.json'
        $OutputFileNameYaml = $_.Name + '.yaml'
        $OutputFullPathJson = $OutputFilePath + $OutputFileNameJson
        $OutputFullPathYaml = $OutputFilePath + $OutputFileNameYaml
        If (-not (Test-Path -Path:($OutputFilePath)))
        {
            New-Item -Path:($OutputFilePath) -ItemType:('Directory')
        }
        # Get OAS content
        $OASContent = (Invoke-WebRequest -Uri:($_.Value)).Content
        If ([System.String]::IsNullOrEmpty($OASContent))
        {
            Write-Error ('No content was returned from: ' + $_.Value)
        }
        Else
        {
            # Prep json for find and replace by flattening string
            $ReadyForConvert = If ($_.Value -like '*.yaml*')
            {
                $OASContent | ConvertFrom-Yaml -Ordered | ConvertTo-Yaml -JsonCompatible
            }
            Else
            {
                $OASContent
            }
            # Remove line breaks from JSON to make the find and replace easier
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
            # Rename operationIds using $OperationIdMapping
            $OperationIdTemplate = '"operationId": "{0}"'
            $OperationIdMatches = Select-String -InputObject:($ReadyForConvert) -Pattern:([regex]'(?s)(?<=operationId": ")(.*?)(?=".*?$)') -AllMatches
            $OperationIdMatchesValues = $OperationIdMatches.Matches.Value
            $UnmappedOperationIds = @{ }
            ForEach ($OperationIdMatchesValue In $OperationIdMatchesValues)
            {
                If ($OperationIdMapping.Contains([System.String]$OperationIdMatchesValue))
                {
                    $Find = $OperationIdTemplate -f [System.String]$OperationIdMatchesValue
                    $Replace = $OperationIdTemplate -f $OperationIdMapping.Item($OperationIdMatchesValue)
                    $ReadyForConvert = $ReadyForConvert.Replace($Find, $Replace)
                }
                Else
                {
                    $UnmappedOperationIds.Add($OperationIdMatchesValue, $_.Name)
                }
            }
            # Check for unmapped operationIds
            If (-not [System.String]::IsNullOrEmpty($UnmappedOperationIds.Keys))
            {
                $UnmappedOperationIds.GetEnumerator() | ForEach-Object {
                    Write-Error ('Unknown ' + $_.Value + ' operationId: ' + $_.Key + ';')
                }
                Write-Error ( 'Please update the $OperationIdMapping variable within the \ApiTransform.ps1 file.')
                Exit
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
            $JsonExport = $ReadyForConvert | ConvertFrom-Json -Depth:(99);
            # Remove tag elements
            $JsonExport.paths = $JsonExport.paths | Select-Object * -ExcludeProperty:('/tags', '/Tag/{name}', '/Tags/{name}');
            # Exclude stoplight sections where the property is hidden
            If ($JsonExport | Get-Member -MemberType NoteProperty | Where-Object { $_.Name -eq 'x-stoplight' })
            {
                # Remove "public": false elements from "paths"
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
                # Remove "public": false elements from "definitions"
                $DefinitionNames = ($JsonExport.definitions | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } )
                ForEach ($DefinitionName In $DefinitionNames)
                {
                    If ($JsonExport.definitions.$DefinitionName.$DefinitionChildName.'x-stoplight'.public -eq $false)
                    {
                        Write-Warning ('Excluding "Definition" "' + $DefinitionName + '"')
                        $JsonExport.definitions = $JsonExport.definitions | Select-Object * -ExcludeProperty:($DefinitionName)
                    }
                }
                # Remove "public": false elements from "textsections"
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
            # Sort the json properties under "path"
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
            # Sort the json properties under "parameters"
            $parametersHash = [ordered]@{ }
            $parameterNames = ($JsonExport.parameters | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } | Sort-Object)
            $parametersHash = [ordered]@{ }
            $parameterNames | ForEach-Object {
                $parameterName = $_
                $parametersHash.Add($parameterName, $JsonExport.parameters.$parameterName)
            }
            $JsonExport.parameters = $parametersHash
            # Sort the json properties under "definitions"
            $definitionsHash = [ordered]@{ }
            $definitionsNames = ($JsonExport.definitions | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } | Sort-Object)
            $definitionsHash = [ordered]@{ }
            $definitionsNames | ForEach-Object {
                $definitionsName = $_
                $definitionsHash.Add($definitionsName, $JsonExport.definitions.$definitionsName)
            }
            $JsonExport.definitions = $definitionsHash
            # Convert json object to string
            $NewSpec = $JsonExport | ConvertTo-Json -Depth:(99)
            # Compare current spec to old spec and if they are diffrent then export the new file
            $UpdatedSpec = $false
            If (Test-Path -Path:($OutputFullPathJson))
            {
                $CurrentSpec = Get-Content -Path:($OutputFullPathJson) -Raw
                $CurrentSpecCompare = [System.String]$CurrentSpec.Trim() -split "`r"
                $NewSpecCompare = [System.String]$NewSpec.Trim() -split "`r"
                $CompareResults = Compare-Object -ReferenceObject:($CurrentSpecCompare) -DifferenceObject:($NewSpecCompare)
                If (-not [System.String]::IsNullOrEmpty($CompareResults))
                {
                    $UpdatedSpec = $true
                    # Export json
                    $NewSpec | Out-File -FilePath:($OutputFullPathJson)
                    # Export yaml
                    $NewSpec | ConvertFrom-Json -Depth:(99) | ConvertTo-Yaml | Out-File -FilePath:($OutputFullPathYaml) -Force
                }
                Else
                {
                    $UpdatedSpec = $false
                }
            }
            Else
            {
                $UpdatedSpec = $true
                # Export json
                $NewSpec | Out-File -FilePath:($OutputFullPathJson)
                # Export yaml
                $NewSpec | ConvertFrom-Json -Depth:(99) | ConvertTo-Yaml | Out-File -FilePath:($OutputFullPathYaml) -Force
            }
            ## Export content for troubleshooting
            # $ReadyForConvert | Out-File -FilePath:($OutputFilePath + $_.Name + '_ReadyForConvert.json')
            # $OASContent | Out-File -FilePath:($OutputFilePath + $_.Name + '_Org.json')
            # Return variable to Azure Pipelines
            Write-Host ("##vso[task.setvariable variable=UpdatedSpec]$UpdatedSpec")
            Return $UpdatedSpec
        }
    }
}
