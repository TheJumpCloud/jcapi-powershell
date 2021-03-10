$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSoftwareApp.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSoftwareApp' {
    It 'SetExpanded' -skip {
        { Set-JcSdkSoftwareApp -Id:($global:PesterTestSoftwareApp.Id) } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkSoftwareApp -Body '<ISoftwareApp>' -Id:($global:PesterTestSoftwareApp.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSoftwareApp -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSoftwareApp -Body '<ISoftwareApp>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
