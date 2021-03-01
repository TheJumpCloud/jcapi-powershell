function RandomString([bool]$allChars, [int32]$len)
{
    if ($allChars)
    {
        return -join ((33..126) | Get-Random -Count $len | ForEach-Object { [char]$_ })
    }
    else
    {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | ForEach-Object { [char]$_ })
    }
}
$env = @{}
function setupEnv()
{
    # For any resources you created for test, you should add it to $env here.
    $envFile = 'env.json'
    if ($TestMode -eq 'live')
    {
        $envFile = 'localEnv.json'
    }
    Set-Content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)

    # Generate random string
    $RandStr = RandomString -len 5
    ########################################################################
    # TODO
    ########################################################################
    # Get-JcSdkApplication
    # Get-JcSdkApplicationTemplate
    # Get-JcSdkCommandFile
    # Get-JcSdkCommandResult
    ########################################################################
    # V1
    ########################################################################
    # Create a command
    $Command = @{
        Name    = 'PesterTestCommand'
        Command = 'echo "Hello World"'
        User    = '000000000000000000000000'
    }
    $global:PesterTestCommand = New-JcSdkCommand @Command

    # Create a user
    $User = @{Username = "pester.test.$($RandStr)"
        FirstName      = "Pester"
        LastName       = "Test"
        Password       = "Testing123!"
        Email          = "pester.test@example$($RandStr).com"
    }
    $global:PesterTestUser = New-JcSdkUser @User
    # Create a user ssh key
    $UserSshKey = @{
        Id        = $global:PesterTestUser.Id
        Name      = 'PesterTestUserSshKeyName'
        PublicKey = 'PesterTestUserSshKeyPublicKey'
    }
    $global:PesterTestUserSshKey = New-JcSdkUserSshKey @UserSshKey
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

    # Get organization
    $global:PesterTestOrganization = Get-JcSdkOrganization
    # Get a System
    $global:PesterTestSystem = Get-JcSdkSystem | Select-Object -First 1
    # ########################################################################
    # # V2
    # ########################################################################
    # # Create a User Group
    # $global:UserGroupName = "PesterTestUserGroup"
    # New-JcSdkUserGroup -Name:($global:UserGroupName)
    # $global:PesterTestUserGroup = Get-JcSdkUserGroup | Where-Object { $_.Name -eq $global:UserGroupName }

    # # Create a System Group
    # $global:SystemGroupName = "PesterTestSystemGroup"
    # New-JcSdkSystemGroup -Name:($global:SystemGroupName)
    # $global:PesterTestSystemGroup = Get-JcSdkSystemGroup | Where-Object { $_.Name -eq $global:SystemGroupName }

    # # Create an Active Directory Object
    # $global:ActiveDirectoryName = "DC=ADTEST$(RandomString -len 6);DC=ORG"
    # $Headers = @{
    #     'Accept'    = 'application/json';
    #     'x-api-key' = $JCApiKey
    # }
    # $Form = @{
    #     'domain' = $global:ActiveDirectoryName;
    # } | ConvertTo-Json
    # Invoke-WebRequest -Method 'POST' -Uri "https://console.jumpcloud.com/api/v2/activedirectories" -Headers $Headers -Body $Form -ContentType 'application/json' -UseBasicParsing
    # $global:PesterTestActiveDirectory = Get-JcSdkActiveDirectory | Where-Object { $_.Domain -eq $global:ActiveDirectoryName }
}
function cleanupEnv()
{
    # Clean resources you create for testing
    Remove-JcSdkUser -Id:($global:PesterTestUser.Id)
    Remove-JcSdkUserGroup -Id:($global:PesterTestUserGroup.Id)
    Remove-JcSdkSystemGroup -Id:($global:PesterTestSystemGroup.Id)
    Remove-JcSdkRadiusServer -Id:($global:PesterTestRadiusServer.Id)

    # Delete an Active Directory Object
    $Headers = @{
        'Accept'    = 'application/json';
        'x-api-key' = $JCApiKey
    }
    Invoke-WebRequest -Method 'DELETE' -Uri "https://console.jumpcloud.com/api/v2/activedirectories/$($global:PesterTestActiveDirectory.Id)" -Headers $Headers -ContentType 'application/json' -UseBasicParsing

}