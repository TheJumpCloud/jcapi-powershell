Describe 'Get-JcSdkOrganization' {
    It 'List' {
        Get-JcSdkOrganization | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $ListResults = Get-JcSdkOrganization
        Get-JcSdkOrganization -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
