$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkCustomEmailConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkCustomEmailConfiguration' {
    It 'SetExpanded' -skip {
        { Set-JcSdkCustomEmailConfiguration -CustomEmailType:($global:PesterDefCustomEmailConfiguration.Type) -Subject '<String>' -Type '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkCustomEmailConfiguration -CustomEmail '<ICustomEmail>' -CustomEmailType:($global:PesterDefCustomEmailConfiguration.Type) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkCustomEmailConfiguration -CustomEmail '<ICustomEmail>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkCustomEmailConfiguration -InputObject '<IJumpCloudApIsIdentity>' -Subject '<String>' -Type '<String>' } | Should -Not -Throw
    }
}
