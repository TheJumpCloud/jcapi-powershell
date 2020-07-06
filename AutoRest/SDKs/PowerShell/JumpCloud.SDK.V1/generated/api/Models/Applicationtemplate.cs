// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>ApplicationTemplate</summary>
    public partial class Applicationtemplate :
        JumpCloud.SDK.V1.Models.IApplicationtemplate,
        JumpCloud.SDK.V1.Models.IApplicationtemplateInternal
    {

        /// <summary>Backing field for <see cref="Beta" /> property.</summary>
        private bool? _beta;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Beta { get => this._beta; set => this._beta = value; }

        /// <summary>Backing field for <see cref="Color" /> property.</summary>
        private string _color;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Color { get => this._color; set => this._color = value; }

        /// <summary>Backing field for <see cref="Config" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfig _config;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IApplicationtemplateConfig Config { get => (this._config = this._config ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfig()); set => this._config = value; }

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

        /// <summary>Backing field for <see cref="IsConfigured" /> property.</summary>
        private bool? _isConfigured;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? IsConfigured { get => this._isConfigured; set => this._isConfigured = value; }

        /// <summary>Backing field for <see cref="Jit" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateJit _jit;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateJit Jit { get => (this._jit = this._jit ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateJit()); set => this._jit = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes JitAttributes { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateJitInternal)Jit).Attributes; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateJitInternal)Jit).Attributes = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? JitCreateOnly { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateJitInternal)Jit).CreateOnly; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateJitInternal)Jit).CreateOnly = value; }

        /// <summary>Internal Acessors for Jit</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateJit JumpCloud.SDK.V1.Models.IApplicationtemplateInternal.Jit { get => (this._jit = this._jit ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateJit()); set { {_jit = value;} } }

        /// <summary>Internal Acessors for Logo</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateLogo JumpCloud.SDK.V1.Models.IApplicationtemplateInternal.Logo { get => (this._logo = this._logo ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateLogo()); set { {_logo = value;} } }

        /// <summary>Backing field for <see cref="Keywords" /> property.</summary>
        private string[] _keywords;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string[] Keywords { get => this._keywords; set => this._keywords = value; }

        /// <summary>Backing field for <see cref="LearnMore" /> property.</summary>
        private string _learnMore;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string LearnMore { get => this._learnMore; set => this._learnMore = value; }

        /// <summary>Backing field for <see cref="Logo" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateLogo _logo;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateLogo Logo { get => (this._logo = this._logo ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateLogo()); set => this._logo = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string LogoUrl { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateLogoInternal)Logo).Url; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateLogoInternal)Logo).Url = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SsoUrl" /> property.</summary>
        private string _ssoUrl;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string SsoUrl { get => this._ssoUrl; set => this._ssoUrl = value; }

        /// <summary>Backing field for <see cref="Test" /> property.</summary>
        private string _test;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Test { get => this._test; set => this._test = value; }

        /// <summary>Creates an new <see cref="Applicationtemplate" /> instance.</summary>
        public Applicationtemplate()
        {

        }
    }
    /// ApplicationTemplate
    public partial interface IApplicationtemplate :
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
        SerializedName = @"color",
        PossibleTypes = new [] { typeof(string) })]
        string Color { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"config",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IApplicationtemplateConfig) })]
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfig Config { get; set; }

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
        SerializedName = @"isConfigured",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsConfigured { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes) })]
        JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes JitAttributes { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"createOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? JitCreateOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"keywords",
        PossibleTypes = new [] { typeof(string) })]
        string[] Keywords { get; set; }

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
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string LogoUrl { get; set; }

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
        SerializedName = @"ssoUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SsoUrl { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"test",
        PossibleTypes = new [] { typeof(string) })]
        string Test { get; set; }

    }
    /// ApplicationTemplate
    internal partial interface IApplicationtemplateInternal

    {
        bool? Beta { get; set; }

        string Color { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfig Config { get; set; }

        string DisplayLabel { get; set; }

        string DisplayName { get; set; }

        string Id { get; set; }

        bool? IsConfigured { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateJit Jit { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateJitAttributes JitAttributes { get; set; }

        bool? JitCreateOnly { get; set; }

        string[] Keywords { get; set; }

        string LearnMore { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateLogo Logo { get; set; }

        string LogoUrl { get; set; }

        string Name { get; set; }

        string SsoUrl { get; set; }

        string Test { get; set; }

    }
}