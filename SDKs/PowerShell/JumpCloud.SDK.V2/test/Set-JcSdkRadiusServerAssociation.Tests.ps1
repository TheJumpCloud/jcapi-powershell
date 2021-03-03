$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkRadiusServerAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkRadiusServerAssociation' {
    It 'SetExpanded' {
        { Set-JcSdkRadiusServerAssociation -RadiusserverId:($global:PesterTestRadiusServer.id) -Id:($global:PesterTestUser.Id) -Op:('add') -Type:('user') } | Should -Not -Throw
    }

    It 'Set' {
        $PesterDefAssociation = @{
            Id   = $global:PesterTestUser.Id
            Op   = 'remove'
            Type = 'user'
        }
        { Set-JcSdkRadiusServerAssociation -RadiusserverId:($global:PesterTestRadiusServer.id) -Body:($PesterDefAssociation) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
