@{
  GUID = '03faa561-1cd3-40aa-ac8e-6544317d1678'
  RootModule = './JumpCloud.SDK.DirectoryInsights.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'JumpCloud Solutions Architect Team'
  CompanyName = 'JumpCloud'
  Copyright = '(c) JumpCloud. All rights reserved.'
  Description = 'The JumpCloud DirectoryInsights PowerShell SDK'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/JumpCloud.SDK.DirectoryInsights.private.dll'
  FormatsToProcess = './JumpCloud.SDK.DirectoryInsights.format.ps1xml'
  FunctionsToExport = 'Get-JcSdkEvent', '*'
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
