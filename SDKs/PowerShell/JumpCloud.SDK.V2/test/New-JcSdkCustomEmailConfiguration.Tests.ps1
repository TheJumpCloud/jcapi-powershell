BeforeAll {
$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkCustomEmailConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


}
Describe 'New-JcSdkCustomEmailConfiguration' -Tag:("") -skip{
    It 'CreateExpanded' {
        # this action is only available for paying customers
        $global:PesterTestCustomEmailConfiguration = New-JcSdkCustomEmailConfiguration -body $global:PesterDefCustomEmailConfiguration
        $global:PesterTestCustomEmailConfiguration | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkCustomEmailConfiguration -CustomEmail:($global:PesterTestCustomEmailConfiguration) } | Should -Not -Throw
    }
}

