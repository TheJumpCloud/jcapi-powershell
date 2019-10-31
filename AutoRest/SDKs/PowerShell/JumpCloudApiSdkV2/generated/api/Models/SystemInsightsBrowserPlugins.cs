namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Browser Plugins</summary>
    public partial class SystemInsightsBrowserPlugins :
        JumpCloudApiSdkV2.Models.ISystemInsightsBrowserPlugins,
        JumpCloudApiSdkV2.Models.ISystemInsightsBrowserPluginsInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DevelopmentRegion" /> property.</summary>
        private string _developmentRegion;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string DevelopmentRegion { get => this._developmentRegion; set => this._developmentRegion = value; }

        /// <summary>Backing field for <see cref="Disabled" /> property.</summary>
        private int? _disabled;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Disabled { get => this._disabled; set => this._disabled = value; }

        /// <summary>Backing field for <see cref="Identifier" /> property.</summary>
        private string _identifier;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Identifier { get => this._identifier; set => this._identifier = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Native" /> property.</summary>
        private int? _native;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Native { get => this._native; set => this._native = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="Sdk" /> property.</summary>
        private string _sdk;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Sdk { get => this._sdk; set => this._sdk = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Uid" /> property.</summary>
        private string _uid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Uid { get => this._uid; set => this._uid = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SystemInsightsBrowserPlugins" /> instance.</summary>
        public SystemInsightsBrowserPlugins()
        {

        }
    }
    /// System Insights Browser Plugins
    public partial interface ISystemInsightsBrowserPlugins :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"collection_time",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionTime { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"development_region",
        PossibleTypes = new [] { typeof(string) })]
        string DevelopmentRegion { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disabled",
        PossibleTypes = new [] { typeof(int) })]
        int? Disabled { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"identifier",
        PossibleTypes = new [] { typeof(string) })]
        string Identifier { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"native",
        PossibleTypes = new [] { typeof(int) })]
        int? Native { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sdk",
        PossibleTypes = new [] { typeof(string) })]
        string Sdk { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"uid",
        PossibleTypes = new [] { typeof(string) })]
        string Uid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System Insights Browser Plugins
    internal partial interface ISystemInsightsBrowserPluginsInternal

    {
        string CollectionTime { get; set; }

        string Description { get; set; }

        string DevelopmentRegion { get; set; }

        int? Disabled { get; set; }

        string Identifier { get; set; }

        string Name { get; set; }

        int? Native { get; set; }

        string Path { get; set; }

        string Sdk { get; set; }

        string SystemId { get; set; }

        string Uid { get; set; }

        string Version { get; set; }

    }
}