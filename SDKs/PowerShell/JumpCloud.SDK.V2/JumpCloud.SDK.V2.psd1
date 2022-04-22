#
# Module manifest for module 'JumpCloud.SDK.V2'
#
# Generated by: JumpCloud
#
# Generated on: 4/22/2022
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './JumpCloud.SDK.V2.psm1'

# Version number of this module.
ModuleVersion = '0.0.32'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'ff397964-2121-4c89-a916-34b5c30d7187'

# Author of this module
Author = 'JumpCloud'

# Company or vendor of this module
CompanyName = 'JumpCloud'

# Copyright statement for this module
Copyright = '(c) JumpCloud. All rights reserved.'

# Description of the functionality provided by this module
Description = 'The JumpCloud V2 PowerShell SDK'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = './bin/JumpCloud.SDK.V2.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Clear-JcSdkAppleMdmDevice', 
               'Clear-JcSdkAppleMdmDeviceActivationLock', 
               'Get-JcSdkActiveDirectory', 'Get-JcSdkActiveDirectoryAgent', 
               'Get-JcSdkActiveDirectoryAssociation', 
               'Get-JcSdkActiveDirectoryTraverseUser', 
               'Get-JcSdkActiveDirectoryTraverseUserGroup', 
               'Get-JcSdkAdministratorOrganization', 
               'Get-JcSdkAdministratorOrganizationLink', 'Get-JcSdkAppleMdm', 
               'Get-JcSdkAppleMdmDevice', 'Get-JcSdkAppleMdmEnrollmentProfile', 
               'Get-JcSdkApplicationAssociation', 
               'Get-JcSdkApplicationTraverseUser', 
               'Get-JcSdkApplicationTraverseUserGroup', 
               'Get-JcSdkAuthenticationPolicy', 'Get-JcSdkBulkUsersResult', 
               'Get-JcSdkBulkUserState', 'Get-JcSdkCommandAssociation', 
               'Get-JcSdkCommandTraverseSystem', 
               'Get-JcSdkCommandTraverseSystemGroup', 
               'Get-JcSdkCustomEmailConfiguration', 'Get-JcSdkCustomEmailTemplate', 
               'Get-JcSdkDirectory', 'Get-JcSdkDuoAccount', 
               'Get-JcSdkDuoApplication', 'Get-JcSdkGroup', 
               'Get-JcSdkGroupSuggestion', 'Get-JcSdkGSuite', 
               'Get-JcSdkGSuiteAssociation', 'Get-JcSdkGSuiteTranslationRule', 
               'Get-JcSdkGSuiteTraverseUser', 'Get-JcSdkGSuiteTraverseUserGroup', 
               'Get-JcSdkGSuiteUsersToImport', 'Get-JcSdkIPList', 
               'Get-JcSdkLdapServer', 'Get-JcSdkLdapServerAssociation', 
               'Get-JcSdkLdapServerSambaDomain', 'Get-JcSdkLdapServerTraverseUser', 
               'Get-JcSdkLdapServerTraverseUserGroup', 
               'Get-JcSdkNextScheduledBulkUserState', 'Get-JcSdkOffice365', 
               'Get-JcSdkOffice365Association', 
               'Get-JcSdkOffice365TranslationRule', 
               'Get-JcSdkOffice365TraverseUser', 
               'Get-JcSdkOffice365TraverseUserGroup', 
               'Get-JcSdkOffice365UsersToImport', 
               'Get-JcSdkOrganizationPolicyResult', 'Get-JcSdkPolicy', 
               'Get-JcSdkPolicyAssociation', 'Get-JcSdkPolicyGroup', 
               'Get-JcSdkPolicyGroupAssociation', 'Get-JcSdkPolicyGroupMember', 
               'Get-JcSdkPolicyGroupMembership', 
               'Get-JcSdkPolicyGroupTraverseSystem', 
               'Get-JcSdkPolicyGroupTraverseSystemGroup', 'Get-JcSdkPolicyResult', 
               'Get-JcSdkPolicyStatus', 'Get-JcSdkPolicyTemplate', 
               'Get-JcSdkPolicyTraverseSystem', 
               'Get-JcSdkPolicyTraverseSystemGroup', 
               'Get-JcSdkProviderAdministrator', 'Get-JcSdkProviderOrganization', 
               'Get-JcSdkProvidersInvoice', 'Get-JcSdkRadiusServerAssociation', 
               'Get-JcSdkRadiusServerTraverseUser', 
               'Get-JcSdkRadiusServerTraverseUserGroup', 'Get-JcSdkSoftwareApp', 
               'Get-JcSdkSoftwareAppAssociation', 'Get-JcSdkSoftwareAppStatus', 
               'Get-JcSdkSoftwareAppTraverseSystem', 
               'Get-JcSdkSoftwareAppTraverseSystemGroup', 'Get-JcSdkSubscription', 
               'Get-JcSdkSystemAssociation', 'Get-JcSdkSystemFdeKey', 
               'Get-JcSdkSystemGroup', 'Get-JcSdkSystemGroupAssociation', 
               'Get-JcSdkSystemGroupMember', 'Get-JcSdkSystemGroupMembership', 
               'Get-JcSdkSystemGroupTraverseCommand', 
               'Get-JcSdkSystemGroupTraversePolicy', 
               'Get-JcSdkSystemGroupTraversePolicyGroup', 
               'Get-JcSdkSystemGroupTraverseUser', 
               'Get-JcSdkSystemGroupTraverseUserGroup', 
               'Get-JcSdkSystemInsightAlf', 'Get-JcSdkSystemInsightAlfException', 
               'Get-JcSdkSystemInsightAlfExplicitAuth', 
               'Get-JcSdkSystemInsightApp', 'Get-JcSdkSystemInsightAppCompatShim', 
               'Get-JcSdkSystemInsightAuthorizedKey', 
               'Get-JcSdkSystemInsightBattery', 
               'Get-JcSdkSystemInsightBitlockerInfo', 
               'Get-JcSdkSystemInsightBrowserPlugin', 
               'Get-JcSdkSystemInsightCertificate', 
               'Get-JcSdkSystemInsightChromeExtension', 
               'Get-JcSdkSystemInsightConnectivity', 'Get-JcSdkSystemInsightCrash', 
               'Get-JcSdkSystemInsightCupDestination', 
               'Get-JcSdkSystemInsightDiskEncryption', 
               'Get-JcSdkSystemInsightDiskInfo', 
               'Get-JcSdkSystemInsightDnsResolver', 
               'Get-JcSdkSystemInsightEtcHost', 
               'Get-JcSdkSystemInsightFirefoxAddon', 'Get-JcSdkSystemInsightGroup', 
               'Get-JcSdkSystemInsightIeExtension', 
               'Get-JcSdkSystemInsightInterfaceAddress', 
               'Get-JcSdkSystemInsightInterfaceDetail', 
               'Get-JcSdkSystemInsightKernelInfo', 'Get-JcSdkSystemInsightLaunchd', 
               'Get-JcSdkSystemInsightLoggedinUser', 
               'Get-JcSdkSystemInsightLogicalDrive', 
               'Get-JcSdkSystemInsightManagedPolicy', 
               'Get-JcSdkSystemInsightMount', 'Get-JcSdkSystemInsightOSVersion', 
               'Get-JcSdkSystemInsightPatch', 'Get-JcSdkSystemInsightProgram', 
               'Get-JcSdkSystemInsightPythonPackage', 
               'Get-JcSdkSystemInsightSafariExtension', 
               'Get-JcSdkSystemInsightScheduledTask', 
               'Get-JcSdkSystemInsightService', 'Get-JcSdkSystemInsightShadow', 
               'Get-JcSdkSystemInsightSharedFolder', 
               'Get-JcSdkSystemInsightSharedResource', 
               'Get-JcSdkSystemInsightSharingPreference', 
               'Get-JcSdkSystemInsightSipConfig', 
               'Get-JcSdkSystemInsightStartupItem', 
               'Get-JcSdkSystemInsightSystemControl', 
               'Get-JcSdkSystemInsightSystemInfo', 'Get-JcSdkSystemInsightUptime', 
               'Get-JcSdkSystemInsightUsbDevice', 'Get-JcSdkSystemInsightUser', 
               'Get-JcSdkSystemInsightUserGroup', 
               'Get-JcSdkSystemInsightUserSshKey', 
               'Get-JcSdkSystemInsightWifiNetwork', 
               'Get-JcSdkSystemInsightWifiStatus', 
               'Get-JcSdkSystemInsightWindowSecurityProduct', 
               'Get-JcSdkSystemMember', 'Get-JcSdkSystemPolicyStatus', 
               'Get-JcSdkSystemTraverseCommand', 'Get-JcSdkSystemTraversePolicy', 
               'Get-JcSdkSystemTraversePolicyGroup', 'Get-JcSdkSystemTraverseUser', 
               'Get-JcSdkSystemTraverseUserGroup', 'Get-JcSdkUserAssociation', 
               'Get-JcSdkUserGroup', 'Get-JcSdkUserGroupAssociation', 
               'Get-JcSdkUserGroupMember', 'Get-JcSdkUserGroupMembership', 
               'Get-JcSdkUserGroupTraverseActiveDirectory', 
               'Get-JcSdkUserGroupTraverseApplication', 
               'Get-JcSdkUserGroupTraverseDirectory', 
               'Get-JcSdkUserGroupTraverseGSuite', 
               'Get-JcSdkUserGroupTraverseLdapServer', 
               'Get-JcSdkUserGroupTraverseOffice365', 
               'Get-JcSdkUserGroupTraverseRadiusServer', 
               'Get-JcSdkUserGroupTraverseSystem', 
               'Get-JcSdkUserGroupTraverseSystemGroup', 'Get-JcSdkUserMember', 
               'Get-JcSdkUserPushEndpoint', 'Get-JcSdkUserTraverseActiveDirectory', 
               'Get-JcSdkUserTraverseApplication', 
               'Get-JcSdkUserTraverseDirectory', 'Get-JcSdkUserTraverseGSuite', 
               'Get-JcSdkUserTraverseLdapServer', 'Get-JcSdkUserTraverseOffice365', 
               'Get-JcSdkUserTraverseRadiusServer', 'Get-JcSdkUserTraverseSystem', 
               'Get-JcSdkUserTraverseSystemGroup', 'Get-JcSdkWorkday', 
               'Get-JcSdkWorkdayWorker', 'Grant-JcSdkWorkday', 'Import-JcSdkWorkday', 
               'Import-JcSdkWorkdayResult', 
               'Invoke-JcSdkReclaimSoftwareAppLicense', 'Lock-JcSdkAppleMdmDevice', 
               'New-JcSdkActiveDirectory', 'New-JcSdkActiveDirectoryAgent', 
               'New-JcSdkAdministratorOrganization', 
               'New-JcSdkAuthenticationPolicy', 'New-JcSdkBulkUser', 
               'New-JcSdkBulkUserState', 'New-JcSdkCustomEmailConfiguration', 
               'New-JcSdkDuoAccount', 'New-JcSdkDuoApplication', 
               'New-JcSdkGSuiteTranslationRule', 'New-JcSdkIPList', 
               'New-JcSdkLdapServerSambaDomain', 
               'New-JcSdkOffice365TranslationRule', 'New-JcSdkPolicy', 
               'New-JcSdkPolicyGroup', 'New-JcSdkProviderAdministrator', 
               'New-JcSdkSoftwareApp', 'New-JcSdkSystemGroup', 'New-JcSdkUserGroup', 
               'New-JcSdkWorkday', 'Remove-JcSdkActiveDirectory', 
               'Remove-JcSdkActiveDirectoryAgent', 
               'Remove-JcSdkAdministratorOrganization', 'Remove-JcSdkAppleMdm', 
               'Remove-JcSdkAppleMdmDevice', 'Remove-JcSdkApplicationLogo', 
               'Remove-JcSdkAuthenticationPolicy', 'Remove-JcSdkBulkUserState', 
               'Remove-JcSdkCustomEmailConfiguration', 'Remove-JcSdkDuoAccount', 
               'Remove-JcSdkDuoApplication', 'Remove-JcSdkGSuiteTranslationRule', 
               'Remove-JcSdkIPList', 'Remove-JcSdkLdapServerSambaDomain', 
               'Remove-JcSdkOffice365TranslationRule', 'Remove-JcSdkPolicy', 
               'Remove-JcSdkPolicyGroup', 'Remove-JcSdkProviderAdministrator', 
               'Remove-JcSdkSoftwareApp', 'Remove-JcSdkSystemGroup', 
               'Remove-JcSdkUserGroup', 'Remove-JcSdkUserPushEndpoint', 
               'Remove-JcSdkWorkdayAuthorization', 'Restart-JcSdkAppleMdmDevice', 
               'Set-JcSdkActiveDirectoryAssociation', 'Set-JcSdkAppleMdm', 
               'Set-JcSdkApplicationAssociation', 'Set-JcSdkCommandAssociation', 
               'Set-JcSdkCustomEmailConfiguration', 'Set-JcSdkDuoApplication', 
               'Set-JcSdkGSuiteAssociation', 'Set-JcSdkIPList', 
               'Set-JcSdkLdapServerAssociation', 'Set-JcSdkLdapServerSambaDomain', 
               'Set-JcSdkOffice365Association', 'Set-JcSdkPolicy', 
               'Set-JcSdkPolicyAssociation', 'Set-JcSdkPolicyGroup', 
               'Set-JcSdkPolicyGroupAssociation', 'Set-JcSdkPolicyGroupMember', 
               'Set-JcSdkRadiusServerAssociation', 'Set-JcSdkSoftwareApp', 
               'Set-JcSdkSoftwareAppAssociation', 'Set-JcSdkSystemAssociation', 
               'Set-JcSdkSystemGroup', 'Set-JcSdkSystemGroupAssociation', 
               'Set-JcSdkSystemGroupMember', 'Set-JcSdkUserAssociation', 
               'Set-JcSdkUserGroup', 'Set-JcSdkUserGroupAssociation', 
               'Set-JcSdkUserGroupMember', 'Set-JcSdkWorkday', 
               'Stop-JcSdkAppleMdmDevice', 'Sync-JcSdkAppleMdmDevice', 
               'Update-JcSdkAppleMdmDeviceLockInformation', 
               'Update-JcSdkAuthenticationPolicy', 'Update-JcSdkBulkUser', 
               'Update-JcSdkGSuite', 'Update-JcSdkIPList', 'Update-JcSdkLdapServer', 
               'Update-JcSdkOffice365', 'Update-JcSdkUserPushEndpoint'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = '*'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'JumpCloud,','DaaS,','Jump,','Cloud,','Directory'

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/TheJumpCloud/jcapi-powershell/tree/master/LICENSE'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

