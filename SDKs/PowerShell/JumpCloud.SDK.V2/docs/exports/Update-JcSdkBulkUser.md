---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkBulkUser.md
schema: 2.0.0
---

# Update-JcSdkBulkUser

## SYNOPSIS
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_put) for full list of attributes.

#### Sample Request 
```
curl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"department\":\"{UPDATED_DEPARTMENT}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}
\t\t]
\t},
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",
\t\t\"phoneNumbers\":[
\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},
\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}
\t\t]
\t}
]
```

## SYNTAX

```
Update-JcSdkBulkUser -Body <IBulkUserUpdate[]> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The endpoint allows you to create a bulk job to asynchronously update users.
See [Update a System User](https://docs.jumpcloud.com/api/1.0/index.html#operation/systemusers_put) for full list of attributes.

#### Sample Request 
```
curl -X PATCH https://console.jumpcloud.com/api/v2/bulk/users \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '[
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"department\":\"{UPDATED_DEPARTMENT}\",
\t\t\"attributes\":[
\t\t\t{\"name\":\"Custom\",\"value\":\"{ATTRIBUTE_VALUE}\"}
\t\t]
\t},
\t{
\t  \"id\":\"5be9fb4ddb01290001e85109\",
\t\t\"firstname\":\"{UPDATED_FIRSTNAME}\",
\t\t\"costCenter\":\"{UPDATED_COST_CENTER}\",
\t\t\"phoneNumbers\":[
\t\t\t{\"type\":\"home\",\"number\":\"{HOME_PHONE_NUMBER}\"},
\t\t\t{\"type\":\"work\",\"number\":\"{WORK_PHONE_NUMBER}\"}
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
Array of bulk-user-update
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IBulkUserUpdate[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### JumpCloud.SDK.V2.Models.IBulkUserUpdate[]

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IBulkUserUpdate[]>: Array of bulk-user-update
  - `[Attributes <IBulkUserUpdateAttributesItem[]>]`: Map of additional attributes.
  - `[Email <String>]`: 
  - `[Firstname <String>]`: 
  - `[Id <String>]`: Object ID of the systemuser being updated
  - `[Lastname <String>]`: 
  - `[Username <String>]`: 

## RELATED LINKS

