<#
.Synopsis
This endpoint returns a list of the Administrators associated with the Provider.
You must be associated with the provider to use this route.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
This endpoint returns a list of the Administrators associated with the Provider.
You must be associated with the provider to use this route.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IPathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema
.Outputs
System.String
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v2/get-jcsdkprovideradministrator
#>
 Function Get-JcSdkProviderAdministrator
{
    [OutputType([JumpCloud.SDK.V2.Models.IPathsYwlyndProvidersProviderIdAdministratorsGetResponses200ContentApplicationJsonSchema], [System.String])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${ProviderId},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # The comma separated fields included in the returned records.
    # If omitted, the default list of fields will be returned.
    ${Fields},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # Supported operators are: eq, ne, gt, ge, lt, le, between, search, in
    ${Filter},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # The comma separated fields used to sort the collection.
    # Default sort is ascending, prefix with `-` to sort descending.
    ${Sort},

    [Parameter(DontShow)]
    [System.Boolean]
    # Set to $true to return all results. This will overwrite any skip and limit parameter.
    $Paginate = $true
    )
    Begin
    {
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
                $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalProviderAdministrator @PSBoundParameters
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result | Measure-Object).Count;
                    $Results += $Result;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit -and $Result)
        }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalProviderAdministrator @PSBoundParameters
            If (-not [System.String]::IsNullOrEmpty($Result))
            {
                $Results += $Result;
            }
        }
    }
    End
    {
        Return $Results
    }
}

