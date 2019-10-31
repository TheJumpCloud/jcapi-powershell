namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>PolicyTemplateConfigField</summary>
    public partial class PolicyTemplateConfigField :
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField,
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal
    {

        /// <summary>Backing field for <see cref="DefaultValue" /> property.</summary>
        private string _defaultValue;

        /// <summary>The default value for this field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string DefaultValue { get => this._defaultValue; set => this._defaultValue = value; }

        /// <summary>Backing field for <see cref="DisplayOptions" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldDisplayOptions _displayOptions;

        /// <summary>The options that correspond to the display_type.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldDisplayOptions DisplayOptions { get => (this._displayOptions = this._displayOptions ?? new JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldDisplayOptions()); set => this._displayOptions = value; }

        /// <summary>Backing field for <see cref="DisplayType" /> property.</summary>
        private string _displayType;

        /// <summary>The default rendering for this field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string DisplayType { get => this._displayType; set => this._displayType = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a Policy Template Configuration Field</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Tooltip</summary>
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltip JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal.Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltip()); set { {_tooltip = value;} } }

        /// <summary>Internal Acessors for TooltipVariables</summary>
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal.TooltipVariables { get => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).Variables; set => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).Variables = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        /// <summary>The default label for this field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>A unique name identifying this config field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Position" /> property.</summary>
        private float? _position;

        /// <summary>The default position to render this field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public float? Position { get => this._position; set => this._position = value; }

        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        /// <summary>If an admin is allowed to modify this field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? ReadOnly { get => this._readOnly; set => this._readOnly = value; }

        /// <summary>Backing field for <see cref="Required" /> property.</summary>
        private bool? _required;

        /// <summary>If this field is required for this field.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public bool? Required { get => this._required; set => this._required = value; }

        /// <summary>Backing field for <see cref="Tooltip" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltip _tooltip;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltip Tooltip { get => (this._tooltip = this._tooltip ?? new JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltip()); set => this._tooltip = value; }

        /// <summary>FIXME: Property TooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string TooltipTemplate { get => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).Template; set => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).Template = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).VariableIcon; set => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).VariableIcon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).VariableMessage; set => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal)Tooltip).VariableMessage = value; }

        /// <summary>Creates an new <see cref="PolicyTemplateConfigField" /> instance.</summary>
        public PolicyTemplateConfigField()
        {

        }
    }
    /// PolicyTemplateConfigField
    public partial interface IPolicyTemplateConfigField :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The default value for this field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default value for this field.",
        SerializedName = @"defaultValue",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultValue { get; set; }
        /// <summary>The options that correspond to the display_type.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The options that correspond to the display_type.",
        SerializedName = @"displayOptions",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldDisplayOptions) })]
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldDisplayOptions DisplayOptions { get; set; }
        /// <summary>The default rendering for this field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default rendering for this field.",
        SerializedName = @"displayType",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayType { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Template Configuration Field</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy Template Configuration Field",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The default label for this field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default label for this field.",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }
        /// <summary>A unique name identifying this config field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A unique name identifying this config field.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The default position to render this field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default position to render this field.",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(float) })]
        float? Position { get; set; }
        /// <summary>If an admin is allowed to modify this field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If an admin is allowed to modify this field.",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReadOnly { get; set; }
        /// <summary>If this field is required for this field.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If this field is required for this field.",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Required { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string TooltipTemplate { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string VariableIcon { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string VariableMessage { get; set; }

    }
    /// PolicyTemplateConfigField
    internal partial interface IPolicyTemplateConfigFieldInternal

    {
        /// <summary>The default value for this field.</summary>
        string DefaultValue { get; set; }
        /// <summary>The options that correspond to the display_type.</summary>
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldDisplayOptions DisplayOptions { get; set; }
        /// <summary>The default rendering for this field.</summary>
        string DisplayType { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Template Configuration Field</summary>
        string Id { get; set; }
        /// <summary>The default label for this field.</summary>
        string Label { get; set; }
        /// <summary>A unique name identifying this config field.</summary>
        string Name { get; set; }
        /// <summary>The default position to render this field.</summary>
        float? Position { get; set; }
        /// <summary>If an admin is allowed to modify this field.</summary>
        bool? ReadOnly { get; set; }
        /// <summary>If this field is required for this field.</summary>
        bool? Required { get; set; }

        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltip Tooltip { get; set; }

        string TooltipTemplate { get; set; }

        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables TooltipVariables { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

    }
}