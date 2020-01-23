namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PolicyTemplateConfigFieldTooltipVariables :
        JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariables,
        JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal
    {

        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private string _icon;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Icon { get => this._icon; set => this._icon = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="PolicyTemplateConfigFieldTooltipVariables" /> instance.
        /// </summary>
        public PolicyTemplateConfigFieldTooltipVariables()
        {

        }
    }
    public partial interface IPolicyTemplateConfigFieldTooltipVariables :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string Icon { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface IPolicyTemplateConfigFieldTooltipVariablesInternal

    {
        string Icon { get; set; }

        string Message { get; set; }

    }
}