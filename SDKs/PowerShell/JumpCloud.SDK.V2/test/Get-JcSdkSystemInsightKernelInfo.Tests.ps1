BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightKernelInfo.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightKernelInfo' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightKernelInfo } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siKernelInfo = Get-JcSdkSystemInsightKernelInfo | Get-Random -Count 1
        if ($siKernelInfo) {
            Get-JcSdkSystemInsightKernelInfo -Filter @("system_id:eq:$($siKernelInfo.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightKernelInfo -Filter @("system_id:eq:$($siKernelInfo.systemId)", "device:eq:$($siKernelInfo.device)") | Should -Not -BeNullOrEmpty
            # device accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightKernelInfo -Filter @("system_id:eq:$($siKernelInfo.systemId)", "device:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

