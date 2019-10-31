---
external help file:
Module Name: JumpCloudApiSdkV1
online version: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/get-jcsdkcommandresult
schema: 2.0.0
---

# Get-JcSdkCommandResult

## SYNOPSIS
This endpoint returns a specific command result.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/commandresults/{CommandResultID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ```

## SYNTAX

### List (Default)
```
Get-JcSdkCommandResult [-Fields <String>] [-Filter <String>] [-Limit <Int32>] [-Skip <Int32>] [-Sort <String>]
 [-PassThru] [<CommonParameters>]
```

### Get
```
Get-JcSdkCommandResult -Id <String> [-Fields <String>] [-Filter <String>] [-PassThru] [<CommonParameters>]
```

### GetViaIdentity
```
Get-JcSdkCommandResult -InputObject <IJumpCloudApIsIdentity> [-Fields <String>] [-Filter <String>] [-PassThru]
 [<CommonParameters>]
```

## DESCRIPTION
This endpoint returns a specific command result.\n\n#### Sample Request\n```\ncurl -X GET https://console.jumpcloud.com/api/commandresults/{CommandResultID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \n  ```

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/jumpcloudapisdkv1/get-jcsdkcommandresult
```



## PARAMETERS

### -Fields
Use a space seperated string of field parameters to include the data in the response.
If omitted, the default list of fields will be returned.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Filter
A filter to apply to the query.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
HELP MESSAGE MISSING

```yaml
Type: System.String
Parameter Sets: Get
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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Limit
The number of records to return at once.
Limited to 100.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Skip
The offset into the records to return.

```yaml
Type: System.Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Sort
Use space separated sort parameters to sort the collection.
Default sort is ascending.
Prefix with `-` to sort descending.

```yaml
Type: System.String
Parameter Sets: List
Aliases:

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

## OUTPUTS

### JumpCloudApiSdkV1.Models.ICommandresult

### JumpCloudApiSdkV1.Models.ICommandresultslist

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IJumpCloudApIsIdentity>: Identity Parameter
  - `[Id <String>]`: 
  - `[SystemuserId <String>]`: 
  - `[Triggername <String>]`: 

## RELATED LINKS

