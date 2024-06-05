namespace JumpCloud.SDK.DirectoryInsights
{
    using Runtime;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Linq;
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
            // We need to add a steps to the pipeline
            // Add Headers
            this._pipeline.Prepend(AddAuthHeaders);
            this._pipelineWithProxy.Prepend(AddAuthHeaders);
            // // Add Debugging Messages
            // this._pipeline.Prepend(Debugging);
            // this._pipelineWithProxy.Prepend(Debugging);
            // Add CustomErrors
            // this._pipeline.Prepend(CustomError);
            // this._pipelineWithProxy.Prepend(CustomError);
            // // Add Paginate
            // this._pipeline.Append(Paginate);
            // this._pipelineWithProxy.Append(Paginate);
        }
        // partial void AfterCreatePipeline(global::System.Management.Automation.InvocationInfo invocationInfo, ref ModuleNameSpace.Runtime.HttpPipeline pipeline)
        // {
        //     pipeline.Append(Paginate);
        // }
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
            if (request.Headers.UserAgent.ToString() != "JumpCloud_JumpCloud.PowerShell.SDK.DirectoryInsights/0.0.31")
            {
                request.Headers.UserAgent.Clear();
                request.Headers.UserAgent.ParseAdd("JumpCloud_JumpCloud.PowerShell.SDK.DirectoryInsights/0.0.31");
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
        // public async System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> Paginate(System.Net.Http.HttpRequestMessage requestMessage, Runtime.IEventListener listener, Runtime.ISendAsync next)
        // {
        //     System.Net.Http.HttpResponseMessage response = null;
        //     while (true)
        //     {
        //         // Make the API call
        //         response = await next.SendAsync(requestMessage, listener);
        //         // Get ResultCount
        //         IEnumerable<string> XResultCount;
        //         response.Headers.TryGetValues("X-Result-Count", out XResultCount);
        //         var XResultCountString = XResultCount.ToList()[0];
        //         // Get Limit
        //         IEnumerable<string> XLimit;
        //         response.Headers.TryGetValues("X-Limit", out XLimit);
        //         var XLimitString = XLimit.ToList()[0];
        //         // Get SearchAfter
        //         IEnumerable<string> XResultSearchAfter;
        //         response.Headers.TryGetValues("X-Search_after", out XResultSearchAfter);
        //         var XResultSearchAfterString = XResultSearchAfter.ToList()[0];
        //         // Write to host
        //         Console.WriteLine("XResultCount: " + XResultCountString);
        //         Console.WriteLine("XLimit: " + XLimitString);
        //         Console.WriteLine("XResultSearchAfter: " + XResultSearchAfterString);
        //         // Modify headers with new XResultSearchAfter
        //         if (XResultCountString == XLimitString) // && response == true)
        //         {
        //             ////////////////////////////////////////////////////////////////////////////////////
        //             // request.Content.Remove("X-Search_after");
        //             // request.Content.Add("X-Search_after", XResultSearchAfterString);
        //             // .Content = new StringContent("{\"name\":\"John Doe\",\"age\":33}", Encoding.UTF8, "application/json");
        //             ////////////////////////////////////////////////////////////////////////////////////
        //             // wait before getting more results
        //             await System.Threading.Tasks.Task.Delay(5000);
        //             continue;
        //         }
        //         else
        //         {
        //             // no more results, break loop.
        //             break;
        //         }
        //     };
        //     // return whatever we have.
        //     return response;
        // }
    }
}

