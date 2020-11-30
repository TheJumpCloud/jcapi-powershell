Describe 'Get-JcSdkCommandResult' {
    It 'List' {
        Get-JcSdkCommandResult | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $ListResults = Get-JcSdkCommandResult
        Get-JcSdkCommandResult -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
