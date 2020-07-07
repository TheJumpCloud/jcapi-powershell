// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsputFeatures :
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeatures,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesInternal
    {

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? DirectoryInsightPremiumEnabled { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesDirectoryInsightsPremiumInternal)DirectoryInsightsPremium).Enabled; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesDirectoryInsightsPremiumInternal)DirectoryInsightsPremium).Enabled = value; }

        /// <summary>Backing field for <see cref="DirectoryInsightsPremium" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesDirectoryInsightsPremium _directoryInsightsPremium;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesDirectoryInsightsPremium DirectoryInsightsPremium { get => (this._directoryInsightsPremium = this._directoryInsightsPremium ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsputFeaturesDirectoryInsightsPremium()); set => this._directoryInsightsPremium = value; }

        /// <summary>Internal Acessors for DirectoryInsightsPremium</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesDirectoryInsightsPremium JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesInternal.DirectoryInsightsPremium { get => (this._directoryInsightsPremium = this._directoryInsightsPremium ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsputFeaturesDirectoryInsightsPremium()); set { {_directoryInsightsPremium = value;} } }

        /// <summary>Internal Acessors for SystemInsights</summary>
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsights JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesInternal.SystemInsights { get => (this._systemInsights = this._systemInsights ?? new JumpCloud.SDK.V1.Models.OrganizationsettingsputFeaturesSystemInsights()); set { {_systemInsights = value;} } }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnableNewDarwin { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).EnableNewDarwin; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).EnableNewDarwin = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnableNewLinux { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).EnableNewLinux; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).EnableNewLinux = value; }

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SystemInsightEnableNewWindows { get => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).EnableNewWindows; set => ((JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsightsInternal)SystemInsights).EnableNewWindows = value; }

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
        bool? DirectoryInsightPremiumEnabled { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableNewDarwin",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemInsightEnableNewDarwin { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableNewLinux",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemInsightEnableNewLinux { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableNewWindows",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SystemInsightEnableNewWindows { get; set; }

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
        bool? DirectoryInsightPremiumEnabled { get; set; }

        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesDirectoryInsightsPremium DirectoryInsightsPremium { get; set; }

        bool? SystemInsightEnableNewDarwin { get; set; }

        bool? SystemInsightEnableNewLinux { get; set; }

        bool? SystemInsightEnableNewWindows { get; set; }

        bool? SystemInsightEnabled { get; set; }

        JumpCloud.SDK.V1.Models.IOrganizationsettingsputFeaturesSystemInsights SystemInsights { get; set; }

    }
}