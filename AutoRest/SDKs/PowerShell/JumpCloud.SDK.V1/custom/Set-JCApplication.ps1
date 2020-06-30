<#
.Synopsis
The endpoint updates a SSO / SAML Application.
.Description
The endpoint updates a SSO / SAML Application.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IApplication
.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
.Outputs
JumpCloud.SDK.V1.Models.IApplication
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IApplication>: 
  [Beta <Boolean?>]: 
  [Color <String>]: 
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
  [Created <String>]: 
  [Description <String>]: 
  [DisplayLabel <String>]: 
  [DisplayName <String>]: 
  [Id <String>]: 
  [LearnMore <String>]: 
  [LogoColor <String>]: 
  [LogoUrl <String>]: 
  [Name <String>]: 
  [Organization <String>]: 
  [SsoUrl <String>]: 

CONFIG <IApplicationConfig>: 
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

INPUTOBJECT <IJumpCloudApIsIdentity>: 
  [Id <String>]: 
  [SystemuserId <String>]: 
  [Triggername <String>]: 
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/AutoRest/SDKs/PowerShell/jumpcloud.sdk.v1/set-jcapplication
#>
 Function Set-JCApplication
{
    [OutputType([JumpCloud.SDK.V1.Models.IApplication])]
    [CmdletBinding(DefaultParameterSetName='PutExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Put', Mandatory)]
    [Parameter(ParameterSetName='PutExpanded', Mandatory)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id},

    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Put', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PutViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplication]
    # Application
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Beta},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Color},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationConfig]
    # .
    # To construct, see NOTES section for CONFIG properties and create a hash table.
    ${Config},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Created},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Description},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayLabel},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayName},

    [Parameter(ParameterSetName='PutExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Id1},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LearnMore},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoColor},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoUrl},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Organization},

    [Parameter(ParameterSetName='PutExpanded')]
    [Parameter(ParameterSetName='PutViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${SsoUrl}
    )
    Begin
    {
        $Results = @()
    }
    Process
    {
        $Results = JumpCloud.SDK.V1.internal\Set-JcSdkApplication @PSBoundParameters
    }
    End
    {
        Return $Results
    }
}

