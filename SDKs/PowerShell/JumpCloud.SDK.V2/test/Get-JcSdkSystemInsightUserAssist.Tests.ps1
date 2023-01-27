BeforeAll {
    if (($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkSystemInsightUserAssist')) {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightUserAssist.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }


}
Describe 'Get-JcSdkSystemInsightUserAssist' -Tag:("") {
    It 'List' {
        { Get-JcSdkSystemInsightUserAssist } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siUserAssist = Get-JcSdkSystemInsightUserAssist | Get-Random -Count 1
        if ($siUserAssist) {
            Get-JcSdkSystemInsightUserAssist -Filter @("system_id:eq:$($siUserAssist.systemId)") | Should -Not -BeNullOrEmpty
        }
    }
}
