namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsFeaturesSystemInsights :
        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsights,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsFeaturesSystemInsightsInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>
        /// Creates an new <see cref="OrganizationsettingsFeaturesSystemInsights" /> instance.
        /// </summary>
        public OrganizationsettingsFeaturesSystemInsights()
        {

        }
    }
    public partial interface IOrganizationsettingsFeaturesSystemInsights :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    internal partial interface IOrganizationsettingsFeaturesSystemInsightsInternal

    {
        bool? Enabled { get; set; }

    }
}