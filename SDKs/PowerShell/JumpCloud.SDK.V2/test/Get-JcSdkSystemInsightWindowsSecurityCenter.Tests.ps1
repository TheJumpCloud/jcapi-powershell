BeforeAll {
    if (($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkSystemInsightWindowsSecurityCenter')) {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightWindowsSecurityCenter.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }


}
Describe 'Get-JcSdkSystemInsightWindowsSecurityCenter' -Tag:("") {
    It 'List' {
        { Get-JcSdkSystemInsightWindowsSecurityCenter } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siWinSecurity = Get-JcSdkSystemInsightWindowsSecurityCenter | Get-Random -Count 1
        if ($siWinSecurity) {
            Get-JcSdkSystemInsightWindowsSecurityCenter -Filter @("system_id:eq:$($siWinSecurity.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightWindowsSecurityCenter -Filter @("system_id:eq:$($siWinSecurity.systemId)", "antivirus:eq:$($siWinSecurity.antivirus)") | Should -Not -BeNullOrEmpty
            # antivirus accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightWindowsSecurityCenter -Filter @("system_id:eq:$($siWinSecurity.systemId)", "antivirus:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}
