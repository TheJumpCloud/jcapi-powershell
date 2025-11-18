BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkCommandAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkCommandAssociation' -Tag:(""){
    It 'SetExpanded' {
        # get a command
        $command = Get-JCsdkCommand | Select-Object -First 1
        # get some user group
        $group = get-jcsdkSystemGroup | Select-Object -First 1
        {Set-JcSdkCommandAssociation -CommandId $command.Id -Op 'add' -Type 'system_group' -id $group.Id} | Should -Not -Throw
        {Set-JcSdkCommandAssociation -CommandId $command.Id -Op 'remove' -Type 'system_group' -id $group.Id} | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkCommandAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkCommandAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

