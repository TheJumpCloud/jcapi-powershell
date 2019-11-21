namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    /// <summary>The graph connection's attributes</summary>
    public partial class UserGraphManagementReqAttributes :
        JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes,
        JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal
    {

        /// <summary>Internal Acessors for Sudo</summary>
        JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal.Sudo { get => (this._sudo = this._sudo ?? new JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesSudo()); set { {_sudo = value;} } }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo _sudo;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo Sudo { get => (this._sudo = this._sudo ?? new JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesSudo()); set => this._sudo = value; }

        /// <summary>FIXME: Property SudoEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? SudoEnabled { get => ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).Enabled; set => ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).Enabled = value; }

        /// <summary>FIXME: Property SudoWithoutPassword is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Inlined)]
        public bool? SudoWithoutPassword { get => ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword; set => ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword = value; }

        /// <summary>Creates an new <see cref="UserGraphManagementReqAttributes" /> instance.</summary>
        public UserGraphManagementReqAttributes()
        {

        }
    }
    /// The graph connection's attributes
    public partial interface IUserGraphManagementReqAttributes :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SudoEnabled { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"withoutPassword",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SudoWithoutPassword { get; set; }

    }
    /// The graph connection's attributes
    internal partial interface IUserGraphManagementReqAttributesInternal

    {
        JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo Sudo { get; set; }

        bool? SudoEnabled { get; set; }

        bool? SudoWithoutPassword { get; set; }

    }
}