$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkApplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkApplication' {
    It 'SetExpanded' -skip {
        { Set-JcSdkApplication -Id:($global:PesterTestApplication.Id) [-Beta] [-Color '<String>'] [-Config '<IApplicationConfig>'] [-Created '<String>'] [-DatabaseAttributes '<IApplicationDatabaseAttributesItem[]>'] [-Description '<String>'] [-DisplayLabel '<String>'] [-DisplayName '<String>'] [-Id1 '<String>'] [-LearnMore '<String>'] [-LogoColor '<String>'] [-LogoUrl '<String>'] [-Name '<String>'] [-Organization '<String>'] [-SsoBeta] [-SsoJit] [-SsoType '<String>'] [-SsoUrl '<String>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkApplication -Body:($global:PesterTestApplication) -Id:($global:PesterTestApplication.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkApplication -InputObject '<IJumpCloudApIsIdentity>' [-Beta] [-Color '<String>'] [-Config '<IApplicationConfig>'] [-Created '<String>'] [-DatabaseAttributes '<IApplicationDatabaseAttributesItem[]>'] [-Description '<String>'] [-DisplayLabel '<String>'] [-DisplayName '<String>'] [-Id '<String>'] [-LearnMore '<String>'] [-LogoColor '<String>'] [-LogoUrl '<String>'] [-Name '<String>'] [-Organization '<String>'] [-SsoBeta] [-SsoJit] [-SsoType '<String>'] [-SsoUrl '<String>'] } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkApplication -Body:($global:PesterTestApplication) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }
}
