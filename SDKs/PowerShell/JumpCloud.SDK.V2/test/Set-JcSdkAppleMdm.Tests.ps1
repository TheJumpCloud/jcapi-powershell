$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkAppleMdm.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkAppleMdm' {
    It 'SetExpanded' -skip {
        { Set-JcSdkAppleMdm -Id '<String>' [-AppleSignedCert '<String>'] [-DefaultSystemGroupId '<String>'] [-DepEnableZeroTouchEnrollment] [-DepSetupAssistantOptions '<IDepSetupAssistantOption[]>'] [-EncryptedDepServerToken '<String>'] [-Name '<String>'] [-WelcomeScreenButton '<String>'] [-WelcomeScreenParagraph '<String>'] [-WelcomeScreenTitle '<String>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkAppleMdm -Body '<IAppleMdmPatchInput>' -Id '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkAppleMdm -Body '<IAppleMdmPatchInput>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkAppleMdm -InputObject '<IJumpCloudApIsIdentity>' [-AppleSignedCert '<String>'] [-DefaultSystemGroupId '<String>'] [-DepEnableZeroTouchEnrollment] [-DepSetupAssistantOptions '<IDepSetupAssistantOption[]>'] [-EncryptedDepServerToken '<String>'] [-Name '<String>'] [-WelcomeScreenButton '<String>'] [-WelcomeScreenParagraph '<String>'] [-WelcomeScreenTitle '<String>'] } | Should -Not -Throw
    }
}
