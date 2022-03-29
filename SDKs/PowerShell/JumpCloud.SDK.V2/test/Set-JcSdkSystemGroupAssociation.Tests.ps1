BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkSystemGroupAssociation' -Tag:(""){
    
    # TODO: Update for PolicyGroups
    #It 'SetExpanded' {
    #    $ParameterType = (Get-Command Set-JcSdkSystemGroupAssociation).Parameters.Type.ParameterType.FullName
    #    (Get-Command Set-JcSdkSystemGroupAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
    #        { Set-JcSdkSystemGroupAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GroupId:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    #        { Set-JcSdkSystemGroupAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GroupId:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    #    }
    #}

    #It 'Set' {
    #    $ParameterType = (Get-Command Set-JcSdkSystemGroupAssociation).Parameters.Type.ParameterType.FullName
    #    (Get-Command Set-JcSdkSystemGroupAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
    #        { Set-JcSdkSystemGroupAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GroupId:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    #        { Set-JcSdkSystemGroupAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GroupId:($global:PesterTestSystemGroup.Id) } | Should -Not -Throw
    #    }
    #}

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemGroupAssociation -Body:(@{Id = $global:PesterTestUserGroup.Id; Op = 'add'; Type = 'user_group';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemGroupAssociation -Id:($global:PesterTestUserGroup.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user_group') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

