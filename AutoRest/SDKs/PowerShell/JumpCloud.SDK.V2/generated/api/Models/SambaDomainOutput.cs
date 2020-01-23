namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Samba Domain Output</summary>
    public partial class SambaDomainOutput :
        JumpCloud.SDK.V2.Models.ISambaDomainOutput,
        JumpCloud.SDK.V2.Models.ISambaDomainOutputInternal,
        JumpCloud.SDK.V2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.IComponentsSchemasSambaDomainOutputAllof0" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.IComponentsSchemasSambaDomainOutputAllof0 __componentsSchemasSambaDomainOutputAllof0 = new JumpCloud.SDK.V2.Models.ComponentsSchemasSambaDomainOutputAllof0();

        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.ISambaDomainInput" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.ISambaDomainInput __sambaDomainInput = new JumpCloud.SDK.V2.Models.SambaDomainInput();

        /// <summary>Unique identifier of this domain</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloud.SDK.V2.Models.IComponentsSchemasSambaDomainOutputAllof0Internal)__componentsSchemasSambaDomainOutputAllof0).Id; set => ((JumpCloud.SDK.V2.Models.IComponentsSchemasSambaDomainOutputAllof0Internal)__componentsSchemasSambaDomainOutputAllof0).Id = value; }

        /// <summary>Name of this domain's WorkGroup</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Name { get => ((JumpCloud.SDK.V2.Models.ISambaDomainInputInternal)__sambaDomainInput).Name; set => ((JumpCloud.SDK.V2.Models.ISambaDomainInputInternal)__sambaDomainInput).Name = value; }

        /// <summary>Security identifier of this domain</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Sid { get => ((JumpCloud.SDK.V2.Models.ISambaDomainInputInternal)__sambaDomainInput).Sid; set => ((JumpCloud.SDK.V2.Models.ISambaDomainInputInternal)__sambaDomainInput).Sid = value; }

        /// <summary>Creates an new <see cref="SambaDomainOutput" /> instance.</summary>
        public SambaDomainOutput()
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
            await eventListener.AssertNotNull(nameof(__componentsSchemasSambaDomainOutputAllof0), __componentsSchemasSambaDomainOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasSambaDomainOutputAllof0), __componentsSchemasSambaDomainOutputAllof0);
            await eventListener.AssertNotNull(nameof(__sambaDomainInput), __sambaDomainInput);
            await eventListener.AssertObjectIsValid(nameof(__sambaDomainInput), __sambaDomainInput);
        }
    }
    /// Samba Domain Output
    public partial interface ISambaDomainOutput :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable,
        JumpCloud.SDK.V2.Models.IComponentsSchemasSambaDomainOutputAllof0,
        JumpCloud.SDK.V2.Models.ISambaDomainInput
    {

    }
    /// Samba Domain Output
    internal partial interface ISambaDomainOutputInternal :
        JumpCloud.SDK.V2.Models.IComponentsSchemasSambaDomainOutputAllof0Internal,
        JumpCloud.SDK.V2.Models.ISambaDomainInputInternal
    {

    }
}