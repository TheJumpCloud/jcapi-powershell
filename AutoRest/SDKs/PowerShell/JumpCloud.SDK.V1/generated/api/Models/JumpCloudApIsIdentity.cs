// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class JumpCloudApIsIdentity :
        JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentity,
        JumpCloud.SDK.V1.Models.IJumpCloudApIsIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="SystemuserId" /> property.</summary>
        private string _systemuserId;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string SystemuserId { get => this._systemuserId; set => this._systemuserId = value; }

        /// <summary>Backing field for <see cref="Triggername" /> property.</summary>
        private string _triggername;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Triggername { get => this._triggername; set => this._triggername = value; }

        /// <summary>Creates an new <see cref="JumpCloudApIsIdentity" /> instance.</summary>
        public JumpCloudApIsIdentity()
        {

        }
    }
    public partial interface IJumpCloudApIsIdentity :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemuser_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemuserId { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"triggername",
        PossibleTypes = new [] { typeof(string) })]
        string Triggername { get; set; }

    }
    internal partial interface IJumpCloudApIsIdentityInternal

    {
        string Id { get; set; }

        string SystemuserId { get; set; }

        string Triggername { get; set; }

    }
}