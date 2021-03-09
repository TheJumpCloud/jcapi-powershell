$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkPolicy' {
    It 'SetExpanded' -skip {
        { Set-JcSdkPolicy -Id '<String>' -Name '<String>' [-TemplateId '<String>'] [-Values '<IPolicyValue[]>'] } | Should -Not -Throw
    }

    It 'Set' -skip {
        { Set-JcSdkPolicy -Body '<IPolicyRequest>' -Id '<String>' } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkPolicy -Body '<IPolicyRequest>' -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkPolicy -InputObject '<IJumpCloudApIsIdentity>' -Name '<String>' [-TemplateId '<String>'] [-Values '<IPolicyValue[]>'] } | Should -Not -Throw
    }
}
