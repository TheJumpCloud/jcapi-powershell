BeforeAll {
    if (($null -eq $TestName) -or ($TestName -contains 'Get-JcSdkSystemInsightLinuxPackage')) {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightLinuxPackage.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }


}
Describe 'Get-JcSdkSystemInsightLinuxPackage' -Tag:("") {
    It 'List' {
        { Get-JcSdkSystemInsightLinuxPackage } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siLinuxPackage = Get-JcSdkSystemInsightLinuxPackage | Get-Random -Count 1
        if ($siLinuxPackage) {
            Get-JcSdkSystemInsightLinuxPackage -Filter @("system_id:eq:$($siLinuxPackage.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightLinuxPackage -Filter @("system_id:eq:$($siLinuxPackage.systemId)", "package_format:eq:$($siLinuxPackage.packageFormat)") | Should -Not -BeNullOrEmpty
            # package_format accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightLinuxPackage -Filter @("system_id:eq:$($siLinuxPackage.systemId)", "package_format:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}
