// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Cmdlets
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>
    /// Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters. This WILL
    /// NOT allow you to add a new system.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters
    /// that can only be passed in the body of POST /api/search/* routes. The `filter` and `searchFilter` parameters must be passed
    /// as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or`
    /// with the value of the property being an array of query expressions. \n\nThis allows you to filter records using the logic
    /// of matching ALL or ANY records in the array of query expressions. If the `and` or `or` are not included the default behavior
    /// is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying
    /// a `searchTerm` and a list of `fields` to query on. If any `field` has a partial text match on the`searchTerm` the record
    /// will be returned.\n\n\n#### Sample Request\n\nExact search for a list of hostnames\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems
    /// \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n
    /// \"filter\": {\n \"or\": [\n {\"hostname\" : \"my-hostname\"},\n {\"hostname\" : \"other-hostname\"}\n ]\n },\n \"fields\"
    /// : \"os hostname displayName\"\n}'\n```\n\nText search for a hostname or display name\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems
    /// \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n
    /// \"searchFilter\": {\n \"searchTerm\": \"my-host\",\n \"fields\": [\"hostname\", \"displayName\"]\n },\n \"fields\": \"os
    /// hostname displayName\"\n}'\n```\n\nCombining `filter` and `searchFilter` to search for names that match a given OS\n```\ncurl
    /// -X POST https://console.jumpcloud.com/api/search/systems \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json'
    /// \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n \"searchFilter\": {\n \"searchTerm\": \"my-host\",\n \"fields\": [\"hostname\",
    /// \"displayName\"]\n },\n \"filter\": {\n \"or\": [\n {\"os\" : \"Ubuntu\"},\n {\"os\" : \"Mac OS X\"}\n ]\n },\n \"fields\":
    /// \"os hostname displayName\"\n}'\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Search-System=>POST:"/search/systems"
    /// [METADATA]
    /// path: /search/systems
    /// apiVersions:
    /// - '1.0'
    /// filename:
    /// - 'mem:///109?oai3.shaken.json'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/SwaggerSpecs/JumpCloud.SDK.V1.json#/paths/~1search~1systems'
    /// [DETAILS]
    /// verb: Search
    /// subjectPrefix:
    /// subject: System
    /// variant: Search
    /// </remarks>
    [global::JumpCloud.SDK.V1.InternalExport]
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsCommon.Search, @"JcSdkInternalSystem_Search", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(JumpCloud.SDK.V1.Models.ISystemslist))]
    [global::JumpCloud.SDK.V1.Description(@"Return Systems in multi-record format allowing for the passing of the `filter` and `searchFilter` parameters. This WILL NOT allow you to add a new system.\n\nTo support advanced filtering you can use the `filter` and `searchFilter` parameters that can only be passed in the body of POST /api/search/* routes. The `filter` and `searchFilter` parameters must be passed as Content-Type application/json.\n\nThe `filter` parameter is an object with a single property, either `and` or `or` with the value of the property being an array of query expressions. \n\nThis allows you to filter records using the logic of matching ALL or ANY records in the array of query expressions. If the `and` or `or` are not included the default behavior is to match ALL query expressions.\n\nThe `searchFilter` parameter allows text searching on supported fields by specifying a `searchTerm` and a list of `fields` to query on. If any `field` has a partial text match on the`searchTerm` the record will be returned.\n\n\n#### Sample Request\n\nExact search for a list of hostnames\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \""filter\"": {\n    \""or\"": [\n      {\""hostname\"" : \""my-hostname\""},\n      {\""hostname\"" : \""other-hostname\""}\n    ]\n  },\n  \""fields\"" : \""os hostname displayName\""\n}'\n```\n\nText search for a hostname or display name\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \""searchFilter\"": {\n    \""searchTerm\"": \""my-host\"",\n    \""fields\"": [\""hostname\"", \""displayName\""]\n  },\n  \""fields\"": \""os hostname displayName\""\n}'\n```\n\nCombining `filter` and `searchFilter` to search for names that match a given OS\n```\ncurl -X POST https://console.jumpcloud.com/api/search/systems \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n  \""searchFilter\"": {\n    \""searchTerm\"": \""my-host\"",\n    \""fields\"": [\""hostname\"", \""displayName\""]\n  },\n  \""filter\"": {\n    \""or\"": [\n      {\""os\"" : \""Ubuntu\""},\n      {\""os\"" : \""Mac OS X\""}\n    ]\n  },\n  \""fields\"": \""os hostname displayName\""\n}'\n```")]
    [global::JumpCloud.SDK.V1.Generated]
    public partial class SearchJcSdkInternalSystem_Search : global::System.Management.Automation.PSCmdlet,
        JumpCloud.SDK.V1.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ISearch _body;

        /// <summary>Search</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Search", ValueFromPipeline = true)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Search",
        SerializedName = @"body",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISearch) })]
        public JumpCloud.SDK.V1.Models.ISearch Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloud.SDK.V1.JumpCloudApIs Client => JumpCloud.SDK.V1.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private string _fields;

        /// <summary>
        /// Use a space seperated string of field parameters to include the data in the response. If omitted, the default list of
        /// fields will be returned.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Use a space seperated string of field parameters to include the data in the response. If omitted, the default list of fields will be returned.\n")]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Use a space seperated string of field parameters to include the data in the response. If omitted, the default list of fields will be returned.
        ",
        SerializedName = @"fields",
        PossibleTypes = new [] { typeof(string) })]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Query)]
        public string Fields { get => this._fields; set => this._fields = value; }

        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private string _filter;

        /// <summary>A filter to apply to the query.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A filter to apply to the query.")]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A filter to apply to the query.",
        SerializedName = @"filter",
        PossibleTypes = new [] { typeof(string) })]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Query)]
        public string Filter { get => this._filter; set => this._filter = value; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V1.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public JumpCloud.SDK.V1.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private int _limit;

        /// <summary>The number of records to return at once. Limited to 100.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to return at once. Limited to 100.")]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of records to return at once. Limited to 100.",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(int) })]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Query)]
        public int Limit { get => this._limit; set => this._limit = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloud.SDK.V1.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloud.SDK.V1.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>
        /// The instance of the <see cref="JumpCloud.SDK.V1.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private JumpCloud.SDK.V1.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="Skip" /> property.</summary>
        private int _skip;

        /// <summary>The offset into the records to return.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The offset into the records to return.")]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offset into the records to return.",
        SerializedName = @"skip",
        PossibleTypes = new [] { typeof(int) })]
        [global::JumpCloud.SDK.V1.Category(global::JumpCloud.SDK.V1.ParameterCategory.Query)]
        public int Skip { get => this._skip; set => this._skip = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V1.Models.ISystemslist" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V1.Models.ISystemslist> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnUnauthorized</c> will be called before the regular onUnauthorized has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onUnauthorized method should be processed, or if the method
        /// should return immediately (set to true to skip further processing )</param>

        partial void overrideOnUnauthorized(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
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
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
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
                if (ShouldProcess($"Call remote 'SearchSystem' operation"))
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
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
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
                Pipeline = JumpCloud.SDK.V1.Module.Instance.CreatePipeline(InvocationInformation, this.ParameterSetName);
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
                    await this.Client.SearchSystem(this.InvocationInformation.BoundParameters.ContainsKey("Fields") ? Fields : null, this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?), this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null, Body, onOk, onUnauthorized, this, Pipeline);
                    await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloud.SDK.V1.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  Fields=this.InvocationInformation.BoundParameters.ContainsKey("Fields") ? Fields : null,Limit=this.InvocationInformation.BoundParameters.ContainsKey("Limit") ? Limit : default(int?),Skip=this.InvocationInformation.BoundParameters.ContainsKey("Skip") ? Skip : default(int?),Filter=this.InvocationInformation.BoundParameters.ContainsKey("Filter") ? Filter : null,body=Body})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="SearchJcSdkInternalSystem_Search" /> cmdlet class.
        /// </summary>
        public SearchJcSdkInternalSystem_Search()
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
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V1.Models.ISystemslist" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V1.Models.ISystemslist> response)
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
                // (await response) // should be JumpCloud.SDK.V1.Models.ISystemslist
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