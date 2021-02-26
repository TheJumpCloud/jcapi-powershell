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

}
function cleanupEnv() {
    # Clean resources you create for testing
    Remove-JcSdkUser -Id:($global:PesterTestUser.Id)

    Remove-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id)
    Remove-JcSdkSystemGroup -Id:($global:PesterTestSystemGroup.Id)
}