namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Firefox Addons</summary>
    public partial class SystemInsightsFirefoxAddons :
        JumpCloud.SDK.V2.Models.ISystemInsightsFirefoxAddons,
        JumpCloud.SDK.V2.Models.ISystemInsightsFirefoxAddonsInternal
    {

        /// <summary>Backing field for <see cref="Active" /> property.</summary>
        private int? _active;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Active { get => this._active; set => this._active = value; }

        /// <summary>Backing field for <see cref="Autoupdate" /> property.</summary>
        private int? _autoupdate;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Autoupdate { get => this._autoupdate; set => this._autoupdate = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Creator" /> property.</summary>
        private string _creator;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Creator { get => this._creator; set => this._creator = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Disabled" /> property.</summary>
        private int? _disabled;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Disabled { get => this._disabled; set => this._disabled = value; }

        /// <summary>Backing field for <see cref="Identifier" /> property.</summary>
        private string _identifier;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Identifier { get => this._identifier; set => this._identifier = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="SourceUrl" /> property.</summary>
        private string _sourceUrl;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SourceUrl { get => this._sourceUrl; set => this._sourceUrl = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Uid" /> property.</summary>
        private string _uid;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Uid { get => this._uid; set => this._uid = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private int? _visible;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? Visible { get => this._visible; set => this._visible = value; }

        /// <summary>Creates an new <see cref="SystemInsightsFirefoxAddons" /> instance.</summary>
        public SystemInsightsFirefoxAddons()
        {

        }
    }
    /// System Insights Firefox Addons
    public partial interface ISystemInsightsFirefoxAddons :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"active",
        PossibleTypes = new [] { typeof(int) })]
        int? Active { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"autoupdate",
        PossibleTypes = new [] { typeof(int) })]
        int? Autoupdate { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"collection_time",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionTime { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"creator",
        PossibleTypes = new [] { typeof(string) })]
        string Creator { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"disabled",
        PossibleTypes = new [] { typeof(int) })]
        int? Disabled { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"identifier",
        PossibleTypes = new [] { typeof(string) })]
        string Identifier { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"source_url",
        PossibleTypes = new [] { typeof(string) })]
        string SourceUrl { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"uid",
        PossibleTypes = new [] { typeof(string) })]
        string Uid { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(int) })]
        int? Visible { get; set; }

    }
    /// System Insights Firefox Addons
    internal partial interface ISystemInsightsFirefoxAddonsInternal

    {
        int? Active { get; set; }

        int? Autoupdate { get; set; }

        string CollectionTime { get; set; }

        string Creator { get; set; }

        string Description { get; set; }

        int? Disabled { get; set; }

        string Identifier { get; set; }

        string Location { get; set; }

        string Name { get; set; }

        string Path { get; set; }

        string SourceUrl { get; set; }

        string SystemId { get; set; }

        string Type { get; set; }

        string Uid { get; set; }

        string Version { get; set; }

        int? Visible { get; set; }

    }
}