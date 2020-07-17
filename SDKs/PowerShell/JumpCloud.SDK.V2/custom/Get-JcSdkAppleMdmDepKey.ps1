<#
.Synopsis
Retrieves an Apple MDM DEP Public Key.
.Description
Retrieves an Apple MDM DEP Public Key.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [AccountId <String>]: 
  [ActivedirectoryId <String>]: 
  [AppleMdmId <String>]: 
  [ApplicationId <String>]: ObjectID of the Application.
  [CommandId <String>]: ObjectID of the Command.
  [DeviceId <String>]: 
  [GroupId <String>]: ObjectID of the System Group.
  [GsuiteId <String>]: ObjectID of the G Suite instance.
  [Id <String>]: ObjectID of the System Group.
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
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkAppleMdmDepKey.md
#>
 Function Get-JcSdkAppleMdmDepKey
{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
    Param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # .
    ${AppleMdmId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V2.Category('Path')]
    [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

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
        If ($Paginate -and $PSCmdlet.ParameterSetName -in (''))
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            Do
            {
                $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalAppleMdmDepKey @PSBoundParameters
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
            While (-not [System.String]::IsNullOrEmpty($Result))
         }
        Else
        {
            $PSBoundParameters.Remove('Paginate') | Out-Null
            $Result = JumpCloud.SDK.V2.internal\Get-JcSdkInternalAppleMdmDepKey @PSBoundParameters
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

