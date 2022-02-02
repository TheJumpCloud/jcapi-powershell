---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkBulkUser.md
schema: 2.0.0
---

# New-JcSdkBulkUser

## SYNOPSIS
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_post) for full list of attributes.

#### Sample Request 
```
curl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t\t\"email\":\"{email}\",
\t\t\"firstname\":\"{firstname}\",
\t\t\"lastname\":\"{firstname}\",
\t\t\"username\":\"{username}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},
\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}
\t\t]
\t}
]
```

## SYNTAX

```
New-JcSdkBulkUser -Body <IBulkUserCreate[]> [-CreationSource <CreationSource>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
The endpoint allows you to create a bulk job to asynchronously create users.
See [Create a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_post) for full list of attributes.

#### Sample Request 
```
curl -X POST https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t\t\"email\":\"{email}\",
\t\t\"firstname\":\"{firstname}\",
\t\t\"lastname\":\"{firstname}\",
\t\t\"username\":\"{username}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"EmployeeID\",\"value\":\"0000\"},
\t\t\t{\"name\":\"Custom\",\"value\":\"attribute\"}
\t\t]
\t}
]
```

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

### -Body
Array of bulk-user-create
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IBulkUserCreate[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreationSource
Defines the creation-source header for gapps, o365 and workdays requests.
If the header isn't sent, the default value is `jumpcloud:bulk`, if you send the header with a malformed value you receive a 400 error.

```yaml
Type: JumpCloud.SDK.V2.Support.CreationSource
Parameter Sets: (All)
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

### JumpCloud.SDK.V2.Models.IBulkUserCreate[]

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IBulkUserCreate[]>: Array of bulk-user-create
  - `[Attributes <IBulkUserCreateAttributesItem[]>]`: Map of additional attributes.
  - `[Email <String>]`: 
  - `[Firstname <String>]`: 
  - `[Lastname <String>]`: 
  - `[Username <String>]`: 

## RELATED LINKS

