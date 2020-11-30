Describe 'Get-JcSdkCommand' {
    It 'List' {
        Get-JcSdkCommand | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $ListResults = Get-JcSdkCommand
        Get-JcSdkCommand -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
