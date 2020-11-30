Describe 'Get-JcSdkApplication' {
    It 'List' {
        Get-JcSdkApplication | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $ListResults = Get-JcSdkApplication
        Get-JcSdkApplication -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
