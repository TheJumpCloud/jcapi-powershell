namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class BodyParameterOrganizationPutRequestBody :
        JumpCloudApiSdkV1.Models.IBodyParameterOrganizationPutRequestBody,
        JumpCloudApiSdkV1.Models.IBodyParameterOrganizationPutRequestBodyInternal
    {

        /// <summary>Backing field for <see cref="Settings" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationsettingsput _settings;

        /// <summary>OrganizationSettingsPut</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public JumpCloudApiSdkV1.Models.IOrganizationsettingsput Settings { get => (this._settings = this._settings ?? new JumpCloudApiSdkV1.Models.Organizationsettingsput()); set => this._settings = value; }

        /// <summary>Creates an new <see cref="BodyParameterOrganizationPutRequestBody" /> instance.</summary>
        public BodyParameterOrganizationPutRequestBody()
        {

        }
    }
    public partial interface IBodyParameterOrganizationPutRequestBody :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        /// <summary>OrganizationSettingsPut</summary>
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OrganizationSettingsPut",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(JumpCloudApiSdkV1.Models.IOrganizationsettingsput) })]
        JumpCloudApiSdkV1.Models.IOrganizationsettingsput Settings { get; set; }

    }
    internal partial interface IBodyParameterOrganizationPutRequestBodyInternal

    {
        /// <summary>OrganizationSettingsPut</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettingsput Settings { get; set; }

    }
}