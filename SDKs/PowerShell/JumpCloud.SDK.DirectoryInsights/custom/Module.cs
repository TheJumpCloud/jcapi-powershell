using System.Management.Automation;
using ModuleNameSpace;
namespace JumpCloud.SDK.DirectoryInsights
{
    using Runtime;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Linq;

    public partial class Module
    {
        partial void CustomInit()
        {
            // Original pipeline modifications
            this._pipeline.Prepend(AddAuthHeaders);
            this._pipelineWithProxy.Prepend(AddAuthHeaders);

            // Set the default JCEnvironment value
            SetDefaultHostEnvInPowerShellSession();
        }

        private void SetDefaultHostEnvInPowerShellSession()
        {
            string envVarNameForDefaultHostEnv = "JCEnvironment";
            string userInputEnvValue = System.Environment.GetEnvironmentVariable(envVarNameForDefaultHostEnv);

            bool showInfo = false;
            string apiHostValue;
            string consoleHostValue;

            if (!string.IsNullOrEmpty(userInputEnvValue))
            {
                switch (userInputEnvValue.ToUpperInvariant())
                {
                    case "STANDARD":
                        apiHostValue = "api";
                        consoleHostValue = "console";
                        break;
                    case "EU":
                        apiHostValue = "api.eu";
                        consoleHostValue = "console.eu";
                        break;
                    case "STAGING":
                        apiHostValue = "api.stg01";
                        consoleHostValue = "console.stg01";
                        break;
                    default:
                        // User provided specific value - determine region and set both
                        if (userInputEnvValue.Contains(".eu"))
                        {
                            apiHostValue = "api.eu";
                            consoleHostValue = "console.eu";
                        }
                        else if (userInputEnvValue.Contains(".stg01"))
                        {
                            apiHostValue = "api.stg01";
                            consoleHostValue = "console.stg01";
                        }
                        else
                        {
                            apiHostValue = "api";
                            consoleHostValue = "console";
                        }
                        break;
                }
            }
            else
            {
                // Default to US region
                apiHostValue = "api";
                consoleHostValue = "console";
                showInfo = true;
            }

            if (showInfo)
            {
                string defaultHostPrefix = ModuleIdentifier.SDKName == "DirectoryInsights" ? "api" : "console";
                Console.WriteLine("JumpCloud SDK Module: {0} is running in the '{1}.jumpcloud.com' host environment.", ModuleIdentifier.SDKName, defaultHostPrefix);
                Console.WriteLine("'{0}.jumpcloud.com' is the standard environment; '{0}.eu.jumpcloud.com' is the EU environment.", defaultHostPrefix);
                Console.WriteLine("To use the EU environment, run: $ENV:{0} = 'EU' and re-import the module.", envVarNameForDefaultHostEnv);
                Console.WriteLine("To use the standard environment, run: $ENV:{0} = 'STANDARD' and re-import the module.", envVarNameForDefaultHostEnv);
            }

            // Store the appropriate value based on SDK type
            string sdkHostValue = ModuleIdentifier.SDKName == "DirectoryInsights" ? apiHostValue : consoleHostValue;
            System.Environment.SetEnvironmentVariable("JCEnvironment", sdkHostValue);

            // Set parameter defaults for both DI and V1/V2 SDKs
            SetPSDefaultHostEnvParameterValue(apiHostValue, consoleHostValue);
        }

