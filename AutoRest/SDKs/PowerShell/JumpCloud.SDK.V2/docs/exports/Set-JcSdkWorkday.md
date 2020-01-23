---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/set-jcsdkworkday
schema: 2.0.0
---

# Set-JcSdkWorkday

## SYNOPSIS
This endpoint allows you to update the name and Custom Report URL for a Workday Instance.\n\nCurrently, the name can not be changed from the default of `Workday Import`.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/workdays/{WorkdayID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"reportUrl\":\"{Report_URL}\",\n\t\"name\":\"{Name}\"\n}\t'\n```

## SYNTAX

### PutExpanded (Default)
```
Set-JcSdkWorkday -Id <String> [-Name <String>] [-ReportUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Put
```
Set-JcSdkWorkday -Id <String> -Body <IWorkdayFields> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PutViaIdentity
```
Set-JcSdkWorkday -InputObject <IJumpCloudApIsIdentity> -Body <IWorkdayFields> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### PutViaIdentityExpanded
```
Set-JcSdkWorkday -InputObject <IJumpCloudApIsIdentity> [-Name <String>] [-ReportUrl <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to update the name and Custom Report URL for a Workday Instance.\n\nCurrently, the name can not be changed from the default of `Workday Import`.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/workdays/{WorkdayID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\"reportUrl\":\"{Report_URL}\",\n\t\"name\":\"{Name}\"\n}\t'\n```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloud.sdk.v2/set-jcsdkworkday
```



## PARAMETERS

### -Body
Workday Fields
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V2.Models.IWorkdayFields
Parameter Sets: Put, PutViaIdentity
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
Parameter Sets: Put, PutExpanded
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
Type: JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity
Parameter Sets: PutViaIdentity, PutViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Name
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ReportUrl
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: PutExpanded, PutViaIdentityExpanded
Aliases:

Required: False
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

### JumpCloud.SDK.V2.Models.IJumpCloudApIsIdentity

### JumpCloud.SDK.V2.Models.IWorkdayFields

## OUTPUTS

### JumpCloud.SDK.V2.Models.IWorkdayOutput

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODY <IWorkdayFields>: Workday Fields
  - `[Name <String>]`: 
  - `[ReportUrl <String>]`: 

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[AccountId <String>]`: 
  - `[ActivedirectoryId <String>]`: ObjectID of the Active Directory instance.
  - `[ApplicationId <String>]`: 
  - `[CommandId <String>]`: ObjectID of the Command.
  - `[GroupId <String>]`: ObjectID of the User Group.
  - `[GsuiteId <String>]`: ObjectID of the G Suite instance.
  - `[Id <String>]`: ObjectID of the User Group.
  - `[JobId <String>]`: 
  - `[LdapserverId <String>]`: ObjectID of the LDAP Server.
  - `[Office365Id <String>]`: ObjectID of the Office 365 instance.
  - `[PolicyId <String>]`: 
  - `[ProviderId <String>]`: 
  - `[RadiusserverId <String>]`: ObjectID of the Radius Server.
  - `[SystemId <String>]`: ObjectID of the System.
  - `[UserId <String>]`: ObjectID of the User.
  - `[WorkdayId <String>]`: 

## RELATED LINKS

