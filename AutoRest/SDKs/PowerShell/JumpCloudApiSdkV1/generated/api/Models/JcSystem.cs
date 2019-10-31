namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>System</summary>
    public partial class JcSystem :
        JumpCloudApiSdkV1.Models.IJcSystem,
        JumpCloudApiSdkV1.Models.IJcSystemInternal
    {

        /// <summary>Backing field for <see cref="Active" /> property.</summary>
        private bool? _active;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Active { get => this._active; set => this._active = value; }

        /// <summary>Backing field for <see cref="AgentVersion" /> property.</summary>
        private string _agentVersion;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string AgentVersion { get => this._agentVersion; set => this._agentVersion = value; }

        /// <summary>Backing field for <see cref="AllowMultiFactorAuthentication" /> property.</summary>
        private bool? _allowMultiFactorAuthentication;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AllowMultiFactorAuthentication { get => this._allowMultiFactorAuthentication; set => this._allowMultiFactorAuthentication = value; }

        /// <summary>Backing field for <see cref="AllowPublicKeyAuthentication" /> property.</summary>
        private bool? _allowPublicKeyAuthentication;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AllowPublicKeyAuthentication { get => this._allowPublicKeyAuthentication; set => this._allowPublicKeyAuthentication = value; }

        /// <summary>Backing field for <see cref="AllowSshPasswordAuthentication" /> property.</summary>
        private bool? _allowSshPasswordAuthentication;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AllowSshPasswordAuthentication { get => this._allowSshPasswordAuthentication; set => this._allowSshPasswordAuthentication = value; }

        /// <summary>Backing field for <see cref="AllowSshRootLogin" /> property.</summary>
        private bool? _allowSshRootLogin;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? AllowSshRootLogin { get => this._allowSshRootLogin; set => this._allowSshRootLogin = value; }

        /// <summary>Backing field for <see cref="AmazonInstanceId" /> property.</summary>
        private string _amazonInstanceId;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string AmazonInstanceId { get => this._amazonInstanceId; set => this._amazonInstanceId = value; }

        /// <summary>Backing field for <see cref="Arch" /> property.</summary>
        private string _arch;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Arch { get => this._arch; set => this._arch = value; }

        /// <summary>Backing field for <see cref="ConnectionHistory" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem[] _connectionHistory;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem[] ConnectionHistory { get => this._connectionHistory; set => this._connectionHistory = value; }

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Fde" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IFde _fde;

        /// <summary>FDE</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IFde Fde { get => (this._fde = this._fde ?? new JumpCloudApiSdkV1.Models.Fde()); set => this._fde = value; }

        /// <summary>FIXME: Property FdeActive is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? FdeActive { get => ((JumpCloudApiSdkV1.Models.IFdeInternal)Fde).Active; set => ((JumpCloudApiSdkV1.Models.IFdeInternal)Fde).Active = value; }

        /// <summary>FIXME: Property FdeKeyPresent is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? FdeKeyPresent { get => ((JumpCloudApiSdkV1.Models.IFdeInternal)Fde).KeyPresent; set => ((JumpCloudApiSdkV1.Models.IFdeInternal)Fde).KeyPresent = value; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Fde</summary>
        JumpCloudApiSdkV1.Models.IFde JumpCloudApiSdkV1.Models.IJcSystemInternal.Fde { get => (this._fde = this._fde ?? new JumpCloudApiSdkV1.Models.Fde()); set { {_fde = value;} } }

        /// <summary>Internal Acessors for SystemInsights</summary>
        JumpCloudApiSdkV1.Models.IJcSystemInsights JumpCloudApiSdkV1.Models.IJcSystemInternal.SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloudApiSdkV1.Models.JcSystemInsights()); set { {_systemInsights = value;} } }

        /// <summary>Backing field for <see cref="LastContact" /> property.</summary>
        private string _lastContact;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string LastContact { get => this._lastContact; set => this._lastContact = value; }

        /// <summary>Backing field for <see cref="ModifySshdConfig" /> property.</summary>
        private bool? _modifySshdConfig;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? ModifySshdConfig { get => this._modifySshdConfig; set => this._modifySshdConfig = value; }

        /// <summary>Backing field for <see cref="NetworkInterfaces" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem[] _networkInterfaces;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem[] NetworkInterfaces { get => this._networkInterfaces; set => this._networkInterfaces = value; }

        /// <summary>Backing field for <see cref="OS" /> property.</summary>
        private string _oS;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string OS { get => this._oS; set => this._oS = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="RemoteIP" /> property.</summary>
        private string _remoteIP;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string RemoteIP { get => this._remoteIP; set => this._remoteIP = value; }

        /// <summary>Backing field for <see cref="SshRootEnabled" /> property.</summary>
        private bool? _sshRootEnabled;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? SshRootEnabled { get => this._sshRootEnabled; set => this._sshRootEnabled = value; }

        /// <summary>Backing field for <see cref="SshdParams" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem[] _sshdParams;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem[] SshdParams { get => this._sshdParams; set => this._sshdParams = value; }

        /// <summary>FIXME: Property SystemInsightState is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string SystemInsightState { get => ((JumpCloudApiSdkV1.Models.IJcSystemInsightsInternal)SystemInsights).State; set => ((JumpCloudApiSdkV1.Models.IJcSystemInsightsInternal)SystemInsights).State = value; }

        /// <summary>Backing field for <see cref="SystemInsights" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IJcSystemInsights _systemInsights;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IJcSystemInsights SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloudApiSdkV1.Models.JcSystemInsights()); set => this._systemInsights = value; }

        /// <summary>Backing field for <see cref="SystemTimezone" /> property.</summary>
        private int? _systemTimezone;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? SystemTimezone { get => this._systemTimezone; set => this._systemTimezone = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private string[] _tags;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="TemplateName" /> property.</summary>
        private string _templateName;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string TemplateName { get => this._templateName; set => this._templateName = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="JcSystem" /> instance.</summary>
        public JcSystem()
        {

        }
    }
    /// System
    public partial interface IJcSystem :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Active { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"agentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AgentVersion { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowMultiFactorAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowMultiFactorAuthentication { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowPublicKeyAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowPublicKeyAuthentication { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowSshPasswordAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowSshPasswordAuthentication { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowSshRootLogin",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowSshRootLogin { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amazonInstanceID",
        PossibleTypes = new [] { typeof(string) })]
        string AmazonInstanceId { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"arch",
        PossibleTypes = new [] { typeof(string) })]
        string Arch { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"connectionHistory",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem) })]
        JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem[] ConnectionHistory { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(string) })]
        string Created { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FdeActive { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"keyPresent",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FdeKeyPresent { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastContact",
        PossibleTypes = new [] { typeof(string) })]
        string LastContact { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"modifySSHDConfig",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ModifySshdConfig { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem) })]
        JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem[] NetworkInterfaces { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"os",
        PossibleTypes = new [] { typeof(string) })]
        string OS { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"remoteIP",
        PossibleTypes = new [] { typeof(string) })]
        string RemoteIP { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sshRootEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SshRootEnabled { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sshdParams",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem) })]
        JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem[] SshdParams { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string SystemInsightState { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemTimezone",
        PossibleTypes = new [] { typeof(int) })]
        int? SystemTimezone { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tags { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"templateName",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateName { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System
    internal partial interface IJcSystemInternal

    {
        bool? Active { get; set; }

        string AgentVersion { get; set; }

        bool? AllowMultiFactorAuthentication { get; set; }

        bool? AllowPublicKeyAuthentication { get; set; }

        bool? AllowSshPasswordAuthentication { get; set; }

        bool? AllowSshRootLogin { get; set; }

        string AmazonInstanceId { get; set; }

        string Arch { get; set; }

        JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem[] ConnectionHistory { get; set; }

        string Created { get; set; }

        string DisplayName { get; set; }
        /// <summary>FDE</summary>
        JumpCloudApiSdkV1.Models.IFde Fde { get; set; }

        bool? FdeActive { get; set; }

        bool? FdeKeyPresent { get; set; }

        string Hostname { get; set; }

        string Id { get; set; }

        string LastContact { get; set; }

        bool? ModifySshdConfig { get; set; }

        JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem[] NetworkInterfaces { get; set; }

        string OS { get; set; }

        string Organization { get; set; }

        string RemoteIP { get; set; }

        bool? SshRootEnabled { get; set; }

        JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem[] SshdParams { get; set; }

        string SystemInsightState { get; set; }

        JumpCloudApiSdkV1.Models.IJcSystemInsights SystemInsights { get; set; }

        int? SystemTimezone { get; set; }

        string[] Tags { get; set; }

        string TemplateName { get; set; }

        string Version { get; set; }

    }
}