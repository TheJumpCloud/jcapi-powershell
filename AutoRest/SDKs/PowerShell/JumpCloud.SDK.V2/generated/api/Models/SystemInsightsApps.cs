namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Apps</summary>
    public partial class SystemInsightsApps :
        JumpCloud.SDK.V2.Models.ISystemInsightsApps,
        JumpCloud.SDK.V2.Models.ISystemInsightsAppsInternal
    {

        /// <summary>Backing field for <see cref="ApplescriptEnabled" /> property.</summary>
        private string _applescriptEnabled;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string ApplescriptEnabled { get => this._applescriptEnabled; set => this._applescriptEnabled = value; }

        /// <summary>Backing field for <see cref="BundleExecutable" /> property.</summary>
        private string _bundleExecutable;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BundleExecutable { get => this._bundleExecutable; set => this._bundleExecutable = value; }

        /// <summary>Backing field for <see cref="BundleIdentifier" /> property.</summary>
        private string _bundleIdentifier;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BundleIdentifier { get => this._bundleIdentifier; set => this._bundleIdentifier = value; }

        /// <summary>Backing field for <see cref="BundleName" /> property.</summary>
        private string _bundleName;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BundleName { get => this._bundleName; set => this._bundleName = value; }

        /// <summary>Backing field for <see cref="BundlePackageType" /> property.</summary>
        private string _bundlePackageType;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BundlePackageType { get => this._bundlePackageType; set => this._bundlePackageType = value; }

        /// <summary>Backing field for <see cref="BundleShortVersion" /> property.</summary>
        private string _bundleShortVersion;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BundleShortVersion { get => this._bundleShortVersion; set => this._bundleShortVersion = value; }

        /// <summary>Backing field for <see cref="BundleVersion" /> property.</summary>
        private string _bundleVersion;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string BundleVersion { get => this._bundleVersion; set => this._bundleVersion = value; }

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Compiler" /> property.</summary>
        private string _compiler;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Compiler { get => this._compiler; set => this._compiler = value; }

        /// <summary>Backing field for <see cref="Copyright" /> property.</summary>
        private string _copyright;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Copyright { get => this._copyright; set => this._copyright = value; }

        /// <summary>Backing field for <see cref="DevelopmentRegion" /> property.</summary>
        private string _developmentRegion;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string DevelopmentRegion { get => this._developmentRegion; set => this._developmentRegion = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Element" /> property.</summary>
        private string _element;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Element { get => this._element; set => this._element = value; }

        /// <summary>Backing field for <see cref="Environment" /> property.</summary>
        private string _environment;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Environment { get => this._environment; set => this._environment = value; }

        /// <summary>Backing field for <see cref="InfoString" /> property.</summary>
        private string _infoString;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InfoString { get => this._infoString; set => this._infoString = value; }

        /// <summary>Backing field for <see cref="LastOpenedTime" /> property.</summary>
        private float? _lastOpenedTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public float? LastOpenedTime { get => this._lastOpenedTime; set => this._lastOpenedTime = value; }

        /// <summary>Backing field for <see cref="MinimumSystemVersion" /> property.</summary>
        private string _minimumSystemVersion;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string MinimumSystemVersion { get => this._minimumSystemVersion; set => this._minimumSystemVersion = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Creates an new <see cref="SystemInsightsApps" /> instance.</summary>
        public SystemInsightsApps()
        {

        }
    }
    /// System Insights Apps
    public partial interface ISystemInsightsApps :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"applescript_enabled",
        PossibleTypes = new [] { typeof(string) })]
        string ApplescriptEnabled { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bundle_executable",
        PossibleTypes = new [] { typeof(string) })]
        string BundleExecutable { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bundle_identifier",
        PossibleTypes = new [] { typeof(string) })]
        string BundleIdentifier { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bundle_name",
        PossibleTypes = new [] { typeof(string) })]
        string BundleName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bundle_package_type",
        PossibleTypes = new [] { typeof(string) })]
        string BundlePackageType { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bundle_short_version",
        PossibleTypes = new [] { typeof(string) })]
        string BundleShortVersion { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"bundle_version",
        PossibleTypes = new [] { typeof(string) })]
        string BundleVersion { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }

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
        SerializedName = @"compiler",
        PossibleTypes = new [] { typeof(string) })]
        string Compiler { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"copyright",
        PossibleTypes = new [] { typeof(string) })]
        string Copyright { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"development_region",
        PossibleTypes = new [] { typeof(string) })]
        string DevelopmentRegion { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"display_name",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"element",
        PossibleTypes = new [] { typeof(string) })]
        string Element { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"environment",
        PossibleTypes = new [] { typeof(string) })]
        string Environment { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"info_string",
        PossibleTypes = new [] { typeof(string) })]
        string InfoString { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"last_opened_time",
        PossibleTypes = new [] { typeof(float) })]
        float? LastOpenedTime { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"minimum_system_version",
        PossibleTypes = new [] { typeof(string) })]
        string MinimumSystemVersion { get; set; }

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
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

    }
    /// System Insights Apps
    internal partial interface ISystemInsightsAppsInternal

    {
        string ApplescriptEnabled { get; set; }

        string BundleExecutable { get; set; }

        string BundleIdentifier { get; set; }

        string BundleName { get; set; }

        string BundlePackageType { get; set; }

        string BundleShortVersion { get; set; }

        string BundleVersion { get; set; }

        string Category { get; set; }

        string CollectionTime { get; set; }

        string Compiler { get; set; }

        string Copyright { get; set; }

        string DevelopmentRegion { get; set; }

        string DisplayName { get; set; }

        string Element { get; set; }

        string Environment { get; set; }

        string InfoString { get; set; }

        float? LastOpenedTime { get; set; }

        string MinimumSystemVersion { get; set; }

        string Name { get; set; }

        string Path { get; set; }

        string SystemId { get; set; }

    }
}