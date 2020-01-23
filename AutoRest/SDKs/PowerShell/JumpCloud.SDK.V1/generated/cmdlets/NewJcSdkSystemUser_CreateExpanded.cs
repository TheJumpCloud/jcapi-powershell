namespace JumpCloud.SDK.V1.Cmdlets
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>
    /// This endpoint allows you to create a new system user.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/systemusers
    /// \\\n -H 'Accept: application/json' \\\n -H 'Content-Type: application/json' \\\n -H 'x-api-key: {API_KEY}' \\\n -d '{\n\t\"username\":\"{username}\",\n\t\"email\":\"{email_address}\",\n\t\"firstname\":\"{Name}\",\n\t\"lastname\":\"{Name}\"\n}'\n```
    /// </summary>
    /// <remarks>
    /// [OpenAPI] SystemUser_Create=>POST:"/systemusers"
    /// [METADATA]
    /// path: /systemusers
    /// apiVersions:
    /// - '1.0'
    /// filename:
    /// - 'mem:///108?tree%20shaken%20doc...'
    /// originalLocations:
    /// - 'file:///D:/a/1/s/AutoRest/SwaggerSpecs/V1.json#/paths/~1systemusers'
    /// [DETAILS]
    /// verb: New
    /// subjectPrefix:
    /// subject: SystemUser
    /// variant: CreateExpanded
    /// </remarks>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"JcSdkSystemUser_CreateExpanded", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(JumpCloud.SDK.V1.Models.ISystemuserreturn))]
    [JumpCloud.SDK.V1.Description(@"This endpoint allows you to create a new system user.\n\n#### Sample Request\n\n```\ncurl -X POST https://console.jumpcloud.com/api/systemusers \\\n  -H 'Accept: application/json' \\\n  -H 'Content-Type: application/json' \\\n  -H 'x-api-key: {API_KEY}' \\\n  -d '{\n\t\""username\"":\""{username}\"",\n\t\""email\"":\""{email_address}\"",\n\t\""firstname\"":\""{Name}\"",\n\t\""lastname\"":\""{Name}\""\n}'\n```")]
    [JumpCloud.SDK.V1.Generated]
    public partial class NewJcSdkSystemUser_CreateExpanded : System.Management.Automation.PSCmdlet,
        JumpCloud.SDK.V1.Runtime.IEventListener
    {
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"account_locked",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AccountLocked { get => Body.AccountLocked ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AccountLocked = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"activated",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter Activated { get => Body.Activated ?? default(global::System.Management.Automation.SwitchParameter); set => Body.Activated = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"addresses",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISystemuserputpostAddressesItem) })]
        public JumpCloud.SDK.V1.Models.ISystemuserputpostAddressesItem[] Addresses { get => Body.Addresses ?? null /* arrayOf */; set => Body.Addresses = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"allow_public_key",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter AllowPublicKey { get => Body.AllowPublicKey ?? default(global::System.Management.Automation.SwitchParameter); set => Body.AllowPublicKey = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISystemuserputpostAttributesItem) })]
        public JumpCloud.SDK.V1.Models.ISystemuserputpostAttributesItem[] Attributes { get => Body.Attributes ?? null /* arrayOf */; set => Body.Attributes = value; }

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private JumpCloud.SDK.V1.Models.ISystemuserputpost _body= new JumpCloud.SDK.V1.Models.Systemuserputpost();

        /// <summary>SystemUserPost</summary>
        private JumpCloud.SDK.V1.Models.ISystemuserputpost Body { get => this._body; set => this._body = value; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public JumpCloud.SDK.V1.JumpCloudApIs Client => JumpCloud.SDK.V1.Module.Instance.ClientAPI;

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"company",
        PossibleTypes = new [] { typeof(string) })]
        public string Company { get => Body.Company ?? null; set => Body.Company = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"costCenter",
        PossibleTypes = new [] { typeof(string) })]
        public string CostCenter { get => Body.CostCenter ?? null; set => Body.CostCenter = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"department",
        PossibleTypes = new [] { typeof(string) })]
        public string Department { get => Body.Department ?? null; set => Body.Department = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        public string Description { get => Body.Description ?? null; set => Body.Description = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"displayname",
        PossibleTypes = new [] { typeof(string) })]
        public string Displayname { get => Body.Displayname ?? null; set => Body.Displayname = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        public string Email { get => Body.Email ?? null; set => Body.Email = value; }

        /// <summary>Must be unique per user.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Must be unique per user. ")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Must be unique per user. ",
        SerializedName = @"employeeIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        public string EmployeeIdentifier { get => Body.EmployeeIdentifier ?? null; set => Body.EmployeeIdentifier = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"employeeType",
        PossibleTypes = new [] { typeof(string) })]
        public string EmployeeType { get => Body.EmployeeType ?? null; set => Body.EmployeeType = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"enable_managed_uid",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableManagedUid { get => Body.EnableManagedUid ?? default(global::System.Management.Automation.SwitchParameter); set => Body.EnableManagedUid = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"enable_user_portal_multifactor",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter EnableUserPortalMultifactor { get => Body.EnableUserPortalMultifactor ?? default(global::System.Management.Automation.SwitchParameter); set => Body.EnableUserPortalMultifactor = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"external_dn",
        PossibleTypes = new [] { typeof(string) })]
        public string ExternalDn { get => Body.ExternalDn ?? null; set => Body.ExternalDn = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"external_password_expiration_date",
        PossibleTypes = new [] { typeof(string) })]
        public string ExternalPasswordExpirationDate { get => Body.ExternalPasswordExpirationDate ?? null; set => Body.ExternalPasswordExpirationDate = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"external_source_type",
        PossibleTypes = new [] { typeof(string) })]
        public string ExternalSourceType { get => Body.ExternalSourceType ?? null; set => Body.ExternalSourceType = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"externally_managed",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter ExternallyManaged { get => Body.ExternallyManaged ?? default(global::System.Management.Automation.SwitchParameter); set => Body.ExternallyManaged = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        public string Firstname { get => Body.Firstname ?? null; set => Body.Firstname = value; }

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

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"jobTitle",
        PossibleTypes = new [] { typeof(string) })]
        public string JobTitle { get => Body.JobTitle ?? null; set => Body.JobTitle = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        public string Lastname { get => Body.Lastname ?? null; set => Body.Lastname = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"ldap_binding_user",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter LdapBindingUser { get => Body.LdapBindingUser ?? default(global::System.Management.Automation.SwitchParameter); set => Body.LdapBindingUser = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        public string Location { get => Body.Location ?? null; set => Body.Location = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"configured",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter MfaConfigured { get => Body.MfaConfigured ?? default(global::System.Management.Automation.SwitchParameter); set => Body.MfaConfigured = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"exclusion",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter MfaExclusion { get => Body.MfaExclusion ?? default(global::System.Management.Automation.SwitchParameter); set => Body.MfaExclusion = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"exclusionUntil",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        public global::System.DateTime MfaExclusionUntil { get => Body.MfaExclusionUntil ?? default(global::System.DateTime); set => Body.MfaExclusionUntil = value; }

        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action JumpCloud.SDK.V1.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken JumpCloud.SDK.V1.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"middlename",
        PossibleTypes = new [] { typeof(string) })]
        public string Middlename { get => Body.Middlename ?? null; set => Body.Middlename = value; }

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Runtime)]
        public System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        public string Password { get => Body.Password ?? null; set => Body.Password = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"password_never_expires",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter PasswordNeverExpires { get => Body.PasswordNeverExpires ?? default(global::System.Management.Automation.SwitchParameter); set => Body.PasswordNeverExpires = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"passwordless_sudo",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter PasswordlessSudo { get => Body.PasswordlessSudo ?? default(global::System.Management.Automation.SwitchParameter); set => Body.PasswordlessSudo = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"phoneNumbers",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISystemuserputpostPhoneNumbersItem) })]
        public JumpCloud.SDK.V1.Models.ISystemuserputpostPhoneNumbersItem[] PhoneNumbers { get => Body.PhoneNumbers ?? null /* arrayOf */; set => Body.PhoneNumbers = value; }

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
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"public_key",
        PossibleTypes = new [] { typeof(string) })]
        public string PublicKey { get => Body.PublicKey ?? null; set => Body.PublicKey = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"relationships",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.ISystemuserputpostRelationshipsItem) })]
        public JumpCloud.SDK.V1.Models.ISystemuserputpostRelationshipsItem[] Relationships { get => Body.Relationships ?? null /* arrayOf */; set => Body.Relationships = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"samba_service_user",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter SambaServiceUser { get => Body.SambaServiceUser ?? default(global::System.Management.Automation.SwitchParameter); set => Body.SambaServiceUser = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"sudo",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter Sudo { get => Body.Sudo ?? default(global::System.Management.Automation.SwitchParameter); set => Body.Sudo = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"suspended",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter Suspended { get => Body.Suspended ?? default(global::System.Management.Automation.SwitchParameter); set => Body.Suspended = value; }

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

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"unix_guid",
        PossibleTypes = new [] { typeof(int) })]
        public int UnixGuid { get => Body.UnixGuid ?? default(int); set => Body.UnixGuid = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"unix_uid",
        PossibleTypes = new [] { typeof(int) })]
        public int UnixUid { get => Body.UnixUid ?? default(int); set => Body.UnixUid = value; }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        [JumpCloud.SDK.V1.Category(JumpCloud.SDK.V1.ParameterCategory.Body)]
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"HELP MESSAGE MISSING",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        public string Username { get => Body.Username ?? null; set => Body.Username = value; }

        /// <summary>
        /// <c>overrideOnBadRequest</c> will be called before the regular onBadRequest has been processed, allowing customization
        /// of what happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onBadRequest method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V1.Models.ISystemuserreturn" /> from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V1.Models.ISystemuserreturn> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

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

        /// <summary>
        /// Intializes a new instance of the <see cref="NewJcSdkSystemUser_CreateExpanded" /> cmdlet class.
        /// </summary>
        public NewJcSdkSystemUser_CreateExpanded()
        {

        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                if (ShouldProcess($"Call remote 'SystemUserCreate' operation"))
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
                    await this.Client.SystemUserCreate(Body, onOk, onBadRequest, onUnauthorized, this, Pipeline);
                    await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletAfterAPICall); if( ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (JumpCloud.SDK.V1.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new {  body=Body}));
                }
                finally
                {
                    await ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Signal(JumpCloud.SDK.V1.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((JumpCloud.SDK.V1.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>a delegate that is called when the remote service returns 400 (BadRequest).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onBadRequest(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnBadRequest(responseMessage, ref _returnNow);
                // if overrideOnBadRequest has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onBadRequest - response for 400 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="JumpCloud.SDK.V1.Models.ISystemuserreturn" /> from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<JumpCloud.SDK.V1.Models.ISystemuserreturn> response)
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
                // (await response) // should be JumpCloud.SDK.V1.Models.ISystemuserreturn
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