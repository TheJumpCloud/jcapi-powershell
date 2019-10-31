namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Samba Domain Output</summary>
    public partial class SambaDomainOutput :
        JumpCloudApiSdkV2.Models.ISambaDomainOutput,
        JumpCloudApiSdkV2.Models.ISambaDomainOutputInternal,
        JumpCloudApiSdkV2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0" />
        /// </summary>
        private JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0 __componentsSchemasSambaDomainOutputAllof0 = new JumpCloudApiSdkV2.Models.ComponentsSchemasSambaDomainOutputAllof0();

        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloudApiSdkV2.Models.ISambaDomainInput" />
        /// </summary>
        private JumpCloudApiSdkV2.Models.ISambaDomainInput __sambaDomainInput = new JumpCloudApiSdkV2.Models.SambaDomainInput();

        /// <summary>Unique identifier of this domain</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0Internal)__componentsSchemasSambaDomainOutputAllof0).Id; set => ((JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0Internal)__componentsSchemasSambaDomainOutputAllof0).Id = value; }

        /// <summary>Name of this domain's WorkGroup</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Name { get => ((JumpCloudApiSdkV2.Models.ISambaDomainInputInternal)__sambaDomainInput).Name; set => ((JumpCloudApiSdkV2.Models.ISambaDomainInputInternal)__sambaDomainInput).Name = value; }

        /// <summary>Security identifier of this domain</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Sid { get => ((JumpCloudApiSdkV2.Models.ISambaDomainInputInternal)__sambaDomainInput).Sid; set => ((JumpCloudApiSdkV2.Models.ISambaDomainInputInternal)__sambaDomainInput).Sid = value; }

        /// <summary>Creates an new <see cref="SambaDomainOutput" /> instance.</summary>
        public SambaDomainOutput()
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
            await eventListener.AssertNotNull(nameof(__componentsSchemasSambaDomainOutputAllof0), __componentsSchemasSambaDomainOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasSambaDomainOutputAllof0), __componentsSchemasSambaDomainOutputAllof0);
            await eventListener.AssertNotNull(nameof(__sambaDomainInput), __sambaDomainInput);
            await eventListener.AssertObjectIsValid(nameof(__sambaDomainInput), __sambaDomainInput);
        }
    }
    /// Samba Domain Output
    public partial interface ISambaDomainOutput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable,
        JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0,
        JumpCloudApiSdkV2.Models.ISambaDomainInput
    {

    }
    /// Samba Domain Output
    internal partial interface ISambaDomainOutputInternal :
        JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0Internal,
        JumpCloudApiSdkV2.Models.ISambaDomainInputInternal
    {

    }
}