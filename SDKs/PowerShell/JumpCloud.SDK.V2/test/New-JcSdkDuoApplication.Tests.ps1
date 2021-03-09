$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkDuoApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkDuoApplication' {
    It 'CreateExpanded' -skip {
        $global:PesterTestDuoApplication = New-JcSdkDuoApplication @global:PesterDefDuoApplication
        $global:PesterTestDuoApplication | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        New-JcSdkDuoApplication -AccountId '<String>' -Body '<IDuoApplicationReq>' | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentity' -skip {
        New-JcSdkDuoApplication -Body '<IDuoApplicationReq>' -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentityExpanded' -skip {
        New-JcSdkDuoApplication -ApiHost '<String>' -InputObject '<IJumpCloudApIsIdentity>' -IntegrationKey '<String>' -Name '<String>' -SecretKey '<String>' | Should -Not -BeNullOrEmpty
    }
}
