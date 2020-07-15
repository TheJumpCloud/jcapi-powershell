# jcapi-powershell

## Description

This repository contains the PowerShell client  code for the JumpCloud API v1, v2 and DirectoryInsights. It also provides the tools necessary to generate this code from the API Yaml files using AutoRest.

## Building from AutoRest

You can build all v1, v2 and DirectoryInsights modules using AutoRest. The [BuildAutoRest](BuildAutoRest.ps1) script invokes AutoRest along and automates building custom PowerShell functions (Auto-Paginate and Authentication) from the JumpCloud API Swagger Spec.

Build DirectoryInsights

```powershell
./BuildAutoRest -SDKName JumpCloud.SDK.DirectoryInsights
```

## Importing the generated Module

After building from AutoRest, a generated module can be imported into your local PowerShell session for testing.

```powershell
Import-Module ~/jcapi-powershell/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/JumpCloud.SDK.DirectoryInsights.psd1
```

Although AutoRest can pack a NuGet package per each generated SDK, the packing and versioning of the PowerShell SDK is managed through our CI/CD pipeline.

## Authentication and Authorization

Authentication to the PowerShell SDK is implemented through the Custom/Module.cs file and copied into each generated SDK. Each PowerShell SDK requires an APIKEY and an ORGID to be populated. These variables are saved as an environment variable to avoid prompting per each function invocation.
