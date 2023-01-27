BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightPythonPackage.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightPythonPackage' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightPythonPackage } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siPythonPkg = Get-JcSdkSystemInsightPythonPackage | Get-Random -Count 1
        if ($siPythonPkg) {
            Get-JcSdkSystemInsightPythonPackage -Filter @("system_id:eq:$($siPythonPkg.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightPythonPackage -Filter @("system_id:eq:$($siPythonPkg.systemId)", "name:eq:$($siPythonPkg.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkSystemInsightPythonPackage -Filter @("system_id:eq:$($siPythonPkg.systemId)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }
}

