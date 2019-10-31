namespace JumpCloudApiSdkV1.Cmdlets
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>The endpoint updates a SSO / SAML Application.</summary>
    /// <remarks>
    /// [OpenAPI] Put-Application=>PUT:"/applications/{id}"
    /// [METADATA]
    /// path: '/applications/{id}'
    /// apiVersions:
    /// - '1.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V1.json#/paths/~1applications~1{id}'
    /// [DETAILS]
    /// verb: Set
    /// subjectPrefix:
    /// subject: Application
    /// variant: PutViaIdentityExpanded
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Set, @"JcSdkApplication_PutViaIdentityExpanded", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(JumpCloudApiSdkV1.Models.IApplication))]
    [JumpCloudApiSdkV1.Description(@"The endpoint updates a SSO / SAML Application.")]
    [JumpCloudApiSdkV1.Generated]
    public partial class SetJcSdkApplication_PutViaIdentityExpanded : System.Management.Automation.PSCmdlet,
        JumpCloudApiSdkV1.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="Accept" /> property.</summary>
        private string _accept;

        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Accept",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Header)]
        public string Accept { get => this._accept; set => this._accept = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter Active { get => Body.Active ?? default(global::System.Management.Automation.SwitchParameter); set => Body.Active = value; }

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplication _body= new JumpCloudApiSdkV1.Models.Application();

        /// <summary>Application</summary>
        private JumpCloudApiSdkV1.Models.IApplication Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloudApiSdkV1.JumpCloudApIs Client => JumpCloudApiSdkV1.Module.Instance.ClientAPI;

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"config",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IApplicationConfig) })]
        public JumpCloudApiSdkV1.Models.IApplicationConfig Config { get => Body.Config ?? null /* object */; set => Body.Config = value; }

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Content-Type",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Header)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"displayLabel",
        PossibleTypes = new [] { typeof(string) })]
        public string DisplayLabel { get => Body.DisplayLabel ?? null; set => Body.DisplayLabel = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        public string DisplayName { get => Body.DisplayName ?? null; set => Body.DisplayName = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public JumpCloudApiSdkV1.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public JumpCloudApiSdkV1.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        public string Id { get => Body.Id ?? null; set => Body.Id = value; }

        /// <summary>Backing field for <see cref="InputObject" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity _inputObject;

        /// <summary>Identity Parameter</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Path)]
        public JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity InputObject { get => this._inputObject; set => this._inputObject = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"learnMore",
        PossibleTypes = new [] { typeof(string) })]
        public string LearnMore { get => Body.LearnMore ?? null; set => Body.LearnMore = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloudApiSdkV1.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloudApiSdkV1.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string Name { get => Body.Name ?? null; set => Body.Name = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        public string Organization { get => Body.Organization ?? null; set => Body.Organization = value; }

        /// <summary>
        /// The instance of the <see cref="JumpCloudApiSdkV1.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private JumpCloudApiSdkV1.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"ssoUrl",
        PossibleTypes = new [] { typeof(string) })]
        public string SsoUrl { get => Body.SsoUrl ?? null; set => Body.SsoUrl = value; }

        /// <summary>Backing field for <see cref="XOrgId" /> property.</summary>
        private string _xOrgId;

        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"x-org-id",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Header)]
        public string XOrgId { get => this._xOrgId; set => this._xOrgId = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IApplication" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                JumpCloudApiSdkV1.Runtime.AttachDebugger.Break();
            }
            ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletEndProcessing).Wait(); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task JumpCloudApiSdkV1.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<JumpCloudApiSdkV1.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case JumpCloudApiSdkV1.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloudApiSdkV1.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloudApiSdkV1.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case JumpCloudApiSdkV1.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloudApiSdkV1.Runtime.Events.Error:
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
            ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'PutApplication' operation"))
                {
                    using( var asyncCommandRuntime = new JumpCloudApiSdkV1.Runtime.PowerShell.AsyncCommandRuntime(this, ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token);
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new System.Management.Automation.ErrorRecord(innerException,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)!= null && (exception as System.Management.Automation.PipelineStoppedException).InnerException == null)
            {
                ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                ThrowTerminatingError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            catch (global::System.Exception exception)
            {
                ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletGetPipeline); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = JumpCloudApiSdkV1.Module.Instance.CreatePipeline(InvocationInformation);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as JumpCloudApiSdkV1.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as JumpCloudApiSdkV1.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletBeforeAPICall); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // try to call with PATH parameters from Input Object
                    if (null == InputObject.Id)
                    {
                        ThrowTerminatingError( new System.Management.Automation.ErrorRecord(new global::System.Exception("InputObject has null value for InputObject.Id"),string.Empty, System.Management.Automation.ErrorCategory.InvalidArgument, InputObject) );
                    }
                    await this.Client.PutApplication(InputObject.Id ?? null, this.InvocationInformation.BoundParameters.ContainsKey("ContentType") ? ContentType : null, this.InvocationInformation.BoundParameters.ContainsKey("Accept") ? Accept : null, this.InvocationInformation.BoundParameters.ContainsKey("XOrgId") ? XOrgId : null, Body, onOk, this, Pipeline);
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloudApiSdkV1.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  ContentType=this.InvocationInformation.BoundParameters.ContainsKey("ContentType") ? ContentType : null,Accept=this.InvocationInformation.BoundParameters.ContainsKey("Accept") ? Accept : null,XOrgId=this.InvocationInformation.BoundParameters.ContainsKey("XOrgId") ? XOrgId : null,body=Body}));
                }
                finally
                {
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="SetJcSdkApplication_PutViaIdentityExpanded" /> cmdlet class.
        /// </summary>
        public SetJcSdkApplication_PutViaIdentityExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IApplication" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IApplication> response)
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
                // (await response) // should be JumpCloudApiSdkV1.Models.IApplication
                WriteObject((await response));
            }
        }
    }
}