$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkIPList.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-JcSdkIPList' {
    BeforeAll {
        $IpList = @{
            Description = 'PesterIpList'
            Ips         = '0.1.2.4'
            Name        = 'Pester IP Test List'
        }
    }
    It 'SetExpanded' {
        { Set-JcSdkIPList -Id:($global:PesterIPList.Id) -Ips:($IpList.Ips) -Name:($IpList.Name) -Description:($IpList.Description) } | Should -Not -Throw
    }

    It 'Set' {
        $IpList.Ips = '0.1.2.5'
        { Set-JcSdkIPList -Id:($global:PesterIPList.Id) -Body:($IpList) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
