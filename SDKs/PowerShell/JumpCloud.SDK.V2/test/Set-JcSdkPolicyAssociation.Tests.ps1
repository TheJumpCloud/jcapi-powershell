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

Describe 'Set-JcSdkPolicyAssociation' {
    It 'SetExpanded' {
        { Set-JcSdkPolicyAssociation -PolicyId:($global:PesterTestWindowsPolicy.Id) -Id:($global:PesterTestSystem.Id) -Op:('add') -Type:('system') } | Should -Not -Throw
    }

    It 'Set' {
        $PesterDefAssociation = @{
            Id   = $global:PesterTestSystem.Id
            Op   = 'remove'
            Type = 'system'
        }
        { Set-JcSdkPolicyAssociation -PolicyId:($global:PesterTestWindowsPolicy.Id) -Body:($PesterDefAssociation) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
