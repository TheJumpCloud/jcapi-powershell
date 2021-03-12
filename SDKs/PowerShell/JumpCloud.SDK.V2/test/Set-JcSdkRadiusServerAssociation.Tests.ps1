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
        { Set-JcSdkRadiusServerAssociation -Id:($global:PesterTestUser.Id) -Op:('add') -RadiusserverId:($global:PesterTestRadiusserver.Id) -Type:('user') } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkRadiusServerAssociation -Body:($global:PesterTestRadiusServerAssociation) -RadiusserverId:($global:PesterTestRadiusserver.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkRadiusServerAssociation -Body:($global:PesterTestRadiusServerAssociation) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkRadiusServerAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
