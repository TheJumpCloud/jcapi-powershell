# jcapi-powershell

## Description

This repository contains the PowerShell client code for the JumpCloud API v1, v2 and DirectoryInsights. It also provides the tools necessary to generate this code from the API Yaml files using AutoRest. [AutoRest]((https://github.com/Azure/autorest)), simply put is a tool used to generate client libraries for accessing RESTful web services.

## Building from AutoRest

You can build all v1, v2 and DirectoryInsights modules using AutoRest. The [BuildAutoRest](BuildAutoRest.ps1) script invokes AutoRest along and automates building custom PowerShell functions (Auto-Paginate and Authentication) from the JumpCloud API Swagger Spec.

Build DirectoryInsights

```powershell
./BuildAutoRest -SDKName JumpCloud.SDK.DirectoryInsights
```

## Importing the generated Module

After building from AutoRest, a generated module can be imported into your local PowerShell session for testing or development

```powershell
Import-Module ~/jcapi-powershell/SDKs/PowerShell/JumpCloud.SDK.DirectoryInsights/JumpCloud.SDK.DirectoryInsights.psd1
```

Although AutoRest can pack a NuGet package per each generated SDK, the packing and versioning of the PowerShell SDK is managed through our CI/CD pipeline.

## Authentication and Authorization

Authentication to the PowerShell SDK is implemented through the Custom/Module.cs file and copied into each generated SDK. Each PowerShell SDK requires an APIKEY and an ORGID to be populated. These variables are saved as an environment variable to avoid prompting per each function invocation.

## Documentation and Examples

Documentation is generated but the examples per each function need to be populated before generation. Within a given SDK directory, populate several usage examples within each SDK's /examples/ directory.

## Custom Translations and Functions

During SDK generation, a transform step is applied to the swagger spec data, think of it like a dictionary of user-friendly translations. The [ApiTansform.ps1](ApiTransform.ps1) script contains those translation definitions and will need to be updated if new endpoints require a custom translation.

Pagination - all SDK generated functions of this project should auto-paginate. This is handled by the [BuildCustomFunctions.ps1](BuildCustomFunctions.ps1) script and applied during SDK generation.

TODO: add additional module customizations here: