### Example 1: List DuoApplications
```powershell
PS C:\> Get-JcSdkDuoApplication -AccountId:(<string>)



----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String


```

This function will return a list of all DuoApplications.

### Example 2: Get a DuoApplication by AccountId, and ApplicationId
```powershell
PS C:\> Get-JcSdkDuoApplication -AccountId:(<string>) -ApplicationId:(<string>)



----           ----------
ApiHost        String
Id             String
IntegrationKey String
Name           String


```

This function will Get a DuoApplication by AccountId ApplicationId. AccountId, and ApplicationId are required parameters.

