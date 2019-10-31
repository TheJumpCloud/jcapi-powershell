namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigSpEntityIdTooltip :
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltip,
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipInternal
    {

        /// <summary>Internal Acessors for Variables</summary>
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipInternal.Variables { get => (this._variables = this._variables ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateConfigSpEntityIdTooltipVariables()); set { {_variables = value;} } }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Template { get => this._template; set => this._template = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Icon; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Icon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Message; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariablesInternal)Variables).Message = value; }

        /// <summary>Backing field for <see cref="Variables" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables _variables;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables Variables { get => (this._variables = this._variables ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateConfigSpEntityIdTooltipVariables()); set => this._variables = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationtemplateConfigSpEntityIdTooltip" /> instance.
        /// </summary>
        public ApplicationtemplateConfigSpEntityIdTooltip()
        {

        }
    }
    public partial interface IApplicationtemplateConfigSpEntityIdTooltip :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string Template { get; set; }

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

    }
    internal partial interface IApplicationtemplateConfigSpEntityIdTooltipInternal

    {
        string Template { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables Variables { get; set; }

    }
}