<#
.Synopsis
This endpoint returns _direct_ associations of an Office 365 instance.\n\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/office365s/{O365_ID}/associations?targets=user_group' \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```
.Description
This endpoint returns _direct_ associations of an Office 365 instance.\n\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example Office 365 and Users.\n\n#### Sample Request\n```\ncurl -X GET 'https://console.jumpcloud.com/api/v2/office365s/{O365_ID}/associations?targets=user_group' \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n\n```
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

#>
Function Get-JCOffice365GraphOffice365Association
{
    #Requires -Modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IGraphConnection])]
    [CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
    Param(
    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Path')]
    [System.String]
    # ObjectID of the Office 365 instance.
    ${Office365Id},

    [Parameter(Mandatory)]
    [JumpCloud.SDK.V2.Category('Query')]
    [System.String[]]
    # .
    ${Targets},

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
                $Result = Get-JcSdkOffice365GraphOffice365Association @PSBoundParameters
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
            $Result = Get-JcSdkOffice365GraphOffice365Association @PSBoundParameters
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
