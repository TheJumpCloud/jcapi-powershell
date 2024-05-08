BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkUserAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkUserAssociation' -Tag:(""){
    It 'SetExpanded' {
        $ParameterType = (Get-Command Set-JcSdkUserAssociation).Parameters.Type.ParameterType.FullName
        # skip routingPolicy association for now
        (Get-Command Set-JcSdkUserAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | Where-Object {$_ -notmatch "routing" } | ForEach-Object {
            { Set-JcSdkUserAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -UserId:($global:PesterTestUser.Id) } | Should -Not -Throw
            { Set-JcSdkUserAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -UserId:($global:PesterTestUser.Id) } | Should -Not -Throw
        }
    }

    It 'Set' {
        $ParameterType = (Get-Command Set-JcSdkUserAssociation).Parameters.Type.ParameterType.FullName
        # skip routingPolicy association for now
        (Get-Command Set-JcSdkUserAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | Where-Object {$_ -notmatch "routing" } | ForEach-Object {
            { Set-JcSdkUserAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -UserId:($global:PesterTestUser.Id) } | Should -Not -Throw
            { Set-JcSdkUserAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -UserId:($global:PesterTestUser.Id) } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkUserAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkUserAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-AttributeSudoEnabled] [-AttributeSudoWithoutPassword] } | Should -Not -Throw
    }
}

