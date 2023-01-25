BeforeAll {
    if (($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkSystemInsightSecureboot')) {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightSecureboot.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }


}
Describe 'Get-JcSdkSystemInsightSecureboot' -Tag:("") {
    It 'List' {
        { Get-JcSdkSystemInsightSecureboot } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siSecureBoot = Get-JcSdkSystemInsightSecureboot | Get-Random -Count 1
        if ($siSecureBoot) {
            Get-JcSdkSystemInsightSecureboot -Filter @("system_id:eq:$($siSecureBoot.systemId)") | Should -Not -BeNullOrEmpty
        }
    }
}
