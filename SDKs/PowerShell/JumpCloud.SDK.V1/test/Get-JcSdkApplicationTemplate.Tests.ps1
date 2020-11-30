Describe 'Get-JcSdkApplicationTemplate' {
    It 'List' {
        Get-JcSdkApplicationTemplate | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $ListResults = Get-JcSdkApplicationTemplate
        Get-JcSdkApplicationTemplate -Id:($ListResults[0].Id) | Should -Not -BeNullOrEmpty
    }

    It 'GetViaIdentity' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
