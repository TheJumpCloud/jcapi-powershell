<#
.Synopsis
This endpoint will return a specific System User's public SSH key.
.Description
This endpoint will return a specific System User's public SSH key.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V1.Models.IPathsCh5U08SystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema
.Outputs
JumpCloud.SDK.V1.Models.ISshkeylist
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/examples/Get-JcSdkSystemUserSshKey.md
#>
 Function Get-JcSdkSystemUserSshKey
{
    [OutputType([JumpCloud.SDK.V1.Models.ISshkeylist], [JumpCloud.SDK.V1.Models.IPathsCh5U08SystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},    [Parameter(DontShow)]
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
                $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalSystemUserSshKey @PSBoundParameters
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
            $Result = JumpCloud.SDK.V1.internal\Get-JcSdkInternalSystemUserSshKey @PSBoundParameters
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

