BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkUserGroup' -Tag:(""){
    It 'SetExpanded' {
        { Set-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id) -Name:($global:PesterTestUserGroup.Name) -MemberQueryFilters:($global:PesterTestUserGroup.MemberQueryFilters) } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserGroup -Body:($global:PesterTestUserGroup) -Id:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroup -Body:($global:PesterTestUserGroup) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroup -InputObject '<IJumpCloudApIsIdentity>' -Name:($global:PesterTestUserGroup.Name) [-AttributeLdapGroups '<IGraphAttributeLdapGroupsItem[]>'] [-AttributePosixGroups '<IGraphAttributePosixGroupsItem[]>'] [-AttributeRadiusReply '<IGraphAttributeRadiusReplyItem[]>'] [-AttributeSambaEnabled] [-Description '<String>'] [-Email '<String>'] [-MemberQueryFilters '<IFilter[]>'] } | Should -Not -Throw
    }
}

