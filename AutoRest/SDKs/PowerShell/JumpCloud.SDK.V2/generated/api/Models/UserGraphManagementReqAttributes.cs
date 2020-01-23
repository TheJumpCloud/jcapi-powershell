namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>The graph connection's attributes</summary>
    public partial class UserGraphManagementReqAttributes :
        JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributes,
        JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesInternal
    {

        /// <summary>Internal Acessors for Sudo</summary>
        JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudo JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesInternal.Sudo { get => (this._sudo = this._sudo ?? new JumpCloud.SDK.V2.Models.UserGraphManagementReqAttributesSudo()); set { {_sudo = value;} } }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudo _sudo;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudo Sudo { get => (this._sudo = this._sudo ?? new JumpCloud.SDK.V2.Models.UserGraphManagementReqAttributesSudo()); set => this._sudo = value; }

        /// <summary>FIXME: Property SudoEnabled is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SudoEnabled { get => ((JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).Enabled; set => ((JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).Enabled = value; }

        /// <summary>FIXME: Property SudoWithoutPassword is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SudoWithoutPassword { get => ((JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword; set => ((JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword = value; }

        /// <summary>Creates an new <see cref="UserGraphManagementReqAttributes" /> instance.</summary>
        public UserGraphManagementReqAttributes()
        {

        }
    }
    /// The graph connection's attributes
    public partial interface IUserGraphManagementReqAttributes :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SudoEnabled { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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
        JumpCloud.SDK.V2.Models.IUserGraphManagementReqAttributesSudo Sudo { get; set; }

        bool? SudoEnabled { get; set; }

        bool? SudoWithoutPassword { get; set; }

    }
}