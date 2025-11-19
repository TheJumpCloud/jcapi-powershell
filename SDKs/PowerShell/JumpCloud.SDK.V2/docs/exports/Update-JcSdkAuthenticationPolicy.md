---
external help file:
Module Name: JumpCloud.SDK.V2
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V2/docs/exports/Update-JcSdkAuthenticationPolicy.md
schema: 2.0.0
---

# Update-JcSdkAuthenticationPolicy

## SYNOPSIS
Patch the specified authentication policy.

#### Sample Request
```
curl -X PATCH https://console.jumpcloud.com/api/v2/authn/policies/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{ \"disabled\": false }'
```

## SYNTAX

### UpdateExpanded (Default)
```
Update-JcSdkAuthenticationPolicy -ConsoleHost <String> -Id <String> [-Conditions <Hashtable>]
 [-CustomErrorMessage <String>] [-CustomErrorMessageEnabled] [-Description <String>] [-Disabled]
 [-EffectAction <String>] [-MfaRequired] [-Name <String>]
 [-ObligationMfaFactors <IAuthnPolicyObligationsMfaFactorsItem[]>] [-PrimaryHelpText <String>]
 [-PrimaryHelpUrl <String>] [-SecondaryHelpText <String>] [-SecondaryHelpUrl <String>]
 [-TargetResources <IAuthnPolicyResourceTarget[]>] [-Type <String>]
 [-UserAttributeExclusions <IAuthnPolicyUserAttributeFilter[]>]
 [-UserAttributeInclusions <IAuthnPolicyUserAttributeFilter[]>] [-UserGroupExclusions <String[]>]
 [-UserGroupInclusions <String[]>] [-UserInclusions <String[]>] [-UserVerificationRequirement <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-JcSdkAuthenticationPolicy -ConsoleHost <String> -Id <String> -Body <IAuthnPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-JcSdkAuthenticationPolicy -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity>
 -Body <IAuthnPolicy> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-JcSdkAuthenticationPolicy -ConsoleHost <String> -InputObject <IJumpCloudApiIdentity>
 [-Conditions <Hashtable>] [-CustomErrorMessage <String>] [-CustomErrorMessageEnabled] [-Description <String>]
 [-Disabled] [-EffectAction <String>] [-MfaRequired] [-Name <String>]
 [-ObligationMfaFactors <IAuthnPolicyObligationsMfaFactorsItem[]>] [-PrimaryHelpText <String>]
 [-PrimaryHelpUrl <String>] [-SecondaryHelpText <String>] [-SecondaryHelpUrl <String>]
 [-TargetResources <IAuthnPolicyResourceTarget[]>] [-Type <String>]
 [-UserAttributeExclusions <IAuthnPolicyUserAttributeFilter[]>]
 [-UserAttributeInclusions <IAuthnPolicyUserAttributeFilter[]>] [-UserGroupExclusions <String[]>]
 [-UserGroupInclusions <String[]>] [-UserInclusions <String[]>] [-UserVerificationRequirement <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Patch the specified authentication policy.

#### Sample Request
```
curl -X PATCH https://console.jumpcloud.com/api/v2/authn/policies/{id} \\
  -H 'accept: application/json' \\
  -H 'content-type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{ \"disabled\": false }'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Update-JcSdkAuthenticationPolicy -Id:(<string>) -Body:(<JumpCloud.SDK.V2.Models.AuthnPolicy>)
```

----                        ----------
Conditions                  JumpCloud.SDK.V2.Models.AuthnPolicyConditions
Description                 String
Disabled                    Boolean
EffectAction                String
Id                          String
MfaRequired                 Boolean
Name                        String
TargetResources             JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]
Type                        String
UserAttributeExclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserAttributeInclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserGroupExclusions         String
UserGroupInclusions         String
UserInclusions              String
UserVerificationRequirement String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Update-JcSdkAuthenticationPolicy -Id:(<string>) -Conditions:(<hashtable>) -Description:(<string>) -Disabled:(<switch>) -EffectAction:(<string>) -MfaRequired:(<switch>) -Name:(<string>) -TargetResources:(<JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]>) -Type:(<string>) -UserAttributeExclusions:(<JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]>) -UserAttributeInclusions:(<JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]>) -UserGroupExclusions:(<string[]>) -UserGroupInclusions:(<string[]>) -UserInclusions:(<string[]>) -UserVerificationRequirement:(<string>)
```

----                        ----------
Conditions                  JumpCloud.SDK.V2.Models.AuthnPolicyConditions
Description                 String
Disabled                    Boolean
EffectAction                String
Id                          String
MfaRequired                 Boolean
Name                        String
TargetResources             JumpCloud.SDK.V2.Models.AuthnPolicyResourceTarget[]
Type                        String
UserAttributeExclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserAttributeInclusions     JumpCloud.SDK.V2.Models.AuthnPolicyUserAttributeFilter[]
UserGroupExclusions         String
UserGroupInclusions         String
UserInclusions              String
UserVerificationRequirement String

