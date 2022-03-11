BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkOffice365.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Update-JcSdkOffice365' {
    It 'UpdateExpanded' -skip {
        { Update-JcSdkOffice365 -Office365Id:($global:PesterTestOffice365.Id) [-Name '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }

    It 'Update' -skip {
        { Update-JcSdkOffice365 -Body:($global:PesterTestOffice365) -Office365Id:($global:PesterTestOffice365.Id) } | Should -Not -Throw
    }

    It 'UpdateViaIdentity' -skip {
        { Update-JcSdkOffice365 -Body:($global:PesterTestOffice365) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { Update-JcSdkOffice365 -InputObject '<IJumpCloudApIsIdentity>' [-Name '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }
}

