### Example 1: Remove an AppleMdmDevice by AppleMdmId, and DeviceId
```powershell
PS C:\> Remove-JcSdkAppleMdmDevice -AppleMdmId:(<string>) -DeviceId:(<string>)



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

This function will Remove an AppleMdmDevice by AppleMdmId DeviceId. AppleMdmId, and DeviceId are required parameters.

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

