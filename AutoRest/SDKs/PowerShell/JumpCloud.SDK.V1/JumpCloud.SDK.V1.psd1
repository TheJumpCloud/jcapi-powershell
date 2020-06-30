@{
  GUID = 'c865b0ce-935e-4500-a486-3ec7bc65c8bb'
  RootModule = './JumpCloud.SDK.V1.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'JumpCloud Solutions Architect Team'
  CompanyName = 'JumpCloud'
  Copyright = '(c) JumpCloud. All rights reserved.'
  Description = 'The JumpCloud V1 PowerShell SDK'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/JumpCloud.SDK.V1.private.dll'
  FormatsToProcess = './JumpCloud.SDK.V1.format.ps1xml'
  FunctionsToExport = 'Get-JCApplication', 'Get-JCApplicationTemplate', 'Get-JCCommand', 'Get-JCCommandFile', 'Get-JCCommandResult', 'Get-JCOrganization', 'Get-JCRadiusServer', 'Get-JCSystem', 'Get-JCSystemUser', 'Get-JCSystemUserSshKey', 'Invoke-JCCommandTrigger', 'Invoke-JCExpireSystemUserPassword', 'New-JCApplication', 'New-JCCommand', 'New-JCRadiusServer', 'New-JCSystemUser', 'New-JCSystemUserSshKey', 'Remove-JCApplication', 'Remove-JCCommand', 'Remove-JCCommandResult', 'Remove-JCSystem', 'Remove-JCSystemUser', 'Remove-JCSystemUserSshKey', 'Reset-JCSystemUserMfa', 'Search-JCOrganization', 'Search-JCSystem', 'Search-JCSystemUser', 'Set-JCApplication', 'Set-JCCommand', 'Set-JCOrganization', 'Set-JCRadiusServer', 'Set-JCSystem', 'Set-JCSystemUser', 'Unlock-JCSystemUser', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'JumpCloud,', 'DaaS,', 'Jump,', 'Cloud,', 'Directory'
      LicenseUri = 'https://github.com/TheJumpCloud/support/blob/master/PowerShell/LICENSE'
      ProjectUri = 'https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/JumpCloud.SDK.V1/'
      ReleaseNotes = ''
    }
  }
}
