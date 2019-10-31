namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>DuoAccount</summary>
    public partial class DuoAccount :
        JumpCloudApiSdkV2.Models.IDuoAccount,
        JumpCloudApiSdkV2.Models.IDuoAccountInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>object ID</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Duo application name.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DuoAccount" /> instance.</summary>
        public DuoAccount()
        {

        }
    }
    /// DuoAccount
    public partial interface IDuoAccount :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>object ID</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"object ID",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Duo application name.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Duo application name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// DuoAccount
    internal partial interface IDuoAccountInternal

    {
        /// <summary>object ID</summary>
        string Id { get; set; }
        /// <summary>Duo application name.</summary>
        string Name { get; set; }

    }
}