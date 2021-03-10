$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath))
{
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkCommandTrigger.Recording.json'
$currentPath = $PSScriptRoot
while (-not $mockingPath)
{
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-JcSdkCommandTrigger' {
    It 'Post' {
        $global:PesterTestCommandTrigger = Invoke-JcSdkCommandTrigger @global:PesterDefCommandTrigger
        $global:PesterTestCommandTrigger | Should -Not -BeNullOrEmpty
    }

    It 'PostViaIdentity' -Skip {
        Invoke-JcSdkCommandTrigger -InputObject '<IJumpCloudApIsIdentity>' | Should -Not -BeNullOrEmpty
    }
}
