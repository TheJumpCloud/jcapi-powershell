// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsputFeatures :
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeatures,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesInternal
    {

        /// <summary>Internal Acessors for SystemInsights</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsights JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesInternal.SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsputFeaturesSystemInsights()); set { {_systemInsights = value;} } }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnabled { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).Enabled; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).Enabled = value; }

        /// <summary>Backing field for <see cref="SystemInsights" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsights _systemInsights;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsights SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsputFeaturesSystemInsights()); set => this._systemInsights = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsputFeatures" /> instance.</summary>
        public OrganizationsettingsputFeatures()
        {

        }
    }
    public partial interface IOrganizationsettingsputFeatures :
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
    internal partial interface IOrganizationsettingsputFeaturesInternal

    {
        bool? SystemInsightEnabled { get; set; }

        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsights SystemInsights { get; set; }

    }
}