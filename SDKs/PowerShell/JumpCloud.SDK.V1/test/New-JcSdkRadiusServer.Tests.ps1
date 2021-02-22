$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkRadiusServer.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$global:PesterTestRadiusServerName = 'PesterTestRadiusServerName'
$global:PesterTestRadiusServerIp = '211.211.211.211'
$global:PesterTestSharedSecret = 'PesterTestSharedSecret'
Describe 'New-JcSdkRadiusServer' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $RadiusServer = Get-JcSdkRadiusServer | Where-Object { $_.Name -eq $global:PesterTestRadiusServerName -or $_.NetworkSourceIP -eq $global:PesterTestRadiusServerIp }
        If ($RadiusServer)
        {
            Remove-JcSdkRadiusServer -Id:($RadiusServer.Id)
        }
        New-JcSdkRadiusServer -Name:($global:PesterTestRadiusServerName) -NetworkSourceIP:($global:PesterTestRadiusServerIp) -SharedSecret:($global:PesterTestSharedSecret) | Should -Not -BeNullOrEmpty
    }
}
