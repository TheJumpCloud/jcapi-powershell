# jcapi-powershell

https://dev.azure.com/JumpCloudPowershell/JumpCloudApiSdk/_apis/build/status/JumpCloud.SDK.V1
https://dev.azure.com/JumpCloudPowershell/JumpCloudApiSdk/_apis/build/status/JumpCloud.SDK.V2
https://dev.azure.com/JumpCloudPowershell/JumpCloudApiSdk/_apis/build/status/JumpCloud.SDK.DirectoryInsights

## Description

This repository contains the PowerShell client code for the JumpCloud V1, V2 and DirectoryInsights APIs. It also provides the tools necessary to generate this code from the API Yaml files using AutoRest. [AutoRest](https://github.com/Azure/autorest), simply put is a tool used to generate client libraries for accessing RESTful web services.

## Building from AutoRest

You can build all V1, V2 and DirectoryInsights modules using AutoRest. The [BuildAutoRest](BuildAutoRest.ps1) script invokes AutoRest along and automates the building PowerShell functions from the JumpCloud API Swagger Spec. You can change the behavior of how AutoRest builds the SDKs by modifying the contents of the [config files](Configs).

Example: Building DirectoryInsights

```powershell
./BuildAutoRest -SDKName JumpCloud.SDK.DirectoryInsights -JCApiKey <ApiKey> -JCOrgId <OrgId>
```

## Importing the generated Module

After building from AutoRest, a generated module can be imported into your local PowerShell session for testing or development

```powershell
Import-Module ~/jcapi-powershell/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/JumpCloud.SDK.DirectoryInsights.psd1
```

or by calling the run-module.ps1 script located within each SDK folder

```powershell
./jcapi-powershell/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/run-module.ps1
```


Although AutoRest can pack a NuGet package per each generated SDK, the packing and versioning of the PowerShell SDK is managed through our CI/CD pipeline.

## Authentication and Authorization

Authentication to the PowerShell SDK is implemented through the Custom/Module.cs file and copied into each generated SDK. Each PowerShell SDK requires an APIKEY and an ORGID to be populated. These variables are saved as an environment variable to avoid prompting per each function invocation.

## Documentation and Examples

Documentation is generated but the examples per each function need to be populated before generation. Within a given SDK directory, populate several usage examples within each SDK's /examples/ directory.

## Custom Translations and Functions

During SDK generation, a transform step is applied to the swagger spec data, think of it like a dictionary of user-friendly translations. The [ApiTansform.ps1](ApiTransform.ps1) script contains those translation definitions and will need to be updated if new endpoints require a custom translation.

These [SDKs](https://www.powershellgallery.com/packages?q=JumpCloud.SDK) contain all the functionality of the [JumpCloudAPIs](https://docs.jumpcloud.com) in addition to the following added features that have been applied during SDK generation by the [BuildCustomFunctions.ps1](BuildCustomFunctions.ps1) script:
* Authentication through environment variables `$env:JCApiKey` and `$env:JCOrgId`. If these are not set the SDK will prompt the user to set them and in turn append the `x-api-key` and `x-org-id` headers to each API call.
* Normalization of endpoint output. The multiple APIs return data in different ways which have been normalized through the SDKs.
* Auto pagination and removal of `Skip` and `Limit` parameters. This enables the functions to return all data from API endpoint.