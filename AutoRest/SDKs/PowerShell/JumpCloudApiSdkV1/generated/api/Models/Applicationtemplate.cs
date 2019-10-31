namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>ApplicationTemplate</summary>
    public partial class Applicationtemplate :
        JumpCloudApiSdkV1.Models.IApplicationtemplate,
        JumpCloudApiSdkV1.Models.IApplicationtemplateInternal
    {

        /// <summary>Backing field for <see cref="Beta" /> property.</summary>
        private bool? _beta;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Beta { get => this._beta; set => this._beta = value; }

        /// <summary>Backing field for <see cref="Color" /> property.</summary>
        private string _color;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Color { get => this._color; set => this._color = value; }

        /// <summary>Backing field for <see cref="Config" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationtemplateConfig _config;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IApplicationtemplateConfig Config { get => (this._config = this._config ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateConfig()); set => this._config = value; }

        /// <summary>Backing field for <see cref="DisplayLabel" /> property.</summary>
        private string _displayLabel;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string DisplayLabel { get => this._displayLabel; set => this._displayLabel = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LearnMore" /> property.</summary>
        private string _learnMore;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string LearnMore { get => this._learnMore; set => this._learnMore = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SsoUrl" /> property.</summary>
        private string _ssoUrl;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string SsoUrl { get => this._ssoUrl; set => this._ssoUrl = value; }

        /// <summary>Creates an new <see cref="Applicationtemplate" /> instance.</summary>
        public Applicationtemplate()
        {

        }
    }
    /// ApplicationTemplate
    public partial interface IApplicationtemplate :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"beta",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Beta { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"color",
        PossibleTypes = new [] { typeof(string) })]
        string Color { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"config",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IApplicationtemplateConfig) })]
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfig Config { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayLabel",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayLabel { get; set; }

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
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"learnMore",
        PossibleTypes = new [] { typeof(string) })]
        string LearnMore { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ssoUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SsoUrl { get; set; }

    }
    /// ApplicationTemplate
    internal partial interface IApplicationtemplateInternal

    {
        bool? Beta { get; set; }

        string Color { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationtemplateConfig Config { get; set; }

        string DisplayLabel { get; set; }

        string DisplayName { get; set; }

        string Id { get; set; }

        string LearnMore { get; set; }

        string Name { get; set; }

        string SsoUrl { get; set; }

    }
}