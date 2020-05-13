namespace ModuleNameSpace
{
    using Runtime;
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
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
            // If headers do not contain an "x-api-key" header add one
            if (request.Headers.Contains("x-api-key") == false)
            {
                request.Headers.Add("x-api-key", JCApiKey);
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
            // request.Headers.Add("Content-Type", "application/json");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Request: '{0}'", request);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("RequestBody: '{0}'", request.Content.ReadAsStringAsync().Result);
            Console.WriteLine("------------------------------------------------------------------------");
            // let it go on.
            System.Net.Http.HttpResponseMessage result = null;
            var XResultSearchAfter;
            var XLimit;
            // System.Collections.ArrayList results = new ArrayList();
            while (true)
            {
                // make the call
                result = await next.SendAsync(request, callback);
                // results.Add(result);
                // check to see if we want to retry

                result.Result.Headers.TryGetValues("X-Search_after", XResultSearchAfter);
                result.Result.Headers.TryGetValues("X-Limit", XLimit);
                Console.WriteLine(XResultSearchAfter);
                Console.WriteLine(XLimit);
                // // While ($XResultCount -eq $XLimit -and $Result)

                // if (result && count-- == XLimit)
                // {
                //     // wait before retrying
                //     await System.Threading.Tasks.Task.Delay(10000);
                //     continue;
                // }
                // else
                // {
                //     // apparently not retrying, let's get out.
                break;
                // }
            };
            // return whatever we have.
            return result;

            // var result = await next.SendAsync(request, callback);
            // if (result.IsSuccessStatusCode)
            // {
            //     return result;
            // }
            // else
            // {
            //     var ResponseContent = await result.Content.ReadAsStringAsync();
            //     if (result.ReasonPhrase == "Unauthorized")
            //     {
            //         System.Environment.SetEnvironmentVariable("JCApiKey", "");
            //         System.Environment.SetEnvironmentVariable("JCOrgId", "");
            //     }
            //     throw new Exception(
            //     "JumpCloudApiSdkError:: "
            //     + Environment.NewLine
            //     + " StatusCode: "
            //     + (int)result.StatusCode
            //     + " - "
            //     + result.ReasonPhrase
            //     + Environment.NewLine
            //     + result.RequestMessage
            //     + Environment.NewLine
            //     + " RequestContent: " + request.Content.ReadAsStringAsync().Result
            //     + Environment.NewLine
            //     + " ResponseContent: " + ResponseContent
            //      );
            // }
            // Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("RequestBody: '{0}'", request.Content.ReadAsStringAsync().Result);
            // Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("StackTrace: '{0}'", Environment.StackTrace);
            // Console.WriteLine("ResponseContent: {0}", ResponseContent);
            // Console.WriteLine("------------------------------------------------------------------------");
            // Console.WriteLine("RequestUri : {0}", request.RequestUri);
            // Console.WriteLine(result.Content.ReadAsStringAsync());
            // Console.WriteLine("Headers: {0}", result.Headers);
            // Console.WriteLine("RequestMessage: {0}", result.RequestMessage);
            // Console.WriteLine("IsSuccessStatusCode: {0}", result.IsSuccessStatusCode);
            // Console.WriteLine("ReasonPhrase: {0}", result.ReasonPhrase);
            // Console.WriteLine("StatusCode: {0}", result.StatusCode);
            // Console.WriteLine("Version: {0}", result.Version);
        }
    }
}
