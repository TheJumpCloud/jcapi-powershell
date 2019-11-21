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

        /// <summary>Backing field for <see cref="IsConfigured" /> property.</summary>
        private bool? _isConfigured;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? IsConfigured { get => this._isConfigured; set => this._isConfigured = value; }

        /// <summary>Backing field for <see cref="Jit" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationtemplateJit _jit;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IApplicationtemplateJit Jit { get => (this._jit = this._jit ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateJit()); set => this._jit = value; }

        /// <summary>FIXME: Property JitAttributes is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes JitAttributes { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateJitInternal)Jit).Attributes; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateJitInternal)Jit).Attributes = value; }

        /// <summary>FIXME: Property JitCreateOnly is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? JitCreateOnly { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateJitInternal)Jit).CreateOnly; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateJitInternal)Jit).CreateOnly = value; }

        /// <summary>Internal Acessors for Jit</summary>
        JumpCloudApiSdkV1.Models.IApplicationtemplateJit JumpCloudApiSdkV1.Models.IApplicationtemplateInternal.Jit { get => (this._jit = this._jit ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateJit()); set { {_jit = value;} } }

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
        SerializedName = @"isConfigured",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsConfigured { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes) })]
        JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes JitAttributes { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"createOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? JitCreateOnly { get; set; }

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

        bool? IsConfigured { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationtemplateJit Jit { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationtemplateJitAttributes JitAttributes { get; set; }

        bool? JitCreateOnly { get; set; }

        string LearnMore { get; set; }

        string Name { get; set; }

        string SsoUrl { get; set; }

    }
}