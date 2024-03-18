<#
.Synopsis
The endpoint updates a SSO / SAML Application.
Any fields not provided will be reset or created with default values.
.Description
The endpoint updates a SSO / SAML Application.
Any fields not provided will be reset or created with default values.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
JumpCloud.SDK.V1.Models.IApplication
.Inputs
JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
.Outputs
JumpCloud.SDK.V1.Models.IApplication
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <IApplication>:
  Config <IApplicationConfig>:
    [AcUrlLabel <String>]:
    [AcUrlPosition <Int32?>]:
    [AcUrlReadOnly <Boolean?>]:
    [AcUrlRequired <Boolean?>]:
    [AcUrlType <String>]:
    [AcUrlValue <String>]:
    [AcUrlVisible <Boolean?>]:
    [AcsUrlTooltipTemplate <String>]:
    [AcsUrlTooltipVariablesIcon <String>]:
    [AcsUrlTooltipVariablesMessage <String>]:
    [ConstantAttributeLabel <String>]:
    [ConstantAttributeMutable <Boolean?>]:
    [ConstantAttributePosition <Int32?>]:
    [ConstantAttributeReadOnly <Boolean?>]:
    [ConstantAttributeRequired <Boolean?>]:
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
    [DeclareRedirectEndpointLabel <String>]:
    [DeclareRedirectEndpointPosition <Int32?>]:
    [DeclareRedirectEndpointReadOnly <Boolean?>]:
    [DeclareRedirectEndpointRequired <Boolean?>]:
    [DeclareRedirectEndpointTooltipTemplate <String>]:
    [DeclareRedirectEndpointTooltipVariablesIcon <String>]:
    [DeclareRedirectEndpointTooltipVariablesMessage <String>]:
    [DeclareRedirectEndpointType <String>]:
    [DeclareRedirectEndpointValue <Boolean?>]:
    [DeclareRedirectEndpointVisible <Boolean?>]:
    [DefaultTargetUrlLabel <String>]:
    [DefaultTargetUrlPosition <Int32?>]:
    [DefaultTargetUrlReadOnly <Boolean?>]:
    [DefaultTargetUrlRequired <Boolean?>]:
    [DefaultTargetUrlTooltipTemplate <String>]:
    [DefaultTargetUrlTooltipVariablesIcon <String>]:
    [DefaultTargetUrlTooltipVariablesMessage <String>]:
    [DefaultTargetUrlType <String>]:
    [DefaultTargetUrlValue <String>]:
    [DefaultTargetUrlVisible <Boolean?>]:
    [GroupAttributeNameDependsOnProperty <String>]:
    [GroupAttributeNameLabel <String>]:
    [GroupAttributeNamePosition <Int32?>]:
    [GroupAttributeNameReadOnly <Boolean?>]:
    [GroupAttributeNameRequired <Boolean?>]:
    [GroupAttributeNameType <String>]:
    [GroupAttributeNameValue <String>]:
    [GroupAttributeNameVisible <Boolean?>]:
    [GroupsAttributeNameTooltipTemplate <String>]:
    [GroupsAttributeNameTooltipVariablesIcon <String>]:
    [GroupsAttributeNameTooltipVariablesMessage <String>]:
    [IdpCertificateLabel <String>]:
    [IdpCertificatePosition <Int32?>]:
    [IdpCertificateReadOnly <Boolean?>]:
    [IdpCertificateRequired <Boolean?>]:
    [IdpCertificateTooltipTemplate <String>]:
    [IdpCertificateTooltipVariablesIcon <String>]:
    [IdpCertificateTooltipVariablesMessage <String>]:
    [IdpCertificateType <String>]:
    [IdpCertificateValue <String>]:
    [IdpCertificateVisible <Boolean?>]:
    [IdpEntityIdLabel <String>]:
    [IdpEntityIdPosition <Int32?>]:
    [IdpEntityIdReadOnly <Boolean?>]:
    [IdpEntityIdRequired <Boolean?>]:
    [IdpEntityIdTooltipTemplate <String>]:
    [IdpEntityIdTooltipVariablesIcon <String>]:
    [IdpEntityIdTooltipVariablesMessage <String>]:
    [IdpEntityIdType <String>]:
    [IdpEntityIdValue <String>]:
    [IdpEntityIdVisible <Boolean?>]:
    [IdpInitUrlLabel <String>]:
    [IdpInitUrlPosition <Int32?>]:
    [IdpInitUrlReadOnly <Boolean?>]:
    [IdpInitUrlRequired <Boolean?>]:
    [IdpInitUrlTooltipTemplate <String>]:
    [IdpInitUrlTooltipVariablesIcon <String>]:
    [IdpInitUrlTooltipVariablesMessage <String>]:
    [IdpInitUrlType <String>]:
    [IdpInitUrlValue <String>]:
    [IdpInitUrlVisible <Boolean?>]:
    [IdpPrivateKeyLabel <String>]:
    [IdpPrivateKeyPosition <Int32?>]:
    [IdpPrivateKeyReadOnly <Boolean?>]:
    [IdpPrivateKeyRequired <Boolean?>]:
    [IdpPrivateKeyTooltipTemplate <String>]:
    [IdpPrivateKeyTooltipVariablesIcon <String>]:
    [IdpPrivateKeyTooltipVariablesMessage <String>]:
    [IdpPrivateKeyType <String>]:
    [IdpPrivateKeyValue <String>]:
    [IdpPrivateKeyVisible <Boolean?>]:
    [IncludeGroupLabel <String>]:
    [IncludeGroupPosition <Int32?>]:
    [IncludeGroupReadOnly <Boolean?>]:
    [IncludeGroupRequired <Boolean?>]:
    [IncludeGroupType <String>]:
    [IncludeGroupValue <Boolean?>]:
    [IncludeGroupVisible <Boolean?>]:
    [IncludeGroupsTooltipTemplate <String>]:
    [IncludeGroupsTooltipVariablesIcon <String>]:
    [IncludeGroupsTooltipVariablesMessage <String>]:
    [OverrideNameIdFormatLabel <String>]:
    [OverrideNameIdFormatOptions <IApplicationConfigOverrideNameIdFormatOptionsItem[]>]:
      [Text <String>]:
      [Value <Int32?>]:
    [OverrideNameIdFormatPosition <Int32?>]:
    [OverrideNameIdFormatReadOnly <Boolean?>]:
    [OverrideNameIdFormatRequired <Boolean?>]:
    [OverrideNameIdFormatTooltipTemplate <String>]:
    [OverrideNameIdFormatTooltipVariablesIcon <String>]:
    [OverrideNameIdFormatTooltipVariablesMessage <String>]:
    [OverrideNameIdFormatType <String>]:
    [OverrideNameIdFormatValue <String>]:
    [OverrideNameIdFormatVisible <Boolean?>]:
    [SignAssertionLabel <String>]:
    [SignAssertionPosition <Int32?>]:
    [SignAssertionReadOnly <Boolean?>]:
    [SignAssertionRequired <Boolean?>]:
    [SignAssertionType <String>]:
    [SignAssertionValue <Boolean?>]:
    [SignAssertionVisible <Boolean?>]:
    [SignResponseLabel <String>]:
    [SignResponsePosition <Int32?>]:
    [SignResponseReadOnly <Boolean?>]:
    [SignResponseRequired <Boolean?>]:
    [SignResponseType <String>]:
    [SignResponseValue <Boolean?>]:
    [SignResponseVisible <Boolean?>]:
    [SignatureAlgorithmLabel <String>]:
    [SignatureAlgorithmOptions <IApplicationConfigSignatureAlgorithmOptionsItem[]>]:
      [Text <String>]:
      [Value <Int32?>]:
    [SignatureAlgorithmPosition <Int32?>]:
    [SignatureAlgorithmReadOnly <Boolean?>]:
    [SignatureAlgorithmRequired <Boolean?>]:
    [SignatureAlgorithmTooltipTemplate <String>]:
    [SignatureAlgorithmTooltipVariablesIcon <String>]:
    [SignatureAlgorithmTooltipVariablesMessage <String>]:
    [SignatureAlgorithmType <String>]:
    [SignatureAlgorithmValue <String>]:
    [SignatureAlgorithmVisible <Boolean?>]:
    [SpCertificateLabel <String>]:
    [SpCertificatePosition <Int32?>]:
    [SpCertificateReadOnly <Boolean?>]:
    [SpCertificateRequired <Boolean?>]:
    [SpCertificateTooltipTemplate <String>]:
    [SpCertificateTooltipVariablesIcon <String>]:
    [SpCertificateTooltipVariablesMessage <String>]:
    [SpCertificateType <String>]:
    [SpCertificateValue <String>]:
    [SpCertificateVisible <Boolean?>]:
    [SpEntityIdLabel <String>]:
    [SpEntityIdPosition <Int32?>]:
    [SpEntityIdReadOnly <Boolean?>]:
    [SpEntityIdRequired <Boolean?>]:
    [SpEntityIdTooltipTemplate <String>]:
    [SpEntityIdTooltipVariablesIcon <String>]:
    [SpEntityIdTooltipVariablesMessage <String>]:
    [SpEntityIdType <String>]:
    [SpEntityIdValue <String>]:
    [SpEntityIdVisible <Boolean?>]:
    [SpErrorFlowLabel <String>]:
    [SpErrorFlowPosition <Int32?>]:
    [SpErrorFlowReadOnly <Boolean?>]:
    [SpErrorFlowRequired <Boolean?>]:
    [SpErrorFlowTooltipTemplate <String>]:
    [SpErrorFlowTooltipVariablesIcon <String>]:
    [SpErrorFlowTooltipVariablesMessage <String>]:
    [SpErrorFlowType <String>]:
    [SpErrorFlowValue <Boolean?>]:
    [SpErrorFlowVisible <Boolean?>]:
    [SubjectFieldLabel <String>]:
    [SubjectFieldOptions <IApplicationConfigSubjectFieldOptionsItem[]>]:
      [Text <String>]:
      [Value <Int32?>]:
    [SubjectFieldPosition <Int32?>]:
    [SubjectFieldReadOnly <Boolean?>]:
    [SubjectFieldRequired <Boolean?>]:
    [SubjectFieldTooltipTemplate <String>]:
    [SubjectFieldTooltipVariablesIcon <String>]:
    [SubjectFieldTooltipVariablesMessage <String>]:
    [SubjectFieldType <String>]:
    [SubjectFieldValue <String>]:
    [SubjectFieldVisible <Boolean?>]:
  Name <String>:
  SsoUrl <String>:
  [Active <Boolean?>]:
  [Beta <Boolean?>]:
  [Color <String>]:
  [Created <String>]:
  [DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]:
  [Description <String>]:
  [DisplayLabel <String>]:
  [DisplayName <String>]:
  [Id <String>]:
  [LearnMore <String>]:
  [LogoColor <String>]:
  [LogoUrl <String>]:
  [Organization <String>]:
  [SsoBeta <Boolean?>]:
  [SsoHidden <Boolean?>]:
  [SsoIdpCertExpirationAt <DateTime?>]:
  [SsoJit <Boolean?>]:
  [SsoType <String>]:

