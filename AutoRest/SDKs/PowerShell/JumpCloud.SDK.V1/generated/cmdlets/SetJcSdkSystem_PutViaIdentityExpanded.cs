namespace JumpCloud.SDK.V1.Cmdlets
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>
    /// This endpoint allows you to update a system.\n\n#### Sample Request \n```\ncurl -X PUT https://console.jumpcloud.com/api/systems/{SystemID}
    /// \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n\t\"displayName\":\"Name_Update\",\n\t\"allowSshPasswordAuthentication\":\"true\",\n\t\"allowSshRootLogin\":\"true\",\n\t\"allowMultiFactorAuthentication\":\"true\",\n\t\"allowPublicKeyAuthentication\":\"false\"\n}'\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] System_Put=>PUT:"/systems/{id}"
    /// [METADATA]
    /// path: '/systems/{id}'
    /// apiVersions:
    /// - '1.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V1.json#/paths/~1systems~1{id}'
    /// [DETAILS]
    /// verb: Set
    /// subjectPrefix:
    /// subject: System
    /// variant: PutViaIdentityExpanded
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Set, @"JcSdkSystem_PutViaIdentityExpanded", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(JumpCloud.SDK.V1.Models.IJcSystem))]
    [JumpCloud.SDK.V1.Description(@"This endpoint allows you to update a system.\n\n#### Sample Request \n```\ncurl -X PUT https://console.jumpcloud.com/api/systems/{SystemID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\""displayName\"":\""Name_Update\"",\n\t\""allowSshPasswordAuthentication\"":\""true\"",\n\t\""allowSshRootLogin\"":\""true\"",\n\t\""allowMultiFactorAuthentication\"":\""true\"",\n\t\""allowPublicKeyAuthentication\"":\""false\""\n}'\n```")]
    [JumpCloud.SDK.V1.Generated]
    public partial class SetJcSdkSystem_PutViaIdentityExpanded : System.Management.Automation.PSCmdlet,
        JumpCloud.SDK.V1.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"agentBoundMessages",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem) })]
        public JumpCloud.SDK.V1.Models.ISystemputAgentBoundMessagesItem[] AgentBoundMessages { get => Body.AgentBoundMessages ?? null /* arrayOf */; set => Body.AgentBoundMessages = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"allowMultiFactorAuthentication",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AllowMultiFactorAuthentication { get => Body.AllowMultiFactorAuthentication ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AllowMultiFactorAuthentication = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"allowPublicKeyAuthentication",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AllowPublicKeyAuthentication { get => Body.AllowPublicKeyAuthentication ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AllowPublicKeyAuthentication = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"allowSshPasswordAuthentication",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AllowSshPasswordAuthentication { get => Body.AllowSshPasswordAuthentication ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AllowSshPasswordAuthentication = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"allowSshRootLogin",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AllowSshRootLogin { get => Body.AllowSshRootLogin ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AllowSshRootLogin = value; }

        /// <summary>Backing field for <see cref="Authorization" /> property.</summary>
        private string _authorization;

        /// <summary>Authorization header for the System Context API</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Authorization header for the System Context API")]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Authorization header for the System Context API",
        SerializedName = @"Authorization",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Header)]
        public string Authorization { get => this._authorization; set => this._authorization = value; }

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ISystemput _body= new JumpCloud.SDK.V1.Models.Systemput();

        /// <summary>SystemPut</summary>
        private JumpCloud.SDK.V1.Models.ISystemput Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloud.SDK.V1.JumpCloudApIs Client => JumpCloud.SDK.V1.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="Date" /> property.</summary>
        private string _date;

        /// <summary>Current date header for the System Context API</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Current date header for the System Context API")]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current date header for the System Context API",
        SerializedName = @"Date",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Header)]
        public string Date { get => this._date; set => this._date = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        public string DisplayName { get => Body.DisplayName ?? null; set => Body.DisplayName = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V1.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V1.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Path)]
        public JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloud.SDK.V1.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloud.SDK.V1.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="JumpCloud.SDK.V1.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private JumpCloud.SDK.V1.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Tags { get => Body.Tags ?? null /* arrayOf */; set => Body.Tags = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V1.Models.IJcSystem" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V1.Models.IJcSystem> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                JumpCloud.SDK.V1.Runtime.AttachDebugger.Break();
            }
            ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletEndProcessing).Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task JumpCloud.SDK.V1.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<JumpCloud.SDK.V1.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case JumpCloud.SDK.V1.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloud.SDK.V1.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloud.SDK.V1.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case JumpCloud.SDK.V1.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloud.SDK.V1.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'SystemPut' operation"))
                {
                    using( var asyncCommandRuntime = new JumpCloud.SDK.V1.Runtime.PowerShell.AsyncCommandRuntime(this, ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new System.Management.Automation.ErrorRecord(innerException,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)!= null && (exception as System.Management.Automation.PipelineStoppedException).InnerException == null)
            {
                ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                ThrowTerminatingError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            catch (global::System.Exception exception)
            {
                ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletGetPipeline); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = JumpCloud.SDK.V1.Module.Instance.CreatePipeline(InvocationInformation);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as JumpCloud.SDK.V1.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as JumpCloud.SDK.V1.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletBeforeAPICall); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // try to call with PATH parameters from Input Object
                    if (null == InputObject.Id)
                    {
                        ThrowTerminatingError( new System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.Id"),string.Empty, System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                    }
                    await this.Client.SystemPut(InputObject.Id ?? null, this.InvocationInformation.BoundParameters.ContainsKey("Date") ? Date : null, this.InvocationInformation.BoundParameters.ContainsKey("Authorization") ? Authorization : null, Body, onOk, this, Pipeline);
                    await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloud.SDK.V1.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  Date=this.InvocationInformation.BoundParameters.ContainsKey("Date") ? Date : null,Authorization=this.InvocationInformation.BoundParameters.ContainsKey("Authorization") ? Authorization : null,body=Body}));
                }
                finally
                {
                    await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="SetJcSdkSystem_PutViaIdentityExpanded" /> cmdlet class.
        /// </summary>
        public SetJcSdkSystem_PutViaIdentityExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V1.Models.IJcSystem" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V1.Models.IJcSystem> response)
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
                // (await response) // should be JumpCloud.SDK.V1.Models.IJcSystem
                WriteObject((await response));
            }
        }
    }
}