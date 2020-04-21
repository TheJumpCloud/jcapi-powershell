Function Invoke-JCExpireSystemUserPassword
{
    #Requires -modules JumpCloud.SDK.V1
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Post', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
        [Parameter(
            ParameterSetName = 'Post',
            Mandatory = $true
        )]
        [System.String]$Id,
        [Parameter(
            ParameterSetName = 'PostViaIdentity',
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
        $Results = Import-JcSdkWorkdayImportWorkdayResult @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}
