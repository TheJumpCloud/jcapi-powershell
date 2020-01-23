namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigIdpPrivateKeyTooltip :
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltip,
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal
    {

        /// <summary>Internal Acessors for Variables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipInternal.Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpPrivateKeyTooltipVariables()); set { {_variables = value;} } }

        /// <summary>Backing field for <see cref="Template" /> property.</summary>
        private string _template;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Template { get => this._template; set => this._template = value; }

        /// <summary>FIXME: Property VariableIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariablesInternal)Variables).Icon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariablesInternal)Variables).Icon = value; }

        /// <summary>FIXME: Property VariableMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string VariableMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariablesInternal)Variables).Message; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariablesInternal)Variables).Message = value; }

        /// <summary>Backing field for <see cref="Variables" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables _variables;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables Variables { get => (this._variables = this._variables ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpPrivateKeyTooltipVariables()); set => this._variables = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationtemplateConfigIdpPrivateKeyTooltip" /> instance.
        /// </summary>
        public ApplicationtemplateConfigIdpPrivateKeyTooltip()
        {

        }
    }
    public partial interface IApplicationtemplateConfigIdpPrivateKeyTooltip :
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
    internal partial interface IApplicationtemplateConfigIdpPrivateKeyTooltipInternal

    {
        string Template { get; set; }

        string VariableIcon { get; set; }

        string VariableMessage { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables Variables { get; set; }

    }
}