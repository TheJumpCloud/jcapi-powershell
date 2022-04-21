BeforeAll {
if (($null -eq $TestName) -or ($TestName -contains 'New-JcSdkProviderAdministrator'))
{
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath))
    {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkProviderAdministrator.Recording.json'
    $currentPath = $PSScriptRoot
    while (-not $mockingPath)
    {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'New-JcSdkProviderAdministrator' -Tag:("MTP") {
    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        { $global:PesterTestProviderAdmin = New-JcsdkProviderAdministrator -Body $global:PesterDefProviderAdmin -ProviderId $env:JCProviderId } | Should -Not -Throw
        $global:PesterTestProviderAdmin | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

