namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class OrganizationsettingsputUserPortal :
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortal,
        JumpCloudApiSdkV1.Models.IOrganizationsettingsputUserPortalInternal
    {

        /// <summary>Backing field for <see cref="IdleSessionDurationMinutes" /> property.</summary>
        private int? _idleSessionDurationMinutes;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public int? IdleSessionDurationMinutes { get => this._idleSessionDurationMinutes; set => this._idleSessionDurationMinutes = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsputUserPortal" /> instance.</summary>
        public OrganizationsettingsputUserPortal()
        {

        }
    }
    public partial interface IOrganizationsettingsputUserPortal :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"idleSessionDurationMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? IdleSessionDurationMinutes { get; set; }

    }
    internal partial interface IOrganizationsettingsputUserPortalInternal

    {
        int? IdleSessionDurationMinutes { get; set; }

    }
}