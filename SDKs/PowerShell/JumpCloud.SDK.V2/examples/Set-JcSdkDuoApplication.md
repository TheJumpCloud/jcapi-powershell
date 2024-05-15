### Example 1: Set a DuoApplication by AccountId, ApplicationId, and Body
```powershell
PS C:\> Set-JcSdkDuoApplication -AccountId:(<string>) -ApplicationId:(<string>) -Body:(<JumpCloud.SDK.V2.Models.DuoApplicationUpdateReq>)



----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String


```

This function will Set a DuoApplication by AccountId ApplicationId Body. AccountId, ApplicationId, and Body are required parameters.

### Example 2: Set a DuoApplication by AccountId, ApplicationId, ApiHost, IntegrationKey, and Name
```powershell
PS C:\> Set-JcSdkDuoApplication -AccountId:(<string>) -ApplicationId:(<string>) -ApiHost:(<string>) -IntegrationKey:(<string>) -Name:(<string>) -SecretKey:(<string>)



----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String


```

This function will Set a DuoApplication by AccountId ApplicationId ApiHost IntegrationKey Name. AccountId, ApplicationId, ApiHost, IntegrationKey, and Name are required parameters.

