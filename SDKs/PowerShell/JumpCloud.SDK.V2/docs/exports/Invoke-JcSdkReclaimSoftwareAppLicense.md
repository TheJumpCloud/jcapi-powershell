---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Invoke-JcSdkReclaimSoftwareAppLicense.md
schema: 2.0.0
---

# Invoke-JcSdkReclaimSoftwareAppLicense

## SYNOPSIS
This endpoint allows you to reclaim the licenses from a software app associated with devices that are deleted.
#### Sample Request
```
$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/reclaim-licenses \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{}'
```

## SYNTAX

### Reclaim (Default)
```
Invoke-JcSdkReclaimSoftwareAppLicense -SoftwareAppId <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ReclaimViaIdentity
```
Invoke-JcSdkReclaimSoftwareAppLicense -InputObject <IJumpCloudApiIdentity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to reclaim the licenses from a software app associated with devices that are deleted.
#### Sample Request
```
$ curl -X POST https://console.jumpcloud.com/api/v2/softwareapps/{software_app_id}/reclaim-licenses \\
-H 'Accept: application/json' \\
-H 'Content-Type: application/json' \\
-H 'x-api-key: {API_KEY}' \\
-d '{}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Invoke-JcSdkReclaimSoftwareAppLicense -SoftwareAppId:(<string>)
```

----              ----------
AssignedLicenses  Int
AvailableLicenses Int
ReclaimedLicenses Int
TotalLicenses     Int

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity
Parameter Sets: ReclaimViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SoftwareAppId
.

```yaml
Type: System.String
Parameter Sets: Reclaim
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

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.ISoftwareAppReclaimLicenses

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IJumpCloudApiIdentity>: Identity Parameter
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