CONFIG <IApplicationConfig>:
  [AcUrlLabel <String>]:
  [AcUrlPosition <Int32?>]:
  [AcUrlReadOnly <Boolean?>]:
  [AcUrlRequired <Boolean?>]:
  [AcUrlType <String>]:
  [AcUrlValue <String>]:
  [AcUrlVisible <Boolean?>]:
  [AcsUrlTooltipTemplate <String>]:
  [AcsUrlTooltipVariablesIcon <String>]:
  [AcsUrlTooltipVariablesMessage <String>]:
  [ConstantAttributeLabel <String>]:
  [ConstantAttributeMutable <Boolean?>]:
  [ConstantAttributePosition <Int32?>]:
  [ConstantAttributeReadOnly <Boolean?>]:
  [ConstantAttributeRequired <Boolean?>]:
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
  [DeclareRedirectEndpointLabel <String>]:
  [DeclareRedirectEndpointPosition <Int32?>]:
  [DeclareRedirectEndpointReadOnly <Boolean?>]:
  [DeclareRedirectEndpointRequired <Boolean?>]:
  [DeclareRedirectEndpointTooltipTemplate <String>]:
  [DeclareRedirectEndpointTooltipVariablesIcon <String>]:
  [DeclareRedirectEndpointTooltipVariablesMessage <String>]:
  [DeclareRedirectEndpointType <String>]:
  [DeclareRedirectEndpointValue <Boolean?>]:
  [DeclareRedirectEndpointVisible <Boolean?>]:
  [DefaultTargetUrlLabel <String>]:
  [DefaultTargetUrlPosition <Int32?>]:
  [DefaultTargetUrlReadOnly <Boolean?>]:
  [DefaultTargetUrlRequired <Boolean?>]:
  [DefaultTargetUrlTooltipTemplate <String>]:
  [DefaultTargetUrlTooltipVariablesIcon <String>]:
  [DefaultTargetUrlTooltipVariablesMessage <String>]:
  [DefaultTargetUrlType <String>]:
  [DefaultTargetUrlValue <String>]:
  [DefaultTargetUrlVisible <Boolean?>]:
  [GroupAttributeNameDependsOnProperty <String>]:
  [GroupAttributeNameLabel <String>]:
  [GroupAttributeNamePosition <Int32?>]:
  [GroupAttributeNameReadOnly <Boolean?>]:
  [GroupAttributeNameRequired <Boolean?>]:
  [GroupAttributeNameType <String>]:
  [GroupAttributeNameValue <String>]:
  [GroupAttributeNameVisible <Boolean?>]:
  [GroupsAttributeNameTooltipTemplate <String>]:
  [GroupsAttributeNameTooltipVariablesIcon <String>]:
  [GroupsAttributeNameTooltipVariablesMessage <String>]:
  [IdpCertificateLabel <String>]:
  [IdpCertificatePosition <Int32?>]:
  [IdpCertificateReadOnly <Boolean?>]:
  [IdpCertificateRequired <Boolean?>]:
  [IdpCertificateTooltipTemplate <String>]:
  [IdpCertificateTooltipVariablesIcon <String>]:
  [IdpCertificateTooltipVariablesMessage <String>]:
  [IdpCertificateType <String>]:
  [IdpCertificateValue <String>]:
  [IdpCertificateVisible <Boolean?>]:
  [IdpEntityIdLabel <String>]:
  [IdpEntityIdPosition <Int32?>]:
  [IdpEntityIdReadOnly <Boolean?>]:
  [IdpEntityIdRequired <Boolean?>]:
  [IdpEntityIdTooltipTemplate <String>]:
  [IdpEntityIdTooltipVariablesIcon <String>]:
  [IdpEntityIdTooltipVariablesMessage <String>]:
  [IdpEntityIdType <String>]:
  [IdpEntityIdValue <String>]:
  [IdpEntityIdVisible <Boolean?>]:
  [IdpInitUrlLabel <String>]:
  [IdpInitUrlPosition <Int32?>]:
  [IdpInitUrlReadOnly <Boolean?>]:
  [IdpInitUrlRequired <Boolean?>]:
  [IdpInitUrlTooltipTemplate <String>]:
  [IdpInitUrlTooltipVariablesIcon <String>]:
  [IdpInitUrlTooltipVariablesMessage <String>]:
  [IdpInitUrlType <String>]:
  [IdpInitUrlValue <String>]:
  [IdpInitUrlVisible <Boolean?>]:
  [IdpPrivateKeyLabel <String>]:
  [IdpPrivateKeyPosition <Int32?>]:
  [IdpPrivateKeyReadOnly <Boolean?>]:
  [IdpPrivateKeyRequired <Boolean?>]:
  [IdpPrivateKeyTooltipTemplate <String>]:
  [IdpPrivateKeyTooltipVariablesIcon <String>]:
  [IdpPrivateKeyTooltipVariablesMessage <String>]:
  [IdpPrivateKeyType <String>]:
  [IdpPrivateKeyValue <String>]:
  [IdpPrivateKeyVisible <Boolean?>]:
  [IncludeGroupLabel <String>]:
  [IncludeGroupPosition <Int32?>]:
  [IncludeGroupReadOnly <Boolean?>]:
  [IncludeGroupRequired <Boolean?>]:
  [IncludeGroupType <String>]:
  [IncludeGroupValue <Boolean?>]:
  [IncludeGroupVisible <Boolean?>]:
  [IncludeGroupsTooltipTemplate <String>]:
  [IncludeGroupsTooltipVariablesIcon <String>]:
  [IncludeGroupsTooltipVariablesMessage <String>]:
  [OverrideNameIdFormatLabel <String>]:
  [OverrideNameIdFormatOptions <IApplicationConfigOverrideNameIdFormatOptionsItem[]>]:
    [Text <String>]:
    [Value <Int32?>]:
  [OverrideNameIdFormatPosition <Int32?>]:
  [OverrideNameIdFormatReadOnly <Boolean?>]:
  [OverrideNameIdFormatRequired <Boolean?>]:
  [OverrideNameIdFormatTooltipTemplate <String>]:
  [OverrideNameIdFormatTooltipVariablesIcon <String>]:
  [OverrideNameIdFormatTooltipVariablesMessage <String>]:
  [OverrideNameIdFormatType <String>]:
  [OverrideNameIdFormatValue <String>]:
  [OverrideNameIdFormatVisible <Boolean?>]:
  [SignAssertionLabel <String>]:
  [SignAssertionPosition <Int32?>]:
  [SignAssertionReadOnly <Boolean?>]:
  [SignAssertionRequired <Boolean?>]:
  [SignAssertionType <String>]:
  [SignAssertionValue <Boolean?>]:
  [SignAssertionVisible <Boolean?>]:
  [SignResponseLabel <String>]:
  [SignResponsePosition <Int32?>]:
  [SignResponseReadOnly <Boolean?>]:
  [SignResponseRequired <Boolean?>]:
  [SignResponseType <String>]:
  [SignResponseValue <Boolean?>]:
  [SignResponseVisible <Boolean?>]:
  [SignatureAlgorithmLabel <String>]:
  [SignatureAlgorithmOptions <IApplicationConfigSignatureAlgorithmOptionsItem[]>]:
    [Text <String>]:
    [Value <Int32?>]:
  [SignatureAlgorithmPosition <Int32?>]:
  [SignatureAlgorithmReadOnly <Boolean?>]:
  [SignatureAlgorithmRequired <Boolean?>]:
  [SignatureAlgorithmTooltipTemplate <String>]:
  [SignatureAlgorithmTooltipVariablesIcon <String>]:
  [SignatureAlgorithmTooltipVariablesMessage <String>]:
  [SignatureAlgorithmType <String>]:
  [SignatureAlgorithmValue <String>]:
  [SignatureAlgorithmVisible <Boolean?>]:
  [SpCertificateLabel <String>]:
  [SpCertificatePosition <Int32?>]:
  [SpCertificateReadOnly <Boolean?>]:
  [SpCertificateRequired <Boolean?>]:
  [SpCertificateTooltipTemplate <String>]:
  [SpCertificateTooltipVariablesIcon <String>]:
  [SpCertificateTooltipVariablesMessage <String>]:
  [SpCertificateType <String>]:
  [SpCertificateValue <String>]:
  [SpCertificateVisible <Boolean?>]:
  [SpEntityIdLabel <String>]:
  [SpEntityIdPosition <Int32?>]:
  [SpEntityIdReadOnly <Boolean?>]:
  [SpEntityIdRequired <Boolean?>]:
  [SpEntityIdTooltipTemplate <String>]:
  [SpEntityIdTooltipVariablesIcon <String>]:
  [SpEntityIdTooltipVariablesMessage <String>]:
  [SpEntityIdType <String>]:
  [SpEntityIdValue <String>]:
  [SpEntityIdVisible <Boolean?>]:
  [SpErrorFlowLabel <String>]:
  [SpErrorFlowPosition <Int32?>]:
  [SpErrorFlowReadOnly <Boolean?>]:
  [SpErrorFlowRequired <Boolean?>]:
  [SpErrorFlowTooltipTemplate <String>]:
  [SpErrorFlowTooltipVariablesIcon <String>]:
  [SpErrorFlowTooltipVariablesMessage <String>]:
  [SpErrorFlowType <String>]:
  [SpErrorFlowValue <Boolean?>]:
  [SpErrorFlowVisible <Boolean?>]:
  [SubjectFieldLabel <String>]:
  [SubjectFieldOptions <IApplicationConfigSubjectFieldOptionsItem[]>]:
    [Text <String>]:
    [Value <Int32?>]:
  [SubjectFieldPosition <Int32?>]:
  [SubjectFieldReadOnly <Boolean?>]:
  [SubjectFieldRequired <Boolean?>]:
  [SubjectFieldTooltipTemplate <String>]:
  [SubjectFieldTooltipVariablesIcon <String>]:
  [SubjectFieldTooltipVariablesMessage <String>]:
  [SubjectFieldType <String>]:
  [SubjectFieldValue <String>]:
  [SubjectFieldVisible <Boolean?>]:

