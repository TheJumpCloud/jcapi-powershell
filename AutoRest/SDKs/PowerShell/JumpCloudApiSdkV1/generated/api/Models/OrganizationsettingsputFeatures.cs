namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class OrganizationsettingsputFeatures :
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeatures,
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesInternal
    {

        /// <summary>Internal Acessors for SystemInsights</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesInternal.SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputFeaturesSystemInsights()); set { {_systemInsights = value;} } }

        /// <summary>FIXME: Property SystemInsightEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnabled { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).Enabled; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).Enabled = value; }

        /// <summary>Backing field for <see cref="SystemInsights" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights _systemInsights;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsputFeaturesSystemInsights()); set => this._systemInsights = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsputFeatures" /> instance.</summary>
        public OrganizationsettingsputFeatures()
        {

        }
    }
    public partial interface IOrganizationsettingsputFeatures :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemInsightEnabled { get; set; }

    }
    internal partial interface IOrganizationsettingsputFeaturesInternal

    {
        bool? SystemInsightEnabled { get; set; }

        JumpCloudApiSdkV1.Models.IOrganizationsettingsputFeaturesSystemInsights SystemInsights { get; set; }

    }
}