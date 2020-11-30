Describe 'Get-JcSdkSystemUserSshKey' {
    It 'List' {
        $SystemUser = (Get-JcSdkSystemUser)[0]
        If ([System.String]::IsNullOrEmpty($SystemUser.SshKeys))
        {
            New-JcSdkSystemUserSshKey -Id:($SystemUser.Id) -Name:('TestName') -PublicKey:('TestPublicKey')
            Start-Sleep 10
        }
        Get-JcSdkSystemUserSshKey -Id:($SystemUser.Id) | Should -Not -BeNullOrEmpty
    }
}