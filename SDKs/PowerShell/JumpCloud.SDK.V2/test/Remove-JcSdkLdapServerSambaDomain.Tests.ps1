BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-JcSdkLdapServerSambaDomain.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Remove-JcSdkLdapServerSambaDomain' -Tag:("")){
    It 'Delete' -skip {
        { Remove-JcSdkLdapServerSambaDomain -Id:($global:PesterTestLdapServerSambaDomain.Id) -LdapserverId:($global:PesterTestLdapserver.Id) } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { Remove-JcSdkLdapServerSambaDomain -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

