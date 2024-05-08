### Example 1: Create a DuoApplication by AccountId, ApiHost, IntegrationKey, Name, and SecretKey
```powershell
PS C:\> New-JcSdkDuoApplication -AccountId:(<string>) -ApiHost:(<string>) -IntegrationKey:(<string>) -Name:(<string>) -SecretKey:(<string>)



----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String


```

This function will Create a DuoApplication by AccountId ApiHost IntegrationKey Name SecretKey. AccountId, ApiHost, IntegrationKey, Name, and SecretKey are required parameters.

### Example 2: Create a DuoApplication by AccountId, and Body
```powershell
PS C:\> New-JcSdkDuoApplication -AccountId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.DuoApplicationReq>)



----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String


```

This function will Create a DuoApplication by AccountId Body. AccountId, and Body are required parameters.

