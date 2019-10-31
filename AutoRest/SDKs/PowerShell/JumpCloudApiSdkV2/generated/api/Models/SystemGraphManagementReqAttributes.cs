namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>The graph connection's attributes</summary>
    public partial class SystemGraphManagementReqAttributes :
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes,
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal
    {

        /// <summary>Internal Acessors for Sudo</summary>
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal.Sudo { get => (this._sudo = this._sudo ?? new JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributesSudo()); set { {_sudo = value;} } }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo _sudo;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo Sudo { get => (this._sudo = this._sudo ?? new JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributesSudo()); set => this._sudo = value; }

        /// <summary>FIXME: Property SudoEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SudoEnabled { get => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).Enabled; set => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).Enabled = value; }

        /// <summary>FIXME: Property SudoWithoutPassword is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SudoWithoutPassword { get => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword; set => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword = value; }

        /// <summary>Creates an new <see cref="SystemGraphManagementReqAttributes" /> instance.</summary>
        public SystemGraphManagementReqAttributes()
        {

        }
    }
    /// The graph connection's attributes
    public partial interface ISystemGraphManagementReqAttributes :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SudoEnabled { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"withoutPassword",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SudoWithoutPassword { get; set; }

    }
    /// The graph connection's attributes
    internal partial interface ISystemGraphManagementReqAttributesInternal

    {
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo Sudo { get; set; }

        bool? SudoEnabled { get; set; }

        bool? SudoWithoutPassword { get; set; }

    }
}