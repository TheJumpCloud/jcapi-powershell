$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemGroup' {
    It 'SetExpanded' {
        { Set-JcSdkSystemGroup -Id:($global:PesterTestSystemGroup.Id) -Name:($global:PesterTestSystemGroup.Name) } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkSystemGroup -Body:($global:PesterTestSystemGroup) -Id:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemGroup -Body:($global:PesterTestSystemGroup) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemGroup -InputObject '<IJumpCloudApIsIdentity>' -Name:($global:PesterTestSystemGroup.Name) } | Should -Not -Throw
    }
}
