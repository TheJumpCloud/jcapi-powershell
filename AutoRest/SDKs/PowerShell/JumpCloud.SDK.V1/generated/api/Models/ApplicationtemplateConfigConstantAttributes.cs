namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigConstantAttributes :
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributes,
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal
    {

        /// <summary>Internal Acessors for Tooltip</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltip JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal.Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigConstantAttributesTooltip()); set { {_tooltip = value;} } }

        /// <summary>Internal Acessors for TooltipVariables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal.TooltipVariables { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).Variables; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).Variables = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>Backing field for <see cref="Mutable" /> property.</summary>
        private bool? _mutable;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Mutable { get => this._mutable; set => this._mutable = value; }

        /// <summary>Backing field for <see cref="Options" /> property.</summary>
        private string _options;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Options { get => this._options; set => this._options = value; }

        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private int? _position;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? Position { get => this._position; set => this._position = value; }

        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? ReadOnly { get => this._readOnly; set => this._readOnly = value; }

        /// <summary>Backing field for <see cref="Required" /> property.</summary>
        private bool? _required;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Required { get => this._required; set => this._required = value; }

        /// <summary>Backing field for <see cref="Toggle" /> property.</summary>
        private string _toggle;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Toggle { get => this._toggle; set => this._toggle = value; }

        /// <summary>Backing field for <see cref="Tooltip" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltip _tooltip;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltip Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigConstantAttributesTooltip()); set => this._tooltip = value; }

        /// <summary>FIXME: Property TooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string TooltipTemplate { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).Template; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).Template = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem[] _value;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem[] Value { get => this._value; set => this._value = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).VariableIcon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).VariableIcon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).VariableMessage; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipInternal)Tooltip).VariableMessage = value; }

        /// <summary>Backing field for <see cref="Visible" /> property.</summary>
        private bool? _visible;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Visible { get => this._visible; set => this._visible = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationtemplateConfigConstantAttributes" /> instance.
        /// </summary>
        public ApplicationtemplateConfigConstantAttributes()
        {

        }
    }
    public partial interface IApplicationtemplateConfigConstantAttributes :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"mutable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Mutable { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string Options { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? Position { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Required { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string Toggle { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string TooltipTemplate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem) })]
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem[] Value { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string VariableIcon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string VariableMessage { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Visible { get; set; }

    }
    internal partial interface IApplicationtemplateConfigConstantAttributesInternal

    {
        string Label { get; set; }

        bool? Mutable { get; set; }

        string Options { get; set; }

        int? Position { get; set; }

        bool? ReadOnly { get; set; }

        bool? Required { get; set; }

        string Toggle { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltip Tooltip { get; set; }

        string TooltipTemplate { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipVariables TooltipVariables { get; set; }

        string Type { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem[] Value { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        bool? Visible { get; set; }

    }
}