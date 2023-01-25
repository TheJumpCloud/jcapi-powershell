BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Get-JcSdkApplicationTemplate.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-JcSdkApplicationTemplate' -Tag:(""){
    It 'List' {
        { Get-JcSdkApplicationTemplate } | Should -Not -Throw
    }

    It 'List Filter Tests' {
        $appTemplate = Get-JcSdkApplicationTemplate | Get-Random -Count 1
        Get-JcSdkApplicationTemplate -Filter @("name:`$eq:$($appTemplate.Name)") | Should -Not -BeNullOrEmpty
        Get-JcSdkApplicationTemplate -Filter @("name:`$eq:$($appTemplate.Name)xx") | Should -BeNullOrEmpty

        # multiple Filter Tests
        Get-JcSdkApplicationTemplate -Filter @("name:`$eq:$($appTemplate.Name)", "_id:`$eq:$($appTemplate.Id)") | Should -Not -BeNullOrEmpty
        Get-JcSdkApplicationTemplate -Filter @("name:`$eq:$($appTemplate.Name)", "_id:`$eq:181434648125485878639646") | Should -BeNullOrEmpty
        Get-JcSdkApplicationTemplate -Filter @("name:`$eq:$($appTemplate.Name)", "_id:`$ne:181434648125485878639646") | Should -Not -BeNullOrEmpty

    }

    It 'Get' {
        { Get-JcSdkApplicationTemplate -Id:($global:PesterTestApplicationTemplate.Id) } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { Get-JcSdkApplicationTemplate -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
