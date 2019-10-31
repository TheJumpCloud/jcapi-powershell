namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights OS Version</summary>
    public partial class SystemInsightsOSVersion :
        JumpCloudApiSdkV2.Models.ISystemInsightsOSVersion,
        JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal
    {

        /// <summary>Backing field for <see cref="Build" /> property.</summary>
        private string _build;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Build { get => this._build; set => this._build = value; }

        /// <summary>Backing field for <see cref="Codename" /> property.</summary>
        private string _codename;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Codename { get => this._codename; set => this._codename = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="InstallDate" /> property.</summary>
        private string _installDate;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string InstallDate { get => this._installDate; set => this._installDate = value; }

        /// <summary>Backing field for <see cref="Major" /> property.</summary>
        private int? _major;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Major { get => this._major; set => this._major = value; }

        /// <summary>Backing field for <see cref="Minor" /> property.</summary>
        private int? _minor;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Minor { get => this._minor; set => this._minor = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Patch" /> property.</summary>
        private int? _patch;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Patch { get => this._patch; set => this._patch = value; }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private string _platform;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Platform { get => this._platform; set => this._platform = value; }

        /// <summary>Backing field for <see cref="PlatformLike" /> property.</summary>
        private string _platformLike;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string PlatformLike { get => this._platformLike; set => this._platformLike = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SystemInsightsOSVersion" /> instance.</summary>
        public SystemInsightsOSVersion()
        {

        }
    }
    /// System Insights OS Version
    public partial interface ISystemInsightsOSVersion :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"build",
        PossibleTypes = new [] { typeof(string) })]
        string Build { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"codename",
        PossibleTypes = new [] { typeof(string) })]
        string Codename { get; set; }

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
        SerializedName = @"install_date",
        PossibleTypes = new [] { typeof(string) })]
        string InstallDate { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"major",
        PossibleTypes = new [] { typeof(int) })]
        int? Major { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minor",
        PossibleTypes = new [] { typeof(int) })]
        int? Minor { get; set; }

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
        SerializedName = @"patch",
        PossibleTypes = new [] { typeof(int) })]
        int? Patch { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"platform",
        PossibleTypes = new [] { typeof(string) })]
        string Platform { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"platform_like",
        PossibleTypes = new [] { typeof(string) })]
        string PlatformLike { get; set; }

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
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System Insights OS Version
    internal partial interface ISystemInsightsOSVersionInternal

    {
        string Build { get; set; }

        string Codename { get; set; }

        string CollectionTime { get; set; }

        string InstallDate { get; set; }

        int? Major { get; set; }

        int? Minor { get; set; }

        string Name { get; set; }

        int? Patch { get; set; }

        string Platform { get; set; }

        string PlatformLike { get; set; }

        string SystemId { get; set; }

        string Version { get; set; }

    }
}