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
    It 'SetExpanded' -Skip {
        { Set-JcSdkSystem -Id '<String>' [-AgentBoundMessages '<ISystemputAgentBoundMessagesItem[]>'] [-AllowMultiFactorAuthentication] [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin] [-DisplayName '<String>'] } | Should -Not -Throw
    }

    It 'Set' -Skip {
        { Set-JcSdkSystem -Body '<ISystemput>' -Id '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -Skip {
        { Set-JcSdkSystem -Body '<ISystemput>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -Skip {
        { Set-JcSdkSystem -InputObject '<IJumpCloudApIsIdentity>' [-AgentBoundMessages '<ISystemputAgentBoundMessagesItem[]>'] [-AllowMultiFactorAuthentication] [-AllowPublicKeyAuthentication] [-AllowSshPasswordAuthentication] [-AllowSshRootLogin] [-DisplayName '<String>'] } | Should -Not -Throw
    }
}
