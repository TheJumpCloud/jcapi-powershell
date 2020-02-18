// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Provider</summary>
    public partial class Provider :
        JumpCloud.SDK.V2.Models.IProvider,
        JumpCloud.SDK.V2.Models.IProviderInternal
    {

        /// <summary>Backing field for <see cref="Contact" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IProviderContact _contact;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IProviderContact Contact { get => (this._contact = this._contact ?? new JumpCloud.SDK.V2.Models.ProviderContact()); set => this._contact = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string ContactEmail { get => ((JumpCloud.SDK.V2.Models.IProviderContactInternal)Contact).Email; set => ((JumpCloud.SDK.V2.Models.IProviderContactInternal)Contact).Email = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string ContactName { get => ((JumpCloud.SDK.V2.Models.IProviderContactInternal)Contact).Name; set => ((JumpCloud.SDK.V2.Models.IProviderContactInternal)Contact).Name = value; }

        /// <summary>Internal Acessors for Contact</summary>
        JumpCloud.SDK.V2.Models.IProviderContact JumpCloud.SDK.V2.Models.IProviderInternal.Contact { get => (this._contact = this._contact ?? new JumpCloud.SDK.V2.Models.ProviderContact()); set { {_contact = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="Provider" /> instance.</summary>
        public Provider()
        {

        }
    }
    /// Provider
    public partial interface IProvider :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string ContactEmail { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ContactName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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
        JumpCloud.SDK.V2.Models.IProviderContact Contact { get; set; }

        string ContactEmail { get; set; }

        string ContactName { get; set; }

        string Name { get; set; }

    }
}