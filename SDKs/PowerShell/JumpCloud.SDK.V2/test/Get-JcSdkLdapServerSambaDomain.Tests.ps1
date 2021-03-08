$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkLdapServerSambaDomain.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-JcSdkLdapServerSambaDomain' {
    It 'List' {
        Get-JcSdkLdapServerSambaDomain -LdapserverId $($global:PesterLdapServer.Id) | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $SambaId = Get-JcSdkLdapServerSambaDomain -LdapserverId $($global:PesterLdapServer.Id)
        Get-JcSdkLdapServerSambaDomain -LdapserverId $($global:PesterLdapServer.Id) -Id $SambaId.id | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
