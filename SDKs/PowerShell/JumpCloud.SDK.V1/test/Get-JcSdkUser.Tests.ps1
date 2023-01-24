BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkUser.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkUser' -Tag:(""){
    It 'List' {
        { Get-JcSdkUser } | Should -Not -Throw
    }

    It 'List User Filter Tests'{
        $user = Get-JcSdkUser | Get-Random -count 1
        Get-jcsdkuser -filter @("firstname:`$eq:$($user.firstname)") | should -not -BeNullOrEmpty
        Get-jcsdkuser -filter @("firstname:`$eq:$($user.firstname)", "company:`$eq:$($user.company)") | should -not -BeNullOrEmpty
        Get-jcsdkuser -filter @("firstname:`$eq:$($user.firstname)", "company:`$eq:fakeCompany") | should -BeNullOrEmpty
    }

    It 'Get' {
        { Get-JcSdkUser -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkUser -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
