function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
$env = @{}
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    #### $env.SubscriptionId = (Get-AzContext).Subscription.Id
    #### $env.Tenant = (Get-AzContext).Tenant.Id
    # For any resources you created for test, you should add it to $env here.
    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)

    # Create a user
    $global:Username = "pester.test"
    $global:FirstName = "Pester"
    $global:LastName = "Test"
    $global:Password = "Testing123!"
    $global:Email = "pester.test@example.com"
    New-JcSdkUser -Username:($global:Username) -FirstName:($global:FirstName) -LastName:($global:LastName) -Password:($global:Password) -Email:($global:Email)
    $global:PesterTestUser = Get-JcSdkUser | ? { $_.username -eq $global:Username }

    # Create a User Group
    $global:UserGroupName = "PesterTestUserGroup"
    New-JcSdkUserGroup -Name:($global:UserGroupName)
    $global:PesterTestUserGroup = Get-JcSdkUserGroup | ? { $_.Name -eq $global:UserGroupName }

    # Create a System Group
    $global:SystemGroupName = "PesterTestSystemGroup"
    New-JcSdkSystemGroup -Name:($global:SystemGroupName)
    $global:PesterTestSystemGroup = Get-JcSdkSystemGroup | ? { $_.Name -eq $global:SystemGroupName }

    # Select a System
    $global:PesterTestSystem = Get-JCSdkSystem | Select -First 1

    # Create a RADIUS Server
    $global:RadiusServerName = "PesterTest"
    $global:SharedSecret = "Testing123!"
    $octet1 = 0
    $octet2 = 0
    $octet3 = 0
    $octet4 = 0
    DO
    {
        $global:PesterTestRadiusServer = New-JcSdkRadiusServer -Name:("$global:RadiusServerName") -SharedSecret:($global:SharedSecret) -NetworkSourceIP:("$($octet1).$($octet2).$($octet3).$($octet4)")
        if ([System.String]::IsNullOrEmpty($global:PesterTestRadiusServer))
        {
            if ($octet4 -lt 255) {
                $octet4++
            } elseif ($octet3 -lt 244) {
                $octet4 = 0
                $octet3++
            } elseif ($octet2 -lt 244) {
                $octet3 = 0
                $octet2++
            } elseif ($octet1 -lt 244) {
                $octet2 = 0
                $octet1++
            } elseif ($octet1 -eq 255) {
                Write-Error "Unable to configure RADIUS server - no valid IP Addresses."
            }
        }
    } WHILE ([System.String]::IsNullOrEmpty($global:PesterTestRadiusServer))
    $Global:RadiusIPAddress = "$($octet1).$($octet2).$($octet3).$($octet4)"

}
function cleanupEnv() {
    # Clean resources you create for testing
    Remove-JcSdkUser -Id:($global:PesterTestUser.Id)
    Remove-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id)
    Remove-JcSdkSystemGroup -Id:($global:PesterTestSystemGroup.Id)
    Remove-JcSdkRadiusServer -Id:($global:PesterTestRadiusServer.Id)
}