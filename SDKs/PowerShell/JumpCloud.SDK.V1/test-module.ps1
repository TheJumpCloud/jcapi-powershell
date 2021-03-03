# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------
param([switch]$Isolated, [switch]$Live, [switch]$Record, [switch]$Playback)
$ErrorActionPreference = 'Stop'

if (-not $Isolated)
{
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$ProgressPreference = 'SilentlyContinue'
$baseName = $PSScriptRoot.BaseName
$requireResourceModule = (($baseName -ne "Resources") -and ($Record.IsPresent -or $Live.IsPresent))
. (Join-Path $PSScriptRoot 'check-dependencies.ps1') -Isolated -Accounts:$false -Pester -Resources:$requireResourceModule
. ("$PSScriptRoot\test\utils.ps1")

if ($requireResourceModule)
{
  $resourceModulePSD = Get-Item -Path (Join-Path $HOME '.PSSharedModules\Resources\Az.Resources.TestSupport.psd1')
  Import-Module -Name $resourceModulePSD.FullName
}

$localModulesPath = Join-Path $PSScriptRoot 'generated\modules'
if (Test-Path -Path $localModulesPath)
{
  $env:PSModulePath = "$localModulesPath$([IO.Path]::PathSeparator)$env:PSModulePath"
}

$modulePsd1 = Get-Item -Path (Join-Path $PSScriptRoot './JumpCloud.SDK.V1.psd1')
$modulePath = $modulePsd1.FullName
$moduleName = $modulePsd1.BaseName

Import-Module -Name Pester
Import-Module -Name $modulePath

$TestMode = 'playback'
if ($Live)
{
  $TestMode = 'live'
}
if ($Record)
{
  $TestMode = 'record'
}
try
{
  if ($TestMode -ne 'playback')
  {
    setupEnv
  }
  $testFolder = Join-Path $PSScriptRoot 'test'
  #################################################################
  $Filter = "*"
  $PesterTestFiles = @()
  # Populate with test file basenames that need to be run in a specific order
  $OrderedTests = @()
  $TestFiles = Get-ChildItem -Path:($testFolder) | Where-Object { $_.BaseName -like "*-JcSdk$($Filter).Tests*" }
  # Add "new" tests (Setup Org)
  $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "New-*" }
  # Add all tests that are in the $OrderedTests list
  $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -in $OrderedTests }
  # Add all tests that are not "new" and not "remove" and not in the $OrderedTests list
  $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -notlike "New-*" -and $_.BaseName -notlike "Remove-*" -and $_.BaseName -notin $OrderedTests }
  # Add "remove" tests (Cleanup Org)
  $PesterTestFiles += $TestFiles | Where-Object { $_.BaseName -like "Remove-*" }
  # Run tests
  Invoke-Pester -Script $PesterTestFiles.FullName -EnableExit -OutputFile (Join-Path $testFolder "$moduleName-TestResults.xml")
  #################################################################
}
Finally
{
  if ($TestMode -ne 'playback')
  {
    cleanupEnv
  }
}

Write-Host -ForegroundColor Green '-------------Done-------------'