---
Module Name: JumpCloud.SDK.DirectoryInsights
Module Guid: 07199251-dd0b-429f-83d7-6e9c22cad39b
Download Help Link: https://github.com/TheJumpCloud/jcapi-powershell/tree/master/SDKs/PowerShell/jumpcloud.sdk.directoryinsights
Help Version: 1.0.0.0
Locale: en-US
---

# JumpCloud.SDK.DirectoryInsights Module
## Description
The JumpCloud DirectoryInsights PowerShell SDK

## JumpCloud.SDK.DirectoryInsights Cmdlets
### [Get-JcSdkEvent](Get-JcSdkEvent.md)
Query the API for Directory Insights events
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"fields\": [\"timestamp\", \"event_type\", \"initiated_by\", \"success\", \"client_ip\", \"provider\", \"organization\"]}'
```

### [Get-JcSdkEventCount](Get-JcSdkEventCount.md)
Query the API for a count of matching events
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/count' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"fields\": [\"timestamp\", \"event_type\", \"initiated_by\", \"success\", \"client_ip\", \"provider\", \"organization\"]}'
```

### [Get-JcSdkEventDistinct](Get-JcSdkEventDistinct.md)
Query the API for a list of distinct values for a field
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/distinct' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"sort\": \"DESC\", \"field\": \"event_type\"}'
```

### [Get-JcSdkEventInterval](Get-JcSdkEventInterval.md)
Query the API for a list of counts by time interval
#### Sample Request
```
curl -X POST 'https://api.jumpcloud.com/insights/directory/v1/events/interval' -H 'Content-Type: application/json' -H 'x-api-key: REPLACE_KEY_VALUE' --data '{\"service\": [\"all\"], \"start_time\": \"2021-07-14T23:00:00Z\", \"end_time\": \"2021-07-28T14:00:00Z\", \"timezone\": \"-0500\", \"interval_unit\": \"h\", \"interval_value\": \"2\"}'
```

### [Get-JcSdkReport](Get-JcSdkReport.md)
Ordered list of report metadata

### [New-JcSdkReport](New-JcSdkReport.md)
Request a JumpCloud report to be generated asynchronously


