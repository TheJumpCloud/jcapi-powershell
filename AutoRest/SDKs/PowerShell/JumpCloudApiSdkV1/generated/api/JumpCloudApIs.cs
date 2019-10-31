namespace JumpCloudApiSdkV1
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>
    /// Low-level API implementation for the JumpCloud APIs service.
    /// </summary>
    public partial class JumpCloudApIs
    {

        /// <summary>The endpoint adds a new SSO / SAML Applications.</summary>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="body">Application</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationCreate(string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationCreate_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>The endpoint adds a new SSO / SAML Applications.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="body">Application</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationCreateViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/applications$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/applications'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationCreate_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ApplicationCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Application.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ApplicationCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="body">Application</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationCreate_Validate(string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(contentType),contentType);
                await eventListener.AssertNotNull(nameof(accept),accept);
                await eventListener.AssertNotNull(nameof(xOrgId),xOrgId);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>The endpoint deletes an SSO / SAML Application.</summary>
        /// <param name="id"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationDelete(string id, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationDelete_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>The endpoint deletes an SSO / SAML Application.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationDeleteViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/applications/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/applications/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationDelete_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ApplicationDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Application.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ApplicationDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationDelete_Validate(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(contentType),contentType);
                await eventListener.AssertNotNull(nameof(accept),accept);
                await eventListener.AssertNotNull(nameof(xOrgId),xOrgId);
            }
        }

        /// <summary>The endpoint retrieves an SSO / SAML Application.</summary>
        /// <param name="id"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationGet(string id, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationGet_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>The endpoint retrieves an SSO / SAML Application.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationGetViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/applications/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/applications/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationGet_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ApplicationGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Application.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ApplicationGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationGet_Validate(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(contentType),contentType);
                await eventListener.AssertNotNull(nameof(accept),accept);
                await eventListener.AssertNotNull(nameof(xOrgId),xOrgId);
            }
        }

        /// <summary>
        /// The endpoint returns all your SSO / SAML Applications.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/applications \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationList(string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// The endpoint returns all your SSO / SAML Applications.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/applications \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationListViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/applications$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/applications'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ApplicationList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Applicationslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ApplicationList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationList_Validate(string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>The endpoint updates a SSO / SAML Application.</summary>
        /// <param name="id"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="body">Application</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationPut(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationPut_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>The endpoint updates a SSO / SAML Application.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="body">Application</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationPutViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/applications/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/applications/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/applications/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != contentType)
                {
                    request.Headers.Add("Content-Type",contentType);
                }
                if (null != accept)
                {
                    request.Headers.Add("Accept",accept);
                }
                if (null != xOrgId)
                {
                    request.Headers.Add("x-org-id",xOrgId);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationPut_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ApplicationPut" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationPut_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Application.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ApplicationPut" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="xOrgId"></param>
        /// <param name="body">Application</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationPut_Validate(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(contentType),contentType);
                await eventListener.AssertNotNull(nameof(accept),accept);
                await eventListener.AssertNotNull(nameof(xOrgId),xOrgId);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// The endpoint returns a specific SSO / SAML Application Template.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/application-templates/{id} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationTemplateGet(string id, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplate>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/application-templates/"
                        + global::System.Uri.EscapeDataString(id)
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationTemplateGet_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// The endpoint returns a specific SSO / SAML Application Template.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/application-templates/{id} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationTemplateGetViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplate>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/application-templates/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/application-templates/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/application-templates/"
                        + id
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationTemplateGet_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ApplicationTemplateGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationTemplateGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplate>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Applicationtemplate.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ApplicationTemplateGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationTemplateGet_Validate(string id, string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// The endpoint returns all the SSO / SAML Application Templates.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/application-templates \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationTemplateList(string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplateslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/application-templates"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationTemplateList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// The endpoint returns all the SSO / SAML Application Templates.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/application-templates \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ApplicationTemplateListViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplateslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/application-templates$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/application-templates'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/application-templates"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ApplicationTemplateList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ApplicationTemplateList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationTemplateList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplateslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Applicationtemplateslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ApplicationTemplateList" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="fields">The comma separated fields included in the returned records. If omitted the default list of fields
        /// will be returned.</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort"></param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ApplicationTemplateList_Validate(string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint allows you to create a new command.
        /// #### Sample Request
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/commands/ \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "name":"Test API Command",
        /// "command":"String",
        /// "user":"{UserID}",
        /// "schedule":"",
        /// "timeout":"100"
        /// }'
        /// ```
        /// </summary>
        /// <param name="body">Command</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandCreate(JumpCloudApiSdkV1.Models.ICommand body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandCreate_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Command.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="body">Command</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandCreate_Validate(JumpCloudApiSdkV1.Models.ICommand body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// This endpoint deletes a specific command based on the Command ID.
        /// #### Sample Request
        /// ```
        /// curl -X DELETE https://console.jumpcloud.com/api/commands/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandDelete(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandDelete_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint deletes a specific command based on the Command ID.
        /// #### Sample Request
        /// ```
        /// curl -X DELETE https://console.jumpcloud.com/api/commands/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/commands/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/commands/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandDelete_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandDelete_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
            }
        }

        /// <summary>
        /// This endpoint returns the uploaded file(s) associated with a specific command.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/files/command/{commandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandFileGet(string id, string fields, int? limit, int? skip, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandfilereturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsFilesCommandIdGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/files/command/"
                        + global::System.Uri.EscapeDataString(id)
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandFileGet_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns the uploaded file(s) associated with a specific command.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/files/command/{commandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandFileGetViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandfilereturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsFilesCommandIdGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/files/command/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/files/command/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/files/command/"
                        + id
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandFileGet_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandFileGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandFileGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandfilereturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsFilesCommandIdGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Commandfilereturn.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.BadRequest:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onBadRequest(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.PathsFilesCommandIdGetResponses400ContentApplicationJsonSchema.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandFileGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandFileGet_Validate(string id, string fields, int? limit, int? skip, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
            }
        }

        /// <summary>
        /// This endpoint returns a specific command based on the command ID.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commands/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandGet(string id, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands/"
                        + global::System.Uri.EscapeDataString(id)
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandGet_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns a specific command based on the command ID.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commands/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandGetViaIdentity(global::System.String viaIdentity, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/commands/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/commands/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands/"
                        + id
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandGet_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Command.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandGet" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandGet_Validate(string id, string fields, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint returns all commands.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commands/ \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandList(int? skip, string fields, int? limit, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands"
                        + "?"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandList_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns all commands.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commands/ \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandListViaIdentity(global::System.String viaIdentity, int? skip, string fields, int? limit, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/commands$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/commands'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands"
                        + "?"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandList_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Commandslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandList" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandList_Validate(int? skip, string fields, int? limit, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint Updates a command based on the command ID and returns the modified command record.
        /// #### Sample Request
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "name":"Test API Command",
        /// "command":"String",
        /// "user":"{UserID}",
        /// "schedule":"",
        /// "timeout":"100"
        /// }'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">Command</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandPut(string id, JumpCloudApiSdkV1.Models.ICommand body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandPut_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint Updates a command based on the command ID and returns the modified command record.
        /// #### Sample Request
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/commands/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "name":"Test API Command",
        /// "command":"String",
        /// "user":"{UserID}",
        /// "schedule":"",
        /// "timeout":"100"
        /// }'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="body">Command</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandPutViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.ICommand body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/commands/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/commands/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commands/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandPut_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandPut" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandPut_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Command.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandPut" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">Command</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandPut_Validate(string id, JumpCloudApiSdkV1.Models.ICommand body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// This endpoint deletes a specific command result.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commandresults/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ````
        /// </summary>
        /// <param name="id"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandResultDelete(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commandresults/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandResultDelete_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint deletes a specific command result.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commandresults/{CommandID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ````
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandResultDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/commandresults/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/commandresults/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commandresults/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandResultDelete_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandResultDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandResultDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Commandresult.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandResultDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandResultDelete_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
            }
        }

        /// <summary>
        /// This endpoint returns a specific command result.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commandresults/{CommandResultID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandResultGet(string id, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commandresults/"
                        + global::System.Uri.EscapeDataString(id)
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandResultGet_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns a specific command result.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commandresults/{CommandResultID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandResultGetViaIdentity(global::System.String viaIdentity, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/commandresults/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/commandresults/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commandresults/"
                        + id
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandResultGet_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandResultGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandResultGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Commandresult.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandResultGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandResultGet_Validate(string id, string fields, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint returns all command results.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commandresults \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key:{API_KEY}'
        /// ```
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandResultList(string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresultslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commandresults"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandResultList_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns all command results.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/commandresults \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key:{API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandResultListViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresultslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/commandresults$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/commandresults'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/commandresults"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandResultList_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandResultList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandResultList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresultslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Commandresultslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandResultList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandResultList_Validate(string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint allows you to launch a command based on a defined trigger.
        /// #### Sample Requests
        /// **Launch a Command via a Trigger**
        /// ```
        /// curl --silent \
        /// -X 'POST' \
        /// -H "x-api-key: {API_KEY}" \
        /// "https://console.jumpcloud.com/api/command/trigger/{TriggerName}"
        /// ```
        /// **Launch a Command via a Trigger passing a JSON object to the command**
        /// ```
        /// curl --silent \
        /// -X 'POST' \
        /// -H "x-api-key: {API_KEY}" \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -d '{ "srcip":"192.168.2.32", "attack":"Cross Site Scripting Attempt" }' \
        /// "https://console.jumpcloud.com/api/command/trigger/{TriggerName}"
        /// ```
        /// </summary>
        /// <param name="triggername"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandTriggerWebhookStart(string triggername, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/command/trigger/"
                        + global::System.Uri.EscapeDataString(triggername)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandTriggerWebhookStart_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to launch a command based on a defined trigger.
        /// #### Sample Requests
        /// **Launch a Command via a Trigger**
        /// ```
        /// curl --silent \
        /// -X 'POST' \
        /// -H "x-api-key: {API_KEY}" \
        /// "https://console.jumpcloud.com/api/command/trigger/{TriggerName}"
        /// ```
        /// **Launch a Command via a Trigger passing a JSON object to the command**
        /// ```
        /// curl --silent \
        /// -X 'POST' \
        /// -H "x-api-key: {API_KEY}" \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -d '{ "srcip":"192.168.2.32", "attack":"Cross Site Scripting Attempt" }' \
        /// "https://console.jumpcloud.com/api/command/trigger/{TriggerName}"
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task CommandTriggerWebhookStartViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/command/trigger/(?<triggername>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/command/trigger/{triggername}'");
                }

                // replace URI parameters with values from identity
                var triggername = _match.Groups["triggername"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/command/trigger/"
                        + triggername

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.CommandTriggerWebhookStart_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CommandTriggerWebhookStart" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandTriggerWebhookStart_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="CommandTriggerWebhookStart" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="triggername"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CommandTriggerWebhookStart_Validate(string triggername, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(triggername),triggername);
            }
        }

        /// <summary>
        /// This endpoint returns Organization Details.
        /// #### Sample Request
        /// ```
        /// curl -X GET \
        /// https://console.jumpcloud.com/api/organizations \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OrganizationList(string fields, string filter, int? limit, int? skip, string sort, string search, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/organizations"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(search) ? global::System.String.Empty : "search=" + global::System.Uri.EscapeDataString(search))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OrganizationList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns Organization Details.
        /// #### Sample Request
        /// ```
        /// curl -X GET \
        /// https://console.jumpcloud.com/api/organizations \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OrganizationListViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, string sort, string search, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/organizations$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/organizations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/organizations"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(search) ? global::System.String.Empty : "search=" + global::System.Uri.EscapeDataString(search))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OrganizationList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="OrganizationList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OrganizationList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Organizationslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="OrganizationList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OrganizationList_Validate(string fields, string filter, int? limit, int? skip, string sort, string search, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(search),search);
            }
        }

        /// <summary>
        /// This endpoint will return Organization data based on your search parameters. This endpoint WILL NOT allow you to add a
        /// new Organization.
        /// You can use the supported parameters and pass those in the body of request.
        /// The parameters must be passed as Content-Type application/json.
        /// #### Sample Request
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/organizations \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "search":{
        /// "fields" : ["settings.name"],
        /// "searchTerm": "Second"
        /// },
        /// "fields": ["_id", "displayName", "logoUrl"],
        /// "limit" : 0,
        /// "skip" : 0
        /// }'
        /// ```
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="body">Search</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OrganizationSearch(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/search/organizations"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OrganizationSearch_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint will return Organization data based on your search parameters. This endpoint WILL NOT allow you to add a
        /// new Organization.
        /// You can use the supported parameters and pass those in the body of request.
        /// The parameters must be passed as Content-Type application/json.
        /// #### Sample Request
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/organizations \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "search":{
        /// "fields" : ["settings.name"],
        /// "searchTerm": "Second"
        /// },
        /// "fields": ["_id", "displayName", "logoUrl"],
        /// "limit" : 0,
        /// "skip" : 0
        /// }'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="body">Search</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OrganizationSearchViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/search/organizations$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/search/organizations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/search/organizations"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OrganizationSearch_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="OrganizationSearch" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OrganizationSearch_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Organizationslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="OrganizationSearch" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="body">Search</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OrganizationSearch_Validate(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// This endpoint allows you to create RADIUS servers in your organization.
        /// #### Sample Request
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/radiusservers/ \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "name": "{test_radius}",
        /// "networkSourceIp": "{0.0.0.0}",
        /// "sharedSecret":"{secretpassword}",
        /// "userLockoutAction": "REMOVE",
        /// "userPasswordExpirationAction": "MAINTAIN"
        /// }'
        /// ```
        /// </summary>
        /// <param name="body">RadiusServerPost</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task RadiusServerCreate(JumpCloudApiSdkV1.Models.IRadiusserverpost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserver>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/radiusservers"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.RadiusServerCreate_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="RadiusServerCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task RadiusServerCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserver>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Radiusserver.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="RadiusServerCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="body">RadiusServerPost</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task RadiusServerCreate_Validate(JumpCloudApiSdkV1.Models.IRadiusserverpost body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// This endpoint allows you to get a list of all RADIUS servers in your organization.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/radiusservers/ \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// ```
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task RadiusServerList(string fields, string filter, int? limit, int? skip, string sort, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/radiusservers"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.RadiusServerList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to get a list of all RADIUS servers in your organization.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/radiusservers/ \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task RadiusServerListViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, string sort, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/radiusservers$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/radiusservers'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/radiusservers"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.RadiusServerList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="RadiusServerList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task RadiusServerList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Radiusserverslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="RadiusServerList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task RadiusServerList_Validate(string fields, string filter, int? limit, int? skip, string sort, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
                await eventListener.AssertNotNull(nameof(sort),sort);
            }
        }

        /// <summary>
        /// This endpoint allows you to update RADIUS servers in your organization.
        /// ####
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "name": "{name_update}",
        /// "networkSourceIp": "{0.0.0.0}",
        /// "userLockoutAction": "REMOVE",
        /// "userPasswordExpirationAction": "MAINTAIN"
        /// }'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task RadiusServerPut(string id, JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverput>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/radiusservers/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.RadiusServerPut_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to update RADIUS servers in your organization.
        /// ####
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/radiusservers/{ServerID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "name": "{name_update}",
        /// "networkSourceIp": "{0.0.0.0}",
        /// "userLockoutAction": "REMOVE",
        /// "userPasswordExpirationAction": "MAINTAIN"
        /// }'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="body"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task RadiusServerPutViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverput>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/radiusservers/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/radiusservers/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/radiusservers/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.RadiusServerPut_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="RadiusServerPut" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task RadiusServerPut_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverput>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Radiusserverput.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="RadiusServerPut" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task RadiusServerPut_Validate(string id, JumpCloudApiSdkV1.Models.IBodyParameterRadiusServerPutRequestBody body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Return System Users in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters. This
        /// WILL NOT allow you to add a new system user.
        /// To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body
        /// of POST /api/search/* routes. The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.
        /// The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being
        /// an array of query expressions.
        /// This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions. If
        /// the `and` or `or` are not included the default behavior is to match ALL query expressions.
        /// The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields`
        /// to query on. If any `field` has a partial text match on the`searchTerm` the record will be returned.
        /// #### Sample Request
        /// Exact search for a list of system users in a department
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "filter" : [{"department" : "IT"}],
        /// "fields" : "email username sudo"
        /// }'
        /// ```
        /// Text search for system users with and email on a domain
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter" : {
        /// "searchTerm": "@jumpcloud.com",
        /// "fields": ["email"]
        /// },
        /// "fields" : "email username sudo"
        /// }'
        /// ```
        /// Combining `filter` and `searchFilter` to text search for system users with and email on a domain who are in a list of
        /// departments
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter": {
        /// "searchTerm": "@jumpcloud.com",
        /// "fields": ["email"]
        /// },
        /// "filter": {
        /// "or": [
        /// {"department" : "IT"},
        /// {"department" : "Sales"}
        /// ]
        /// },
        /// "fields" : "email username sudo"
        /// }'
        /// ```
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="body">Search</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SearchSystemUserCreate(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/search/systemusers"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SearchSystemUserCreate_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// Return System Users in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters. This
        /// WILL NOT allow you to add a new system user.
        /// To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body
        /// of POST /api/search/* routes. The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.
        /// The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being
        /// an array of query expressions.
        /// This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions. If
        /// the `and` or `or` are not included the default behavior is to match ALL query expressions.
        /// The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields`
        /// to query on. If any `field` has a partial text match on the`searchTerm` the record will be returned.
        /// #### Sample Request
        /// Exact search for a list of system users in a department
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "filter" : [{"department" : "IT"}],
        /// "fields" : "email username sudo"
        /// }'
        /// ```
        /// Text search for system users with and email on a domain
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter" : {
        /// "searchTerm": "@jumpcloud.com",
        /// "fields": ["email"]
        /// },
        /// "fields" : "email username sudo"
        /// }'
        /// ```
        /// Combining `filter` and `searchFilter` to text search for system users with and email on a domain who are in a list of
        /// departments
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter": {
        /// "searchTerm": "@jumpcloud.com",
        /// "fields": ["email"]
        /// },
        /// "filter": {
        /// "or": [
        /// {"department" : "IT"},
        /// {"department" : "Sales"}
        /// ]
        /// },
        /// "fields" : "email username sudo"
        /// }'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="body">Search</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SearchSystemUserCreateViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/search/systemusers$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/search/systemusers'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/search/systemusers"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SearchSystemUserCreate_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SearchSystemUserCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SearchSystemUserCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemuserslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SearchSystemUserCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="body">Search</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SearchSystemUserCreate_Validate(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>This endpoint will create a specific System User's Public SSH Key.</summary>
        /// <param name="id"></param>
        /// <param name="body">SSHKeyPost</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SshKeyCreate(string id, JumpCloudApiSdkV1.Models.ISshkeypost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(id)
                        + "/sshkeys"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SshKeyCreate_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>This endpoint will create a specific System User's Public SSH Key.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="body">SSHKeyPost</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SshKeyCreateViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.ISshkeypost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<id>[^/]+)/sshkeys$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{id}/sshkeys'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + id
                        + "/sshkeys"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SshKeyCreate_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SshKeyCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SshKeyCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Sshkeylist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.BadRequest:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onBadRequest(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.PathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SshKeyCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">SSHKeyPost</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SshKeyCreate_Validate(string id, JumpCloudApiSdkV1.Models.ISshkeypost body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>This endpoint will delete a specific System User's SSH Key.</summary>
        /// <param name="systemuserId"></param>
        /// <param name="id"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SshKeyDelete(string systemuserId, string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(systemuserId)
                        + "/sshkeys/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SshKeyDelete_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>This endpoint will delete a specific System User's SSH Key.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SshKeyDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<systemuser_id>[^/]+)/sshkeys/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{systemuser_id}/sshkeys/{id}'");
                }

                // replace URI parameters with values from identity
                var systemuserId = _match.Groups["systemuser_id"].Value;
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + systemuserId
                        + "/sshkeys/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SshKeyDelete_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SshKeyDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SshKeyDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.BadRequest:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onBadRequest(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.PathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SshKeyDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="systemuserId"></param>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SshKeyDelete_Validate(string systemuserId, string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(systemuserId),systemuserId);
                await eventListener.AssertNotNull(nameof(id),id);
            }
        }

        /// <summary>This endpoint will return a specific System User's public SSH key.</summary>
        /// <param name="id"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SshKeyList(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist[]>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(id)
                        + "/sshkeys"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SshKeyList_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>This endpoint will return a specific System User's public SSH key.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SshKeyListViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist[]>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<id>[^/]+)/sshkeys$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{id}/sshkeys'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + id
                        + "/sshkeys"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SshKeyList_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SshKeyList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SshKeyList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist[]>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => If( JumpCloudApiSdkV1.Runtime.Json.JsonArray.Parse(body.Result) as JumpCloudApiSdkV1.Runtime.Json.JsonArray, out var __y) ? new global::System.Func<JumpCloudApiSdkV1.Models.ISshkeylist[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__y, (__x)=>(JumpCloudApiSdkV1.Models.ISshkeylist) (JumpCloudApiSdkV1.Models.Sshkeylist.FromJson(__x) )) ))() : null));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.BadRequest:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onBadRequest(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.PathsSystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SshKeyList" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SshKeyList_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
            }
        }

        /// <summary>
        /// This endpoint allows you to delete a system. This command will cause the system to uninstall the JumpCloud agent from
        /// its self which can can take about a minute. If the system is not connected to JumpCloud the system record will simply
        /// be removed.
        /// #### Sample Request
        /// ```
        /// curl -X DELETE https://console.jumpcloud.com/api/systems/{SystemID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemDelete(string id, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != date)
                {
                    request.Headers.Add("Date",date);
                }
                if (null != authorization)
                {
                    request.Headers.Add("Authorization",authorization);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemDelete_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to delete a system. This command will cause the system to uninstall the JumpCloud agent from
        /// its self which can can take about a minute. If the system is not connected to JumpCloud the system record will simply
        /// be removed.
        /// #### Sample Request
        /// ```
        /// curl -X DELETE https://console.jumpcloud.com/api/systems/{SystemID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemDeleteViaIdentity(global::System.String viaIdentity, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systems/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systems/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != date)
                {
                    request.Headers.Add("Date",date);
                }
                if (null != authorization)
                {
                    request.Headers.Add("Authorization",authorization);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemDelete_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.JcSystem.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemDelete_Validate(string id, string date, string authorization, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(date),date);
                await eventListener.AssertNotNull(nameof(authorization),authorization);
            }
        }

        /// <summary>
        /// This endpoint returns an individual system.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemGet(string id, string fields, string filter, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems/"
                        + global::System.Uri.EscapeDataString(id)
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != date)
                {
                    request.Headers.Add("Date",date);
                }
                if (null != authorization)
                {
                    request.Headers.Add("Authorization",authorization);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemGet_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns an individual system.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systems/{SystemID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemGetViaIdentity(global::System.String viaIdentity, string fields, string filter, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systems/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systems/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems/"
                        + id
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != date)
                {
                    request.Headers.Add("Date",date);
                }
                if (null != authorization)
                {
                    request.Headers.Add("Authorization",authorization);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemGet_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.JcSystem.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemGet" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemGet_Validate(string id, string fields, string filter, string date, string authorization, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
                await eventListener.AssertNotNull(nameof(date),date);
                await eventListener.AssertNotNull(nameof(authorization),authorization);
            }
        }

        /// <summary>
        /// This endpoint returns all Systems.
        /// #### Sample Requests
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemList(string fields, int? limit, string search, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(search) ? global::System.String.Empty : "search=" + global::System.Uri.EscapeDataString(search))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns all Systems.
        /// #### Sample Requests
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemListViaIdentity(global::System.String viaIdentity, string fields, int? limit, string search, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systems$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systems'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(search) ? global::System.String.Empty : "search=" + global::System.Uri.EscapeDataString(search))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemList_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemList" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">Use space separated sort parameters to sort the collection.
        /// Default sort is ascending. Prefix with `-` to sort descending.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemList_Validate(string fields, int? limit, string search, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(search),search);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint allows you to update a system.
        /// #### Sample Request
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "displayName":"Name_Update",
        /// "allowSshPasswordAuthentication":"true",
        /// "allowSshRootLogin":"true",
        /// "allowMultiFactorAuthentication":"true",
        /// "allowPublicKeyAuthentication":"false"
        /// }'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="body">SystemPut</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemPut(string id, string date, string authorization, JumpCloudApiSdkV1.Models.ISystemput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != date)
                {
                    request.Headers.Add("Date",date);
                }
                if (null != authorization)
                {
                    request.Headers.Add("Authorization",authorization);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemPut_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to update a system.
        /// #### Sample Request
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "displayName":"Name_Update",
        /// "allowSshPasswordAuthentication":"true",
        /// "allowSshRootLogin":"true",
        /// "allowMultiFactorAuthentication":"true",
        /// "allowPublicKeyAuthentication":"false"
        /// }'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="body">SystemPut</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemPutViaIdentity(global::System.String viaIdentity, string date, string authorization, JumpCloudApiSdkV1.Models.ISystemput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systems/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systems/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systems/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // add headers parameters
                if (null != date)
                {
                    request.Headers.Add("Date",date);
                }
                if (null != authorization)
                {
                    request.Headers.Add("Authorization",authorization);
                }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemPut_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemPut" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemPut_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.JcSystem.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemPut" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="body">SystemPut</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemPut_Validate(string id, string date, string authorization, JumpCloudApiSdkV1.Models.ISystemput body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(date),date);
                await eventListener.AssertNotNull(nameof(authorization),authorization);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters. This WILL
        /// NOT allow you to add a new system.
        /// To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body
        /// of POST /api/search/* routes. The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.
        /// The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being
        /// an array of query expressions.
        /// This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions. If
        /// the `and` or `or` are not included the default behavior is to match ALL query expressions.
        /// The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields`
        /// to query on. If any `field` has a partial text match on the`searchTerm` the record will be returned.
        /// #### Sample Request
        /// Exact search for a list of hostnames
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "filter": {
        /// "or": [
        /// {"hostname" : "my-hostname"},
        /// {"hostname" : "other-hostname"}
        /// ]
        /// },
        /// "fields" : "os hostname displayName"
        /// }'
        /// ```
        /// Text search for a hostname or display name
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter": {
        /// "searchTerm": "my-host",
        /// "fields": ["hostname", "displayName"]
        /// },
        /// "fields": "os hostname displayName"
        /// }'
        /// ```
        /// Combining `filter` and `searchFilter` to search for names that match a given OS
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter": {
        /// "searchTerm": "my-host",
        /// "fields": ["hostname", "displayName"]
        /// },
        /// "filter": {
        /// "or": [
        /// {"os" : "Ubuntu"},
        /// {"os" : "Mac OS X"}
        /// ]
        /// },
        /// "fields": "os hostname displayName"
        /// }'
        /// ```
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="body">Search</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemSearch(string fields, int? limit, int? skip, string filter, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/search/systems"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemSearch_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters. This WILL
        /// NOT allow you to add a new system.
        /// To support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body
        /// of POST /api/search/* routes. The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.
        /// The `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being
        /// an array of query expressions.
        /// This allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions. If
        /// the `and` or `or` are not included the default behavior is to match ALL query expressions.
        /// The `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields`
        /// to query on. If any `field` has a partial text match on the`searchTerm` the record will be returned.
        /// #### Sample Request
        /// Exact search for a list of hostnames
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "filter": {
        /// "or": [
        /// {"hostname" : "my-hostname"},
        /// {"hostname" : "other-hostname"}
        /// ]
        /// },
        /// "fields" : "os hostname displayName"
        /// }'
        /// ```
        /// Text search for a hostname or display name
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter": {
        /// "searchTerm": "my-host",
        /// "fields": ["hostname", "displayName"]
        /// },
        /// "fields": "os hostname displayName"
        /// }'
        /// ```
        /// Combining `filter` and `searchFilter` to search for names that match a given OS
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/search/systems \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "searchFilter": {
        /// "searchTerm": "my-host",
        /// "fields": ["hostname", "displayName"]
        /// },
        /// "filter": {
        /// "or": [
        /// {"os" : "Ubuntu"},
        /// {"os" : "Mac OS X"}
        /// ]
        /// },
        /// "fields": "os hostname displayName"
        /// }'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="body">Search</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemSearchViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string filter, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/search/systems$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/search/systems'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/search/systems"
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemSearch_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemSearch" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemSearch_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemSearch" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="limit">The number of records to return at once. Limited to 100.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="body">Search</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemSearch_Validate(string fields, int? limit, int? skip, string filter, JumpCloudApiSdkV1.Models.ISearch body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// This endpoint allows you to create a new system user.
        /// #### Sample Request
        /// ```
        /// curl -X POST https://console.jumpcloud.com/api/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "username":"{username}",
        /// "email":"{email_address}",
        /// "firstname":"{Name}",
        /// "lastname":"{Name}"
        /// }'
        /// ```
        /// </summary>
        /// <param name="body">SystemUserPost</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserCreate(JumpCloudApiSdkV1.Models.ISystemuserputpost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserCreate_Call(request,onOk,onBadRequest,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemUserCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserCreate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemuserreturn.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.BadRequest:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onBadRequest(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemUserCreate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="body">SystemUserPost</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserCreate_Validate(JumpCloudApiSdkV1.Models.ISystemuserputpost body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// This endpoint allows you to delete a particular system user.
        /// #### Sample Request
        /// ```
        /// curl -X DELETE https://console.jumpcloud.com/api/systemusers/{UserID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserDelete(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserDelete_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to delete a particular system user.
        /// #### Sample Request
        /// ```
        /// curl -X DELETE https://console.jumpcloud.com/api/systemusers/{UserID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Delete, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserDelete_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemUserDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemuserreturn.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemUserDelete" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserDelete_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
            }
        }

        /// <summary>
        /// This endpoint returns a particular System User.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systemusers/{UserID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserGet(string id, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(id)
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserGet_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns a particular System User.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systemusers/{UserID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserGetViaIdentity(global::System.String viaIdentity, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + id
                        + "?"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserGet_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemUserGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemuserreturn.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemUserGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fields">Use a space seperated string of field parameters to include the data in the response. If omitted,
        /// the default list of fields will be returned.
        /// </param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserGet_Validate(string id, string fields, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint returns all systemusers.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">The comma separated fields used to sort the collection.
        /// Default sort is ascending, prefix with `-` to sort descending.
        /// </param>
        /// <param name="fields">The comma separated fields included in the returned records.
        /// If omitted the default list of fields will be returned.
        /// </param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserList(int? limit, int? skip, string sort, string fields, string search, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers"
                        + "?"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(search) ? global::System.String.Empty : "search=" + global::System.Uri.EscapeDataString(search))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserList_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint returns all systemusers.
        /// #### Sample Request
        /// ```
        /// curl -X GET https://console.jumpcloud.com/api/systemusers \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">The comma separated fields used to sort the collection.
        /// Default sort is ascending, prefix with `-` to sort descending.
        /// </param>
        /// <param name="fields">The comma separated fields included in the returned records.
        /// If omitted the default list of fields will be returned.
        /// </param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserListViaIdentity(global::System.String viaIdentity, int? limit, int? skip, string sort, string fields, string search, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers"
                        + "?"
                        + (null == limit ? global::System.String.Empty : "limit=" + global::System.Uri.EscapeDataString(limit.ToString()))
                        + "&"
                        + (null == skip ? global::System.String.Empty : "skip=" + global::System.Uri.EscapeDataString(skip.ToString()))
                        + "&"
                        + (string.IsNullOrEmpty(sort) ? global::System.String.Empty : "sort=" + global::System.Uri.EscapeDataString(sort))
                        + "&"
                        + (string.IsNullOrEmpty(fields) ? global::System.String.Empty : "fields=" + global::System.Uri.EscapeDataString(fields))
                        + "&"
                        + (string.IsNullOrEmpty(search) ? global::System.String.Empty : "search=" + global::System.Uri.EscapeDataString(search))
                        + "&"
                        + (string.IsNullOrEmpty(filter) ? global::System.String.Empty : "filter=" + global::System.Uri.EscapeDataString(filter))
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Get, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserList_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemUserList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemuserslist.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemUserList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="limit">The number of records to return at once.</param>
        /// <param name="skip">The offset into the records to return.</param>
        /// <param name="sort">The comma separated fields used to sort the collection.
        /// Default sort is ascending, prefix with `-` to sort descending.
        /// </param>
        /// <param name="fields">The comma separated fields included in the returned records.
        /// If omitted the default list of fields will be returned.
        /// </param>
        /// <param name="search">A nested object containing a string `searchTerm` and a list of `fields` to search on.</param>
        /// <param name="filter">A filter to apply to the query.</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserList_Validate(int? limit, int? skip, string sort, string fields, string search, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(search),search);
                await eventListener.AssertNotNull(nameof(filter),filter);
            }
        }

        /// <summary>
        /// This endpoint allows you to reset the MFA TOTP token for a specified system user and put them in an MFA enrollment period.
        /// This will result in the user being prompted to setup MFA when logging into userportal. Please be aware that if the user
        /// does not complete MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require MFA.
        /// Please refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud)
        /// on setting up MFA for more information.
        /// #### Sample Request
        /// ```
        /// curl -X POST \
        /// https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{"exclusion": true, "exclusionUntil": "{date-time}"}'
        ///
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="onForbidden">a delegate that is called when the remote service returns 403 (Forbidden).</param>
        /// <param name="onNotFound">a delegate that is called when the remote service returns 404 (NotFound).</param>
        /// <param name="onConflict">a delegate that is called when the remote service returns 409 (Conflict).</param>
        /// <param name="onInternalServerError">a delegate that is called when the remote service returns 500 (InternalServerError).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserMfaReset(string id, JumpCloudApiSdkV1.Models.IBodyParameterSystemUserMfaResetRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(id)
                        + "/resetmfa"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserMfaReset_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to reset the MFA TOTP token for a specified system user and put them in an MFA enrollment period.
        /// This will result in the user being prompted to setup MFA when logging into userportal. Please be aware that if the user
        /// does not complete MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require MFA.
        /// Please refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud)
        /// on setting up MFA for more information.
        /// #### Sample Request
        /// ```
        /// curl -X POST \
        /// https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{"exclusion": true, "exclusionUntil": "{date-time}"}'
        ///
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="body"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="onForbidden">a delegate that is called when the remote service returns 403 (Forbidden).</param>
        /// <param name="onNotFound">a delegate that is called when the remote service returns 404 (NotFound).</param>
        /// <param name="onConflict">a delegate that is called when the remote service returns 409 (Conflict).</param>
        /// <param name="onInternalServerError">a delegate that is called when the remote service returns 500 (InternalServerError).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserMfaResetViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.IBodyParameterSystemUserMfaResetRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<id>[^/]+)/resetmfa$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{id}/resetmfa'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + id
                        + "/resetmfa"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserMfaReset_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemUserMfaReset" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="onForbidden">a delegate that is called when the remote service returns 403 (Forbidden).</param>
        /// <param name="onNotFound">a delegate that is called when the remote service returns 404 (NotFound).</param>
        /// <param name="onConflict">a delegate that is called when the remote service returns 409 (Conflict).</param>
        /// <param name="onInternalServerError">a delegate that is called when the remote service returns 500 (InternalServerError).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserMfaReset_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.BadRequest:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onBadRequest(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Forbidden:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onForbidden(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NotFound:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNotFound(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Conflict:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onConflict(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.InternalServerError:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onInternalServerError(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemUserMfaReset" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserMfaReset_Validate(string id, JumpCloudApiSdkV1.Models.IBodyParameterSystemUserMfaResetRequestBody body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>
        /// This endpoint allows you to update a system user.
        /// #### Sample Request
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "email":"{email_address}",
        /// "firstname":"{Name}",
        /// "lastname":"{Name}"
        /// }'
        /// ```
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">SystemUserPut</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserPut(string id, JumpCloudApiSdkV1.Models.ISystemuserput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(id)

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserPut_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>
        /// This endpoint allows you to update a system user.
        /// #### Sample Request
        /// ```
        /// curl -X PUT https://console.jumpcloud.com/api/systemusers/{UserID} \
        /// -H 'Accept: application/json' \
        /// -H 'Content-Type: application/json' \
        /// -H 'x-api-key: {API_KEY}' \
        /// -d '{
        /// "email":"{email_address}",
        /// "firstname":"{Name}",
        /// "lastname":"{Name}"
        /// }'
        /// ```
        /// </summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="body">SystemUserPut</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserPutViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.ISystemuserput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<id>[^/]+)$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{id}'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + id

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Put, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserPut_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemUserPut" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserPut_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Systemuserreturn.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response);
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemUserPut" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">SystemUserPut</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserPut_Validate(string id, JumpCloudApiSdkV1.Models.ISystemuserput body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>This endpoint allows you to unlock a user's account.</summary>
        /// <param name="id"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="onForbidden">a delegate that is called when the remote service returns 403 (Forbidden).</param>
        /// <param name="onNotFound">a delegate that is called when the remote service returns 404 (NotFound).</param>
        /// <param name="onConflict">a delegate that is called when the remote service returns 409 (Conflict).</param>
        /// <param name="onInternalServerError">a delegate that is called when the remote service returns 500 (InternalServerError).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserUnlock(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + global::System.Uri.EscapeDataString(id)
                        + "/unlock"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserUnlock_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
            }
        }

        /// <summary>This endpoint allows you to unlock a user's account.</summary>
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="onForbidden">a delegate that is called when the remote service returns 403 (Forbidden).</param>
        /// <param name="onNotFound">a delegate that is called when the remote service returns 404 (NotFound).</param>
        /// <param name="onConflict">a delegate that is called when the remote service returns 409 (Conflict).</param>
        /// <param name="onInternalServerError">a delegate that is called when the remote service returns 500 (InternalServerError).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SystemUserUnlockViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/systemusers/(?<id>[^/]+)/unlock$").Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/systemusers/{id}/unlock'");
                }

                // replace URI parameters with values from identity
                var id = _match.Groups["id"].Value;
                // construct URL
                var _url = new global::System.Uri(global::System.Text.RegularExpressions.Regex.Replace(
                        "https://console.jumpcloud.com/api/systemusers/"
                        + id
                        + "/unlock"

                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2"));

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(JumpCloudApiSdkV1.Runtime.Method.Post, _url);
                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SystemUserUnlock_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SystemUserUnlock" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="onForbidden">a delegate that is called when the remote service returns 403 (Forbidden).</param>
        /// <param name="onNotFound">a delegate that is called when the remote service returns 404 (NotFound).</param>
        /// <param name="onConflict">a delegate that is called when the remote service returns 409 (Conflict).</param>
        /// <param name="onInternalServerError">a delegate that is called when the remote service returns 500 (InternalServerError).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserUnlock_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.BadRequest:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onBadRequest(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Unauthorized:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onUnauthorized(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Forbidden:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onForbidden(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NotFound:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNotFound(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.Conflict:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onConflict(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        case global::System.Net.HttpStatusCode.InternalServerError:
                        {
                            await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onInternalServerError(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => JumpCloudApiSdkV1.Models.Errorresponse.FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            throw new JumpCloudApiSdkV1.Runtime.UndeclaredResponseException(_response);
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(JumpCloudApiSdkV1.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SystemUserUnlock" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SystemUserUnlock_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
            }
        }
    }
}