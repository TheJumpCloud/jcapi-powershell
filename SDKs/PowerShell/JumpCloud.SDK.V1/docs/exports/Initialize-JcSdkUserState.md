---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/Initialize-JcSdkUserState.md
schema: 2.0.0
---

# Initialize-JcSdkUserState

## SYNOPSIS
This endpoint changes the state of a STAGED user to ACTIVATED.
#### Email Flag
Use the \"email\" flag to determine whether or not to send a Welcome or
Activation email to the newly activated user.
Sending an empty body
without the `email` flag, will send an email with default behavior
(see the \"Behavior\" section below)
```
{}
```
Sending `email=true` flag will send an email with default behavior (see `Behavior` below)
```
{ \"email\": true }
```
Populated email will override the default behavior and send to the specified email value
```
{ \"email\": \"example@example.com\" }
```
Sending `email=false` will suppress sending the email
```
{ \"email\": false }
```
#### Behavior
Users with a password will be sent a Welcome email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's primary email address (default behavior)
Users without a password will be sent an Activation email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's alternate email address (default behavior)
  - If no alternate email address, the user's primary email address (default behavior)

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/systemusers/{id}/state/activate \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: \<api-key\>' \\
  -d '{ \"email\": \"alternate-activation-email@email.com\" }'

```

## SYNTAX

### ActivateExpanded (Default)
```
Initialize-JcSdkUserState -ConsoleHost <String> -Id <String> [-Email <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Activate
```
Initialize-JcSdkUserState -ConsoleHost <String> -Id <String>
 -Body <IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ActivateViaIdentity
```
Initialize-JcSdkUserState -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity>
 -Body <IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ActivateViaIdentityExpanded
```
Initialize-JcSdkUserState -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-Email <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint changes the state of a STAGED user to ACTIVATED.
#### Email Flag
Use the \"email\" flag to determine whether or not to send a Welcome or
Activation email to the newly activated user.
Sending an empty body
without the `email` flag, will send an email with default behavior
(see the \"Behavior\" section below)
```
{}
```
Sending `email=true` flag will send an email with default behavior (see `Behavior` below)
```
{ \"email\": true }
```
Populated email will override the default behavior and send to the specified email value
```
{ \"email\": \"example@example.com\" }
```
Sending `email=false` will suppress sending the email
```
{ \"email\": false }
```
#### Behavior
Users with a password will be sent a Welcome email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's primary email address (default behavior)
Users without a password will be sent an Activation email to:
  - The address specified in `email` flag in the request
  - If no `email` flag, the user's alternate email address (default behavior)
  - If no alternate email address, the user's primary email address (default behavior)

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/systemusers/{id}/state/activate \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: \<api-key\>' \\
  -d '{ \"email\": \"alternate-activation-email@email.com\" }'

```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Initialize-JcSdkUserState -Id:(<string>) -Email:(<string>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Initialize-JcSdkUserState -Id:(<string>) -Body:(<JumpCloud.SDK.V1.Models.PathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema>)
```



## PARAMETERS

### -Body
.

```yaml
Type: JumpCloud.SDK.V1.Models.IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Activate, ActivateViaIdentity
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

### -Email
.

```yaml
Type: System.String
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
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
Parameter Sets: Activate, ActivateExpanded
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
Parameter Sets: ActivateViaIdentity, ActivateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
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

### JumpCloud.SDK.V1.Models.IJumpCloudApiIdentity

### JumpCloud.SDK.V1.Models.IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPathsDi9CukSystemusersIdStateActivatePostRequestbodyContentApplicationJsonSchema>`: .
  - `[Email <String>]`: 

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemId <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

