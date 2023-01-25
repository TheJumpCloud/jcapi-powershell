BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkUserGroup' -Tag:(""){
    It 'List' {
        { Get-JcSdkUserGroup } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $group = Get-JcSdkUserGroup | Get-Random -Count 1
        if ($group) {
            Get-JcSdkUserGroup -Filter @("type:eq:$($group.type)") | Should -Not -BeNullOrEmpty
            Get-JcSdkUserGroup -Filter @("type:eq:$($group.type)", "name:eq:$($group.name)") | Should -Not -BeNullOrEmpty
            # name accepts strings, fakeString is a fake value
            Get-JcSdkUserGroup -Filter @("type:eq:$($group.type)", "name:eq:fakeString") | Should -BeNullOrEmpty
        }
    }

    It 'Get' {
        { Get-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkUserGroup -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

