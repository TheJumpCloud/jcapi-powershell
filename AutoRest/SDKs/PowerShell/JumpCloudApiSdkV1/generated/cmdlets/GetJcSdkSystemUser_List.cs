namespace JumpCloudApiSdkV1.Cmdlets
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>
    /// This endpoint returns all systemusers.\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/systemusers
    /// \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}'\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] SystemUser_List=>GET:"/systemusers"
    /// [METADATA]
    /// path: /systemusers
    /// apiVersions:
    /// - '1.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V1.json#/paths/~1systemusers'
    /// [DETAILS]
    /// verb: Get
    /// subjectPrefix:
    /// subject: SystemUser
    /// variant: List
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Get, @"JcSdkSystemUser_List")]
    [System.Management.Automation.OutputType(typeof(JumpCloudApiSdkV1.Models.ISystemuserslist))]
    [JumpCloudApiSdkV1.Description(@"This endpoint returns all systemusers.\n\n#### Sample Request\n\n```\ncurl -X GET https://console.jumpcloud.com/api/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```")]
    [JumpCloudApiSdkV1.Generated]
    public partial class GetJcSdkSystemUser_List : System.Management.Automation.PSCmdlet,
        JumpCloudApiSdkV1.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloudApiSdkV1.JumpCloudApIs Client => JumpCloudApiSdkV1.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private string _fields;

        /// <summary>
        /// The comma separated fields included in the returned records.
        /// If omitted the default list of fields will be returned.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The comma separated fields included in the returned records.\nIf omitted the default list of fields will be returned.\n")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The comma separated fields included in the returned records.
        If omitted the default list of fields will be returned.
        ",
        SerializedName = @"fields",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Query)]
        public string Fields { get => this._fields; set => this._fields = value; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private string _filter;

        /// <summary>A filter to apply to the query.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A filter to apply to the query.")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A filter to apply to the query.",
        SerializedName = @"filter",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Query)]
        public string Filter { get => this._filter; set => this._filter = value; }

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

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private int _limit;

        /// <summary>The number of records to return at once.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to return at once.")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of records to return at once.",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(int) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Query)]
        public int Limit { get => this._limit; set => this._limit = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloudApiSdkV1.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloudApiSdkV1.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter PassThru { get; set; }

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

        /// <summary>Backing field for <see cref="Search" /> property.</summary>
        private string _search;

        /// <summary>
        /// A nested object containing a string `searchTerm` and a list of `fields` to search on.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A nested object containing a string `searchTerm` and a list of `fields` to search on.")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A nested object containing a string `searchTerm` and a list of `fields` to search on.",
        SerializedName = @"search",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Query)]
        public string Search { get => this._search; set => this._search = value; }

        /// <summary>Backing field for <see cref="Skip" /> property.</summary>
        private int _skip;

        /// <summary>The offset into the records to return.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The offset into the records to return.")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offset into the records to return.",
        SerializedName = @"skip",
        PossibleTypes = new [] { typeof(int) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Query)]
        public int Skip { get => this._skip; set => this._skip = value; }

        /// <summary>Backing field for <see cref="Sort" /> property.</summary>
        private string _sort;

        /// <summary>
        /// The comma separated fields used to sort the collection.
        /// Default sort is ascending, prefix with `-` to sort descending.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The comma separated fields used to sort the collection.\nDefault sort is ascending, prefix with `-` to sort descending.\n")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The comma separated fields used to sort the collection.
        Default sort is ascending, prefix with `-` to sort descending.
        ",
        SerializedName = @"sort",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Query)]
        public string Sort { get => this._sort; set => this._sort = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.ISystemuserslist" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnUnauthorized</c> will be called before the regular onUnauthorized has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onUnauthorized method should be processed, or if the method
        /// should return immediately (set to true to skip further processing )</param>

        partial void overrideOnUnauthorized(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

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

        /// <summary>
        /// Intializes a new instance of the <see cref="GetJcSdkSystemUser_List" /> cmdlet class.
        /// </summary>
        public GetJcSdkSystemUser_List()
        {

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
                using( var asyncCommandRuntime = new JumpCloudApiSdkV1.Runtime.PowerShell.AsyncCommandRuntime(this, ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token);
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
                    await this.Client.SystemUserList(this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null, this.InvocationInformation.BoundParameters.ContainsKey("Fields") ? Fields : null, this.InvocationInformation.BoundParameters.ContainsKey("Search") ? Search : null, this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, onOk, onUnauthorized, this, Pipeline);
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloudApiSdkV1.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  Limit=this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?),Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?),Sort=this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null,Fields=this.InvocationInformation.BoundParameters.ContainsKey("Fields") ? Fields : null,Search=this.InvocationInformation.BoundParameters.ContainsKey("Search") ? Search : null,Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null}));
                }
                finally
                {
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.ISystemuserslist" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ISystemuserslist> response)
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
                // (await response) // should be JumpCloudApiSdkV1.Models.ISystemuserslist
                WriteObject((await response));
            }
        }

        /// <summary>a delegate that is called when the remote service returns 401 (Unauthorized).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onUnauthorized(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnUnauthorized(responseMessage, ref _returnNow);
                // if overrideOnUnauthorized has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onUnauthorized - response for 401 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}