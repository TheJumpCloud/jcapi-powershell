### Example 1: Create an ApprovalFlow
```powershell
New-JcSdkApprovalFlow -ApprovalType 'manual' -Category "Application" -Description "A new workflow" -MultiSelectDuration @("P5D") -Name "New Workflow" -ResourceId 5d67fd481da3c52aa1faa883 -ResourceType "user_group" -Status "active" -TimeBasedAccess -TtlConfig "TTL_CONFIG_MULTI_SELECT_DURATIONS" -VisibleTo @('6148cd739d38866f0814e874')
```

```output
Id
--
698cba2ed5a55800019f4aae
```

This function will Create an Approval Flow