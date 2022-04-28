BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkActiveDirectoryAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkActiveDirectoryAssociation' -Tag:(""){
    It 'SetExpanded' {
        $ParameterType = (Get-Command Set-JcSdkActiveDirectoryAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkActiveDirectoryAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkActiveDirectoryAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -ActiveDirectoryId:($global:PesterTestActiveDirectory.Id) } | Should -Not -Throw
            { Set-JcSdkActiveDirectoryAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -ActiveDirectoryId:($global:PesterTestActiveDirectory.Id) } | Should -Not -Throw
        }
    }

    It 'Set' {
        $ParameterType = (Get-Command Set-JcSdkActiveDirectoryAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkActiveDirectoryAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkActiveDirectoryAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -ActiveDirectoryId:($global:PesterTestActiveDirectory.Id) } | Should -Not -Throw
            { Set-JcSdkActiveDirectoryAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -ActiveDirectoryId:($global:PesterTestActiveDirectory.Id) } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add'; Type = 'user';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkActiveDirectoryAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

