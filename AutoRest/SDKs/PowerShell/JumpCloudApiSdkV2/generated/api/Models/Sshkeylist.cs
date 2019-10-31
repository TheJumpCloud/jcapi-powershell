namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>SSHKeyList</summary>
    public partial class Sshkeylist :
        JumpCloudApiSdkV2.Models.ISshkeylist,
        JumpCloudApiSdkV2.Models.ISshkeylistInternal
    {

        /// <summary>Backing field for <see cref="CreateDate" /> property.</summary>
        private string _createDate;

        /// <summary>The date the SSH key was created.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CreateDate { get => this._createDate; set => this._createDate = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the SSH key.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the SSH key.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private string _publicKey;

        /// <summary>The Public SSH key.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string PublicKey { get => this._publicKey; set => this._publicKey = value; }

        /// <summary>Creates an new <see cref="Sshkeylist" /> instance.</summary>
        public Sshkeylist()
        {

        }
    }
    /// SSHKeyList
    public partial interface ISshkeylist :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>The date the SSH key was created.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date the SSH key was created.",
        SerializedName = @"create_date",
        PossibleTypes = new [] { typeof(string) })]
        string CreateDate { get; set; }
        /// <summary>The ID of the SSH key.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the SSH key.",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the SSH key.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the SSH key.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The Public SSH key.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Public SSH key.",
        SerializedName = @"public_key",
        PossibleTypes = new [] { typeof(string) })]
        string PublicKey { get; set; }

    }
    /// SSHKeyList
    internal partial interface ISshkeylistInternal

    {
        /// <summary>The date the SSH key was created.</summary>
        string CreateDate { get; set; }
        /// <summary>The ID of the SSH key.</summary>
        string Id { get; set; }
        /// <summary>The name of the SSH key.</summary>
        string Name { get; set; }
        /// <summary>The Public SSH key.</summary>
        string PublicKey { get; set; }

    }
}