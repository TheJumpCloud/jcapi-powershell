// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6219, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>LDAP Server Output</summary>
    public partial class LdapServerOutput :
        JumpCloud.SDK.V2.Models.ILdapServerOutput,
        JumpCloud.SDK.V2.Models.ILdapServerOutputInternal,
        JumpCloud.SDK.V2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.ILdapServerInput" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.ILdapServerInput __ldapServerInput = new JumpCloud.SDK.V2.Models.LdapServerInput();

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Unique identifier of this LDAP server</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>The name of this LDAP server</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Name { get => ((JumpCloud.SDK.V2.Models.ILdapServerInputInternal)__ldapServerInput).Name; set => ((JumpCloud.SDK.V2.Models.ILdapServerInputInternal)__ldapServerInput).Name = value; }

        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string UserLockoutAction { get => ((JumpCloud.SDK.V2.Models.ILdapServerInputInternal)__ldapServerInput).UserLockoutAction; set => ((JumpCloud.SDK.V2.Models.ILdapServerInputInternal)__ldapServerInput).UserLockoutAction = value; }

        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string UserPasswordExpirationAction { get => ((JumpCloud.SDK.V2.Models.ILdapServerInputInternal)__ldapServerInput).UserPasswordExpirationAction; set => ((JumpCloud.SDK.V2.Models.ILdapServerInputInternal)__ldapServerInput).UserPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="LdapServerOutput" /> instance.</summary>
        public LdapServerOutput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="JumpCloud.SDK.V2.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(JumpCloud.SDK.V2.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__ldapServerInput), __ldapServerInput);
            await eventListener.AssertObjectIsValid(nameof(__ldapServerInput), __ldapServerInput);
        }
    }
    /// LDAP Server Output
    public partial interface ILdapServerOutput :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable,
        JumpCloud.SDK.V2.Models.ILdapServerInput
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
    /// LDAP Server Output
    internal partial interface ILdapServerOutputInternal :
        JumpCloud.SDK.V2.Models.ILdapServerInputInternal
    {
        /// <summary>Unique identifier of this LDAP server</summary>
        string Id { get; set; }

    }
}