### Example 1: Search All

```powershell
PS C:\> (Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-15T00:00:00Z') -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json

Pull all event records between Tue, 14 Apr 2020 18:00:00 -0600 to Thu, 16 Apr 2020 17:00:00 -0600
```

Pull all event records between Tue, 14 Apr 2020 18:00:00 -0600 to Thu, 16 Apr 2020 17:00:00 -0600

### Example 2: Limit results

```powershell
PS C:\> (Get-JcSdkEvent -Service:('directory') -StartTime:('2020-04-15T00:00:00Z') -Limit:('10') -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json

Limit results to last 10 in the time range
```

Limit results to last 10 in the time range

### Example 3: Sort Descending

```powershell
PS C:\> (Get-JcSdkEvent -Service:('directory') -StartTime:('2020-04-15T00:00:00Z') -Sort:("DESC") -EndTime:('2020-04-16T23:00:00Z')).ToJsonString() | ConvertFrom-Json

Sort descending results against timestamp value
```

Sort descending results against timestamp value

### Example 4: Sort by Event Type

```powershell
PS C:\> (Get-JcSdkEvent -Service:('directory') -StartTime:('2020-04-15T00:00:00Z') -Limit:('10') -EndTime:('2020-04-16T23:00:00Z') -searchTermAnd:@{"event_type" = "group_create"}).ToJsonString() | ConvertFrom-Json

Get only group_create events during a time range
```

Get only group_create events during a time range

### Example 5: Filter by two users

```powershell
PS C:\> (Get-JcSdkEvent -Service:('all') -StartTime:('2020-04-14T00:00:00Z') -EndTime:('2020-04-20T23:00:00Z') -SearchTermOr @{"initiated_by.username" = @("user.1", "user.2")}).ToJsonString() | ConvertFrom-Json

Get login events initiated by either "user.1" or "user.2"
```

Get login events initiated by either "user.1" or "user.2"
