---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkApplication.md
schema: 2.0.0
---

# New-JcSdkApplication

## SYNOPSIS
The endpoint adds a new SSO / SAML Applications.

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkApplication [-Beta] [-Color <String>] [-Config <IApplicationConfig>] [-Created <String>]
 [-DatabaseAttributes <IApplicationDatabaseAttributesItem[]>] [-Description <String>] [-DisplayLabel <String>]
 [-DisplayName <String>] [-Id <String>] [-LearnMore <String>] [-LogoColor <String>] [-LogoUrl <String>]
 [-Name <String>] [-Organization <String>] [-SsoUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkApplication -Body <IApplication> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The endpoint adds a new SSO / SAML Applications.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Beta
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Created
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LearnMore
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Organization
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
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

## OUTPUTS

### JumpCloud.SDK.V1.Models.IApplication

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IApplication>: Application
  - `[Beta <Boolean?>]`: 
  - `[Color <String>]`: 
  - `[Config <IApplicationConfig>]`: 
    - `[AcUrlLabel <String>]`: 
    - `[AcUrlOptions <String>]`: 
    - `[AcUrlPosition <Int32?>]`: 
    - `[AcUrlReadOnly <Boolean?>]`: 
    - `[AcUrlRequired <Boolean?>]`: 
    - `[AcUrlToggle <String>]`: 
    - `[AcUrlType <String>]`: 
    - `[AcUrlValue <String>]`: 
    - `[AcUrlVisible <Boolean?>]`: 
    - `[AcsUrlTooltipTemplate <String>]`: 
    - `[AcsUrlTooltipVariablesIcon <String>]`: 
    - `[AcsUrlTooltipVariablesMessage <String>]`: 
    - `[ConstantAttributeLabel <String>]`: 
    - `[ConstantAttributeMutable <Boolean?>]`: 
    - `[ConstantAttributeOptions <String>]`: 
    - `[ConstantAttributePosition <Int32?>]`: 
    - `[ConstantAttributeReadOnly <Boolean?>]`: 
    - `[ConstantAttributeRequired <Boolean?>]`: 
    - `[ConstantAttributeToggle <String>]`: 
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
    - `[DatabaseAttributePosition <Int32?>]`: 
    - `[IdpCertificateLabel <String>]`: 
    - `[IdpCertificateOptions <String>]`: 
    - `[IdpCertificatePosition <Int32?>]`: 
    - `[IdpCertificateReadOnly <Boolean?>]`: 
    - `[IdpCertificateRequired <Boolean?>]`: 
    - `[IdpCertificateToggle <String>]`: 
    - `[IdpCertificateTooltipTemplate <String>]`: 
    - `[IdpCertificateTooltipVariablesIcon <String>]`: 
    - `[IdpCertificateTooltipVariablesMessage <String>]`: 
    - `[IdpCertificateType <String>]`: 
    - `[IdpCertificateValue <String>]`: 
    - `[IdpCertificateVisible <Boolean?>]`: 
    - `[IdpEntityIdLabel <String>]`: 
    - `[IdpEntityIdOptions <String>]`: 
    - `[IdpEntityIdPosition <Int32?>]`: 
    - `[IdpEntityIdReadOnly <Boolean?>]`: 
    - `[IdpEntityIdRequired <Boolean?>]`: 
    - `[IdpEntityIdToggle <String>]`: 
    - `[IdpEntityIdTooltipTemplate <String>]`: 
    - `[IdpEntityIdTooltipVariablesIcon <String>]`: 
    - `[IdpEntityIdTooltipVariablesMessage <String>]`: 
    - `[IdpEntityIdType <String>]`: 
    - `[IdpEntityIdValue <String>]`: 
    - `[IdpEntityIdVisible <Boolean?>]`: 
    - `[IdpPrivateKeyLabel <String>]`: 
    - `[IdpPrivateKeyOptions <String>]`: 
    - `[IdpPrivateKeyPosition <Int32?>]`: 
    - `[IdpPrivateKeyReadOnly <Boolean?>]`: 
    - `[IdpPrivateKeyRequired <Boolean?>]`: 
    - `[IdpPrivateKeyToggle <String>]`: 
    - `[IdpPrivateKeyTooltipTemplate <String>]`: 
    - `[IdpPrivateKeyTooltipVariablesIcon <String>]`: 
    - `[IdpPrivateKeyTooltipVariablesMessage <String>]`: 
    - `[IdpPrivateKeyType <String>]`: 
    - `[IdpPrivateKeyValue <String>]`: 
    - `[IdpPrivateKeyVisible <Boolean?>]`: 
    - `[SpEntityIdLabel <String>]`: 
    - `[SpEntityIdOptions <String>]`: 
    - `[SpEntityIdPosition <Int32?>]`: 
    - `[SpEntityIdReadOnly <Boolean?>]`: 
    - `[SpEntityIdRequired <Boolean?>]`: 
    - `[SpEntityIdToggle <String>]`: 
    - `[SpEntityIdTooltipTemplate <String>]`: 
    - `[SpEntityIdTooltipVariablesIcon <String>]`: 
    - `[SpEntityIdTooltipVariablesMessage <String>]`: 
    - `[SpEntityIdType <String>]`: 
    - `[SpEntityIdValue <String>]`: 
    - `[SpEntityIdVisible <Boolean?>]`: 
  - `[Created <String>]`: 
  - `[DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayLabel <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[LearnMore <String>]`: 
  - `[LogoColor <String>]`: 
  - `[LogoUrl <String>]`: 
  - `[Name <String>]`: 
  - `[Organization <String>]`: 
  - `[SsoUrl <String>]`: 

CONFIG <IApplicationConfig>: .
  - `[AcUrlLabel <String>]`: 
  - `[AcUrlOptions <String>]`: 
  - `[AcUrlPosition <Int32?>]`: 
  - `[AcUrlReadOnly <Boolean?>]`: 
  - `[AcUrlRequired <Boolean?>]`: 
  - `[AcUrlToggle <String>]`: 
  - `[AcUrlType <String>]`: 
  - `[AcUrlValue <String>]`: 
  - `[AcUrlVisible <Boolean?>]`: 
  - `[AcsUrlTooltipTemplate <String>]`: 
  - `[AcsUrlTooltipVariablesIcon <String>]`: 
  - `[AcsUrlTooltipVariablesMessage <String>]`: 
  - `[ConstantAttributeLabel <String>]`: 
  - `[ConstantAttributeMutable <Boolean?>]`: 
  - `[ConstantAttributeOptions <String>]`: 
  - `[ConstantAttributePosition <Int32?>]`: 
  - `[ConstantAttributeReadOnly <Boolean?>]`: 
  - `[ConstantAttributeRequired <Boolean?>]`: 
  - `[ConstantAttributeToggle <String>]`: 
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
  - `[DatabaseAttributePosition <Int32?>]`: 
  - `[IdpCertificateLabel <String>]`: 
  - `[IdpCertificateOptions <String>]`: 
  - `[IdpCertificatePosition <Int32?>]`: 
  - `[IdpCertificateReadOnly <Boolean?>]`: 
  - `[IdpCertificateRequired <Boolean?>]`: 
  - `[IdpCertificateToggle <String>]`: 
  - `[IdpCertificateTooltipTemplate <String>]`: 
  - `[IdpCertificateTooltipVariablesIcon <String>]`: 
  - `[IdpCertificateTooltipVariablesMessage <String>]`: 
  - `[IdpCertificateType <String>]`: 
  - `[IdpCertificateValue <String>]`: 
  - `[IdpCertificateVisible <Boolean?>]`: 
  - `[IdpEntityIdLabel <String>]`: 
  - `[IdpEntityIdOptions <String>]`: 
  - `[IdpEntityIdPosition <Int32?>]`: 
  - `[IdpEntityIdReadOnly <Boolean?>]`: 
  - `[IdpEntityIdRequired <Boolean?>]`: 
  - `[IdpEntityIdToggle <String>]`: 
  - `[IdpEntityIdTooltipTemplate <String>]`: 
  - `[IdpEntityIdTooltipVariablesIcon <String>]`: 
  - `[IdpEntityIdTooltipVariablesMessage <String>]`: 
  - `[IdpEntityIdType <String>]`: 
  - `[IdpEntityIdValue <String>]`: 
  - `[IdpEntityIdVisible <Boolean?>]`: 
  - `[IdpPrivateKeyLabel <String>]`: 
  - `[IdpPrivateKeyOptions <String>]`: 
  - `[IdpPrivateKeyPosition <Int32?>]`: 
  - `[IdpPrivateKeyReadOnly <Boolean?>]`: 
  - `[IdpPrivateKeyRequired <Boolean?>]`: 
  - `[IdpPrivateKeyToggle <String>]`: 
  - `[IdpPrivateKeyTooltipTemplate <String>]`: 
  - `[IdpPrivateKeyTooltipVariablesIcon <String>]`: 
  - `[IdpPrivateKeyTooltipVariablesMessage <String>]`: 
  - `[IdpPrivateKeyType <String>]`: 
  - `[IdpPrivateKeyValue <String>]`: 
  - `[IdpPrivateKeyVisible <Boolean?>]`: 
  - `[SpEntityIdLabel <String>]`: 
  - `[SpEntityIdOptions <String>]`: 
  - `[SpEntityIdPosition <Int32?>]`: 
  - `[SpEntityIdReadOnly <Boolean?>]`: 
  - `[SpEntityIdRequired <Boolean?>]`: 
  - `[SpEntityIdToggle <String>]`: 
  - `[SpEntityIdTooltipTemplate <String>]`: 
  - `[SpEntityIdTooltipVariablesIcon <String>]`: 
  - `[SpEntityIdTooltipVariablesMessage <String>]`: 
  - `[SpEntityIdType <String>]`: 
  - `[SpEntityIdValue <String>]`: 
  - `[SpEntityIdVisible <Boolean?>]`: 

## RELATED LINKS

