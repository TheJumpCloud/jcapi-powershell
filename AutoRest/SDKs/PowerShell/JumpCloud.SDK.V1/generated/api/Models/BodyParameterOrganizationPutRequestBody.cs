namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class BodyParameterOrganizationPutRequestBody :
        JumpCloud.SDK.V1.Models.IBodyParameterOrganizationPutRequestBody,
        JumpCloud.SDK.V1.Models.IBodyParameterOrganizationPutRequestBodyInternal
    {

        /// <summary>Backing field for <see cref="Settings" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IOrganizationsettingsput _settings;

        /// <summary>OrganizationSettingsPut</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V1.Models.IOrganizationsettingsput Settings { get => (this._settings = this._settings ?? new JumpCloud.SDK.V1.Models.Organizationsettingsput()); set => this._settings = value; }

        /// <summary>Creates an new <see cref="BodyParameterOrganizationPutRequestBody" /> instance.</summary>
        public BodyParameterOrganizationPutRequestBody()
        {

        }
    }
    public partial interface IBodyParameterOrganizationPutRequestBody :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>OrganizationSettingsPut</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OrganizationSettingsPut",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IOrganizationsettingsput) })]
        JumpCloud.SDK.V1.Models.IOrganizationsettingsput Settings { get; set; }

    }
    internal partial interface IBodyParameterOrganizationPutRequestBodyInternal

    {
        /// <summary>OrganizationSettingsPut</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsput Settings { get; set; }

    }
}