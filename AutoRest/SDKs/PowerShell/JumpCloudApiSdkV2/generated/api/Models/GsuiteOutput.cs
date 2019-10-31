namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>GSuite Output</summary>
    public partial class GsuiteOutput :
        JumpCloudApiSdkV2.Models.IGsuiteOutput,
        JumpCloudApiSdkV2.Models.IGsuiteOutputInternal,
        JumpCloudApiSdkV2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0" />
        /// </summary>
        private JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0 __componentsSchemasGsuiteOutputAllof0 = new JumpCloudApiSdkV2.Models.ComponentsSchemasGsuiteOutputAllof0();

        /// <summary>FIXME: Property Id is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).Id; set => ((JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).Id = value; }

        /// <summary>FIXME: Property UserLockoutAction is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string UserLockoutAction { get => ((JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserLockoutAction; set => ((JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserLockoutAction = value; }

        /// <summary>FIXME: Property UserPasswordExpirationAction is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inherited)]
        public string UserPasswordExpirationAction { get => ((JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserPasswordExpirationAction; set => ((JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="GsuiteOutput" /> instance.</summary>
        public GsuiteOutput()
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
            await eventListener.AssertNotNull(nameof(__componentsSchemasGsuiteOutputAllof0), __componentsSchemasGsuiteOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasGsuiteOutputAllof0), __componentsSchemasGsuiteOutputAllof0);
        }
    }
    /// GSuite Output
    public partial interface IGsuiteOutput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable,
        JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0
    {

    }
    /// GSuite Output
    internal partial interface IGsuiteOutputInternal :
        JumpCloudApiSdkV2.Models.IComponentsSchemasGsuiteOutputAllof0Internal
    {

    }
}