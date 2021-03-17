#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('JumpCloud.SDK.V1', 'JumpCloud.SDK.V2', 'JumpCloud.SDK.DirectoryInsights')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub Personal Access Token.')][ValidateNotNullOrEmpty()][System.String]$GitHubAccessToken
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Use to alphabetically order the properties within the swagger object.')][bool]$SortAttributes = $true
)
Set-Location $PSScriptRoot
$OutputFilePath = $PSScriptRoot + '/SwaggerSpecs'
# OperationId to Function name mapping - https://github.com/Azure/autorest.powershell/blob/a530bd721c9326a4356fba15638fee236722aca9/powershell/autorest-configuration.md
$TransformConfig = [Ordered]@{
    'JumpCloud.SDK.DirectoryInsights' = [PSCustomObject]@{
        Url                = 'https://api.stoplight.io/v1/versions/fj5YeBmMuwbb6dghr/export/oas.yaml';
        FindAndReplace     = [Ordered]@{
            '"basePath":"\/insights\/directory\/v1"'                                                                                                                                                                                                                 = '"basePath":"/insights/directory/v1/"'; # The extra slash at the end is needed to properly build the url.
            '"TermConjunction":{"title":"TermConjunction","description":"TermConjunction represents a conjunction (and\/or)\nNOTE: the validator limits what the operator can be, not the object\nfor future-proof-ness\nand a list of sub-values","type":"object"}' = '"TermConjunction":{"title":"TermConjunction","description":"TermConjunction represents a conjunction (and/or)\nNOTE: the validator limits what the operator can be, not the object\nfor future-proof-ness\nand a list of sub-values","type":"object","additionalProperties":true}'
        };
        OperationIdMapping = [Ordered]@{
            'POST_events'          = 'Get-Event';
            'POST_events-count'    = 'Get-EventCount';
            'POST_events-interval' = 'Get-EventInterval';
            'POST_events-distinct' = 'Get-EventDistinct';
        };
        ExcludedList       = @();
    }
    'JumpCloud.SDK.V1'                = [PSCustomObject]@{
        Url                = 'https://api.stoplight.io/v1/versions/MeLBYr6CGg2f4g9Qh/export/oas.yaml'
        FindAndReplace     = [Ordered]@{
            # Path Issues
            '"#\/definitions\/system"'                                                 = '"#/definitions/JcSystem"'; # error CS0426: The type name 'ComponentModel' does not exist in the type 'System'
            '"system":{"title":"System"'                                               = '"JcSystem":{"title":"JcSystem"'; # error CS0426: The type name 'ComponentModel' does not exist in the type 'System'
            # V1 Issues
            '"basePath":"\/api"'                                                       = '"basePath":"/api/"'; # The extra slash at the end is needed to properly build the url.
            '"type":"null"'                                                            = '"type":"string"'; # A type of null is not valid.
            '"format":"email",'                                                        = ''; # WARNING (LLCS1001/DoesNotSupportEnum):Schema with type:'string and 'format:'email' is not recognized.
            '"internal":{"type":"object","properties":{"deviceId":{"type":"string"}}}' = ''
            # Custom Tweaks
            '{"\$ref":"#\/parameters\/trait:systemContextAuth:Authorization"}'         = ''; # We dont want to support authentication through system context via the SDK
            '{"\$ref":"#\/parameters\/trait:systemContextAuth:Date"}'                  = ''; # We dont want to support authentication through system context via the SDK
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Content-Type"}'             = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Accept"}'                   = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"}'      = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            '{"name":"Content-Type","in":"header","required":false,"type":"string"}'   = ''; # This will be passed in later through the Module.cs file.
            '{"name":"Accept","in":"header","required":false,"type":"string"}'         = ''; # This will be passed in later through the Module.cs file.
            '{"name":"x-org-id","in":"header","required":false,"type":"string"}'       = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            ',,'                                                                       = ',';
            '\[,'                                                                      = '[';
            ',]'                                                                       = ']';
        };
        OperationIdMapping = [Ordered]@{
            'POST_applications'                               = 'Create-Application';
            'DELETE_applications-id'                          = 'Delete-Application';
            'GET_applications-id'                             = 'Get-Application';
            'GET_applications'                                = 'List-Application';
            'PUT_applications-id'                             = 'Set-Application';
            'GET_application-templates-id'                    = 'Get-ApplicationTemplate';
            'GET_application-templates'                       = 'List-ApplicationTemplate';
            'POST_commands'                                   = 'Create-Command';
            'DELETE_commands-id'                              = 'Delete-Command';
            'GET_commands-id'                                 = 'Get-Command';
            'GET_commands'                                    = 'List-Command';
            'PUT_commands-id'                                 = 'Set-Command';
            'GET_files-command-id'                            = 'Get-CommandFile';
            'DELETE_commandresults-id'                        = 'Delete-CommandResult';
            'GET_commandresults-id'                           = 'Get-CommandResult';
            'GET_commandresults'                              = 'List-CommandResult';
            'POST_command-trigger-triggername'                = 'POST-CommandTrigger';
            'POST_systemusers-id-expire'                      = 'POST-ExpireUserPassword';
            'GET_organizations-id'                            = 'Get-Organization';
            'GET_organizations'                               = 'List-Organization';
            'POST_search-organizations'                       = 'Search-Organization';
            'PUT_organizations-id'                            = 'Set-Organization';
            'POST_radiusservers'                              = 'Create-RadiusServer';
            'DELETE_radiusservers-id'                         = 'Delete-RadiusServer';
            'GET_radiusservers-id'                            = 'Get-RadiusServer';
            'GET_radiusservers'                               = 'List-RadiusServer';
            'PUT_radiusservers-id'                            = 'Set-RadiusServer';
            'POST_systems-system_id-command-builtin-erase'    = 'Clear-System';
            'DELETE_systems-id'                               = 'Delete-System';
            'GET_systems-id'                                  = 'Get-System';
            'GET_systems'                                     = 'List-System';
            'POST_systems-system_id-command-builtin-lock'     = 'Lock-System';
            'POST_systems-system_id-command-builtin-restart'  = 'Restart-System';
            'POST_search-systems'                             = 'Search-System';
            'PUT_systems-id'                                  = 'Set-System';
            'POST_systems-system_id-command-builtin-shutdown' = 'Stop-System';
            'POST_systemusers'                                = 'Create-User';
            'DELETE_systemusers-id'                           = 'Delete-User';
            'GET_systemusers-id'                              = 'Get-User';
            'GET_systemusers'                                 = 'List-User';
            'POST_search-systemusers'                         = 'Search-User';
            'PUT_systemusers-id'                              = 'Set-User';
            'POST_systemusers-id-unlock'                      = 'Unlock-User';
            'POST_systemusers-id-resetmfa'                    = 'Reset-UserMfa';
            'POST_systemusers-id-sshkeys'                     = 'Create-UserSshKey';
            'DELETE_systemusers-systemuser_id-sshkeys-id'     = 'Delete-UserSshKey';
            'GET_systemusers-id-sshkeys'                      = 'Get-UserSshKey';
        };
        ExcludedList       = @();
    }
    'JumpCloud.SDK.V2'                = [PSCustomObject]@{
        Url                = 'https://api.stoplight.io/v1/versions/kP6fw2Ppd9ZbbfNmT/export/oas.yaml'
        FindAndReplace     = [Ordered]@{
            # V2 Issues
            '"basePath":"\/api\/v2"'                                                                               = '"basePath":"/api/v2/"'; # The extra slash at the end is needed to properly build the url.
            '\["string","number","boolean","array"]'                                                               = '"string"'; # FAILURE  {} Error:Invalid type 'string,number,boolean,array' in schema
            '\["string","number","boolean","array","null"]'                                                        = '"string"' #  FAILURE  {} Error:Invalid type 'string,number,boolean,array,null' in schema
            '\["object","null"]'                                                                                   = '"object"';
            '\["string","null"]'                                                                                   = '"string"';
            '\["boolean","null"]'                                                                                  = '"boolean"'; # Error:Invalid type 'boolean,null' in schema
            '\["integer","null"]'                                                                                  = '"integer"'; # Error:Invalid type 'integer,null' in schema
            '\["number","null"]'                                                                                   = '"number"'; # Error:Invalid type 'number,null' in schema
            '"jobId"'                                                                                              = '"id"'; # The transform removes the "-" in the parent objects name,"job-id",which makes the parent name the same as the child.
            '"type":"null"'                                                                                        = '"type":"string"'; # Error: Invalid type 'null' in schema
            'software-app-settings'                                                                                = 'SoftwareAppSettings'; # Error: Collision detected inserting into object: software-app-settings
            'custom email type","parameters":\[{"name":"body"'                                                     = 'custom email type","parameters":[{"name":"CustomEmail"'; # The type 'SetJcSdkInternalCustomEmailConfiguration_SetExpanded, SetJcSdkInternalCustomEmailConfiguration_SetViaIdentityExpanded, NewJcSdkInternalCustomEmailConfiguration_CreateExpanded' already contains a definition for 'Body'
            '"format":"uint32"'                                                                                    = '"format":"int64"' # SI code uses uint32 which is larger than int32 . Swagger 2 doesnt have a concept of uint32 . AutoRest defaults to int32 when it sees a type of integer.
            # Custom Tweaks
            '{"\$ref":"#\/parameters\/trait:requestHeaders:creation-source"}'                                      = ''; # Stoplight is adding this in a lot of places it shouldnt be so were just going to remove it
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Content-Type"}'                                         = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:requestHeaders:Accept"}'                                               = ''; # This will be passed in later through the Module.cs file.
            '{"\$ref":"#\/parameters\/trait:multiTenantRequestHeaders:x-org-id"}'                                  = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            '{"name":"Content-Type","in":"header","required":false,"type":"string","default":"application\/json"}' = ''; # This will be passed in later through the Module.cs file.
            '{"name":"Accept","in":"header","required":false,"type":"string","default":"application\/json"}'       = ''; # This will be passed in later through the Module.cs file.
            '{"name":"x-org-id","in":"header","required":false,"type":"string"}'                                   = ''; # Along with the ApiKey this will be passed in later through the Module.cs file.
            '{"name":"x-api-key","in":"header","required":false,"type":"string"}'                                  = ''; # This will be passed in later through the Module.cs file.
            ',,'                                                                                                   = ',';
            '\[,'                                                                                                  = '[';
            ',]'                                                                                                   = ']';
            '"collection_time":".*?",'                                                                             = '"collection_time":"2020-01-01T00:00:00.00-06:00",'; # Stoplight keeps updating these examples when we want them to remain static
        };
        OperationIdMapping = [Ordered]@{
            'GET_activedirectories-id'                                   = 'Get-ActiveDirectory';
            'GET_activedirectories'                                      = 'List-ActiveDirectory';
            'GET_activedirectories-activedirectory_id-associations'      = 'Get-ActiveDirectoryAssociation';
            'POST_activedirectories-activedirectory_id-associations'     = 'Set-ActiveDirectoryAssociation';
            'GET_activedirectories-activedirectory_id-usergroups'        = 'Get-ActiveDirectoryTraverseUserGroup';
            'DELETE_applemdms-id'                                        = 'Delete-AppleMDM';
            'GET_applemdms'                                              = 'List-AppleMDM';
            'PUT_applemdms-id'                                           = 'Set-AppleMDM';
            'GET_applemdms-apple_mdm_id-csr'                             = 'Get-AppleMDMCsr';
            'GET_applemdms-apple_mdm_id-depkey'                          = 'Get-AppleMDMDepKey';
            'POST_applemdms-apple_mdm_id-devices-device_id-erase'        = 'Clear-AppleMDMDevice';
            'GET_applemdms-apple_mdm_id-devices'                         = 'List-AppleMDMDevice';
            'POST_applemdms-apple_mdm_id-devices-device_id-lock'         = 'Lock-AppleMDMDevice';
            'POST_applemdms-apple_mdm_id-devices-device_id-restart'      = 'Restart-AppleMDMDevice';
            'POST_applemdms-apple_mdm_id-devices-device_id-shutdown'     = 'Stop-AppleMDMDevice';
            'POST_applemdms-apple_mdm_id-refreshdepdevices'              = 'Sync-AppleMDMDevice';
            'GET_applemdms-apple_mdm_id-enrollmentprofiles-id'           = 'Get-AppleMDMEnrollmentProfile';
            'GET_applemdms-apple_mdm_id-enrollmentprofiles'              = 'List-AppleMDMEnrollmentProfile';
            'GET_applications-application_id-associations'               = 'Get-ApplicationAssociation';
            'POST_applications-application_id-associations'              = 'Set-ApplicationAssociation';
            'GET_applications-application_id-users'                      = 'Get-ApplicationTraverseUser';
            'GET_applications-application_id-usergroups'                 = 'Get-ApplicationTraverseUserGroup';
            'POST_authn-policies'                                        = 'Create-AuthenticationPolicy';
            'DELETE_authn-policies-id'                                   = 'Delete-AuthenticationPolicy';
            'GET_authn-policies-id'                                      = 'Get-AuthenticationPolicy';
            'GET_authn-policies'                                         = 'List-AuthenticationPolicy';
            'PATCH_authn-policies-id'                                    = 'Update-AuthenticationPolicy';
            'POST_bulk-users'                                            = 'Create-BulkUsers';
            'PATCH_bulk-users'                                           = 'Update-BulkUsers';
            'GET_bulk-users-job_id-results'                              = 'Get-BulkUsersResult';
            'GET_commands-command_id-associations'                       = 'Get-CommandAssociation';
            'POST_commands-command_id-associations'                      = 'Set-CommandAssociation';
            'GET_commands-command_id-systems'                            = 'Get-CommandTraverseSystem';
            'GET_commands-command_id-systemgroups'                       = 'Get-CommandTraverseSystemGroup';
            'POST_customemails'                                          = 'Create-CustomEmailConfiguration';
            'DELETE_customemails-custom_email_type'                      = 'Delete-CustomEmailConfiguration';
            'GET_customemails-custom_email_type'                         = 'Get-CustomEmailConfiguration';
            'PUT_customemails-custom_email_type'                         = 'Set-CustomEmailConfiguration';
            'GET_customemail-templates'                                  = 'List-CustomEmailTemplates';
            'GET_directories'                                            = 'List-Directory';
            'POST_duo-accounts'                                          = 'Create-DuoAccount';
            'DELETE_duo-accounts-id'                                     = 'Delete-DuoAccount';
            'GET_duo-accounts-id'                                        = 'Get-DuoAccount';
            'GET_duo-accounts'                                           = 'List-DuoAccount';
            'POST_duo-accounts-account_id-applications'                  = 'Create-DuoApplication';
            'DELETE_duo-accounts-account_id-applications-application_id' = 'Delete-DuoApplication';
            'GET_duo-accounts-account_id-applications-application_id'    = 'Get-DuoApplication';
            'GET_duo-accounts-account_id-applications'                   = 'List-DuoApplication';
            'PUT_duo-accounts-account_id-applications-application_id'    = 'Set-DuoApplication';
            'GET_groups'                                                 = 'List-Group';
            'GET_gsuites-id'                                             = 'Get-GSuite';
            'PATCH_gsuites-id'                                           = 'Update-GSuite';
            'GET_gsuites-gsuite_id-associations'                         = 'Get-GSuiteAssociation';
            'POST_gsuites-gsuite_id-associations'                        = 'Set-GSuiteAssociation';
            'POST_gsuites-gsuite_id-translationrules'                    = 'Create-GSuiteTranslationRule';
            'DELETE_gsuites-gsuite_id-translationrules-id'               = 'Delete-GSuiteTranslationRule';
            'GET_gsuites-gsuite_id-translationrules-id'                  = 'Get-GSuiteTranslationRule';
            'GET_gsuites-gsuite_id-translationrules'                     = 'List-GSuiteTranslationRule';
            'GET_gsuites-gsuite_id-users'                                = 'Get-GSuiteTraverseUser';
            'GET_gsuites-gsuite_id-usergroups'                           = 'Get-GSuiteTraverseUserGroup';
            'GET_gsuites-gsuite_id-import-users'                         = 'List-GSuiteUsersToImport';
            'POST_iplists'                                               = 'Create-IpList';
            'DELETE_iplists-id'                                          = 'Delete-IpList';
            'GET_iplists-id'                                             = 'Get-IpList';
            'GET_iplists'                                                = 'List-IpList';
            'PUT_iplists-id'                                             = 'Set-IpList';
            'PATCH_iplists-id'                                           = 'Update-IpList';
            'GET_ldapservers-id'                                         = 'Get-LdapServer';
            'GET_ldapservers'                                            = 'List-LdapServer';
            'PATCH_ldapservers-id'                                       = 'Update-LdapServer';
            'GET_ldapservers-ldapserver_id-associations'                 = 'Get-LdapServerAssociation';
            'POST_ldapservers-ldapserver_id-associations'                = 'Set-LdapServerAssociation';
            'POST_ldapservers-ldapserver_id-sambadomains'                = 'Create-LdapServerSambaDomain';
            'DELETE_ldapservers-ldapserver_id-sambadomains-id'           = 'Delete-LdapServerSambaDomain';
            'GET_ldapservers-ldapserver_id-sambadomains-id'              = 'Get-LdapServerSambaDomain';
            'GET_ldapservers-ldapserver_id-sambadomains'                 = 'List-LdapServerSambaDomain';
            'PUT_ldapservers-ldapserver_id-sambadomains-id'              = 'Set-LdapServerSambaDomain';
            'GET_ldapservers-ldapserver_id-users'                        = 'Get-LdapServerTraverseUser';
            'GET_ldapservers-ldapserver_id-usergroups'                   = 'Get-LdapServerTraverseUserGroup';
            'GET_office365s-office365_id'                                = 'Get-Office365';
            'PATCH_office365s-office365_id'                              = 'Update-Office365';
            'GET_office365s-office365_id-associations'                   = 'Get-Office365Association';
            'POST_office365s-office365_id-associations'                  = 'Set-Office365Association';
            'POST_office365s-office365_id-translationrules'              = 'Create-Office365TranslationRule';
            'DELETE_office365s-office365_id-translationrules-id'         = 'Delete-Office365TranslationRule';
            'GET_office365s-office365_id-translationrules-id'            = 'Get-Office365TranslationRule';
            'GET_office365s-office365_id-translationrules'               = 'List-Office365TranslationRule';
            'GET_office365s-office365_id-users'                          = 'Get-Office365TraverseUser';
            'GET_office365s-office365_id-usergroups'                     = 'Get-Office365TraverseUserGroup';
            'GET_office365s-office365_id-import-users'                   = 'List-Office365UsersToImport';
            'GET_policyresults'                                          = 'List-OrganizationPolicyResult';
            'POST_policies'                                              = 'Create-Policy';
            'DELETE_policies-id'                                         = 'Delete-Policy';
            'GET_policies-id'                                            = 'Get-Policy';
            'GET_policies'                                               = 'List-Policy';
            'PUT_policies-id'                                            = 'Set-Policy';
            'GET_policies-policy_id-associations'                        = 'Get-PolicyAssociation';
            'POST_policies-policy_id-associations'                       = 'Set-PolicyAssociation';
            'GET_policyresults-id'                                       = 'Get-PolicyResult';
            'GET_policies-policy_id-policyresults'                       = 'List-PolicyResult';
            'GET_policies-policy_id-policystatuses'                      = 'List-PolicyStatus';
            'GET_policytemplates-id'                                     = 'Get-PolicyTemplate';
            'GET_policytemplates'                                        = 'List-PolicyTemplate';
            'GET_policies-policy_id-systems'                             = 'Get-PolicyTraverseSystem';
            'GET_policies-policy_id-systemgroups'                        = 'Get-PolicyTraverseSystemGroup';
            'POST_providers-provider_id-administrators'                  = 'Create-ProviderAdministrator';
            'GET_providers-provider_id-administrators'                   = 'List-ProviderAdministrator';
            'GET_radiusservers-radiusserver_id-associations'             = 'Get-RadiusServerAssociation';
            'POST_radiusservers-radiusserver_id-associations'            = 'Set-RadiusServerAssociation';
            'GET_radiusservers-radiusserver_id-users'                    = 'Get-RadiusServerTraverseUser';
            'GET_radiusservers-radiusserver_id-usergroups'               = 'Get-RadiusServerTraverseUserGroup';
            'POST_softwareapps'                                          = 'Create-SoftwareApp';
            'DELETE_softwareapps-id'                                     = 'Delete-SoftwareApp';
            'GET_softwareapps-id'                                        = 'Get-SoftwareApp';
            'GET_softwareapps'                                           = 'List-SoftwareApp';
            'PUT_softwareapps-id'                                        = 'Set-SoftwareApp';
            'GET_softwareapps-software_app_id-associations'              = 'Get-SoftwareAppAssociation';
            'POST_softwareapps-software_app_id-associations'             = 'Set-SoftwareAppAssociation';
            'GET_softwareapps-software_app_id-statuses'                  = 'Get-SoftwareAppStatus';
            'GET_softwareapps-software_app_id-systems'                   = 'Get-SoftwareAppTraverseSystem';
            'GET_softwareapps-software_app_id-systemgroups'              = 'Get-SoftwareAppTraverseSystemGroup';
            'GET_subscriptions'                                          = 'Get-Subscription';
            'GET_systems-system_id-associations'                         = 'Get-SystemAssociation';
            'POST_systems-system_id-associations'                        = 'Set-SystemAssociation';
            'GET_systems-system_id-fdekey'                               = 'Get-SystemFDEKey';
            'POST_systemgroups'                                          = 'Create-SystemGroup';
            'DELETE_systemgroups-id'                                     = 'Delete-SystemGroup';
            'GET_systemgroups-id'                                        = 'Get-SystemGroup';
            'GET_systemgroups'                                           = 'List-SystemGroup';
            'PUT_systemgroups-id'                                        = 'Set-SystemGroup';
            'GET_systemgroups-group_id-associations'                     = 'Get-SystemGroupAssociation';
            'POST_systemgroups-group_id-associations'                    = 'Set-SystemGroupAssociation';
            'GET_systemgroups-group_id-members'                          = 'Get-SystemGroupMembers';
            'POST_systemgroups-group_id-members'                         = 'Set-SystemGroupMembers';
            'GET_systemgroups-group_id-membership'                       = 'Get-SystemGroupMembership';
            'GET_systemgroups-group_id-commands'                         = 'Get-SystemGroupTraverseCommand';
            'GET_systemgroups-group_id-policies'                         = 'Get-SystemGroupTraversePolicy';
            'GET_systemgroups-group_id-users'                            = 'Get-SystemGroupTraverseUser';
            'GET_systemgroups-group_id-usergroups'                       = 'Get-SystemGroupTraverseUserGroup';
            'GET_systeminsights-alf'                                     = 'List-SystemInsightsAlf';
            'GET_systeminsights-alf_exceptions'                          = 'List-SystemInsightsAlfException';
            'GET_systeminsights-alf_explicit_auths'                      = 'List-SystemInsightsAlfExplicitAuth';
            'GET_systeminsights-appcompat_shims'                         = 'List-SystemInsightsAppCompatShim';
            'GET_systeminsights-apps'                                    = 'List-SystemInsightsApps';
            'GET_systeminsights-authorized_keys'                         = 'List-SystemInsightsAuthorizedKey';
            'GET_systeminsights-battery'                                 = 'List-SystemInsightsBattery';
            'GET_systeminsights-bitlocker_info'                          = 'List-SystemInsightsBitlockerInfo';
            'GET_systeminsights-browser_plugins'                         = 'List-SystemInsightsBrowserPlugins';
            'GET_systeminsights-certificates'                            = 'List-SystemInsightsCertificates';
            'GET_systeminsights-chrome_extensions'                       = 'List-SystemInsightsChromeExtensions';
            'GET_systeminsights-connectivity'                            = 'List-SystemInsightsConnectivity';
            'GET_systeminsights-crashes'                                 = 'List-SystemInsightsCrashes';
            'GET_systeminsights-cups_destinations'                       = 'List-SystemInsightsCupsDestinations';
            'GET_systeminsights-disk_encryption'                         = 'List-SystemInsightsDiskEncryption';
            'GET_systeminsights-disk_info'                               = 'List-SystemInsightsDiskInfo';
            'GET_systeminsights-dns_resolvers'                           = 'List-SystemInsightsDnsResolver';
            'GET_systeminsights-etc_hosts'                               = 'List-SystemInsightsEtcHosts';
            'GET_systeminsights-firefox_addons'                          = 'List-SystemInsightsFirefoxAddons';
            'GET_systeminsights-groups'                                  = 'List-SystemInsightsGroups';
            'GET_systeminsights-ie_extensions'                           = 'List-SystemInsightsIEExtensions';
            'GET_systeminsights-interface_addresses'                     = 'List-SystemInsightsInterfaceAddresses';
            'GET_systeminsights-interface_details'                       = 'List-SystemInsightsInterfaceDetails';
            'GET_systeminsights-kernel_info'                             = 'List-SystemInsightsKernelInfo';
            'GET_systeminsights-launchd'                                 = 'List-SystemInsightsLaunchd';
            'GET_systeminsights-logged_in_users'                         = 'List-SystemInsightsLoggedinUsers';
            'GET_systeminsights-logical_drives'                          = 'List-SystemInsightsLogicalDrives';
            'GET_systeminsights-managed_policies'                        = 'List-SystemInsightsManagedPolicies';
            'GET_systeminsights-mounts'                                  = 'List-SystemInsightsMounts';
            'GET_systeminsights-os_version'                              = 'List-SystemInsightsOsVersion';
            'GET_systeminsights-patches'                                 = 'List-SystemInsightsPatches';
            'GET_systeminsights-programs'                                = 'List-SystemInsightsPrograms';
            'GET_systeminsights-python_packages'                         = 'List-SystemInsightsPythonPackages';
            'GET_systeminsights-safari_extensions'                       = 'List-SystemInsightsSafariExtensions';
            'GET_systeminsights-scheduled_tasks'                         = 'List-SystemInsightsScheduledTasks';
            'GET_systeminsights-services'                                = 'List-SystemInsightsServices';
            'GET_systeminsights-shadow'                                  = 'List-SystemInsightsShadow';
            'GET_systeminsights-shared_folders'                          = 'List-SystemInsightsSharedFolders';
            'GET_systeminsights-shared_resources'                        = 'List-SystemInsightsSharedResources';
            'GET_systeminsights-sharing_preferences'                     = 'List-SystemInsightsSharingPreferences';
            'GET_systeminsights-sip_config'                              = 'List-SystemInsightsSipConfig';
            'GET_systeminsights-startup_items'                           = 'List-SystemInsightsStartupItems';
            'GET_systeminsights-system_controls'                         = 'List-SystemInsightsSystemControls';
            'GET_systeminsights-system_info'                             = 'List-SystemInsightsSystemInfo';
            'GET_systeminsights-uptime'                                  = 'List-SystemInsightsUptime';
            'GET_systeminsights-usb_devices'                             = 'List-SystemInsightsUSBDevices';
            'GET_systeminsights-user_groups'                             = 'List-SystemInsightsUserGroups';
            'GET_systeminsights-users'                                   = 'List-SystemInsightsUsers';
            'GET_systeminsights-user_ssh_keys'                           = 'List-SystemInsightsUserSSHKeys';
            'GET_systeminsights-wifi_networks'                           = 'List-SystemInsightsWifiNetwork';
            'GET_systeminsights-wifi_status'                             = 'List-SystemInsightsWifiStatus';
            'GET_systeminsights-windows_security_products'               = 'List-SystemInsightsWindowsSecurityProduct';
            'GET_systems-system_id-memberof'                             = 'Get-SystemMember';
            'GET_systems-system_id-policystatuses'                       = 'List-SystemsPolicyStatus';
            'GET_systems-system_id-commands'                             = 'Get-SystemTraverseCommand';
            'GET_systems-system_id-policies'                             = 'Get-SystemTraversePolicy';
            'GET_systems-system_id-users'                                = 'Get-SystemTraverseUser';
            'GET_systems-system_id-usergroups'                           = 'Get-SystemTraverseUserGroup';
            'GET_users-user_id-associations'                             = 'Get-UserAssociation';
            'POST_users-user_id-associations'                            = 'Set-UserAssociation';
            'POST_usergroups'                                            = 'Create-UserGroup';
            'DELETE_usergroups-id'                                       = 'Delete-UserGroup';
            'GET_usergroups-id'                                          = 'Get-UserGroup';
            'GET_usergroups'                                             = 'List-UserGroup';
            'PUT_usergroups-id'                                          = 'Set-UserGroup';
            'GET_usergroups-group_id-associations'                       = 'Get-UserGroupAssociation';
            'POST_usergroups-group_id-associations'                      = 'Set-UserGroupAssociation';
            'GET_usergroups-group_id-members'                            = 'Get-UserGroupMembers';
            'POST_usergroups-group_id-members'                           = 'Set-UserGroupMembers';
            'GET_usergroups-group_id-membership'                         = 'Get-UserGroupMembership';
            'GET_usergroups-group_id-applications'                       = 'Get-UserGroupTraverseApplication';
            'GET_usergroups-group_id-directories'                        = 'Get-UserGroupTraverseDirectory';
            'GET_usergroups-group_id-gsuites'                            = 'Get-UserGroupTraverseGSuite';
            'GET_usergroups-group_id-ldapservers'                        = 'Get-UserGroupTraverseLdapServer';
            'GET_usergroups-group_id-office365s'                         = 'Get-UserGroupTraverseOffice365';
            'GET_usergroups-group_id-radiusservers'                      = 'Get-UserGroupTraverseRadiusServer';
            'GET_usergroups-group_id-systems'                            = 'Get-UserGroupTraverseSystem';
            'GET_usergroups-group_id-systemgroups'                       = 'Get-UserGroupTraverseSystemGroup';
            'GET_users-user_id-memberof'                                 = 'Get-UserMember';
            'GET_users-user_id-applications'                             = 'Get-UserTraverseApplication';
            'GET_users-user_id-directories'                              = 'Get-UserTraverseDirectory';
            'GET_users-user_id-gsuites'                                  = 'Get-UserTraverseGSuite';
            'GET_users-user_id-ldapservers'                              = 'Get-UserTraverseLdapServer';
            'GET_users-user_id-office365s'                               = 'Get-UserTraverseOffice365';
            'GET_users-user_id-radiusservers'                            = 'Get-UserTraverseRadiusServer';
            'GET_users-user_id-systems'                                  = 'Get-UserTraverseSystem';
            'GET_users-user_id-systemgroups'                             = 'Get-UserTraverseSystemGroup';
            'POST_workdays-workday_id-auth'                              = 'Authorize-Workday';
            'POST_workdays'                                              = 'Create-Workday';
            'GET_workdays-id'                                            = 'Get-Workday';
            'POST_workdays-workday_id-import'                            = 'Import-Workday';
            'GET_workdays'                                               = 'List-Workday';
            'PUT_workdays-id'                                            = 'Set-Workday';
            'DELETE_workdays-workday_id-auth'                            = 'Delete-WorkdayAuthorization';
            'GET_workdays-id-import-job_id-results'                      = 'Import-WorkdayResult';
            'GET_workdays-workday_id-workers'                            = 'Get-WorkdayWorker';
        };
        ExcludedList       = @('/applications/{application_id}', '/applications/{application_id}/logo', '/logos/{id}')
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
            If ($InputObjectName -like '*.get.parameters')
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
                            Write-Host ("##vso[task.logissue type=error;]In '$($CurrentSDKName)' unknown operationId '$($ThisObject.operationId)'.")
                        }
                    }
                    # Remove non 2XX response so that autorest returns correct errors to PowerShell
                    If ($AttributePath -like '.paths.*.responses.*' -and $AttributePath -notlike '.paths.*.responses.2*')
                    {
                        $ThisObject.PSObject.Properties.Remove($AttributeName)
                    }
                    # Remove blank values from enum
                    If ($AttributePath -like '*.enum')
                    {
                        If ($ThisObject.enum -contains '') { $ThisObject.enum = $ThisObject.enum | Where-Object { $_ } } # error CS1519: Invalid token '=' in class, struct, or interface member declaration # FATAL: Error: Name is empty!
                    }
                    # Append "x-ms-enum" to "enum" section
                    If ($AttributePath -like '.paths.*.parameters.enum' -or $AttributePath -like '.definitions.GraphOperation-*.enum')
                    {
                        $xMsEnum = [PSCustomObject]@{
                            name = $ThisObjectName
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
                    # Remove tags
                    If ($AttributePath -like '*.tags')
                    {
                        $ThisObject.PSObject.Properties.Remove('tags')
                    }
                    # Remove tagnames
                    If ($AttributePath -like '*.tagnames')
                    {
                        $ThisObject.PSObject.Properties.Remove('tagnames')
                    }
                    # If ($AttributePath -like '*.enum')
                    # {
                    #     $ThisObject.PSObject.Properties.Remove('enum')
                    # }
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
        # Get OAS content
        $OASContent = If ($Config.Url -like '*api.github.com*' -and -not [System.String]::IsNullOrEmpty($GitHubAccessToken))
        {
            $GitHubHeaders = @{
                'Authorization' = "token $GitHubAccessToken";
                'Accept'        = 'application/vnd.github.v3.raw';
            }
            Invoke-RestMethod -Method:('GET') -Uri:($Config.Url) -Headers:($GitHubHeaders)
        }
        ElseIf ($Config.Url -like '*https*')
        {
            (Invoke-WebRequest -Uri:($Config.Url)).Content
        }
        Else
        {
            Get-Content -Path:($Config.Url) -Raw
        }
        If ([System.String]::IsNullOrEmpty($OASContent))
        {
            Write-Host("##vso[task.logissue type=error;]No content was returned from: $($Config.Url)")
        }
        Else
        {
            # Prep json for find and replace by flattening string
            $SwaggerObjectContent = If ($Config.Url -like '*.yaml*')
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
                        Write-Host("##vso[task.logissue type=error;]" + 'Unable to find a match in "' + $CurrentSDKName + '" for : ' + $_.Name)
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
                    Write-Host ("##vso[task.logissue type=error;]In '$($CurrentSDKName)' unable to find operationId '$($_.Key)'.")
                }
            }
            # Validate that all "ExcludedList" in mapping have been removed from spec
            If (-not [System.String]::IsNullOrEmpty($global:ExcludedList))
            {
                $global:ExcludedList | ForEach-Object {
                    Write-Host ("##vso[task.logissue type=error;]In '$($CurrentSDKName)' unable to find ExcludedPath '$($_)'.")
                }
            }
            $global:ExcludedListOrg | ForEach-Object {
                If ($SwaggerString -match """$($_)""" -or $SwaggerString -match [regex]("(""\`$ref"": ""\#\/)(.*?)($($_)"")"))
                {
                    Write-Host ("##vso[task.logissue type=error;]In '$($CurrentSDKName)' the item '$($_)' has not been excluded.")
                }
            }
            # Validate that "tags" have been removed
            $Tags = $SwaggerString | Select-String -Pattern:('"Tags"')
            If ($Tags.Matches.Value)
            {
                Write-Host ("##vso[task.logissue type=error;]In '$($CurrentSDKName)' still has '$($Tags.Matches.Value)' in it.")
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
            Write-Host ("##vso[task.setvariable variable=UpdatedSpec]$UpdatedSpec")
            Return $UpdatedSpec
        }
    }
    Else
    {
        Write-Host("##vso[task.logissue type=error;]Config 'TransformConfig' does not contain an SDK called '$($SDKNameItem)'.")
    }
}