## PARAMETERS

### -Body
This represents an authentication policy.
See the details of each field for valid values and restrictions.

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthnPolicy
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Conditions
Dictionary of \<any\>

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -CustomErrorMessage
The custom error message to be displayed when the policy is applied.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CustomErrorMessageEnabled
Indicates whether the custom error message is enabled or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Disabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EffectAction
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Unique identifier of the authentication policy

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MfaRequired
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ObligationMfaFactors
.

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthnPolicyObligationsMfaFactorsItem[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrimaryHelpText
The text to be displayed for the help link.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrimaryHelpUrl
The URL to be opened when the help link is clicked.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecondaryHelpText
The text to be displayed for the help link.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SecondaryHelpUrl
The URL to be opened when the help link is clicked.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetResources
.

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthnPolicyResourceTarget[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
AuthnPolicyType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserAttributeExclusions
.

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthnPolicyUserAttributeFilter[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserAttributeInclusions
.

```yaml
Type: JumpCloud.SDK.V2.Models.IAuthnPolicyUserAttributeFilter[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroupExclusions
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserGroupInclusions
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserInclusions
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserVerificationRequirement
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### JumpCloud.SDK.V2.Models.IAuthnPolicy

### JumpCloud.SDK.V2.Models.IJumpCloudApiIdentity

## OUTPUTS

### JumpCloud.SDK.V2.Models.IAuthnPolicy

## NOTES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IAuthnPolicy>`: This represents an authentication policy. See the details of each field for valid values and restrictions.
  - `[Conditions <IAuthnPolicyConditions>]`: Dictionary of <any>
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CustomErrorMessage <String>]`: The custom error message to be displayed when the policy is applied.
  - `[CustomErrorMessageEnabled <Boolean?>]`: Indicates whether the custom error message is enabled or not.
  - `[Description <String>]`: 
  - `[Disabled <Boolean?>]`: 
  - `[EffectAction <String>]`: 
  - `[MfaRequired <Boolean?>]`: 
  - `[Name <String>]`: 
  - `[ObligationMfaFactors <List<IAuthnPolicyObligationsMfaFactorsItem>>]`: 
    - `[Type <String>]`: 
  - `[PrimaryHelpText <String>]`: The text to be displayed for the help link.
  - `[PrimaryHelpUrl <String>]`: The URL to be opened when the help link is clicked.
  - `[SecondaryHelpText <String>]`: The text to be displayed for the help link.
  - `[SecondaryHelpUrl <String>]`: The URL to be opened when the help link is clicked.
  - `[TargetResources <List<IAuthnPolicyResourceTarget>>]`: 
    - `Type <String>`: 
    - `[Id <String>]`: Object ID of the resource target. If undefined, then all resources of the given type are targeted.
  - `[Type <String>]`: AuthnPolicyType
  - `[UserAttributeExclusions <List<IAuthnPolicyUserAttributeFilter>>]`: 
    - `[Field <String>]`: The only field that is currently supported is ldap_binding_user
    - `[Operator <String>]`: 
    - `[Value <IAny>]`: Can be any value - string, number, boolean, array or object.
  - `[UserAttributeInclusions <List<IAuthnPolicyUserAttributeFilter>>]`: 
  - `[UserGroupExclusions <List<String>>]`: 
  - `[UserGroupInclusions <List<String>>]`: 
  - `[UserInclusions <List<String>>]`: 
  - `[UserVerificationRequirement <String>]`: 

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

`OBLIGATIONMFAFACTORS <IAuthnPolicyObligationsMfaFactorsItem[]>`: .
  - `[Type <String>]`: 

`TARGETRESOURCES <IAuthnPolicyResourceTarget[]>`: .
  - `Type <String>`: 
  - `[Id <String>]`: Object ID of the resource target. If undefined, then all resources of the given type are targeted.

`USERATTRIBUTEEXCLUSIONS <IAuthnPolicyUserAttributeFilter[]>`: .
  - `[Field <String>]`: The only field that is currently supported is ldap_binding_user
  - `[Operator <String>]`: 
  - `[Value <IAny>]`: Can be any value - string, number, boolean, array or object.

`USERATTRIBUTEINCLUSIONS <IAuthnPolicyUserAttributeFilter[]>`: .
  - `[Field <String>]`: The only field that is currently supported is ldap_binding_user
  - `[Operator <String>]`: 
  - `[Value <IAny>]`: Can be any value - string, number, boolean, array or object.

## RELATED LINKS

