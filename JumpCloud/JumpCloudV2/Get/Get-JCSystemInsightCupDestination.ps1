<#
.Synopsis
Valid filter fields are `system_id` and `name`.
.Description
Valid filter fields are `system_id` and `name`.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
JumpCloud.SDK.V2.Models.ISystemInsightsCupsDestinations
.Link
https://github.com/TheJumpCloud/support/wiki/Get-JCSystemInsightCupDestination
#>
Function Get-JCSystemInsightCupDestination
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.ISystemInsightsCupsDestinations])]
    [CmdletBinding(DefaultParameterSetName='Get', PositionalBinding=$false)]
    Param(
    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # Supported operators are: eq
    ${Filter},

    [Parameter()]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.Int32]
    # .
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
                $Result = Get-JcSdkSystemInsightCupDestination @PSBoundParameters
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
            $Result = Get-JcSdkSystemInsightCupDestination @PSBoundParameters
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
