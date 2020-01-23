namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PolicyTemplateConfigFieldTooltip :
        JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltip,
        JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipInternal
    {

        /// <summary>Internal Acessors for Variables</summary>
        JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariables JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipInternal.Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTooltipVariables()); set { {_variables = value;} } }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Template { get => this._template; set => this._template = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Icon; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Icon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Message; set => ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal)Variables).Message = value; }

        /// <summary>Backing field for <see cref="Variables" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariables _variables;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariables Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTooltipVariables()); set => this._variables = value; }

        /// <summary>Creates an new <see cref="PolicyTemplateConfigFieldTooltip" /> instance.</summary>
        public PolicyTemplateConfigFieldTooltip()
        {

        }
    }
    public partial interface IPolicyTemplateConfigFieldTooltip :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string Template { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string VariableIcon { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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

        JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariables Variables { get; set; }

    }
}