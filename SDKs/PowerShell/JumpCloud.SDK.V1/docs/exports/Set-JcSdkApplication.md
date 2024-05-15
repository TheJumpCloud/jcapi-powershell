---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkApplication.md
schema: 2.0.0
---

# Set-JcSdkApplication

## SYNOPSIS
The endpoint updates a SSO / SAML Application.
Any fields not provided will be reset or created with default values.

## SYNTAX

### Set (Default)
```
Set-JcSdkApplication -Id <String> -Body <IApplication> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetExpanded
```
Set-JcSdkApplication -Id <String> -Config <IApplicationConfig> -Name <String> -SsoUrl <String> [-Active]
 [-Beta] [-Color <String>] [-Created <String>] [-DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]
 [-Description <String>] [-DisplayLabel <String>] [-DisplayName <String>] [-Id1 <String>]
 [-LearnMore <String>] [-LogoColor <String>] [-LogoUrl <String>] [-Organization <String>] [-SsoBeta]
 [-SsoHidden] [-SsoIdpCertExpirationAt <DateTime>] [-SsoJit] [-SsoType <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkApplication -InputObject <IJumpCloudApiIdentity> -Body <IApplication> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkApplication -InputObject <IJumpCloudApiIdentity> -Config <IApplicationConfig> -Name <String>
 -SsoUrl <String> [-Id <String>] [-Active] [-Beta] [-Color <String>] [-Created <String>]
 [-DatabaseAttributes <IApplicationDatabaseAttributesItem[]>] [-Description <String>] [-DisplayLabel <String>]
 [-DisplayName <String>] [-LearnMore <String>] [-LogoColor <String>] [-LogoUrl <String>]
 [-Organization <String>] [-SsoBeta] [-SsoHidden] [-SsoIdpCertExpirationAt <DateTime>] [-SsoJit]
 [-SsoType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The endpoint updates a SSO / SAML Application.
Any fields not provided will be reset or created with default values.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Set-JcSdkApplication -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Application>)
```

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

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Set-JcSdkApplication -Id:(<string>) -Config:(<JumpCloud.SDK.V1.Models.ApplicationConfig>) -Name:(<string>) -SsoUrl:(<string>) -Active:(<switch>) -Beta:(<switch>) -Color:(<string>) -Created:(<string>) -DatabaseAttributes:(<JumpCloud.SDK.V1.Models.ApplicationDatabaseAttributesItem[]>) -Description:(<string>) -DisplayLabel:(<string>) -DisplayName:(<string>) -LearnMore:(<string>) -LogoColor:(<string>) -LogoUrl:(<string>) -Organization:(<string>) -SsoBeta:(<switch>) -SsoHidden:(<switch>) -SsoIdpCertExpirationAt:(<datetime>) -SsoJit:(<switch>) -SsoType:(<string>) -Id1:(<string>)
```

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

## PARAMETERS

### -Active
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Beta
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Application
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IApplication
Parameter Sets: Set, SetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Color
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Config
.
To construct, see NOTES section for CONFIG properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IApplicationConfig
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Created
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DatabaseAttributes
.

```yaml
Type: JumpCloud.SDK.V1.Models.IApplicationDatabaseAttributesItem[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayLabel
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: Set, SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id1
.

```yaml
Type: System.String
Parameter Sets: SetExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
Parameter Sets: SetViaIdentity, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LearnMore
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogoColor
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogoUrl
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Organization
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsoBeta
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsoHidden
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsoIdpCertExpirationAt
.

```yaml
Type: System.DateTime
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsoJit
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsoType
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SsoUrl
.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.V1.Models.IApplication

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.IApplication

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IApplication>: Application
  - `Config <IApplicationConfig>`: 
    - `[AcUrlLabel <String>]`: 
    - `[AcUrlPosition <Int32?>]`: 
    - `[AcUrlReadOnly <Boolean?>]`: 
    - `[AcUrlRequired <Boolean?>]`: 
    - `[AcUrlType <String>]`: 
    - `[AcUrlValue <String>]`: 
    - `[AcUrlVisible <Boolean?>]`: 
    - `[AcsUrlTooltipTemplate <String>]`: 
    - `[AcsUrlTooltipVariablesIcon <String>]`: 
    - `[AcsUrlTooltipVariablesMessage <String>]`: 
    - `[ConstantAttributeLabel <String>]`: 
    - `[ConstantAttributeMutable <Boolean?>]`: 
    - `[ConstantAttributePosition <Int32?>]`: 
    - `[ConstantAttributeReadOnly <Boolean?>]`: 
    - `[ConstantAttributeRequired <Boolean?>]`: 
    - `[ConstantAttributeType <String>]`: 
    - `[ConstantAttributeValue <IApplicationConfigConstantAttributesValueItem[]>]`: 
      - `[Name <String>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
    - `[ConstantAttributeVisible <Boolean?>]`: 
    - `[ConstantAttributesTooltipTemplate <String>]`: 
    - `[ConstantAttributesTooltipVariablesIcon <String>]`: 
    - `[ConstantAttributesTooltipVariablesMessage <String>]`: 
    - `[DatabaseAttributeLabel <String>]`: 
    - `[DatabaseAttributePosition <Int32?>]`: 
    - `[DatabaseAttributeReadOnly <Boolean?>]`: 
    - `[DatabaseAttributeRequired <Boolean?>]`: 
    - `[DatabaseAttributeType <String>]`: 
    - `[DatabaseAttributeValue <IApplicationConfigDatabaseAttributesValueItem[]>]`: 
      - `[Name <String>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
    - `[DatabaseAttributeVisible <Boolean?>]`: 
    - `[DatabaseAttributesTooltipTemplate <String>]`: 
    - `[DatabaseAttributesTooltipVariablesIcon <String>]`: 
    - `[DatabaseAttributesTooltipVariablesMessage <String>]`: 
    - `[DeclareRedirectEndpointLabel <String>]`: 
    - `[DeclareRedirectEndpointPosition <Int32?>]`: 
    - `[DeclareRedirectEndpointReadOnly <Boolean?>]`: 
    - `[DeclareRedirectEndpointRequired <Boolean?>]`: 
    - `[DeclareRedirectEndpointTooltipTemplate <String>]`: 
    - `[DeclareRedirectEndpointTooltipVariablesIcon <String>]`: 
    - `[DeclareRedirectEndpointTooltipVariablesMessage <String>]`: 
    - `[DeclareRedirectEndpointType <String>]`: 
    - `[DeclareRedirectEndpointValue <Boolean?>]`: 
    - `[DeclareRedirectEndpointVisible <Boolean?>]`: 
    - `[DefaultTargetUrlLabel <String>]`: 
    - `[DefaultTargetUrlPosition <Int32?>]`: 
    - `[DefaultTargetUrlReadOnly <Boolean?>]`: 
    - `[DefaultTargetUrlRequired <Boolean?>]`: 
    - `[DefaultTargetUrlTooltipTemplate <String>]`: 
    - `[DefaultTargetUrlTooltipVariablesIcon <String>]`: 
    - `[DefaultTargetUrlTooltipVariablesMessage <String>]`: 
    - `[DefaultTargetUrlType <String>]`: 
    - `[DefaultTargetUrlValue <String>]`: 
    - `[DefaultTargetUrlVisible <Boolean?>]`: 
    - `[GroupAttributeNameDependsOnProperty <String>]`: 
    - `[GroupAttributeNameLabel <String>]`: 
    - `[GroupAttributeNamePosition <Int32?>]`: 
    - `[GroupAttributeNameReadOnly <Boolean?>]`: 
    - `[GroupAttributeNameRequired <Boolean?>]`: 
    - `[GroupAttributeNameType <String>]`: 
    - `[GroupAttributeNameValue <String>]`: 
    - `[GroupAttributeNameVisible <Boolean?>]`: 
    - `[GroupsAttributeNameTooltipTemplate <String>]`: 
    - `[GroupsAttributeNameTooltipVariablesIcon <String>]`: 
    - `[GroupsAttributeNameTooltipVariablesMessage <String>]`: 
    - `[IdpCertificateLabel <String>]`: 
    - `[IdpCertificatePosition <Int32?>]`: 
    - `[IdpCertificateReadOnly <Boolean?>]`: 
    - `[IdpCertificateRequired <Boolean?>]`: 
    - `[IdpCertificateTooltipTemplate <String>]`: 
    - `[IdpCertificateTooltipVariablesIcon <String>]`: 
    - `[IdpCertificateTooltipVariablesMessage <String>]`: 
    - `[IdpCertificateType <String>]`: 
    - `[IdpCertificateValue <String>]`: 
    - `[IdpCertificateVisible <Boolean?>]`: 
    - `[IdpEntityIdLabel <String>]`: 
    - `[IdpEntityIdPosition <Int32?>]`: 
    - `[IdpEntityIdReadOnly <Boolean?>]`: 
    - `[IdpEntityIdRequired <Boolean?>]`: 
    - `[IdpEntityIdTooltipTemplate <String>]`: 
    - `[IdpEntityIdTooltipVariablesIcon <String>]`: 
    - `[IdpEntityIdTooltipVariablesMessage <String>]`: 
    - `[IdpEntityIdType <String>]`: 
    - `[IdpEntityIdValue <String>]`: 
    - `[IdpEntityIdVisible <Boolean?>]`: 
    - `[IdpInitUrlLabel <String>]`: 
    - `[IdpInitUrlPosition <Int32?>]`: 
    - `[IdpInitUrlReadOnly <Boolean?>]`: 
    - `[IdpInitUrlRequired <Boolean?>]`: 
    - `[IdpInitUrlTooltipTemplate <String>]`: 
    - `[IdpInitUrlTooltipVariablesIcon <String>]`: 
    - `[IdpInitUrlTooltipVariablesMessage <String>]`: 
    - `[IdpInitUrlType <String>]`: 
    - `[IdpInitUrlValue <String>]`: 
    - `[IdpInitUrlVisible <Boolean?>]`: 
    - `[IdpPrivateKeyLabel <String>]`: 
    - `[IdpPrivateKeyPosition <Int32?>]`: 
    - `[IdpPrivateKeyReadOnly <Boolean?>]`: 
    - `[IdpPrivateKeyRequired <Boolean?>]`: 
    - `[IdpPrivateKeyTooltipTemplate <String>]`: 
    - `[IdpPrivateKeyTooltipVariablesIcon <String>]`: 
    - `[IdpPrivateKeyTooltipVariablesMessage <String>]`: 
    - `[IdpPrivateKeyType <String>]`: 
    - `[IdpPrivateKeyValue <String>]`: 
    - `[IdpPrivateKeyVisible <Boolean?>]`: 
    - `[IncludeGroupLabel <String>]`: 
    - `[IncludeGroupPosition <Int32?>]`: 
    - `[IncludeGroupReadOnly <Boolean?>]`: 
    - `[IncludeGroupRequired <Boolean?>]`: 
    - `[IncludeGroupType <String>]`: 
    - `[IncludeGroupValue <Boolean?>]`: 
    - `[IncludeGroupVisible <Boolean?>]`: 
    - `[IncludeGroupsTooltipTemplate <String>]`: 
    - `[IncludeGroupsTooltipVariablesIcon <String>]`: 
    - `[IncludeGroupsTooltipVariablesMessage <String>]`: 
    - `[OverrideNameIdFormatLabel <String>]`: 
    - `[OverrideNameIdFormatOptions <IApplicationConfigOverrideNameIdFormatOptionsItem[]>]`: 
      - `[Text <String>]`: 
      - `[Value <Int32?>]`: 
    - `[OverrideNameIdFormatPosition <Int32?>]`: 
    - `[OverrideNameIdFormatReadOnly <Boolean?>]`: 
    - `[OverrideNameIdFormatRequired <Boolean?>]`: 
    - `[OverrideNameIdFormatTooltipTemplate <String>]`: 
    - `[OverrideNameIdFormatTooltipVariablesIcon <String>]`: 
    - `[OverrideNameIdFormatTooltipVariablesMessage <String>]`: 
    - `[OverrideNameIdFormatType <String>]`: 
    - `[OverrideNameIdFormatValue <String>]`: 
    - `[OverrideNameIdFormatVisible <Boolean?>]`: 
    - `[SignAssertionLabel <String>]`: 
    - `[SignAssertionPosition <Int32?>]`: 
    - `[SignAssertionReadOnly <Boolean?>]`: 
    - `[SignAssertionRequired <Boolean?>]`: 
    - `[SignAssertionType <String>]`: 
    - `[SignAssertionValue <Boolean?>]`: 
    - `[SignAssertionVisible <Boolean?>]`: 
    - `[SignResponseLabel <String>]`: 
    - `[SignResponsePosition <Int32?>]`: 
    - `[SignResponseReadOnly <Boolean?>]`: 
    - `[SignResponseRequired <Boolean?>]`: 
    - `[SignResponseType <String>]`: 
    - `[SignResponseValue <Boolean?>]`: 
    - `[SignResponseVisible <Boolean?>]`: 
    - `[SignatureAlgorithmLabel <String>]`: 
    - `[SignatureAlgorithmOptions <IApplicationConfigSignatureAlgorithmOptionsItem[]>]`: 
      - `[Text <String>]`: 
      - `[Value <Int32?>]`: 
    - `[SignatureAlgorithmPosition <Int32?>]`: 
    - `[SignatureAlgorithmReadOnly <Boolean?>]`: 
    - `[SignatureAlgorithmRequired <Boolean?>]`: 
    - `[SignatureAlgorithmTooltipTemplate <String>]`: 
    - `[SignatureAlgorithmTooltipVariablesIcon <String>]`: 
    - `[SignatureAlgorithmTooltipVariablesMessage <String>]`: 
    - `[SignatureAlgorithmType <String>]`: 
    - `[SignatureAlgorithmValue <String>]`: 
    - `[SignatureAlgorithmVisible <Boolean?>]`: 
    - `[SpCertificateLabel <String>]`: 
    - `[SpCertificatePosition <Int32?>]`: 
    - `[SpCertificateReadOnly <Boolean?>]`: 
    - `[SpCertificateRequired <Boolean?>]`: 
    - `[SpCertificateTooltipTemplate <String>]`: 
    - `[SpCertificateTooltipVariablesIcon <String>]`: 
    - `[SpCertificateTooltipVariablesMessage <String>]`: 
    - `[SpCertificateType <String>]`: 
    - `[SpCertificateValue <String>]`: 
    - `[SpCertificateVisible <Boolean?>]`: 
    - `[SpEntityIdLabel <String>]`: 
    - `[SpEntityIdPosition <Int32?>]`: 
    - `[SpEntityIdReadOnly <Boolean?>]`: 
    - `[SpEntityIdRequired <Boolean?>]`: 
    - `[SpEntityIdTooltipTemplate <String>]`: 
    - `[SpEntityIdTooltipVariablesIcon <String>]`: 
    - `[SpEntityIdTooltipVariablesMessage <String>]`: 
    - `[SpEntityIdType <String>]`: 
    - `[SpEntityIdValue <String>]`: 
    - `[SpEntityIdVisible <Boolean?>]`: 
    - `[SpErrorFlowLabel <String>]`: 
    - `[SpErrorFlowPosition <Int32?>]`: 
    - `[SpErrorFlowReadOnly <Boolean?>]`: 
    - `[SpErrorFlowRequired <Boolean?>]`: 
    - `[SpErrorFlowTooltipTemplate <String>]`: 
    - `[SpErrorFlowTooltipVariablesIcon <String>]`: 
    - `[SpErrorFlowTooltipVariablesMessage <String>]`: 
    - `[SpErrorFlowType <String>]`: 
    - `[SpErrorFlowValue <Boolean?>]`: 
    - `[SpErrorFlowVisible <Boolean?>]`: 
    - `[SubjectFieldLabel <String>]`: 
    - `[SubjectFieldOptions <IApplicationConfigSubjectFieldOptionsItem[]>]`: 
      - `[Text <String>]`: 
      - `[Value <Int32?>]`: 
    - `[SubjectFieldPosition <Int32?>]`: 
    - `[SubjectFieldReadOnly <Boolean?>]`: 
    - `[SubjectFieldRequired <Boolean?>]`: 
    - `[SubjectFieldTooltipTemplate <String>]`: 
    - `[SubjectFieldTooltipVariablesIcon <String>]`: 
    - `[SubjectFieldTooltipVariablesMessage <String>]`: 
    - `[SubjectFieldType <String>]`: 
    - `[SubjectFieldValue <String>]`: 
    - `[SubjectFieldVisible <Boolean?>]`: 
  - `Name <String>`: 
  - `SsoUrl <String>`: 
  - `[Active <Boolean?>]`: 
  - `[Beta <Boolean?>]`: 
  - `[Color <String>]`: 
  - `[Created <String>]`: 
  - `[DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayLabel <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[LearnMore <String>]`: 
  - `[LogoColor <String>]`: 
  - `[LogoUrl <String>]`: 
  - `[Organization <String>]`: 
  - `[SsoBeta <Boolean?>]`: 
  - `[SsoHidden <Boolean?>]`: 
  - `[SsoIdpCertExpirationAt <DateTime?>]`: 
  - `[SsoJit <Boolean?>]`: 
  - `[SsoType <String>]`: 

CONFIG <IApplicationConfig>: .
  - `[AcUrlLabel <String>]`: 
  - `[AcUrlPosition <Int32?>]`: 
  - `[AcUrlReadOnly <Boolean?>]`: 
  - `[AcUrlRequired <Boolean?>]`: 
  - `[AcUrlType <String>]`: 
  - `[AcUrlValue <String>]`: 
  - `[AcUrlVisible <Boolean?>]`: 
  - `[AcsUrlTooltipTemplate <String>]`: 
  - `[AcsUrlTooltipVariablesIcon <String>]`: 
  - `[AcsUrlTooltipVariablesMessage <String>]`: 
  - `[ConstantAttributeLabel <String>]`: 
  - `[ConstantAttributeMutable <Boolean?>]`: 
  - `[ConstantAttributePosition <Int32?>]`: 
  - `[ConstantAttributeReadOnly <Boolean?>]`: 
  - `[ConstantAttributeRequired <Boolean?>]`: 
  - `[ConstantAttributeType <String>]`: 
  - `[ConstantAttributeValue <IApplicationConfigConstantAttributesValueItem[]>]`: 
    - `[Name <String>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Value <String>]`: 
    - `[Visible <Boolean?>]`: 
  - `[ConstantAttributeVisible <Boolean?>]`: 
  - `[ConstantAttributesTooltipTemplate <String>]`: 
  - `[ConstantAttributesTooltipVariablesIcon <String>]`: 
  - `[ConstantAttributesTooltipVariablesMessage <String>]`: 
  - `[DatabaseAttributeLabel <String>]`: 
  - `[DatabaseAttributePosition <Int32?>]`: 
  - `[DatabaseAttributeReadOnly <Boolean?>]`: 
  - `[DatabaseAttributeRequired <Boolean?>]`: 
  - `[DatabaseAttributeType <String>]`: 
  - `[DatabaseAttributeValue <IApplicationConfigDatabaseAttributesValueItem[]>]`: 
    - `[Name <String>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Value <String>]`: 
    - `[Visible <Boolean?>]`: 
  - `[DatabaseAttributeVisible <Boolean?>]`: 
  - `[DatabaseAttributesTooltipTemplate <String>]`: 
  - `[DatabaseAttributesTooltipVariablesIcon <String>]`: 
  - `[DatabaseAttributesTooltipVariablesMessage <String>]`: 
  - `[DeclareRedirectEndpointLabel <String>]`: 
  - `[DeclareRedirectEndpointPosition <Int32?>]`: 
  - `[DeclareRedirectEndpointReadOnly <Boolean?>]`: 
  - `[DeclareRedirectEndpointRequired <Boolean?>]`: 
  - `[DeclareRedirectEndpointTooltipTemplate <String>]`: 
  - `[DeclareRedirectEndpointTooltipVariablesIcon <String>]`: 
  - `[DeclareRedirectEndpointTooltipVariablesMessage <String>]`: 
  - `[DeclareRedirectEndpointType <String>]`: 
  - `[DeclareRedirectEndpointValue <Boolean?>]`: 
  - `[DeclareRedirectEndpointVisible <Boolean?>]`: 
  - `[DefaultTargetUrlLabel <String>]`: 
  - `[DefaultTargetUrlPosition <Int32?>]`: 
  - `[DefaultTargetUrlReadOnly <Boolean?>]`: 
  - `[DefaultTargetUrlRequired <Boolean?>]`: 
  - `[DefaultTargetUrlTooltipTemplate <String>]`: 
  - `[DefaultTargetUrlTooltipVariablesIcon <String>]`: 
  - `[DefaultTargetUrlTooltipVariablesMessage <String>]`: 
  - `[DefaultTargetUrlType <String>]`: 
  - `[DefaultTargetUrlValue <String>]`: 
  - `[DefaultTargetUrlVisible <Boolean?>]`: 
  - `[GroupAttributeNameDependsOnProperty <String>]`: 
  - `[GroupAttributeNameLabel <String>]`: 
  - `[GroupAttributeNamePosition <Int32?>]`: 
  - `[GroupAttributeNameReadOnly <Boolean?>]`: 
  - `[GroupAttributeNameRequired <Boolean?>]`: 
  - `[GroupAttributeNameType <String>]`: 
  - `[GroupAttributeNameValue <String>]`: 
  - `[GroupAttributeNameVisible <Boolean?>]`: 
  - `[GroupsAttributeNameTooltipTemplate <String>]`: 
  - `[GroupsAttributeNameTooltipVariablesIcon <String>]`: 
  - `[GroupsAttributeNameTooltipVariablesMessage <String>]`: 
  - `[IdpCertificateLabel <String>]`: 
  - `[IdpCertificatePosition <Int32?>]`: 
  - `[IdpCertificateReadOnly <Boolean?>]`: 
  - `[IdpCertificateRequired <Boolean?>]`: 
  - `[IdpCertificateTooltipTemplate <String>]`: 
  - `[IdpCertificateTooltipVariablesIcon <String>]`: 
  - `[IdpCertificateTooltipVariablesMessage <String>]`: 
  - `[IdpCertificateType <String>]`: 
  - `[IdpCertificateValue <String>]`: 
  - `[IdpCertificateVisible <Boolean?>]`: 
  - `[IdpEntityIdLabel <String>]`: 
  - `[IdpEntityIdPosition <Int32?>]`: 
  - `[IdpEntityIdReadOnly <Boolean?>]`: 
  - `[IdpEntityIdRequired <Boolean?>]`: 
  - `[IdpEntityIdTooltipTemplate <String>]`: 
  - `[IdpEntityIdTooltipVariablesIcon <String>]`: 
  - `[IdpEntityIdTooltipVariablesMessage <String>]`: 
  - `[IdpEntityIdType <String>]`: 
  - `[IdpEntityIdValue <String>]`: 
  - `[IdpEntityIdVisible <Boolean?>]`: 
  - `[IdpInitUrlLabel <String>]`: 
  - `[IdpInitUrlPosition <Int32?>]`: 
  - `[IdpInitUrlReadOnly <Boolean?>]`: 
  - `[IdpInitUrlRequired <Boolean?>]`: 
  - `[IdpInitUrlTooltipTemplate <String>]`: 
  - `[IdpInitUrlTooltipVariablesIcon <String>]`: 
  - `[IdpInitUrlTooltipVariablesMessage <String>]`: 
  - `[IdpInitUrlType <String>]`: 
  - `[IdpInitUrlValue <String>]`: 
  - `[IdpInitUrlVisible <Boolean?>]`: 
  - `[IdpPrivateKeyLabel <String>]`: 
  - `[IdpPrivateKeyPosition <Int32?>]`: 
  - `[IdpPrivateKeyReadOnly <Boolean?>]`: 
  - `[IdpPrivateKeyRequired <Boolean?>]`: 
  - `[IdpPrivateKeyTooltipTemplate <String>]`: 
  - `[IdpPrivateKeyTooltipVariablesIcon <String>]`: 
  - `[IdpPrivateKeyTooltipVariablesMessage <String>]`: 
  - `[IdpPrivateKeyType <String>]`: 
  - `[IdpPrivateKeyValue <String>]`: 
  - `[IdpPrivateKeyVisible <Boolean?>]`: 
  - `[IncludeGroupLabel <String>]`: 
  - `[IncludeGroupPosition <Int32?>]`: 
  - `[IncludeGroupReadOnly <Boolean?>]`: 
  - `[IncludeGroupRequired <Boolean?>]`: 
  - `[IncludeGroupType <String>]`: 
  - `[IncludeGroupValue <Boolean?>]`: 
  - `[IncludeGroupVisible <Boolean?>]`: 
  - `[IncludeGroupsTooltipTemplate <String>]`: 
  - `[IncludeGroupsTooltipVariablesIcon <String>]`: 
  - `[IncludeGroupsTooltipVariablesMessage <String>]`: 
  - `[OverrideNameIdFormatLabel <String>]`: 
  - `[OverrideNameIdFormatOptions <IApplicationConfigOverrideNameIdFormatOptionsItem[]>]`: 
    - `[Text <String>]`: 
    - `[Value <Int32?>]`: 
  - `[OverrideNameIdFormatPosition <Int32?>]`: 
  - `[OverrideNameIdFormatReadOnly <Boolean?>]`: 
  - `[OverrideNameIdFormatRequired <Boolean?>]`: 
  - `[OverrideNameIdFormatTooltipTemplate <String>]`: 
  - `[OverrideNameIdFormatTooltipVariablesIcon <String>]`: 
  - `[OverrideNameIdFormatTooltipVariablesMessage <String>]`: 
  - `[OverrideNameIdFormatType <String>]`: 
  - `[OverrideNameIdFormatValue <String>]`: 
  - `[OverrideNameIdFormatVisible <Boolean?>]`: 
  - `[SignAssertionLabel <String>]`: 
  - `[SignAssertionPosition <Int32?>]`: 
  - `[SignAssertionReadOnly <Boolean?>]`: 
  - `[SignAssertionRequired <Boolean?>]`: 
  - `[SignAssertionType <String>]`: 
  - `[SignAssertionValue <Boolean?>]`: 
  - `[SignAssertionVisible <Boolean?>]`: 
  - `[SignResponseLabel <String>]`: 
  - `[SignResponsePosition <Int32?>]`: 
  - `[SignResponseReadOnly <Boolean?>]`: 
  - `[SignResponseRequired <Boolean?>]`: 
  - `[SignResponseType <String>]`: 
  - `[SignResponseValue <Boolean?>]`: 
  - `[SignResponseVisible <Boolean?>]`: 
  - `[SignatureAlgorithmLabel <String>]`: 
  - `[SignatureAlgorithmOptions <IApplicationConfigSignatureAlgorithmOptionsItem[]>]`: 
    - `[Text <String>]`: 
    - `[Value <Int32?>]`: 
  - `[SignatureAlgorithmPosition <Int32?>]`: 
  - `[SignatureAlgorithmReadOnly <Boolean?>]`: 
  - `[SignatureAlgorithmRequired <Boolean?>]`: 
  - `[SignatureAlgorithmTooltipTemplate <String>]`: 
  - `[SignatureAlgorithmTooltipVariablesIcon <String>]`: 
  - `[SignatureAlgorithmTooltipVariablesMessage <String>]`: 
  - `[SignatureAlgorithmType <String>]`: 
  - `[SignatureAlgorithmValue <String>]`: 
  - `[SignatureAlgorithmVisible <Boolean?>]`: 
  - `[SpCertificateLabel <String>]`: 
  - `[SpCertificatePosition <Int32?>]`: 
  - `[SpCertificateReadOnly <Boolean?>]`: 
  - `[SpCertificateRequired <Boolean?>]`: 
  - `[SpCertificateTooltipTemplate <String>]`: 
  - `[SpCertificateTooltipVariablesIcon <String>]`: 
  - `[SpCertificateTooltipVariablesMessage <String>]`: 
  - `[SpCertificateType <String>]`: 
  - `[SpCertificateValue <String>]`: 
  - `[SpCertificateVisible <Boolean?>]`: 
  - `[SpEntityIdLabel <String>]`: 
  - `[SpEntityIdPosition <Int32?>]`: 
  - `[SpEntityIdReadOnly <Boolean?>]`: 
  - `[SpEntityIdRequired <Boolean?>]`: 
  - `[SpEntityIdTooltipTemplate <String>]`: 
  - `[SpEntityIdTooltipVariablesIcon <String>]`: 
  - `[SpEntityIdTooltipVariablesMessage <String>]`: 
  - `[SpEntityIdType <String>]`: 
  - `[SpEntityIdValue <String>]`: 
  - `[SpEntityIdVisible <Boolean?>]`: 
  - `[SpErrorFlowLabel <String>]`: 
  - `[SpErrorFlowPosition <Int32?>]`: 
  - `[SpErrorFlowReadOnly <Boolean?>]`: 
  - `[SpErrorFlowRequired <Boolean?>]`: 
  - `[SpErrorFlowTooltipTemplate <String>]`: 
  - `[SpErrorFlowTooltipVariablesIcon <String>]`: 
  - `[SpErrorFlowTooltipVariablesMessage <String>]`: 
  - `[SpErrorFlowType <String>]`: 
  - `[SpErrorFlowValue <Boolean?>]`: 
  - `[SpErrorFlowVisible <Boolean?>]`: 
  - `[SubjectFieldLabel <String>]`: 
  - `[SubjectFieldOptions <IApplicationConfigSubjectFieldOptionsItem[]>]`: 
    - `[Text <String>]`: 
    - `[Value <Int32?>]`: 
  - `[SubjectFieldPosition <Int32?>]`: 
  - `[SubjectFieldReadOnly <Boolean?>]`: 
  - `[SubjectFieldRequired <Boolean?>]`: 
  - `[SubjectFieldTooltipTemplate <String>]`: 
  - `[SubjectFieldTooltipVariablesIcon <String>]`: 
  - `[SubjectFieldTooltipVariablesMessage <String>]`: 
  - `[SubjectFieldType <String>]`: 
  - `[SubjectFieldValue <String>]`: 
  - `[SubjectFieldVisible <Boolean?>]`: 

INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

