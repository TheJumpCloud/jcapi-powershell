---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/CUT-4908_userGroupDeviceGroupFilters/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/New-JcSdkIPList.md
schema: 2.0.0
---

# New-JcSdkIPList

## SYNOPSIS
Create an IP list.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/iplists \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Sample IP List\",
    \"ips\": [
      \"192.168.10.12\",
      \"192.168.10.20 - 192.168.10.30\",
      \"123.225.10.0/32\"
    ]
  }'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkIPList -HostEnv <String> [-Description <String>] [-Ips <String[]>] [-Name <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkIPList -HostEnv <String> -Body <IIPListRequest> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create an IP list.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/v2/iplists \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"Sample IP List\",
    \"ips\": [
      \"192.168.10.12\",
      \"192.168.10.20 - 192.168.10.30\",
      \"123.225.10.0/32\"
    ]
  }'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkIPList -Description:(<string>) -Ips:(<string[]>) -Name:(<string>)
```

----        ----------
Description String
Id          String
Ips         String
Name        String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkIPList -Body:(<JumpCloud.SDK.V2.Models.IPListRequest>)
```

----        ----------
Description String
Id          String
Ips         String
Name        String

## PARAMETERS

### -Body
IPListRequest

```yaml
Type: JumpCloud.SDK.V2.Models.IIPListRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
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

### -HostEnv
Region for JumpCloud API host.
Use 'console' for US or 'console.eu' for EU.

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

### -Ips
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### JumpCloud.SDK.V2.Models.IIPListRequest

## OUTPUTS

### JumpCloud.SDK.V2.Models.IIPList

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IIPListRequest>`: IPListRequest
  - `[Description <String>]`: 
  - `[Ips <List<String>>]`: 
  - `[Name <String>]`: 

## RELATED LINKS

