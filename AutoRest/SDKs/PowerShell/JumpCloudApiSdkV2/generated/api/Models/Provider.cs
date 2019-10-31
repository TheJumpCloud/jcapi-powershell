namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Provider</summary>
    public partial class Provider :
        JumpCloudApiSdkV2.Models.IProvider,
        JumpCloudApiSdkV2.Models.IProviderInternal
    {

        /// <summary>Backing field for <see cref="Contact" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IProviderContact _contact;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IProviderContact Contact { get => (this._contact = this._contact ?? new JumpCloudApiSdkV2.Models.ProviderContact()); set => this._contact = value; }

        /// <summary>FIXME: Property ContactEmail is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string ContactEmail { get => ((JumpCloudApiSdkV2.Models.IProviderContactInternal)Contact).Email; set => ((JumpCloudApiSdkV2.Models.IProviderContactInternal)Contact).Email = value; }

        /// <summary>FIXME: Property ContactName is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string ContactName { get => ((JumpCloudApiSdkV2.Models.IProviderContactInternal)Contact).Name; set => ((JumpCloudApiSdkV2.Models.IProviderContactInternal)Contact).Name = value; }

        /// <summary>Internal Acessors for Contact</summary>
        JumpCloudApiSdkV2.Models.IProviderContact JumpCloudApiSdkV2.Models.IProviderInternal.Contact { get => (this._contact = this._contact ?? new JumpCloudApiSdkV2.Models.ProviderContact()); set { {_contact = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Provider" /> instance.</summary>
        public Provider()
        {

        }
    }
    /// Provider
    public partial interface IProvider :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string ContactEmail { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ContactName { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Provider
    internal partial interface IProviderInternal

    {
        JumpCloudApiSdkV2.Models.IProviderContact Contact { get; set; }

        string ContactEmail { get; set; }

        string ContactName { get; set; }

        string Name { get; set; }

    }
}