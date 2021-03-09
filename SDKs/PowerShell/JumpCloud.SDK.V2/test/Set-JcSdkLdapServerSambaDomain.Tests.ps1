$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkLdapServerSambaDomain.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkLdapServerSambaDomain' {
    It 'SetExpanded' -skip {
        { Set-JcSdkLdapServerSambaDomain -Id '<String>' -LdapserverId '<String>' -Name '<String>' -Sid '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkLdapServerSambaDomain -Body '<ISambaDomainInput>' -Id '<String>' -LdapserverId '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkLdapServerSambaDomain -Body '<ISambaDomainInput>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkLdapServerSambaDomain -InputObject '<IJumpCloudApIsIdentity>' -Name '<String>' -Sid '<String>' } | Should -Not -Throw
    }
}
