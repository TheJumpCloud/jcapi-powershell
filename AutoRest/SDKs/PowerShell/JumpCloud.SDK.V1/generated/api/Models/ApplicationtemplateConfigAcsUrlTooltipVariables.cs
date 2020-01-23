namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigAcsUrlTooltipVariables :
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables,
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipVariablesInternal
    {

        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private string _icon;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Icon { get => this._icon; set => this._icon = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationtemplateConfigAcsUrlTooltipVariables" /> instance.
        /// </summary>
        public ApplicationtemplateConfigAcsUrlTooltipVariables()
        {

        }
    }
    public partial interface IApplicationtemplateConfigAcsUrlTooltipVariables :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string Icon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface IApplicationtemplateConfigAcsUrlTooltipVariablesInternal

    {
        string Icon { get; set; }

        string Message { get; set; }

    }
}