namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Active Directory Output</summary>
    public partial class ActiveDirectoryOutput :
        JumpCloud.SDK.V2.Models.IActiveDirectoryOutput,
        JumpCloud.SDK.V2.Models.IActiveDirectoryOutputInternal,
        JumpCloud.SDK.V2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.IActiveDirectoryInput" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.IActiveDirectoryInput __activeDirectoryInput = new JumpCloud.SDK.V2.Models.ActiveDirectoryInput();

        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.IComponentsSchemasActiveDirectoryOutputAllof0" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.IComponentsSchemasActiveDirectoryOutputAllof0 __componentsSchemasActiveDirectoryOutputAllof0 = new JumpCloud.SDK.V2.Models.ComponentsSchemasActiveDirectoryOutputAllof0();

        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Domain { get => ((JumpCloud.SDK.V2.Models.IActiveDirectoryInputInternal)__activeDirectoryInput).Domain; set => ((JumpCloud.SDK.V2.Models.IActiveDirectoryInputInternal)__activeDirectoryInput).Domain = value; }

        /// <summary>ObjectID of this Active Directory instance.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloud.SDK.V2.Models.IComponentsSchemasActiveDirectoryOutputAllof0Internal)__componentsSchemasActiveDirectoryOutputAllof0).Id; set => ((JumpCloud.SDK.V2.Models.IComponentsSchemasActiveDirectoryOutputAllof0Internal)__componentsSchemasActiveDirectoryOutputAllof0).Id = value; }

        /// <summary>Creates an new <see cref="ActiveDirectoryOutput" /> instance.</summary>
        public ActiveDirectoryOutput()
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
            await eventListener.AssertNotNull(nameof(__componentsSchemasActiveDirectoryOutputAllof0), __componentsSchemasActiveDirectoryOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasActiveDirectoryOutputAllof0), __componentsSchemasActiveDirectoryOutputAllof0);
            await eventListener.AssertNotNull(nameof(__activeDirectoryInput), __activeDirectoryInput);
            await eventListener.AssertObjectIsValid(nameof(__activeDirectoryInput), __activeDirectoryInput);
        }
    }
    /// Active Directory Output
    public partial interface IActiveDirectoryOutput :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable,
        JumpCloud.SDK.V2.Models.IComponentsSchemasActiveDirectoryOutputAllof0,
        JumpCloud.SDK.V2.Models.IActiveDirectoryInput
    {

    }
    /// Active Directory Output
    internal partial interface IActiveDirectoryOutputInternal :
        JumpCloud.SDK.V2.Models.IComponentsSchemasActiveDirectoryOutputAllof0Internal,
        JumpCloud.SDK.V2.Models.IActiveDirectoryInputInternal
    {

    }
}