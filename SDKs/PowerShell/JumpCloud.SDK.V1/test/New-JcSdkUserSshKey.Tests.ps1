BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-JcSdkUserSshKey.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-JcSdkUserSshKey' -Tag:(""){
    It 'CreateExpanded' {
        $global:PesterDefUserSshKey.Id = $global:PesterTestUser.Id
        # pass in some random values for the name and public key
        $name = "newKeyName" + $(Get-Random -Maximum 1000000)
        $publicKey = "ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKNyuXv0JBV2Ph7IqvRUI30zRlIHAX1Q7TWePswBCTdG test@test"
        $global:PesterTestUserSshKey = New-JcSdkUserSshKey -id @global:PesterDefUserSshKey -Name $name -PublicKey $publicKey
        $global:PesterTestUserSshKey | Should -Not -BeNullOrEmpty
    }

    It 'Create' -skip {
        { New-JcSdkUserSshKey -Body:($global:PesterTestUser) -Id:($global:PesterTestUser.Id) } | Should -Not -Throw
    }

    It 'CreateViaIdentity' -skip {
        { New-JcSdkUserSshKey -Body:($global:PesterTestUser) -InputObject '<IJumpCloudApIsIdentity>' } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -skip {
        { New-JcSdkUserSshKey -InputObject '<IJumpCloudApIsIdentity>' -Name:($global:PesterTestUser.Name) -PublicKey '<String>' } | Should -Not -Throw
    }
}
