$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkCommand.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkCommand' {
    It 'SetExpanded' -skip {
        { Set-JcSdkCommand -Command '<String>' -Id:($global:PesterTestCommand.Id) } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkCommand -Body:($global:PesterTestCommand) -Id:($global:PesterTestCommand.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkCommand -Body:($global:PesterTestCommand) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkCommand -Command '<String>' -InputObject '<IJumpCloudApIsIdentity>' [-CommandRunners '<String[]>'] [-CommandType '<String>'] [-Files '<String[]>'] [-LaunchType '<String>'] [-ListensTo '<String>'] [-Name '<String>'] [-Organization '<String>'] [-Schedule '<String>'] [-ScheduleRepeatType '<String>'] [-Shell '<String>'] [-Sudo] [-Systems '<String[]>'] [-Timeout '<String>'] [-Trigger '<String>'] [-User '<String>'] } | Should -Not -Throw
    }
}
