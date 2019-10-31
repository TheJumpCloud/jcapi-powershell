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
        public async global::System.Threading.Tasks.Task CreateApplication(string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.CreateApplication_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task CreateApplicationViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.CreateApplication_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CreateApplication" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateApplication_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="CreateApplication" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task CreateApplication_Validate(string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task CreateCommand(JumpCloudApiSdkV1.Models.ICommand body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.CreateCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CreateCommand" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateCommand_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="CreateCommand" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="body">Command</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateCommand_Validate(JumpCloudApiSdkV1.Models.ICommand body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
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
        public async global::System.Threading.Tasks.Task CreateRadiusServer(JumpCloudApiSdkV1.Models.IRadiusserverpost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserver>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.CreateRadiusServer_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CreateRadiusServer" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateRadiusServer_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserver>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="CreateRadiusServer" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="body">RadiusServerPost</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateRadiusServer_Validate(JumpCloudApiSdkV1.Models.IRadiusserverpost body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
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
        public async global::System.Threading.Tasks.Task CreateSshKey(string id, JumpCloudApiSdkV1.Models.ISshkeypost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.CreateSshKey_Call(request,onOk,onBadRequest,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task CreateSshKeyViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.ISshkeypost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.CreateSshKey_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CreateSshKey" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateSshKey_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysPostResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="CreateSshKey" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">SSHKeyPost</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateSshKey_Validate(string id, JumpCloudApiSdkV1.Models.ISshkeypost body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
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
        public async global::System.Threading.Tasks.Task CreateSystemUser(JumpCloudApiSdkV1.Models.ISystemuserputpost body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.CreateSystemUser_Call(request,onOk,onBadRequest,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="CreateSystemUser" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateSystemUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="CreateSystemUser" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="body">SystemUserPost</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task CreateSystemUser_Validate(JumpCloudApiSdkV1.Models.ISystemuserputpost body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
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
        public async global::System.Threading.Tasks.Task DeleteApplication(string id, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteApplication_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task DeleteApplicationViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteApplication_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="DeleteApplication" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteApplication_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="DeleteApplication" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task DeleteApplication_Validate(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task DeleteCommand(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task DeleteCommandResult(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteCommandResult_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task DeleteCommandResultViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteCommandResult_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="DeleteCommandResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteCommandResult_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="DeleteCommandResult" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteCommandResult_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
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
        public async global::System.Threading.Tasks.Task DeleteCommandViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="DeleteCommand" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteCommand_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="DeleteCommand" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteCommand_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
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
        public async global::System.Threading.Tasks.Task DeleteSshKey(string systemuserId, string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteSshKey_Call(request,onOk,onBadRequest,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task DeleteSshKeyViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteSshKey_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="DeleteSshKey" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteSshKey_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersSystemuserIdSshkeysIdDeleteResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="DeleteSshKey" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="systemuserId"></param>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteSshKey_Validate(string systemuserId, string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(systemuserId),systemuserId);
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
        public async global::System.Threading.Tasks.Task DeleteSystem(string id, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteSystem_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task DeleteSystemUser(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task DeleteSystemUserViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="DeleteSystemUser" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteSystemUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="DeleteSystemUser" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteSystemUser_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        /// <param name="viaIdentity">FIXME: Parameter viaIdentity is MISSING DESCRIPTION</param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task DeleteSystemViaIdentity(global::System.String viaIdentity, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.DeleteSystem_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="DeleteSystem" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteSystem_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="DeleteSystem" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date">Current date header for the System Context API</param>
        /// <param name="authorization">Authorization header for the System Context API</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task DeleteSystem_Validate(string id, string date, string authorization, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(date),date);
                await eventListener.AssertNotNull(nameof(authorization),authorization);
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
        public async global::System.Threading.Tasks.Task GetApplication(string id, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetApplication_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task GetApplicationTemplate(string id, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplate>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetApplicationTemplate_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task GetApplicationTemplateViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplate>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetApplicationTemplate_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GetApplicationTemplate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GetApplicationTemplate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplate>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="GetApplicationTemplate" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task GetApplicationTemplate_Validate(string id, string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
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
        public async global::System.Threading.Tasks.Task GetApplicationViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetApplication_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GetApplication" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GetApplication_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="GetApplication" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task GetApplication_Validate(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task GetCommand(string id, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task GetCommandFile(string id, string fields, int? limit, int? skip, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandfilereturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsFilesCommandIdGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetCommandFile_Call(request,onOk,onBadRequest,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task GetCommandFileViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandfilereturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsFilesCommandIdGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetCommandFile_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GetCommandFile" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GetCommandFile_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandfilereturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsFilesCommandIdGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="GetCommandFile" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task GetCommandFile_Validate(string id, string fields, int? limit, int? skip, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
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
        public async global::System.Threading.Tasks.Task GetCommandResult(string id, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetCommandResult_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task GetCommandResultViaIdentity(global::System.String viaIdentity, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetCommandResult_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GetCommandResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GetCommandResult_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="GetCommandResult" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task GetCommandResult_Validate(string id, string fields, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
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
        public async global::System.Threading.Tasks.Task GetCommandViaIdentity(global::System.String viaIdentity, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GetCommand" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GetCommand_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="GetCommand" /> method. Call this like the actual call, but you will get validation events
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
        internal async global::System.Threading.Tasks.Task GetCommand_Validate(string id, string fields, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
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
        public async global::System.Threading.Tasks.Task GetSystem(string id, string fields, string filter, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetSystem_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task GetSystemUser(string id, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task GetSystemUserViaIdentity(global::System.String viaIdentity, string fields, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GetSystemUser" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GetSystemUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="GetSystemUser" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task GetSystemUser_Validate(string id, string fields, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
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
        public async global::System.Threading.Tasks.Task GetSystemViaIdentity(global::System.String viaIdentity, string fields, string filter, string date, string authorization, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.GetSystem_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="GetSystem" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task GetSystem_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="GetSystem" /> method. Call this like the actual call, but you will get validation events
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
        internal async global::System.Threading.Tasks.Task GetSystem_Validate(string id, string fields, string filter, string date, string authorization, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task ListApplication(string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListApplication_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListApplicationTemplate(string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplateslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListApplicationTemplate_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListApplicationTemplateViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplateslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListApplicationTemplate_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListApplicationTemplate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListApplicationTemplate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationtemplateslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListApplicationTemplate" /> method. Call this like the actual call, but you will get
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
        internal async global::System.Threading.Tasks.Task ListApplicationTemplate_Validate(string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
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
        public async global::System.Threading.Tasks.Task ListApplicationViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListApplication_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListApplication" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListApplication_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplicationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListApplication" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task ListApplication_Validate(string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
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
        public async global::System.Threading.Tasks.Task ListCommand(int? skip, string fields, int? limit, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListCommandResult(string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresultslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListCommandResult_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListCommandResultViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresultslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListCommandResult_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListCommandResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListCommandResult_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandresultslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListCommandResult" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task ListCommandResult_Validate(string fields, int? limit, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
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
        public async global::System.Threading.Tasks.Task ListCommandViaIdentity(global::System.String viaIdentity, int? skip, string fields, int? limit, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListCommand" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListCommand_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommandslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListCommand" /> method. Call this like the actual call, but you will get validation events
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
        internal async global::System.Threading.Tasks.Task ListCommand_Validate(int? skip, string fields, int? limit, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(sort),sort);
                await eventListener.AssertNotNull(nameof(filter),filter);
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
        public async global::System.Threading.Tasks.Task ListOrganization(string fields, string filter, int? limit, int? skip, string sort, string search, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListOrganization_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListOrganizationViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, string sort, string search, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListOrganization_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListOrganization" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListOrganization_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListOrganization" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task ListOrganization_Validate(string fields, string filter, int? limit, int? skip, string sort, string search, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task ListRadiusServer(string fields, string filter, int? limit, int? skip, string sort, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListRadiusServer_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListRadiusServerViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, string sort, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListRadiusServer_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListRadiusServer" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListRadiusServer_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListRadiusServer" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task ListRadiusServer_Validate(string fields, string filter, int? limit, int? skip, string sort, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(filter),filter);
                await eventListener.AssertNotNull(nameof(sort),sort);
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
        public async global::System.Threading.Tasks.Task ListSshKey(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist[]>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListSshKey_Call(request,onOk,onBadRequest,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListSshKeyViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist[]>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListSshKey_Call(request,onOk,onBadRequest,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListSshKey" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onBadRequest">a delegate that is called when the remote service returns 400 (BadRequest).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListSshKey_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISshkeylist[]>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IPathsSystemusersIdSshkeysGetResponses400ContentApplicationJsonSchema>, global::System.Threading.Tasks.Task> onBadRequest, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListSshKey" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListSshKey_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
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
        public async global::System.Threading.Tasks.Task ListSystem(string fields, int? limit, string search, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListSystem_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListSystemUser(int? limit, int? skip, string sort, string fields, string search, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ListSystemUserViaIdentity(global::System.String viaIdentity, int? limit, int? skip, string sort, string fields, string search, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListSystemUser" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListSystemUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListSystemUser" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task ListSystemUser_Validate(int? limit, int? skip, string sort, string fields, string search, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task ListSystemViaIdentity(global::System.String viaIdentity, string fields, int? limit, string search, int? skip, string sort, string filter, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ListSystem_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ListSystem" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ListSystem_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ListSystem" /> method. Call this like the actual call, but you will get validation events
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
        internal async global::System.Threading.Tasks.Task ListSystem_Validate(string fields, int? limit, string search, int? skip, string sort, string filter, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(fields),fields);
                await eventListener.AssertNotNull(nameof(search),search);
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
        public async global::System.Threading.Tasks.Task PutApplication(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutApplication_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task PutApplicationViaIdentity(global::System.String viaIdentity, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutApplication_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="PutApplication" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutApplication_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="PutApplication" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task PutApplication_Validate(string id, string contentType, string accept, string xOrgId, JumpCloudApiSdkV1.Models.IApplication body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task PutCommand(string id, JumpCloudApiSdkV1.Models.ICommand body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task PutCommandViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.ICommand body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutCommand_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="PutCommand" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutCommand_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="PutCommand" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">Command</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutCommand_Validate(string id, JumpCloudApiSdkV1.Models.ICommand body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
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
        public async global::System.Threading.Tasks.Task PutRadiusServer(string id, JumpCloudApiSdkV1.Models.IBodyParameterPutRadiusServerRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverput>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutRadiusServer_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task PutRadiusServerViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.IBodyParameterPutRadiusServerRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverput>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutRadiusServer_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="PutRadiusServer" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutRadiusServer_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IRadiusserverput>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="PutRadiusServer" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutRadiusServer_Validate(string id, JumpCloudApiSdkV1.Models.IBodyParameterPutRadiusServerRequestBody body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
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
        public async global::System.Threading.Tasks.Task PutSystem(string id, string date, string authorization, JumpCloudApiSdkV1.Models.ISystemput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutSystem_Call(request,onOk,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task PutSystemUser(string id, JumpCloudApiSdkV1.Models.ISystemuserput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task PutSystemUserViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.ISystemuserput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="PutSystemUser" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutSystemUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserreturn>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="PutSystemUser" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body">SystemUserPut</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutSystemUser_Validate(string id, JumpCloudApiSdkV1.Models.ISystemuserput body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
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
        public async global::System.Threading.Tasks.Task PutSystemViaIdentity(global::System.String viaIdentity, string date, string authorization, JumpCloudApiSdkV1.Models.ISystemput body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.PutSystem_Call(request,onOk,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="PutSystem" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PutSystem_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IJcSystem>, global::System.Threading.Tasks.Task> onOk, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="PutSystem" /> method. Call this like the actual call, but you will get validation events
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
        internal async global::System.Threading.Tasks.Task PutSystem_Validate(string id, string date, string authorization, JumpCloudApiSdkV1.Models.ISystemput body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task ResetSystemUserMfa(string id, JumpCloudApiSdkV1.Models.IBodyParameterResetSystemUserMfaRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ResetSystemUserMfa_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task ResetSystemUserMfaViaIdentity(global::System.String viaIdentity, JumpCloudApiSdkV1.Models.IBodyParameterResetSystemUserMfaRequestBody body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.ResetSystemUserMfa_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="ResetSystemUserMfa" /> method.</summary>
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
        internal async global::System.Threading.Tasks.Task ResetSystemUserMfa_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="ResetSystemUserMfa" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ResetSystemUserMfa_Validate(string id, JumpCloudApiSdkV1.Models.IBodyParameterResetSystemUserMfaRequestBody body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task SearchCreateSystemUser(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.SearchCreateSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task SearchCreateSystemUserViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.SearchCreateSystemUser_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SearchCreateSystemUser" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SearchCreateSystemUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="SearchCreateSystemUser" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task SearchCreateSystemUser_Validate(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task SearchOrganization(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.SearchOrganization_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task SearchOrganizationViaIdentity(global::System.String viaIdentity, string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.SearchOrganization_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SearchOrganization" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SearchOrganization_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IOrganizationslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="SearchOrganization" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task SearchOrganization_Validate(string fields, string filter, int? limit, int? skip, JumpCloudApiSdkV1.Models.ISearch body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task SearchSystem(string fields, int? limit, int? skip, string filter, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.SearchSystem_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task SearchSystemViaIdentity(global::System.String viaIdentity, string fields, int? limit, int? skip, string filter, JumpCloudApiSdkV1.Models.ISearch body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.SearchSystem_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="SearchSystem" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SearchSystem_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemslist>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="SearchSystem" /> method. Call this like the actual call, but you will get validation
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
        internal async global::System.Threading.Tasks.Task SearchSystem_Validate(string fields, int? limit, int? skip, string filter, JumpCloudApiSdkV1.Models.ISearch body, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
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
        public async global::System.Threading.Tasks.Task StartCommandTriggerWebhook(string triggername, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.StartCommandTriggerWebhook_Call(request,onOk,onUnauthorized,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task StartCommandTriggerWebhookViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.StartCommandTriggerWebhook_Call(request,onOk,onUnauthorized,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="StartCommandTriggerWebhook" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onUnauthorized">a delegate that is called when the remote service returns 401 (Unauthorized).</param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an JumpCloudApiSdkV1.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task StartCommandTriggerWebhook_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onUnauthorized, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="StartCommandTriggerWebhook" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="triggername"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task StartCommandTriggerWebhook_Validate(string triggername, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(triggername),triggername);
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
        public async global::System.Threading.Tasks.Task UnlockSystemUser(string id, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.UnlockSystemUser_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
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
        public async global::System.Threading.Tasks.Task UnlockSystemUserViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
                await this.UnlockSystemUser_Call(request,onOk,onBadRequest,onUnauthorized,onForbidden,onNotFound,onConflict,onInternalServerError,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref="UnlockSystemUser" /> method.</summary>
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
        internal async global::System.Threading.Tasks.Task UnlockSystemUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onBadRequest, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onUnauthorized, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onForbidden, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onNotFound, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onConflict, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse>, global::System.Threading.Tasks.Task> onInternalServerError, JumpCloudApiSdkV1.Runtime.IEventListener eventListener, JumpCloudApiSdkV1.Runtime.ISendAsync sender)
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
        /// Validation method for <see cref="UnlockSystemUser" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV1.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task UnlockSystemUser_Validate(string id, JumpCloudApiSdkV1.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(id),id);
            }
        }
    }
}