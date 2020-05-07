#
# Module manifest for module 'JumpCloud.SDK.V2'
#
# Generated by: JumpCloud Solutions Architect Team
#
# Generated on: 5/7/2020
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './JumpCloud.SDK.V2.psm1'

# Version number of this module.
ModuleVersion = '0.0.16'

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
FormatsToProcess = './JumpCloud.SDK.V2.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Clear-JcSdkAppleMdmDevice', 'Get-JcSdkActiveDirectory', 
               'Get-JcSdkActiveDirectoryGraphActiveDirectoryAssociation', 
               'Get-JcSdkActiveDirectoryGraphActiveDirectoryTraverseUserGroup', 
               'Get-JcSdkAppleMdm', 'Get-JcSdkAppleMdmCsr', 
               'Get-JcSdkAppleMdmDepKey', 'Get-JcSdkAppleMdmDevice', 
               'Get-JcSdkAppleMdmEnrollmentProfile', 
               'Get-JcSdkApplicationGraphApplicationAssociation', 
               'Get-JcSdkApplicationGraphApplicationTraverseUser', 
               'Get-JcSdkApplicationGraphApplicationTraverseUserGroup', 
               'Get-JcSdkBulkJobRequestBulkUserResult', 
               'Get-JcSdkCommandGraphCommandAssociation', 
               'Get-JcSdkCommandGraphCommandTraverseSystem', 
               'Get-JcSdkCommandGraphCommandTraverseSystemGroup', 
               'Get-JcSdkDirectory', 'Get-JcSdkDuoAccount', 
               'Get-JcSdkDuoApplication', 'Get-JcSdkGroup', 'Get-JcSdkGSuite', 
               'Get-JcSdkGSuiteGraphGSuiteAssociation', 
               'Get-JcSdkGSuiteGraphGSuiteTraverseUser', 
               'Get-JcSdkGSuiteGraphGSuiteTraverseUserGroup', 
               'Get-JcSdkGSuiteTranslationRule', 'Get-JcSdkLdapServer', 
               'Get-JcSdkLdapServerGraphLdapServerAssociation', 
               'Get-JcSdkLdapServerGraphLdapServerTraverseUser', 
               'Get-JcSdkLdapServerGraphLdapServerTraverseUserGroup', 
               'Get-JcSdkOffice365', 'Get-JcSdkOffice365GraphOffice365Association', 
               'Get-JcSdkOffice365GraphOffice365TraverseUser', 
               'Get-JcSdkOffice365GraphOffice365TraverseUserGroup', 
               'Get-JcSdkOffice365TranslationRule', 'Get-JcSdkPolicy', 
               'Get-JcSdkPolicyGraphPolicyAssociation', 
               'Get-JcSdkPolicyGraphPolicyStatus', 
               'Get-JcSdkPolicyGraphPolicyTraverseSystem', 
               'Get-JcSdkPolicyGraphPolicyTraverseSystemGroup', 
               'Get-JcSdkPolicyResult', 'Get-JcSdkPolicyStatus', 
               'Get-JcSdkPolicyTemplate', 'Get-JcSdkProviderAdministrator', 
               'Get-JcSdkRadiusServerGraphRadiusServerAssociation', 
               'Get-JcSdkRadiusServerGraphRadiusServerTraverseUser', 
               'Get-JcSdkRadiusServerGraphRadiusServerTraverseUserGroup', 
               'Get-JcSdkSambaDomainLdapServerSambaDomain', 
               'Get-JcSdkSystemFdeKey', 'Get-JcSdkSystemGraphSystemAssociation', 
               'Get-JcSdkSystemGraphSystemMember', 
               'Get-JcSdkSystemGraphSystemTraverseCommand', 
               'Get-JcSdkSystemGraphSystemTraversePolicy', 
               'Get-JcSdkSystemGraphSystemTraverseUser', 
               'Get-JcSdkSystemGraphSystemTraverseUserGroup', 
               'Get-JcSdkSystemGroup', 
               'Get-JcSdkSystemGroupAssociationGraphSystemGroupTraverseCommand', 
               'Get-JcSdkSystemGroupAssociationSystemGroupGraphSystemGroupAssociation', 
               'Get-JcSdkSystemGroupAssociationSystemGroupGraphSystemGroupTraversePolicy', 
               'Get-JcSdkSystemGroupAssociationSystemGroupGraphSystemGroupTraverseUser', 
               'Get-JcSdkSystemGroupAssociationSystemGroupGraphSystemGroupTraverseUserGroup', 
               'Get-JcSdkSystemGroupMemberMembershipSystemGroupGraphSystemGroupMember', 
               'Get-JcSdkSystemGroupMemberMembershipSystemGroupGraphSystemGroupMembership', 
               'Get-JcSdkSystemInsightAlf', 'Get-JcSdkSystemInsightApp', 
               'Get-JcSdkSystemInsightBattery', 
               'Get-JcSdkSystemInsightBitlockerInfo', 
               'Get-JcSdkSystemInsightBrowserPlugin', 
               'Get-JcSdkSystemInsightCertificate', 
               'Get-JcSdkSystemInsightChromeExtension', 
               'Get-JcSdkSystemInsightCrash', 
               'Get-JcSdkSystemInsightCupDestination', 
               'Get-JcSdkSystemInsightDiskEncryption', 
               'Get-JcSdkSystemInsightDiskInfo', 'Get-JcSdkSystemInsightEtcHost', 
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
               'Get-JcSdkSystemInsightRegistry', 
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
               'Get-JcSdkSystemInsightWindowCrash', 
               'Get-JcSdkUserGraphUserAssociation', 'Get-JcSdkUserGraphUserMember', 
               'Get-JcSdkUserGraphUserTraverseApplication', 
               'Get-JcSdkUserGraphUserTraverseDirectory', 
               'Get-JcSdkUserGraphUserTraverseGSuite', 
               'Get-JcSdkUserGraphUserTraverseLdapServer', 
               'Get-JcSdkUserGraphUserTraverseOffice365', 
               'Get-JcSdkUserGraphUserTraverseRadiusServer', 
               'Get-JcSdkUserGraphUserTraverseSystem', 
               'Get-JcSdkUserGraphUserTraverseSystemGroup', 'Get-JcSdkUserGroup', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupAssociation', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseApplication', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseDirectory', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseGSuite', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseLdapServer', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseOffice365', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseRadiusServer', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseSystem', 
               'Get-JcSdkUserGroupAssociationUserGroupGraphUserGroupTraverseSystemGroup', 
               'Get-JcSdkUserGroupMemberMembershipUserGroupGraphUserGroupMember', 
               'Get-JcSdkUserGroupMemberMembershipUserGroupGraphUserGroupMembership', 
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
               'Set-JcSdkApplicationGraphApplicationAssociation', 
               'Set-JcSdkCommandGraphCommandAssociation', 
               'Set-JcSdkDuoApplication', 'Set-JcSdkGSuiteGraphGSuiteAssociation', 
               'Set-JcSdkLdapServerGraphLdapServerAssociation', 
               'Set-JcSdkOffice365GraphOffice365Association', 'Set-JcSdkPolicy', 
               'Set-JcSdkPolicyGraphPolicyAssociation', 
               'Set-JcSdkRadiusServerGraphRadiusServerAssociation', 
               'Set-JcSdkSambaDomainLdapServerSambaDomain', 
               'Set-JcSdkSystemGraphSystemAssociation', 'Set-JcSdkSystemGroup', 
               'Set-JcSdkSystemGroupAssociationSystemGroupGraphSystemGroupAssociation', 
               'Set-JcSdkSystemGroupMemberMembershipSystemGroupGraphSystemGroupMember', 
               'Set-JcSdkUserGraphUserAssociation', 'Set-JcSdkUserGroup', 
               'Set-JcSdkUserGroupAssociationUserGroupGraphUserGroupAssociation', 
               'Set-JcSdkUserGroupMemberMembershipUserGroupGraphUserGroupMember', 
               'Set-JcSdkWorkdayImportWorkday', 'Stop-JcSdkAppleMdmDevice', 
               'Update-JcSdkAppleMdmDevice', 'Update-JcSdkBulkJobRequestBulkUser', 
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
        LicenseUri = 'https://github.com/TheJumpCloud/support/blob/master/PowerShell/LICENSE'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/TheJumpCloud/support/wiki/'

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

