namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsputUserPortal :
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputUserPortal,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsputUserPortalInternal
    {

        /// <summary>Backing field for <see cref="IdleSessionDurationMinutes" /> property.</summary>
        private int? _idleSessionDurationMinutes;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? IdleSessionDurationMinutes { get => this._idleSessionDurationMinutes; set => this._idleSessionDurationMinutes = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsputUserPortal" /> instance.</summary>
        public OrganizationsettingsputUserPortal()
        {

        }
    }
    public partial interface IOrganizationsettingsputUserPortal :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
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