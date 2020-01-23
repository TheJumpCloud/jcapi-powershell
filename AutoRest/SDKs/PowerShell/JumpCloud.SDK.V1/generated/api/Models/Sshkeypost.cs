namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    /// <summary>SSHKeyPost</summary>
    public partial class Sshkeypost :
        JumpCloud.SDK.V1.Models.ISshkeypost,
        JumpCloud.SDK.V1.Models.ISshkeypostInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the SSH key.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private string _publicKey;

        /// <summary>The Public SSH key.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string PublicKey { get => this._publicKey; set => this._publicKey = value; }

        /// <summary>Creates an new <see cref="Sshkeypost" /> instance.</summary>
        public Sshkeypost()
        {

        }
    }
    /// SSHKeyPost
    public partial interface ISshkeypost :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>The name of the SSH key.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the SSH key.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The Public SSH key.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Public SSH key.",
        SerializedName = @"public_key",
        PossibleTypes = new [] { typeof(string) })]
        string PublicKey { get; set; }

    }
    /// SSHKeyPost
    internal partial interface ISshkeypostInternal

    {
        /// <summary>The name of the SSH key.</summary>
        string Name { get; set; }
        /// <summary>The Public SSH key.</summary>
        string PublicKey { get; set; }

    }
}