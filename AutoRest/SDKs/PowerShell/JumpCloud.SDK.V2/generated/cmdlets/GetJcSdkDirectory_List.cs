namespace JumpCloud.SDK.V2.Cmdlets
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>
    /// This endpoint returns all active directories (LDAP, O365 Suite, G-Suite).\n\n#### Sample Request\n```\n curl -X GET https://console.jumpcloud.com/api/v2/directories
    /// \\\n -H 'accept: application/json' \\\n -H 'content-type: application/json' \\\n -H 'x-api-key: {API_KEY}'\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Directory_List=>GET:"/directories"
    /// [METADATA]
    /// path: /directories
    /// apiVersions:
    /// - '2.0'
    /// filename:
    /// - 'mem:///116?oai3.shaken.json'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V2.json#/paths/~1directories'
    /// [DETAILS]
    /// verb: Get
    /// subjectPrefix:
    /// subject: Directory
    /// variant: List
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Get, @"JcSdkDirectory_List")]
    [System.Management.Automation.OutputType(typeof(JumpCloud.SDK.V2.Models.IDirectory))]
    [JumpCloud.SDK.V2.Description(@"This endpoint returns all active directories (LDAP, O365 Suite, G-Suite).\n\n#### Sample Request\n```\n curl -X GET https://console.jumpcloud.com/api/v2/directories \\\n  -H 'accept: application/json' \\\n  -H 'content-type: application/json' \\\n  -H 'x-api-key: {API_KEY}'\n```")]
    [JumpCloud.SDK.V2.Generated]
    public partial class GetJcSdkDirectory_List : System.Management.Automation.PSCmdlet,
        JumpCloud.SDK.V2.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloud.SDK.V2.JumpCloudApIs Client => JumpCloud.SDK.V2.Module.Instance.ClientAPI;

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V2.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V2.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private int _limit;

        /// <summary>The number of records to return at once. Limited to 100.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to return at once. Limited to 100.")]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of records to return at once. Limited to 100.",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(int) })]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Query)]
        public int Limit { get => this._limit; set => this._limit = value; }

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

        /// <summary>The URI for the proxy server to use</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [System.Management.Automation.ValidateNotNull]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="Skip" /> property.</summary>
        private int _skip;

        /// <summary>The offset into the records to return.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The offset into the records to return.")]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offset into the records to return.",
        SerializedName = @"skip",
        PossibleTypes = new [] { typeof(int) })]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Query)]
        public int Skip { get => this._skip; set => this._skip = value; }

        /// <summary>Backing field for <see cref="Sort" /> property.</summary>
        private string[] _sort;

        /// <summary>
        /// The comma separated fields used to sort the collection.
        /// Default sort is ascending, prefix with `-` to sort descending.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The comma separated fields used to sort the collection.\nDefault sort is ascending, prefix with `-` to sort descending.\n")]
        [System.Management.Automation.AllowEmptyCollection]
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The comma separated fields used to sort the collection.
        Default sort is ascending, prefix with `-` to sort descending.
        ",
        SerializedName = @"sort",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloud.SDK.V2.Category(JumpCloud.SDK.V2.ParameterCategory.Query)]
        public string[] Sort { get => this._sort; set => this._sort = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IError" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IError> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IDirectory[]" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IDirectory[]> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in System.Management.Automation.PSCmdlet)
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

        /// <summary>
        /// Intializes a new instance of the <see cref="GetJcSdkDirectory_List" /> cmdlet class.
        /// </summary>
        public GetJcSdkDirectory_List()
        {

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
            ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                using( var asyncCommandRuntime = new JumpCloud.SDK.V2.Runtime.PowerShell.AsyncCommandRuntime(this, ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token);
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new System.Management.Automation.ErrorRecord(innerException,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)!= null && (exception as System.Management.Automation.PipelineStoppedException).InnerException == null)
            {
                ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                ThrowTerminatingError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            catch (global::System.Exception exception)
            {
                ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
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
                Pipeline = JumpCloud.SDK.V2.Module.Instance.CreatePipeline(InvocationInformation);
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
                    await this.Client.DirectoryList(this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null /* arrayOf */, this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?), onOk, onDefault, this, Pipeline);
                    await ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V2.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloud.SDK.V2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloud.SDK.V2.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  Limit=this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?),Sort=this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null /* arrayOf */,Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?)}));
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

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IError" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IError> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new JumpCloud.SDK.V2.Runtime.RestException<JumpCloud.SDK.V2.Models.IError>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, System.Management.Automation.ErrorCategory.InvalidOperation, new { Limit=this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?), Sort=this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null /* arrayOf */, Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?) })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { Limit=this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?), Sort=this.InvocationInformation.BoundParameters.ContainsKey("Sort") ? Sort : null /* arrayOf */, Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?) })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V2.Models.IDirectory[]" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V2.Models.IDirectory[]> response)
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