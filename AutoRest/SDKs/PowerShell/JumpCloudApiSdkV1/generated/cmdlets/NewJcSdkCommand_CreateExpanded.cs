namespace JumpCloudApiSdkV1.Cmdlets
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>
    /// This endpoint allows you to create a new command.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/commands/
    /// \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n\t\"name\":\"Test
    /// API Command\",\n\t\"command\":\"String\",\n\t\"user\":\"{UserID}\",\n\t\"schedule\":\"\",\n\t\"timeout\":\"100\"\n}'\n\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] Command_Create=>POST:"/commands"
    /// [METADATA]
    /// path: /commands
    /// apiVersions:
    /// - '1.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V1.json#/paths/~1commands'
    /// [DETAILS]
    /// verb: New
    /// subjectPrefix:
    /// subject: Command
    /// variant: CreateExpanded
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"JcSdkCommand_CreateExpanded", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(JumpCloudApiSdkV1.Models.ICommand))]
    [JumpCloudApiSdkV1.Description(@"This endpoint allows you to create a new command.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/commands/ \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\""name\"":\""Test API Command\"",\n\t\""command\"":\""String\"",\n\t\""user\"":\""{UserID}\"",\n\t\""schedule\"":\""\"",\n\t\""timeout\"":\""100\""\n}'\n\n```")]
    [JumpCloudApiSdkV1.Generated]
    public partial class NewJcSdkCommand_CreateExpanded : System.Management.Automation.PSCmdlet,
        JumpCloudApiSdkV1.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ICommand _body= new JumpCloudApiSdkV1.Models.Command();

        /// <summary>Command</summary>
        private JumpCloudApiSdkV1.Models.ICommand Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloudApiSdkV1.JumpCloudApIs Client => JumpCloudApiSdkV1.Module.Instance.ClientAPI;

        /// <summary>The command to execute on the server.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The command to execute on the server.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The command to execute on the server.",
        SerializedName = @"command",
        PossibleTypes = new [] { typeof(string) })]
        public string Command { get => Body.Command1 ?? null; set => Body.Command1 = value; }

        /// <summary>An array of IDs of the Command Runner Users that can execute this command.</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "An array of IDs of the Command Runner Users that can execute this command.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of IDs of the Command Runner Users that can execute this command.",
        SerializedName = @"commandRunners",
        PossibleTypes = new [] { typeof(string) })]
        public string[] CommandRunners { get => Body.CommandRunners ?? null /* arrayOf */; set => Body.CommandRunners = value; }

        /// <summary>The Command OS</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Command OS")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Command OS",
        SerializedName = @"commandType",
        PossibleTypes = new [] { typeof(string) })]
        public string CommandType { get => Body.CommandType ?? null; set => Body.CommandType = value; }

        /// <summary>An array of file IDs to include with the command.</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "An array of file IDs to include with the command.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of file IDs to include with the command.",
        SerializedName = @"files",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Files { get => Body.Files ?? null /* arrayOf */; set => Body.Files = value; }

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

        /// <summary>How the command will execute.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "How the command will execute.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How the command will execute.",
        SerializedName = @"launchType",
        PossibleTypes = new [] { typeof(string) })]
        public string LaunchType { get => Body.LaunchType ?? null; set => Body.LaunchType = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"listensTo",
        PossibleTypes = new [] { typeof(string) })]
        public string ListensTo { get => Body.ListensTo ?? null; set => Body.ListensTo = value; }

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

        /// <summary>The ID of the organization.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The ID of the organization.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the organization.",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        public string Organization { get => Body.Organization ?? null; set => Body.Organization = value; }

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
        /// A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you
        /// send this as an empty string, it will run immediately.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A crontab that consists of: [ (seconds) (minutes) (hours) (days of month) (months) (weekdays) ] or [ immediate ]. If you send this as an empty string, it will run immediately.",
        SerializedName = @"schedule",
        PossibleTypes = new [] { typeof(string) })]
        public string Schedule { get => Body.Schedule ?? null; set => Body.Schedule = value; }

        /// <summary>When the command will repeat.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "When the command will repeat.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"When the command will repeat.",
        SerializedName = @"scheduleRepeatType",
        PossibleTypes = new [] { typeof(string) })]
        public string ScheduleRepeatType { get => Body.ScheduleRepeatType ?? null; set => Body.ScheduleRepeatType = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"sudo",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter Sudo { get => Body.Sudo ?? default(global::System.Management.Automation.SwitchParameter); set => Body.Sudo = value; }

        /// <summary>
        /// An array of system IDs to run the command on. Not available if you are using Groups.
        /// </summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "An array of system IDs to run the command on. Not available if you are using Groups.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"An array of system IDs to run the command on. Not available if you are using Groups.",
        SerializedName = @"systems",
        PossibleTypes = new [] { typeof(string) })]
        public string[] Systems { get => Body.Systems ?? null /* arrayOf */; set => Body.Systems = value; }

        /// <summary>The time in seconds to allow the command to run for.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The time in seconds to allow the command to run for.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time in seconds to allow the command to run for.",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(string) })]
        public string Timeout { get => Body.Timeout ?? null; set => Body.Timeout = value; }

        /// <summary>The name of the command trigger.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The name of the command trigger.")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the command trigger.",
        SerializedName = @"trigger",
        PossibleTypes = new [] { typeof(string) })]
        public string Trigger { get => Body.Trigger ?? null; set => Body.Trigger = value; }

        /// <summary>
        /// The ID of the system user to run the command as. This field is required when creating a command with a commandType of
        /// "mac" or "linux".
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The ID of the system user to run the command as. This field is required when creating a command with a commandType of \"mac\" or \"linux\".")]
        [JumpCloudApiSdkV1.Category(JumpCloudApiSdkV1.ParameterCategory.Body)]
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the system user to run the command as. This field is required when creating a command with a commandType of ""mac"" or ""linux"".",
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        public string User { get => Body.User ?? null; set => Body.User = value; }

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.ICommand" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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

        /// <summary>
        /// Intializes a new instance of the <see cref="NewJcSdkCommand_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewJcSdkCommand_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CommandCreate' operation"))
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
                    await this.Client.CommandCreate(Body, onOk, onUnauthorized, this, Pipeline);
                    await ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Signal(JumpCloudApiSdkV1.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloudApiSdkV1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloudApiSdkV1.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  body=Body}));
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
        /// <param name="response">the body result as a <see cref="JumpCloudApiSdkV1.Models.ICommand" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloudApiSdkV1.Models.ICommand> response)
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
                // (await response) // should be JumpCloudApiSdkV1.Models.ICommand
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