<#
.Synopsis
This endpoint allows you to reset the MFA TOTP token for a specified system user and put them in an MFA enrollment period.
This will result in the user being prompted to setup MFA when logging into userportal.
Please be aware that if the user does not complete MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.
\n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'\n  \n\n```
.Description
This endpoint allows you to reset the MFA TOTP token for a specified system user and put them in an MFA enrollment period.
This will result in the user being prompted to setup MFA when logging into userportal.
Please be aware that if the user does not complete MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information.
\n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\"exclusion\": true, \"exclusionUntil\": \"{date-time}\"}'\n  \n\n```
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/reset-jcsdksystemusermfa
.Inputs
JumpCloudApiSdkV1.Models.IBodyParameterResetSystemUserMfaRequestBody
.Inputs
JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
.Outputs
System.String
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IBodyParameterResetSystemUserMfaRequestBody>: HELP MESSAGE MISSING
  [Exclusion <Boolean?>]: 
  [ExclusionUntil <DateTime?>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/reset-jcsdksystemusermfa
#>
function Reset-JcSdkSystemUserMfa {
[OutputType([System.String])]
[CmdletBinding(DefaultParameterSetName='ResetExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Reset', Mandatory)]
    [Parameter(ParameterSetName='ResetExpanded', Mandatory)]
    [JumpCloudApiSdkV1.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Id},

    [Parameter(ParameterSetName='ResetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ResetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Path')]
    [JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Reset', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='ResetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.IBodyParameterResetSystemUserMfaRequestBody]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='ResetExpanded')]
    [Parameter(ParameterSetName='ResetViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${Exclusion},

    [Parameter(ParameterSetName='ResetExpanded')]
    [Parameter(ParameterSetName='ResetViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.DateTime]
    # HELP MESSAGE MISSING
    ${ExclusionUntil},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [JumpCloudApiSdkV1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [JumpCloudApiSdkV1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Reset = 'JumpCloudApiSdkV1.private\Reset-JcSdkSystemUserMfa_Reset';
            ResetExpanded = 'JumpCloudApiSdkV1.private\Reset-JcSdkSystemUserMfa_ResetExpanded';
            ResetViaIdentity = 'JumpCloudApiSdkV1.private\Reset-JcSdkSystemUserMfa_ResetViaIdentity';
            ResetViaIdentityExpanded = 'JumpCloudApiSdkV1.private\Reset-JcSdkSystemUserMfa_ResetViaIdentityExpanded';
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
