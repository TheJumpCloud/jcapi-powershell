BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkPolicyAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkPolicyAssociation' -Tag:(""){
    It 'SetExpanded' {
        $ParameterType = (Get-Command Set-JcSdkPolicyAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkPolicyAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkPolicyAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -PolicyId:($global:PesterTestPolicy.Id) } | Should -Not -Throw
            { Set-JcSdkPolicyAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -PolicyId:($global:PesterTestPolicy.Id) } | Should -Not -Throw
        }
    }

    It 'Set' {
        $ParameterType = (Get-Command Set-JcSdkPolicyAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkPolicyAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkPolicyAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -PolicyId:($global:PesterTestPolicy.Id) } | Should -Not -Throw
            { Set-JcSdkPolicyAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -PolicyId:($global:PesterTestPolicy.Id) } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkPolicyAssociation -Body:(@{Id = $global:PesterTestSystem.Id; Op = 'add'; Type = 'system';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkPolicyAssociation -Id:($global:PesterTestSystem.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('system') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

