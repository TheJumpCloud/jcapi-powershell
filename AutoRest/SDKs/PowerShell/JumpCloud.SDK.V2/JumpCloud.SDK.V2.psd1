<<<<<<< HEAD
@{
  GUID = '94bcf7d0-4c14-4182-a387-5803b44d1d7e'
  RootModule = './JumpCloud.SDK.V2.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'JumpCloud Solutions Architect Team'
  CompanyName = 'JumpCloud'
  Copyright = '(c) JumpCloud. All rights reserved.'
  Description = 'The JumpCloud V2 PowerShell SDK'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/JumpCloud.SDK.V2.private.dll'
  FormatsToProcess = './JumpCloud.SDK.V2.format.ps1xml'
  FunctionsToExport = 'Clear-JCAppleMdmDevice', 'Get-JCActiveDirectory', 'Get-JCActiveDirectoryGraphActiveDirectoryAssociation', 'Get-JCActiveDirectoryGraphActiveDirectoryTraverseUserGroup', 'Get-JCAppleMdm', 'Get-JCAppleMdmCsr', 'Get-JCAppleMdmDepKey', 'Get-JCAppleMdmDevice', 'Get-JCAppleMdmEnrollmentProfile', 'Get-JCApplicationGraphApplicationAssociation', 'Get-JCApplicationGraphApplicationTraverseUser', 'Get-JCApplicationGraphApplicationTraverseUserGroup', 'Get-JCBulkJobRequestBulkUserResult', 'Get-JCCommandGraphCommandAssociation', 'Get-JCCommandGraphCommandTraverseSystem', 'Get-JCCommandGraphCommandTraverseSystemGroup', 'Get-JCDirectory', 'Get-JCDuoAccount', 'Get-JCDuoApplication', 'Get-JCGroup', 'Get-JCGSuite', 'Get-JCGSuiteGraphGSuiteAssociation', 'Get-JCGSuiteGraphGSuiteTraverseUser', 'Get-JCGSuiteGraphGSuiteTraverseUserGroup', 'Get-JCGSuiteTranslationRule', 'Get-JCLdapServer', 'Get-JCLdapServerGraphLdapServerAssociation', 'Get-JCLdapServerGraphLdapServerTraverseUser', 'Get-JCLdapServerGraphLdapServerTraverseUserGroup', 'Get-JCOffice365', 'Get-JCOffice365GraphOffice365Association', 'Get-JCOffice365GraphOffice365TraverseUser', 'Get-JCOffice365GraphOffice365TraverseUserGroup', 'Get-JCOffice365TranslationRule', 'Get-JCPolicy', 'Get-JCPolicyGraphPolicyAssociation', 'Get-JCPolicyGraphPolicyStatus', 'Get-JCPolicyGraphPolicyTraverseSystem', 'Get-JCPolicyGraphPolicyTraverseSystemGroup', 'Get-JCPolicyResult', 'Get-JCPolicyStatus', 'Get-JCPolicyTemplate', 'Get-JCProviderAdministrator', 'Get-JCRadiusServerGraphRadiusServerAssociation', 'Get-JCRadiusServerGraphRadiusServerTraverseUser', 'Get-JCRadiusServerGraphRadiusServerTraverseUserGroup', 'Get-JCSambaDomainLdapServerSambaDomain', 'Get-JCSystemFdeKey', 'Get-JCSystemGraphSystemAssociation', 'Get-JCSystemGraphSystemMember', 'Get-JCSystemGraphSystemTraverseCommand', 'Get-JCSystemGraphSystemTraversePolicy', 'Get-JCSystemGraphSystemTraverseUser', 'Get-JCSystemGraphSystemTraverseUserGroup', 'Get-JCSystemGroup', 'Get-JCSystemGroupAssociationGraphSystemGroupTraverseCommand', 'Get-JCSystemGroupAssociationSystemGroupGraphSystemGroupAssociation', 'Get-JCSystemGroupAssociationSystemGroupGraphSystemGroupTraversePolicy', 'Get-JCSystemGroupAssociationSystemGroupGraphSystemGroupTraverseUser', 'Get-JCSystemGroupAssociationSystemGroupGraphSystemGroupTraverseUserGroup', 'Get-JCSystemGroupMemberMembershipSystemGroupGraphSystemGroupMember', 'Get-JCSystemGroupMemberMembershipSystemGroupGraphSystemGroupMembership', 'Get-JCSystemGroupSystemInsightAlfExplicitAuth', 'Get-JCSystemGroupSystemInsightAppCompatShim', 'Get-JCSystemInsightAlf', 'Get-JCSystemInsightAlfException', 'Get-JCSystemInsightApp', 'Get-JCSystemInsightAuthorizedKey', 'Get-JCSystemInsightBattery', 'Get-JCSystemInsightBitlockerInfo', 'Get-JCSystemInsightBrowserPlugin', 'Get-JCSystemInsightCertificate', 'Get-JCSystemInsightChromeExtension', 'Get-JCSystemInsightConnectivity', 'Get-JCSystemInsightCrash', 'Get-JCSystemInsightCupDestination', 'Get-JCSystemInsightDiskEncryption', 'Get-JCSystemInsightDiskInfo', 'Get-JCSystemInsightDnsResolver', 'Get-JCSystemInsightEtcHost', 'Get-JCSystemInsightFirefoxAddon', 'Get-JCSystemInsightGroup', 'Get-JCSystemInsightIeExtension', 'Get-JCSystemInsightInterfaceAddress', 'Get-JCSystemInsightInterfaceDetail', 'Get-JCSystemInsightKernelInfo', 'Get-JCSystemInsightLaunchd', 'Get-JCSystemInsightLogged', 'Get-JCSystemInsightLogicalDrive', 'Get-JCSystemInsightManagedPolicy', 'Get-JCSystemInsightMount', 'Get-JCSystemInsightOSVersion', 'Get-JCSystemInsightPatch', 'Get-JCSystemInsightProgram', 'Get-JCSystemInsightPythonPackage', 'Get-JCSystemInsightRegistry', 'Get-JCSystemInsightSafariExtension', 'Get-JCSystemInsightScheduledTask', 'Get-JCSystemInsightService', 'Get-JCSystemInsightShadow', 'Get-JCSystemInsightSharedFolder', 'Get-JCSystemInsightSharedResource', 'Get-JCSystemInsightSharingPreference', 'Get-JCSystemInsightSipConfig', 'Get-JCSystemInsightStartupItem', 'Get-JCSystemInsightSystemControl', 'Get-JCSystemInsightSystemInfo', 'Get-JCSystemInsightUptime', 'Get-JCSystemInsightUsbDevice', 'Get-JCSystemInsightUser', 'Get-JCSystemInsightUserGroup', 'Get-JCSystemInsightUserSshKey', 'Get-JCSystemInsightWifiNetwork', 'Get-JCSystemInsightWifiStatus', 'Get-JCSystemInsightWindowCrash', 'Get-JCSystemInsightWindowSecurityProduct', 'Get-JCUserGraphUserAssociation', 'Get-JCUserGraphUserMember', 'Get-JCUserGraphUserTraverseApplication', 'Get-JCUserGraphUserTraverseDirectory', 'Get-JCUserGraphUserTraverseGSuite', 'Get-JCUserGraphUserTraverseLdapServer', 'Get-JCUserGraphUserTraverseOffice365', 'Get-JCUserGraphUserTraverseRadiusServer', 'Get-JCUserGraphUserTraverseSystem', 'Get-JCUserGraphUserTraverseSystemGroup', 'Get-JCUserGroup', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupAssociation', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseApplication', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseDirectory', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseGSuite', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseLdapServer', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseOffice365', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseRadiusServer', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseSystem', 'Get-JCUserGroupAssociationUserGroupGraphUserGroupTraverseSystemGroup', 'Get-JCUserGroupMemberMembershipUserGroupGraphUserGroupMember', 'Get-JCUserGroupMemberMembershipUserGroupGraphUserGroupMembership', 'Get-JCWorkdayImportWorkday', 'Get-JCWorkdayImportWorkdayWorker', 'Grant-JCWorkdayImportWorkday', 'Import-JCWorkdayImportWorkday', 'Import-JCWorkdayImportWorkdayResult', 'Lock-JCAppleMdmDevice', 'New-JCBulkJobRequestBulkUser', 'New-JCDuoAccount', 'New-JCDuoApplication', 'New-JCGSuiteTranslationRule', 'New-JCOffice365TranslationRule', 'New-JCPolicy', 'New-JCProviderAdmin', 'New-JCSambaDomainLdapServerSambaDomain', 'New-JCSystemGroup', 'New-JCUserGroup', 'New-JCWorkdayImportWorkday', 'Remove-JCAppleMdm', 'Remove-JCDuoAccount', 'Remove-JCDuoApplication', 'Remove-JCGSuiteTranslationRule', 'Remove-JCOffice365TranslationRule', 'Remove-JCPolicy', 'Remove-JCSambaDomainLdapServerSambaDomain', 'Remove-JCSystemGroup', 'Remove-JCUserGroup', 'Remove-JCWorkdayImportWorkdayAuthorization', 'Restart-JCAppleMdmDevice', 'Set-JCAppleMdm', 'Set-JCApplicationGraphApplicationAssociation', 'Set-JCCommandGraphCommandAssociation', 'Set-JCDuoApplication', 'Set-JCGSuiteGraphGSuiteAssociation', 'Set-JCLdapServerGraphLdapServerAssociation', 'Set-JCOffice365GraphOffice365Association', 'Set-JCPolicy', 'Set-JCPolicyGraphPolicyAssociation', 'Set-JCRadiusServerGraphRadiusServerAssociation', 'Set-JCSambaDomainLdapServerSambaDomain', 'Set-JCSystemGraphSystemAssociation', 'Set-JCSystemGroup', 'Set-JCSystemGroupAssociationSystemGroupGraphSystemGroupAssociation', 'Set-JCSystemGroupMemberMembershipSystemGroupGraphSystemGroupMember', 'Set-JCUserGraphUserAssociation', 'Set-JCUserGroup', 'Set-JCUserGroupAssociationUserGroupGraphUserGroupAssociation', 'Set-JCUserGroupMemberMembershipUserGroupGraphUserGroupMember', 'Set-JCWorkdayImportWorkday', 'Stop-JCAppleMdmDevice', 'Update-JCAppleMdmDevice', 'Update-JCBulkJobRequestBulkUser', 'Update-JCGSuite', 'Update-JCLdapServer', 'Update-JCOffice365', '*'
  AliasesToExport = '*'
  PrivateData = @{
=======
#
# Module manifest for module 'JumpCloud.SDK.V2'
#
# Generated by: JumpCloud Solutions Architect Team
#
# Generated on: 5/26/2020
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './JumpCloud.SDK.V2.psm1'

# Version number of this module.
ModuleVersion = '0.0.17'

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

>>>>>>> master
    PSData = @{
      Tags = 'JumpCloud,', 'DaaS,', 'Jump,', 'Cloud,', 'Directory'
      LicenseUri = 'https://github.com/TheJumpCloud/support/blob/master/PowerShell/LICENSE'
      ProjectUri = 'https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/JumpCloud.SDK.V2/'
      ReleaseNotes = ''
    }
  }
}
