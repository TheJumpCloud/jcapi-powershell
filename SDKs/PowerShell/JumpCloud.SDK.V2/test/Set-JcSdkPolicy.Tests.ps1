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
    It 'PutExpanded' {
        { Set-JcSdkPolicy -Id:($global:PesterTestWindowsPolicy.Id) -Name:('Pester_Windows_Modified') -TemplateId:($global:WindowsPolicy.Id) } | Should -Not -Throw
    }

    It 'Put' {
        $PesterDefPolicy = @{
            Name       = 'Pester_Windows'
            TemplateId = $global:WindowsPolicy.Id
        }
        { Set-JcSdkPolicy -Id:($global:PesterTestWindowsPolicy.Id) -Body:($PesterDefPolicy) } | Should -Not -Throw
    }

    It 'PutViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PutViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
