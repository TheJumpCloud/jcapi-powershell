BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkDuoApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkDuoApplication' -Tag:("")){
    It 'SetExpanded' -skip {
        { Set-JcSdkDuoApplication -AccountId '<String>' -ApiHost '<String>' -ApplicationId:($global:PesterTestApplication.Id) -IntegrationKey '<String>' -Name:($global:PesterTestDuoApplication.Name) } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkDuoApplication -AccountId '<String>' -ApplicationId:($global:PesterTestApplication.Id) -Body:($global:PesterTestDuoApplication) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkDuoApplication -Body:($global:PesterTestDuoApplication) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkDuoApplication -ApiHost '<String>' -InputObject '<IJumpCloudApIsIdentity>' -IntegrationKey '<String>' -Name:($global:PesterTestDuoApplication.Name) [-SecretKey '<String>'] } | Should -Not -Throw
    }
}

