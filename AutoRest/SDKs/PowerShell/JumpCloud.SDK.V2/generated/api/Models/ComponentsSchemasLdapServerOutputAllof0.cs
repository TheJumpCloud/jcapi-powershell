namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class ComponentsSchemasLdapServerOutputAllof0 :
        JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0,
        JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0Internal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Unique identifier of this LDAP server</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="ComponentsSchemasLdapServerOutputAllof0" /> instance.</summary>
        public ComponentsSchemasLdapServerOutputAllof0()
        {

        }
    }
    public partial interface IComponentsSchemasLdapServerOutputAllof0 :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>Unique identifier of this LDAP server</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Unique identifier of this LDAP server",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    internal partial interface IComponentsSchemasLdapServerOutputAllof0Internal

    {
        /// <summary>Unique identifier of this LDAP server</summary>
        string Id { get; set; }

    }
}