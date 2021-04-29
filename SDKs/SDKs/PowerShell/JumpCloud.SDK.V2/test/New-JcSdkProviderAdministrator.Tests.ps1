$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkProviderAdministrator.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkProviderAdministrator' {
    It 'CreateExpanded' -skip {
        $global:PesterTestProviderAdministrator = New-JcSdkProviderAdministrator @global:PesterDefProviderAdministrator
        $global:PesterTestProviderAdministrator | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkProviderAdministrator -Body:($global:PesterTestProviderAdministrator) -ProviderId '<String>' } | Should -Not -Throw
    }

    It 'CreateViaIdentity' -skip {
        { New-JcSdkProviderAdministrator -Body:($global:PesterTestProviderAdministrator) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { New-JcSdkProviderAdministrator -Email '<String>' -InputObject '<IJumpCloudApIsIdentity>' [-EnableMultiFactor] [-Firstname '<String>'] [-Lastname '<String>'] [-Role '<String>'] [-RoleName '<String>'] } | Should -Not -Throw
    }
}
