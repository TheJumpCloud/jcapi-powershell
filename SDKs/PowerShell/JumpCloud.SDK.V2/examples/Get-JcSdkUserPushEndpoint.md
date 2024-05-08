### Example 1: List UserPushEndpoints
```powershell
PS C:\> Get-JcSdkUserPushEndpoint -UserId:(<string>)



----             ----------
DeviceAppVersion String
DeviceMake       String
DeviceModel      String
DeviceOS         String
DeviceOSVersion  String
DeviceUvEnabled  Boolean
EnrollmentDate   Datetime
Id               String
LastUsedDate     Datetime
Name             String
State            String


```

This function will return a list of all UserPushEndpoints.

### Example 2: Get an UserPushEndpoint by UserId, and PushEndpointId
```powershell
PS C:\> Get-JcSdkUserPushEndpoint -UserId:(<string>) -PushEndpointId:(<string>)



----             ----------
DeviceAppVersion String
DeviceMake       String
DeviceModel      String
DeviceOS         String
DeviceOSVersion  String
DeviceUvEnabled  Boolean
EnrollmentDate   Datetime
Id               String
LastUsedDate     Datetime
Name             String
State            String


```

This function will Get an UserPushEndpoint by UserId PushEndpointId. UserId, and PushEndpointId are required parameters.

