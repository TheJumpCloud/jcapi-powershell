<#
.Synopsis
This endpoint allows you to expire a user's password.
.Description
This endpoint allows you to expire a user's password.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v1/invoke-jcexpiresystemuserpassword
#>
 Function Invoke-JCExpireSystemUserPassword
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Post', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Post', Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='PostViaIdentity', Mandatory, ValueFromPipeline)]
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
                $Result = JumpCloud.SDK.V1.internal\Get-JcSdkSystemUserSshKey @PSBoundParameters
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
            $Result = JumpCloud.SDK.V1.internal\Get-JcSdkSystemUserSshKey @PSBoundParameters
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

