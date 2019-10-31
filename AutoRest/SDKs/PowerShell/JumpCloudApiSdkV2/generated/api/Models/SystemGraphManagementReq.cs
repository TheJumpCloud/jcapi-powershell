namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>SystemGraphManagementReq</summary>
    public partial class SystemGraphManagementReq :
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReq,
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes _attributes;

        /// <summary>The graph connection's attributes</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for AttributeSudo</summary>
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo JumpCloudApiSdkV2.Models.ISystemGraphManagementReqInternal.AttributeSudo { get => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).Sudo; set => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).Sudo = value; }

        /// <summary>Internal Acessors for Attributes</summary>
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes JumpCloudApiSdkV2.Models.ISystemGraphManagementReqInternal.Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributes()); set { {_attributes = value;} } }

        /// <summary>Backing field for <see cref="Op" /> property.</summary>
        private string _op;

        /// <summary>How to modify the graph connection.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Op { get => this._op; set => this._op = value; }

        /// <summary>FIXME: Property SudoEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SudoEnabled { get => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoEnabled; set => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoEnabled = value; }

        /// <summary>FIXME: Property SudoWithoutPassword is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SudoWithoutPassword { get => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoWithoutPassword; set => ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoWithoutPassword = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemGraphManagementReq" /> instance.</summary>
        public SystemGraphManagementReq()
        {

        }
    }
    /// SystemGraphManagementReq
    public partial interface ISystemGraphManagementReq :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of graph object being added or removed as an association.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"How to modify the graph connection.",
        SerializedName = @"op",
        PossibleTypes = new [] { typeof(string) })]
        string Op { get; set; }

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

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// SystemGraphManagementReq
    internal partial interface ISystemGraphManagementReqInternal

    {
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo AttributeSudo { get; set; }
        /// <summary>The graph connection's attributes</summary>
        JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes Attributes { get; set; }
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        string Op { get; set; }

        bool? SudoEnabled { get; set; }

        bool? SudoWithoutPassword { get; set; }

        string Type { get; set; }

    }
}