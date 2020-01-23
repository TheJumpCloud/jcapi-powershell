namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationConfigAcsUrlTooltip :
        JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltip,
        JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipInternal
    {

        /// <summary>Internal Acessors for Variables</summary>
        JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariables JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipInternal.Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V1.Models.ApplicationConfigAcsUrlTooltipVariables()); set { {_variables = value;} } }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Template { get => this._template; set => this._template = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariablesInternal)Variables).Icon; set => ((JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariablesInternal)Variables).Icon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariablesInternal)Variables).Message; set => ((JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariablesInternal)Variables).Message = value; }

        /// <summary>Backing field for <see cref="Variables" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariables _variables;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariables Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V1.Models.ApplicationConfigAcsUrlTooltipVariables()); set => this._variables = value; }

        /// <summary>Creates an new <see cref="ApplicationConfigAcsUrlTooltip" /> instance.</summary>
        public ApplicationConfigAcsUrlTooltip()
        {

        }
    }
    public partial interface IApplicationConfigAcsUrlTooltip :
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
    internal partial interface IApplicationConfigAcsUrlTooltipInternal

    {
        string Template { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationConfigAcsUrlTooltipVariables Variables { get; set; }

    }
}