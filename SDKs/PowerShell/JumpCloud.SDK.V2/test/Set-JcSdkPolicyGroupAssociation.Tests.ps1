BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkPolicyGroupAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkPolicyGroupAssociation' {
    It 'SetExpanded' -skip {
        $ParameterType = (Get-Command Set-JcSdkPolicyGroupAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkPolicyGroupAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkPolicyGroupAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GroupId:($global:PesterTestPolicyGroup.Id) } | Should -Not -Throw
            { Set-JcSdkPolicyGroupAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GroupId:($global:PesterTestPolicyGroup.Id) } | Should -Not -Throw
        }
    }

    It 'Set' -skip {
        $ParameterType = (Get-Command Set-JcSdkPolicyGroupAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkPolicyGroupAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkPolicyGroupAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GroupId:($global:PesterTestPolicyGroup.Id) } | Should -Not -Throw
            { Set-JcSdkPolicyGroupAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GroupId:($global:PesterTestPolicyGroup.Id) } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}

