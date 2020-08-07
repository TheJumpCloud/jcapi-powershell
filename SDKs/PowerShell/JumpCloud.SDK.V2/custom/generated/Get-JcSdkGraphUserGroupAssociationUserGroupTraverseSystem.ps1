<#
.Synopsis
This endpoint will return all Systems bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Description
This endpoint will return all Systems bound to a User Group, either directly or indirectly, essentially traversing the JumpCloud Graph for your Organization.\n\nEach element will contain the type, id, attributes and paths\n\nThe `attributes` object is a key/value hash of compiled graph attributes for all paths followed.\n\nThe `paths` array enumerates each path from this User Group to the corresponding System; this array represents all grouping and/or associations that would have to be removed to deprovision the System from this User Group.\n\nSee `/members` and `/associations` endpoints to manage those collections.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/v2/usergroups/{GroupID}/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.IGraphObjectWithPaths
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkGraphUserGroupAssociationUserGroupTraverseSystem.md
#>
 Function Get-JcSdkGraphUserGroupAssociationUserGroupTraverseSystem
{
    [OutputType([JumpCloud.SDK.V2.Models.IGraphObjectWithPaths])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the User Group.
    ${GroupId},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # Supported operators are: eq, ne, gt, ge, lt, le, between, search, in
    ${Filter},

    [Parameter(DontShow)]
    [System.Boolean]
    # Set to $true to return all results. This will overwrite any skip and limit parameter.
    $Paginate = $true
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        If ($Paginate -and $PSCmdlet.ParameterSetName -in ('List'))
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Limit))
            {
                $PSBoundParameters.Add('Limit', 100)
            }
            If ([System.String]::IsNullOrEmpty($PSBoundParameters.Skip))
            {
                $PSBoundParameters.Add('Skip', 0)
            }
            Do
            {
                Write-Debug ("Limit: $($PSBoundParameters.Limit); ");
                Write-Debug ("Skip: $($PSBoundParameters.Skip); ");
                $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalGraphUserGroupAssociationUserGroupTraverseSystem @PSBoundParameters
                $Result = If ('Results' -in $Result.PSObject.Properties.Name)
                {
                    $Result.results
                }
                Else
                {
                    $Result
                }
                If (-not [System.String]::IsNullOrEmpty($Result))
                {
                    $ResultCount = ($Result | Measure-Object).Count;
                    $Results += $Result;
                    $PSBoundParameters.Skip += $ResultCount
                }
            }
            While ($ResultCount -eq $PSBoundParameters.Limit -and -not [System.String]::IsNullOrEmpty($Result))
         }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalGraphUserGroupAssociationUserGroupTraverseSystem @PSBoundParameters
            $Result = If ('Results' -in $Result.PSObject.Properties.Name)
            {
                $Result.results
            }
            Else
            {
                $Result
            }
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
