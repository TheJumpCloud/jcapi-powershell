BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkLdapServerTraverseUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkLdapServerTraverseUserGroup' -Tag:(""){
    It 'Get' {
        { Get-JcSdkLdapServerTraverseUserGroup -LdapserverId:($global:PesterTestLdapserver.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkLdapServerTraverseUserGroup -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

