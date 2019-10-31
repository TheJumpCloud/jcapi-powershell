namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class ProviderContact :
        JumpCloudApiSdkV2.Models.IProviderContact,
        JumpCloudApiSdkV2.Models.IProviderContactInternal
    {

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ProviderContact" /> instance.</summary>
        public ProviderContact()
        {

        }
    }
    public partial interface IProviderContact :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    internal partial interface IProviderContactInternal

    {
        string Email { get; set; }

        string Name { get; set; }

    }
}