### Example 1: Get All Event Counts

```powershell
PS C:\> Get-JcSdkEventCount -Service:('all') -StartTime:((Get-date).AddDays(-30))

Pull all event records from a specified time and count the results
```

Pull all event records from a specified time and count the results

### Example 2: Get SSO Event Counts

```powershell
PS C:\> Get-JcSdkEventCount -Service:('sso') -StartTime:('2020-04-14T00:00:00Z')

Pull all SSO event records from a specified time and count the results
```

Pull all SSO event records from a specified time and count the results

### Example 3: Filter by two different search terms

```powershell
PS C:\> Get-JcSdkEventCount -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermAnd @{"event_type" = "admin_login_attempt"; "resource.email" = "admin.user@adminbizorg.com"}

Get all events counts between a date range and match event_type = admin_login_attempt and resource.email = admin.user@adminbizorg.com
```

Get all events counts between a date range and match event_type = admin_login_attempt and resource.email = admin.user@adminbizorg.com

### Example 4: Sort by Event Type

```powershell
PS C:\> Get-JcSdkEventCount -Service:('directory') -StartTime:((Get-date).AddDays(-30)) -searchTermAnd:@{"event_type" = "group_create"}

Get only group_create event counts the last thirty days
```

Get only group_create event counts the last thirty days