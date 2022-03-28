BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkCustomEmailConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkCustomEmailConfiguration' -Tag:("")){
    It 'SetExpanded' {
        { Set-JcSdkCustomEmailConfiguration -CustomEmailType:($global:PesterTestCustomEmailConfiguration.Type) -Subject:($global:PesterTestCustomEmailConfiguration.Subject) -Type:($global:PesterTestCustomEmailConfiguration.Type) } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkCustomEmailConfiguration -CustomEmail:($global:PesterTestCustomEmailConfiguration) -CustomEmailType:($global:PesterTestCustomEmailConfiguration.Type) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkCustomEmailConfiguration -CustomEmail:($global:PesterTestCustomEmailConfiguration) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkCustomEmailConfiguration -InputObject '<IJumpCloudApIsIdentity>' -Subject:($global:PesterTestCustomEmailConfiguration.Subject) -Type:($global:PesterTestCustomEmailConfiguration.Type) [-Body '<String>'] [-Button '<String>'] [-Header '<String>'] [-NextStepContactInfo '<String>'] [-Title '<String>'] } | Should -Not -Throw
    }
}

