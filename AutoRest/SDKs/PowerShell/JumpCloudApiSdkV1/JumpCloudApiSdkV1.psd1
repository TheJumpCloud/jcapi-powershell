@{
  GUID = 'cc4eb447-504a-41d7-ba3b-712cd308723b'
  RootModule = './JumpCloudApiSdkV1.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'JumpCloud Solutions Architect Team'
  CompanyName = 'JumpCloud'
  Copyright = '(c) JumpCloud. All rights reserved.'
  Description = 'The JumpCloud PowerShell SDK'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/JumpCloudApiSdkV1.private.dll'
  FormatsToProcess = './JumpCloudApiSdkV1.format.ps1xml'
  CmdletsToExport = 'Get-JcSdkApplication', 'Get-JcSdkCommand', 'Get-JcSdkCommandFile', 'Get-JcSdkCommandResult', 'Get-JcSdkOrganization', 'Get-JcSdkRadiusServer', 'Get-JcSdkSystem', 'Get-JcSdkSystemUser', 'Get-JcSdkSystemUserBinding', 'Get-JcSdkSystemUserSshKey', 'Get-JcSdkSystemUserSystemBinding', 'Invoke-JcSdkTemplateApplication', 'New-JcSdkApplication', 'New-JcSdkCommand', 'New-JcSdkRadiusServer', 'New-JcSdkSearchSystemUser', 'New-JcSdkSystemUser', 'New-JcSdkSystemUserSshKey', 'Remove-JcSdkApplication', 'Remove-JcSdkCommand', 'Remove-JcSdkCommandResult', 'Remove-JcSdkSystem', 'Remove-JcSdkSystemUser', 'Remove-JcSdkSystemUserSshKey', 'Reset-JcSdkSystemUserMfa', 'Search-JcSdkSearchOrganization', 'Search-JcSdkSearchSystem', 'Set-JcSdkApplication', 'Set-JcSdkCommand', 'Set-JcSdkRadiusServer', 'Set-JcSdkSystem', 'Set-JcSdkSystemUser', 'Set-JcSdkSystemUserBinding', 'Set-JcSdkSystemUserSystemBinding', 'Start-JcSdkCommandTriggerWebhook', 'Unlock-JcSdkSystemUser', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'JumpCloud,', 'DaaS,', 'Jump,', 'Cloud,', 'Directory'
      LicenseUri = 'https://github.com/TheJumpCloud/support/blob/master/PowerShell/LICENSE'
      ProjectUri = 'https://github.com/TheJumpCloud/support/wiki'
      ReleaseNotes = ''
    }
  }
}
