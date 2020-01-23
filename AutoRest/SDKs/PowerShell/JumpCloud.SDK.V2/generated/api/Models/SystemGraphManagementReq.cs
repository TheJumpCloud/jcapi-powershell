namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>SystemGraphManagementReq</summary>
    public partial class SystemGraphManagementReq :
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReq,
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributes _attributes;

        /// <summary>The graph connection's attributes</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloud.SDK.V2.Models.SystemGraphManagementReqAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for AttributeSudo</summary>
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudo JumpCloud.SDK.V2.Models.ISystemGraphManagementReqInternal.AttributeSudo { get => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).Sudo; set => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).Sudo = value; }

        /// <summary>Internal Acessors for Attributes</summary>
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributes JumpCloud.SDK.V2.Models.ISystemGraphManagementReqInternal.Attributes { get => (this._attributes = this._attributes ?? new JumpCloud.SDK.V2.Models.SystemGraphManagementReqAttributes()); set { {_attributes = value;} } }

        /// <summary>Backing field for <see cref="Op" /> property.</summary>
        private string _op;

        /// <summary>How to modify the graph connection.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Op { get => this._op; set => this._op = value; }

        /// <summary>FIXME: Property SudoEnabled is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SudoEnabled { get => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoEnabled; set => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoEnabled = value; }

        /// <summary>FIXME: Property SudoWithoutPassword is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? SudoWithoutPassword { get => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoWithoutPassword; set => ((JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesInternal)Attributes).SudoWithoutPassword = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SystemGraphManagementReq" /> instance.</summary>
        public SystemGraphManagementReq()
        {

        }
    }
    /// SystemGraphManagementReq
    public partial interface ISystemGraphManagementReq :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of graph object being added or removed as an association.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"How to modify the graph connection.",
        SerializedName = @"op",
        PossibleTypes = new [] { typeof(string) })]
        string Op { get; set; }

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

        [JumpCloud.SDK.V2.Runtime.Info(
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
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributesSudo AttributeSudo { get; set; }
        /// <summary>The graph connection's attributes</summary>
        JumpCloud.SDK.V2.Models.ISystemGraphManagementReqAttributes Attributes { get; set; }
        /// <summary>The ObjectID of graph object being added or removed as an association.</summary>
        string Id { get; set; }
        /// <summary>How to modify the graph connection.</summary>
        string Op { get; set; }

        bool? SudoEnabled { get; set; }

        bool? SudoWithoutPassword { get; set; }

        string Type { get; set; }

    }
}