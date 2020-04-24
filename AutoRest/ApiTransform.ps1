#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('V1', 'V2', 'DirectoryInsights')][ValidateNotNullOrEmpty()][System.String[]]$ApiName
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Use to prevent redownload of spec.')][switch]$NoUpdate
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub Personal Access Token.')][ValidateNotNullOrEmpty()][System.String[]]$GitHubAccessToken
)
Set-Location $PSScriptRoot
$ApiHash = [Ordered]@{
    # 'V1' = 'https://api.stoplight.io/v1/versions/sNtcAibbBX7Nizrmd/export/oas.yaml'; # StopLight
    # 'V2' = 'https://api.stoplight.io/v1/versions/JWvycPWBDeEZ3R5dF/export/oas.yaml'; # StopLight
    'V1'                = 'https://api.stoplight.io/v1/versions/MeLBYr6CGg2f4g9Qh/export/oas.yaml' # Docs
    'V2'                = 'https://api.stoplight.io/v1/versions/kP6fw2Ppd9ZbbfNmT/export/oas.yaml' # Docs
    'DirectoryInsights' = 'https://api.github.com/repos/TheJumpCloud/jumpcloud-insights-api/contents/docs/swagger.yaml?ref=master'
    # 'V1' = 'https://raw.githubusercontent.com/TheJumpCloud/SI/master/routes/webui/api/index.yaml?token=AK5FVUOCYLGLDFEW32YPIKS52VTCS'
    # 'V2' = 'https://raw.githubusercontent.com/TheJumpCloud/SI/master/routes/webui/api/v2/index.yaml?token=AK5FVUKXH6FIFU45LMFJIEC52VTEM'
}
$OutputFilePath = $PSScriptRoot + '/SwaggerSpecs/'
# Build Find and Replace table
$FixesMapping = @{
    'V1'                = [Ordered]@{
        # Path Issues
        '"#/definitions/system"'                                                                                            = '"#/definitions/JcSystem"'; # The "system" class is a reserved word.
        '"system": {"title": "System"'                                                                                      = '"JcSystem": {"title": "System"'; # The "system" class is a reserved word.
        # V1 Issues
        '"basePath": "/api"'                                                                                                = '"basePath": "/api/"'; # The extra slash at the end is needed to properly build the url.
        '"command": {"title": "Command", "organization": {"description": "The ID of the organization.", "type": "string"},' = '"command": {"title": "Command", "type": "object",'
        '"type": "null"'                                                                                                    = '"type": "string"'; # A type of null is not valid.
        '"format": "email", '                                                                                               = ''; # WARNING (LLCS1001/DoesNotSupportEnum): Schema with type:'string and 'format:'email' is not recognized.
        # Custom Tweaks
        '{"name": "Content-Type", "in": "header", "required": false, "type": "string"}'                                     = ''; # This will be passed in later through the Module.cs file.
        '{"name": "Accept", "in": "header", "required": false, "type": "string"}'                                           = ''; # This will be passed in later through the Module.cs file.
        '{"name": "x-org-id", "in": "header", "required": false, "type": "string"}'                                         = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
        ', ,'                                                                                                               = ',';
        '[,'                                                                                                                = '[';
        ', ]'                                                                                                               = ']';
        "`t"                                                                                                                = '\t';
    };
    'V2'                = [Ordered]@{
        # V2 Issues
        '"basePath": "/api/v2"'                                                                                        = '"basePath": "/api/v2/"'; # The extra slash at the end is needed to properly build the url.
        '["string", "number", "boolean"]'                                                                              = '"string"';
        '["string", "number", "boolean", "null"]'                                                                      = '"string"';
        '["object", "null"]'                                                                                           = '"object"';
        '["string", "null"]'                                                                                           = '"string"';
        '["boolean", "null"]'                                                                                          = '"boolean"'; # Error: Invalid type 'boolean,null' in schema
        '"jobId"'                                                                                                      = '"id"'; # The transform removes the "-" in the parent objects name, "job-id", which makes the parent name the same as the child.
        # Custom Tweaks
        '{"$ref": "#/parameters/trait:requestHeaders:Content-Type"}'                                                   = ''; # This will be passed in later through the Module.cs file.
        '{"$ref": "#/parameters/trait:requestHeaders:Accept"}'                                                         = ''; # This will be passed in later through the Module.cs file.
        '{"$ref": "#/parameters/trait:multiTenantRequestHeaders:x-org-id"}'                                            = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
        '{"name": "Content-Type", "in": "header", "required": false, "type": "string", "default": "application/json"}' = ''; # This will be passed in later through the Module.cs file.
        '{"name": "Accept", "in": "header", "required": false, "type": "string", "default": "application/json"}'       = ''; # This will be passed in later through the Module.cs file.
        '{"name": "x-org-id", "in": "header", "required": false, "type": "string"}'                                    = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
        '{"name": "x-api-key", "in": "header", "required": false, "type": "string"}'                                   = ''; # This will be passed in later through the Module.cs file.
        ', ,'                                                                                                          = ',';
        '[,'                                                                                                           = '[';
        ', ]'                                                                                                          = ']';
        "`t"                                                                                                           = '\t';
    };
    'DirectoryInsights' = [Ordered]@{
        '"search_after": {"description": "Specific query to search after, see x-* response headers for next values", "items": {"type": "object"}, "type": "array"}' = '"search_after": {"description": "Specific query to search after, see x-* response headers for next values", "items": {"type": "string"}, "type": "array"}'
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
        'POST_command-trigger-triggername'            = 'POST-CommandTrigger';
        'POST_systemusers-id-expire'                  = 'POST-ExpireSystemUserPassword';
        'GET_organizations-id'                        = 'Get-Organization';
        'GET_organizations'                           = 'List-Organization';
        'PUT_organizations-id'                        = 'Put-Organization';
        'POST_search-organizations'                   = 'Search-Organization';
        'POST_radiusservers'                          = 'Create-RadiusServer';
        'GET_radiusservers-id'                        = 'Get-RadiusServer';
        'GET_radiusservers'                           = 'List-RadiusServer';
        'PUT_radiusservers-id'                        = 'Put-RadiusServer';
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
        'POST_systemusers-id-sshkeys'                 = 'Create-SystemUsersSshKey';
        'DELETE_systemusers-systemuser_id-sshkeys-id' = 'Delete-SystemUsersSshKey';
        'GET_systemusers-id-sshkeys'                  = 'List-SystemUsersSshKey';
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
        'GET_systeminsights-certificates'                            = 'Get-Certificates';
        'GET_commands-command_id-associations'                       = 'List-CommandAssociation';
        'POST_commands-command_id-associations'                      = 'Set-CommandAssociation';
        'GET_commands-command_id-systems'                            = 'List-CommandTraverseSystem';
        'GET_commands-command_id-systemgroups'                       = 'List-CommandTraverseSystemGroup';
        'GET_systeminsights-cups_destinations'                       = 'Get-CupsDestinations';
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
        'GET_systeminsights-interface_details'                       = 'Get-InterfaceDetails';
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
        'POST_policies'                                              = 'Create-Policy';
        'DELETE_policies-id'                                         = 'Delete-Policy';
        'GET_policies-id'                                            = 'Get-Policy';
        'GET_policies'                                               = 'List-Policy';
        'PUT_policies-id'                                            = 'Put-Policy';
        'GET_policies-policy_id-associations'                        = 'List-PolicyAssociation';
        'POST_policies-policy_id-associations'                       = 'Set-PolicyAssociation';
        'GET_policyresults-id'                                       = 'Get-PolicyResult';
        'GET_policyresults'                                          = 'List-PolicyResult';
        'GET_policies-policy_id-policyresults'                       = 'List-PolicyResult';
        'GET_policies-policy_id-policystatuses'                      = 'List-PolicyStatus';
        'GET_systems-system_id-policystatuses'                       = 'List-PolicyStatus';
        'GET_policytemplates-id'                                     = 'Get-PolicyTemplate';
        'GET_policytemplates'                                        = 'List-PolicyTemplate';
        'GET_policies-policy_id-systems'                             = 'List-PolicyTraverseSystem';
        'GET_policies-policy_id-systemgroups'                        = 'List-PolicyTraverseSystemGroup';
        'POST_providers-provider_id-administrators'                  = 'Create-ProviderAdmin';
        'GET_providers-provider_id-administrators'                   = 'List-ProviderAdministrator';
        'GET_systeminsights-python_packages'                         = 'Get-PythonPackages';
        'GET_radiusservers-radiusserver_id-associations'             = 'List-RadiusServerAssociation';
        'POST_radiusservers-radiusserver_id-associations'            = 'Set-RadiusServerAssociation';
        'GET_radiusservers-radiusserver_id-users'                    = 'List-RadiusServerTraverseUser';
        'GET_radiusservers-radiusserver_id-usergroups'               = 'List-RadiusServerTraverseUserGroup';
        'GET_systeminsights-registry'                                = 'Get-Registry';
        'GET_systeminsights-scheduled_tasks'                         = 'Get-ScheduledTasks';
        'GET_systeminsights-services'                                = 'Get-Services';
        'GET_systeminsights-startup_items'                           = 'Get-StartupItems';
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
        'GET_systeminsights-user_groups'                             = 'List-SystemInsightsUserGroups';
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
# Set initial value for "UpdatedSpec" within Azure Pipelines
$UpdatedSpec = $false
Write-Host ("##vso[task.setvariable variable=UpdatedSpec]$UpdatedSpec")
# Start script
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
        $OASContent = If ($NoUpdate)
        {
            Get-Content -Path:($OutputFullPathYaml) -Raw
        }
        ElseIf ($APIName -eq 'DirectoryInsights')
        {
            $GitHubHeaders = @{
                'Authorization' = "token $GitHubAccessToken";
                'Accept'        = 'application/vnd.github.v3.raw';
            }
            Invoke-RestMethod -Method:('GET') -Uri:($_.Value) -Headers:($GitHubHeaders)
        }
        Else
        {
            (Invoke-WebRequest -Uri:($_.Value)).Content
        }
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
            If (-not $NoUpdate)
            {
                # Check to see if there are any operationIds not listed in the $OperationIdMapping
                If ($OperationIdMapping.Contains($CurrentApiName))
                {
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
                            Write-Host ("##vso[task.logissue type=error;]" + 'Unable to find in "' + $CurrentApiName + '" API an operationId called "' + $_.Name + '".')
                            Write-Error ('Unable to find in "' + $CurrentApiName + '" API an operationId called "' + $_.Name + '".')
                        }
                    }
                    # Check for unmapped operationIds
                    If (-not [System.String]::IsNullOrEmpty($UnmappedOperationIds.Keys))
                    {
                        $UnmappedOperationIds.GetEnumerator() | ForEach-Object {
                            Write-Host("##vso[task.logissue type=error;]" + 'Unknown ' + $_.Value + ' operationId: ' + $_.Key + ';')
                            Write-Error ('Unknown ' + $_.Value + ' operationId: ' + $_.Key + ';')
                        }
                        Write-Error ( 'New operationId found in "' + $CurrentApiName + '". Please update the $OperationIdMapping variable within the \ApiTransform.ps1 file.')
                        Exit
                    }
                }
                # Make fixes to file
                If ($FixesMapping.ContainsKey($CurrentApiName))
                {
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
                            Write-Host("##vso[task.logissue type=error;]" + 'Unable to find a match in "' + $CurrentApiName + '" for : ' + $_.Name)
                            Write-Error ('Unable to find a match in "' + $CurrentApiName + '" for : ' + $_.Name)
                        }
                    }
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
            # Sort the json properties under "paths"
            If ('paths' -in $JsonExport.PSObject.Properties.Name)
            {
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
            }
            # Sort the json properties under "parameters"
            If ('parameters' -in $JsonExport.PSObject.Properties.Name)
            {
                $parametersHash = [ordered]@{ }
                $parameterNames = ($JsonExport.parameters | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } | Sort-Object)
                $parametersHash = [ordered]@{ }
                $parameterNames | ForEach-Object {
                    $parameterName = $_
                    $parametersHash.Add($parameterName, $JsonExport.parameters.$parameterName)
                }
                $JsonExport.parameters = $parametersHash
            }
            # Sort the json properties under "definitions"
            If ('definitions' -in $JsonExport.PSObject.Properties.Name)
            {
                $definitionsHash = [ordered]@{ }
                $definitionsNames = ($JsonExport.definitions | Get-Member -MemberType NoteProperty | ForEach-Object { $_.Name } | Sort-Object)
                $definitionsHash = [ordered]@{ }
                $definitionsNames | ForEach-Object {
                    $definitionsName = $_
                    $definitionsHash.Add($definitionsName, $JsonExport.definitions.$definitionsName)
                }
                $JsonExport.definitions = $definitionsHash
            }
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
