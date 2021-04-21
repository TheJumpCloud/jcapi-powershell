---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkWorkday.md
schema: 2.0.0
---

# New-JcSdkWorkday

## SYNOPSIS
This endpoint allows you to create a new workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

Currently, only one instance is allowed and it must be `Workday Import`.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Workday2\",
    \"reportUrl\":\"https://workday.com/ccx/service/customreport2/gms/user/reportname?format=json\",
    \"auth\": {
      \"basic\": {
        \"username\": \"someDeveloper\",
        \"password\": \"notTheRealPassword\"
      }
    }
  }'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkWorkday [-BasicPassword <String>] [-BasicUsername <String>] [-Name <String>] [-OauthCode <String>]
 [-ReportUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkWorkday -Body <IWorkdayInput> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create a new workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

Currently, only one instance is allowed and it must be `Workday Import`.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Workday2\",
    \"reportUrl\":\"https://workday.com/ccx/service/customreport2/gms/user/reportname?format=json\",
    \"auth\": {
      \"basic\": {
        \"username\": \"someDeveloper\",
        \"password\": \"notTheRealPassword\"
      }
    }
  }'
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

### -BasicPassword
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BasicUsername
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Workday Input
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IWorkdayInput
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OauthCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReportUrl
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### JumpCloud.SDK.V2.Models.IWorkdayInput

## OUTPUTS

### JumpCloud.SDK.V2.Models.IWorkdayOutput

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IWorkdayInput>: Workday Input
  - `[BasicPassword <String>]`: 
  - `[BasicUsername <String>]`: 
  - `[Name <String>]`: 
  - `[OauthCode <String>]`: 
  - `[ReportUrl <String>]`: 

## RELATED LINKS

