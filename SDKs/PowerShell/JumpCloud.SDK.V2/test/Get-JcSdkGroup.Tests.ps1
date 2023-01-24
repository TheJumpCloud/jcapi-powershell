BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkGroup' -Tag:(""){
    It 'List' {
        { Get-JcSdkGroup } | Should -Not -Throw
    }
    It 'List Group Filter Tests' {
        $group = Get-JcSdkGroup | Get-Random -Count 1
        Get-JcSdkGroup -Filter @("name:eq:$($group.name)") | Should -Not -BeNullOrEmpty
        Get-JcSdkGroup -Filter @("name:eq:$($group.name)", "type:eq:$($group.type)") | Should -Not -BeNullOrEmpty
        Get-JcSdkGroup -Filter @("name:eq:fakeName") | Should -BeNullOrEmpty
    }
}

