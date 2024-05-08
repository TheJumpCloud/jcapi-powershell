BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkUserGroupAssociation' -Tag:(""){
    It 'SetExpanded' {
        $ParameterType = (Get-Command Set-JcSdkUserGroupAssociation).Parameters.Type.ParameterType.FullName
        # skip routingPolicy associations for now
        (Get-Command Set-JcSdkUserGroupAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | Where-Object {$_ -notmatch "routing" } | ForEach-Object {
            { Set-JcSdkUserGroupAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
            { Set-JcSdkUserGroupAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
        }
    }

    It 'Set' {
        $ParameterType = (Get-Command Set-JcSdkUserGroupAssociation).Parameters.Type.ParameterType.FullName
        # skip routingPolicy associations for now
        (Get-Command Set-JcSdkUserGroupAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | Where-Object {$_ -notmatch "routing" } | ForEach-Object {
            { Set-JcSdkUserGroupAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
            { Set-JcSdkUserGroupAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GroupId:($global:PesterTestUserGroup.Id) } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserGroupAssociation -Body:(@{Id = $global:PesterTestSystemGroup.Id; Op = 'add'; Type = 'system_group';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserGroupAssociation -Id:($global:PesterTestSystemGroup.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system_group') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

