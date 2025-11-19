---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Grant-JcSdkWorkday.md
schema: 2.0.0
---

# Grant-JcSdkWorkday

## SYNOPSIS
This endpoint adds an authorization method to a workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"auth\":{
\t  \"basic\": {
\t\t\"username\": \"someDeveloper\",\t  
\t\t\"password\": \"notTheRealPassword\"

\t  }
\t}
}'

```

## SYNTAX

### AuthorizeExpanded (Default)
```
Grant-JcSdkWorkday -ConsoleHost <String> -WorkdayId <String> [-BasicPassword <String>]
 [-BasicUsername <String>] [-OauthCode <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Authorize
```
Grant-JcSdkWorkday -ConsoleHost <String> -WorkdayId <String> -Body <IAuthInputObject> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### AuthorizeViaIdentity
```
Grant-JcSdkWorkday -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> -Body <IAuthInputObject>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AuthorizeViaIdentityExpanded
```
Grant-JcSdkWorkday -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-BasicPassword <String>]
 [-BasicUsername <String>] [-OauthCode <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint adds an authorization method to a workday instance.

You must supply a username and password for `Basic Authentication` that is the same as your WorkDay Integrator System User.
Failure to provide these credentials  will result in the request being rejected.

Currently `O-Auth` isn't a supported authentication protocol for WorkDay, but will be in the future.

#### Sample Request

```
curl -X POST https://console.jumpcloud.com/api/v2/workdays/{WorkDayID}/auth \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
\t\"auth\":{
\t  \"basic\": {
\t\t\"username\": \"someDeveloper\",\t  
\t\t\"password\": \"notTheRealPassword\"

\t  }
\t}
}'

```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Grant-JcSdkWorkday -WorkdayId:(<string>) -BasicPassword:(<string>) -BasicUsername:(<string>) -OauthCode:(<string>)
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
Grant-JcSdkWorkday -WorkdayId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AuthInputObject>)
```



## PARAMETERS

### -BasicPassword
.

```yaml
Type: System.String
Parameter Sets: AuthorizeExpanded, AuthorizeViaIdentityExpanded
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
Parameter Sets: AuthorizeExpanded, AuthorizeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
Auth Input Object

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthInputObject
Parameter Sets: Authorize, AuthorizeViaIdentity
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

### -InputObject
Identity Parameter

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: AuthorizeViaIdentity, AuthorizeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OauthCode
.

```yaml
Type: System.String
Parameter Sets: AuthorizeExpanded, AuthorizeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -WorkdayId
.

```yaml
Type: System.String
Parameter Sets: Authorize, AuthorizeExpanded
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

### JumpCloud.SDK.V2.Models.IAuthInputObject

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### System.Boolean

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IAuthInputObject>`: Auth Input Object
  - `[BasicPassword <String>]`: 
  - `[BasicUsername <String>]`: 
  - `[OauthCode <String>]`: 

`INPUTOBJECT <IJumpCloudApiIdentity>`: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: 
  - `[AdministratorId <String>]`: 
  - `[AgentId <String>]`: 
  - `[AppleMdmId <String>]`: 
  - `[ApplicationId <String>]`: ObjectID of the Application.
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[CustomEmailType <String>]`: 
  - `[DeviceId <String>]`: 
  - `[GroupId <String>]`: ObjectID of the Policy Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of this Active Directory instance.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: ObjectID of the Policy.
  - `[ProviderId <String>]`: 
  - `[PushEndpointId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SoftwareAppId <String>]`: ObjectID of the Software App.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

