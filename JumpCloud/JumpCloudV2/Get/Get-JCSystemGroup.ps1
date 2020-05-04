<#
.Synopsis
This endpoint returns the details of a System Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
This endpoint returns the details of a System Group.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/systemgroups/{Group_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloud.SDK.V2.Models.ISystemGroup
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [AccountId <String>]: 
  [ActivedirectoryId <String>]: 
  [ApplicationId <String>]: 
  [CommandId <String>]: ObjectID of the Command.
  [GroupId <String>]: ObjectID of the User Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the User Group.
  [JobId <String>]: 
  [LdapserverId <String>]: ObjectID of the LDAP Server.
  [Office365Id <String>]: ObjectID of the Office 365 instance.
  [PolicyId <String>]: ObjectID of the Policy.
  [ProviderId <String>]: 
  [RadiusserverId <String>]: ObjectID of the Radius Server.
  [SystemId <String>]: ObjectID of the System.
  [UserId <String>]: ObjectID of the User.
  [WorkdayId <String>]: 
.Link
https://github.com/TheJumpCloud/support/wiki/Get-JCSystemGroup
#>
Function Get-JCSystemGroup
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.ISystemGroup])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the System Group.
    ${Id},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # The comma separated fields included in the returned records.
    # If omitted, the default list of fields will be returned.
    ${Fields},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # Supported operators are: eq, ne, gt, ge, lt, le, between, search, in
    ${Filter},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # The number of records to return at once.
    # Limited to 100.
    ${Limit},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # The offset into the records to return.
    ${Skip},

    [Parameter(ParameterSetName='List')]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # The comma separated fields used to sort the collection.
    # Default sort is ascending, prefix with `-` to sort descending.
    ${Sort},

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
                $Result = Get-JcSdkSystemGroup @PSBoundParameters
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
            $Result = Get-JcSdkSystemGroup @PSBoundParameters
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
