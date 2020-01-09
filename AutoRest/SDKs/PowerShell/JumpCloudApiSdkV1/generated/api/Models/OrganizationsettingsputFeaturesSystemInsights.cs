namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class OrganizationsettingsputFeaturesSystemInsights :
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights,
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>
        /// Creates an new <see cref="OrganizationsettingsputFeaturesSystemInsights" /> instance.
        /// </summary>
        public OrganizationsettingsputFeaturesSystemInsights()
        {

        }
    }
    public partial interface IOrganizationsettingsputFeaturesSystemInsights :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    internal partial interface IOrganizationsettingsputFeaturesSystemInsightsInternal

    {
        bool? Enabled { get; set; }

    }
}