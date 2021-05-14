#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub Personal Access Token.')][ValidateNotNullOrEmpty()][System.String]$GitHubAccessToken
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub branch or tag to pull spec from.')][ValidateNotNullOrEmpty()][System.String]$GitHubTag
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Use to alphabetically order the properties within the swagger object.')][bool]$SortAttributes = $true
)
Set-Location $PSScriptRoot
$OutputFilePath = $PSScriptRoot + '/SwaggerSpecs'
# OperationId to Function name mapping - https://github.com/Azure/autorest.powershell/blob/a530bd721c9326a4356fba15638fee236722aca9/powershell/autorest-configuration.md
$TransformConfig = [Ordered]@{
    'JumpCloud.SDK.DirectoryInsights' = [PSCustomObject]@{
        Repo               = "jumpcloud-insights-api"
        Path               = "docs/generated/directory_insights_swagger.json"
        FindAndReplace     = [Ordered]@{
            '"in":"body","name":".*?"'                                                                                                                                                      = '"in":"body","name":"body"' # Across our APIs the standard is using "body" for the name of the body
            '"search_after":{"description":"Specific query to search after, see x-\* response headers for next values","items":{"type":"object"},"type":"array","x-go-name":"SearchAfter"}' = '"search_after":{"description":"Specific query to search after, see x-* response headers for next values","items":{"type":"string"},"type":"array","x-go-name":"SearchAfter"}';
        };
        OperationIdMapping = [Ordered]@{
            'directoryInsights_eventsPost'         = 'Get-Event';
            'directoryInsights_eventsCountPost'    = 'Get-EventCount';
            'directoryInsights_eventsDistinctPost' = 'Get-EventDistinct';
            'directoryInsights_eventsIntervalPost' = 'Get-EventInterval';
        };
        ExcludedList       = @();
    }
    'JumpCloud.SDK.V1'                = [PSCustomObject]@{
        Repo               = "SI"
        Path               = "routes/webui/api/index.yaml"
        FindAndReplace     = [Ordered]@{
            # Path Issues
            '"#\/definitions\/system"'                                                           = '"#/definitions/JcSystem"'; # error CS0426: The type name 'ComponentModel' does not exist in the type 'System'
            '"system":{"title":"System"'                                                         = '"JcSystem":{"title":"JcSystem"'; # error CS0426: The type name 'ComponentModel' does not exist in the type 'System'
            # V1 Issues
            '"basePath":"\/api"'                                                                 = '"basePath":"/api/"'; # The extra slash at the end is needed to properly build the url.
            '"type":"null"'                                                                      = '"type":"string"'; # A type of null is not valid.
            '"internal":{"type":"object","properties":{"deviceId":{"type":"string"}}}'           = ''; # is already listed in interface list
            # '{"in":"body","name":"body","schema":{"additionalProperties":true,"type":"object"}}' = '{"in":"body","name":"body","schema":{"description": "Key value pair of parameters to pass into command.","type":"object","additionalProperties":{"type": "string"},"required": false}'; # Remove bodys that dont have parameters
            '{"in":"body","name":"body","schema":{"additionalProperties":true,"type":"object"}}' = ''; # Remove bodys that dont have parameters
            # Custom Tweaks
            '{"\$ref":"#\/parameters\/trait:systemContextAuth:Authorization"}'                   = ''; # We dont want to support authentication through system context via the SDK
            '{"\$ref":"#\/parameters\/trait:systemContextAuth:Date"}'                            = ''; # We dont want to support authentication through system context via the SDK
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Content-Type"}'                       = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Accept"}'                             = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"}'                = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            '{"in":"header","name":"Content-Type","type":"string"}'                              = ''; # This will be passed in later through the Module.cs file.
            '{"in":"header","name":"Accept","type":"string"}'                                    = ''; # This will be passed in later through the Module.cs file.
            '{"in":"header","name":"x-org-id","type":"string"}'                                  = ''; # This will be passed in later through the Module.cs file.
            ',,'                                                                                 = ',';
            '\[,'                                                                                = '[';
            ',]'                                                                                 = ']';
        };
        OperationIdMapping = [Ordered]@{
            'systems_commandBuiltinErase'    = 'Clear-System';
            'applications_post'              = 'Create-Application';
            'commands_post'                  = 'Create-Command';
            'radius_servers_post'            = 'Create-RadiusServer';
            'systemusers_post'               = 'Create-User';
            'sshkey_post'                    = 'Create-UserSshKey';
            'applications_delete'            = 'Delete-Application';
            'commands_delete'                = 'Delete-Command';
            'command_results_delete'         = 'Delete-CommandResult';
            'radius_servers_delete'          = 'Delete-RadiusServer';
            'systems_delete'                 = 'Delete-System';
            'systemusers_delete'             = 'Delete-User';
            'sshkey_delete'                  = 'Delete-UserSshKey';
            'applications_get'               = 'Get-Application';
            'application_templates_get'      = 'Get-ApplicationTemplate';
            'commands_get'                   = 'Get-Command';
            'command_file_get'               = 'Get-CommandFile';
            'command_results_get'            = 'Get-CommandResult';
            'commands_getResults'            = 'Get-CommandResult';
            'organizations_get'              = 'Get-Organization';
            'radius_servers_get'             = 'Get-RadiusServer';
            'systems_get'                    = 'Get-System';
            'systemusers_get'                = 'Get-User';
            'sshkey_list'                    = 'Get-UserSshKey';
            'applications_list'              = 'List-Application';
            'application_templates_list'     = 'List-ApplicationTemplate';
            'commands_list'                  = 'List-Command';
            'command_results_list'           = 'List-CommandResult';
            'organization_list'              = 'List-Organization';
            'radius_servers_list'            = 'List-RadiusServer';
            'systems_list'                   = 'List-System';
            'systemusers_list'               = 'List-User';
            'systems_commandBuiltinLock'     = 'Lock-System';
            'command_trigger_webhook_post'   = 'POST-CommandTrigger';
            'systemusers_expire'             = 'POST-ExpireUserPassword';
            'systemusers_resetmfa'           = 'Reset-UserMfa';
            'systems_commandBuiltinRestart'  = 'Restart-System';
            'search_organizations_post'      = 'Search-Organization';
            'search_systems_post'            = 'Search-System';
            'search_systemusers_post'        = 'Search-User';
            'applications_put'               = 'Set-Application';
            'commands_put'                   = 'Set-Command';
            'organization_put'               = 'Set-Organization';
            'radius_servers_put'             = 'Set-RadiusServer';
            'systems_put'                    = 'Set-System';
            'systemusers_put'                = 'Set-User';
            'systems_commandBuiltinShutdown' = 'Stop-System';
            'systemusers_unlock'             = 'Unlock-User';
        };
        ExcludedList       = @();
    }
    'JumpCloud.SDK.V2'                = [PSCustomObject]@{
        Repo               = "SI"
        Path               = "routes/webui/api/v2/index.yaml"
        FindAndReplace     = [Ordered]@{
            # V2 Issues
            '"basePath":"\/api\/v2"'                                                              = '"basePath":"/api/v2/"'; # The extra slash at the end is needed to properly build the url.
            '\["string","number","boolean","array"]'                                              = '"string"'; # FAILURE  {} Error:Invalid type 'string,number,boolean,array' in schema
            '\["string","number","boolean","array","null"]'                                       = '"string"' #  FAILURE  {} Error:Invalid type 'string,number,boolean,array,null' in schema
            '\["object","null"]'                                                                  = '"object"';
            '\["string","null"]'                                                                  = '"string"';
            '\["boolean","null"]'                                                                 = '"boolean"'; # Error:Invalid type 'boolean,null' in schema
            '\["integer","null"]'                                                                 = '"integer"'; # Error:Invalid type 'integer,null' in schema
            '\["number","null"]'                                                                  = '"number"'; # Error:Invalid type 'number,null' in schema
            '"type":"null"'                                                                       = '"type":"string"'; # Error: Invalid type 'null' in schema
            'software-app-settings'                                                               = 'SoftwareAppSettings'; # Error: Collision detected inserting into object: software-app-settings
            '{"in":"body","name":"body","schema":{"\$ref":"#\/definitions\/CustomEmail"}'         = '{"in":"body","name":"CustomEmail","schema":{"$ref":"#/definitions/CustomEmail"}'; # The type 'SetJcSdkInternalCustomEmailConfiguration_SetExpanded, SetJcSdkInternalCustomEmailConfiguration_SetViaIdentityExpanded, NewJcSdkInternalCustomEmailConfiguration_CreateExpanded' already contains a definition for 'Body'
            '"format":"uint32"'                                                                   = '"format":"int64"' # SI code uses uint32 which is larger than int32 . Swagger 2 doesnt have a concept of uint32 . AutoRest defaults to int32 when it sees a type of integer.
            # Custom Tweaks
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Content-Type"}'                        = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Accept"}'                              = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"}'                 = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            '{"default":"application\/json","in":"header","name":"Content-Type","type":"string"}' = ''; # This will be passed in later through the Module.cs file.
            '{"default":"application\/json","in":"header","name":"Accept","type":"string"}'       = ''; # This will be passed in later through the Module.cs file.
            '{"in":"header","name":"x-org-id","type":"string"}'                                   = ''; # This will be passed in later through the Module.cs file.
            '{"in":"header","name":"x-api-key","type":"string"}'                                  = ''; # This will be passed in later through the Module.cs file.
            ',,'                                                                                  = ',';
            '\[,'                                                                                 = '[';
            ',]'                                                                                  = ']';
        };
        OperationIdMapping = [Ordered]@{
            'workdays_authorize'                                = 'Authorize-Workday';
            'applemdms_deviceserase'                            = 'Clear-AppleMDMDevice';
            'applemdms_devicesClearActivationLock'              = 'Clear-AppleMDMDeviceActivationLock';
            'activedirectories_post'                            = 'Create-ActiveDirectory';
            'authnpolicies_post'                                = 'Create-AuthenticationPolicy';
            'bulk_usersCreate'                                  = 'Create-BulkUsers';
            'customEmails_create'                               = 'Create-CustomEmailConfiguration';
            'duo_accountPost'                                   = 'Create-DuoAccount';
            'duo_applicationPost'                               = 'Create-DuoApplication';
            'translationRules_gSuitePost'                       = 'Create-GSuiteTranslationRule';
            'iplists_post'                                      = 'Create-IpList';
            'ldapservers_sambaDomainsPost'                      = 'Create-LdapServerSambaDomain';
            'translationRules_office365Post'                    = 'Create-Office365TranslationRule';
            'policies_post'                                     = 'Create-Policy';
            'providers_postAdmins'                              = 'Create-ProviderAdministrator';
            'softwareApps_post'                                 = 'Create-SoftwareApp';
            'groups_system_post'                                = 'Create-SystemGroup';
            'groups_user_post'                                  = 'Create-UserGroup';
            'workdays_post'                                     = 'Create-Workday';
            'applemdms_delete'                                  = 'Delete-AppleMDM';
            'applications_deleteLogo'                           = 'Delete-ApplicationLogo';
            'authnpolicies_delete'                              = 'Delete-AuthenticationPolicy';
            'customEmails_destroy'                              = 'Delete-CustomEmailConfiguration';
            'duo_accountDelete'                                 = 'Delete-DuoAccount';
            'duo_applicationDelete'                             = 'Delete-DuoApplication';
            'groups_policy_delete'                              = 'Delete-GroupPolicy';
            'translationRules_gSuiteDelete'                     = 'Delete-GSuiteTranslationRule';
            'iplists_delete'                                    = 'Delete-IpList';
            'ldapservers_sambaDomainsDelete'                    = 'Delete-LdapServerSambaDomain';
            'translationRules_office365Delete'                  = 'Delete-Office365TranslationRule';
            'policies_delete'                                   = 'Delete-Policy';
            'softwareApps_delete'                               = 'Delete-SoftwareApp';
            'groups_system_delete'                              = 'Delete-SystemGroup';
            'groups_user_delete'                                = 'Delete-UserGroup';
            'workdays_deauthorize'                              = 'Delete-WorkdayAuthorization';
            'activedirectories_get'                             = 'Get-ActiveDirectory';
            'graph_activeDirectoryAssociationsList'             = 'Get-ActiveDirectoryAssociation';
            'graph_activeDirectoryTraverseUserGroup'            = 'Get-ActiveDirectoryTraverseUserGroup';
            'applemdms_getdevice'                               = 'Get-AppleMDMDevice';
            'graph_applicationAssociationsList'                 = 'Get-ApplicationAssociation';
            'graph_applicationTraverseUser'                     = 'Get-ApplicationTraverseUser';
            'graph_applicationTraverseUserGroup'                = 'Get-ApplicationTraverseUserGroup';
            'authnpolicies_get'                                 = 'Get-AuthenticationPolicy';
            'bulk_usersCreateResults'                           = 'Get-BulkUsersResult';
            'graph_commandAssociationsList'                     = 'Get-CommandAssociation';
            'graph_commandTraverseSystem'                       = 'Get-CommandTraverseSystem';
            'graph_commandTraverseSystemGroup'                  = 'Get-CommandTraverseSystemGroup';
            'customEmails_read'                                 = 'Get-CustomEmailConfiguration';
            'duo_accountGet'                                    = 'Get-DuoAccount';
            'duo_applicationGet'                                = 'Get-DuoApplication';
            'groups_policy_get'                                 = 'Get-GroupPolicy';
            'groups_suggestions_get'                            = 'Get-GroupSuggestion';
            'gsuites_get'                                       = 'Get-GSuite';
            'graph_gSuiteAssociationsList'                      = 'Get-GSuiteAssociation';
            'translationRules_gSuiteGet'                        = 'Get-GSuiteTranslationRule';
            'graph_gSuiteTraverseUser'                          = 'Get-GSuiteTraverseUser';
            'graph_gSuiteTraverseUserGroup'                     = 'Get-GSuiteTraverseUserGroup';
            'iplists_get'                                       = 'Get-IpList';
            'ldapservers_get'                                   = 'Get-LdapServer';
            'graph_ldapServerAssociationsList'                  = 'Get-LdapServerAssociation';
            'ldapservers_sambaDomainsGet'                       = 'Get-LdapServerSambaDomain';
            'graph_ldapServerTraverseUser'                      = 'Get-LdapServerTraverseUser';
            'graph_ldapServerTraverseUserGroup'                 = 'Get-LdapServerTraverseUserGroup';
            'office365s_get'                                    = 'Get-Office365';
            'graph_office365AssociationsList'                   = 'Get-Office365Association';
            'translationRules_office365Get'                     = 'Get-Office365TranslationRule';
            'graph_office365TraverseUser'                       = 'Get-Office365TraverseUser';
            'graph_office365TraverseUserGroup'                  = 'Get-Office365TraverseUserGroup';
            'policies_get'                                      = 'Get-Policy';
            'graph_policyAssociationsList'                      = 'Get-PolicyAssociation';
            'graph_policyMemberOf'                              = 'Get-PolicyGroupMember';
            'graph_policyGroupMembership'                       = 'Get-PolicyGroupMembership';
            'graph_policyGroupTraverseSystem'                   = 'Get-PolicyGroupTraverseSystem';
            'graph_policyGroupTraverseSystemGroup'              = 'Get-PolicyGroupTraverseSystemGroup';
            'policyresults_get'                                 = 'Get-PolicyResult';
            'policytemplates_get'                               = 'Get-PolicyTemplate';
            'graph_policyTraverseSystem'                        = 'Get-PolicyTraverseSystem';
            'graph_policyTraverseSystemGroup'                   = 'Get-PolicyTraverseSystemGroup';
            'graph_radiusServerAssociationsList'                = 'Get-RadiusServerAssociation';
            'graph_radiusServerTraverseUser'                    = 'Get-RadiusServerTraverseUser';
            'graph_radiusServerTraverseUserGroup'               = 'Get-RadiusServerTraverseUserGroup';
            'softwareApps_get'                                  = 'Get-SoftwareApp';
            'graph_softwareappsAssociationsList'                = 'Get-SoftwareAppAssociation';
            'softwareAppStatuses_list'                          = 'Get-SoftwareAppStatus';
            'graph_softwareappsTraverseSystem'                  = 'Get-SoftwareAppTraverseSystem';
            'graph_softwareappsTraverseSystemGroup'             = 'Get-SoftwareAppTraverseSystemGroup';
            'subscriptions_get'                                 = 'Get-Subscription';
            'graph_systemAssociationsList'                      = 'Get-SystemAssociation';
            'systems_getFDEKey'                                 = 'Get-SystemFDEKey';
            'groups_system_get'                                 = 'Get-SystemGroup';
            'graph_systemGroupAssociationsList'                 = 'Get-SystemGroupAssociation';
            'graph_systemGroupMembersList'                      = 'Get-SystemGroupMembers';
            'graph_systemGroupMembership'                       = 'Get-SystemGroupMembership';
            'graph_systemGroupTraverseCommand'                  = 'Get-SystemGroupTraverseCommand';
            'graph_systemGroupTraversePolicy'                   = 'Get-SystemGroupTraversePolicy';
            'graph_systemGroupTraversePolicyGroup'              = 'Get-SystemGroupTraversePolicyGroup';
            'graph_systemGroupTraverseUser'                     = 'Get-SystemGroupTraverseUser';
            'graph_systemGroupTraverseUserGroup'                = 'Get-SystemGroupTraverseUserGroup';
            'graph_systemMemberOf'                              = 'Get-SystemMember';
            'graph_systemTraverseCommand'                       = 'Get-SystemTraverseCommand';
            'graph_systemTraversePolicy'                        = 'Get-SystemTraversePolicy';
            'graph_systemTraversePolicyGroup'                   = 'Get-SystemTraversePolicyGroup';
            'graph_systemTraverseUser'                          = 'Get-SystemTraverseUser';
            'graph_systemTraverseUserGroup'                     = 'Get-SystemTraverseUserGroup';
            'graph_userAssociationsList'                        = 'Get-UserAssociation';
            'groups_user_get'                                   = 'Get-UserGroup';
            'graph_userGroupAssociationsList'                   = 'Get-UserGroupAssociation';
            'graph_userGroupMembersList'                        = 'Get-UserGroupMembers';
            'graph_userGroupMembership'                         = 'Get-UserGroupMembership';
            'graph_userGroupTraverseApplication'                = 'Get-UserGroupTraverseApplication';
            'graph_userGroupTraverseDirectory'                  = 'Get-UserGroupTraverseDirectory';
            'graph_userGroupTraverseGSuite'                     = 'Get-UserGroupTraverseGSuite';
            'graph_userGroupTraverseLdapServer'                 = 'Get-UserGroupTraverseLdapServer';
            'graph_userGroupTraverseOffice365'                  = 'Get-UserGroupTraverseOffice365';
            'graph_userGroupTraverseRadiusServer'               = 'Get-UserGroupTraverseRadiusServer';
            'graph_userGroupTraverseSystem'                     = 'Get-UserGroupTraverseSystem';
            'graph_userGroupTraverseSystemGroup'                = 'Get-UserGroupTraverseSystemGroup';
            'graph_userMemberOf'                                = 'Get-UserMember';
            'graph_userTraverseApplication'                     = 'Get-UserTraverseApplication';
            'graph_userTraverseDirectory'                       = 'Get-UserTraverseDirectory';
            'graph_userTraverseGSuite'                          = 'Get-UserTraverseGSuite';
            'graph_userTraverseLdapServer'                      = 'Get-UserTraverseLdapServer';
            'graph_userTraverseOffice365'                       = 'Get-UserTraverseOffice365';
            'graph_userTraverseRadiusServer'                    = 'Get-UserTraverseRadiusServer';
            'graph_userTraverseSystem'                          = 'Get-UserTraverseSystem';
            'graph_userTraverseSystemGroup'                     = 'Get-UserTraverseSystemGroup';
            'workdays_get'                                      = 'Get-Workday';
            'workdays_workers'                                  = 'Get-WorkdayWorker';
            'workdays_import'                                   = 'Import-Workday';
            'workdays_importresults'                            = 'Import-WorkdayResult';
            'activedirectories_list'                            = 'List-ActiveDirectory';
            'applemdms_list'                                    = 'List-AppleMDM';
            'applemdms_deviceslist'                             = 'List-AppleMDMDevice';
            'applemdms_enrollmentprofileslist'                  = 'List-AppleMDMEnrollmentProfile';
            'authnpolicies_list'                                = 'List-AuthenticationPolicy';
            'customEmails_getTemplates'                         = 'List-CustomEmailTemplates';
            'directories_list'                                  = 'List-Directory';
            'duo_accountList'                                   = 'List-DuoAccount';
            'duo_applicationList'                               = 'List-DuoApplication';
            'groups_list'                                       = 'List-Group';
            'groups_policy_list'                                = 'List-GroupPolicy';
            'translationRules_gSuiteList'                       = 'List-GSuiteTranslationRule';
            'gsuites_listImportUsers'                           = 'List-GSuiteUsersToImport';
            'iplists_list'                                      = 'List-IpList';
            'ldapservers_list'                                  = 'List-LdapServer';
            'ldapservers_sambaDomainsList'                      = 'List-LdapServerSambaDomain';
            'translationRules_office365List'                    = 'List-Office365TranslationRule';
            'office365s_listImportUsers'                        = 'List-Office365UsersToImport';
            'policyresults_org_list'                            = 'List-OrganizationPolicyResult';
            'policies_list'                                     = 'List-Policy';
            'graph_policyGroupAssociationsList'                 = 'List-PolicyGroupAssociation';
            'graph_policyGroupMembersList'                      = 'List-PolicyGroupMembers';
            'policyresults_list'                                = 'List-PolicyResult';
            'policystatuses_policiesList'                       = 'List-PolicyStatus';
            'policytemplates_list'                              = 'List-PolicyTemplate';
            'providers_listAdministrators'                      = 'List-ProviderAdministrator';
            'softwareApps_list'                                 = 'List-SoftwareApp';
            'groups_system_list'                                = 'List-SystemGroup';
            'systeminsights_list_alf'                           = 'List-SystemInsightsAlf';
            'systeminsights_list_alf_exceptions'                = 'List-SystemInsightsAlfException';
            'systeminsights_list_alf_explicit_auths'            = 'List-SystemInsightsAlfExplicitAuth';
            'systeminsights_list_appcompat_shims'               = 'List-SystemInsightsAppCompatShim';
            'systeminsights_list_apps'                          = 'List-SystemInsightsApps';
            'systeminsights_list_authorized_keys'               = 'List-SystemInsightsAuthorizedKey';
            'systeminsights_list_battery'                       = 'List-SystemInsightsBattery';
            'systeminsights_list_bitlocker_info'                = 'List-SystemInsightsBitlockerInfo';
            'systeminsights_list_browser_plugins'               = 'List-SystemInsightsBrowserPlugins';
            'systeminsights_list_certificates'                  = 'List-SystemInsightsCertificates';
            'systeminsights_list_chrome_extensions'             = 'List-SystemInsightsChromeExtensions';
            'systeminsights_list_connectivity'                  = 'List-SystemInsightsConnectivity';
            'systeminsights_list_crashes'                       = 'List-SystemInsightsCrashes';
            'systeminsights_list_cups_destinations'             = 'List-SystemInsightsCupsDestinations';
            'systeminsights_list_disk_encryption'               = 'List-SystemInsightsDiskEncryption';
            'systeminsights_list_disk_info'                     = 'List-SystemInsightsDiskInfo';
            'systeminsights_list_dns_resolvers'                 = 'List-SystemInsightsDnsResolver';
            'systeminsights_list_etc_hosts'                     = 'List-SystemInsightsEtcHosts';
            'systeminsights_list_firefox_addons'                = 'List-SystemInsightsFirefoxAddons';
            'systeminsights_list_groups'                        = 'List-SystemInsightsGroups';
            'systeminsights_list_ie_extensions'                 = 'List-SystemInsightsIEExtensions';
            'systeminsights_list_interface_addresses'           = 'List-SystemInsightsInterfaceAddresses';
            'systeminsights_list_interface_details'             = 'List-SystemInsightsInterfaceDetails';
            'systeminsights_list_kernel_info'                   = 'List-SystemInsightsKernelInfo';
            'systeminsights_list_launchd'                       = 'List-SystemInsightsLaunchd';
            'systeminsights_list_logged_in_users'               = 'List-SystemInsightsLoggedinUsers';
            'systeminsights_list_logical_drives'                = 'List-SystemInsightsLogicalDrives';
            'systeminsights_list_managed_policies'              = 'List-SystemInsightsManagedPolicies';
            'systeminsights_list_mounts'                        = 'List-SystemInsightsMounts';
            'systeminsights_list_os_version'                    = 'List-SystemInsightsOsVersion';
            'systeminsights_list_patches'                       = 'List-SystemInsightsPatches';
            'systeminsights_list_programs'                      = 'List-SystemInsightsPrograms';
            'systeminsights_list_python_packages'               = 'List-SystemInsightsPythonPackages';
            'systeminsights_list_safari_extensions'             = 'List-SystemInsightsSafariExtensions';
            'systeminsights_list_scheduled_tasks'               = 'List-SystemInsightsScheduledTasks';
            'systeminsights_list_services'                      = 'List-SystemInsightsServices';
            'systeminsights_list_shadow'                        = 'List-SystemInsightsShadow';
            'systeminsights_list_shared_folders'                = 'List-SystemInsightsSharedFolders';
            'systeminsights_list_shared_resources'              = 'List-SystemInsightsSharedResources';
            'systeminsights_list_sharing_preferences'           = 'List-SystemInsightsSharingPreferences';
            'systeminsights_list_sip_config'                    = 'List-SystemInsightsSipConfig';
            'systeminsights_list_startup_items'                 = 'List-SystemInsightsStartupItems';
            'systeminsights_list_system_controls'               = 'List-SystemInsightsSystemControls';
            'systeminsights_list_system_info'                   = 'List-SystemInsightsSystemInfo';
            'systeminsights_list_uptime'                        = 'List-SystemInsightsUptime';
            'systeminsights_list_usb_devices'                   = 'List-SystemInsightsUSBDevices';
            'systeminsights_list_user_groups'                   = 'List-SystemInsightsUserGroups';
            'systeminsights_list_users'                         = 'List-SystemInsightsUsers';
            'systeminsights_list_user_ssh_keys'                 = 'List-SystemInsightsUserSSHKeys';
            'systeminsights_list_wifi_networks'                 = 'List-SystemInsightsWifiNetwork';
            'systeminsights_list_wifi_status'                   = 'List-SystemInsightsWifiStatus';
            'systeminsights_list_windows_security_products'     = 'List-SystemInsightsWindowsSecurityProduct';
            'policystatuses_systemsList'                        = 'List-SystemsPolicyStatus';
            'groups_user_list'                                  = 'List-UserGroup';
            'workdays_list'                                     = 'List-Workday';
            'applemdms_deviceslock'                             = 'Lock-AppleMDMDevice';
            'groups_policy_post'                                = 'New-GroupPolicy';
            'softwareApps_reclaimLicenses'                      = 'Reclaim-SoftwareAppsLicenses';
            'applemdms_devicesRefreshActivationLockInformation' = 'Refresh-AppleMDMDeviceLockInformation';
            'applemdms_devicesrestart'                          = 'Restart-AppleMDMDevice';
            'graph_activeDirectoryAssociationsPost'             = 'Set-ActiveDirectoryAssociation';
            'applemdms_put'                                     = 'Set-AppleMDM';
            'graph_applicationAssociationsPost'                 = 'Set-ApplicationAssociation';
            'graph_commandAssociationsPost'                     = 'Set-CommandAssociation';
            'customEmails_update'                               = 'Set-CustomEmailConfiguration';
            'duo_applicationUpdate'                             = 'Set-DuoApplication';
            'groups_policy_put'                                 = 'Set-GroupPolicy';
            'graph_gSuiteAssociationsPost'                      = 'Set-GSuiteAssociation';
            'iplists_put'                                       = 'Set-IpList';
            'graph_ldapServerAssociationsPost'                  = 'Set-LdapServerAssociation';
            'ldapservers_sambaDomainsPut'                       = 'Set-LdapServerSambaDomain';
            'graph_office365AssociationsPost'                   = 'Set-Office365Association';
            'policies_put'                                      = 'Set-Policy';
            'graph_policyAssociationsPost'                      = 'Set-PolicyAssociation';
            'graph_policyGroupAssociationsPost'                 = 'Set-PolicyGroupAssociation';
            'graph_policyGroupMembersPost'                      = 'Set-PolicyGroupMembers';
            'graph_radiusServerAssociationsPost'                = 'Set-RadiusServerAssociation';
            'softwareApps_update'                               = 'Set-SoftwareApp';
            'graph_softwareappsAssociationsPost'                = 'Set-SoftwareAppAssociation';
            'graph_systemAssociationsPost'                      = 'Set-SystemAssociation';
            'groups_system_put'                                 = 'Set-SystemGroup';
            'graph_systemGroupAssociationsPost'                 = 'Set-SystemGroupAssociation';
            'graph_systemGroupMembersPost'                      = 'Set-SystemGroupMembers';
            'graph_userAssociationsPost'                        = 'Set-UserAssociation';
            'groups_user_put'                                   = 'Set-UserGroup';
            'graph_userGroupAssociationsPost'                   = 'Set-UserGroupAssociation';
            'graph_userGroupMembersPost'                        = 'Set-UserGroupMembers';
            'workdays_put'                                      = 'Set-Workday';
            'applemdms_devicesshutdown'                         = 'Stop-AppleMDMDevice';
            'applemdms_refreshdepdevices'                       = 'Sync-AppleMDMDevice';
            'authnpolicies_patch'                               = 'Update-AuthenticationPolicy';
            'bulk_usersUpdate'                                  = 'Update-BulkUsers';
            'gsuites_patch'                                     = 'Update-GSuite';
            'iplists_patch'                                     = 'Update-IpList';
            'ldapservers_patch'                                 = 'Update-LdapServer';
            'office365s_patch'                                  = 'Update-Office365';
        };
        ExcludedList       = @('/applications/{application_id}') #, '/applications/{application_id}/logo', '/logos/{id}')
    }
}
Function Get-SwaggerItem
{
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'An object representing a swagger file.')]$InputObject
        , $Path
    )
    # Brake up parts of path to iterate through
    If ($Path -match '#')
    {
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
Function Update-SwaggerObject
{
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'An object representing a swagger file.')]$InputObject
        , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'The name of the object that is being passed in.')]$InputObjectName = ''
        , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Use to alphabetically order the properties within the swagger object.')][bool]$Sort = $false
        , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Use to disable changes made to the swagger object. Use if you want to only sort a swagger object.')][bool]$NoUpdate = $false
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
        If ($NoUpdate -eq $false)
        {
            # TODO: Unsure why leaving as an array wont work with autorest. Convert the enum array to a string.
            # TODO: If left as is in an array autorest throws error "error CS0023: Operator '?' cannot be applied to operand of type 'Items1'"
            If ($InputObjectName -like '.parameters.*')
            {
                $ThisObjectName = $ThisObject.name
                If ($ThisObject | Get-Member -Name type)
                {
                    If ($ThisObject | Get-Member -Name name)
                    {
                        If ($ThisObject.name -eq "targets")
                        {
                            $ThisObject.type = 'string'
                            Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:('enum') -Value:($ThisObject.items.enum) -Force
                            $ThisObject.PSObject.Properties.Remove('items')
                        }
                    }
                }
            }
            Else
            {
                $ThisObjectName = $InputObjectName.split('.') | Select-Object -Last 1
            }
        }
        # Get child objects
        If (-not [System.String]::IsNullOrEmpty($ThisObject))
        {
            $AttributeType = $ThisObject.GetType()
            $AttributeNames = If ($AttributeType.FullName -in ('System.Management.Automation.PSCustomObject'))
            {
                $ThisObject.PSObject.Properties.Name
            }
            # Sort attribute names
            If (-not [System.String]::IsNullOrEmpty($AttributeNames) -and $Sort -eq $true)
            {
                $AttributeNames = $AttributeNames | Sort-Object -CaseSensitive
            }
        }
        Else
        {
            $AttributeNames = $null
        }
        # Iterate through child objects
        If (-not [System.String]::IsNullOrEmpty($AttributeNames))
        {
            # Write-Host ("AttributeNames: $AttributeNames")
            $AttributeNames | ForEach-Object {
                $AttributeName = $_
                $AttributePath = (@($InputObjectName, $AttributeName) -join ('.'))
                If ($NoUpdate -eq $false)
                {
                    # Map operationIds
                    If ($AttributePath -like '*.operationId')
                    {
                        If (($global:OperationIdMapping).Contains($ThisObject.operationId))
                        {
                            $OperationId = $ThisObject.operationId
                            $ThisObject.operationId = $global:OperationIdMapping.($ThisObject.operationId)
                            $global:OperationIdMapping.Remove($OperationId)
                            $NewOperationId = $ThisObject.operationId
                        }
                        Else
                        {
                            Write-Error ("In '$($CurrentSDKName)' unknown operationId '$($ThisObject.operationId) - $($InputObjectName)'.")
                        }
                    }
                    # Remove blank values from enum
                    If ($AttributePath -like '*.enum')
                    {
                        If ($ThisObject.enum -contains '') { $ThisObject.enum = $ThisObject.enum | Where-Object { $_ } } # error CS1519: Invalid token '=' in class, struct, or interface member declaration # FATAL: Error: Name is empty!
                    }
                    # Append "x-ms-enum" to "enum" section
                    If ($AttributePath -like '.paths.*.parameters.enum' -or $AttributePath -like '.definitions.GraphOperation-*.enum' -or $AttributePath -like '.parameters.*.enum')
                    {
                        $xMsEnum = [PSCustomObject]@{
                            name = If ($ThisObject.name) { $ThisObject.name }
                            Else { $ThisObjectName }
                            # modelAsString = $true
                        }
                        # C# does not like it when we use these characters/reserved words so we have to make the "Name" diffrent from the "Value"
                        If ($ThisObject.enum -contains 'system' -or $ThisObject.enum -like '*#*')
                        {
                            $xMsEnumValues = @(
                                $ThisObject.enum | ForEach-Object {
                                    $EnumItem = $_
                                    $EnumItemName = $EnumItem.Replace('#', '').Replace('system', 'systems') # C# does not like it when we use these characters/reserved words
                                    [PSCustomObject]@{
                                        name  = $EnumItemName;
                                        value = $EnumItem | ForEach-Object {
                                            If ($_ -match [regex]'(\#|\s)')
                                            {
                                                "'$($_)'"
                                            }
                                            Else
                                            {
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
                        If ([System.String]::IsNullOrEmpty($xMsEnumObjectByName))
                        {
                            $xMsEnumObjectFilteredId = 0
                            $xMsEnumItem = @{
                                Id   = $xMsEnumObjectFilteredId
                                Name = $ThisObjectName
                                Enum = $ThisObject.enum
                            }
                            $global:xMsEnumObject += $xMsEnumItem
                        }
                        Else
                        {
                            # See if x-ms-enum already exists by name and value
                            $xMsEnumObjectByNameValue = $global:xMsEnumObject | Where-Object { $_.Name -eq $ThisObjectName -and [String]$_.Enum -eq [String]$ThisObject.enum }
                            If ([System.String]::IsNullOrEmpty($xMsEnumObjectByNameValue))
                            {
                                $xMsEnumObjectFilteredId = [int](($xMsEnumObjectByName | Measure-Object -Property Id -Maximum).maximum) + 1
                                $xMsEnumItem = @{
                                    Id   = $xMsEnumObjectFilteredId
                                    Name = $ThisObjectName
                                    Enum = $ThisObject.enum
                                }
                                $global:xMsEnumObject += $xMsEnumItem
                            }
                            Else
                            {
                                $xMsEnumObjectFilteredId = $xMsEnumObjectByNameValue.Id
                            }
                        }
                        If ($xMsEnumObjectFilteredId -gt 0)
                        {
                            $ThisObject.'x-ms-enum'.name = "$($ThisObject.'x-ms-enum'.name)$($xMsEnumObjectFilteredId)"
                        }
                        # Write-Host ("$($CurrentSDKName)|$($NewOperationId)|$($AttributePath)|$($xMsEnumObjectFilteredId)|$($ThisObject.enum -join ',')")
                    }
                    # Check for when type is object without defined properties
                    If ($AttributePath -like '*.type')
                    {
                        If ('object' -in $ThisObject.type -and 'properties' -notin $ThisObject.PSObject.Properties.Name -and 'allOf' -notin $ThisObject.PSObject.Properties.Name -and 'additionalProperties' -notin $ThisObject.PSObject.Properties.Name)
                        {
                            Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:('additionalProperties') -Value:($true)
                        }
                    }
                    # Exclude $ref
                    If ($AttributeName -eq '$ref' -and (($ThisObject.$AttributeName).split('/') | Select-Object -Last 1) -in $global:ExcludedListOrg)
                    {
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
                    # Exclude paths
                    If ($AttributeName -in $global:ExcludedList)
                    {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                        $global:ExcludedList.Remove($AttributeName)
                    }
                    # Remove non 2XX response so that autorest returns correct errors to PowerShell
                    If ($AttributePath -like '.paths.*.responses.*' -and $AttributePath -notlike '.paths.*.responses.2*')
                    {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove endpoints that are not AutoRest compatible or that should be hidden from the public
                    If ($AttributePath -match '(.paths.)([a-zA-Z0-9\/\{\}\-_]+$|.*\.xml$)')
                    {
                        $ThisObject.$AttributeName.PSObject.Properties.Name | ForEach-Object {
                            $Method = $_
                            # Remove endpoint where "consumes" and "produces" does not contain "application/json" or "text/plain"
                            If (
                                ('produces' -in $ThisObject.$AttributeName.$Method.PSObject.Properties.Name -and $ThisObject.$AttributeName.$Method.produces -notcontains 'application/json' -and $ThisObject.$AttributeName.$Method.produces -notcontains 'text/plain') `
                                    -or ('consumes' -in $ThisObject.$AttributeName.$Method.PSObject.Properties.Name -and $ThisObject.$AttributeName.$Method.consumes -notcontains 'application/json' -and $ThisObject.$AttributeName.$Method.consumes -notcontains 'text/plain')
                            )
                            {
                                # Write-Warning ("Removing: $($AttributeName) - $($Method.ToUpper())")
                                $ThisObject.$AttributeName.PSObject.Properties.Remove($Method)
                            }
                            # Remove endpoints where ".public.x-stoplight.public" is "false"
                            If ('x-stoplight' -in $ThisObject.$AttributeName.$Method.PSObject.Properties.Name -and [String]$ThisObject.$AttributeName.$Method.'x-stoplight'.public -eq 'False')
                            {
                                # Write-Warning ("Removing: $($AttributeName) - $($Method.ToUpper())")
                                $ThisObject.$AttributeName.PSObject.Properties.Remove($Method)
                            }
                        }
                    }
                    # Remove x-stoplight sections
                    If ($AttributePath -like '*.x-stoplight') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove x-swagger-jumpcloud-auto-insert
                    If ($AttributePath -like '*.x-swagger-jumpcloud-auto-insert*') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove x-jumpcloud
                    If ($AttributePath -like '*.x-jumpcloud*') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove x-scopes
                    If ($AttributePath -like '*.x-scopes') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove x-tagGroups
                    If ($AttributePath -eq '.x-tagGroups') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove x-tests
                    If ($AttributePath -eq '.x-tests') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove x-go-package
                    If ($AttributePath -like '*.x-go-package') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove tags
                    If ($AttributePath -like '*.tags') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove x-tags
                    If ($AttributePath -like '*.x-tags*') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # Remove tagnames
                    If ($AttributePath -like '*.tagnames') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    # # If ($AttributePath -like '*.enum')
                    # { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    If ($ThisObject.$AttributeName)
                    {
                        $ModifiedObject = Update-SwaggerObject -InputObject:($ThisObject.$AttributeName) -InputObjectName:($AttributePath) -Sort:($Sort) -NoUpdate:($NoUpdate) -InputObjectOrg:($InputObjectOrg)
                        # If it was an array of objects before reapply the parent array.
                        If (($ThisObject.$AttributeName.GetType()).FullName -eq 'System.Object[]')
                        {
                            $ModifiedObject = @($ModifiedObject)
                        }
                        # Sort object
                        If ($Sort)
                        {
                            $ThisObject.PSObject.Properties.Remove($AttributeName)
                            Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:($AttributeName) -Value:($ModifiedObject)
                        }
                        Else
                        {
                            $ThisObject.$AttributeName = $ModifiedObject
                        }
                    }
                }
                Else
                {
                    If ($ThisObject.$AttributeName)
                    {
                        $ModifiedObject = Update-SwaggerObject -InputObject:($ThisObject.$AttributeName) -InputObjectName:($AttributePath) -Sort:($Sort) -NoUpdate:($NoUpdate) -InputObjectOrg:($InputObjectOrg)
                        # If it was an array of objects before reapply the parent array.
                        If (($ThisObject.$AttributeName.GetType()).FullName -eq 'System.Object[]')
                        {
                            $ModifiedObject = @($ModifiedObject)
                        }
                        # Sort object
                        If ($Sort)
                        {
                            $ThisObject.PSObject.Properties.Remove($AttributeName)
                            Add-Member -InputObject:($ThisObject) -MemberType:('NoteProperty') -Name:($AttributeName) -Value:($ModifiedObject)
                        }
                        Else
                        {
                            $ThisObject.$AttributeName = $ModifiedObject
                        }
                    }
                }
            }
        }
    }
    # Return modified object
    Return $InputObject
}
Function Format-SwaggerObject
{
    Param(
        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'An Object representing a swagger file.')]$InputObject
        , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Use to alphabetically order the properties within the swagger object.')][bool]$Sort = $true
    )
    $SortedSwaggerObject = Update-SwaggerObject -InputObject:($InputObject) -Sort:($Sort) -NoUpdate:($true)
    Return $SortedSwaggerObject
}
# Start script
$SDKName | ForEach-Object {
    $SDKNameItem = $_
    $global:xMsEnumObject = @()
    If ($TransformConfig.Contains($SDKNameItem))
    {
        $Config = $TransformConfig.($SDKNameItem)
        $CurrentSDKName = $SDKNameItem
        $global:OperationIdMapping = $Config.OperationIdMapping
        $global:ExcludedList = [System.Collections.ArrayList]$Config.ExcludedList
        $global:ExcludedListOrg = [System.Collections.ArrayList]$Config.ExcludedList
        # Create output file path
        $OutputFullPathJson = "$($OutputFilePath)/$($SDKNameItem).json"
        If (-not (Test-Path -Path:($OutputFilePath)))
        {
            New-Item -Path:($OutputFilePath) -ItemType:('Directory')
        }
        $RepoUrl = 'https://api.github.com/repos/TheJumpCloud/{0}' -f $Config.Repo
        $LatestReleaseUrl = '{0}/releases/latest' -f $RepoUrl
        # Get latest version of SI from GitHub
        $GitHubHeaders = @{
            'Authorization' = "token $GitHubAccessToken";
            'Accept'        = 'application/vnd.github.json.raw';
        }
        # Get repo's latest release
        $GitHubTag = If (-not [System.String]::IsNullOrEmpty($GitHubAccessToken) -and [System.String]::IsNullOrEmpty($GitHubTag))
        {
            (Invoke-RestMethod -Method:('GET') -Uri:($LatestReleaseUrl) -Headers:($GitHubHeaders)).tag_name
        }
        Else
        {
            'master'
        }
        Write-Host ("Latest Tag: $GitHubTag")
        # Get OAS content
        $SwaggerUrl = '{0}/contents/{1}?ref={2}' -f $RepoUrl, $Config.Path, $GitHubTag
        $OASContent = If ($SwaggerUrl -like '*api.github.com*' -and -not [System.String]::IsNullOrEmpty($GitHubAccessToken))
        {
            $RawContent = Invoke-RestMethod -Method:('GET') -Uri:($SwaggerUrl) -Headers:($GitHubHeaders)
            If ($SwaggerUrl -like '*.json*')
            {
                $RawContent | ConvertTo-Json -Depth:(100)
            }
            Else
            {
                $RawContent
            }
        }
        ElseIf ($SwaggerUrl -like '*https*')
        {
            (Invoke-WebRequest -Uri:($SwaggerUrl)).Content
        }
        Else
        {
            Get-Content -Path:($SwaggerUrl) -Raw
        }
        If ([System.String]::IsNullOrEmpty($OASContent))
        {
            Write-Error ("No content was returned from: $($SwaggerUrl)")
        }
        Else
        {
            # Prep json for find and replace by flattening string
            $SwaggerObjectContent = If ($SwaggerUrl -like '*.yaml*')
            {
                $OASContent | ConvertFrom-Yaml -Ordered # | ConvertTo-Yaml -JsonCompatible
            }
            Else
            {
                $OASContent | ConvertFrom-Json -Depth:(100)
            }
            # Format the spec
            $SwaggerObjectContent = Format-SwaggerObject -InputObject:($SwaggerObjectContent) -Sort:($SortAttributes)
            # Find and replace on file
            $SwaggerObject = $SwaggerObjectContent | ConvertTo-Json -Depth:(100) -Compress
            # Perform find and replace
            If (-not [System.String]::IsNullOrEmpty($Config.FindAndReplace))
            {
                ($Config.FindAndReplace).GetEnumerator() | ForEach-Object {
                    $PatternMatch = $SwaggerObject | Select-String -Pattern:([regex]($_.Name))
                    If (-not [System.String]::IsNullOrEmpty($PatternMatch))
                    {
                        Do
                        {
                            $SwaggerObject = $SwaggerObject -Replace ([regex]$_.Name, [string]$_.Value)
                            $PatternExists = $SwaggerObject | Select-String -Pattern:([regex]($_.Name))
                        } While ($PatternExists -and $PatternExists.Matches.Value -ne $_.Value)
                    }
                    Else
                    {
                        Write-Error ("Unable to find a match in '$CurrentSDKName' for:$($_.Name)")
                    }
                }
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
            $SwaggerObject = $SwaggerObject | ConvertFrom-Json -Depth:(100)
            $UpdatedSwagger = Update-SwaggerObject -InputObject:($SwaggerObject) -Sort:($SortAttributes) -InputObjectOrg:($SwaggerObject)
            #region Clean up paths without methods (that have been removed after stripping x-stoplight.public:false)
            $UpdatedSwagger.paths.PSObject.Properties.Name | ForEach-Object {
                $ValidPath = $false
                $UpdatedSwagger.paths.$_.PSObject.Properties.Name | ForEach-Object {
                    If ($_ -in ('delete', 'get', 'patch', 'post', 'put'))
                    {
                        $ValidPath = $true
                    }
                }
                If (-not $ValidPath)
                {
                    # Write-Warning ("Removing: $($_)")
                    $UpdatedSwagger.paths.PSObject.Properties.Remove($_)
                }
            }
            #endregion Clean up paths without methods (that have been removed after stripping x-stoplight.public:false)
            #region Clean up unused definitions and parameters
            Do
            {
                $UsedRefs = ($UpdatedSwagger | ConvertTo-Json -Depth:(100) -Compress | Select-String -Pattern:('(\{"\$ref":")(.*?)("\})') -AllMatches).Matches
                If (-not [System.String]::IsNullOrEmpty($UsedRefs))
                {
                    $UsedDefinitions = ($UsedRefs | ForEach-Object { $_.Groups[2].Value.Where( { $_ -like '*definitions*' }) }) | ForEach-Object { $_.Split('/') | Select-Object -Last 1 } | Select-Object -Unique | Sort-Object
                    $UsedParameters = ($UsedRefs | ForEach-Object { $_.Groups[2].Value.Where( { $_ -like '*parameters*' }) }) | ForEach-Object { $_.Split('/') | Select-Object -Last 1 } | Select-Object -Unique | Sort-Object
                }
                # Remove unused definitions
                $AllDefinitions = $UpdatedSwagger.definitions.PSObject.Properties.Name | Select-Object -Unique | Sort-Object
                $AllDefinitions | ForEach-Object {
                    If ($UsedDefinitions -notcontains $_)
                    {
                        # Write-Warning ("Removing unused definition: $_")
                        $UpdatedSwagger.definitions.PSObject.Properties.Remove($_)
                    }
                }
                $DefinitionResults = If (-not [System.String]::IsNullOrEmpty($UsedDefinitions) -and -not [System.String]::IsNullOrEmpty($AllDefinitions))
                {
                    Compare-Object -ReferenceObject $UsedDefinitions -DifferenceObject $AllDefinitions
                }
                # Remove unused parameters
                $AllParameters = $UpdatedSwagger.parameters.PSObject.Properties.Name | Select-Object -Unique | Sort-Object
                $AllParameters | ForEach-Object {
                    If ($UsedParameters -notcontains $_)
                    {
                        # Write-Warning ("Removing unused parameter: $_")
                        $UpdatedSwagger.parameters.PSObject.Properties.Remove($_)
                    }
                }
                $ParameterResults = If (-not [System.String]::IsNullOrEmpty($UsedParameters) -and -not [System.String]::IsNullOrEmpty($AllParameters))
                {
                    Compare-Object -ReferenceObject $UsedParameters -DifferenceObject $AllParameters
                }
            } While ($DefinitionResults -or $ParameterResults)
            #endregion
            $SwaggerString = $UpdatedSwagger | ConvertTo-Json -Depth:(100)
            # TODO: Validate that all "enum" locations have been updated to add "x-ms-enum"
            # Validate that all operationIds in mapping have been found in spec
            If (-not [System.String]::IsNullOrEmpty($global:OperationIdMapping))
            {
                ($global:OperationIdMapping).GetEnumerator() | ForEach-Object {
                    Write-Error ("In '$($CurrentSDKName)' unable to find operationId '$($_.Key)'.")
                }
            }
            # Validate that all "ExcludedList" in mapping have been removed from spec
            If (-not [System.String]::IsNullOrEmpty($global:ExcludedList))
            {
                $global:ExcludedList | ForEach-Object {
                    Write-Error ("In '$($CurrentSDKName)' unable to find ExcludedPath '$($_)'.")
                }
            }
            $global:ExcludedListOrg | ForEach-Object {
                If ($SwaggerString -match """$($_)""" -or $SwaggerString -match [regex]("(""\`$ref"": ""\#\/)(.*?)($($_)"")"))
                {
                    Write-Error ("In '$($CurrentSDKName)' the item '$($_)' has not been excluded.")
                }
            }
            # Validate that "tags" have been removed
            $Tags = $SwaggerString | Select-String -Pattern:('"Tags"')
            If ($Tags.Matches.Value)
            {
                Write-Error ("In '$($CurrentSDKName)' still has '$($Tags.Matches.Value)' in it.")
            }
            # Compare current spec to old spec and if they are diffrent then export the new file
            $UpdatedSpec = $false
            If (Test-Path -Path:($OutputFullPathJson))
            {
                $OldSpec = Get-Content -Path:($OutputFullPathJson) -Raw | ConvertFrom-Json -Depth:(100) | ConvertTo-Json -Depth:(100)
                If (-not [System.String]::IsNullOrEmpty($OldSpec))
                {
                    $CompareResults = Compare-Object -ReferenceObject:($OldSpec.Trim()) -DifferenceObject:($SwaggerString.Trim())
                    If (-not [System.String]::IsNullOrEmpty($CompareResults))
                    {
                        $UpdatedSpec = $true
                    }
                }
                Else
                {
                    $UpdatedSpec = $true
                }
            }
            Else
            {
                $UpdatedSpec = $true
            }
            # Format the results
            $SwaggerString = Format-SwaggerObject -InputObject:($SwaggerString | ConvertFrom-Json -Depth:(100)) -Sort:($SortAttributes) | ConvertTo-Json -Depth:(100)
            # Output new file
            $SwaggerString | Out-File -Path:($OutputFullPathJson) -Force
            # # For comparing before and after
            # $SwaggerObjectContent | ConvertTo-Json -Depth:(100) -Compress | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.FindAndReplace")) -Force # For Debugging to compare before and after
            # $SwaggerObjectOrg = Format-SwaggerObject -InputObject:($SwaggerObjectContent | ConvertTo-Json -Depth:(100) | ConvertFrom-Json -Depth:(100)) -Sort:($SortAttributes)
            # $SwaggerObjectContent | ConvertTo-Json -Depth:(100) | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.Before")) -Force # For Debugging to compare before and after
            # # $SwaggerObjectContent | ConvertTo-Json -Depth:(100) -Compress | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.Before")) -Force # For Debugging to compare before and after
            # $UpdatedSwagger | ConvertTo-Json -Depth:(100) | Out-File -Path:($OutputFullPathJson.Replace($CurrentSDKName, "$CurrentSDKName.After")) -Force # For Debugging to compare before and after
            # Return variable to Azure Pipelines
            Return $UpdatedSpec
        }
    }
    Else
    {
        Write-Error ("Config 'TransformConfig' does not contain an SDK called '$($SDKNameItem)'.")
    }
}
