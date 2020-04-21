Function New-JCSystemUserSshKey
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([JumpCloud.SDK.V1.Models.ISshkeylist], [JumpCloud.SDK.V1.Models.IPathsZx6QbkSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema])]
    [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]$InputObject,
        [Parameter(
            ParameterSetName = 'CreateViaIdentity',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [Parameter(
            ParameterSetName = 'Create',
            Mandatory = $true,
            ValueFromPipeline = $true
        )]
        [JumpCloud.SDK.V1.Models.ISshkeypost]$Body,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$Name,
        [Parameter(
            ParameterSetName = 'CreateViaIdentityExpanded',
            Mandatory = $true
        )]
        [Parameter(
            ParameterSetName = 'CreateExpanded',
            Mandatory = $true
        )]
        [System.String]$PublicKey
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = New-JcSdkSystemUserSshKey @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
