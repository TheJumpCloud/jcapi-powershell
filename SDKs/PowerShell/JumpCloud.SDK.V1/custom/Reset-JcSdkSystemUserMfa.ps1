<#
.Synopsis
This endpoint allows you to reset the TOTP key for a specified system user and put them in an TOTP MFA enrollment period.
This will result in the user being prompted to setup TOTP MFA when logging into userportal.
Please be aware that if the user does not complete TOTP MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require TOTP MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.
\n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'\n  \n\n```
.Description
This endpoint allows you to reset the TOTP key for a specified system user and put them in an TOTP MFA enrollment period.
This will result in the user being prompted to setup TOTP MFA when logging into userportal.
Please be aware that if the user does not complete TOTP MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require TOTP MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.
\n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'\n  \n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Inputs
JumpCloud.SDK.V1.Models.IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema>: 
  [Exclusion <Boolean?>]: 
  [ExclusionUntil <DateTime?>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v1/reset-jcsdksystemusermfa
#>
 Function Reset-JcSdkSystemUserMfa
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='ResetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Reset', Mandatory)]
    [Parameter(ParameterSetName='ResetExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='ResetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ResetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Reset', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ResetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IPathsYhix24SystemusersIdResetmfaPostRequestbodyContentApplicationJsonSchema]
    # .
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ResetExpanded')]
    [Parameter(ParameterSetName='ResetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Exclusion},

    [Parameter(ParameterSetName='ResetExpanded')]
    [Parameter(ParameterSetName='ResetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${ExclusionUntil},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Reset-JcSdkInternalSystemUserMfa @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

