BeforeAll {
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


}
Describe 'Set-JcSdkSoftwareAppAssociation' -Tag:(""){
    It 'SetExpanded' {
        # get some system group
        $group = get-jcsdksystemGroup | Select-Object -First 1
        {Set-JcSdkSoftwareAppAssociation -SoftwareAppId $global:PesterTestSoftwareApp.Id -Op 'add' -Type 'system_group' -id $group.Id} | Should -Not -Throw
        {Set-JcSdkSoftwareAppAssociation -SoftwareAppId $global:PesterTestSoftwareApp.Id -Op 'remove' -Type 'system_group' -id $group.Id} | Should -Not -Throw

    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSoftwareAppAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSoftwareAppAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

