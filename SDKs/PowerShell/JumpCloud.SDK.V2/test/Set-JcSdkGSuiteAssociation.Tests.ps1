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

Describe 'Set-JcSdkGSuiteAssociation' {
    It 'SetExpanded' {
        { Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGSuite.Id) -Id:($global:PesterTestUser.Id) -Op:('add') -Type:('user') } | Should -Not -Throw
        { Set-JcSdkGSuiteAssociation -GsuiteId $($global:PesterTestGSuite.Id) -Id:($global:PesterTestUser.Id) -Op:('remove') -Type:('user') } | Should -Not -Throw
    }

    It 'Set' {
        $PesterDefAssociation = @{
            Id         = $global:PesterTestUser.Id
            Op         = 'add'
            Type       = 'user'
            Attributes = @{}
        }
        { Set-JcSdkGSuiteAssociation -GsuiteId:($global:PesterTestGSuite.Id) -Body:($PesterDefAssociation) } | Should -Not -Throw
        $PesterDefAssociation.Op = 'remove'
        { Set-JcSdkGSuiteAssociation -GsuiteId:($global:PesterTestGSuite.Id) -Body:($PesterDefAssociation) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
