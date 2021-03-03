$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkPolicy.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-JcSdkPolicy' {
    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        # Create a policy
        $global:WindowsPolicy = Get-JcSdkPolicyTemplate | ? { $_.OSMetaFamily -eq 'windows' } | Select-Object -Last 1
        $global:LinuxPolicy = Get-JcSdkPolicyTemplate | ? { $_.OSMetaFamily -eq 'linux' } | Select-Object -Last 1
        $global:DarwinPolicy = Get-JcSdkPolicyTemplate | ? { $_.OSMetaFamily -eq 'darwin' } | Select-Object -Last 1
        $global:PesterTestWindowsPolicy = New-jcsdkpolicy -TemplateId $WindowsPolicy.id -Name Pester_Windows
        $global:PesterTestLinuxPolicy = New-jcsdkpolicy -TemplateId $LinuxPolicy.id -Name Pester_Linux
        $global:PesterTestDarwinPolicy = New-jcsdkpolicy -TemplateId $DarwinPolicy.id -Name Pester_Darwin
    }
}