INPUTOBJECT <IJumpCloudApiIdentity>:
  [Id <String>]:
  [SystemId <String>]:
  [SystemuserId <String>]:
  [Triggername <String>]:
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkApplication.md
#>
 Function Set-JcSdkApplication
{
    [OutputType([JumpCloud.SDK.V1.Models.IApplication])]
    [CmdletBinding(DefaultParameterSetName='Set', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Set', Mandatory)]
    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Path')]
    [System.String]
    # .
    ${Id}, 

    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Path')]
    [JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject}, 

    [Parameter(ParameterSetName='Set', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SetViaIdentity', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplication]
    # Application
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationConfig]
    # .
    # To construct, see NOTES section for CONFIG properties and create a hash table.
    ${Config}, 

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name}, 

    [Parameter(ParameterSetName='SetExpanded', Mandatory)]
    [Parameter(ParameterSetName='SetViaIdentityExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${SsoUrl}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Active}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Beta}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Color}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Created}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationDatabaseAttributesItem[]]
    # .
    ${DatabaseAttributes}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Description}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayLabel}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayName}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Id1}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LearnMore}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoColor}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoUrl}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Organization}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoBeta}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoHidden}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${SsoIdpCertExpirationAt}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoJit}, 

    [Parameter(ParameterSetName='SetExpanded')]
    [Parameter(ParameterSetName='SetViaIdentityExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${SsoType}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [JumpCloud.SDK.V1.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy}, 

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential}, 

    [Parameter(DontShow)]
    [JumpCloud.SDK.V1.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
    )
    Begin
    {
        $Results = @()
        $PSBoundParameters.Add('HttpPipelineAppend', {
                param($req, $callback, $next)
                # call the next step in the Pipeline
                $ResponseTask = $next.SendAsync($req, $callback)
                $global:JCHttpRequest = $req
                # $global:JCHttpRequestContent = If (-not [System.String]::IsNullOrEmpty($req.Content)) { $req.Content.ReadAsStringAsync() }
                $global:JCHttpResponse = $ResponseTask
                # $global:JCHttpResponseContent = If (-not [System.String]::IsNullOrEmpty($ResponseTask.Result.Content)) { $ResponseTask.Result.Content.ReadAsStringAsync() }
                Return $ResponseTask
            }
        )
    }
    Process
    {
        $maxRetries = 4
        $resultCounter = 0
        :retryLoop do {
            $resultCounter++
            try {
                $Results = JumpCloud.SDK.V1.internal\Set-JcSdkInternalApplication @PSBoundParameters -ErrorAction Stop
                break retryLoop
            } catch {
                If (($JCHttpResponse.Result.StatusCode -ne 503) -or ($resultCounter -eq $maxRetries)) {
                    throw $_
                } else {
                    Write-Warning ("An error occurred: $_.")
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                }
            }
            Start-Sleep -Seconds ($resultCounter * 5)
        } while ($resultCounter -lt $maxRetries)
    }
    End
    {
        Write-Debug ('HttpRequest: ' + $JCHttpRequest);
        # Write-Debug ('HttpRequestContent: ' + $JCHttpRequestContent.Result);
        Write-Debug ('HttpResponse: ' + $JCHttpResponse.Result);
        # Write-Debug ('HttpResponseContent: ' + $JCHttpResponseContent.Result);
        # Clean up global variables
        $GlobalVars = @('JCHttpRequest', 'JCHttpRequestContent', 'JCHttpResponse', 'JCHttpResponseContent')
        $GlobalVars | ForEach-Object {
            If ((Get-Variable -Scope:('Global')).Where( { $_.Name -eq $_ })) {
                Remove-Variable -Name:($_) -Scope:('Global')
            }
        }
        Return $Results
    }
}


