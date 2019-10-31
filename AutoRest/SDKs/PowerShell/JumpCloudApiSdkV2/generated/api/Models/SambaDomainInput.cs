namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Samba Domain Input</summary>
    public partial class SambaDomainInput :
        JumpCloudApiSdkV2.Models.ISambaDomainInput,
        JumpCloudApiSdkV2.Models.ISambaDomainInputInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of this domain's WorkGroup</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Sid" /> property.</summary>
        private string _sid;

        /// <summary>Security identifier of this domain</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Sid { get => this._sid; set => this._sid = value; }

        /// <summary>Creates an new <see cref="SambaDomainInput" /> instance.</summary>
        public SambaDomainInput()
        {

        }
    }
    /// Samba Domain Input
    public partial interface ISambaDomainInput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>Name of this domain's WorkGroup</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Name of this domain's WorkGroup",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Security identifier of this domain</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Security identifier of this domain",
        SerializedName = @"sid",
        PossibleTypes = new [] { typeof(string) })]
        string Sid { get; set; }

    }
    /// Samba Domain Input
    internal partial interface ISambaDomainInputInternal

    {
        /// <summary>Name of this domain's WorkGroup</summary>
        string Name { get; set; }
        /// <summary>Security identifier of this domain</summary>
        string Sid { get; set; }

    }
}