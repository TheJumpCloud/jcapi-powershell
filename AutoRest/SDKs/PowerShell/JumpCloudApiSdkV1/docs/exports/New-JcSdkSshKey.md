---
external help file:
Module Name: JumpCloudApiSdkV1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdksshkey
schema: 2.0.0
---

# New-JcSdkSshKey

## SYNOPSIS
This endpoint will create a specific System User's Public SSH Key.

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkSshKey -Id <String> -Name <String> -PublicKey <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkSshKey -Id <String> -Body <ISshkeypost> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-JcSdkSshKey -InputObject <IJumpCloudApIsIdentity> -Body <ISshkeypost> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-JcSdkSshKey -InputObject <IJumpCloudApIsIdentity> -Name <String> -PublicKey <String> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint will create a specific System User's Public SSH Key.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/new-jcsdksshkey
```



## PARAMETERS

### -Body
SSHKeyPost
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.ISshkeypost
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity

### JumpCloudApiSdkV1.Models.ISshkeypost

## OUTPUTS

### JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema

### JumpCloudApiSdkV1.Models.ISshkeylist

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <ISshkeypost>: SSHKeyPost
  - `Name <String>`: The name of the SSH key.
  - `PublicKey <String>`: The Public SSH key.

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

