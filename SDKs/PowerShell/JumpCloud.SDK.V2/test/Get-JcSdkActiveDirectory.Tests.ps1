BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkActiveDirectory.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Get-JcSdkActiveDirectory' -Tag:(""){
    It 'List' {
        { Get-JcSdkActiveDirectory } | Should -Not -Throw
    }

    It 'List AD Filter Tests'{
        $ad = Get-JcSdkActiveDirectory | Get-Random -Count 1
        Get-JcSdkActiveDirectory -Filter @("domain:eq:$($ad.domain)") | Should -Not -BeNullOrEmpty
        Get-JcSdkActiveDirectory -Filter @("domain:eq:$($ad.domain)", "domain:eq:fakedomain") | Should -BeNullOrEmpty
    }

    It 'Get' {
        { Get-JcSdkActiveDirectory -Id:($global:PesterTestActiveDirectory.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkActiveDirectory -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}

