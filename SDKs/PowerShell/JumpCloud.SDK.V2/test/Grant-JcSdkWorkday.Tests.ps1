$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Grant-JcSdkWorkday.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Grant-JcSdkWorkday' {
    It 'AuthorizeExpanded' -skip {
        { Grant-JcSdkWorkday -WorkdayId '<String>' [-BasicPassword '<String>'] [-BasicUsername '<String>'] [-OauthCode '<String>'] } | Should -Not -Throw
    }

    It 'Authorize' -skip {
        { Grant-JcSdkWorkday -Body:($global:PesterTestWorkday) -WorkdayId '<String>' } | Should -Not -Throw
    }

    It 'AuthorizeViaIdentity' -skip {
        { Grant-JcSdkWorkday -Body:($global:PesterTestWorkday) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'AuthorizeViaIdentityExpanded' -skip {
        { Grant-JcSdkWorkday -InputObject '<IJumpCloudApIsIdentity>' [-BasicPassword '<String>'] [-BasicUsername '<String>'] [-OauthCode '<String>'] } | Should -Not -Throw
    }
}
