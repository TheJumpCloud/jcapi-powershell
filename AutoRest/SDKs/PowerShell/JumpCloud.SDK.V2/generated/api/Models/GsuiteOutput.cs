namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>GSuite Output</summary>
    public partial class GsuiteOutput :
        JumpCloud.SDK.V2.Models.IGsuiteOutput,
        JumpCloud.SDK.V2.Models.IGsuiteOutputInternal,
        JumpCloud.SDK.V2.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0" />
        /// </summary>
        private JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0 __componentsSchemasGsuiteOutputAllof0 = new JumpCloud.SDK.V2.Models.ComponentsSchemasGsuiteOutputAllof0();

        /// <summary>FIXME: Property Id is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string Id { get => ((JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).Id; set => ((JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).Id = value; }

        /// <summary>FIXME: Property UserLockoutAction is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string UserLockoutAction { get => ((JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserLockoutAction; set => ((JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserLockoutAction = value; }

        /// <summary>FIXME: Property UserPasswordExpirationAction is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inherited)]
        public string UserPasswordExpirationAction { get => ((JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserPasswordExpirationAction; set => ((JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0Internal)__componentsSchemasGsuiteOutputAllof0).UserPasswordExpirationAction = value; }

        /// <summary>Creates an new <see cref="GsuiteOutput" /> instance.</summary>
        public GsuiteOutput()
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
            await eventListener.AssertNotNull(nameof(__componentsSchemasGsuiteOutputAllof0), __componentsSchemasGsuiteOutputAllof0);
            await eventListener.AssertObjectIsValid(nameof(__componentsSchemasGsuiteOutputAllof0), __componentsSchemasGsuiteOutputAllof0);
        }
    }
    /// GSuite Output
    public partial interface IGsuiteOutput :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable,
        JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0
    {

    }
    /// GSuite Output
    internal partial interface IGsuiteOutputInternal :
        JumpCloud.SDK.V2.Models.IComponentsSchemasGsuiteOutputAllof0Internal
    {

    }
}