---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkOffice365UserToImport.md
schema: 2.0.0
---

# Get-JcSdkOffice365UserToImport

## SYNOPSIS
Lists Office 365 users available for import.

## SYNTAX

```
Get-JcSdkOffice365UserToImport -Office365Id <String> [-Count] [-Filter <String>] [-Orderby <String>]
 [-Search <String>] [-SkipToken <String>] [-Top <Int32>] [-ConsistencyLevel <String>] [<CommonParameters>]
```

## DESCRIPTION
Lists Office 365 users available for import.

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

### -ConsistencyLevel
Defines the consistency header for O365 requests.
See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#request-headers

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Count
Office 365 API count parameter.
See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Office 365 API filter parameter.
See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Office365Id
.

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

### -Orderby
Office 365 API orderby parameter.
See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Office 365 API search parameter.
See https://docs.microsoft.com/en-us/graph/api/user-list?view=graph-rest-1.0&tabs=http#optional-query-parameters.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipToken
Office 365 API token used to access the next page of results.
See https://docs.microsoft.com/en-us/graph/paging.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Office 365 API maximum number of results per page.
See https://docs.microsoft.com/en-us/graph/paging.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPaths1J0ThkrOffice365SOffice365IdImportUsersGetResponses200ContentApplicationJsonSchema

## NOTES

ALIASES

## RELATED LINKS

