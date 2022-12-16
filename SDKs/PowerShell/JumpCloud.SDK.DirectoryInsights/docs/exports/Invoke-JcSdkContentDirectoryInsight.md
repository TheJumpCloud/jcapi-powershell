---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Invoke-JcSdkContentDirectoryInsight.md
schema: 2.0.0
---

# Invoke-JcSdkContentDirectoryInsight

## SYNOPSIS
Download a report by report ID and artifact ID

## SYNTAX

### Content (Default)
```
Invoke-JcSdkContentDirectoryInsight -ArtifactId <String> -ReportId <String> [<CommonParameters>]
```

### ContentViaIdentity
```
Invoke-JcSdkContentDirectoryInsight -InputObject <IDirectoryInsightsApiIdentity> [<CommonParameters>]
```

## DESCRIPTION
Download a report by report ID and artifact ID

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

### -ArtifactId
Artifact ID

```yaml
Type: System.String
Parameter Sets: Content
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity
Parameter Sets: ContentViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ReportId
Report ID

```yaml
Type: System.String
Parameter Sets: Content
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDirectoryInsightsApiIdentity>: Identity Parameter
  - `[ArtifactId <String>]`: Artifact ID
  - `[ReportId <String>]`: Report ID
  - `[ReportType <ReportType1?>]`: Report Type

## RELATED LINKS
