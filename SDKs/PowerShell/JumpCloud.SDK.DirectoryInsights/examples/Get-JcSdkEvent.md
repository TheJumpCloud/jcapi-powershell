### Example 1: Search All

```powershell
PS C:\> Get-JcSdkEvent -Service:('all') -StartTime:((Get-date).AddDays(-30))

Pull all event records from the last thirty days
```

Pull all event records from the last thirty days

### Example 2: Limit results

```powershell
PS C:\> Get-JcSdkEvent -Service:('directory') -StartTime:((Get-date).AddHours(-1)) -Limit:('10')

Get directory results from the last hour limit to the last 10 results in the time range
```

Get directory results from the last hour limit to the last 10 results in the time range

### Example 3: Sort Descending

```powershell
PS C:\> Get-JcSdkEvent -Service:('directory') -StartTime:((Get-date).AddDays(-30)) -Sort:("DESC") -EndTime:((Get-date).AddDays(-5))

Get directory results between 30 and 5 days ago, sort timestamp by descending value
```

Get directory results between 30 and 5 days ago, sort timestamp by descending value

### Example 4: Sort by Event Type

```powershell
PS C:\> Get-JcSdkEvent -Service:('directory') -StartTime:((Get-date).AddDays(-30)) -Limit:('10') -searchTermAnd:@{"event_type" = "group_create"}

Get only group_create from the last thirty days
```

Get only group_create from the last thirty days

### Example 5: Filter by two users

```powershell
PS C:\> Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermOr @{"initiated_by.username" = @("user.1", "user.2")}

Get login events initiated by either "user.1" or "user.2" between a universal time zone range
```

Get login events initiated by either "user.1" or "user.2" between a universal time zone range

### Example 6: Filter by two different search terms

```powershell
PS C:\> Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermAnd @{"event_type" = "admin_login_attempt"; "resource.email" = "admin.user@adminbizorg.com"}

Get all events between a date range and match event_type = admin_login_attempt and resource.email = admin.user@adminbizorg.com
```

Get all events between a date range and match event_type = admin_login_attempt and resource.email = admin.user@adminbizorg.com

### Example 7: Filter by SSO service and by username

```powershell
PS C:\> Get-JcSdkEvent -Service:('sso') -StartTime:('2020-04-14T00:00:00Z')  -EndTime:('2020-04-20T23:00:00Z') -SearchTermAnd @{"initiated_by.username" = "user.1"}

Get sso events with the search term initiated_by: username with value "user.1"
```

Get sso events with the search term initiated_by: username with value "user.1"

### Example 8: Filter by Organization updates

```powershell
PS C:\> Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermAnd @{"event_type" = "organization_update"}

Get all events filtered by organization_update term between a date range
```

Get all events filtered by organization_update term between a date range