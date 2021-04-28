---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Set-JcSdkApplication.md
schema: 2.0.0
---

# Set-JcSdkApplication

## SYNOPSIS
The endpoint updates a SSO / SAML Application.

## SYNTAX

### SetExpanded (Default)
```
Set-JcSdkApplication -Id <String> [-Beta] [-Color <String>] [-Config <IApplicationConfig>] [-Created <String>]
 [-DatabaseAttributes <IApplicationDatabaseAttributesItem[]>] [-Description <String>] [-DisplayLabel <String>]
 [-DisplayName <String>] [-Id1 <String>] [-LearnMore <String>] [-Logo <IApplicationLogo>] [-Name <String>]
 [-Organization <String>] [-Sso <IApplicationSso>] [-SsoUrl <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Set
```
Set-JcSdkApplication -Id <String> -Body <IApplication> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentity
```
Set-JcSdkApplication -InputObject <IJumpCloudSdkV1Identity> -Body <IApplication> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Set-JcSdkApplication -InputObject <IJumpCloudSdkV1Identity> [-Id <String>] [-Beta] [-Color <String>]
 [-Config <IApplicationConfig>] [-Created <String>]
 [-DatabaseAttributes <IApplicationDatabaseAttributesItem[]>] [-Description <String>] [-DisplayLabel <String>]
 [-DisplayName <String>] [-LearnMore <String>] [-Logo <IApplicationLogo>] [-Name <String>]
 [-Organization <String>] [-Sso <IApplicationSso>] [-SsoUrl <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
The endpoint updates a SSO / SAML Application.

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
Type: JumpCloud.SDK.V1.Models.IJumpCloudSdkV1Identity
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

### -Logo
.
To construct, see NOTES section for LOGO properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IApplicationLogo
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
Parameter Sets: SetExpanded, SetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sso
.
To construct, see NOTES section for SSO properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IApplicationSso
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

### JumpCloud.SDK.V1.Models.IJumpCloudSdkV1Identity

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
    - `[AcsUrl <IApplicationConfigAcsUrl>]`: 
      - `[Label <String>]`: 
      - `[Options <String>]`: 
      - `[Position <Int32?>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Toggle <String>]`: 
      - `[Tooltip <IApplicationConfigAcsUrlTooltip>]`: 
        - `[Template <String>]`: 
        - `[Variables <IApplicationConfigAcsUrlTooltipVariables>]`: 
          - `[Icon <String>]`: 
          - `[Message <String>]`: 
      - `[Type <String>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
    - `[ConstantAttributes <IApplicationConfigConstantAttributes>]`: 
      - `[Label <String>]`: 
      - `[Mutable <Boolean?>]`: 
      - `[Options <String>]`: 
      - `[Position <Int32?>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Toggle <String>]`: 
      - `[Tooltip <IApplicationConfigConstantAttributesTooltip>]`: 
        - `[Template <String>]`: 
        - `[Variables <IApplicationConfigConstantAttributesTooltipVariables>]`: 
          - `[Icon <String>]`: 
          - `[Message <String>]`: 
      - `[Type <String>]`: 
      - `[Value <IApplicationConfigConstantAttributesValueItem[]>]`: 
        - `[Name <String>]`: 
        - `[ReadOnly <Boolean?>]`: 
        - `[Required <Boolean?>]`: 
        - `[Value <String>]`: 
        - `[Visible <Boolean?>]`: 
      - `[Visible <Boolean?>]`: 
    - `[DatabaseAttributes <IApplicationConfigDatabaseAttributes>]`: 
      - `[Position <Int32?>]`: 
    - `[IdpCertificate <IApplicationConfigIdpCertificate>]`: 
      - `[Label <String>]`: 
      - `[Options <String>]`: 
      - `[Position <Int32?>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Toggle <String>]`: 
      - `[Tooltip <IApplicationConfigIdpCertificateTooltip>]`: 
        - `[Template <String>]`: 
        - `[Variables <IApplicationConfigIdpCertificateTooltipVariables>]`: 
          - `[Icon <String>]`: 
          - `[Message <String>]`: 
      - `[Type <String>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
    - `[IdpEntityId <IApplicationConfigIdpEntityId>]`: 
      - `[Label <String>]`: 
      - `[Options <String>]`: 
      - `[Position <Int32?>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Toggle <String>]`: 
      - `[Tooltip <IApplicationConfigIdpEntityIdTooltip>]`: 
        - `[Template <String>]`: 
        - `[Variables <IApplicationConfigIdpEntityIdTooltipVariables>]`: 
          - `[Icon <String>]`: 
          - `[Message <String>]`: 
      - `[Type <String>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
    - `[IdpPrivateKey <IApplicationConfigIdpPrivateKey>]`: 
      - `[Label <String>]`: 
      - `[Options <String>]`: 
      - `[Position <Int32?>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Toggle <String>]`: 
      - `[Tooltip <IApplicationConfigIdpPrivateKeyTooltip>]`: 
        - `[Template <String>]`: 
        - `[Variables <IApplicationConfigIdpPrivateKeyTooltipVariables>]`: 
          - `[Icon <String>]`: 
          - `[Message <String>]`: 
      - `[Type <String>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
    - `[SpEntityId <IApplicationConfigSpEntityId>]`: 
      - `[Label <String>]`: 
      - `[Options <String>]`: 
      - `[Position <Int32?>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Toggle <String>]`: 
      - `[Tooltip <IApplicationConfigSpEntityIdTooltip>]`: 
        - `[Template <String>]`: 
        - `[Variables <IApplicationConfigSpEntityIdTooltipVariables>]`: 
          - `[Icon <String>]`: 
          - `[Message <String>]`: 
      - `[Type <String>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
  - `[Created <String>]`: 
  - `[DatabaseAttributes <IApplicationDatabaseAttributesItem[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayLabel <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Id <String>]`: 
  - `[LearnMore <String>]`: 
  - `[Logo <IApplicationLogo>]`: 
    - `[Color <String>]`: 
    - `[Url <String>]`: 
  - `[Name <String>]`: 
  - `[Organization <String>]`: 
  - `[Sso <IApplicationSso>]`: 
    - `[Beta <Boolean?>]`: 
    - `[Jit <Boolean?>]`: 
    - `[Type <String>]`: 
  - `[SsoUrl <String>]`: 

CONFIG <IApplicationConfig>: .
  - `[AcsUrl <IApplicationConfigAcsUrl>]`: 
    - `[Label <String>]`: 
    - `[Options <String>]`: 
    - `[Position <Int32?>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Toggle <String>]`: 
    - `[Tooltip <IApplicationConfigAcsUrlTooltip>]`: 
      - `[Template <String>]`: 
      - `[Variables <IApplicationConfigAcsUrlTooltipVariables>]`: 
        - `[Icon <String>]`: 
        - `[Message <String>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
    - `[Visible <Boolean?>]`: 
  - `[ConstantAttributes <IApplicationConfigConstantAttributes>]`: 
    - `[Label <String>]`: 
    - `[Mutable <Boolean?>]`: 
    - `[Options <String>]`: 
    - `[Position <Int32?>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Toggle <String>]`: 
    - `[Tooltip <IApplicationConfigConstantAttributesTooltip>]`: 
      - `[Template <String>]`: 
      - `[Variables <IApplicationConfigConstantAttributesTooltipVariables>]`: 
        - `[Icon <String>]`: 
        - `[Message <String>]`: 
    - `[Type <String>]`: 
    - `[Value <IApplicationConfigConstantAttributesValueItem[]>]`: 
      - `[Name <String>]`: 
      - `[ReadOnly <Boolean?>]`: 
      - `[Required <Boolean?>]`: 
      - `[Value <String>]`: 
      - `[Visible <Boolean?>]`: 
    - `[Visible <Boolean?>]`: 
  - `[DatabaseAttributes <IApplicationConfigDatabaseAttributes>]`: 
    - `[Position <Int32?>]`: 
  - `[IdpCertificate <IApplicationConfigIdpCertificate>]`: 
    - `[Label <String>]`: 
    - `[Options <String>]`: 
    - `[Position <Int32?>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Toggle <String>]`: 
    - `[Tooltip <IApplicationConfigIdpCertificateTooltip>]`: 
      - `[Template <String>]`: 
      - `[Variables <IApplicationConfigIdpCertificateTooltipVariables>]`: 
        - `[Icon <String>]`: 
        - `[Message <String>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
    - `[Visible <Boolean?>]`: 
  - `[IdpEntityId <IApplicationConfigIdpEntityId>]`: 
    - `[Label <String>]`: 
    - `[Options <String>]`: 
    - `[Position <Int32?>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Toggle <String>]`: 
    - `[Tooltip <IApplicationConfigIdpEntityIdTooltip>]`: 
      - `[Template <String>]`: 
      - `[Variables <IApplicationConfigIdpEntityIdTooltipVariables>]`: 
        - `[Icon <String>]`: 
        - `[Message <String>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
    - `[Visible <Boolean?>]`: 
  - `[IdpPrivateKey <IApplicationConfigIdpPrivateKey>]`: 
    - `[Label <String>]`: 
    - `[Options <String>]`: 
    - `[Position <Int32?>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Toggle <String>]`: 
    - `[Tooltip <IApplicationConfigIdpPrivateKeyTooltip>]`: 
      - `[Template <String>]`: 
      - `[Variables <IApplicationConfigIdpPrivateKeyTooltipVariables>]`: 
        - `[Icon <String>]`: 
        - `[Message <String>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
    - `[Visible <Boolean?>]`: 
  - `[SpEntityId <IApplicationConfigSpEntityId>]`: 
    - `[Label <String>]`: 
    - `[Options <String>]`: 
    - `[Position <Int32?>]`: 
    - `[ReadOnly <Boolean?>]`: 
    - `[Required <Boolean?>]`: 
    - `[Toggle <String>]`: 
    - `[Tooltip <IApplicationConfigSpEntityIdTooltip>]`: 
      - `[Template <String>]`: 
      - `[Variables <IApplicationConfigSpEntityIdTooltipVariables>]`: 
        - `[Icon <String>]`: 
        - `[Message <String>]`: 
    - `[Type <String>]`: 
    - `[Value <String>]`: 
    - `[Visible <Boolean?>]`: 

INPUTOBJECT <IJumpCloudSdkV1Identity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

LOGO <IApplicationLogo>: .
  - `[Color <String>]`: 
  - `[Url <String>]`: 

SSO <IApplicationSso>: .
  - `[Beta <Boolean?>]`: 
  - `[Jit <Boolean?>]`: 
  - `[Type <String>]`: 

## RELATED LINKS

