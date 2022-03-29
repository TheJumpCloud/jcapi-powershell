BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkIPList.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Update-JcSdkIPList' {
    It 'UpdateExpanded' -skip {
        { Update-JcSdkIPList -Id:($global:PesterTestIPList.Id) [-Description '<String>'] [-Ips '<String[]>'] [-Name '<String>'] } | Should -Not -Throw
    }

    It 'Update' -skip {
        { Update-JcSdkIPList -Body:($global:PesterTestIPList) -Id:($global:PesterTestIPList.Id) } | Should -Not -Throw
    }

    It 'UpdateViaIdentity' -skip {
        { Update-JcSdkIPList -Body:($global:PesterTestIPList) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { Update-JcSdkIPList -InputObject '<IJumpCloudApIsIdentity>' [-Description '<String>'] [-Ips '<String[]>'] [-Name '<String>'] } | Should -Not -Throw
    }
}

