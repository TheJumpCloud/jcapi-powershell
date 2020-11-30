$PesterTestSystemUserName = 'PesterTestSystemUser'
$PesterTestSystemUserEmail = 'PesterTest@PesterTest.com'
Describe 'New-JcSdkSystemUser' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $SystemUser = Get-JcSdkSystemUser | Where-Object { $_.Username -eq $PesterTestSystemUserName }
        If ($SystemUser)
        {
            Remove-JcSdkSystemUser -Id:($SystemUser.Id)
        }
        New-JcSdkSystemUser -Email:($PesterTestSystemUserEmail) -Username:($PesterTestSystemUserName)  | Should -Not -BeNullOrEmpty
    }
}
