// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigSpEntityIdTooltip :
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltip,
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipInternal
    {

        /// <summary>Internal Acessors for Variables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipInternal.Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityIdTooltipVariables()); set { {_variables = value;} } }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Template { get => this._template; set => this._template = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Icon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Icon = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Message; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Message = value; }

        /// <summary>Backing field for <see cref="Variables" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables _variables;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityIdTooltipVariables()); set => this._variables = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationtemplateConfigSpEntityIdTooltip" /> instance.
        /// </summary>
        public ApplicationtemplateConfigSpEntityIdTooltip()
        {

        }
    }
    public partial interface IApplicationtemplateConfigSpEntityIdTooltip :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string Template { get; set; }

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

    }
    internal partial interface IApplicationtemplateConfigSpEntityIdTooltipInternal

    {
        string Template { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables Variables { get; set; }

    }
}