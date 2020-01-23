namespace JumpCloudApiSdkV2.Cmdlets
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>
    /// This endpoint allows you to update the samba domain information for an LDAP server.\n\n##### Sample Request\n```\ncurl
    /// -X PUT https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n -H 'Accept: application/json'
    /// \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n\"sid\":\"{SID_ID}\",\n\"name\":\"{WORKGROUP_NAME}\"\n}'\n\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] LdapServerSambaDomain_Put=>PUT:"/ldapservers/{ldapserver_id}/sambadomains/{id}"
    /// [METADATA]
    /// path: '/ldapservers/{ldapserver_id}/sambadomains/{id}'
    /// apiVersions:
    /// - '2.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/2/s/AutoRest/SwaggerSpecs/V2.json#/paths/~1ldapservers~1{ldapserver_id}~1sambadomains~1{id}'
    /// [DETAILS]
    /// verb: Set
    /// subjectPrefix:
    /// subject: LdapServerSambaDomain
    /// variant: PutExpanded
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Set, @"JcSdkLdapServerSambaDomain_PutExpanded", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(JumpCloudApiSdkV2.Models.ISambaDomainOutput))]
    [JumpCloudApiSdkV2.Description(@"This endpoint allows you to update the samba domain information for an LDAP server.\n\n##### Sample Request\n```\ncurl -X PUT https://console.jumpcloud.com/api/v2/ldapservers/{LDAP_ID}/sambadomains/{SAMBA_ID} \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\""sid\"":\""{SID_ID}\"",\n\""name\"":\""{WORKGROUP_NAME}\""\n}'\n\n```")]
    [JumpCloudApiSdkV2.Generated]
    public partial class SetJcSdkLdapServerSambaDomain_PutExpanded : System.Management.Automation.PSCmdlet,
        JumpCloudApiSdkV2.Runtime.IEventListener
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
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Accept",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Header)]
        public string Accept { get => this._accept; set => this._accept = value; }

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISambaDomainInput _body= new JumpCloudApiSdkV2.Models.SambaDomainInput();

        /// <summary>Samba Domain Input</summary>
        private JumpCloudApiSdkV2.Models.ISambaDomainInput Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloudApiSdkV2.JumpCloudApIs Client => JumpCloudApiSdkV2.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Content-Type",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Header)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

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

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Unique identifier of the samba domain.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Unique identifier of the samba domain.")]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Unique identifier of the samba domain.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Path)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="LdapserverId" /> property.</summary>
        private string _ldapserverId;

        /// <summary>Unique identifier o f the LDAP server.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Unique identifier o f the LDAP server.")]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Unique identifier o f the LDAP server.",
        SerializedName = @"ldapserver_id",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Path)]
        public string LdapserverId { get => this._ldapserverId; set => this._ldapserverId = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloudApiSdkV2.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloudApiSdkV2.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Name of this domain's WorkGroup</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of this domain's WorkGroup")]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Body)]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of this domain's WorkGroup",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        public string Name { get => Body.Name ?? null; set => Body.Name = value; }

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

        /// <summary>Security identifier of this domain</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Security identifier of this domain")]
        [JumpCloudApiSdkV2.Category(JumpCloudApiSdkV2.ParameterCategory.Body)]
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Security identifier of this domain",
        SerializedName = @"sid",
        PossibleTypes = new [] { typeof(string) })]
        public string Sid { get => Body.Sid ?? null; set => Body.Sid = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV2.Models.ISambaDomainOutput" /> from the remote
        /// call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV2.Models.ISambaDomainOutput> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
                if (ShouldProcess($"Call remote 'LdapServerSambaDomainPut' operation"))
                {
                    using( var asyncCommandRuntime = new JumpCloudApiSdkV2.Runtime.PowerShell.AsyncCommandRuntime(this, ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token) )
                    {
                        asyncCommandRuntime.Wait( ProcessRecordAsync(),((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token);
                    }
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
                    await this.Client.LdapServerSambaDomainPut(LdapserverId, Id, this.InvocationInformation.BoundParameters.ContainsKey("ContentType") ? ContentType : null, this.InvocationInformation.BoundParameters.ContainsKey("Accept") ? Accept : null, Body, onOk, this, Pipeline);
                    await ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloudApiSdkV2.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  LdapserverId=LdapserverId,Id=Id,ContentType=this.InvocationInformation.BoundParameters.ContainsKey("ContentType") ? ContentType : null,Accept=this.InvocationInformation.BoundParameters.ContainsKey("Accept") ? Accept : null,body=Body}));
                }
                finally
                {
                    await ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV2.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="SetJcSdkLdapServerSambaDomain_PutExpanded" /> cmdlet class.
        /// </summary>
        public SetJcSdkLdapServerSambaDomain_PutExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloudApiSdkV2.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV2.Models.ISambaDomainOutput" /> from the remote
        /// call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV2.Models.ISambaDomainOutput> response)
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
                // (await response) // should be JumpCloudApiSdkV2.Models.ISambaDomainOutput
                WriteObject((await response));
            }
        }
    }
}