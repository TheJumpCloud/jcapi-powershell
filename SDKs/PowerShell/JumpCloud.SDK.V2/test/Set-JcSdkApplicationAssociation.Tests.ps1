$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkApplicationAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkApplicationAssociation' {
    It 'SetExpanded' {
        Set-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -Id:($global:PesterTestUser.Id) -Op:('add') -Type:('user')
        Get-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -targets:('user') | Should -Not -BeNullOrEmpty

        Set-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -Id:($global:PesterTestUser.Id) -Op:('remove') -Type:('user')
        Get-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -targets:('user') | Should -BeNullOrEmpty
    }

    It 'Set' {
        $PesterDefAssociation = @{
            Id   = $global:PesterTestUser.Id;
            Op   = 'add';
            Type = 'user';
            Attributes = @{};
        }
        Set-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -Body $PesterDefAssociation
        Get-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -targets:('user') | Should -Not -BeNullOrEmpty

        $PesterDefAssociation.Op = 'remove'
        Set-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -Body $PesterDefAssociation
        Get-JcSdkApplicationAssociation -ApplicationId $($global:PesterTestApplication.id) -targets:('user') | Should -BeNullOrEmpty
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
