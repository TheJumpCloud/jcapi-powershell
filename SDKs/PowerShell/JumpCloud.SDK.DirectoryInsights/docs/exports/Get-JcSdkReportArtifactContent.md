---
external help file:
Module Name: JumpCloud.SDK.DirectoryInsights
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/docs/exports/Get-JcSdkReportArtifactContent.md
schema: 2.0.0
---

# Get-JcSdkReportArtifactContent

## SYNOPSIS
Download a report by report ID and artifact ID

## SYNTAX

### Get (Default)
```
Get-JcSdkReportArtifactContent -HostEnv <String> -ArtifactId <String> -ReportId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkReportArtifactContent -HostEnv <String> -InputObject <IDirectoryInsightsApiIdentity>
 [<CommonParameters>]
```

## DESCRIPTION
Download a report by report ID and artifact ID

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -ArtifactId
Artifact ID

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostEnv
Region for JumpCloud API host.
Use 'api' for US or 'api.eu' for EU.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.DirectoryInsights.Models.IDirectoryInsightsApiIdentity
Parameter Sets: GetViaIdentity
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
Parameter Sets: Get
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

### JumpCloud.SDK.DirectoryInsights.Models.IDictionaryOfany

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IDirectoryInsightsApiIdentity>`: Identity Parameter
  - `[ArtifactId <String>]`: Artifact ID
  - `[ReportId <String>]`: Report ID
  - `[ReportType <String>]`: Report Type

## RELATED LINKS

