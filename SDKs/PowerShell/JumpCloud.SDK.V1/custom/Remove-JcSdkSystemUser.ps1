<#
.Synopsis
This endpoint allows you to delete a particular system user.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/systemusers/{UserID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n```
.Description
This endpoint allows you to delete a particular system user.\n\n#### Sample Request\n```\ncurl -X DELETE https://console.jumpcloud.com/api/systemusers/{UserID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloud.SDK.V1.Models.ISystemuserreturn
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApIsIdentity>:
  [Id <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Remove-JcSdkSystemUser.md
#>
 Function Remove-JcSdkSystemUser
{
    [OutputType([JumpCloud.SDK.V1.Models.ISystemuserreturn])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

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
        $Results = JumpCloud.SDK.V1.internal\Remove-JcSdkInternalSystemUser @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

