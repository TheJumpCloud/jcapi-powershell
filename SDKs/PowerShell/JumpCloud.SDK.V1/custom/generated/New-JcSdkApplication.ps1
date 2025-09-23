<#
.Synopsis
The endpoint adds a new SSO / SAML Applications.
.Description
The endpoint adds a new SSO / SAML Applications.
.Example
PS C:\> New-JcSdkApplication -Config:(<JumpCloud.SDK.V1.Models.ApplicationConfig>) -Name:(<string>) -SsoUrl:(<string>) -Active:(<switch>) -Beta:(<switch>) -Color:(<string>) -Created:(<string>) -DatabaseAttributes:(<JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]>) -Description:(<string>) -DisplayLabel:(<string>) -DisplayName:(<string>) -Id:(<string>) -LearnMore:(<string>) -LogoColor:(<string>) -LogoUrl:(<string>) -Organization:(<string>) -SsoBeta:(<switch>) -SsoHidden:(<switch>) -SsoIdpCertExpirationAt:(<datetime>) -SsoJit:(<switch>) -SsoType:(<string>)



----                       ----------
Active                     Boolean
Beta                       Boolean
Color                      String
Config                     JumpCloud.SDK.V1.Models.ApplicationConfig
Created                    String
DatabaseAttributes         JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]
Description                String
DisplayLabel               String
DisplayName                String
Id                         String
LearnMore                  String
LogoColor                  String
LogoUrl                    String
Name                       String
Organization               String
SsoBeta                    Boolean
SsoHidden                  Boolean
SsoIdpCertExpirationAt     Datetime
SsoIdpCertificateUpdatedAt Datetime
SsoIdpPrivateKeyUpdatedAt  Datetime
SsoJit                     Boolean
SsoSpCertificateUpdatedAt  Datetime
SsoType                    String
SsoUrl                     String


.Example
PS C:\> New-JcSdkApplication -Body:(<JumpCloud.SDK.V1.Models.Application>)



----                       ----------
Active                     Boolean
Beta                       Boolean
Color                      String
Config                     JumpCloud.SDK.V1.Models.ApplicationConfig
Created                    String
DatabaseAttributes         JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]
Description                String
DisplayLabel               String
DisplayName                String
Id                         String
LearnMore                  String
LogoColor                  String
LogoUrl                    String
Name                       String
Organization               String
SsoBeta                    Boolean
SsoHidden                  Boolean
SsoIdpCertExpirationAt     Datetime
SsoIdpCertificateUpdatedAt Datetime
SsoIdpPrivateKeyUpdatedAt  Datetime
SsoJit                     Boolean
SsoSpCertificateUpdatedAt  Datetime
SsoType                    String
SsoUrl                     String



.Inputs
JumpCloud.SDK.V1.Models.IApplication
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
    [DatabaseAttributeLabel <String>]:
    [DatabaseAttributePosition <Int32?>]:
    [DatabaseAttributeReadOnly <Boolean?>]:
    [DatabaseAttributeRequired <Boolean?>]:
    [DatabaseAttributeType <String>]:
    [DatabaseAttributeValue <IApplicationConfigDatabaseAttributesValueItem[]>]:
      [Name <String>]:
      [ReadOnly <Boolean?>]:
      [Required <Boolean?>]:
      [Value <String>]:
      [Visible <Boolean?>]:
    [DatabaseAttributeVisible <Boolean?>]:
    [DatabaseAttributesTooltipTemplate <String>]:
    [DatabaseAttributesTooltipVariablesIcon <String>]:
    [DatabaseAttributesTooltipVariablesMessage <String>]:
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
  [ParentApp <String>]:
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
  [DatabaseAttributeLabel <String>]:
  [DatabaseAttributePosition <Int32?>]:
  [DatabaseAttributeReadOnly <Boolean?>]:
  [DatabaseAttributeRequired <Boolean?>]:
  [DatabaseAttributeType <String>]:
  [DatabaseAttributeValue <IApplicationConfigDatabaseAttributesValueItem[]>]:
    [Name <String>]:
    [ReadOnly <Boolean?>]:
    [Required <Boolean?>]:
    [Value <String>]:
    [Visible <Boolean?>]:
  [DatabaseAttributeVisible <Boolean?>]:
  [DatabaseAttributesTooltipTemplate <String>]:
  [DatabaseAttributesTooltipVariablesIcon <String>]:
  [DatabaseAttributesTooltipVariablesMessage <String>]:
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
.Link
https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkApplication.md
#>
 Function New-JcSdkApplication
{
    [OutputType([JumpCloud.SDK.V1.Models.IApplication])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    Param(
    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplication]
    # Application
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationConfig]
    # .
    # To construct, see NOTES section for CONFIG properties and create a hash table.
    ${Config}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Name}, 

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${SsoUrl}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Active}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${Beta}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Color}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Created}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [JumpCloud.SDK.V1.Category('Body')]
    [JumpCloud.SDK.V1.Models.IApplicationDatabaseAttributesItem[]]
    # .
    ${DatabaseAttributes}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Description}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayLabel}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${DisplayName}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Id}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LearnMore}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoColor}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${LogoUrl}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${Organization}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.String]
    # .
    ${ParentApp}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoBeta}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoHidden}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.DateTime]
    # .
    ${SsoIdpCertExpirationAt}, 

    [Parameter(ParameterSetName='CreateExpanded')]
    [JumpCloud.SDK.V1.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${SsoJit}, 

    [Parameter(ParameterSetName='CreateExpanded')]
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
            $Results = JumpCloud.SDK.V1.internal\New-JcSdkInternalApplication @PSBoundParameters -errorAction SilentlyContinue -errorVariable sdkError
            If ($sdkError){
                If ($resultCounter -eq $maxRetries){
                    throw $sdkError
                }
                If ($JCHttpResponse.Result.StatusCode -eq "503") {
                    Write-Warning ("503: Service Unavailable - retrying in " + ($resultCounter * 5) + " seconds.")
                } else {
                    throw $sdkError
                }
            } else {
                break retryLoop
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


