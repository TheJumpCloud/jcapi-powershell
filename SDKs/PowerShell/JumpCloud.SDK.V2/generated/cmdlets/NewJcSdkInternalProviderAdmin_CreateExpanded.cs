// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Cmdlets
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>
    /// This endpoint allows you to create a provider administrator. You must be associated with the provider to use this route.\n\n####
    /// Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n -H 'Accept:
    /// application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n \"email\":\"{ADMIN_EMAIL}\"\n
    /// }'\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Create-ProviderAdmin=>POST:"/providers/{provider_id}/administrators"
    /// [METADATA]
    /// path: '/providers/{provider_id}/administrators'
    /// apiVersions:
    /// - '2.0'
    /// filename:
    /// - 'mem:///109?oai3.shaken.json'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/SwaggerSpecs/JumpCloud.SDK.V2.json#/paths/~1providers~1{provider_id}~1administrators'
    /// [DETAILS]
    /// verb: New
    /// subjectPrefix:
    /// subject: ProviderAdmin
    /// variant: CreateExpanded
    /// </remarks>
    [global::JumpCloud.SDK.V2.InternalExport]
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.New, @"JcSdkInternalProviderAdmin_CreateExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(JumpCloud.SDK.V2.Models.IAdministrator), typeof(string))]
    [global::JumpCloud.SDK.V2.Description(@"This endpoint allows you to create a provider administrator. You must be associated with the provider to use this route.\n\n#### Sample Request\n```\ncurl -X POST https://console.jumpcloud.com/api/v2/providers/{ProviderID}/administrators \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n    \""email\"":\""{ADMIN_EMAIL}\""\n  }'\n```")]
    [global::JumpCloud.SDK.V2.Generated]
    public partial class NewJcSdkInternalProviderAdmin_CreateExpanded : global::System.Management.Automation.PSCmdlet,
        JumpCloud.SDK.V2.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IProviderAdminReq _body= new JumpCloud.SDK.V2.Models.ProviderAdminReq();

        /// <summary>ProviderAdminReq</summary>
        private JumpCloud.SDK.V2.Models.IProviderAdminReq Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloud.SDK.V2.JumpCloudApIs Client => JumpCloud.SDK.V2.Module.Instance.ClientAPI;

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = ".")]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Body)]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        public string Email { get => Body.Email ?? null; set => Body.Email = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Body)]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"enableMultiFactor",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableMultiFactor { get => Body.EnableMultiFactor ?? default(global::System.Management.Automation.SwitchParameter); set => Body.EnableMultiFactor = value; }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Body)]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        public string Firstname { get => Body.Firstname ?? null; set => Body.Firstname = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V2.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V2.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = ".")]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Body)]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @".",
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        public string Lastname { get => Body.Lastname ?? null; set => Body.Lastname = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloud.SDK.V2.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloud.SDK.V2.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="JumpCloud.SDK.V2.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private JumpCloud.SDK.V2.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Backing field for <see cref="ProviderId" /> property.</summary>
        private string _providerId;

        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = ".")]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"provider_id",
        PossibleTypes = new [] { typeof(string) })]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Path)]
        public string ProviderId { get => this._providerId; set => this._providerId = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::JumpCloud.SDK.V2.Category(global::JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IAdministrator" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IAdministrator> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnUnauthorized</c> will be called before the regular onUnauthorized has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IPaths11UphleProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema"
        /// /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onUnauthorized method should be processed, or if the method
        /// should return immediately (set to true to skip further processing )</param>

        partial void overrideOnUnauthorized(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IPaths11UphleProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                JumpCloud.SDK.V2.Runtime.AttachDebugger.Break();
            }
            ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletEndProcessing).Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task JumpCloud.SDK.V2.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<JumpCloud.SDK.V2.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case JumpCloud.SDK.V2.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloud.SDK.V2.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloud.SDK.V2.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case JumpCloud.SDK.V2.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloud.SDK.V2.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="NewJcSdkInternalProviderAdmin_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewJcSdkInternalProviderAdmin_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CreateProviderAdmin' operation"))
                {
                    using( var asyncCommandRuntime = new JumpCloud.SDK.V2.Runtime.PowerShell.AsyncCommandRuntime(this, ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletGetPipeline); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = JumpCloud.SDK.V2.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as JumpCloud.SDK.V2.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as JumpCloud.SDK.V2.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletBeforeAPICall); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.CreateProviderAdmin(ProviderId, Body, onOk, onUnauthorized, this, Pipeline);
                    await ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloud.SDK.V2.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  ProviderId=ProviderId,body=Body})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IAdministrator" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IAdministrator> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be JumpCloud.SDK.V2.Models.IAdministrator
                WriteObject((await response));
            }
        }

        /// <summary>a delegate that is called when the remote service returns 401 (Unauthorized).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IPaths11UphleProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onUnauthorized(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IPaths11UphleProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnUnauthorized(responseMessage, response, ref _returnNow);
                // if overrideOnUnauthorized has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onUnauthorized - response for 401 / application/json
                // (await response) // should be JumpCloud.SDK.V2.Models.IPaths11UphleProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema
                WriteObject((await response).Message);
            }
        }
    }
}