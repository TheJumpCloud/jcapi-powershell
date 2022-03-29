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
        $ParameterType = (Get-Command Set-JcSdkSoftwareAppAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkSoftwareAppAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkSoftwareAppAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -SoftwareAppId:($global:PesterTestSoftwareApp.Id) } | Should -Not -Throw
            { Set-JcSdkSoftwareAppAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -SoftwareAppId:($global:PesterTestSoftwareApp.Id) } | Should -Not -Throw
        }
    }

    It 'Set' {
        $ParameterType = (Get-Command Set-JcSdkSoftwareAppAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkSoftwareAppAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkSoftwareAppAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -SoftwareAppId:($global:PesterTestSoftwareApp.Id) } | Should -Not -Throw
            { Set-JcSdkSoftwareAppAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -SoftwareAppId:($global:PesterTestSoftwareApp.Id) } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSoftwareAppAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSoftwareAppAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

