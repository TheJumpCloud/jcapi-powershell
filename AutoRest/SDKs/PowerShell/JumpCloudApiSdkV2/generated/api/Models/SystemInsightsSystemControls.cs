namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights System Controls</summary>
    public partial class SystemInsightsSystemControls :
        JumpCloudApiSdkV2.Models.ISystemInsightsSystemControls,
        JumpCloudApiSdkV2.Models.ISystemInsightsSystemControlsInternal
    {

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="ConfigValue" /> property.</summary>
        private string _configValue;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ConfigValue { get => this._configValue; set => this._configValue = value; }

        /// <summary>Backing field for <see cref="CurrentValue" /> property.</summary>
        private string _currentValue;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CurrentValue { get => this._currentValue; set => this._currentValue = value; }

        /// <summary>Backing field for <see cref="FieldName" /> property.</summary>
        private string _fieldName;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string FieldName { get => this._fieldName; set => this._fieldName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Oid" /> property.</summary>
        private string _oid;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Oid { get => this._oid; set => this._oid = value; }

        /// <summary>Backing field for <see cref="Subsystem" /> property.</summary>
        private string _subsystem;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Subsystem { get => this._subsystem; set => this._subsystem = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemInsightsSystemControls" /> instance.</summary>
        public SystemInsightsSystemControls()
        {

        }
    }
    /// System Insights System Controls
    public partial interface ISystemInsightsSystemControls :
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
        SerializedName = @"config_value",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigValue { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"current_value",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentValue { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"field_name",
        PossibleTypes = new [] { typeof(string) })]
        string FieldName { get; set; }

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
        SerializedName = @"oid",
        PossibleTypes = new [] { typeof(string) })]
        string Oid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subsystem",
        PossibleTypes = new [] { typeof(string) })]
        string Subsystem { get; set; }

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
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// System Insights System Controls
    internal partial interface ISystemInsightsSystemControlsInternal

    {
        string CollectionTime { get; set; }

        string ConfigValue { get; set; }

        string CurrentValue { get; set; }

        string FieldName { get; set; }

        string Name { get; set; }

        string Oid { get; set; }

        string Subsystem { get; set; }

        string SystemId { get; set; }

        string Type { get; set; }

    }
}