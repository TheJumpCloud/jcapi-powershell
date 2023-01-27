BeforeAll {
    if (($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkSystemInsightTpmInfo')) {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightTpmInfo.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }


}
Describe 'Get-JcSdkSystemInsightTpmInfo' -Tag:("") {
    It 'List' {
        { Get-JcSdkSystemInsightTpmInfo } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siTPM = Get-JcSdkSystemInsightTpmInfo | Get-Random -Count 1
        if ($siTPM) {
            Get-JcSdkSystemInsightTpmInfo -Filter @("system_id:eq:$($siTPM.systemId)") | Should -Not -BeNullOrEmpty
        }
    }
}
