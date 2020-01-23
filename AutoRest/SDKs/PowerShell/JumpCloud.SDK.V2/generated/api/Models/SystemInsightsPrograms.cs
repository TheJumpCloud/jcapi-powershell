namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Programs</summary>
    public partial class SystemInsightsPrograms :
        JumpCloud.SDK.V2.Models.ISystemInsightsPrograms,
        JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="IdentifyingNumber" /> property.</summary>
        private string _identifyingNumber;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string IdentifyingNumber { get => this._identifyingNumber; set => this._identifyingNumber = value; }

        /// <summary>Backing field for <see cref="InstallDate" /> property.</summary>
        private string _installDate;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InstallDate { get => this._installDate; set => this._installDate = value; }

        /// <summary>Backing field for <see cref="InstallLocation" /> property.</summary>
        private string _installLocation;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InstallLocation { get => this._installLocation; set => this._installLocation = value; }

        /// <summary>Backing field for <see cref="InstallSource" /> property.</summary>
        private string _installSource;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string InstallSource { get => this._installSource; set => this._installSource = value; }

        /// <summary>Backing field for <see cref="Language" /> property.</summary>
        private string _language;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Language { get => this._language; set => this._language = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="UninstallString" /> property.</summary>
        private string _uninstallString;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string UninstallString { get => this._uninstallString; set => this._uninstallString = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SystemInsightsPrograms" /> instance.</summary>
        public SystemInsightsPrograms()
        {

        }
    }
    /// System Insights Programs
    public partial interface ISystemInsightsPrograms :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
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
        SerializedName = @"identifying_number",
        PossibleTypes = new [] { typeof(string) })]
        string IdentifyingNumber { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"install_date",
        PossibleTypes = new [] { typeof(string) })]
        string InstallDate { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"install_location",
        PossibleTypes = new [] { typeof(string) })]
        string InstallLocation { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"install_source",
        PossibleTypes = new [] { typeof(string) })]
        string InstallSource { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"language",
        PossibleTypes = new [] { typeof(string) })]
        string Language { get; set; }

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
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }

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
        SerializedName = @"uninstall_string",
        PossibleTypes = new [] { typeof(string) })]
        string UninstallString { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System Insights Programs
    internal partial interface ISystemInsightsProgramsInternal

    {
        string CollectionTime { get; set; }

        string IdentifyingNumber { get; set; }

        string InstallDate { get; set; }

        string InstallLocation { get; set; }

        string InstallSource { get; set; }

        string Language { get; set; }

        string Name { get; set; }

        string Publisher { get; set; }

        string SystemId { get; set; }

        string UninstallString { get; set; }

        string Version { get; set; }

    }
}