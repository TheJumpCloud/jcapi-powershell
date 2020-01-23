namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>Application</summary>
    public partial class Application :
        JumpCloud.SDK.V1.Models.IApplication,
        JumpCloud.SDK.V1.Models.IApplicationInternal
    {

        /// <summary>Backing field for <see cref="Beta" /> property.</summary>
        private bool? _beta;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Beta { get => this._beta; set => this._beta = value; }

        /// <summary>Backing field for <see cref="Config" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationConfig _config;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IApplicationConfig Config { get => (this._config = this._config ?? new JumpCloud.SDK.V1.Models.ApplicationConfig()); set => this._config = value; }

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="DisplayLabel" /> property.</summary>
        private string _displayLabel;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string DisplayLabel { get => this._displayLabel; set => this._displayLabel = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LearnMore" /> property.</summary>
        private string _learnMore;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string LearnMore { get => this._learnMore; set => this._learnMore = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="SsoUrl" /> property.</summary>
        private string _ssoUrl;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string SsoUrl { get => this._ssoUrl; set => this._ssoUrl = value; }

        /// <summary>Creates an new <see cref="Application" /> instance.</summary>
        public Application()
        {

        }
    }
    /// Application
    public partial interface IApplication :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"beta",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Beta { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"config",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IApplicationConfig) })]
        JumpCloud.SDK.V1.Models.IApplicationConfig Config { get; set; }

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
        SerializedName = @"displayLabel",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayLabel { get; set; }

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
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"learnMore",
        PossibleTypes = new [] { typeof(string) })]
        string LearnMore { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

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
        SerializedName = @"ssoUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SsoUrl { get; set; }

    }
    /// Application
    internal partial interface IApplicationInternal

    {
        bool? Beta { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationConfig Config { get; set; }

        string Created { get; set; }

        string DisplayLabel { get; set; }

        string DisplayName { get; set; }

        string Id { get; set; }

        string LearnMore { get; set; }

        string Name { get; set; }

        string Organization { get; set; }

        string SsoUrl { get; set; }

    }
}