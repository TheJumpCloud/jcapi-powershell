$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkOffice365Association.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkOffice365Association' {
    It 'SetExpanded' -skip {
        { Set-JcSdkOffice365Association -Id:($global:PesterTestOffice365Association.Id) -Office365Id:($global:PesterTestOffice365.Id) -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkOffice365Association -Body '<IGraphOperationOffice365>' -Office365Id:($global:PesterTestOffice365.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkOffice365Association -Body '<IGraphOperationOffice365>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkOffice365Association -Id:($global:PesterTestOffice365Association.Id) -InputObject '<IJumpCloudApIsIdentity>' -Op '<String>' -Type '<String>' } | Should -Not -Throw
    }
}
