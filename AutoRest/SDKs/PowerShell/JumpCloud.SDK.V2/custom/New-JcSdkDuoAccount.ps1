<#
.Synopsis
Registers a Duo account for an organization.
Only one Duo account will be allowed,\nin case an organization has a Duo account already a 409 (Conflict) code will be returned.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```
.Description
Registers a Duo account for an organization.
Only one Duo account will be allowed,\nin case an organization has a Duo account already a 409 (Conflict) code will be returned.\n\n#### Sample Request\n```\n  curl -X POST https://console.jumpcloud.com/api/v2/duo/accounts \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IDuoAccount
.Outputs
System.String
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/new-jcsdkduoaccount
#>
 Function New-JcSdkDuoAccount
{
    [OutputType([JumpCloud.SDK.V2.Models.IDuoAccount], [System.String])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(

    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V2.internal\New-JcSdkInternalDuoAccount @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

