namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class PolicyTemplateConfigFieldTooltipVariables :
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables,
        JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariablesInternal
    {

        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private string _icon;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Icon { get => this._icon; set => this._icon = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="PolicyTemplateConfigFieldTooltipVariables" /> instance.
        /// </summary>
        public PolicyTemplateConfigFieldTooltipVariables()
        {

        }
    }
    public partial interface IPolicyTemplateConfigFieldTooltipVariables :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string Icon { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
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