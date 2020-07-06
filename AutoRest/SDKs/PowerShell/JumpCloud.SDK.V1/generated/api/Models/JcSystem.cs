// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>System</summary>
    public partial class JcSystem :
        JumpCloud.SDK.V1.Models.IJcSystem,
        JumpCloud.SDK.V1.Models.IJcSystemInternal
    {

        /// <summary>Backing field for <see cref="Active" /> property.</summary>
        private bool? _active;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Active { get => this._active; set => this._active = value; }

        /// <summary>Backing field for <see cref="AgentVersion" /> property.</summary>
        private string _agentVersion;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string AgentVersion { get => this._agentVersion; set => this._agentVersion = value; }

        /// <summary>Backing field for <see cref="AllowMultiFactorAuthentication" /> property.</summary>
        private bool? _allowMultiFactorAuthentication;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? AllowMultiFactorAuthentication { get => this._allowMultiFactorAuthentication; set => this._allowMultiFactorAuthentication = value; }

        /// <summary>Backing field for <see cref="AllowPublicKeyAuthentication" /> property.</summary>
        private bool? _allowPublicKeyAuthentication;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? AllowPublicKeyAuthentication { get => this._allowPublicKeyAuthentication; set => this._allowPublicKeyAuthentication = value; }

        /// <summary>Backing field for <see cref="AllowSshPasswordAuthentication" /> property.</summary>
        private bool? _allowSshPasswordAuthentication;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? AllowSshPasswordAuthentication { get => this._allowSshPasswordAuthentication; set => this._allowSshPasswordAuthentication = value; }

        /// <summary>Backing field for <see cref="AllowSshRootLogin" /> property.</summary>
        private bool? _allowSshRootLogin;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? AllowSshRootLogin { get => this._allowSshRootLogin; set => this._allowSshRootLogin = value; }

        /// <summary>Backing field for <see cref="AmazonInstanceId" /> property.</summary>
        private string _amazonInstanceId;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string AmazonInstanceId { get => this._amazonInstanceId; set => this._amazonInstanceId = value; }

        /// <summary>Backing field for <see cref="Arch" /> property.</summary>
        private string _arch;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Arch { get => this._arch; set => this._arch = value; }

        /// <summary>Backing field for <see cref="ConnectionHistory" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem[] _connectionHistory;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem[] ConnectionHistory { get => this._connectionHistory; set => this._connectionHistory = value; }

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Fde" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IFde _fde;

        /// <summary>FDE</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IFde Fde { get => (this._fde = this._fde ?? new JumpCloud.SDK.V1.Models.Fde()); set => this._fde = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? FdeActive { get => ((JumpCloud.SDK.V1.Models.IFdeInternal)Fde).Active; set => ((JumpCloud.SDK.V1.Models.IFdeInternal)Fde).Active = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? FdeKeyPresent { get => ((JumpCloud.SDK.V1.Models.IFdeInternal)Fde).KeyPresent; set => ((JumpCloud.SDK.V1.Models.IFdeInternal)Fde).KeyPresent = value; }

        /// <summary>Backing field for <see cref="FileSystem" /> property.</summary>
        private string _fileSystem;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string FileSystem { get => this._fileSystem; set => this._fileSystem = value; }

        /// <summary>Backing field for <see cref="HasServiceAccount" /> property.</summary>
        private bool? _hasServiceAccount;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? HasServiceAccount { get => this._hasServiceAccount; set => this._hasServiceAccount = value; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Fde</summary>
        JumpCloud.SDK.V1.Models.IFde JumpCloud.SDK.V1.Models.IJcSystemInternal.Fde { get => (this._fde = this._fde ?? new JumpCloud.SDK.V1.Models.Fde()); set { {_fde = value;} } }

        /// <summary>Internal Acessors for Mdm</summary>
        JumpCloud.SDK.V1.Models.IJcSystemMdm JumpCloud.SDK.V1.Models.IJcSystemInternal.Mdm { get => (this._mdm = this._mdm ?? new JumpCloud.SDK.V1.Models.JcSystemMdm()); set { {_mdm = value;} } }

        /// <summary>Internal Acessors for SystemInsights</summary>
        JumpCloud.SDK.V1.Models.IJcSystemInsights JumpCloud.SDK.V1.Models.IJcSystemInternal.SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloud.SDK.V1.Models.JcSystemInsights()); set { {_systemInsights = value;} } }

        /// <summary>Backing field for <see cref="LastContact" /> property.</summary>
        private string _lastContact;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string LastContact { get => this._lastContact; set => this._lastContact = value; }

        /// <summary>Backing field for <see cref="Mdm" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IJcSystemMdm _mdm;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IJcSystemMdm Mdm { get => (this._mdm = this._mdm ?? new JumpCloud.SDK.V1.Models.JcSystemMdm()); set => this._mdm = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? MdmDep { get => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).Dep; set => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).Dep = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string MdmProfileIdentifier { get => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).ProfileIdentifier; set => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).ProfileIdentifier = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? MdmUserApproved { get => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).UserApproved; set => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).UserApproved = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string MdmVendor { get => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).Vendor; set => ((JumpCloud.SDK.V1.Models.IJcSystemMdmInternal)Mdm).Vendor = value; }

        /// <summary>Backing field for <see cref="ModifySshdConfig" /> property.</summary>
        private bool? _modifySshdConfig;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? ModifySshdConfig { get => this._modifySshdConfig; set => this._modifySshdConfig = value; }

        /// <summary>Backing field for <see cref="NetworkInterfaces" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem[] _networkInterfaces;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem[] NetworkInterfaces { get => this._networkInterfaces; set => this._networkInterfaces = value; }

        /// <summary>Backing field for <see cref="OS" /> property.</summary>
        private string _oS;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string OS { get => this._oS; set => this._oS = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="RemoteIP" /> property.</summary>
        private string _remoteIP;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string RemoteIP { get => this._remoteIP; set => this._remoteIP = value; }

        /// <summary>Backing field for <see cref="SshRootEnabled" /> property.</summary>
        private bool? _sshRootEnabled;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? SshRootEnabled { get => this._sshRootEnabled; set => this._sshRootEnabled = value; }

        /// <summary>Backing field for <see cref="SshdParams" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem[] _sshdParams;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem[] SshdParams { get => this._sshdParams; set => this._sshdParams = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SystemInsightState { get => ((JumpCloud.SDK.V1.Models.IJcSystemInsightsInternal)SystemInsights).State; set => ((JumpCloud.SDK.V1.Models.IJcSystemInsightsInternal)SystemInsights).State = value; }

        /// <summary>Backing field for <see cref="SystemInsights" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IJcSystemInsights _systemInsights;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IJcSystemInsights SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloud.SDK.V1.Models.JcSystemInsights()); set => this._systemInsights = value; }

        /// <summary>Backing field for <see cref="SystemTimezone" /> property.</summary>
        private int? _systemTimezone;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? SystemTimezone { get => this._systemTimezone; set => this._systemTimezone = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private string[] _tags;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Backing field for <see cref="TemplateName" /> property.</summary>
        private string _templateName;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string TemplateName { get => this._templateName; set => this._templateName = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="JcSystem" /> instance.</summary>
        public JcSystem()
        {

        }
    }
    /// System
    public partial interface IJcSystem :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Active { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"agentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AgentVersion { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowMultiFactorAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowMultiFactorAuthentication { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowPublicKeyAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowPublicKeyAuthentication { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowSshPasswordAuthentication",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowSshPasswordAuthentication { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"allowSshRootLogin",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowSshRootLogin { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amazonInstanceID",
        PossibleTypes = new [] { typeof(string) })]
        string AmazonInstanceId { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"arch",
        PossibleTypes = new [] { typeof(string) })]
        string Arch { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"connectionHistory",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem) })]
        JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem[] ConnectionHistory { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(string) })]
        string Created { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FdeActive { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"keyPresent",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FdeKeyPresent { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fileSystem",
        PossibleTypes = new [] { typeof(string) })]
        string FileSystem { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hasServiceAccount",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HasServiceAccount { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastContact",
        PossibleTypes = new [] { typeof(string) })]
        string LastContact { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"dep",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MdmDep { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"profileIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string MdmProfileIdentifier { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userApproved",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MdmUserApproved { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string MdmVendor { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"modifySSHDConfig",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ModifySshdConfig { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem) })]
        JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem[] NetworkInterfaces { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"os",
        PossibleTypes = new [] { typeof(string) })]
        string OS { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"remoteIP",
        PossibleTypes = new [] { typeof(string) })]
        string RemoteIP { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sshRootEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SshRootEnabled { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sshdParams",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem) })]
        JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem[] SshdParams { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string SystemInsightState { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemTimezone",
        PossibleTypes = new [] { typeof(int) })]
        int? SystemTimezone { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tags { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"templateName",
        PossibleTypes = new [] { typeof(string) })]
        string TemplateName { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
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

        JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem[] ConnectionHistory { get; set; }

        string Created { get; set; }

        string DisplayName { get; set; }
        /// <summary>FDE</summary>
        JumpCloud.SDK.V1.Models.IFde Fde { get; set; }

        bool? FdeActive { get; set; }

        bool? FdeKeyPresent { get; set; }

        string FileSystem { get; set; }

        bool? HasServiceAccount { get; set; }

        string Hostname { get; set; }

        string Id { get; set; }

        string LastContact { get; set; }

        JumpCloud.SDK.V1.Models.IJcSystemMdm Mdm { get; set; }

        bool? MdmDep { get; set; }

        string MdmProfileIdentifier { get; set; }

        bool? MdmUserApproved { get; set; }

        string MdmVendor { get; set; }

        bool? ModifySshdConfig { get; set; }

        JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem[] NetworkInterfaces { get; set; }

        string OS { get; set; }

        string Organization { get; set; }

        string RemoteIP { get; set; }

        bool? SshRootEnabled { get; set; }

        JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem[] SshdParams { get; set; }

        string SystemInsightState { get; set; }

        JumpCloud.SDK.V1.Models.IJcSystemInsights SystemInsights { get; set; }

        int? SystemTimezone { get; set; }

        string[] Tags { get; set; }

        string TemplateName { get; set; }

        string Version { get; set; }

    }
}