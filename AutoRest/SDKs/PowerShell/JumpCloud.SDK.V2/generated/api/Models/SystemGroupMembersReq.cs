// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>SystemGroupMembersReq</summary>
    public partial class SystemGroupMembersReq :
        JumpCloud.SDK.V2.Models.ISystemGroupMembersReq,
        JumpCloud.SDK.V2.Models.ISystemGroupMembersReqInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ObjectID of member being added or removed.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Type</summary>
        string JumpCloud.SDK.V2.Models.ISystemGroupMembersReqInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Op" /> property.</summary>
        private string _op;

        /// <summary>How to modify the membership connection.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Op { get => this._op; set => this._op = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"system";

        /// <summary>The member type.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="SystemGroupMembersReq" /> instance.</summary>
        public SystemGroupMembersReq()
        {

        }
    }
    /// SystemGroupMembersReq
    public partial interface ISystemGroupMembersReq :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>The ObjectID of member being added or removed.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ObjectID of member being added or removed.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>How to modify the membership connection.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"How to modify the membership connection.",
        SerializedName = @"op",
        PossibleTypes = new [] { typeof(string) })]
        string Op { get; set; }
        /// <summary>The member type.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The member type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// SystemGroupMembersReq
    internal partial interface ISystemGroupMembersReqInternal

    {
        /// <summary>The ObjectID of member being added or removed.</summary>
        string Id { get; set; }
        /// <summary>How to modify the membership connection.</summary>
        string Op { get; set; }
        /// <summary>The member type.</summary>
        string Type { get; set; }

    }
}