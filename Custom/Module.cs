// Add this using statement at the top of your Module.cs if it's not already there
using System.Management.Automation;

namespace ModuleNameSpace
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

            // **New code to set $PSDefaultParameterValues for EnvHost**
            SetDefaultEnvHostInPowerShellSession();
        }

        private void SetDefaultEnvHostInPowerShellSession()
        {
            // Define the name of the environment variable you'll use to specify the default EnvHost
            string envVarNameForDefaultEnvHost = "JC_DEFAULT_ENV_HOST";
            string defaultEnvHostValue = System.Environment.GetEnvironmentVariable(envVarNameForDefaultEnvHost);

            // If the environment variable isn't set, you can fall back to a hardcoded default
            if (string.IsNullOrEmpty(defaultEnvHostValue))
            {
                defaultEnvHostValue = "console"; // Your ultimate fallback default
            }

            // Construct the PowerShell script to set $PSDefaultParameterValues
            // Note the single quotes around the defaultEnvHostValue in the script string
            // to handle it as a PowerShell string literal.
            string scriptToSetDefault = $"$PSDefaultParameterValues['*:EnvHost'] = '{defaultEnvHostValue}'";

            try
            {
                // Create a PowerShell instance that runs in the current session's runspace
                using (PowerShell ps = PowerShell.Create(RunspaceMode.CurrentRunspace))
                {
                    ps.AddScript(scriptToSetDefault);
                    ps.Invoke(); // Execute the script

                    if (ps.HadErrors)
                    {
                        // Log any errors that occurred while trying to set the default
                        foreach (var error in ps.Streams.Error)
                        {
                            // You might want a more robust logging mechanism
                            Console.Error.WriteLine($"Error setting PSDefaultParameterValues for EnvHost: {error.ToString()}");
                        }
                    }
                    else
                    {
                        // Optionally, log success or provide feedback if in a verbose/debug mode
                        // Console.WriteLine($"Successfully set default for -EnvHost to '{defaultEnvHostValue}' via module initialization.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch any exceptions during the PowerShell invocation process itself
                Console.Error.WriteLine($"Exception while trying to set PSDefaultParameterValues for EnvHost: {ex.Message}");
            }
        }

        // ... (rest of your Module.cs code, like AddAuthHeaders, Debugging, CustomError) ...
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
            if (request.Headers.UserAgent.ToString() != "JumpCloud_ModuleNameSpace/ModuleVersion")
            {
                request.Headers.UserAgent.Clear();
                request.Headers.UserAgent.ParseAdd("JumpCloud_ModuleNameSpace/ModuleVersion");
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