BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkApplication.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkApplication' -Tag:(""){
    It 'List' {
        { Get-JcSdkApplication } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $app = Get-JcSdkApplication | Select-Object -First 1
        # Test single conditions
        $NameEQ = Get-JcsdkApplication -Filter @("displayName:`$eq:$($app.DisplayName)")
        $NameEQ | Should -Not -BeNullOrEmpty
        $NameNE = Get-JcsdkApplication -Filter @("displayName:`$ne:$($app.DisplayName)")
        $nameNE  | Should -Not -BeNullOrEmpty
        $nameNE | Should -Not -Contain $NameEQ
        # Multiple Filter Conditions
        Get-JcsdkApplication -Filter @("displayName:`$eq:$($app.DisplayName)", "_id:`$eq:$($app.Id)") | Should -Not -BeNullOrEmpty
        Get-JcsdkApplication -Filter @("displayName:`$eq:$($app.DisplayName)", "_id:`$eq:$($app.Organization)") | Should -BeNullOrEmpty
    }

    It 'Get' {
        { Get-JcSdkApplication -Id:($global:PesterTestApplication.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkApplication -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
