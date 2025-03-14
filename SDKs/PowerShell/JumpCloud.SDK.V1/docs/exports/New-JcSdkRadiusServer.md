---
external help file:
Module Name: JumpCloud.SDK.V1
online version: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/JumpCloud.SDK.V1/docs/exports/New-JcSdkRadiusServer.md
schema: 2.0.0
---

# New-JcSdkRadiusServer

## SYNOPSIS
This endpoint allows you to create RADIUS servers in your organization.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/radiusservers/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{test_radius}\",
    \"networkSourceIp\": \"{0.0.0.0}\",
    \"sharedSecret\":\"{secretpassword}\",
    \"userLockoutAction\": \"REMOVE\",
    \"userPasswordExpirationAction\": \"MAINTAIN\"
}'
```

## SYNTAX

### CreateExpanded (Default)
```
New-JcSdkRadiusServer -Name <String> -NetworkSourceIP <String> -SharedSecret <String> [-AuthIdp <String>]
 [-CaCert <String>] [-DeviceCertEnabled] [-Mfa <String>] [-RequireTlsAuth] [-UserCertEnabled]
 [-UserLockoutAction <String>] [-UserPasswordEnabled] [-UserPasswordExpirationAction <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-JcSdkRadiusServer -Body <IRadiusserverpost> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
This endpoint allows you to create RADIUS servers in your organization.

#### Sample Request
```
curl -X POST https://console.jumpcloud.com/api/radiusservers/ \\
  -H 'Accept: application/json' \\
  -H 'Content-Type: application/json' \\
  -H 'x-api-key: {API_KEY}' \\
  -d '{
    \"name\": \"{test_radius}\",
    \"networkSourceIp\": \"{0.0.0.0}\",
    \"sharedSecret\":\"{secretpassword}\",
    \"userLockoutAction\": \"REMOVE\",
    \"userPasswordExpirationAction\": \"MAINTAIN\"
}'
```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
New-JcSdkRadiusServer -Name:(<string>) -NetworkSourceIP:(<string>) -SharedSecret:(<string>) -AuthIdp:(<string>) -CaCert:(<string>) -DeviceCertEnabled:(<switch>) -Mfa:(<string>) -UserCertEnabled:(<switch>) -UserLockoutAction:(<string>) -UserPasswordEnabled:(<switch>) -UserPasswordExpirationAction:(<string>)
```

----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
Organization                 String
SharedSecret                 String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String

### -------------------------- EXAMPLE 2 --------------------------
```powershell
New-JcSdkRadiusServer -Body:(<JumpCloud.SDK.V1.Models.Radiusserverpost>)
```

----                         ----------
AuthIdp                      String
CaCert                       String
DeviceCertEnabled            Boolean
Id                           String
Mfa                          String
Name                         String
NetworkSourceIP              String
Organization                 String
SharedSecret                 String
UserCertEnabled              Boolean
UserLockoutAction            String
UserPasswordEnabled          Boolean
UserPasswordExpirationAction String

## PARAMETERS

### -AuthIdp
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

### -Body
RadiusServerPost
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: JumpCloud.SDK.V1.Models.IRadiusserverpost
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CaCert
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

### -DeviceCertEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Mfa
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

### -Name
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSourceIP
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequireTlsAuth
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedSecret
RADIUS shared secret between the server and client.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCertEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserLockoutAction
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

### -UserPasswordEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPasswordExpirationAction
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

### JumpCloud.SDK.V1.Models.IRadiusserverpost

## OUTPUTS

### JumpCloud.SDK.V1.Models.IRadiusserver

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODY <IRadiusserverpost>: RadiusServerPost
  - `Name <String>`: 
  - `NetworkSourceIP <String>`: 
  - `SharedSecret <String>`: RADIUS shared secret between the server and client.
  - `[AuthIdp <String>]`: 
  - `[CaCert <String>]`: 
  - `[DeviceCertEnabled <Boolean?>]`: 
  - `[Mfa <String>]`: 
  - `[RequireTlsAuth <Boolean?>]`: 
  - `[UserCertEnabled <Boolean?>]`: 
  - `[UserLockoutAction <String>]`: 
  - `[UserPasswordEnabled <Boolean?>]`: 
  - `[UserPasswordExpirationAction <String>]`: 

## RELATED LINKS

