BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightManagedPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightManagedPolicy' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightManagedPolicy } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siManagedPolicy = Get-JcSdkSystemInsightManagedPolicy | Get-Random -Count 1
        if ($siManagedPolicy) {
            Get-JcSdkSystemInsightManagedPolicy -Filter @("system_id:eq:$($siManagedPolicy.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightManagedPolicy -Filter @("system_id:eq:$($siManagedPolicy.systemId)", "domain:eq:$($siManagedPolicy.domain)") | Should -Not -BeNullOrEmpty
            # domain accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightManagedPolicy -Filter @("system_id:eq:$($siManagedPolicy.systemId)", "domain:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

