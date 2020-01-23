#
# Module manifest for module 'JumpCloud.SDK.V2'
#
# Generated by: JumpCloud Solutions Architect Team
#
# Generated on: 1/23/2020
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './JumpCloud.SDK.V2.psm1'

# Version number of this module.
ModuleVersion = '0.0.1'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '8f41086d-2727-44b6-9601-5f257c918f88'

# Author of this module
Author = 'JumpCloud Solutions Architect Team'

# Company or vendor of this module
CompanyName = 'JumpCloud'

# Copyright statement for this module
Copyright = '(c) JumpCloud. All rights reserved.'

# Description of the functionality provided by this module
Description = 'The JumpCloud PowerShell SDK'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

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
FunctionsToExport = 'Get-JcSdkActiveDirectory', 'Get-JcSdkActiveDirectoryAssociation', 
               'Get-JcSdkActiveDirectoryTraverseUserGroup', 
               'Get-JcSdkApplicationAssociation', 
               'Get-JcSdkApplicationTraverseUser', 
               'Get-JcSdkApplicationTraverseUserGroup', 'Get-JcSdkBulkUsersResult', 
               'Get-JcSdkCommandAssociation', 'Get-JcSdkCommandTraverseSystem', 
               'Get-JcSdkCommandTraverseSystemGroup', 'Get-JcSdkDirectory', 
               'Get-JcSdkDuoAccount', 'Get-JcSdkDuoApplication', 'Get-JcSdkGroup', 
               'Get-JcSdkGSuite', 'Get-JcSdkGSuiteAssociation', 
               'Get-JcSdkGSuiteTranslationRule', 'Get-JcSdkGSuiteTraverseUser', 
               'Get-JcSdkGSuiteTraverseUserGroup', 'Get-JcSdkLdapServer', 
               'Get-JcSdkLdapServerAssociation', 'Get-JcSdkLdapServerSambaDomain', 
               'Get-JcSdkLdapServerTraverseUser', 
               'Get-JcSdkLdapServerTraverseUserGroup', 'Get-JcSdkOffice365', 
               'Get-JcSdkOffice365Association', 
               'Get-JcSdkOffice365TranslationRule', 
               'Get-JcSdkOffice365TraverseUser', 
               'Get-JcSdkOffice365TraverseUserGroup', 'Get-JcSdkOrgPolicyResult', 
               'Get-JcSdkPolicy', 'Get-JcSdkPolicyAssociation', 
               'Get-JcSdkPolicyResult', 'Get-JcSdkPolicyStatus', 
               'Get-JcSdkPolicyTemplate', 'Get-JcSdkPolicyTraverseSystem', 
               'Get-JcSdkPolicyTraverseSystemGroup', 
               'Get-JcSdkProviderAdministrator', 
               'Get-JcSdkRadiusServerAssociation', 
               'Get-JcSdkRadiusServerTraverseUser', 
               'Get-JcSdkRadiusServerTraverseUserGroup', 
               'Get-JcSdkSystemAssociation', 'Get-JcSdkSystemFdeKey', 
               'Get-JcSdkSystemGroup', 'Get-JcSdkSystemGroupAssociation', 
               'Get-JcSdkSystemGroupMember', 'Get-JcSdkSystemGroupMembership', 
               'Get-JcSdkSystemGroupTraverseCommand', 
               'Get-JcSdkSystemGroupTraversePolicy', 
               'Get-JcSdkSystemGroupTraverseUser', 
               'Get-JcSdkSystemGroupTraverseUserGroup', 
               'Get-JcSdkSystemInsightsApp', 
               'Get-JcSdkSystemInsightsBitlockerInfo', 
               'Get-JcSdkSystemInsightsBrowserPlugin', 
               'Get-JcSdkSystemInsightsChromeExtension', 
               'Get-JcSdkSystemInsightsDiskEncryption', 
               'Get-JcSdkSystemInsightsDiskInfo', 'Get-JcSdkSystemInsightsEtcHost', 
               'Get-JcSdkSystemInsightsFirefoxAddon', 
               'Get-JcSdkSystemInsightsGroup', 
               'Get-JcSdkSystemInsightsInterfaceAddress', 
               'Get-JcSdkSystemInsightsKernelInfo', 
               'Get-JcSdkSystemInsightsLogicalDrive', 
               'Get-JcSdkSystemInsightsMount', 'Get-JcSdkSystemInsightsOSVersion', 
               'Get-JcSdkSystemInsightsPatch', 'Get-JcSdkSystemInsightsProgram', 
               'Get-JcSdkSystemInsightsSafariExtension', 
               'Get-JcSdkSystemInsightsSystemControl', 
               'Get-JcSdkSystemInsightsSystemInfo', 
               'Get-JcSdkSystemInsightsUptime', 'Get-JcSdkSystemInsightsUser', 
               'Get-JcSdkSystemMemberOf', 'Get-JcSdkSystemTraverseCommand', 
               'Get-JcSdkSystemTraversePolicy', 'Get-JcSdkSystemTraverseUser', 
               'Get-JcSdkSystemTraverseUserGroup', 'Get-JcSdkUserAssociation', 
               'Get-JcSdkUserGroup', 'Get-JcSdkUserGroupAssociation', 
               'Get-JcSdkUserGroupMember', 'Get-JcSdkUserGroupMembership', 
               'Get-JcSdkUserGroupTraverseApplication', 
               'Get-JcSdkUserGroupTraverseDirectory', 
               'Get-JcSdkUserGroupTraverseGSuite', 
               'Get-JcSdkUserGroupTraverseLdapServer', 
               'Get-JcSdkUserGroupTraverseOffice365', 
               'Get-JcSdkUserGroupTraverseRadiusServer', 
               'Get-JcSdkUserGroupTraverseSystem', 
               'Get-JcSdkUserGroupTraverseSystemGroup', 'Get-JcSdkUserMemberOf', 
               'Get-JcSdkUserTraverseApplication', 
               'Get-JcSdkUserTraverseDirectory', 'Get-JcSdkUserTraverseGSuite', 
               'Get-JcSdkUserTraverseLdapServer', 'Get-JcSdkUserTraverseOffice365', 
               'Get-JcSdkUserTraverseRadiusServer', 'Get-JcSdkUserTraverseSystem', 
               'Get-JcSdkUserTraverseSystemGroup', 'Get-JcSdkWorkday', 
               'Get-JcSdkWorkdayWorker', 'Grant-JcSdkWorkday', 'Import-JcSdkWorkday', 
               'Import-JcSdkWorkdayResult', 'New-JcSdkBulkUser', 
               'New-JcSdkDuoAccount', 'New-JcSdkDuoApplication', 
               'New-JcSdkGSuiteTranslationRule', 'New-JcSdkLdapServerSambaDomain', 
               'New-JcSdkOffice365TranslationRule', 'New-JcSdkPolicy', 
               'New-JcSdkProviderAdmin', 'New-JcSdkSystemGroup', 
               'New-JcSdkUserGroup', 'New-JcSdkWorkday', 'Remove-JcSdkDuoAccount', 
               'Remove-JcSdkDuoApplication', 'Remove-JcSdkGSuiteTranslationRule', 
               'Remove-JcSdkLdapServerSambaDomain', 
               'Remove-JcSdkOffice365TranslationRule', 'Remove-JcSdkPolicy', 
               'Remove-JcSdkSystemGroup', 'Remove-JcSdkUserGroup', 
               'Remove-JcSdkWorkdayAuthorization', 
               'Set-JcSdkApplicationAssociation', 'Set-JcSdkCommandAssociation', 
               'Set-JcSdkDuoApplication', 'Set-JcSdkGSuiteAssociation', 
               'Set-JcSdkLdapServerAssociation', 'Set-JcSdkLdapServerSambaDomain', 
               'Set-JcSdkOffice365Association', 'Set-JcSdkPolicy', 
               'Set-JcSdkPolicyAssociation', 'Set-JcSdkRadiusServerAssociation', 
               'Set-JcSdkSystemAssociation', 'Set-JcSdkSystemGroup', 
               'Set-JcSdkSystemGroupAssociation', 'Set-JcSdkSystemGroupMember', 
               'Set-JcSdkUserAssociation', 'Set-JcSdkUserGroup', 
               'Set-JcSdkUserGroupAssociation', 'Set-JcSdkUserGroupMember', 
               'Set-JcSdkWorkday', 'Update-JcSdkBulkUser', 'Update-JcSdkGSuite', 
               'Update-JcSdkLdapServer', 'Update-JcSdkOffice365', '*'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Get-JcSdkActiveDirectory', 'Get-JcSdkActiveDirectoryAssociation', 
               'Get-JcSdkActiveDirectoryTraverseUserGroup', 
               'Get-JcSdkApplicationAssociation', 
               'Get-JcSdkApplicationTraverseUser', 
               'Get-JcSdkApplicationTraverseUserGroup', 'Get-JcSdkBulkUsersResult', 
               'Get-JcSdkCommandAssociation', 'Get-JcSdkCommandTraverseSystem', 
               'Get-JcSdkCommandTraverseSystemGroup', 'Get-JcSdkDirectory', 
               'Get-JcSdkDuoAccount', 'Get-JcSdkDuoApplication', 'Get-JcSdkGroup', 
               'Get-JcSdkGSuite', 'Get-JcSdkGSuiteAssociation', 
               'Get-JcSdkGSuiteTranslationRule', 'Get-JcSdkGSuiteTraverseUser', 
               'Get-JcSdkGSuiteTraverseUserGroup', 'Get-JcSdkLdapServer', 
               'Get-JcSdkLdapServerAssociation', 'Get-JcSdkLdapServerSambaDomain', 
               'Get-JcSdkLdapServerTraverseUser', 
               'Get-JcSdkLdapServerTraverseUserGroup', 'Get-JcSdkOffice365', 
               'Get-JcSdkOffice365Association', 
               'Get-JcSdkOffice365TranslationRule', 
               'Get-JcSdkOffice365TraverseUser', 
               'Get-JcSdkOffice365TraverseUserGroup', 'Get-JcSdkOrgPolicyResult', 
               'Get-JcSdkPolicy', 'Get-JcSdkPolicyAssociation', 
               'Get-JcSdkPolicyResult', 'Get-JcSdkPolicyStatus', 
               'Get-JcSdkPolicyTemplate', 'Get-JcSdkPolicyTraverseSystem', 
               'Get-JcSdkPolicyTraverseSystemGroup', 
               'Get-JcSdkProviderAdministrator', 
               'Get-JcSdkRadiusServerAssociation', 
               'Get-JcSdkRadiusServerTraverseUser', 
               'Get-JcSdkRadiusServerTraverseUserGroup', 
               'Get-JcSdkSystemAssociation', 'Get-JcSdkSystemFdeKey', 
               'Get-JcSdkSystemGroup', 'Get-JcSdkSystemGroupAssociation', 
               'Get-JcSdkSystemGroupMember', 'Get-JcSdkSystemGroupMembership', 
               'Get-JcSdkSystemGroupTraverseCommand', 
               'Get-JcSdkSystemGroupTraversePolicy', 
               'Get-JcSdkSystemGroupTraverseUser', 
               'Get-JcSdkSystemGroupTraverseUserGroup', 
               'Get-JcSdkSystemInsightsApp', 
               'Get-JcSdkSystemInsightsBitlockerInfo', 
               'Get-JcSdkSystemInsightsBrowserPlugin', 
               'Get-JcSdkSystemInsightsChromeExtension', 
               'Get-JcSdkSystemInsightsDiskEncryption', 
               'Get-JcSdkSystemInsightsDiskInfo', 'Get-JcSdkSystemInsightsEtcHost', 
               'Get-JcSdkSystemInsightsFirefoxAddon', 
               'Get-JcSdkSystemInsightsGroup', 
               'Get-JcSdkSystemInsightsInterfaceAddress', 
               'Get-JcSdkSystemInsightsKernelInfo', 
               'Get-JcSdkSystemInsightsLogicalDrive', 
               'Get-JcSdkSystemInsightsMount', 'Get-JcSdkSystemInsightsOSVersion', 
               'Get-JcSdkSystemInsightsPatch', 'Get-JcSdkSystemInsightsProgram', 
               'Get-JcSdkSystemInsightsSafariExtension', 
               'Get-JcSdkSystemInsightsSystemControl', 
               'Get-JcSdkSystemInsightsSystemInfo', 
               'Get-JcSdkSystemInsightsUptime', 'Get-JcSdkSystemInsightsUser', 
               'Get-JcSdkSystemMemberOf', 'Get-JcSdkSystemTraverseCommand', 
               'Get-JcSdkSystemTraversePolicy', 'Get-JcSdkSystemTraverseUser', 
               'Get-JcSdkSystemTraverseUserGroup', 'Get-JcSdkUserAssociation', 
               'Get-JcSdkUserGroup', 'Get-JcSdkUserGroupAssociation', 
               'Get-JcSdkUserGroupMember', 'Get-JcSdkUserGroupMembership', 
               'Get-JcSdkUserGroupTraverseApplication', 
               'Get-JcSdkUserGroupTraverseDirectory', 
               'Get-JcSdkUserGroupTraverseGSuite', 
               'Get-JcSdkUserGroupTraverseLdapServer', 
               'Get-JcSdkUserGroupTraverseOffice365', 
               'Get-JcSdkUserGroupTraverseRadiusServer', 
               'Get-JcSdkUserGroupTraverseSystem', 
               'Get-JcSdkUserGroupTraverseSystemGroup', 'Get-JcSdkUserMemberOf', 
               'Get-JcSdkUserTraverseApplication', 
               'Get-JcSdkUserTraverseDirectory', 'Get-JcSdkUserTraverseGSuite', 
               'Get-JcSdkUserTraverseLdapServer', 'Get-JcSdkUserTraverseOffice365', 
               'Get-JcSdkUserTraverseRadiusServer', 'Get-JcSdkUserTraverseSystem', 
               'Get-JcSdkUserTraverseSystemGroup', 'Get-JcSdkWorkday', 
               'Get-JcSdkWorkdayWorker', 'Grant-JcSdkWorkday', 'Import-JcSdkWorkday', 
               'Import-JcSdkWorkdayResult', 'New-JcSdkBulkUser', 
               'New-JcSdkDuoAccount', 'New-JcSdkDuoApplication', 
               'New-JcSdkGSuiteTranslationRule', 'New-JcSdkLdapServerSambaDomain', 
               'New-JcSdkOffice365TranslationRule', 'New-JcSdkPolicy', 
               'New-JcSdkProviderAdmin', 'New-JcSdkSystemGroup', 
               'New-JcSdkUserGroup', 'New-JcSdkWorkday', 'Remove-JcSdkDuoAccount', 
               'Remove-JcSdkDuoApplication', 'Remove-JcSdkGSuiteTranslationRule', 
               'Remove-JcSdkLdapServerSambaDomain', 
               'Remove-JcSdkOffice365TranslationRule', 'Remove-JcSdkPolicy', 
               'Remove-JcSdkSystemGroup', 'Remove-JcSdkUserGroup', 
               'Remove-JcSdkWorkdayAuthorization', 
               'Set-JcSdkApplicationAssociation', 'Set-JcSdkCommandAssociation', 
               'Set-JcSdkDuoApplication', 'Set-JcSdkGSuiteAssociation', 
               'Set-JcSdkLdapServerAssociation', 'Set-JcSdkLdapServerSambaDomain', 
               'Set-JcSdkOffice365Association', 'Set-JcSdkPolicy', 
               'Set-JcSdkPolicyAssociation', 'Set-JcSdkRadiusServerAssociation', 
               'Set-JcSdkSystemAssociation', 'Set-JcSdkSystemGroup', 
               'Set-JcSdkSystemGroupAssociation', 'Set-JcSdkSystemGroupMember', 
               'Set-JcSdkUserAssociation', 'Set-JcSdkUserGroup', 
               'Set-JcSdkUserGroupAssociation', 'Set-JcSdkUserGroupMember', 
               'Set-JcSdkWorkday', 'Update-JcSdkBulkUser', 'Update-JcSdkGSuite', 
               'Update-JcSdkLdapServer', 'Update-JcSdkOffice365'

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
        ProjectUri = 'https://github.com/TheJumpCloud/support/wiki'

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

