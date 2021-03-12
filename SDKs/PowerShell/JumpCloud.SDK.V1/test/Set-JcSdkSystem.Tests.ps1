$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkSystem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkSystem' {
    It 'SetExpanded' -skip {
        { Set-JcSdkSystem -Id:($global:PesterTestSystem.Id) [-AgentBoundMessages '<ISystemputAgentBoundMessagesItem[]>'] [-AllowMultiFactorAuthentication] [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin] [-DisplayName '<String>'] } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkSystem -Body:($global:PesterTestSystem) -Id:($global:PesterTestSystem.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkSystem -Body:($global:PesterTestSystem) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkSystem -InputObject '<IJumpCloudApIsIdentity>' [-AgentBoundMessages '<ISystemputAgentBoundMessagesItem[]>'] [-AllowMultiFactorAuthentication] [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin] [-DisplayName '<String>'] } | Should -Not -Throw
    }
}
