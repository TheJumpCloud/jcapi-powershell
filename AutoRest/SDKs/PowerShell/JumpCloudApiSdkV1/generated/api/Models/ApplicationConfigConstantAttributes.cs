namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationConfigConstantAttributes :
        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributes,
        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesInternal
    {

        /// <summary>Internal Acessors for Tooltip</summary>
        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltip JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesInternal.Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloudApiSdkV1.Models.ApplicationConfigConstantAttributesTooltip()); set { {_tooltip = value;} } }

        /// <summary>Internal Acessors for TooltipVariables</summary>
        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipVariables JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesInternal.TooltipVariables { get => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).Variables; set => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).Variables = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>Backing field for <see cref="Mutable" /> property.</summary>
        private bool? _mutable;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Mutable { get => this._mutable; set => this._mutable = value; }

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
        private JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltip _tooltip;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltip Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloudApiSdkV1.Models.ApplicationConfigConstantAttributesTooltip()); set => this._tooltip = value; }

        /// <summary>FIXME: Property TooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string TooltipTemplate { get => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).Template; set => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).Template = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesValueItem[] _value;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesValueItem[] Value { get => this._value; set => this._value = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).VariableIcon; set => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).VariableIcon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).VariableMessage; set => ((JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipInternal)Tooltip).VariableMessage = value; }

        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private bool? _visible;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Visible { get => this._visible; set => this._visible = value; }

        /// <summary>Creates an new <see cref="ApplicationConfigConstantAttributes" /> instance.</summary>
        public ApplicationConfigConstantAttributes()
        {

        }
    }
    public partial interface IApplicationConfigConstantAttributes :
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
        SerializedName = @"mutable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Mutable { get; set; }

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
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesValueItem) })]
        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesValueItem[] Value { get; set; }

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
    internal partial interface IApplicationConfigConstantAttributesInternal

    {
        string Label { get; set; }

        bool? Mutable { get; set; }

        string Options { get; set; }

        int? Position { get; set; }

        bool? ReadOnly { get; set; }

        bool? Required { get; set; }

        string Toggle { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltip Tooltip { get; set; }

        string TooltipTemplate { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesTooltipVariables TooltipVariables { get; set; }

        string Type { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationConfigConstantAttributesValueItem[] Value { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        bool? Visible { get; set; }

    }
}