---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkUserSshKey.md
schema: 2.0.0
---

# New-JcSdkUserSshKey

## SYNOPSIS
This endpoint will create a specific System User's Public SSH Key.

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkUserSshKey -ConsoleHost <String> -Id <String> [-Name <String>] [-PublicKey <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkUserSshKey -ConsoleHost <String> -Id <String> -Body <ISshkeypost> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkUserSshKey -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> -Body <ISshkeypost> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkUserSshKey -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-Name <String>]
 [-PublicKey <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint will create a specific System User's Public SSH Key.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkUserSshKey -Id:(<string>) -Name:(<string>) -PublicKey:(<string>)
```

----       ----------
CreateDate String
Id         String
Name       String
PublicKey  String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkUserSshKey -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.Sshkeypost>)
```

----       ----------
CreateDate String
Id         String
Name       String
PublicKey  String

## PARAMETERS

### -Body
SSHKeyPost

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

### -ConsoleHost
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

```yaml
Type: JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity
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

Required: False
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

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V1.Models.ISshkeypost

## OUTPUTS

### JumpCloud.SDK.V1.Models.ISshkeylist

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <ISshkeypost>`: SSHKeyPost
  - `Name <String>`: The name of the SSH key.
  - `PublicKey <String>`: The Public SSH key.

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

