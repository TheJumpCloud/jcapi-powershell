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
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0 __componentsSchemasLdapServerOutputAllof0 = new JumpCloud.SDK.V2.Models.ComponentsSchemasLdapServerOutputAllof0();

        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.ILdapServerInput" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.ILdapServerInput __ldapServerInput = new JumpCloud.SDK.V2.Models.LdapServerInput();

        /// <summary>Unique identifier of this LDAP server</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0Internal)__componentsSchemasLdapServerOutputAllof0).Id; set => ((JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0Internal)__componentsSchemasLdapServerOutputAllof0).Id = value; }

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
            await eventListener.AssertNotNull(nameof(__componentsSchemasLdapServerOutputAllof0), __componentsSchemasLdapServerOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasLdapServerOutputAllof0), __componentsSchemasLdapServerOutputAllof0);
            await eventListener.AssertNotNull(nameof(__ldapServerInput), __ldapServerInput);
            await eventListener.AssertObjectIsValid(nameof(__ldapServerInput), __ldapServerInput);
        }
    }
    /// LDAP Server Output
    public partial interface ILdapServerOutput :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable,
        JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0,
        JumpCloud.SDK.V2.Models.ILdapServerInput
    {

    }
    /// LDAP Server Output
    internal partial interface ILdapServerOutputInternal :
        JumpCloud.SDK.V2.Models.IComponentsSchemasLdapServerOutputAllof0Internal,
        JumpCloud.SDK.V2.Models.ILdapServerInputInternal
    {

    }
}