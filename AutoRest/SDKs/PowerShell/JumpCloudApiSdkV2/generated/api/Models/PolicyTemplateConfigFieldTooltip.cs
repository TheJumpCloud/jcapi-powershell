namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class PolicyTemplateConfigFieldTooltip :
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltip,
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal
    {

        /// <summary>Internal Acessors for Variables</summary>
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipInternal.Variables { get => (this._variables = this._variables ?? new JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltipVariables()); set { {_variables = value;} } }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Template { get => this._template; set => this._template = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Icon; set => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Icon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Message; set => ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Message = value; }

        /// <summary>Backing field for <see cref="Variables" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables _variables;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables Variables { get => (this._variables = this._variables ?? new JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltipVariables()); set => this._variables = value; }

        /// <summary>Creates an new <see cref="PolicyTemplateConfigFieldTooltip" /> instance.</summary>
        public PolicyTemplateConfigFieldTooltip()
        {

        }
    }
    public partial interface IPolicyTemplateConfigFieldTooltip :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string Template { get; set; }

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
    internal partial interface IPolicyTemplateConfigFieldTooltipInternal

    {
        string Template { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables Variables { get; set; }

    }
}