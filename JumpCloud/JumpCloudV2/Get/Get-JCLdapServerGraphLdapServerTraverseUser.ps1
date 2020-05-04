<#
.Synopsis
This endpoint will return all Users bound to an LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this LDAP server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this LDAP server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
This endpoint will return all Users bound to an LDAP Server, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths.\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this LDAP server instance to the corresponding User; this array represents all grouping and/or associations that would have to be removed to deprovision the User from this LDAP server instance.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/users \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IGraphObjectWithPaths
.Link
https://github.com/TheJumpCloud/support/wiki/Get-JCLdapServerGraphLdapServerTraverseUser
#>
Function Get-JCLdapServerGraphLdapServerTraverseUser
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IGraphObjectWithPaths])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the LDAP Server.
    ${LdapserverId},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # Supported operators are: eq, ne, gt, ge, lt, le, between, search, in
    ${Filter},

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
    ${Skip},

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
                $Result = Get-JcSdkLdapServerGraphLdapServerTraverseUser @PSBoundParameters
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
            $Result = Get-JcSdkLdapServerGraphLdapServerTraverseUser @PSBoundParameters
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
