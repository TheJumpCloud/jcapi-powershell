param([switch]$Isolated)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$exportsFolder = Join-Path $PSScriptRoot 'exports'
if(-not (Test-Path $exportsFolder)) {
  Write-Error "Exports folder '$exportsFolder' was not found."
}

$directories = Get-ChildItem -Directory -Path $exportsFolder
$hasProfiles = ($directories | Measure-Object).Count -gt 0
if(-not $hasProfiles) {
  $directories = Get-Item -Path $exportsFolder
}

$docsFolder = Join-Path $PSScriptRoot 'docs'
if(Test-Path $docsFolder) {
  $null = Get-ChildItem -Path $docsFolder -Recurse -Exclude 'readme.md' | Remove-Item -Recurse -ErrorAction SilentlyContinue
}
$null = New-Item -ItemType Directory -Force -Path $docsFolder -ErrorAction SilentlyContinue
$examplesFolder = Join-Path $PSScriptRoot 'examples'

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot './JumpCloud.SDK.V1.psd1')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

# Load DLL to use build-time cmdlets
Import-Module -Name (Join-Path $PSScriptRoot './bin/JumpCloud.SDK.V1.private.dll')
Import-Module -Name $modulePath
$instance = [JumpCloud.SDK.V1.Module]::Instance
# Module info is shared per profile
$moduleInfo = Get-Module -Name $moduleName

foreach($directory in $directories)
{
  if($hasProfiles) {
    Select-AzProfile -Name $directory.Name
  }
  # Reload module per profile
  Import-Module -Name $modulePath -Force

  $cmdletNames = Get-ScriptCmdlet -ScriptFolder $directory.FullName
  $cmdletHelpInfo = $cmdletNames | ForEach-Object { Get-Help -Name $_ -Full }
  $cmdletFunctionInfo = Get-ScriptCmdlet -ScriptFolder $directory.FullName -AsFunctionInfo

  $docsPath = Join-Path $docsFolder $directory.Name
  $null = New-Item -ItemType Directory -Force -Path $docsPath -ErrorAction SilentlyContinue
  $examplesPath = Join-Path $examplesFolder $directory.Name

  Export-HelpMarkdown -ModuleInfo $moduleInfo -FunctionInfo $cmdletFunctionInfo -HelpInfo $cmdletHelpInfo -DocsFolder $docsPath -ExamplesFolder $examplesPath
  Write-Host -ForegroundColor Green "Created documentation in '$docsPath'"
}

Write-Host -ForegroundColor Green '-------------Done-------------'