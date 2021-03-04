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

Describe 'Get-JcSdkAppleMdmEnrollmentProfile' {
    It 'List' -skip {
        # TODO: this should return a file
        # TODO: ID of MDM enrollment profile is same id of $($global:PesterAppleMDM.id) and last number is one value greater
        # ex. if AppleMDMID == 5f93256663336c45c3c1e892; AppleMdmEnrollmentProfileID == 5f93256663336c45c3c1e893
        Get-JcSdkAppleMdmEnrollmentProfile -AppleMdmId $($global:PesterAppleMDM.id) -id 5f93256663336c45c3c1e893
    }

    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
