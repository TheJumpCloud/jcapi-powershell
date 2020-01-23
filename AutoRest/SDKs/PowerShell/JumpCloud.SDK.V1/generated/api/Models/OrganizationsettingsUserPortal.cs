namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationsettingsUserPortal :
        JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortal,
        JumpCloud.SDK.V1.Models.IOrganizationsettingsUserPortalInternal
    {

        /// <summary>Backing field for <see cref="IdleSessionDurationMinutes" /> property.</summary>
        private int? _idleSessionDurationMinutes;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public int? IdleSessionDurationMinutes { get => this._idleSessionDurationMinutes; set => this._idleSessionDurationMinutes = value; }

        /// <summary>Creates an new <see cref="OrganizationsettingsUserPortal" /> instance.</summary>
        public OrganizationsettingsUserPortal()
        {

        }
    }
    public partial interface IOrganizationsettingsUserPortal :
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
    internal partial interface IOrganizationsettingsUserPortalInternal

    {
        int? IdleSessionDurationMinutes { get; set; }

    }
}