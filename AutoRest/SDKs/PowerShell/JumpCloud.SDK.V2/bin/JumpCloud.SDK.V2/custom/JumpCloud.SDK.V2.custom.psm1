# region Generated 
  # Load the private module dll
  $null = Import-Module -PassThru -Name (Join-Path $PSScriptRoot '..\bin\JumpCloud.SDK.V2.private.dll')

  # Load the internal module
  $internalModulePath = Join-Path $PSScriptRoot '..\internal\JumpCloud.SDK.V2.internal.psm1'
  if(Test-Path $internalModulePath) {
    $null = Import-Module -Name $internalModulePath
  }

  # Export nothing to clear implicit exports
  Export-ModuleMember

  # Export script cmdlets
  Get-ChildItem -Path $PSScriptRoot -Recurse -Include '*.ps1' -File | ForEach-Object { . $_.FullName }
  Export-ModuleMember -Function (Get-ScriptCmdlet -ScriptFolder $PSScriptRoot) -Alias (Get-ScriptCmdlet -ScriptFolder $PSScriptRoot -AsAlias)
# endregion
