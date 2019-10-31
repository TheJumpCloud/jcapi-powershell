param([switch]$Isolated, [switch]$IncludeGeneralParameters, [switch]$UseExpandedFormat)
$ErrorActionPreference = 'Stop'

$pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$dll = Join-Path $PSScriptRoot 'bin\JumpCloudApiSdkV1.private.dll'
if(-not (Test-Path $dll)) {
  Write-Error "Unable to find output assembly in '$binFolder'."
}
$null = Import-Module -Name $dll

$moduleName = 'JumpCloudApiSdkV1'
$exportsFolder = Join-Path $PSScriptRoot 'exports'
$resourcesFolder = Join-Path $PSScriptRoot 'resources'

Export-CmdletSurface -ModuleName $moduleName -CmdletFolder $exportsFolder -OutputFolder $resourcesFolder -IncludeGeneralParameters $IncludeGeneralParameters.IsPresent -UseExpandedFormat $UseExpandedFormat.IsPresent
Write-Host -ForegroundColor Green "CmdletSurface file(s) created in '$resourcesFolder'"

Export-ModelSurface -OutputFolder $resourcesFolder -UseExpandedFormat $UseExpandedFormat.IsPresent
Write-Host -ForegroundColor Green "ModelSurface file created in '$resourcesFolder'"

Write-Host -ForegroundColor Green '-------------Done-------------'