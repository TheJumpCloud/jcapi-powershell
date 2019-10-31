namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Active Directory Output</summary>
    public partial class ActiveDirectoryOutput :
        JumpCloudApiSdkV2.Models.IActiveDirectoryOutput,
        JumpCloudApiSdkV2.Models.IActiveDirectoryOutputInternal,
        JumpCloudApiSdkV2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloudApiSdkV2.Models.IActiveDirectoryInput" />
        /// </summary>
        private JumpCloudApiSdkV2.Models.IActiveDirectoryInput __activeDirectoryInput = new JumpCloudApiSdkV2.Models.ActiveDirectoryInput();

        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0"
        /// />
        /// </summary>
        private JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0 __componentsSchemasActiveDirectoryOutputAllof0 = new JumpCloudApiSdkV2.Models.ComponentsSchemasActiveDirectoryOutputAllof0();

        /// <summary>Domain name for this Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Domain { get => ((JumpCloudApiSdkV2.Models.IActiveDirectoryInputInternal)__activeDirectoryInput).Domain; set => ((JumpCloudApiSdkV2.Models.IActiveDirectoryInputInternal)__activeDirectoryInput).Domain = value; }

        /// <summary>ObjectID of this Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0Internal)__componentsSchemasActiveDirectoryOutputAllof0).Id; set => ((JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0Internal)__componentsSchemasActiveDirectoryOutputAllof0).Id = value; }

        /// <summary>Creates an new <see cref="ActiveDirectoryOutput" /> instance.</summary>
        public ActiveDirectoryOutput()
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
            await eventListener.AssertNotNull(nameof(__componentsSchemasActiveDirectoryOutputAllof0), __componentsSchemasActiveDirectoryOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasActiveDirectoryOutputAllof0), __componentsSchemasActiveDirectoryOutputAllof0);
            await eventListener.AssertNotNull(nameof(__activeDirectoryInput), __activeDirectoryInput);
            await eventListener.AssertObjectIsValid(nameof(__activeDirectoryInput), __activeDirectoryInput);
        }
    }
    /// Active Directory Output
    public partial interface IActiveDirectoryOutput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable,
        JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0,
        JumpCloudApiSdkV2.Models.IActiveDirectoryInput
    {

    }
    /// Active Directory Output
    internal partial interface IActiveDirectoryOutputInternal :
        JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0Internal,
        JumpCloudApiSdkV2.Models.IActiveDirectoryInputInternal
    {

    }
}