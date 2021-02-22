Describe 'Get-JcSdkSystemUser' {
    It 'List' {
        Get-JcSdkSystemUser | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $ListResults = Get-JcSdkSystemUser
        Get-JcSdkSystemUser -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
