$global:PesterTestSystemUserName = 'PesterTestSystemUser'
$global:PesterTestSystemUserEmail = 'PesterTest@PesterTest.com'
Describe 'New-JcSdkSystemUser' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $SystemUser = Get-JcSdkSystemUser | Where-Object { $_.Username -eq $global:PesterTestSystemUserName }
        If ($SystemUser)
        {
            Remove-JcSdkSystemUser -Id:($SystemUser.Id)
        }
        New-JcSdkSystemUser -Email:($global:PesterTestSystemUserEmail) -Username:($global:PesterTestSystemUserName)  | Should -Not -BeNullOrEmpty
    }
}
