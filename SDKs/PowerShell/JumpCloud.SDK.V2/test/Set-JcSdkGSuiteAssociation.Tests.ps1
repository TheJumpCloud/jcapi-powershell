BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkGSuiteAssociation.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkGSuiteAssociation' -Tag:("")){
    It 'SetExpanded' {
        $ParameterType = (Get-Command Set-JcSdkGSuiteAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkGSuiteAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkGSuiteAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('add') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GSuiteId:($global:PesterTestGSuite.Id) } | Should -Not -Throw
            { Set-JcSdkGSuiteAssociation -Id:((Get-Variable -Name:("PesterTest$($_)")).Value.Id) -Op:('remove') -Type:(Invoke-Expression "[$ParameterType]::$_".Replace('group','_group')) -GSuiteId:($global:PesterTestGSuite.Id) } | Should -Not -Throw
        }
    }

    It 'Set' {
        $ParameterType = (Get-Command Set-JcSdkGSuiteAssociation).Parameters.Type.ParameterType.FullName
        (Get-Command Set-JcSdkGSuiteAssociation).Parameters.Type.ParameterType.DeclaredFields.Where( { $_.IsPublic }).Name | ForEach-Object {
            { Set-JcSdkGSuiteAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'add'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GSuiteId:($global:PesterTestGSuite.Id) } | Should -Not -Throw
            { Set-JcSdkGSuiteAssociation -Body:(@{Id = (Get-Variable -Name:("PesterTest$($_)")).Value.Id; Op = 'remove'; Type = Invoke-Expression "[$ParameterType]::$_".Replace('group','_group'); }) -GSuiteId:($global:PesterTestGSuite.Id) } | Should -Not -Throw
        }
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkGSuiteAssociation -Body:(@{Id = $global:PesterTestUser.Id; Op = 'add'; Type = 'user';}) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkGSuiteAssociation -Id:($global:PesterTestUser.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op:('add') -Type:('user') [-Attributes '<Hashtable>'] } | Should -Not -Throw
    }
}

