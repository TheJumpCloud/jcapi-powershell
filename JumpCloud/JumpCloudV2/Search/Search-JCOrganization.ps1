<#
.Synopsis
This endpoint will return Organization data based on your search parameters.
This endpoint WILL NOT allow you to add a new Organization.\n\nYou can use the supported parameters and pass those in the body of request.
\n\nThe parameters must be passed as Content-Type application/json.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/search/organizations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"search\":{\n    \"fields\" : [\"settings.name\"],\n    \"searchTerm\": \"Second\"\n    },\n  \"fields\": [\"_id\", \"displayName\", \"logoUrl\"],\n  \"limit\" : 0,\n  \"skip\" : 0\n}'\n```
.Description
This endpoint will return Organization data based on your search parameters.
This endpoint WILL NOT allow you to add a new Organization.\n\nYou can use the supported parameters and pass those in the body of request.
\n\nThe parameters must be passed as Content-Type application/json.\n\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/search/organizations \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"search\":{\n    \"fields\" : [\"settings.name\"],\n    \"searchTerm\": \"Second\"\n    },\n  \"fields\": [\"_id\", \"displayName\", \"logoUrl\"],\n  \"limit\" : 0,\n  \"skip\" : 0\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.ISearch
.Outputs
JumpCloud.SDK.V1.Models.IOrganizationslist
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ISearch>: Search
  [Fields <String>]: 
  [Filter <ISearchFilter>]: 
  [SearchFilter <ISearchFilter1>]: 
.Link
https://github.com/TheJumpCloud/support/wiki/Search-JCOrganization
#>
Function Search-JCOrganization
{
    #Requires -Modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.IOrganizationslist])]
    [CmdletBinding(DefaultParameterSetName='SearchExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # Use a space seperated string of field parameters to include the data in the response.
    # If omitted, the default list of fields will be returned.
    ${Fields},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.String]
    # A filter to apply to the query.
    ${Filter},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.Int32]
    # The number of records to return at once.
    # Limited to 100.
    ${Limit},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Query')]
    [System.Int32]
    # The offset into the records to return.
    ${Skip},

    [Parameter(ParameterSetName='Search', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISearch]
    # Search
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Fields1},

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISearchFilter]
    # .
    ${Filter1},

    [Parameter(ParameterSetName='SearchExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.ISearchFilter1]
    # .
    ${SearchFilter},

    [Parameter()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [System.Boolean]
    # Set to $true to return all results.
    $Paginate = $true
    )
    Begin
    {
        Connect-JCOnline -force | Out-Null
        $Results = @()
        If ([System.String]::IsNullOrEmpty($PSBoundParameters.Skip))
        {
            $PSBoundParameters.Add('Skip', 0)
        }
        If ([System.String]::IsNullOrEmpty($PSBoundParameters.Limit))
        {
            $PSBoundParameters.Add('Limit', 100)
        }
    }
    Process
    {
        If ($Paginate)
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            Do
            {
                Write-Debug ("Skip: $($PSBoundParameters.Skip); Limit: $($PSBoundParameters.Limit);");
                $Result = Search-JcSdkOrganization @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result.results | Measure-Object).Count;
                    $Results += $Result.results;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit -and $Result)
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = Search-JcSdkOrganization @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $Results += $Result.results;
            }
        }
    }
    End
    {
        Return $Results
    }
}
