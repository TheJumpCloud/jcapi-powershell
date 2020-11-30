Describe 'Get-JcSdkRadiusServer' {
    It 'List' {
        Get-JcSdkRadiusServer | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $ListResults = Get-JcSdkRadiusServer
        Get-JcSdkRadiusServer -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
