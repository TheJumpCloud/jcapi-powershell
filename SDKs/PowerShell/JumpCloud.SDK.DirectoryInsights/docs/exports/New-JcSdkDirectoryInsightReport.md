---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/New-JcSdkDirectoryInsightReport.md
schema: 2.0.0
---

# New-JcSdkDirectoryInsightReport

## SYNOPSIS
Request a JumpCloud report to be generated asynchronously

## SYNTAX

### Create (Default)
```
New-JcSdkDirectoryInsightReport -ReportType <ReportType1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkDirectoryInsightReport -InputObject <IDirectoryInsightsApiIdentity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Request a JumpCloud report to be generated asynchronously

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity
Parameter Sets: CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ReportType
Report Type

```yaml
Type: JumpCloud.SDK.DirectoryInsights.Support.ReportType1
Parameter Sets: Create
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

### JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity

## OUTPUTS

### JumpCloud.SDK.DirectoryInsights.Models.IPathsE6Q3GdReportsReportTypePostResponses202ContentApplicationJsonSchema

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDirectoryInsightsApiIdentity>: Identity Parameter
  - `[ArtifactId <String>]`: Artifact ID
  - `[ReportId <String>]`: Report ID
  - `[ReportType <ReportType1?>]`: Report Type

## RELATED LINKS

