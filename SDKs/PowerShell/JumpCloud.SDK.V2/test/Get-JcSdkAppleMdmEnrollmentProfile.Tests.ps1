BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkAppleMdmEnrollmentProfile.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkAppleMdmEnrollmentProfile' -Tag:(""){
    It 'List' -skip {
        { Get-JcSdkAppleMdmEnrollmentProfile -AppleMdmId:($global:PesterTestAppleMdm.Id) } | Should -Not -Throw
    }

    It 'Get' -skip {
        { Get-JcSdkAppleMdmEnrollmentProfile -AppleMdmId:($global:PesterTestAppleMdm.Id) -Id:($global:PesterTestAppleMdmEnrollmentProfile.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkAppleMdmEnrollmentProfile -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

