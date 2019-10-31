namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigIdpPrivateKey :
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKey,
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal
    {

        /// <summary>Internal Acessors for Tooltip</summary>
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltip JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal.Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateConfigIdpPrivateKeyTooltip()); set { {_tooltip = value;} } }

        /// <summary>Internal Acessors for TooltipVariables</summary>
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal.TooltipVariables { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).Variables; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).Variables = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>Backing field for <see cref="Options" /> property.</summary>
        private string _options;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Options { get => this._options; set => this._options = value; }

        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private int? _position;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? Position { get => this._position; set => this._position = value; }

        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? ReadOnly { get => this._readOnly; set => this._readOnly = value; }

        /// <summary>Backing field for <see cref="Required" /> property.</summary>
        private bool? _required;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Required { get => this._required; set => this._required = value; }

        /// <summary>Backing field for <see cref="Toggle" /> property.</summary>
        private string _toggle;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Toggle { get => this._toggle; set => this._toggle = value; }

        /// <summary>Backing field for <see cref="Tooltip" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltip _tooltip;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltip Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateConfigIdpPrivateKeyTooltip()); set => this._tooltip = value; }

        /// <summary>FIXME: Property TooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string TooltipTemplate { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).Template; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).Template = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).VariableIcon; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).VariableIcon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).VariableMessage; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal)Tooltip).VariableMessage = value; }

        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private bool? _visible;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Visible { get => this._visible; set => this._visible = value; }

        /// <summary>Creates an new <see cref="ApplicationtemplateConfigIdpPrivateKey" /> instance.</summary>
        public ApplicationtemplateConfigIdpPrivateKey()
        {

        }
    }
    public partial interface IApplicationtemplateConfigIdpPrivateKey :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string Options { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? Position { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReadOnly { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Required { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string Toggle { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string TooltipTemplate { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string VariableIcon { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string VariableMessage { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Visible { get; set; }

    }
    internal partial interface IApplicationtemplateConfigIdpPrivateKeyInternal

    {
        string Label { get; set; }

        string Options { get; set; }

        int? Position { get; set; }

        bool? ReadOnly { get; set; }

        bool? Required { get; set; }

        string Toggle { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltip Tooltip { get; set; }

        string TooltipTemplate { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables TooltipVariables { get; set; }

        string Type { get; set; }

        string Value { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        bool? Visible { get; set; }

    }
}