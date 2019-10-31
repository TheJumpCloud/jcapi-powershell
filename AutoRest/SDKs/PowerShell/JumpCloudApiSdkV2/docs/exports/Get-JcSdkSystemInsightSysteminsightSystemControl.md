---
external help file:
Module Name: JumpCloudApiSdkV2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/get-jcsdksysteminsightsysteminsightsystemcontrol
schema: 2.0.0
---

# Get-JcSdkSystemInsightSysteminsightSystemControl

## SYNOPSIS
Valid filter fields are `system_id` and `name`.

## SYNTAX

### List (Default)
```
Get-JcSdkSystemInsightSysteminsightSystemControl [-Filter <String[]>] [-Limit <Int32>] [-Skip <Int32>]
 [<CommonParameters>]
```

### List1
```
Get-JcSdkSystemInsightSysteminsightSystemControl -SystemId <String> [-Filter <String[]>] [-Limit <Int32>]
 [-Skip <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Valid filter fields are `system_id` and `name`.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv2/get-jcsdksysteminsightsysteminsightsystemcontrol
```



## PARAMETERS

### -Filter
Supported operators are: eq

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Limit
HELP MESSAGE MISSING

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Skip
The offset into the records to return.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SystemId
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloudApiSdkV2.Models.ISystemInsightsBitlockerInfo

### JumpCloudApiSdkV2.Models.ISystemInsightsSystemControls

## ALIASES

## NOTES

## RELATED LINKS

