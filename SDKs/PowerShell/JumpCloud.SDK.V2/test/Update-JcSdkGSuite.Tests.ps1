BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-JcSdkGSuite.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Update-JcSdkGSuite' -Tag:("")){
    It 'UpdateExpanded' -skip {
        { Update-JcSdkGSuite -Id:($global:PesterTestGSuite.Id) [-GroupsEnabled] [-Name '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }

    It 'Update' -skip {
        { Update-JcSdkGSuite -Body:($global:PesterTestGSuite) -Id:($global:PesterTestGSuite.Id) } | Should -Not -Throw
    }

    It 'UpdateViaIdentity' -skip {
        { Update-JcSdkGSuite -Body:($global:PesterTestGSuite) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { Update-JcSdkGSuite -InputObject '<IJumpCloudApIsIdentity>' [-GroupsEnabled] [-Name '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }
}