        private void SetPSDefaultHostEnvParameterValue(string apiHostValue, string consoleHostValue)
        {
            // Always set both parameter defaults so all SDKs work correctly regardless of import order
            string scriptToSetDefaults = $@"
                $Global:PSDefaultParameterValues['*-JcSdk*:ApiHost'] = '{apiHostValue}'
                $Global:PSDefaultParameterValues['*-JcSdk*:ConsoleHost'] = '{consoleHostValue}'
            ";
            try
            {
                using (PowerShell ps = PowerShell.Create(RunspaceMode.CurrentRunspace))
                {
                    ps.AddScript(scriptToSetDefaults);
                    ps.Invoke();

                    if (ps.HadErrors)
                    {
                        foreach (var error in ps.Streams.Error)
                        {
                            Console.Error.WriteLine($"Error setting PSDefaultParameterValues: {error.ToString()}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception while trying to set PSDefaultParameterValues: {ex.Message}");
            }
        }

        protected async Task<HttpResponseMessage> AddAuthHeaders(HttpRequestMessage request, IEventListener callback, ISendAsync next)
        {
            // Check to see if the environment variable for JCApiKey is populated
            var JCApiKey = System.Environment.GetEnvironmentVariable("JCApiKey");
            if (JCApiKey == null || JCApiKey == "")
            {
                Console.Write("Please enter your JumpCloud API key: ");
                JCApiKey = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", JCApiKey);
                System.Environment.SetEnvironmentVariable("JCApiKey", JCApiKey);
            }
            // If headers do not contain an "x-api-key" header add one
            if (request.Headers.Contains("x-api-key") == false)
            {
                request.Headers.Add("x-api-key", JCApiKey);
            }
            // Check to see if the environment variable for JCOrgId is populated
            var JCOrgId = System.Environment.GetEnvironmentVariable("JCOrgId");
            if (JCOrgId == null || JCOrgId == "")
            {
                Console.Write("Please enter your JumpCloud organization id: ");
                JCOrgId = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", JCOrgId);
                System.Environment.SetEnvironmentVariable("JCOrgId", JCOrgId);
            }
            // Check to see if the environment variable for HostEnv is populated
            var HostEnv = System.Environment.GetEnvironmentVariable("JCEnvironment");
            if (string.IsNullOrEmpty(HostEnv))
            {
                // Determine default based on SDK
                string defaultHostPrefix = ModuleIdentifier.SDKName == "DirectoryInsights" ? "api" : "console";
                Console.Write($"Please enter your JumpCloud environment host (e.g., {defaultHostPrefix}, {defaultHostPrefix}.eu): ");
                HostEnv = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", HostEnv);
                System.Environment.SetEnvironmentVariable("JCEnvironment", HostEnv);

                // Translate to both formats and set parameter defaults
                string apiHost = HostEnv.Contains(".eu") ? "api.eu" : (HostEnv.Contains(".stg01") ? "api.stg01" : "api");
                string consoleHost = HostEnv.Contains(".eu") ? "console.eu" : (HostEnv.Contains(".stg01") ? "console.stg01" : "console");
                SetPSDefaultHostEnvParameterValue(apiHost, consoleHost);
            }

            // If headers do not contain an "x-org-id" header add one
            if (request.Headers.Contains("x-org-id") == false)
            {
                request.Headers.Add("x-org-id", JCOrgId);
            }
            List<String> mtpUrls = new List<String>();
            // Adding elements to List
            mtpUrls.Add("/api/search/organizations");
            mtpUrls.Add("/api/organizations");
            mtpUrls.Add("/api/users");
            mtpUrls.Add("/api/v2/organizations");
            mtpUrls.Add("/api/v2/administrators");
            mtpUrls.Add("/api/v2/providers");
            mtpUrls.Add("/api/v2/integrations/");
            foreach (string mtpUrl in mtpUrls){
                // Several endpoints do not accept x-org-id as a header so remove it
                if (request.Headers.Contains("x-org-id") && request.RequestUri.LocalPath.StartsWith(mtpUrl) == true)
                {
                    request.Headers.Remove("x-org-id");
                }
            }
            // If headers do not contain an "Accept" header add one
            if (request.Headers.Contains("Accept") == false)
            {
                request.Headers.Add("Accept", "application/json");
            }
            // If headers do not contain an "UserAgent" with the correct value fix it
            if (request.Headers.UserAgent.ToString() != "JumpCloud_JumpCloud.PowerShell.SDK.DirectoryInsights/0.1.0")
            {
                request.Headers.UserAgent.Clear();
                request.Headers.UserAgent.ParseAdd("JumpCloud_JumpCloud.PowerShell.SDK.DirectoryInsights/0.1.0");
            }
            // // request.Headers.Add("Content-Type", "application/json");
            System.Net.Http.HttpResponseMessage response = await next.SendAsync(request, callback);
            return response;
        }
        protected async Task<HttpResponseMessage> Debugging(HttpRequestMessage request, IEventListener callback, ISendAsync next)
        {
            System.Net.Http.HttpResponseMessage response = await next.SendAsync(request, callback);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Request: '{0}'", request);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("RequestBody: '{0}'", request.Content.ReadAsStringAsync().Result);
            Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);
            // Console.WriteLine("ResponseContent: {0}", ResponseContent);
            // Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("RequestUri : {0}", request.RequestUri);
            // Console.WriteLine(response.Content.ReadAsStringAsync());
            // Console.WriteLine("Headers: {0}", response.Headers);
            // Console.WriteLine("RequestMessage: {0}", response.RequestMessage);
            // Console.WriteLine("IsSuccessStatusCode: {0}", response.IsSuccessStatusCode);
            // Console.WriteLine("ReasonPhrase: {0}", response.ReasonPhrase);
            // Console.WriteLine("StatusCode: {0}", response.StatusCode);
            // Console.WriteLine("Version: {0}", response.Version);
            return response;
        }
        protected async Task<HttpResponseMessage> CustomError(HttpRequestMessage request, IEventListener callback, ISendAsync next)
        {
            System.Net.Http.HttpResponseMessage response = await next.SendAsync(request, callback);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                var ResponseContent = await response.Content.ReadAsStringAsync();
                if (response.ReasonPhrase == "Unauthorized")
                {
                    System.Environment.SetEnvironmentVariable("JCApiKey", "");
                    System.Environment.SetEnvironmentVariable("JCOrgId", "");
                }
                throw new Exception(
                "JumpCloudApiSdkError:: "
                + Environment.NewLine
                + " StatusCode: "
                + (int)response.StatusCode
                + " - "
                + response.ReasonPhrase
                + Environment.NewLine
                + response.RequestMessage
                + Environment.NewLine
                + " RequestContent: " + request.Content.ReadAsStringAsync().Result
                + Environment.NewLine
                + " ResponseContent: " + ResponseContent
                 );
            }
        }
    }
}
