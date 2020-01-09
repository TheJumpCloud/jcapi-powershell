---
external help file:
Module Name: JumpCloudApiSdkV1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdkapplication
schema: 2.0.0
---

# New-JcSdkApplication

## SYNOPSIS
The endpoint adds a new SSO / SAML Applications.

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkApplication [-Accept <String>] [-ContentType <String>] [-XOrgId <String>] [-Beta]
 [-Config <IApplicationConfig>] [-Created <String>] [-DisplayLabel <String>] [-DisplayName <String>]
 [-Id <String>] [-LearnMore <String>] [-Name <String>] [-Organization <String>] [-SsoUrl <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkApplication -Body <IApplication> [-Accept <String>] [-ContentType <String>] [-XOrgId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The endpoint adds a new SSO / SAML Applications.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdkapplication
```



## PARAMETERS

### -Accept
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Beta
HELP MESSAGE MISSING

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Body
Application
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.IApplication
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Config
HELP MESSAGE MISSING
To construct, see NOTES section for CONFIG properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.IApplicationConfig
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ContentType
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Created
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayLabel
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LearnMore
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Organization
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SsoUrl
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -XOrgId
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloudApiSdkV1.Models.IApplication

## OUTPUTS

### JumpCloudApiSdkV1.Models.IApplication

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IApplication>: Application
  - `[Beta <Boolean?>]`: 
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
  - `[DisplayLabel <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[LearnMore <String>]`: 
  - `[Name <String>]`: 
  - `[Organization <String>]`: 
  - `[SsoUrl <String>]`: 

#### CONFIG <IApplicationConfig>: HELP MESSAGE MISSING
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

