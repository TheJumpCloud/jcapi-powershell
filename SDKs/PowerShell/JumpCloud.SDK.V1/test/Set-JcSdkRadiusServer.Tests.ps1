$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkRadiusServer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkRadiusServer' {
    It 'SetExpanded' -skip {
        { Set-JcSdkRadiusServer -Id:($global:PesterTestRadiusServer.Id) -Name '<String>' -NetworkSourceIP '<String>' -SharedSecret '<String>' [-Mfa '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkRadiusServer -Body '<IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema>' -Id:($global:PesterTestRadiusServer.Id)  } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkRadiusServer -Body '<IPathsKeqea5RadiusserversIdPutRequestbodyContentApplicationJsonSchema>' -InputObject '<IJumpCloudApIsIdentity>'  } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkRadiusServer -InputObject '<IJumpCloudApIsIdentity>' -Name '<String>' -NetworkSourceIP '<String>' -SharedSecret '<String>' [-Mfa '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }
}
