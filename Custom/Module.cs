
using System.Management.Automation;
namespace SDK
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
            string actualHostEnvValue;
            string fallbackHostEnvValue = "console";

            if (!string.IsNullOrEmpty(userInputEnvValue))
            {
                switch (userInputEnvValue.ToUpperInvariant())
                {
                    case "US":
                        actualHostEnvValue = "console";
                        break;
                    case "STAGING":
                        actualHostEnvValue = "console.stg01";
                        break;
                    case "EU":
                        actualHostEnvValue = "console.eu";
                        break;
                    default:
                        // If user entered a full host (e.g., console, console.stg01, console.prod02), use as is
                        actualHostEnvValue = userInputEnvValue;
                        break;
                }
            }
            else
            {
                actualHostEnvValue = fallbackHostEnvValue;
            }
            // Log the determined environment host for transparency
            Console.WriteLine("JumpCloud SDK Module Environment: {0}.jumpcloud.com", actualHostEnvValue);
            Console.WriteLine("To change the default host environment, set the environment variable $ENV:{0} to one of the following values: 'US' or 'EU' depending on your region and re-import the module.", envVarNameForDefaultHostEnv);
            System.Environment.SetEnvironmentVariable("JCEnvironment", actualHostEnvValue);

            // Construct the PowerShell script to set $PSDefaultParameterValues
            string scriptToSetDefault = $"$Global:PSDefaultParameterValues['*-JcSdk*:HostEnv'] = '{actualHostEnvValue}'";

            try
            {
                using (PowerShell ps = PowerShell.Create(RunspaceMode.CurrentRunspace))
                {
                    ps.AddScript(scriptToSetDefault);
                    ps.Invoke();

                    if (ps.HadErrors)
                    {
                        foreach (var error in ps.Streams.Error)
                        {
                            Console.Error.WriteLine($"Error setting PSDefaultParameterValues for HostEnv: {error.ToString()}");
                        }
                    }
                    // Optionally log success
                    // else
                    // {
                    //     Console.WriteLine($"Successfully set default for -HostEnv to '{actualHostEnvValue}' via module initialization based on input '{userInputEnvValue ?? "not set"}'.");
                    // }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception while trying to set PSDefaultParameterValues for HostEnv: {ex.Message}");
            }
        }
        private void SetPSDefaultHostEnvParameterValue(string HostEnvValue)
        {
            string scriptToSetDefault = $"$Global:PSDefaultParameterValues['*-JcSdk*:HostEnv'] = '{HostEnvValue}'";
            try
            {
                using (PowerShell ps = PowerShell.Create(RunspaceMode.CurrentRunspace))
                {
                    ps.AddScript(scriptToSetDefault);
                    ps.Invoke();

                    if (ps.HadErrors)
                    {
                        foreach (var error in ps.Streams.Error)
                        {
                            Console.Error.WriteLine($"Error setting PSDefaultParameterValues for HostEnv: {error.ToString()}");
                        }
                    }
                    // Optionally log success
                    // else
                    // {
                    //     Console.WriteLine($"Successfully set default for -HostEnv to '{HostEnvValue}' via module initialization.");
                    // }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Exception while trying to set PSDefaultParameterValues for HostEnv: {ex.Message}");
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
                Console.Write("Please enter your JumpCloud environment host (e.g., console, console.eu): ");
                HostEnv = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", HostEnv);
                System.Environment.SetEnvironmentVariable("JCEnvironment", HostEnv);
            }
            SetPSDefaultHostEnvParameterValue(HostEnv);

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
            if (request.Headers.UserAgent.ToString() != "JumpCloud_SDK/ModuleVersion")
            {
                request.Headers.UserAgent.Clear();
                request.Headers.UserAgent.ParseAdd("JumpCloud_SDK/ModuleVersion");
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