BeforeAll {
if(($null -eq $TestName) -or ($TestName -contains 'Reset-JcSdkAdministratorUserTotp'))
{
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Reset-JcSdkAdministratorUserTotp.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}


}
Describe 'Reset-JcSdkAdministratorUserTotp' -Tag:("MTP"){
    It 'Reset' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
        # Tested locally, activation emails are sent, not testing automatically to prevent unauthorized access
    }

    It 'ResetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
