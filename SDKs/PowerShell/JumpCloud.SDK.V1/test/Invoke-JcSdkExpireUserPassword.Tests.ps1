BeforeAll {
    if(($null -eq $TestName) -or ($TestName -contains 'Invoke-JcSdkExpireUserPassword'))
    {
      $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
      if (-Not (Test-Path -Path $loadEnvPath)) {
          $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
      }
      . ($loadEnvPath)
      $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-JcSdkExpireUserPassword.Recording.json'
      $currentPath = $PSScriptRoot
      while(-not $mockingPath) {
          $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
          $currentPath = Split-Path -Path $currentPath -Parent
      }
      . ($mockingPath | Select-Object -First 1).FullName
    }
}

Describe 'Invoke-JcSdkExpireUserPassword' -Tag:(""){
    It 'Post' {
        $body = [JumpCloud.SDK.V1.Models.Systemuserput]@{
            Email = "PesterInvokeExpire-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))@example.com";
            Firstname = "InvokeExpire";
            Lastname = "UserPasssword";
            Username  = "PesterInvokeExpire-$(-join ((65..90) + (97..122) | Get-Random -Count 5 | ForEach-Object { [char]$_ }))";
            Password = "TestTest1234!@#"
        }
        $userToExpire = New-JcSdkUser -Body $body
        { Invoke-JcSdkExpireUserPassword -id:($userToExpire.Id) } | Should -Not -Throw
        # Cleanup
        Remove-JcSdkUser -Id $userToExpire.Id
    }

    It 'PostViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
