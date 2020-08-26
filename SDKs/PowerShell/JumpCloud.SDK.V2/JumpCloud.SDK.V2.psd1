#
# Module manifest for module 'JumpCloud.SDK.V2'
#
# Generated by: JumpCloud Solutions Architect Team
#
# Generated on: 8/26/2020
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './JumpCloud.SDK.V2.psm1'

# Version number of this module.
ModuleVersion = '0.0.23'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'ff397964-2121-4c89-a916-34b5c30d7187'

# Author of this module
Author = 'JumpCloud Solutions Architect Team'

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
# FormatsToProcess = './JumpCloud.SDK.V2.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Clear-JcSdkAppleMdmDevice', 'Get-JcSdkActiveDirectory', 
               'Get-JcSdkAppleMdm', 'Get-JcSdkAppleMdmCsr', 
               'Get-JcSdkAppleMdmDepKey', 'Get-JcSdkAppleMdmDevice', 
               'Get-JcSdkAppleMdmEnrollmentProfile', 
               'Get-JcSdkBulkJobRequestBulkUserResult', 'Get-JcSdkDirectory', 
               'Get-JcSdkDuoAccount', 'Get-JcSdkDuoApplication', 
               'Get-JcSdkFdeSystemFdeKey', 
               'Get-JcSdkGraphActiveDirectoryAssociation', 
               'Get-JcSdkGraphActiveDirectoryTraverseUserGroup', 
               'Get-JcSdkGraphApplicationAssociation', 
               'Get-JcSdkGraphApplicationTraverseUser', 
               'Get-JcSdkGraphApplicationTraverseUserGroup', 
               'Get-JcSdkGraphCommandAssociation', 
               'Get-JcSdkGraphCommandTraverseSystem', 
               'Get-JcSdkGraphCommandTraverseSystemGroup', 
               'Get-JcSdkGraphGSuiteAssociation', 
               'Get-JcSdkGraphGSuiteTraverseUser', 
               'Get-JcSdkGraphGSuiteTraverseUserGroup', 
               'Get-JcSdkGraphLdapServerAssociation', 
               'Get-JcSdkGraphLdapServerTraverseUser', 
               'Get-JcSdkGraphLdapServerTraverseUserGroup', 
               'Get-JcSdkGraphOffice365Association', 
               'Get-JcSdkGraphOffice365TraverseUser', 
               'Get-JcSdkGraphOffice365TraverseUserGroup', 
               'Get-JcSdkGraphPolicyAssociation', 'Get-JcSdkGraphPolicyStatus', 
               'Get-JcSdkGraphPolicyTraverseSystem', 
               'Get-JcSdkGraphPolicyTraverseSystemGroup', 
               'Get-JcSdkGraphRadiusServerAssociation', 
               'Get-JcSdkGraphRadiusServerTraverseUser', 
               'Get-JcSdkGraphRadiusServerTraverseUserGroup', 
               'Get-JcSdkGraphSystemAssociation', 
               'Get-JcSdkGraphSystemGroupAssociationSystemGroupAssociation', 
               'Get-JcSdkGraphSystemGroupAssociationSystemGroupTraverseCommand', 
               'Get-JcSdkGraphSystemGroupAssociationSystemGroupTraversePolicy', 
               'Get-JcSdkGraphSystemGroupAssociationSystemGroupTraverseUser', 
               'Get-JcSdkGraphSystemGroupAssociationSystemGroupTraverseUserGroup', 
               'Get-JcSdkGraphSystemGroupMemberMembershipSystemGroupMember', 
               'Get-JcSdkGraphSystemGroupMemberMembershipSystemGroupMembership', 
               'Get-JcSdkGraphSystemMember', 'Get-JcSdkGraphSystemTraverseCommand', 
               'Get-JcSdkGraphSystemTraversePolicy', 
               'Get-JcSdkGraphSystemTraverseUser', 
               'Get-JcSdkGraphSystemTraverseUserGroup', 
               'Get-JcSdkGraphUserAssociation', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupAssociation', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseApplication', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseDirectory', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseGSuite', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseLdapServer', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseOffice365', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseRadiusServer', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseSystem', 
               'Get-JcSdkGraphUserGroupAssociationUserGroupTraverseSystemGroup', 
               'Get-JcSdkGraphUserGroupMemberMembershipUserGroupMember', 
               'Get-JcSdkGraphUserGroupMemberMembershipUserGroupMembership', 
               'Get-JcSdkGraphUserMember', 'Get-JcSdkGraphUserTraverseApplication', 
               'Get-JcSdkGraphUserTraverseDirectory', 
               'Get-JcSdkGraphUserTraverseGSuite', 
               'Get-JcSdkGraphUserTraverseLdapServer', 
               'Get-JcSdkGraphUserTraverseOffice365', 
               'Get-JcSdkGraphUserTraverseRadiusServer', 
               'Get-JcSdkGraphUserTraverseSystem', 
               'Get-JcSdkGraphUserTraverseSystemGroup', 'Get-JcSdkGroup', 
               'Get-JcSdkGSuite', 'Get-JcSdkGSuiteTranslationRule', 
               'Get-JcSdkLdapServer', 'Get-JcSdkOffice365', 
               'Get-JcSdkOffice365TranslationRule', 'Get-JcSdkPolicy', 
               'Get-JcSdkPolicyResult', 'Get-JcSdkPolicyStatus', 
               'Get-JcSdkPolicytemplatePolicyTemplate', 
               'Get-JcSdkProviderAdministrator', 
               'Get-JcSdkSambaDomainLdapServerSambaDomain', 'Get-JcSdkSystemGroup', 
               'Get-JcSdkSystemGroupSystemInsightAlfExplicitAuth', 
               'Get-JcSdkSystemGroupSystemInsightAppCompatShim', 
               'Get-JcSdkSystemInsightAlf', 'Get-JcSdkSystemInsightAlfException', 
               'Get-JcSdkSystemInsightApp', 'Get-JcSdkSystemInsightAuthorizedKey', 
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
               'Get-JcSdkSystemInsightLogged', 
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
               'Get-JcSdkSystemInsightWindowSecurityProduct', 'Get-JcSdkUserGroup', 
               'Get-JcSdkWorkdayImportWorkday', 
               'Get-JcSdkWorkdayImportWorkdayWorker', 
               'Grant-JcSdkWorkdayImportWorkday', 
               'Import-JcSdkWorkdayImportWorkday', 
               'Import-JcSdkWorkdayImportWorkdayResult', 
               'Lock-JcSdkAppleMdmDevice', 'New-JcSdkBulkJobRequestBulkUser', 
               'New-JcSdkDuoAccount', 'New-JcSdkDuoApplication', 
               'New-JcSdkGSuiteTranslationRule', 
               'New-JcSdkOffice365TranslationRule', 'New-JcSdkPolicy', 
               'New-JcSdkProviderAdmin', 
               'New-JcSdkSambaDomainLdapServerSambaDomain', 'New-JcSdkSystemGroup', 
               'New-JcSdkUserGroup', 'New-JcSdkWorkdayImportWorkday', 
               'Remove-JcSdkAppleMdm', 'Remove-JcSdkDuoAccount', 
               'Remove-JcSdkDuoApplication', 'Remove-JcSdkGSuiteTranslationRule', 
               'Remove-JcSdkOffice365TranslationRule', 'Remove-JcSdkPolicy', 
               'Remove-JcSdkSambaDomainLdapServerSambaDomain', 
               'Remove-JcSdkSystemGroup', 'Remove-JcSdkUserGroup', 
               'Remove-JcSdkWorkdayImportWorkdayAuthorization', 
               'Restart-JcSdkAppleMdmDevice', 'Set-JcSdkAppleMdm', 
               'Set-JcSdkDuoApplication', 'Set-JcSdkGraphApplicationAssociation', 
               'Set-JcSdkGraphCommandAssociation', 
               'Set-JcSdkGraphGSuiteAssociation', 
               'Set-JcSdkGraphLdapServerAssociation', 
               'Set-JcSdkGraphOffice365Association', 
               'Set-JcSdkGraphPolicyAssociation', 
               'Set-JcSdkGraphRadiusServerAssociation', 
               'Set-JcSdkGraphSystemAssociation', 
               'Set-JcSdkGraphSystemGroupAssociationSystemGroupAssociation', 
               'Set-JcSdkGraphSystemGroupMemberMembershipSystemGroupMember', 
               'Set-JcSdkGraphUserAssociation', 
               'Set-JcSdkGraphUserGroupAssociationUserGroupAssociation', 
               'Set-JcSdkGraphUserGroupMemberMembershipUserGroupMember', 
               'Set-JcSdkPolicy', 'Set-JcSdkSambaDomainLdapServerSambaDomain', 
               'Set-JcSdkSystemGroup', 'Set-JcSdkUserGroup', 
               'Set-JcSdkWorkdayImportWorkday', 'Stop-JcSdkAppleMdmDevice', 
               'Sync-JcSdkAppleMdmDevice', 'Update-JcSdkBulkJobRequestBulkUser', 
               'Update-JcSdkGSuite', 'Update-JcSdkLdapServer', 
               'Update-JcSdkOffice365'

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
        LicenseUri = 'https://github.com/TheJumpCloud/jcapi-powershell/blob/master/LICENSE'

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


