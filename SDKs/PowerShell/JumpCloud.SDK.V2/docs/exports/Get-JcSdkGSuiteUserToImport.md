---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkGSuiteUserToImport.md
schema: 2.0.0
---

# Get-JcSdkGSuiteUserToImport

## SYNOPSIS
Lists G Suite users available for import.

## SYNTAX

```
Get-JcSdkGSuiteUserToImport -GsuiteId <String> [-MaxResults <Int32>] [-OrderBy <String>] [-PageToken <String>]
 [-Query <String>] [-SortOrder <String>] [<CommonParameters>]
```

## DESCRIPTION
Lists G Suite users available for import.

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

### -GsuiteId
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

### -MaxResults
Google Directory API maximum number of results per page.
See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.

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

### -OrderBy
Google Directory API sort field parameter.
See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.

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

### -PageToken
Google Directory API token used to access the next page of results.
See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.

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

### -Query
Google Directory API search parameter.
See https://developers.google.com/admin-sdk/directory/v1/guides/search-users.

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

### -SortOrder
Google Directory API sort direction parameter.
See https://developers.google.com/admin-sdk/directory/reference/rest/v1/users/list.

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### JumpCloud.SDK.V2.Models.IPathsC7Pl4LGsuitesGsuiteIdImportUsersGetResponses200ContentApplicationJsonSchema

## NOTES

ALIASES

## RELATED LINKS

