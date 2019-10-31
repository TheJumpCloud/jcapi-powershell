namespace JumpCloudApiSdkV1.Models
{
    using static JumpCloudApiSdkV1.Runtime.Extensions;

    public partial class JumpCloudApIsIdentity :
        JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentity,
        JumpCloudApiSdkV1.Models.IJumpCloudApIsIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="SystemuserId" /> property.</summary>
        private string _systemuserId;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string SystemuserId { get => this._systemuserId; set => this._systemuserId = value; }

        /// <summary>Backing field for <see cref="Triggername" /> property.</summary>
        private string _triggername;

        [JumpCloudApiSdkV1.Origin(JumpCloudApiSdkV1.PropertyOrigin.Owned)]
        public string Triggername { get => this._triggername; set => this._triggername = value; }

        /// <summary>Creates an new <see cref="JumpCloudApIsIdentity" /> instance.</summary>
        public JumpCloudApIsIdentity()
        {

        }
    }
    public partial interface IJumpCloudApIsIdentity :
        JumpCloudApiSdkV1.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"systemuser_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemuserId { get; set; }

        [JumpCloudApiSdkV1.Runtime.Info(
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