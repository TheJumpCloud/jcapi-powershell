---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Get-JcSdkApplicationTemplate.md
schema: 2.0.0
---

# Get-JcSdkApplicationTemplate

## SYNOPSIS
The endpoint returns a specific SSO / SAML Application Template.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n\n```

## SYNTAX

### List (Default)
```
Get-JcSdkApplicationTemplate -Accept <String> -ContentType <String> [-Fields <String>] [-Filter <String>]
 [-Sort <String>] [-XOrgId <String>] [<CommonParameters>]
```

### Get
```
Get-JcSdkApplicationTemplate -Id <String> -Accept <String> -ContentType <String> [-Fields <String>]
 [-Filter <String>] [-Sort <String>] [-XOrgId <String>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkApplicationTemplate -InputObject <IJumpCloudApIsIdentity> -Accept <String> -ContentType <String>
 [-Fields <String>] [-Filter <String>] [-Sort <String>] [-XOrgId <String>] [<CommonParameters>]
```

## DESCRIPTION
The endpoint returns a specific SSO / SAML Application Template.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/application-templates/{id} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n\n```

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

### -Accept
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

### -ContentType
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

### -Fields
The comma separated fields included in the returned records.
If omitted the default list of fields will be returned.

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

### -Filter
A filter to apply to the query.

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

### -Id
.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Sort
.

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

### -XOrgId
.

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

### JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity

## OUTPUTS

### JumpCloud.SDK.V1.Models.IApplicationtemplate

### JumpCloud.SDK.V1.Models.IApplicationtemplateslist

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

