namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsFeatures :
        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeatures,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesInternal
    {

        /// <summary>Internal Acessors for SystemInsights</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsights JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesInternal.SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsFeaturesSystemInsights()); set { {_systemInsights = value;} } }

        /// <summary>FIXME: Property SystemInsightEnabled is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnabled { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsightsInternal)SystemInsights).Enabled; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsightsInternal)SystemInsights).Enabled = value; }

        /// <summary>Backing field for <see cref="SystemInsights" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsights _systemInsights;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsights SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsFeaturesSystemInsights()); set => this._systemInsights = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsFeatures" /> instance.</summary>
        public OrganizationsettingsFeatures()
        {

        }
    }
    public partial interface IOrganizationsettingsFeatures :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
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

        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsights SystemInsights { get; set; }

    }
}