BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkLdapServerSambaDomain.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkLdapServerSambaDomain' {
    It 'CreateExpanded' -skip {
        $global:PesterTestLdapServerSambaDomain = New-JcSdkLdapServerSambaDomain @global:PesterDefLdapServerSambaDomain
        $global:PesterTestLdapServerSambaDomain | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkLdapServerSambaDomain -Body:($global:PesterTestLdapServerSambaDomain) -LdapserverId:($global:PesterTestLdapserver.Id) } | Should -Not -Throw
    }

    It 'CreateViaIdentity' -skip {
        { New-JcSdkLdapServerSambaDomain -Body:($global:PesterTestLdapServerSambaDomain) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { New-JcSdkLdapServerSambaDomain -InputObject '<IJumpCloudApIsIdentity>' -Name:($global:PesterTestLdapServerSambaDomain.Name) -Sid '<String>' } | Should -Not -Throw
    }
}

