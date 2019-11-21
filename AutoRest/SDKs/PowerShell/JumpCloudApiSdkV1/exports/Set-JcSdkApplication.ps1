<#
.Synopsis
The endpoint updates a SSO / SAML Application.
.Description
The endpoint updates a SSO / SAML Application.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkapplication
.Inputs
JumpCloudApiSdkV1.Models.IApplication
.Inputs
JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloudApiSdkV1.Models.IApplication
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IApplication>: Application
  [Beta <Boolean?>]: 
  [Config <IApplicationConfig>]: 
    [AcUrlLabel <String>]: 
    [AcUrlOptions <String>]: 
    [AcUrlPosition <Int32?>]: 
    [AcUrlReadOnly <Boolean?>]: 
    [AcUrlRequired <Boolean?>]: 
    [AcUrlToggle <String>]: 
    [AcUrlType <String>]: 
    [AcUrlValue <String>]: 
    [AcUrlVisible <Boolean?>]: 
    [AcsUrlTooltipTemplate <String>]: 
    [AcsUrlTooltipVariablesIcon <String>]: 
    [AcsUrlTooltipVariablesMessage <String>]: 
    [ConstantAttributeLabel <String>]: 
    [ConstantAttributeMutable <Boolean?>]: 
    [ConstantAttributeOptions <String>]: 
    [ConstantAttributePosition <Int32?>]: 
    [ConstantAttributeReadOnly <Boolean?>]: 
    [ConstantAttributeRequired <Boolean?>]: 
    [ConstantAttributeToggle <String>]: 
    [ConstantAttributeType <String>]: 
    [ConstantAttributeValue <IApplicationConfigConstantAttributesValueItem[]>]: 
      [Name <String>]: 
      [ReadOnly <Boolean?>]: 
      [Required <Boolean?>]: 
      [Value <String>]: 
      [Visible <Boolean?>]: 
    [ConstantAttributeVisible <Boolean?>]: 
    [ConstantAttributesTooltipTemplate <String>]: 
    [ConstantAttributesTooltipVariablesIcon <String>]: 
    [ConstantAttributesTooltipVariablesMessage <String>]: 
    [DatabaseAttributePosition <Int32?>]: 
    [IdpCertificateLabel <String>]: 
    [IdpCertificateOptions <String>]: 
    [IdpCertificatePosition <Int32?>]: 
    [IdpCertificateReadOnly <Boolean?>]: 
    [IdpCertificateRequired <Boolean?>]: 
    [IdpCertificateToggle <String>]: 
    [IdpCertificateTooltipTemplate <String>]: 
    [IdpCertificateTooltipVariablesIcon <String>]: 
    [IdpCertificateTooltipVariablesMessage <String>]: 
    [IdpCertificateType <String>]: 
    [IdpCertificateValue <String>]: 
    [IdpCertificateVisible <Boolean?>]: 
    [IdpEntityIdLabel <String>]: 
    [IdpEntityIdOptions <String>]: 
    [IdpEntityIdPosition <Int32?>]: 
    [IdpEntityIdReadOnly <Boolean?>]: 
    [IdpEntityIdRequired <Boolean?>]: 
    [IdpEntityIdToggle <String>]: 
    [IdpEntityIdTooltipTemplate <String>]: 
    [IdpEntityIdTooltipVariablesIcon <String>]: 
    [IdpEntityIdTooltipVariablesMessage <String>]: 
    [IdpEntityIdType <String>]: 
    [IdpEntityIdValue <String>]: 
    [IdpEntityIdVisible <Boolean?>]: 
    [IdpPrivateKeyLabel <String>]: 
    [IdpPrivateKeyOptions <String>]: 
    [IdpPrivateKeyPosition <Int32?>]: 
    [IdpPrivateKeyReadOnly <Boolean?>]: 
    [IdpPrivateKeyRequired <Boolean?>]: 
    [IdpPrivateKeyToggle <String>]: 
    [IdpPrivateKeyTooltipTemplate <String>]: 
    [IdpPrivateKeyTooltipVariablesIcon <String>]: 
    [IdpPrivateKeyTooltipVariablesMessage <String>]: 
    [IdpPrivateKeyType <String>]: 
    [IdpPrivateKeyValue <String>]: 
    [IdpPrivateKeyVisible <Boolean?>]: 
    [SpEntityIdLabel <String>]: 
    [SpEntityIdOptions <String>]: 
    [SpEntityIdPosition <Int32?>]: 
    [SpEntityIdReadOnly <Boolean?>]: 
    [SpEntityIdRequired <Boolean?>]: 
    [SpEntityIdToggle <String>]: 
    [SpEntityIdTooltipTemplate <String>]: 
    [SpEntityIdTooltipVariablesIcon <String>]: 
    [SpEntityIdTooltipVariablesMessage <String>]: 
    [SpEntityIdType <String>]: 
    [SpEntityIdValue <String>]: 
    [SpEntityIdVisible <Boolean?>]: 
  [DisplayLabel <String>]: 
  [DisplayName <String>]: 
  [Id <String>]: 
  [LearnMore <String>]: 
  [Name <String>]: 
  [Organization <String>]: 
  [SsoUrl <String>]: 

