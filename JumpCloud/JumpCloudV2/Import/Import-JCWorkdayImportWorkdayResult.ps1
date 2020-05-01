<#
.Synopsis
This endpoint provides a list of job results from the workday import and will contain all imported data from Workday.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import/{ImportJobID}/results \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
This endpoint provides a list of job results from the workday import and will contain all imported data from Workday.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/workdays/{WorkdayID}/import/{ImportJobID}/results \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

#>
Function Import-JCWorkdayImportWorkdayResult
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IJobWorkresult])]
    [CmdletBinding(DefaultParameterSetName='Import', PositionalBinding=$false)]
    Param(
    [Parameter(ParameterSetName='Import', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='Import', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${JobId},

    [Parameter(ParameterSetName='ImportViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # The number of records to return at once.
    # Limited to 100.
    ${Limit},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # The offset into the records to return.
    ${Skip}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Import-JcSdkWorkdayImportWorkdayResult @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
