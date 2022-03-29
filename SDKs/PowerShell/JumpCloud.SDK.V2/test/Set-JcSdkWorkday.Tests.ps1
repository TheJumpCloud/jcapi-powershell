BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkWorkday.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'Set-JcSdkWorkday' {
    It 'SetExpanded' -skip {
        { Set-JcSdkWorkday -Id:($global:PesterTestWorkday.Id) } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkWorkday -Body:($global:PesterTestWorkday) -Id:($global:PesterTestWorkday.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkWorkday -Body:($global:PesterTestWorkday) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkWorkday -InputObject '<IJumpCloudApIsIdentity>' [-Name '<String>'] [-ReportUrl '<String>'] } | Should -Not -Throw
    }
}

