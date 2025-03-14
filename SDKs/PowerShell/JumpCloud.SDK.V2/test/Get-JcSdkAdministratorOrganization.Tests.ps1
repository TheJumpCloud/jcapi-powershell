BeforeAll {
    if (($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkAdministratorOrganization'))
    {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath))
        {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAdministratorOrganization.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath)
        {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }


}
Describe 'Get-JcSdkAdministratorOrganization' -Tag:("MTP") -Skip {
    It 'List' {
        $ProviderAdmins = Get-JCSDKProviderAdministrator -ProviderID $env:JCProviderId
        { Get-JcSdkAdministratorOrganization -Id:(($ProviderAdmins | Select-Object -First 1).Id) } | Should -Not -Throw
    }
}

