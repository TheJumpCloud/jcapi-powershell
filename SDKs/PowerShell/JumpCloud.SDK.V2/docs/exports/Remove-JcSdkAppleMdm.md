---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Remove-JcSdkAppleMdm.md
schema: 2.0.0
---

# Remove-JcSdkAppleMdm

## SYNOPSIS
Removes an Apple MDM configuration.

Warning: This is a destructive operation and will remove your Apple Push Certificates.
We will no longer be able to manage your devices and the only recovery option is to re-register all devices into MDM.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/applemdms/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## SYNTAX

### Delete (Default)
```
Remove-JcSdkAppleMdm -ConsoleHost <String> -Id <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-JcSdkAppleMdm -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Removes an Apple MDM configuration.

Warning: This is a destructive operation and will remove your Apple Push Certificates.
We will no longer be able to manage your devices and the only recovery option is to re-register all devices into MDM.

#### Sample Request
```
curl -X DELETE https://console.jumpcloud.com/api/v2/applemdms/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Remove-JcSdkAppleMdm -Id:(<string>)
```

----                                  ----------
AllowMobileUserEnrollment             Boolean
ApnsCertExpiry                        String
ApnsPushTopic                         String
AppleCertCreatorAppleId               String
AppleCertSerialNumber                 String
DefaultIosUserEnrollmentDeviceGroupId String
DefaultSystemGroupId                  String
DepAccessTokenExpiry                  String
DepEnableZeroTouchEnrollment          Boolean
DepServerTokenState                   String
DepSetupAssistantOptions              JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
Id                                    String
IoDefaultDeviceGroupObjectIds         String
IoEnableZeroTouchEnrollment           Boolean
IoSetupAssistantOptions               JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
IoSetupOptions                        String
IosWelcomeScreenButton                String
IosWelcomeScreenParagraph             String
IosWelcomeScreenTitle                 String
MacoDefaultDeviceGroupObjectIds       String
MacoEnableZeroTouchEnrollment         Boolean
MacoSetupAssistantOptions             JumpCloud.SDK.V2.Models.DepSetupAssistantOption[]
MacoSetupOptions                      String
MacosWelcomeScreenButton              String
MacosWelcomeScreenParagraph           String
MacosWelcomeScreenTitle               String
Name                                  String
Organization                          String
WelcomeScreenButton                   String
WelcomeScreenParagraph                String
WelcomeScreenTitle                    String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

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
Parameter Sets: Delete
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
Parameter Sets: DeleteViaIdentity
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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAppleMdm

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

