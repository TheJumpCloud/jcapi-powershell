BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkUserGroup' -Tag:(""){
    It 'CreateExpanded Static' {
        $global:PesterTestUserGroup = New-JcSdkUserGroup @global:PesterDefUserGroupStatic
        $global:PesterTestUserGroup | Should -Not -BeNullOrEmpty
    }
    It 'CreateExpanded Filter' {
        $global:PesterTestUserGroupFilter = New-JcSdkUserGroup @global:PesterDefUserGroupFilter
        $global:PesterTestUserGroupFilter | Should -Not -BeNullOrEmpty
    }
    It 'CreateExpanded Search' {
        $global:PesterTestUserGroupSearch = New-JcSdkUserGroup @global:PesterDefUserGroupSearch
        $global:PesterTestUserGroupSearch | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkUserGroup -Body:($global:PesterTestUserGroup) } | Should -Not -Throw
    }
}

