Function Set-JCDuoApplication
{
    #Requires -modules JumpCloud.SDK.V2
    [OutputType([JumpCloud.SDK.V2.Models.IDuoApplication])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Put',
            Mandatory = $true
        )]
        [System.String]$AccountId,
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Put',
            Mandatory = $true
        )]
        [System.String]$ApplicationId,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'PutViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'PutViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Put',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V2.Models.IDuoApplicationUpdateReq]$Body,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [System.String]$ApiHost,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [System.String]$IntegrationKey,
        [Parameter(
            ParameterSetName = 'PutViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'PutExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(ParameterSetName = 'PutViaIdentityExpanded')]
        [Parameter(ParameterSetName = 'PutExpanded')]
        [System.String]$SecretKey
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = Set-JcSdkDuoApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
