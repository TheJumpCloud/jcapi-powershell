BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'Set-JcSdkRadiusServer.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Set-JcSdkRadiusServer' -Tag:(""){
    It 'SetExpanded' -skip {
        { Set-JcSdkRadiusServer -Id:($global:PesterTestRadiusServer.Id) -Name:($global:PesterTestRadiusServer.Name) -NetworkSourceIP '<String>' -SharedSecret '<String>' } | Should -Not -Throw
    }

    It 'Set' {
        { Set-JcSdkRadiusServer -Body:($global:PesterTestRadiusServer) -Id:($global:PesterTestRadiusServer.Id) } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { Set-JcSdkRadiusServer -Body:($global:PesterTestRadiusServer) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'SetViaIdentityExpanded' -skip {
        { Set-JcSdkRadiusServer -InputObject '<IJumpCloudApIsIdentity>' -Name:($global:PesterTestRadiusServer.Name) -NetworkSourceIP '<String>' -SharedSecret '<String>' [-Mfa '<String>'] [-UserLockoutAction '<String>'] [-UserPasswordExpirationAction '<String>'] } | Should -Not -Throw
    }
}
