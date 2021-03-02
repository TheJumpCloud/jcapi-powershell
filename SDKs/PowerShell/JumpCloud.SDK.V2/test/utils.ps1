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
    $global:Email = "pester.test$(RandomString -len 6)@example.com"
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
     # Create a RADIUS Server
    $RadiusServer = @{
        Name            = "PesterTestRadiusServer"
        SharedSecret    = "Testing123!"
        NetworkSourceIP = [IPAddress]::Parse([String](Get-Random)).IPAddressToString
    }
    Do
    {
        $global:PesterTestRadiusServer = New-JcSdkRadiusServer @RadiusServer
    } While ([System.String]::IsNullOrEmpty($global:PesterTestRadiusServer))

    # Create an Active Directory Object
    $global:ActiveDirectoryName = "DC=ADTEST$(RandomString -len 6);DC=ORG"
    $Headers = @{
        'Accept'    = 'application/json';
        'x-api-key' = $env:JCApiKey
    }
    $Form = @{
        'domain'   = $global:ActiveDirectoryName;
    } | ConvertTo-Json
    Invoke-WebRequest -Method 'Post' -Uri "https://console.jumpcloud.com/api/v2/activedirectories" -Headers $Headers -Body $Form -ContentType 'application/json' -UseBasicParsing
    $global:PesterTestActiveDirectory = Get-JcSdkActiveDirectory| ? { $_.Domain -eq $global:ActiveDirectoryName }

    # Get the Apple MDM
    $global:PesterAppleMDM = Get-JcSdkAppleMdm

    # Create Application
    # TODO: Switch from select to new
    $global:PesterTestApplication = Get-JcSdkApplication | Select -First 1

    # Create Authentication Policy
    $global:PesterTestAuthenticationPolicy = New-JcSdkAuthenticationPolicy -Name "AuthenticationPolicy-$(RandomString -len 7)" -EffectAction allow -TargetResources @{"type" = "user_portal" } -UserGroupInclusions $($global:PesterTestUserGroup.id)

    # Create a command
    $Command = @{
        Name    = 'PesterTestCommand'
        Command = 'echo "Hello World"'
        User    = '000000000000000000000000'
    }
    # #TODO #BUG Swagger for New-JcSdkCommand does not return an id
    $NewCommand = New-JcSdkCommand @Command
    $global:PesterTestCommand = Get-JcSdkCommand | Where-Object { $_.Name -eq $NewCommand.Name }

    # Create New IP List
    $IpList = @{
        Description    = 'PesterIpList'
        Ips = '0.1.2.3'
        Name    = 'Pester IP Test List'
    }
    $global:PesterIPList = new-jcsdkIpList @IpList

    # Get LDAP Server
    $global:PesterLdapServer = Get-JcSdkLdapServer
}
    # Get all Directories
    $global:PesterTestDirectories = Get-JcSdkDirectory
    $global:PesterTestGSuite = $global:PesterTestDirectories | ? { $_.type -eq "g_suite" } | Select -First 1
    $global:PesterTestOffice365 = $global:PesterTestDirectories | ? { $_.type -eq "office_365" } | Select -First 1
    $global:PesterTestLdap = $global:PesterTestDirectories | ? { $_.type -eq "ldap_server" } | Select -First 1

    # Get an Application
    $global:PesterTestApplication = Get-JcSdkApplication | Select -First 1
    }
function cleanupEnv() {
    # Clean resources you create for testing
    Remove-JcSdkUser -Id:($global:PesterTestUser.Id)
    Remove-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id)
    Remove-JcSdkSystemGroup -Id:($global:PesterTestSystemGroup.Id)
    Remove-JcSdkRadiusServer -Id:($global:PesterTestRadiusServer.Id)

    # Delete an Active Directory Object
    $Headers = @{
        'Accept'    = 'application/json';
        'x-api-key' = $env:JCApiKey
    }
    Invoke-WebRequest -Method 'Delete' -Uri "https://console.jumpcloud.com/api/v2/activedirectories/$($global:PesterTestActiveDirectory.Id)" -Headers $Headers -ContentType 'application/json' -UseBasicParsing

    # Delete Authentication Policy
    Remove-JcSdkAuthenticationPolicy -id $($global:PesterTestAuthenticationPolicy.id)
}