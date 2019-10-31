namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>LDAP Server Output</summary>
    public partial class LdapServerOutput :
        JumpCloudApiSdkV2.Models.ILdapServerOutput,
        JumpCloudApiSdkV2.Models.ILdapServerOutputInternal,
        JumpCloudApiSdkV2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloudApiSdkV2.Models.IComponentsSchemasLdapServerOutputAllof0" />
        /// </summary>
        private JumpCloudApiSdkV2.Models.IComponentsSchemasLdapServerOutputAllof0 __componentsSchemasLdapServerOutputAllof0 = new JumpCloudApiSdkV2.Models.ComponentsSchemasLdapServerOutputAllof0();

        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloudApiSdkV2.Models.ILdapServerInput" />
        /// </summary>
        private JumpCloudApiSdkV2.Models.ILdapServerInput __ldapServerInput = new JumpCloudApiSdkV2.Models.LdapServerInput();

        /// <summary>Unique identifier of this LDAP server</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloudApiSdkV2.Models.IComponentsSchemasLdapServerOutputAllof0Internal)__componentsSchemasLdapServerOutputAllof0).Id; set => ((JumpCloudApiSdkV2.Models.IComponentsSchemasLdapServerOutputAllof0Internal)__componentsSchemasLdapServerOutputAllof0).Id = value; }

        /// <summary>The name of this LDAP server</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Name { get => ((JumpCloudApiSdkV2.Models.ILdapServerInputInternal)__ldapServerInput).Name; set => ((JumpCloudApiSdkV2.Models.ILdapServerInputInternal)__ldapServerInput).Name = value; }

        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string UserLockoutAction { get => ((JumpCloudApiSdkV2.Models.ILdapServerInputInternal)__ldapServerInput).UserLockoutAction; set => ((JumpCloudApiSdkV2.Models.ILdapServerInputInternal)__ldapServerInput).UserLockoutAction = value; }

        /// <summary>action to take; one of 'remove' or 'disable'</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string UserPasswordExpirationAction { get => ((JumpCloudApiSdkV2.Models.ILdapServerInputInternal)__ldapServerInput).UserPasswordExpirationAction; set => ((JumpCloudApiSdkV2.Models.ILdapServerInputInternal)__ldapServerInput).UserPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="LdapServerOutput" /> instance.</summary>
        public LdapServerOutput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="JumpCloudApiSdkV2.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(JumpCloudApiSdkV2.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__componentsSchemasLdapServerOutputAllof0), __componentsSchemasLdapServerOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasLdapServerOutputAllof0), __componentsSchemasLdapServerOutputAllof0);
            await eventListener.AssertNotNull(nameof(__ldapServerInput), __ldapServerInput);
            await eventListener.AssertObjectIsValid(nameof(__ldapServerInput), __ldapServerInput);
        }
    }
    /// LDAP Server Output
    public partial interface ILdapServerOutput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable,
        JumpCloudApiSdkV2.Models.IComponentsSchemasLdapServerOutputAllof0,
        JumpCloudApiSdkV2.Models.ILdapServerInput
    {

    }
    /// LDAP Server Output
    internal partial interface ILdapServerOutputInternal :
        JumpCloudApiSdkV2.Models.IComponentsSchemasLdapServerOutputAllof0Internal,
        JumpCloudApiSdkV2.Models.ILdapServerInputInternal
    {

    }
}