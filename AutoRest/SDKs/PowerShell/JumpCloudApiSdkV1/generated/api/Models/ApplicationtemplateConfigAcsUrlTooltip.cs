namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigAcsUrlTooltip :
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltip,
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal
    {

        /// <summary>Internal Acessors for Variables</summary>
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal.Variables { get => (this._variables = this._variables ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateConfigAcsUrlTooltipVariables()); set { {_variables = value;} } }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Template { get => this._template; set => this._template = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariablesInternal)Variables).Icon; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariablesInternal)Variables).Icon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariablesInternal)Variables).Message; set => ((JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariablesInternal)Variables).Message = value; }

        /// <summary>Backing field for <see cref="Variables" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables _variables;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables Variables { get => (this._variables = this._variables ?? new JumpCloudApiSdkV1.Models.ApplicationtemplateConfigAcsUrlTooltipVariables()); set => this._variables = value; }

        /// <summary>Creates an new <see cref="ApplicationtemplateConfigAcsUrlTooltip" /> instance.</summary>
        public ApplicationtemplateConfigAcsUrlTooltip()
        {

        }
    }
    public partial interface IApplicationtemplateConfigAcsUrlTooltip :
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
    internal partial interface IApplicationtemplateConfigAcsUrlTooltipInternal

    {
        string Template { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables Variables { get; set; }

    }
}