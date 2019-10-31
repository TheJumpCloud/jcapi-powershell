namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>SystemPut</summary>
    public partial class Systemput :
        JumpCloudApiSdkV1.Models.ISystemput,
        JumpCloudApiSdkV1.Models.ISystemputInternal
    {

        /// <summary>Backing field for <see cref="AgentBoundMessages" /> property.</summary>
        private JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem[] _agentBoundMessages;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem[] AgentBoundMessages { get => this._agentBoundMessages; set => this._agentBoundMessages = value; }

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

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private string[] _tags;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string[] Tags { get => this._tags; set => this._tags = value; }

        /// <summary>Creates an new <see cref="Systemput" /> instance.</summary>
        public Systemput()
        {

        }
    }
    /// SystemPut
    public partial interface ISystemput :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"agentBoundMessages",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem) })]
        JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem[] AgentBoundMessages { get; set; }

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
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tags { get; set; }

    }
    /// SystemPut
    internal partial interface ISystemputInternal

    {
        JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem[] AgentBoundMessages { get; set; }

        bool? AllowMultiFactorAuthentication { get; set; }

        bool? AllowPublicKeyAuthentication { get; set; }

        bool? AllowSshPasswordAuthentication { get; set; }

        bool? AllowSshRootLogin { get; set; }

        string DisplayName { get; set; }

        string[] Tags { get; set; }

    }
}