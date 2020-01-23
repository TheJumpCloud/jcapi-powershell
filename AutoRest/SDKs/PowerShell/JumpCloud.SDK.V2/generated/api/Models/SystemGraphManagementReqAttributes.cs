namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>The graph connection's attributes</summary>
    public partial class SystemGraphManagementReqAttributes :
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributes,
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal
    {

        /// <summary>Internal Acessors for Sudo</summary>
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudo JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal.Sudo { get => (this._sudo = this._sudo ?? new JumpCloud.SDK.V2.Models.SystemGraphManagementReqAttributesSudo()); set { {_sudo = value;} } }

        /// <summary>Backing field for <see cref="Sudo" /> property.</summary>
        private JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudo _sudo;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudo Sudo { get => (this._sudo = this._sudo ?? new JumpCloud.SDK.V2.Models.SystemGraphManagementReqAttributesSudo()); set => this._sudo = value; }

        /// <summary>FIXME: Property SudoEnabled is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SudoEnabled { get => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).Enabled; set => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).Enabled = value; }

        /// <summary>FIXME: Property SudoWithoutPassword is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SudoWithoutPassword { get => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword; set => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudoInternal)Sudo).WithoutPassword = value; }

        /// <summary>Creates an new <see cref="SystemGraphManagementReqAttributes" /> instance.</summary>
        public SystemGraphManagementReqAttributes()
        {

        }
    }
    /// The graph connection's attributes
    public partial interface ISystemGraphManagementReqAttributes :
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
    internal partial interface ISystemGraphManagementReqAttributesInternal

    {
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudo Sudo { get; set; }

        bool? SudoEnabled { get; set; }

        bool? SudoWithoutPassword { get; set; }

    }
}