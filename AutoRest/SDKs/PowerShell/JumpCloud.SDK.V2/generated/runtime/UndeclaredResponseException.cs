
namespace JumpCloud.SDK.V2.Runtime
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public class RestException : Exception, IDisposable
    {
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public string Code { get; protected set; }
        protected string message;
        public HttpRequestMessage RequestMessage { get; protected set; }
        public HttpResponseHeaders ResponseHeaders { get; protected set; }

        public string ResponseBody { get; protected set; }
        public string ClientRequestId { get; protected set; }
        public string RequestId { get; protected set; }

        public override string Message => message;
        public string Action { get; protected set; }

        public RestException(System.Net.Http.HttpResponseMessage response)
        {
            StatusCode = response.StatusCode;
            RequestMessage = response.RequestMessage.CloneWithContent().Result;
            ResponseBody = response.Content.ReadAsStringAsync().Result;
            ResponseHeaders = response.Headers;

            RequestId = response.GetFirstHeader("x-ms-request-id");
            ClientRequestId = response.GetFirstHeader("x-ms-client-request-id");

            try
            {
                // try to parse the body as JSON, and see if a code and message are in there.
                var json = JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(ResponseBody) as JumpCloud.SDK.V2.Runtime.Json.JsonObject;
                { Code = If(json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("code"), out var c) ? (string)c : (string)StatusCode.ToString(); }
                { message = If(json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("message"), out var m) ? (string)m : (string)Message; }
                { Action = If(json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("action"), out var a) ? (string)a : (string)Action; }
            }
#if DEBUG
            catch(System.Exception E)
            {
                System.Console.Error.WriteLine($"{E.GetType().Name}/{E.Message}/{E.StackTrace}");
            }
#else 
            catch
            {
                // couldn't get the code/message from the body response. 
                // we'll create one below.
            }
#endif
            if (string.IsNullOrEmpty(message))
            {
                if (StatusCode >= System.Net.HttpStatusCode.BadRequest && StatusCode < System.Net.HttpStatusCode.InternalServerError)
                {
                    message = $"The server responded with a Request Error, Status: {StatusCode}";
                }
                else if (StatusCode >= System.Net.HttpStatusCode.InternalServerError)
                {
                    message = $"The server responded with a Server Error, Status: {StatusCode}";
                }
                else
                {
                    message = $"The server responded with an unrecognized response, Status: {StatusCode}";
                }
            }
        }

        public void Dispose()
        {
            ((IDisposable)RequestMessage).Dispose();
        }
    }

    public class RestException<T> : RestException
    {
        public T Error { get; protected set; }
        public RestException(System.Net.Http.HttpResponseMessage response, T error) : base(response)
        {
            Error = error;
        }
    }


    public class UndeclaredResponseException : RestException
    {
        public UndeclaredResponseException(System.Net.Http.HttpResponseMessage response) : base(response)
        {

        }
    }
}