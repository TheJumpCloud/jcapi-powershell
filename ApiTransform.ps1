#Requires -Modules powershell-yaml
Param(
    [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, HelpMessage = 'Name of the API to build an SDK for.')][ValidateSet('JumpCloud.SDK.DirectoryInsights', 'JumpCloud.SDK.V1', 'JumpCloud.SDK.V2')][ValidateNotNullOrEmpty()][System.String[]]$SDKName
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub Personal Access Token.')][ValidateNotNullOrEmpty()][System.String]$GitHubAccessToken = $env:GitHubAccessToken
    , [Parameter(Mandatory = $false, ValueFromPipelineByPropertyName = $true, HelpMessage = 'GitHub branch or tag to pull spec from.')][ValidateNotNullOrEmpty()][System.String]$GitHubTag
)
Set-Location $PSScriptRoot
$OutputFilePath = $PSScriptRoot + '/SwaggerSpecs'
# OperationId to Function name mapping - https://github.com/Azure/autorest.powershell/blob/a530bd721c9326a4356fba15638fee236722aca9/powershell/autorest-configuration.md
$TransformConfig = [Ordered]@{
    'JumpCloud.SDK.DirectoryInsights' = [PSCustomObject]@{
        Repo               = "jumpcloud-insights-api"
        Path               = "docs/generated/directory_insights_swagger.json"
        FindAndReplace     = [Ordered]@{
            '"name":".*?","in":"body"'                                                                                                                                                      = '"name":"body","in":"body"' # Across our APIs the standard is using "body" for the name of the body
            '"search_after":{"description":"Specific query to search after, see x-\* response headers for next values","type":"array","items":{"type":"object"},"x-go-name":"SearchAfter"}' = '"search_after":{"description":"Specific query to search after, see x-* response headers for next values","type":"array","items":{"type":"string"},"x-go-name":"SearchAfter"}';
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
            '\["object","null"]'                                                                 = '"object"';
            '\["string","null"]'                                                                 = '"string"';
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
            'commands_getResults'            = 'CommandResult_Get';
            'commands_list'                  = 'Command_List';
            'commands_post'                  = 'Command_Create';
            'commands_put'                   = 'Command_Set';
            'organization_list'              = 'Organization_List';
            'organization_put'               = 'Organization_Set';
            'organizations_get'              = 'Organization_Get';
            'radius_servers_delete'          = 'RadiusServer_Delete';
            'radius_servers_get'             = 'RadiusServer_Get';
            'radius_servers_list'            = 'RadiusServer_List';
            'radius_servers_post'            = 'RadiusServer_Create';
            'radius_servers_put'             = 'RadiusServer_Set';
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
            'systemusers_post'               = 'User_Create';
            'systemusers_put'                = 'User_Set';
            'systemusers_resetmfa'           = 'UserMfa_Reset';
            'systemusers_unlock'             = 'User_Unlock';
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
            'activedirectories_agentsDelete'                    = 'ActiveDirectoryAgent_Delete';
            'activedirectories_agentsGet'                       = 'ActiveDirectoryAgent_Get';
            'activedirectories_agentsList'                      = 'ActiveDirectoryAgent_List';
            'activedirectories_agentsPost'                      = 'ActiveDirectoryAgent_Create';
            'activedirectories_delete'                          = 'ActiveDirectory_Delete';
            'activedirectories_get'                             = 'ActiveDirectory_Get';
            'activedirectories_list'                            = 'ActiveDirectory_List';
            'activedirectories_post'                            = 'ActiveDirectory_Create';
            'applemdms_delete'                                  = 'AppleMDM_Delete';
            'applemdms_devicesClearActivationLock'              = 'AppleMDMDeviceActivationLock_Clear';
            'applemdms_deviceserase'                            = 'AppleMDMDevice_Clear';
            'applemdms_deviceslist'                             = 'AppleMDMDevice_List';
            'applemdms_deviceslock'                             = 'AppleMDMDevice_Lock';
            'applemdms_devicesRefreshActivationLockInformation' = 'AppleMDMDeviceLockInformation_Refresh';
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
            'graph_policyGroupMembership'                       = 'PolicyGroupMembership_Get';
            'graph_policyGroupMembersList'                      = 'PolicyGroupMembers_List';
            'graph_policyGroupMembersPost'                      = 'PolicyGroupMembers_Set';
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
            'graph_systemGroupMembership'                       = 'SystemGroupMembership_Get';
            'graph_systemGroupMembersList'                      = 'SystemGroupMembers_Get';
            'graph_systemGroupMembersPost'                      = 'SystemGroupMembers_Set';
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
            'graph_userGroupMembership'                         = 'UserGroupMembership_Get';
            'graph_userGroupMembersList'                        = 'UserGroupMembers_Get';
            'graph_userGroupMembersPost'                        = 'UserGroupMembers_Set';
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
            'groups_suggestions_get'                            = 'GroupSuggestion_Get';
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
            'gsuites_patch'                                     = 'GSuite_Update';
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
            'providers_postAdmins'                              = 'ProviderAdministrator_Create';
            'softwareApps_delete'                               = 'SoftwareApp_Delete';
            'softwareApps_get'                                  = 'SoftwareApp_Get';
            'softwareApps_list'                                 = 'SoftwareApp_List';
            'softwareApps_post'                                 = 'SoftwareApp_Create';
            'softwareApps_reclaimLicenses'                      = 'SoftwareAppsLicenses_Reclaim';
            'softwareApps_update'                               = 'SoftwareApp_Set';
            'softwareAppStatuses_list'                          = 'SoftwareAppStatus_Get';
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
            'systeminsights_list_windows_security_products'     = 'SystemInsightWindowSecurityProduct_List';
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
                        # Determine unique xMsEnum name
                        $xMsEnumNameProperty = If ($ThisObject.name) { $ThisObject.name }
                        $xMsEnumModelName = If ($AttributePath -match [regex]'\.definitions\.(.*?)\.allOf\.properties\.type\.enum') { $matches[1] }
                        ElseIf ($AttributePath -match [regex]'\.parameters\.trait:(.*?)\.items\.enum') { $matches[1].Replace(':', '-') }
                        ElseIf ($AttributePath -match [regex]'\.parameters\.trait:(.*?)\.enum') { $matches[1].Replace(':', '-') }
                        # Else { $ThisObjectName }
                        $xMsEnumName = If (-not [System.String]::IsNullOrEmpty($xMsEnumNameProperty) -and -not [System.String]::IsNullOrEmpty($xMsEnumModelName))
                        {
                            "$($xMsEnumModelName.Replace($xMsEnumNameProperty,''))$((Get-Culture).TextInfo.ToTitleCase($xMsEnumNameProperty))"
                        }
                        ElseIf (-not [System.String]::IsNullOrEmpty($xMsEnumNameProperty) -and [System.String]::IsNullOrEmpty($xMsEnumModelName))
                        {
                            "$($xMsEnumNameProperty)"
                        }
                        ElseIf ([System.String]::IsNullOrEmpty($xMsEnumNameProperty) -and -not [System.String]::IsNullOrEmpty($xMsEnumModelName))
                        {
                            "$($xMsEnumModelName)"
                        }
                        Else
                        {
                            Write-Error ("Unable to determine enum name: $($AttributePath)  $($ThisObject.name)")
                        }
                        $xMsEnum = [PSCustomObject]@{
                            name = $xMsEnumName
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
                    # If ($AttributePath -like '*.enum') { $ThisObject.PSObject.Properties.Remove($AttributeName) }
                    If ($ThisObject.$AttributeName)
                    {
                        $ModifiedObject = Update-SwaggerObject -InputObject:($ThisObject.$AttributeName) -InputObjectName:($AttributePath) -NoUpdate:($NoUpdate) -InputObjectOrg:($InputObjectOrg)
                        # If it was an array of objects before reapply the parent array.
                        If (($ThisObject.$AttributeName.GetType()).FullName -eq 'System.Object[]')
                        {
                            $ModifiedObject = @($ModifiedObject)
                        }
                        $ThisObject.$AttributeName = $ModifiedObject
                    }
                }
                Else
                {
                    If ($ThisObject.$AttributeName)
                    {
                        $ModifiedObject = Update-SwaggerObject -InputObject:($ThisObject.$AttributeName) -InputObjectName:($AttributePath) -NoUpdate:($NoUpdate) -InputObjectOrg:($InputObjectOrg)
                        # If it was an array of objects before reapply the parent array.
                        If (($ThisObject.$AttributeName.GetType()).FullName -eq 'System.Object[]')
                        {
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
        $GitHubLatestReleaseTag = If (-not [System.String]::IsNullOrEmpty($GitHubAccessToken) -and [System.String]::IsNullOrEmpty($GitHubTag))
        {
            (Invoke-RestMethod -Method:('GET') -Uri:($LatestReleaseUrl) -Headers:($GitHubHeaders)).tag_name
        }
        Else
        {
            'master'
        }
        Write-Host ("Repo: $($Config.Repo); Path: $($Config.Path); Latest Release Tag: $($GitHubLatestReleaseTag);")
        # Get OAS content
        $SwaggerUrl = '{0}/contents/{1}?ref={2}' -f $RepoUrl, $Config.Path, $GitHubLatestReleaseTag
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
            # Add GitHubTag to spec
            Add-Member -InputObject:($SwaggerObject.info) -MemberType:('NoteProperty') -Name:('x-releaseTag') -Value:($GitHubLatestReleaseTag) -Force
            If (-not $SwaggerObject.info.'x-releaseTag')
            {
                $SwaggerObject.info.Add('x-releaseTag', $GitHubLatestReleaseTag)
            }
            $UpdatedSwagger = Update-SwaggerObject -InputObject:($SwaggerObject) -InputObjectOrg:($SwaggerObject)
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
    }
    Else
    {
        Write-Error ("Config 'TransformConfig' does not contain an SDK called '$($SDKNameItem)'.")
    }
}
