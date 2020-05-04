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
.Link
https://github.com/TheJumpCloud/support/wiki/New-JCDuoAccount
#>
Function New-JCDuoAccount
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IDuoAccount])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(

    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkDuoAccount @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
