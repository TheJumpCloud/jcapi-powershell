namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class ApplicationtemplateConfigIdpEntityIdTooltipVariables :
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpEntityIdTooltipVariables,
        JumpCloudApiSdkV1.Models.IApplicationtemplateConfigIdpEntityIdTooltipVariablesInternal
    {

        /// <summary>Backing field for <see cref="Icon" /> property.</summary>
        private string _icon;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Icon { get => this._icon; set => this._icon = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="ApplicationtemplateConfigIdpEntityIdTooltipVariables" /> instance.
        /// </summary>
        public ApplicationtemplateConfigIdpEntityIdTooltipVariables()
        {

        }
    }
    public partial interface IApplicationtemplateConfigIdpEntityIdTooltipVariables :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string Icon { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface IApplicationtemplateConfigIdpEntityIdTooltipVariablesInternal

    {
        string Icon { get; set; }

        string Message { get; set; }

    }
}