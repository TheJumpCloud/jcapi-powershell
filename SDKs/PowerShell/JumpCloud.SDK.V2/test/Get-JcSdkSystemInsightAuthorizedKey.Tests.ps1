BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightAuthorizedKey.Recording.json'
    $currentPath = $PSScriptRoot
    while (-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightAuthorizedKey' -Tag:("") {
    It 'List' {
        { Get-JcSdkSystemInsightAuthorizedKey } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siAuthKey = Get-JcSdkSystemInsightAuthorizedKey | Get-Random -Count 1
        if ($siAuthKey) {
            Get-JcSdkSystemInsightAuthorizedKey -Filter @("system_id:eq:$($siAuthKey.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightAuthorizedKey -Filter @("system_id:eq:$($siAuthKey.systemId)", "uid:eq:$($siAuthKey.uid)") | Should -Not -BeNullOrEmpty
            # uid accepts ints, 9988 is a fake value
            Get-JcSdkSystemInsightAuthorizedKey -Filter @("system_id:eq:$($siAuthKey.systemId)", "uid:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

