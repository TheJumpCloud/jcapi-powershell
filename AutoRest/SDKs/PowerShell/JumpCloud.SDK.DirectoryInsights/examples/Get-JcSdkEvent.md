### Example 1: Search All

```PowerShell
PS C:\> (Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-15T00:00:00Z') -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json

Pull all event records between Tue, 14 Apr 2020 18:00:00 -0600 to Thu, 16 Apr 2020 17:00:00 -0600
```

Pull all event records between Tue, 14 Apr 2020 18:00:00 -0600 to Thu, 16 Apr 2020 17:00:00 -0600

### Example 2: Limit results

```PowerShell
PS C:\> (Get-JcSdkEvent -Service:('directory') -StartTime:('2020-04-15T00:00:00Z') -Limit:('10') -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json

Limit directory results to last 10 in the time range
```

Limit results to last 10 in the time range

### Example 3: Sort Descending

```PowerShell
PS C:\> (Get-JcSdkEvent -Service:('directory') -StartTime:('2020-04-15T00:00:00Z') -Sort:("DESC") -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json

Sort directory descending results against timestamp value
```

Sort descending results against timestamp value

### Example 4: Sort by Event Type

```PowerShell
PS C:\> (Get-JcSdkEvent -Service:('directory') -StartTime:('2020-04-15T00:00:00Z') -Limit:('10') -EndTime:('2020-04-16T23:00:00Z') -searchTermAnd:@{"event_type" = "group_create"}).ToJsonString() | ConvertFrom-Json

Get only group_create events during a time range
```

Get only group_create events during a time range

### Example 5: Filter by two users

```PowerShell
PS C:\> (Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermOr @{"initiated_by.username" = @("user.1", "user.2")}).ToJsonString() | ConvertFrom-Json

Get login events initiated by either "user.1" or "user.2"
```

Get login events initiated by either "user.1" or "user.2"

### Example 6: Filter by two different search terms

```PowerShell
PS C:\> (Get-JCEvent -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermAnd @{"event_type" = "admin_login_attempt"; "resource.email" = "admin.user@adminbizorg.com"}).ToJsonString() | ConvertFrom-Json

Get all events between a date range and match event_type = admin_login_attempt and resource.email = admin.user@adminbizorg.com
```

Get all events between a date range and match event_type = admin_login_attempt and resource.email = admin.user@adminbizorg.com


### Example 7: Filter by SSO service and by username

```PowerShell
PS C:\> (Get-JcSdkEvent -Service:('sso') -StartTime:('2020-04-14T00:00:00Z')  -EndTime:('2020-04-20T23:00:00Z') -SearchTermAnd @{"initiated_by.username" = "user.1"}).ToJsonString() | ConvertFrom-Json

Get sso events with the search term initated_by: username with value "user.1"
```

Get sso events with the search term initated_by: username with value "user.1"

### Example 8: Filter by Organization updates

```PowerShell
PS C:\> (Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermAnd @{"event_type" = "organization_update"}).ToJsonString() | ConvertFrom-Json

Get all events filtered by organization_update term between a date range
```

Get all events filtered by organization_update term between a date range
