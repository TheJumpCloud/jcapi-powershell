Function Remove-JCSystemUserSshKey
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.IPaths1Bg71WnSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Delete',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'Delete',
            Mandatory = $true
        )]
        [System.String]$SystemuserId,
        [Parameter(
            ParameterSetName = 'DeleteViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Remove-JcSdkSystemUserSshKey @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
