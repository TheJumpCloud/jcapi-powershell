$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkIPList.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkIPList' {
    It 'SetExpanded' {
        { Set-JcSdkIPList -Id:($global:PesterTestIPList.Id) } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkIPList -Body:($global:PesterTestIPList) -Id:($global:PesterTestIPList.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkIPList -Body:($global:PesterTestIPList) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkIPList -InputObject '<IJumpCloudApIsIdentity>' [-Description '<String>'] [-Ips '<String[]>'] [-Name '<String>'] } | Should -Not -Throw
    }
}
