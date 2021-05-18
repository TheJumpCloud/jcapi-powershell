#
# Module manifest for module 'JumpCloud.SDK.V1'
#
# Generated by: JumpCloud
#
# Generated on: 5/14/2021
#

@{

# Script module or binary module file associated with this manifest.
RootModule = './JumpCloud.SDK.V1.psm1'

# Version number of this module.
ModuleVersion = '0.0.27'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = '85e70ace-c640-4638-89eb-e4b30362d95d'

# Author of this module
Author = 'JumpCloud'

# Company or vendor of this module
CompanyName = 'JumpCloud'

# Copyright statement for this module
Copyright = '(c) JumpCloud. All rights reserved.'

# Description of the functionality provided by this module
Description = 'The JumpCloud V1 PowerShell SDK'

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
RequiredAssemblies = './bin/JumpCloud.SDK.V1.private.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Clear-JcSdkSystem', 'Get-JcSdkApplication', 
               'Get-JcSdkApplicationTemplate', 'Get-JcSdkCommand', 
               'Get-JcSdkCommandFile', 'Get-JcSdkCommandResult', 
               'Get-JcSdkOrganization', 'Get-JcSdkRadiusServer', 'Get-JcSdkSystem', 
               'Get-JcSdkUser', 'Get-JcSdkUserSshKey', 'Invoke-JcSdkCommandTrigger', 
               'Invoke-JcSdkExpireUserPassword', 'Lock-JcSdkSystem', 
               'New-JcSdkApplication', 'New-JcSdkCommand', 'New-JcSdkRadiusServer', 
               'New-JcSdkUser', 'New-JcSdkUserSshKey', 'Remove-JcSdkApplication', 
               'Remove-JcSdkCommand', 'Remove-JcSdkCommandResult', 
               'Remove-JcSdkRadiusServer', 'Remove-JcSdkSystem', 'Remove-JcSdkUser', 
               'Remove-JcSdkUserSshKey', 'Reset-JcSdkUserMfa', 'Restart-JcSdkSystem', 
               'Search-JcSdkOrganization', 'Search-JcSdkSystem', 'Search-JcSdkUser', 
               'Set-JcSdkApplication', 'Set-JcSdkCommand', 'Set-JcSdkOrganization', 
               'Set-JcSdkRadiusServer', 'Set-JcSdkSystem', 'Set-JcSdkUser', 
               'Stop-JcSdkSystem', 'Unlock-JcSdkUser'

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
        ProjectUri = 'https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/'

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

