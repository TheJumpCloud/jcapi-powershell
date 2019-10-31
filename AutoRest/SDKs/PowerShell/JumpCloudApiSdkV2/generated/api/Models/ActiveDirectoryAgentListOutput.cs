namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Active Directory Agent List Output</summary>
    public partial class ActiveDirectoryAgentListOutput :
        JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutput,
        JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal
    {

        /// <summary>Backing field for <see cref="ContactAt" /> property.</summary>
        private string _contactAt;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ContactAt { get => this._contactAt; set => this._contactAt = value; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectID of this Active Directory Agent.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="SourceIP" /> property.</summary>
        private string _sourceIP;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SourceIP { get => this._sourceIP; set => this._sourceIP = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ActiveDirectoryAgentListOutput" /> instance.</summary>
        public ActiveDirectoryAgentListOutput()
        {

        }
    }
    /// Active Directory Agent List Output
    public partial interface IActiveDirectoryAgentListOutput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"contactAt",
        PossibleTypes = new [] { typeof(string) })]
        string ContactAt { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }
        /// <summary>ObjectID of this Active Directory Agent.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of this Active Directory Agent.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"source_ip",
        PossibleTypes = new [] { typeof(string) })]
        string SourceIP { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Active Directory Agent List Output
    internal partial interface IActiveDirectoryAgentListOutputInternal

    {
        string ContactAt { get; set; }

        string Hostname { get; set; }
        /// <summary>ObjectID of this Active Directory Agent.</summary>
        string Id { get; set; }

        string SourceIP { get; set; }

        string State { get; set; }

        string Version { get; set; }

    }
}