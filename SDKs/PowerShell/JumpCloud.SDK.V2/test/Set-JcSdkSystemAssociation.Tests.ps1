$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystemAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystemAssociation' {
    # TODO: Update for PolicyGroups
    #It 'SetExpanded' {
    #    $ParameterType = (Get-Command Set-JcSdkSystemAssociation).Parameters.Type.ParameterType.FullName
    #    (Get-Command Set-JcSdkSystemAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
    #        { Set-JcSdkSystemAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -SystemId:($global:PesterTestSystem.Id) } | Should -Not -Throw
    #        { Set-JcSdkSystemAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -SystemId:($global:PesterTestSystem.Id) } | Should -Not -Throw
    #    }
    #}

    #It 'Set' {
    #    $ParameterType = (Get-Command Set-JcSdkSystemAssociation).Parameters.Type.ParameterType.FullName
    #    (Get-Command Set-JcSdkSystemAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
    #        { Set-JcSdkSystemAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -SystemId:($global:PesterTestSystem.Id) } | Should -Not -Throw
    #        { Set-JcSdkSystemAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -SystemId:($global:PesterTestSystem.Id) } | Should -Not -Throw
    #    }
    #}

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystemAssociation -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add'; Type = 'user';}) -InputObject '<IJumpCloudApIsIdentity>' [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystemAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-AttributeSudoEnabled] [-AttributeSudoWithoutPassword] [-Authorization '<String>'] [-Date '<String>'] } | Should -Not -Throw
    }
}
