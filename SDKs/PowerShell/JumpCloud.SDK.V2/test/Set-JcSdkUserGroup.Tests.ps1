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
    It 'PutExpanded' {
        # TODO: implement these:
        # skip this because you can't edit things you make this change
        # Set-JcSdkUserGroup -Id $($global:PesterTestUserGroup.Id) -AttributePosixGroups @{id = '123'; name = 'test' }
        # Set-JcSdkUserGroup -Id $($global:PesterTestUserGroup.Id) -AttributeSambaEnabled
        # Set-JcSdkUserGroup -Id $($global:PesterTestUserGroup.Id) -AttributeRadiusReply @{name = '604000c1ca7c80b4cc8b6a41'; value = '604000c1ca7c80b4cc8b6a41' } -Name PesterTestUserGroup
        # Set-JcSdkUserGroup -Id $($global:PesterTestUserGroup.Id) -AttributeLdapGroups @(name='string'; type='string'; value='test') -Name PesterTestUserGroup}
        # TODO: Unexpected error shows up but doesn't throw
        { Set-JcSdkUserGroup -Id $($global:PesterTestUserGroup.Id) -Name "PesterTestUserGroup" -Email "example" -Description "example" } | Should -Not -Throw
    }

    It 'Put' {
        $body = @{
            Name        = 'PesterTestUserGroup'
            Email       = 'example'
            Description = 'example'
            # AttributePosixGroups = @{id = '123'; name = 'test' }
        }
        { Set-JcSdkUserGroup -Id $($global:PesterTestUserGroup.Id) -Body $body } | Should -Not -Throw
    }

    It 'PutViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PutViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
