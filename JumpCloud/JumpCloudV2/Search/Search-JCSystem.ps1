<#
.Synopsis
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of hostnames\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\": {\n    \"or\": [\n      {\"hostname\" : \"my-hostname\"},\n      {\"hostname\" : \"other-hostname\"}\n    ]\n  },\n  \"fields\" : \"os hostname displayName\"\n}'\n```\n\nText search for a hostname or display name\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```\n\nCombining `filter` and `searchFilter` to search for names that match a given OS\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"os\" : \"Ubuntu\"},\n      {\"os\" : \"Mac OS X\"}\n    ]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```
.Description
Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters.
This WILL NOT allow you to add a new system.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes.
The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions.
\n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions.
If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on.
If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of hostnames\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"filter\": {\n    \"or\": [\n      {\"hostname\" : \"my-hostname\"},\n      {\"hostname\" : \"other-hostname\"}\n    ]\n  },\n  \"fields\" : \"os hostname displayName\"\n}'\n```\n\nText search for a hostname or display name\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```\n\nCombining `filter` and `searchFilter` to search for names that match a given OS\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \"searchFilter\": {\n    \"searchTerm\": \"my-host\",\n    \"fields\": [\"hostname\", \"displayName\"]\n  },\n  \"filter\": {\n    \"or\": [\n      {\"os\" : \"Ubuntu\"},\n      {\"os\" : \"Mac OS X\"}\n    ]\n  },\n  \"fields\": \"os hostname displayName\"\n}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

#>
Function Search-JCSystem
{
    #Requires -Modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.ISystemslist])]
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
                $Result = Search-JcSdkSystem @PSBoundParameters
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
            $Result = Search-JcSdkSystem @PSBoundParameters
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
