$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkApplication' {
    It 'SetExpanded' -skip {
        { Set-JcSdkApplication -Id:($global:PesterTestApplication.Id) } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkApplication -Body '<IApplication>' -Id:($global:PesterTestApplication.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkApplication -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkApplication -Body '<IApplication>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
