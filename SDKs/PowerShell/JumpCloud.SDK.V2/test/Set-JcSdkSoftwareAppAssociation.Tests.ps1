$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSoftwareAppAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSoftwareAppAssociation' {
    It 'SetExpanded' -skip {
        { Set-JcSdkSoftwareAppAssociation -Id:($global:PesterTestSystem.Id) -Op:('add') -SoftwareAppId:($global:PesterTestSoftwareApp.Id) -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkSoftwareAppAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -SoftwareAppId:($global:PesterTestSoftwareApp.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSoftwareAppAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSoftwareAppAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}
