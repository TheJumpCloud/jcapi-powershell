$global:PesterTestSystemUserSshKeyName = 'PesterTestSystemUserSshKeyName'
$global:PesterTestSystemUserSshKeyPublicKey = 'PesterTestSystemUserSshKeyPublicKey'
Describe 'New-JcSdkSystemUserSshKey' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $SystemUser = (Get-JcSdkSystemUser)[0]
        $SshKey = Get-JcSdkSystemUserSshKey -Id:($SystemUser.Id)
        If (-not [System.String]::IsNullOrEmpty($SshKey))
        {
            $SshKey.Id | ForEach-Object {
                Remove-JcSdkSystemUserSshKey -Id:($_) -SystemuserId:($SystemUser.Id)
            }
        }
        New-JcSdkSystemUserSshKey -Id:($SystemUser.Id) -Name:($global:PesterTestSystemUserSshKeyName) -PublicKey:($global:PesterTestSystemUserSshKeyPublicKey) | Should -Not -BeNullOrEmpty
    }

    It 'CreateViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
