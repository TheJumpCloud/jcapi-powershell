$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkDuoAccount.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkDuoAccount' {
    It 'List' -skip {
        { Get-JcSdkDuoAccount } | Should -Not -Throw
    }

    It 'Get' -skip {
        { Get-JcSdkDuoAccount -Id:($global:PesterTestDuoAccount.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        Get-JcSdkDuoAccount -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }
}
