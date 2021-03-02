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
    ########################################################################
    # TODO
    ########################################################################
    # (Get-Command -Syntax -Name Invoke-JcSdkCommandTrigger) | ForEach-Object { $_.Replace('[-Fields <string>]', '').Replace('[-Filter <string>]', '').Replace('[-Sort <string>]', '').Replace('[-Search <string>]', '').Replace('[-Paginate <bool>]', '').Replace('[-Break]', '').Replace('[-HttpPipelineAppend <SendAsyncStep[]>]', '').Replace('[-HttpPipelinePrepend <SendAsyncStep[]>]', '').Replace('[-PassThru]', '').Replace('[-Proxy <uri>]', '').Replace('[-ProxyCredential <pscredential>]', '').Replace('[-ProxyUseDefaultCredentials]', '').Replace('[<CommonParameters>]', '').Replace('[-WhatIf]', '').Replace('[-Confirm]', '') }
    # Get-JcSdkApplication
    # Get-JcSdkApplicationTemplate
    # Get-JcSdkCommandFile
    # Get-JcSdkCommandResult
    ########################################################################
    # V1
    ########################################################################
    # Create a command
    $global:PesterDefCommand = @{
        Name    = 'PesterTestCommand'
        Command = 'echo "Hello World"'
        User    = '000000000000000000000000'
    }
    # Create a user
    $global:PesterDefUser = @{
        Username  = "pester.test.$(RandomString -len 5)"
        FirstName = "Pester"
        LastName  = "Test"
        Password  = "Testing123!"
        Email     = "pester.test@example$(RandomString -len 5).com"
    }
    # Create a user ssh key
    $global:PesterDefUserSshKey = @{
        Id        = $null # Defined later in New-JcSdkUserSshKey.Tests.ps1
        Name      = 'PesterTestUserSshKeyName'
        PublicKey = 'PesterTestUserSshKeyPublicKey'
    }
    # Create a RADIUS Server
    $global:PesterDefRadiusServer = @{
        Name            = "PesterTestRadiusServer"
        SharedSecret    = "Testing123!"
        NetworkSourceIP = [IPAddress]::Parse([String](Get-Random)).IPAddressToString
    }
    # Get organization
    $global:PesterTestOrganization = Get-JcSdkOrganization
    # Get a System
    $global:PesterTestSystem = Get-JcSdkSystem | Select-Object -First 1
}
function cleanupEnv()
{
    ########################################################################
    # V1
    ########################################################################
    # Remove Commands
    $null = Get-JcSdkCommand | ForEach-Object { Remove-JcSdkCommand -Id:($_.Id) }
    # Remove Users and SSH Keys
    $null = Get-JcSdkUser | ForEach-Object {
        $UserId = $_.Id
        If ( $_.ExternallyManaged )
        {
            Set-JcSdkUser -Id:($UserId) -ExternallyManaged:($false)
        }
        If ($_.SshKeys)
        {
            $_.SshKeys | ForEach-Object {
                Remove-JcSdkUserSshKey -Id:($_.Id) -SystemuserId:($UserId)
            }
        }
        Remove-JcSdkUser -Id:($UserId)
    }
    # Remove RADIUS Servers
    $null = Get-JcSdkRadiusServer | ForEach-Object { Remove-JcSdkRadiusServer -Id:($_.Id) }
}