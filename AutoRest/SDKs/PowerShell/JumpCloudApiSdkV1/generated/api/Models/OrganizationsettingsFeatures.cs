namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class OrganizationsettingsFeatures :
        JumpCloudApiSdkV1.Models.IOrganizationsettingsFeatures,
        JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesInternal
    {

        /// <summary>Internal Acessors for SystemInsights</summary>
        JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsights JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesInternal.SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsFeaturesSystemInsights()); set { {_systemInsights = value;} } }

        /// <summary>FIXME: Property SystemInsightEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnabled { get => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsightsInternal)SystemInsights).Enabled; set => ((JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsightsInternal)SystemInsights).Enabled = value; }

        /// <summary>Backing field for <see cref="SystemInsights" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsights _systemInsights;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsights SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloudApiSdkV1.Models.OrganizationsettingsFeaturesSystemInsights()); set => this._systemInsights = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsFeatures" /> instance.</summary>
        public OrganizationsettingsFeatures()
        {

        }
    }
    public partial interface IOrganizationsettingsFeatures :
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
    internal partial interface IOrganizationsettingsFeaturesInternal

    {
        bool? SystemInsightEnabled { get; set; }

        JumpCloudApiSdkV1.Models.IOrganizationsettingsFeaturesSystemInsights SystemInsights { get; set; }

    }
}