CONFIG <IApplicationConfig>: HELP MESSAGE MISSING
  [AcUrlLabel <String>]: 
  [AcUrlOptions <String>]: 
  [AcUrlPosition <Int32?>]: 
  [AcUrlReadOnly <Boolean?>]: 
  [AcUrlRequired <Boolean?>]: 
  [AcUrlToggle <String>]: 
  [AcUrlType <String>]: 
  [AcUrlValue <String>]: 
  [AcUrlVisible <Boolean?>]: 
  [AcsUrlTooltipTemplate <String>]: 
  [AcsUrlTooltipVariablesIcon <String>]: 
  [AcsUrlTooltipVariablesMessage <String>]: 
  [ConstantAttributeLabel <String>]: 
  [ConstantAttributeMutable <Boolean?>]: 
  [ConstantAttributeOptions <String>]: 
  [ConstantAttributePosition <Int32?>]: 
  [ConstantAttributeReadOnly <Boolean?>]: 
  [ConstantAttributeRequired <Boolean?>]: 
  [ConstantAttributeToggle <String>]: 
  [ConstantAttributeType <String>]: 
  [ConstantAttributeValue <IApplicationConfigConstantAttributesValueItem[]>]: 
    [Name <String>]: 
    [ReadOnly <Boolean?>]: 
    [Required <Boolean?>]: 
    [Value <String>]: 
    [Visible <Boolean?>]: 
  [ConstantAttributeVisible <Boolean?>]: 
  [ConstantAttributesTooltipTemplate <String>]: 
  [ConstantAttributesTooltipVariablesIcon <String>]: 
  [ConstantAttributesTooltipVariablesMessage <String>]: 
  [DatabaseAttributePosition <Int32?>]: 
  [IdpCertificateLabel <String>]: 
  [IdpCertificateOptions <String>]: 
  [IdpCertificatePosition <Int32?>]: 
  [IdpCertificateReadOnly <Boolean?>]: 
  [IdpCertificateRequired <Boolean?>]: 
  [IdpCertificateToggle <String>]: 
  [IdpCertificateTooltipTemplate <String>]: 
  [IdpCertificateTooltipVariablesIcon <String>]: 
  [IdpCertificateTooltipVariablesMessage <String>]: 
  [IdpCertificateType <String>]: 
  [IdpCertificateValue <String>]: 
  [IdpCertificateVisible <Boolean?>]: 
  [IdpEntityIdLabel <String>]: 
  [IdpEntityIdOptions <String>]: 
  [IdpEntityIdPosition <Int32?>]: 
  [IdpEntityIdReadOnly <Boolean?>]: 
  [IdpEntityIdRequired <Boolean?>]: 
  [IdpEntityIdToggle <String>]: 
  [IdpEntityIdTooltipTemplate <String>]: 
  [IdpEntityIdTooltipVariablesIcon <String>]: 
  [IdpEntityIdTooltipVariablesMessage <String>]: 
  [IdpEntityIdType <String>]: 
  [IdpEntityIdValue <String>]: 
  [IdpEntityIdVisible <Boolean?>]: 
  [IdpPrivateKeyLabel <String>]: 
  [IdpPrivateKeyOptions <String>]: 
  [IdpPrivateKeyPosition <Int32?>]: 
  [IdpPrivateKeyReadOnly <Boolean?>]: 
  [IdpPrivateKeyRequired <Boolean?>]: 
  [IdpPrivateKeyToggle <String>]: 
  [IdpPrivateKeyTooltipTemplate <String>]: 
  [IdpPrivateKeyTooltipVariablesIcon <String>]: 
  [IdpPrivateKeyTooltipVariablesMessage <String>]: 
  [IdpPrivateKeyType <String>]: 
  [IdpPrivateKeyValue <String>]: 
  [IdpPrivateKeyVisible <Boolean?>]: 
  [SpEntityIdLabel <String>]: 
  [SpEntityIdOptions <String>]: 
  [SpEntityIdPosition <Int32?>]: 
  [SpEntityIdReadOnly <Boolean?>]: 
  [SpEntityIdRequired <Boolean?>]: 
  [SpEntityIdToggle <String>]: 
  [SpEntityIdTooltipTemplate <String>]: 
  [SpEntityIdTooltipVariablesIcon <String>]: 
  [SpEntityIdTooltipVariablesMessage <String>]: 
  [SpEntityIdType <String>]: 
  [SpEntityIdValue <String>]: 
  [SpEntityIdVisible <Boolean?>]: 

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/set-jcsdkapplication
#>
function Set-JcSdkApplication {
[OutputType([JumpCloudApiSdkV1.Models.IApplication])]
[CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Path')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Path')]
    [JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [JumpCloudApiSdkV1.Category('Header')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Accept},

    [Parameter()]
    [JumpCloudApiSdkV1.Category('Header')]
    [System.String]
    # HELP MESSAGE MISSING
    ${ContentType},

    [Parameter()]
    [JumpCloudApiSdkV1.Category('Header')]
    [System.String]
    # HELP MESSAGE MISSING
    ${XOrgId},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.IApplication]
    # Application
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # HELP MESSAGE MISSING
    ${Beta},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [JumpCloudApiSdkV1.Models.IApplicationConfig]
    # HELP MESSAGE MISSING
    # To construct, see NOTES section for CONFIG properties and create a hash table.
    ${Config},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${DisplayLabel},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${DisplayName},

    [Parameter(ParameterSetName='PutExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Id1},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${LearnMore},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Name},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${Organization},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloudApiSdkV1.Category('Body')]
    [System.String]
    # HELP MESSAGE MISSING
    ${SsoUrl},

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
            Put = 'JumpCloudApiSdkV1.private\Set-JcSdkApplication_Put';
            PutExpanded = 'JumpCloudApiSdkV1.private\Set-JcSdkApplication_PutExpanded';
            PutViaIdentity = 'JumpCloudApiSdkV1.private\Set-JcSdkApplication_PutViaIdentity';
            PutViaIdentityExpanded = 'JumpCloudApiSdkV1.private\Set-JcSdkApplication_PutViaIdentityExpanded';
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
