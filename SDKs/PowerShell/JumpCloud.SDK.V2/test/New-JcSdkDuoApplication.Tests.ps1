BeforeAll {
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


}
Describe 'New-JcSdkDuoApplication' -Tag:("")){
    It 'CreateExpanded' -skip {
        $global:PesterTestDuoApplication = New-JcSdkDuoApplication @global:PesterDefDuoApplication
        $global:PesterTestDuoApplication | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkDuoApplication -AccountId '<String>' -Body:($global:PesterTestDuoApplication) } | Should -Not -Throw
    }

    It 'CreateViaIdentity' -skip {
        { New-JcSdkDuoApplication -Body:($global:PesterTestDuoApplication) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { New-JcSdkDuoApplication -ApiHost '<String>' -InputObject '<IJumpCloudApIsIdentity>' -IntegrationKey '<String>' -Name:($global:PesterTestDuoApplication.Name) -SecretKey '<String>' } | Should -Not -Throw
    }
}

