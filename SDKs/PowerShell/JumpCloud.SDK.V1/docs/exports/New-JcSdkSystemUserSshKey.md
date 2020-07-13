---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.v1/new-jcsdksystemusersshkey
schema: 2.0.0
---

# New-JcSdkSystemUserSshKey

## SYNOPSIS
This endpoint will create a specific System User's Public SSH Key.

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkSystemUserSshKey -Id <String> -Name <String> -PublicKey <String> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-JcSdkSystemUserSshKey -Id <String> -Body <ISshkeypost> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkSystemUserSshKey -InputObject <IJumpCloudApIsIdentity> -Body <ISshkeypost> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkSystemUserSshKey -InputObject <IJumpCloudApIsIdentity> -Name <String> -PublicKey <String> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint will create a specific System User's Public SSH Key.

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
SSHKeyPost
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.ISshkeypost
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the SSH key.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublicKey
The Public SSH key.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: True
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

### JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity

### JumpCloud.SDK.V1.Models.ISshkeypost

## OUTPUTS

### JumpCloud.SDK.V1.Models.IPathsZx6QbkSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema

### JumpCloud.SDK.V1.Models.ISshkeylist

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <ISshkeypost>: SSHKeyPost
  - `Name <String>`: The name of the SSH key.
  - `PublicKey <String>`: The Public SSH key.

INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

