namespace JumpCloud.SDK.DirectoryInsights
{
    using Runtime;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Management.Automation;
    /// <summary>A class that contains the module-common code and data.</summary>
    /// <notes>
    /// This class is where you can add things to modify the module.
    /// As long as it's in the 'custom' folder, it won't get deleted
    /// when you use --clear-output-folder in autorest.
    /// </notes>
    public partial class Module
    {
        partial void CustomInit()
        {
            // we need to add a step at the end of the pipeline
            // to attach the API key
            // once for the regular pipeline
            this._pipeline.Append(AddAuth);
            // once for the pipeline that supports a proxy
            this._pipelineWithProxy.Append(AddAuth);
        }
        protected async Task<HttpResponseMessage> AddAuth(HttpRequestMessage request, IEventListener callback, ISendAsync next)
        {
            var JCApiKey = System.Environment.GetEnvironmentVariable("JCApiKey");
            var JCOrgId = System.Environment.GetEnvironmentVariable("JCOrgId");
            if (JCApiKey == null || JCApiKey == "")
            {
                Console.Write("Please enter your JumpCloud API key: ");
                JCApiKey = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", JCApiKey);
                System.Environment.SetEnvironmentVariable("JCApiKey", JCApiKey);
            }
            if (request.RequestUri.ToString() == "https://console.jumpcloud.com/api/organizations")
            {
                System.Environment.SetEnvironmentVariable("JCOrgId", "");
            }
            else if (JCOrgId == null || JCOrgId == "")
            {
                Console.Write("Please enter your JumpCloud organization id: ");
                JCOrgId = Console.ReadLine();
                Console.WriteLine("You entered '{0}'", JCOrgId);
                System.Environment.SetEnvironmentVariable("JCOrgId", JCOrgId);
                request.Headers.Add("x-org-id", JCOrgId);
            }
            if (request.Headers.Contains("x-api-key") == false)
            {
                request.Headers.Add("x-api-key", JCApiKey);
            }
            if (request.Headers.Contains("Accept") == false)
            {
                request.Headers.Add("Accept", "application/json");
            }
            request.Headers.UserAgent.ParseAdd("JumpCloud_JumpCloud.PowerShell.SDK.DirectoryInsights/0.0.4");
            // request.Headers.Add("Content-Type", "application/json");
            // let it go on.
            var requestResult = await next.SendAsync(request, callback);
            // Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("RequestUri : {0}", request.RequestUri);
            // Console.WriteLine("Content: {0}", requestResult.Content);
            // Console.WriteLine(requestResult.Content.ToString());
            // Console.WriteLine("Headers: {0}", requestResult.Headers);
            // Console.WriteLine("RequestMessage: {0}", requestResult.RequestMessage);
            // Console.WriteLine("IsSuccessStatusCode: {0}", requestResult.IsSuccessStatusCode);
            // Console.WriteLine("ReasonPhrase: {0}", requestResult.ReasonPhrase);
            // Console.WriteLine("StatusCode: {0}", requestResult.StatusCode);
            // Console.WriteLine("Version: {0}", requestResult.Version);
            if (requestResult.IsSuccessStatusCode)
            {
                return requestResult;
            }
            else
            {
                if (requestResult.ReasonPhrase == "Unauthorized")
                {
                    System.Environment.SetEnvironmentVariable("JCApiKey", "");
                    System.Environment.SetEnvironmentVariable("JCOrgId", "");
                }
                throw new Exception(
                "JumpCloudApiSdkError:: "
                + Environment.NewLine
                + " StatusCode: "
                + (int)requestResult.StatusCode
                + " - "
                + requestResult.ReasonPhrase
                + Environment.NewLine
                + requestResult.RequestMessage
                + ";"
                 );
            }
        }
    }
}

