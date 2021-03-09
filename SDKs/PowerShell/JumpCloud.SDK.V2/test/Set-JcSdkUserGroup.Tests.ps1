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

Describe 'Set-JcSdkUserGroup' {
    It 'SetExpanded' -skip {
        { Set-JcSdkUserGroup -Id '<String>' -Name '<String>' [-AttributeLdapGroups '<IGraphAttributeLdapGroupsItem[]>'] [-AttributePosixGroups '<IGraphAttributePosixGroupsItem[]>'] [-AttributeRadiusReply '<IGraphAttributeRadiusReplyItem[]>'] [-AttributeSambaEnabled] [-Description '<String>'] [-Email '<String>'] [-MemberQueryFilters '<IFilter[]>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkUserGroup -Body '<IUserGroupPut>' -Id '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroup -Body '<IUserGroupPut>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroup -InputObject '<IJumpCloudApIsIdentity>' -Name '<String>' [-AttributeLdapGroups '<IGraphAttributeLdapGroupsItem[]>'] [-AttributePosixGroups '<IGraphAttributePosixGroupsItem[]>'] [-AttributeRadiusReply '<IGraphAttributeRadiusReplyItem[]>'] [-AttributeSambaEnabled] [-Description '<String>'] [-Email '<String>'] [-MemberQueryFilters '<IFilter[]>'] } | Should -Not -Throw
    }
}
