BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkSystemInsightUserSshKey.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkSystemInsightUserSshKey' -Tag:(""){
    It 'List' {
        { Get-JcSdkSystemInsightUserSshKey } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $siUserSSH = Get-JcSdkSystemInsightUserSshKey | Get-Random -Count 1
        if ($siUserSSH) {
            Get-JcSdkSystemInsightUserSshKey -Filter @("system_id:eq:$($siUserSSH.systemId)") | Should -Not -BeNullOrEmpty
            Get-JcSdkSystemInsightUserSshKey -Filter @("system_id:eq:$($siUserSSH.systemId)", "uid:eq:$($siUserSSH.uid)") | Should -Not -BeNullOrEmpty
            # uid accepts int, 9988 is a fake value
            Get-JcSdkSystemInsightUserSshKey -Filter @("system_id:eq:$($siUserSSH.systemId)", "uid:eq:9988") | Should -BeNullOrEmpty
        }
    }
}

