namespace JumpCloudApiSdkV1.Cmdlets
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>
    /// This endpoint allows you to reset the MFA TOTP token for a specified system user and put them in an MFA enrollment period.
    /// This will result in the user being prompted to setup MFA when logging into userportal. Please be aware that if the user
    /// does not complete MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require MFA.\n\nPlease
    /// refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud)
    /// on setting up MFA for more information. \n\n#### Sample Request \n```\ncurl -X POST \\\n https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa
    /// \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\"exclusion\":
    /// true, \"exclusionUntil\": \"{date-time}\"}'\n \n\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] SystemUserMfa_Reset=>POST:"/systemusers/{id}/resetmfa"
    /// [METADATA]
    /// path: '/systemusers/{id}/resetmfa'
    /// apiVersions:
    /// - '1.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V1.json#/paths/~1systemusers~1{id}~1resetmfa'
    /// [DETAILS]
    /// verb: Reset
    /// subjectPrefix:
    /// subject: SystemUserMfa
    /// variant: ResetExpanded
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Reset, @"JcSdkSystemUserMfa_ResetExpanded", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(string))]
    [JumpCloudApiSdkV1.Description(@"This endpoint allows you to reset the MFA TOTP token for a specified system user and put them in an MFA enrollment period. This will result in the user being prompted to setup MFA when logging into userportal. Please be aware that if the user does not complete MFA setup before the `exclusionUntil` date, they will be locked out of any resources that require MFA.\n\nPlease refer to our [Knowledge Base Article](https://support.jumpcloud.com/customer/en/portal/articles/2959138-using-multifactor-authentication-with-jumpcloud) on setting up MFA for more information. \n\n#### Sample Request \n```\ncurl -X POST \\\n  https://console.jumpcloud.com/api/systemusers/{UserID}/resetmfa \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\""exclusion\"": true, \""exclusionUntil\"": \""{date-time}\""}'\n  \n\n```")]
    [JumpCloudApiSdkV1.Generated]
    public partial class ResetJcSdkSystemUserMfa_ResetExpanded : System.Management.Automation.PSCmdlet,
        JumpCloudApiSdkV1.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IBodyParameterSystemUserMfaResetRequestBody _body= new JumpCloudApiSdkV1.Models.BodyParameterSystemUserMfaResetRequestBody();

        private JumpCloudApiSdkV1.Models.IBodyParameterSystemUserMfaResetRequestBody Body { get => this._body; set => this._body = value; }

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
        SerializedName = @"exclusion",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter Exclusion { get => Body.Exclusion ?? default(global::System.Management.Automation.SwitchParameter); set => Body.Exclusion = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"exclusionUntil",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime ExclusionUntil { get => Body.ExclusionUntil ?? default(global::System.DateTime); set => Body.ExclusionUntil = value; }

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

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Path)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

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

        /// <summary>
        /// <c>overrideOnBadRequest</c> will be called before the regular onBadRequest has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onBadRequest method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnConflict</c> will be called before the regular onConflict has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onConflict method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnConflict(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnForbidden</c> will be called before the regular onForbidden has been processed, allowing customization of
        /// what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onForbidden method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnForbidden(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnInternalServerError</c> will be called before the regular onInternalServerError has been processed, allowing
        /// customization of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onInternalServerError method should be processed, or if the
        /// method should return immediately (set to true to skip further processing )</param>

        partial void overrideOnInternalServerError(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnNotFound</c> will be called before the regular onNotFound has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onNotFound method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnNotFound(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnUnauthorized</c> will be called before the regular onUnauthorized has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onUnauthorized method should be processed, or if the method
        /// should return immediately (set to true to skip further processing )</param>

        partial void overrideOnUnauthorized(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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
                if (ShouldProcess($"Call remote 'SystemUserMfaReset' operation"))
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
                    await this.Client.SystemUserMfaReset(Id, Body, onOk, onBadRequest, onUnauthorized, onForbidden, onNotFound, onConflict, onInternalServerError, this, Pipeline);
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloudApiSdkV1.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  Id=Id,body=Body}));
                }
                finally
                {
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="ResetJcSdkSystemUserMfa_ResetExpanded" /> cmdlet class.
        /// </summary>
        public ResetJcSdkSystemUserMfa_ResetExpanded()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 400 (BadRequest).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnBadRequest(responseMessage, response, ref _returnNow);
                // if overrideOnBadRequest has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onBadRequest - response for 400 / application/json
                // (await response) // should be JumpCloudApiSdkV1.Models.IErrorresponse
                WriteObject((await response).Message);
            }
        }

        /// <summary>a delegate that is called when the remote service returns 409 (Conflict).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onConflict(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnConflict(responseMessage, response, ref _returnNow);
                // if overrideOnConflict has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onConflict - response for 409 / application/json
                // (await response) // should be JumpCloudApiSdkV1.Models.IErrorresponse
                WriteObject((await response).Message);
            }
        }

        /// <summary>a delegate that is called when the remote service returns 403 (Forbidden).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onForbidden(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnForbidden(responseMessage, response, ref _returnNow);
                // if overrideOnForbidden has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onForbidden - response for 403 / application/json
                // (await response) // should be JumpCloudApiSdkV1.Models.IErrorresponse
                WriteObject((await response).Message);
            }
        }

        /// <summary>
        /// a delegate that is called when the remote service returns 500 (InternalServerError).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onInternalServerError(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnInternalServerError(responseMessage, response, ref _returnNow);
                // if overrideOnInternalServerError has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onInternalServerError - response for 500 / application/json
                // (await response) // should be JumpCloudApiSdkV1.Models.IErrorresponse
                WriteObject((await response).Message);
            }
        }

        /// <summary>a delegate that is called when the remote service returns 404 (NotFound).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onNotFound(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnNotFound(responseMessage, response, ref _returnNow);
                // if overrideOnNotFound has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onNotFound - response for 404 / application/json
                // (await response) // should be JumpCloudApiSdkV1.Models.IErrorresponse
                WriteObject((await response).Message);
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 401 (Unauthorized).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.IErrorresponse" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onUnauthorized(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.IErrorresponse> response)
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
                // (await response) // should be JumpCloudApiSdkV1.Models.IErrorresponse
                WriteObject((await response).Message);
            }
        }
    }
}