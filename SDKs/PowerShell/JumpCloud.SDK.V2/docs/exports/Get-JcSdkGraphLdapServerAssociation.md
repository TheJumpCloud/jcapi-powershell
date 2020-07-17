---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Get-JcSdkGraphLdapServerAssociation.md
schema: 2.0.0
---

# Get-JcSdkGraphLdapServerAssociation

## SYNOPSIS
This endpoint returns the _direct_ associations of this LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n\n```\n curl -X GET 'https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

## SYNTAX

```
Get-JcSdkGraphLdapServerAssociation -LdapserverId <String> -Targets <String[]> [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns the _direct_ associations of this LDAP Server.\n\nA direct association can be a non-homogeneous relationship between 2 different objects, for example LDAP and Users.\n\n#### Sample Request\n\n```\n curl -X GET 'https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/associations?targets=user_group \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```

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

### -LdapserverId
ObjectID of the LDAP Server.

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

### -Targets
.

```yaml
Type: System.String[]
Parameter Sets: (All)
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

## OUTPUTS

### JumpCloud.SDK.V2.Models.IGraphConnection

## NOTES

ALIASES

## RELATED LINKS

