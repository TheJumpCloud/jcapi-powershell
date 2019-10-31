namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>UserGraphManagementReq</summary>
    public partial class UserGraphManagementReq :
        JumpCloudApiSdkV2.Models.IUserGraphManagementReq,
        JumpCloudApiSdkV2.Models.IUserGraphManagementReqInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributes _attributes;

        /// <summary>The graph connection's attributes</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.UserGraphManagementReqAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for AttributeSudo</summary>
        JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesSudo JumpCloudApiSdkV2.Models.IUserGraphManagementReqInternal.AttributeSudo { get => ((JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesInternal)Attributes).Sudo; set => ((JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesInternal)Attributes).Sudo = value; }

        /// <summary>Internal Acessors for Attributes</summary>
        JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributes JumpCloudApiSdkV2.Models.IUserGraphManagementReqInternal.Attributes { get => (this._attributes = this._attributes ?? new JumpCloudApiSdkV2.Models.UserGraphManagementReqAttributes()); set { {_attributes = value;} } }

        /// <summary>Backing field for <see cref="Op" /> property.</summary>
        private string _op;

        /// <summary>How to modify the graph connection.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Op { get => this._op; set => this._op = value; }

        /// <summary>FIXME: Property SudoEnabled is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SudoEnabled { get => ((JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesInternal)Attributes).SudoEnabled; set => ((JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesInternal)Attributes).SudoEnabled = value; }

        /// <summary>FIXME: Property SudoWithoutPassword is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? SudoWithoutPassword { get => ((JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesInternal)Attributes).SudoWithoutPassword; set => ((JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesInternal)Attributes).SudoWithoutPassword = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="UserGraphManagementReq" /> instance.</summary>
        public UserGraphManagementReq()
        {

        }
    }
    /// UserGraphManagementReq
    public partial interface IUserGraphManagementReq :
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
    /// UserGraphManagementReq
    internal partial interface IUserGraphManagementReqInternal

    {
        JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributesSudo AttributeSudo { get; set; }
        /// <summary>The graph connection's attributes</summary>
        JumpCloudApiSdkV2.Models.IUserGraphManagementReqAttributes Attributes { get; set; }
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        string Op { get; set; }

        bool? SudoEnabled { get; set; }

        bool? SudoWithoutPassword { get; set; }

        string Type { get; set; }

    }
}