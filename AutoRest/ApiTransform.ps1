#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('V1', 'V2')][ValidateNotNullOrEmpty()][System.String[]]$ApiName
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
$FixesMapping = @{
    # Not In V1 or V2 Issues
    # ',"/tags/{name}": {"parameters": [{"name": "name","in": "path","required": true,"type": "string"}],"delete": {"operationId": "tags_delete","summary": "Delete a Tag","tags": ["Tags"],"description": "Hidden as Tags is deprecated\n\nDelete a Tag.","parameters": [{"$ref": "#/parameters/trait:requestHeaders:Content-Type"},{"$ref": "#/parameters/trait:requestHeaders:Accept"}],"responses": {"200": {"description": "","schema": {"$ref": "#/definitions/tag"}}},"security": [{"x-api-key": []}]}}' = '' # Prevents PowerShell from parsing json. Within the "paths" section there is "/tags/{name}" and "/Tags/{name}" which causes a duplication error.
    # '"": {"type": "string"}'                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  = ''; # Prevents PowerShell from parsing json. # Property name can not be blank.
    # '"system": {"properties": {"_id"'                                                                  = '"JcSystem": {"properties": {"_id"';
    # '"type": "object","organization": {"type": "string","description": "The ID of the organization."}' = '"type":"object"'; # This section is in the wrong place within the json.
    # '"command": {"organization": {"description": "The ID of the organization.", "type": "string"},'    = '"command": {';
    # '["string","null"]'                                                                                                                   = '"string"'; # A type of null is not valid.
    # '["object", "null"]'                                                                                                                  = '"object"';
    # '["string","number","boolean","null"]'                                                                                                = '"string"'; # A type of null is not valid.
    # '["string","number","boolean"]'                                                                                                       = '"string"'; # Error: Invalid type 'string,number,boolean' in schema
    # '["boolean", "null"]'                                                                                                                 = '"boolean"';
    # '["null", "integer"]'                                                                                                                 = '"integer"';
    # '"type": ["null","integer"]'                               = '"type": "integer"'; # A type of null is not valid.
    # '"type": ["null", "integer"]'                              = '"type": "integer"'
    # '"tags": ["Systemusers"]'                                   = '"tags": ["SystemUsers"]'; # Change casing for pretty cmdlet names
    # '{"name": "Content-Type","in": "header","type": "string"},' = '';
    # '{"name": "Accept","in": "header","type": "string"},'       = '';
    # '{"name": "x-org-id","in": "header","type": "string"}'      = '';
    # ',,'                                                       = ',';
    # '{,'                                                       = '{';
    # '{ ,'                                                      = '{';
    # ',}'                                                       = '}';
    # ', }'                                                      = '}';
    # '[ ,'                                                      = '[';
    # ',]'                                                                                                                                  = ']';
    # ',"format": "ipv4"'                                        = ''; # Remove StopLight syntax
    'V1' = [Ordered]@{
        # Path Issues
        '"#/definitions/system"'                                                                                                              = '"#/definitions/JcSystem"'; # The "system" class is a reserved word.
        '"system": {"title": "System"'                                                                                                        = '"JcSystem": {"title": "System"'; # The "system" class is a reserved word.
        # Issues with pulling from Docs - Adding missing definitions
        '"definitions": {"sshkeylist"'                                                                                                        = '"definitions": {"UserGroupGraphManagementReq": {"title": "UserGroupGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes."},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","description": "The graph type","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","system","system_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"SystemGroupGraphManagementReq": {"title": "SystemGroupGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes."},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","user","user_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"bulk-user-create": {"title": "Bulk User Create","type": "object","description": "See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.","properties": {"username": {"type": "string"},"firstname": {"type": "string"},"lastname": {"type": "string"},"email": {"type": "string"},"attributes": {"type": "array","description": "Map of additional attributes.","items": {"type": "object"}}}},"gsuite-patch-input": {"title": "GSuite Patch Input","type": "object","properties": {"userLockoutAction": {"type": "string","enum": ["suspend","maintain"]},"userPasswordExpirationAction": {"type": "string","enum": ["suspend","maintain"]}}},"UserGraphManagementReq": {"title": "UserGraphManagementReq","type": "object","properties": {"attributes": {"type": ["object","null"],"description": "The graph connection''s attributes","properties": {"sudo": {"type": "object","properties": {"enabled": {"type": "boolean"},"withoutPassword": {"type": "boolean"}}}}},"op": {"type": "string","description": "How to modify the graph connection.","enum": ["add","remove","update"]},"type": {"type": "string","enum": ["active_directory","application","command","g_suite","ldap_server","office_365","policy","radius_server","system","system_group"]},"id": {"type": "string","description": "The ObjectID of graph object being added or removed as an association."}},"required": ["op","type","id"]},"active-directory-input": {"title": "Active Directory Input","type": "object","properties": {"domain": {"type": "string","description": "Domain name for this Active Directory instance."}}},"sshkeylist"'
        # V1 Issues
        '"basePath": "/api"'                                                                                                                  = '"basePath": "/api/"'; # The extra slash at the end is needed to properly build the url.
        '"command": {"title": "Command", "type": "object", "organization": {"type": "string", "description": "The ID of the organization."},' = '"command": {"title": "Command", "type": "object",'
        '"type": "null"'                                                                                                                      = '"type": "string"'; # A type of null is not valid.
        '["object","null"]'                                                                                                                   = '"object"'; # A type of null is not valid.
        # Custom Tweaks
        '{"$ref": "#/parameters/trait:requestHeaders:Content-Type"}'                                                                          = ''; # This will be passed in later through the Module.cs file.
        '{"$ref": "#/parameters/trait:requestHeaders:Accept"}'                                                                                = ''; # This will be passed in later through the Module.cs file.
        '{"$ref": "#/parameters/trait:multiTenantRequestHeaders:x-org-id"}'                                                                   = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
        ', ,'                                                                                                                                 = ',';
        '[,'                                                                                                                                  = '[';
        ', ]'                                                                                                                                 = ']';
        "`t"                                                                                                                                  = '\t';
    };
    'V2' = [Ordered]@{
        # V2 Issues
        '"basePath": "/api/v2"'                                             = '"basePath": "/api/v2/"'; # The extra slash at the end is needed to properly build the url.
        '["string", "number", "boolean"]'                                   = '"string"';
        '["string", "number", "boolean", "null"]'                           = '"string"';
        '["object", "null"]'                                                = '"object"';
        '["string", "null"]'                                                = '"string"';
        '"jobId"'                                                           = '"id"'; # The transform removes the "-" in the parent objects name, "job-id", which makes the parent name the same as the child.
        '"collection_time": ''2019-05-16T12:58:15.6730000-06:00'''          = '"collection_time": "2019-05-16T12:58:15.6730000-06:00"';
        '"collection_time": ''2019-06-03T13:41:29.7100000-06:00'''          = '"collection_time": "2019-06-03T13:41:29.7100000-06:00"';
        '"collection_time": ''2019-06-03T13:41:30.7710000-06:00'''          = '"collection_time": "2019-06-03T13:41:30.7710000-06:00"';
        '"collection_time": ''2019-06-03T13:41:31.5570000-06:00'''          = '"collection_time": "2019-06-03T13:41:31.5570000-06:00"';
        '"collection_time": ''2019-06-03T13:41:30.6580000-06:00'''          = '"collection_time": "2019-06-03T13:41:30.6580000-06:00"';
        '"collection_time": ''2019-06-03T13:41:30.8580000-06:00'''          = '"collection_time": "2019-06-03T13:41:30.8580000-06:00"';
        '"collection_time": ''2019-06-03T13:41:30.9330000-06:00'''          = '"collection_time": "2019-06-03T13:41:30.9330000-06:00"';
        '"collection_time": ''2019-06-03T13:41:31.0080000-06:00'''          = '"collection_time": "2019-06-03T13:41:31.0080000-06:00"';
        '"collection_time": ''2019-06-03T13:41:31.2040000-06:00'''          = '"collection_time": "2019-06-03T13:41:31.2040000-06:00"';
        '"collection_time": ''2019-06-03T13:41:31.1250000-06:00'''          = '"collection_time": "2019-06-03T13:41:31.1250000-06:00"';
        '"collection_time": ''2019-06-03T13:41:31.6730000-06:00'''          = '"collection_time": "2019-06-03T13:41:31.6730000-06:00"';
        '"collection_time": ''2019-06-03T13:41:31.7460000-06:00'''          = '"collection_time": "2019-06-03T13:41:31.7460000-06:00"';
        # Custom Tweaks
        '{"$ref": "#/parameters/trait:requestHeaders:Content-Type"}'        = ''; # This will be passed in later through the Module.cs file.
        '{"$ref": "#/parameters/trait:requestHeaders:Accept"}'              = ''; # This will be passed in later through the Module.cs file.
        '{"$ref": "#/parameters/trait:multiTenantRequestHeaders:x-org-id"}' = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
        ', ,'                                                               = ',';
        '[,'                                                                = '[';
        ', ]'                                                               = ']';
        "`t"                                                                = '\t';
    };
}
$OperationIdMapping = [Ordered]@{
    # OperationId to Function name mapping - https://github.com/Azure/autorest.powershell/blob/a530bd721c9326a4356fba15638fee236722aca9/powershell/autorest-configuration.md
    'V1' = [Ordered]@{
        'POST_applications'                           = 'Create-Application';
        'DELETE_applications-id'                      = 'Delete-Application';
        'GET_applications-id'                         = 'Get-Application';
        'GET_applications'                            = 'List-Application';
        'PUT_applications-id'                         = 'Put-Application';
        'GET_application-templates-id'                = 'Get-ApplicationTemplate';
        'GET_application-templates'                   = 'List-ApplicationTemplate';
        'POST_commands'                               = 'Create-Command';
        'DELETE_commands-id'                          = 'Delete-Command';
        'GET_commands-id'                             = 'Get-Command';
        'GET_commands'                                = 'List-Command';
        'PUT_commands-id'                             = 'Put-Command';
        'GET_files-command-id'                        = 'Get-CommandFile';
        'DELETE_commandresults-id'                    = 'Delete-CommandResult';
        'GET_commandresults-id'                       = 'Get-CommandResult';
        'GET_commandresults'                          = 'List-CommandResult';
        'POST_command-trigger-triggername'            = 'Start-CommandTriggerWebhook';
        'POST_systemusers-id-expire'                  = 'POST-ExpireSystemUserPassword';
        'GET_organizations-id'                        = 'Get-Organization';
        'GET_organizations'                           = 'List-Organization';
        'PUT_organizations-id'                        = 'Put-Organization';
        'POST_search-organizations'                   = 'Search-Organization';
        'POST_radiusservers'                          = 'Create-RadiusServer';
        'GET_radiusservers-id'                        = 'Get-RadiusServer';
        'GET_radiusservers'                           = 'List-RadiusServer';
        'PUT_radiusservers-id'                        = 'Put-RadiusServer';
        'POST_systemusers-id-sshkeys'                 = 'Create-SshKey';
        'DELETE_systemusers-systemuser_id-sshkeys-id' = 'Delete-SshKey';
        'GET_systemusers-id-sshkeys'                  = 'List-SshKey';
        'DELETE_systems-id'                           = 'Delete-System';
        'GET_systems-id'                              = 'Get-System';
        'GET_systems'                                 = 'List-System';
        'PUT_systems-id'                              = 'Put-System';
        'POST_search-systems'                         = 'Search-System';
        'POST_systemusers'                            = 'Create-SystemUser';
        'DELETE_systemusers-id'                       = 'Delete-SystemUser';
        'GET_systemusers-id'                          = 'Get-SystemUser';
        'GET_systemusers'                             = 'List-SystemUser';
        'PUT_systemusers-id'                          = 'Put-SystemUser';
        'POST_search-systemusers'                     = 'Search-SystemUser';
        'POST_systemusers-id-unlock'                  = 'Unlock-SystemUser';
        'POST_systemusers-id-resetmfa'                = 'Reset-SystemUserMfa';
    };
    'V2' = [Ordered]@{
        'GET_activedirectories-id'                                   = 'Get-ActiveDirectory';
        'GET_activedirectories'                                      = 'List-ActiveDirectory';
        'GET_activedirectories-activedirectory_id-associations'      = 'List-ActiveDirectoryAssociation';
        'GET_activedirectories-activedirectory_id-usergroups'        = 'List-ActiveDirectoryTraverseUserGroup';
        'GET_applications-application_id-associations'               = 'List-ApplicationAssociation';
        'POST_applications-application_id-associations'              = 'Set-ApplicationAssociation';
        'GET_applications-application_id-users'                      = 'List-ApplicationTraverseUser';
        'GET_applications-application_id-usergroups'                 = 'List-ApplicationTraverseUserGroup';
        'POST_bulk-users'                                            = 'Create-BulkUsers';
        'PATCH_bulk-users'                                           = 'Patch-BulkUsers';
        'GET_bulk-users-job_id-results'                              = 'Get-BulkUsersResult';
        'GET_commands-command_id-associations'                       = 'List-CommandAssociation';
        'POST_commands-command_id-associations'                      = 'Set-CommandAssociation';
        'GET_commands-command_id-systems'                            = 'List-CommandTraverseSystem';
        'GET_commands-command_id-systemgroups'                       = 'List-CommandTraverseSystemGroup';
        'GET_directories'                                            = 'List-Directory';
        'POST_duo-accounts'                                          = 'Create-DuoAccount';
        'DELETE_duo-accounts-id'                                     = 'Delete-DuoAccount';
        'GET_duo-accounts-id'                                        = 'Get-DuoAccount';
        'GET_duo-accounts'                                           = 'List-DuoAccount';
        'POST_duo-accounts-account_id-applications'                  = 'Create-DuoApplication';
        'DELETE_duo-accounts-account_id-applications-application_id' = 'Delete-DuoApplication';
        'GET_duo-accounts-account_id-applications-application_id'    = 'Get-DuoApplication';
        'GET_duo-accounts-account_id-applications'                   = 'List-DuoApplication';
        'PUT_duo-accounts-account_id-applications-application_id'    = 'Put-DuoApplication';
        'GET_groups'                                                 = 'List-Group';
        'GET_gsuites-id'                                             = 'Get-GSuite';
        'PATCH_gsuites-id'                                           = 'Patch-GSuite';
        'GET_gsuites-gsuite_id-associations'                         = 'List-GSuiteAssociation';
        'POST_gsuites-gsuite_id-associations'                        = 'Set-GSuiteAssociation';
        'POST_gsuites-gsuite_id-translationrules'                    = 'Create-GSuiteTranslationRule';
        'DELETE_gsuites-gsuite_id-translationrules-id'               = 'Delete-GSuiteTranslationRule';
        'GET_gsuites-gsuite_id-translationrules-id'                  = 'Get-GSuiteTranslationRule';
        'GET_gsuites-gsuite_id-translationrules'                     = 'List-GSuiteTranslationRule';
        'GET_gsuites-gsuite_id-users'                                = 'List-GSuiteTraverseUser';
        'GET_gsuites-gsuite_id-usergroups'                           = 'List-GSuiteTraverseUserGroup';
        'GET_ldapservers-id'                                         = 'Get-LdapServer';
        'GET_ldapservers'                                            = 'List-LdapServer';
        'PATCH_ldapservers-id'                                       = 'Patch-LdapServer';
        'GET_ldapservers-ldapserver_id-associations'                 = 'List-LdapServerAssociation';
        'POST_ldapservers-ldapserver_id-associations'                = 'Set-LdapServerAssociation';
        'POST_ldapservers-ldapserver_id-sambadomains'                = 'Create-LdapServerSambaDomain';
        'DELETE_ldapservers-ldapserver_id-sambadomains-id'           = 'Delete-LdapServerSambaDomain';
        'GET_ldapservers-ldapserver_id-sambadomains-id'              = 'Get-LdapServerSambaDomain';
        'GET_ldapservers-ldapserver_id-sambadomains'                 = 'List-LdapServerSambaDomain';
        'PUT_ldapservers-ldapserver_id-sambadomains-id'              = 'Put-LdapServerSambaDomain';
        'GET_ldapservers-ldapserver_id-users'                        = 'List-LdapServerTraverseUser';
        'GET_ldapservers-ldapserver_id-usergroups'                   = 'List-LdapServerTraverseUserGroup';
        'GET_office365s-office365_id'                                = 'Get-Office365';
        'PATCH_office365s-office365_id'                              = 'Patch-Office365';
        'GET_office365s-office365_id-associations'                   = 'List-Office365Association';
        'POST_office365s-office365_id-associations'                  = 'Set-Office365Association';
        'POST_office365s-office365_id-translationrules'              = 'Create-Office365TranslationRule';
        'DELETE_office365s-office365_id-translationrules-id'         = 'Delete-Office365TranslationRule';
        'GET_office365s-office365_id-translationrules-id'            = 'Get-Office365TranslationRule';
        'GET_office365s-office365_id-translationrules'               = 'List-Office365TranslationRule';
        'GET_office365s-office365_id-users'                          = 'List-Office365TraverseUser';
        'GET_office365s-office365_id-usergroups'                     = 'List-Office365TraverseUserGroup';
        'GET_policyresults'                                          = 'List-OrgPolicyResult';
        'POST_policies'                                              = 'Create-Policy';
        'DELETE_policies-id'                                         = 'Delete-Policy';
        'GET_policies-id'                                            = 'Get-Policy';
        'GET_policies'                                               = 'List-Policy';
        'PUT_policies-id'                                            = 'Put-Policy';
        'GET_policies-policy_id-associations'                        = 'List-PolicyAssociation';
        'POST_policies-policy_id-associations'                       = 'Set-PolicyAssociation';
        'GET_policyresults-id'                                       = 'Get-PolicyResult';
        'GET_policies-policy_id-policyresults'                       = 'List-PolicyResult';
        'GET_policies-policy_id-policystatuses'                      = 'List-PolicyStatus';
        'GET_systems-system_id-policystatuses'                       = 'List-PolicyStatus';
        'GET_policytemplates-id'                                     = 'Get-PolicyTemplate';
        'GET_policytemplates'                                        = 'List-PolicyTemplate';
        'GET_policies-policy_id-systems'                             = 'List-PolicyTraverseSystem';
        'GET_policies-policy_id-systemgroups'                        = 'List-PolicyTraverseSystemGroup';
        'POST_providers-provider_id-administrators'                  = 'Create-ProviderAdmin';
        'GET_providers-provider_id-administrators'                   = 'List-ProviderAdministrator';
        'GET_radiusservers-radiusserver_id-associations'             = 'List-RadiusServerAssociation';
        'POST_radiusservers-radiusserver_id-associations'            = 'Set-RadiusServerAssociation';
        'GET_radiusservers-radiusserver_id-users'                    = 'List-RadiusServerTraverseUser';
        'GET_radiusservers-radiusserver_id-usergroups'               = 'List-RadiusServerTraverseUserGroup';
        'GET_systems-system_id-associations'                         = 'List-SystemAssociation';
        'POST_systems-system_id-associations'                        = 'Set-SystemAssociation';
        'GET_systems-system_id-fdekey'                               = 'Get-SystemFDEKey';
        'POST_systemgroups'                                          = 'Create-SystemGroup';
        'DELETE_systemgroups-id'                                     = 'Delete-SystemGroup';
        'GET_systemgroups-id'                                        = 'Get-SystemGroup';
        'GET_systemgroups'                                           = 'List-SystemGroup';
        'PUT_systemgroups-id'                                        = 'Put-SystemGroup';
        'GET_systemgroups-group_id-associations'                     = 'List-SystemGroupAssociation';
        'POST_systemgroups-group_id-associations'                    = 'Set-SystemGroupAssociation';
        'GET_systemgroups-group_id-members'                          = 'List-SystemGroupMembers';
        'POST_systemgroups-group_id-members'                         = 'Set-SystemGroupMembers';
        'GET_systemgroups-group_id-membership'                       = 'List-SystemGroupMembership';
        'GET_systemgroups-group_id-commands'                         = 'List-SystemGroupTraverseCommand';
        'GET_systemgroups-group_id-policies'                         = 'List-SystemGroupTraversePolicy';
        'GET_systemgroups-group_id-users'                            = 'List-SystemGroupTraverseUser';
        'GET_systemgroups-group_id-usergroups'                       = 'List-SystemGroupTraverseUserGroup';
        'GET_systeminsights-alf'                                     = 'List-SystemInsightsAlf';
        'GET_systeminsights-apps'                                    = 'List-SystemInsightsApps';
        'GET_systeminsights-battery'                                 = 'List-SystemInsightsBattery';
        'GET_systeminsights-bitlocker_info'                          = 'List-SystemInsightsBitlockerInfo';
        'GET_systeminsights-browser_plugins'                         = 'List-SystemInsightsBrowserPlugins';
        'GET_systeminsights-chrome_extensions'                       = 'List-SystemInsightsChromeExtensions';
        'GET_systeminsights-crashes'                                 = 'List-SystemInsightsCrashes';
        'GET_systeminsights-disk_encryption'                         = 'List-SystemInsightsDiskEncryption';
        'GET_systeminsights-disk_info'                               = 'List-SystemInsightsDiskInfo';
        'GET_systeminsights-etc_hosts'                               = 'List-SystemInsightsEtcHosts';
        'GET_systeminsights-firefox_addons'                          = 'List-SystemInsightsFirefoxAddons';
        'GET_systeminsights-groups'                                  = 'List-SystemInsightsGroups';
        'GET_systeminsights-user_groups'                             = 'List-SystemInsightsGroups';
        'GET_systeminsights-ie_extensions'                           = 'List-SystemInsightsIEExtensions';
        'GET_systeminsights-interface_addresses'                     = 'List-SystemInsightsInterfaceAddresses';
        'GET_systeminsights-kernel_info'                             = 'List-SystemInsightsKernelInfo';
        'GET_systeminsights-launchd'                                 = 'List-SystemInsightsLaunchd';
        'GET_systeminsights-logged_in_users'                         = 'List-SystemInsightsLoggedInUsers';
        'GET_systeminsights-logical_drives'                          = 'List-SystemInsightsLogicalDrives';
        'GET_systeminsights-managed_policies'                        = 'List-SystemInsightsManagedPolicies';
        'GET_systeminsights-mounts'                                  = 'List-SystemInsightsMounts';
        'GET_systeminsights-os_version'                              = 'List-SystemInsightsOsVersion';
        'GET_systeminsights-patches'                                 = 'List-SystemInsightsPatches';
        'GET_systeminsights-programs'                                = 'List-SystemInsightsPrograms';
        'GET_systeminsights-safari_extensions'                       = 'List-SystemInsightsSafariExtensions';
        'GET_systeminsights-shadow'                                  = 'List-SystemInsightsShadow';
        'GET_systeminsights-shared_folders'                          = 'List-SystemInsightsSharedFolders';
        'GET_systeminsights-shared_resources'                        = 'List-SystemInsightsSharedResources';
        'GET_systeminsights-sharing_preferences'                     = 'List-SystemInsightsSharingPreferences';
        'GET_systeminsights-sip_config'                              = 'List-SystemInsightsSipConfig';
        'GET_systeminsights-system_controls'                         = 'List-SystemInsightsSystemControls';
        'GET_systeminsights-system_info'                             = 'List-SystemInsightsSystemInfo';
        'GET_systeminsights-uptime'                                  = 'List-SystemInsightsUptime';
        'GET_systeminsights-usb_devices'                             = 'List-SystemInsightsUSBDevices';
        'GET_systeminsights-users'                                   = 'List-SystemInsightsUsers';
        'GET_systeminsights-user_ssh_keys'                           = 'List-SystemInsightsUserSSHKeys';
        'GET_systeminsights-windows_crashes'                         = 'List-SystemInsightsWindowsCrashes';
        'GET_systems-system_id-memberof'                             = 'List-SystemMemberOf';
        'GET_systems-system_id-commands'                             = 'List-SystemTraverseCommand';
        'GET_systems-system_id-policies'                             = 'List-SystemTraversePolicy';
        'GET_systems-system_id-users'                                = 'List-SystemTraverseUser';
        'GET_systems-system_id-usergroups'                           = 'List-SystemTraverseUserGroup';
        'GET_users-user_id-associations'                             = 'List-UserAssociation';
        'POST_users-user_id-associations'                            = 'Set-UserAssociation';
        'POST_usergroups'                                            = 'Create-UserGroup';
        'DELETE_usergroups-id'                                       = 'Delete-UserGroup';
        'GET_usergroups-id'                                          = 'Get-UserGroup';
        'GET_usergroups'                                             = 'List-UserGroup';
        'PUT_usergroups-id'                                          = 'Put-UserGroup';
        'GET_usergroups-group_id-associations'                       = 'List-UserGroupAssociation';
        'POST_usergroups-group_id-associations'                      = 'Set-UserGroupAssociation';
        'GET_usergroups-group_id-members'                            = 'List-UserGroupMembers';
        'POST_usergroups-group_id-members'                           = 'Set-UserGroupMembers';
        'GET_usergroups-group_id-membership'                         = 'List-UserGroupMembership';
        'GET_usergroups-group_id-applications'                       = 'List-UserGroupTraverseApplication';
        'GET_usergroups-group_id-directories'                        = 'List-UserGroupTraverseDirectory';
        'GET_usergroups-group_id-gsuites'                            = 'List-UserGroupTraverseGSuite';
        'GET_usergroups-group_id-ldapservers'                        = 'List-UserGroupTraverseLdapServer';
        'GET_usergroups-group_id-office365s'                         = 'List-UserGroupTraverseOffice365';
        'GET_usergroups-group_id-radiusservers'                      = 'List-UserGroupTraverseRadiusServer';
        'GET_usergroups-group_id-systems'                            = 'List-UserGroupTraverseSystem';
        'GET_usergroups-group_id-systemgroups'                       = 'List-UserGroupTraverseSystemGroup';
        'GET_users-user_id-memberof'                                 = 'List-UserMemberOf';
        'GET_users-user_id-applications'                             = 'List-UserTraverseApplication';
        'GET_users-user_id-directories'                              = 'List-UserTraverseDirectory';
        'GET_users-user_id-gsuites'                                  = 'List-UserTraverseGSuite';
        'GET_users-user_id-ldapservers'                              = 'List-UserTraverseLdapServer';
        'GET_users-user_id-office365s'                               = 'List-UserTraverseOffice365';
        'GET_users-user_id-radiusservers'                            = 'List-UserTraverseRadiusServer';
        'GET_users-user_id-systems'                                  = 'List-UserTraverseSystem';
        'GET_users-user_id-systemgroups'                             = 'List-UserTraverseSystemGroup';
        'POST_workdays-workday_id-auth'                              = 'Authorize-Workday';
        'POST_workdays'                                              = 'Create-Workday';
        'GET_workdays-id'                                            = 'Get-Workday';
        'POST_workdays-workday_id-import'                            = 'Import-Workday';
        'GET_workdays'                                               = 'List-Workday';
        'PUT_workdays-id'                                            = 'Put-Workday';
        'DELETE_workdays-workday_id-auth'                            = 'Remove-WorkdayAuthorization';
        'GET_workdays-id-import-job_id-results'                      = 'Import-WorkdayResult';
        'GET_workdays-workday_id-workers'                            = 'List-WorkdayWorker';
    };
};
$ApiHash.GetEnumerator() | ForEach-Object {
    $CurrentApiName = $_.Name
    If ($CurrentApiName -in $ApiName)
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
            # Check to see if there are any operationIds not listed in the $OperationIdMapping
            $OperationIdMappingVersion = ($OperationIdMapping.Item($CurrentApiName))
            $OperationIdTemplate = '"operationId": "{0}"'
            $OperationIdMatches = Select-String -InputObject:($ReadyForConvert) -Pattern:([regex]'(?s)(?<=operationId": ")(.*?)(?=".*?$)') -AllMatches
            $OperationIdMatchesValues = $OperationIdMatches.Matches.Value
            $UnmappedOperationIds = @{ }
            ForEach ($OperationIdMatchesValue In $OperationIdMatchesValues)
            {
                If (-not $OperationIdMappingVersion.Contains([System.String]$OperationIdMatchesValue))
                {
                    $UnmappedOperationIds.Add($OperationIdMatchesValue, $_.Name)
                }
            }
            # Rename operationIds using $OperationIdMapping
            $OperationIdMappingVersion.GetEnumerator() | ForEach-Object {
                $OperationId_Old = $OperationIdTemplate -f [System.String]$_.Name
                $OperationId_New = $OperationIdTemplate -f [System.String]$_.Value
                If ($ReadyForConvert | Select-String -Pattern:([regex]::Escape($OperationId_Old)))
                {
                    $ReadyForConvert = $ReadyForConvert.Replace($OperationId_Old, $OperationId_New)
                }
                Else
                {
                    Write-Error ('Unable to find in "' + $CurrentApiName + '" API an operationId called "' + $_.Name + '".')
                }
            }
            # Check for unmapped operationIds
            If (-not [System.String]::IsNullOrEmpty($UnmappedOperationIds.Keys))
            {
                $UnmappedOperationIds.GetEnumerator() | ForEach-Object {
                    Write-Error ('Unknown ' + $_.Value + ' operationId: ' + $_.Key + ';')
                }
                Write-Error ( 'New operationId found in "' + $CurrentApiName + '". Please update the $OperationIdMapping variable within the \ApiTransform.ps1 file.')
                Exit
            }
            # Make fixes to file
            $VersionFixes = $FixesMapping.Item($CurrentApiName)
            $VersionFixes.GetEnumerator() | ForEach-Object {
                $PatternMatch = $ReadyForConvert | Select-String -Pattern:([regex]::Escape($_.Name))
                If (-not [System.String]::IsNullOrEmpty($PatternMatch))
                {
                    $ReadyForConvert = $ReadyForConvert.Replace([string]$_.Name, [string]$_.Value)
                    $ReadyForConvert = $ReadyForConvert.Replace([string]$PatternMatch.Matches.Value, [string]$_.Value)
                }
                Else
                {
                    Write-Error ('Unable to find a match in "' + $CurrentApiName + '" for : ' + $_.Name)
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
            # $ReadyForConvert | Out-File -FilePath:($OutputFilePath + $CurrentApiName + '_ReadyForConvert.json')
            # $OASContent | Out-File -FilePath:($OutputFilePath + $CurrentApiName + '_Org.json')
            # Return variable to Azure Pipelines
            Write-Host ("##vso[task.setvariable variable=UpdatedSpec]$UpdatedSpec")
            Return $UpdatedSpec
        }
    }
}
