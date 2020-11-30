$PesterTestRadiusServerName = 'PesterTestRadiusServerName'
$PesterTestRadiusServerIp = '211.211.211.211'
$PesterTestSharedSecret = 'PesterTestSharedSecret'
Describe 'New-JcSdkRadiusServer' {
    It 'CreateExpanded' -Skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        $RadiusServer = Get-JcSdkRadiusServer | Where-Object { $_.Name -eq $PesterTestRadiusServerName -or $_.NetworkSourceIP -eq $PesterTestRadiusServerIp }
        If ($RadiusServer)
        {
            Remove-JcSdkRadiusServer -Id:($RadiusServer.Id)
        }
        New-JcSdkRadiusServer -Name:($PesterTestRadiusServerName) -NetworkSourceIP:($PesterTestRadiusServerIp) -SharedSecret:($PesterTestSharedSecret) | Should -Not -BeNullOrEmpty
    }
}
