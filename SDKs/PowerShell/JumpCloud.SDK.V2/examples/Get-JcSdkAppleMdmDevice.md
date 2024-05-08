### Example 1: List AppleMdmDevices
```powershell
PS C:\> Get-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -Filter:(<string[]>) -Sort:(<string[]>) -XTotalCount:(<int>)



----                                                  ----------
CreatedAt                                             String
DepRegistered                                         Boolean
DeviceInformationActivationLockAllowedWhileSupervised Boolean
DeviceInformationAvailableDeviceCapacity              System.Nullable[float] DeviceInformationAvailableDeviceCapacity {get;set;}
DeviceInformationDeviceCapacity                       System.Nullable[float] DeviceInformationDeviceCapacity {get;set;}
DeviceInformationDeviceName                           String
DeviceInformationIccid                                String
DeviceInformationImei                                 String
DeviceInformationIsSupervised                         Boolean
DeviceInformationModelName                            String
DeviceInformationSecondIccid                          String
DeviceInformationSecondImei                           String
DeviceInformationSecondSubscriberCarrierNetwork       String
DeviceInformationSubscriberCarrierNetwork             String
DeviceInformationWifiMac                              String
Enrolled                                              Boolean
HasActivationLockBypassCodes                          Boolean
Id                                                    String
OSVersion                                             String
SecurityInfoEnrolledViaDep                            Boolean
SecurityInfoIsActivationLockManageable                Boolean
SecurityInfoIsUserEnrollment                          Boolean
SecurityInfoPasscodePresent                           Boolean
SecurityInfoUserApprovedEnrollment                    Boolean
SerialNumber                                          String
Udid                                                  String


```

This function will return a list of all AppleMdmDevices. Filter, Sort, and XTotalCount are optional parameters.

### Example 2: Get an AppleMdmDevice by AppleMdmId, and DeviceId
```powershell
PS C:\> Get-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>)



----                                                  ----------
CreatedAt                                             String
DepRegistered                                         Boolean
DeviceInformationActivationLockAllowedWhileSupervised Boolean
DeviceInformationAvailableDeviceCapacity              System.Nullable[float] DeviceInformationAvailableDeviceCapacity {get;set;}
DeviceInformationDeviceCapacity                       System.Nullable[float] DeviceInformationDeviceCapacity {get;set;}
DeviceInformationDeviceName                           String
DeviceInformationIccid                                String
DeviceInformationImei                                 String
DeviceInformationIsSupervised                         Boolean
DeviceInformationModelName                            String
DeviceInformationSecondIccid                          String
DeviceInformationSecondImei                           String
DeviceInformationSecondSubscriberCarrierNetwork       String
DeviceInformationSubscriberCarrierNetwork             String
DeviceInformationWifiMac                              String
Enrolled                                              Boolean
HasActivationLockBypassCodes                          Boolean
Id                                                    String
OSVersion                                             String
SecurityInfoEnrolledViaDep                            Boolean
SecurityInfoIsActivationLockManageable                Boolean
SecurityInfoIsUserEnrollment                          Boolean
SecurityInfoPasscodePresent                           Boolean
SecurityInfoUserApprovedEnrollment                    Boolean
SerialNumber                                          String
Udid                                                  String


```

This function will Get an AppleMdmDevice by AppleMdmId DeviceId. AppleMdmId, and DeviceId are required parameters.

