<#
.Synopsis
This endpoint deletes a specific command result.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/commandresults/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ````
.Description
This endpoint deletes a specific command result.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/commandresults/{CommandID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ````
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

#>
Function Remove-JCCommandResult
{
    #Requires -Modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.ICommandresult])]
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
        $Results = Remove-JcSdkCommandResult @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
