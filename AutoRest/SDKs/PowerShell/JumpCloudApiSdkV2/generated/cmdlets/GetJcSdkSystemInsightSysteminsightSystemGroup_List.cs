namespace JumpCloudApiSdkV2.Cmdlets
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Valid filter fields are `bundle_name`.</summary>
    /// <remarks>
    /// [OpenAPI] List-SysteminsightsSystemGroups=>GET:"/systeminsights/{system_id}/apps"
    /// [METADATA]
    /// path: '/systeminsights/{system_id}/apps'
    /// apiVersions:
    /// - '2.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V2.json#/paths/~1systeminsights~1{system_id}~1apps'
    /// [DETAILS]
    /// verb: Get
    /// subjectPrefix:
    /// subject: SystemInsightSysteminsightSystemGroup
    /// variant: List
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Get, @"JcSdkSystemInsightSysteminsightSystemGroup_List")]
    [System.Management.Automation.OutputType(typeof(JumpCloudApiSdkV2.Models.ISystemInsightsApps))]
    [JumpCloudApiSdkV2.Description(@"Valid filter fields are `bundle_name`.")]
    [JumpCloudApiSdkV2.Generated]
    public partial class GetJcSdkSystemInsightSysteminsightSystemGroup_List : System.Management.Automation.PSCmdlet,
        JumpCloudApiSdkV2.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloudApiSdkV2.JumpCloudApIs Client => JumpCloudApiSdkV2.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private string[] _filter;

        /// <summary>Supported operators are: eq</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Supported operators are: eq")]
        [System.Management.Automation.AllowEmptyCollection]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Supported operators are: eq",
        SerializedName = @"filter",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Query)]
        public string[] Filter { get => this._filter; set => this._filter = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Runtime)]
        public JumpCloudApiSdkV2.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Runtime)]
        public JumpCloudApiSdkV2.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private int _limit;

        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(int) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Query)]
        public int Limit { get => this._limit; set => this._limit = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloudApiSdkV2.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloudApiSdkV2.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// The instance of the <see cref="JumpCloudApiSdkV2.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private JumpCloudApiSdkV2.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Runtime)]
        public System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="Skip" /> property.</summary>
        private int _skip;

        /// <summary>The offset into the records to return.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The offset into the records to return.")]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offset into the records to return.",
        SerializedName = @"skip",
        PossibleTypes = new [] { typeof(int) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Query)]
        public int Skip { get => this._skip; set => this._skip = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Path)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsApps[]" /> from the remote
        /// call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV2.Models.ISystemInsightsApps[]> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                JumpCloudApiSdkV2.Runtime.AttachDebugger.Break();
            }
            ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletEndProcessing).Wait(); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="GetJcSdkSystemInsightSysteminsightSystemGroup_List" /> cmdlet class.
        /// </summary>
        public GetJcSdkSystemInsightSysteminsightSystemGroup_List()
        {

        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task JumpCloudApiSdkV2.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<JumpCloudApiSdkV2.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case JumpCloudApiSdkV2.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloudApiSdkV2.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloudApiSdkV2.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case JumpCloudApiSdkV2.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case JumpCloudApiSdkV2.Runtime.Events.Error:
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
            ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                using( var asyncCommandRuntime = new JumpCloudApiSdkV2.Runtime.PowerShell.AsyncCommandRuntime(this, ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token);
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new System.Management.Automation.ErrorRecord(innerException,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)!= null && (exception as System.Management.Automation.PipelineStoppedException).InnerException == null)
            {
                ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                ThrowTerminatingError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            catch (global::System.Exception exception)
            {
                ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletProcessRecordEnd).Wait();
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
                await ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletGetPipeline); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = JumpCloudApiSdkV2.Module.Instance.CreatePipeline(InvocationInformation);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as JumpCloudApiSdkV2.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as JumpCloudApiSdkV2.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletBeforeAPICall); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.ListSysteminsightsSystemGroups(SystemId, this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null /* arrayOf */, onOk, this, Pipeline);
                    await ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloudApiSdkV2.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  SystemId=SystemId,Limit=this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?),Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?),Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null /* arrayOf */}));
                }
                finally
                {
                    await ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsApps[]" /> from the remote
        /// call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV2.Models.ISystemInsightsApps[]> response)
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
                // response should be returning an array of some kind. +Pageable
                // array / <none> / <none>
                WriteObject(await response, true);
            }
        }
    }
}