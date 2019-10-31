namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class ComponentsSchemasSambaDomainOutputAllof0 :
        JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0,
        JumpCloudApiSdkV2.Models.IComponentsSchemasSambaDomainOutputAllof0Internal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Unique identifier of this domain</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasSambaDomainOutputAllof0" /> instance.
        /// </summary>
        public ComponentsSchemasSambaDomainOutputAllof0()
        {

        }
    }
    public partial interface IComponentsSchemasSambaDomainOutputAllof0 :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>Unique identifier of this domain</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Unique identifier of this domain",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    internal partial interface IComponentsSchemasSambaDomainOutputAllof0Internal

    {
        /// <summary>Unique identifier of this domain</summary>
        string Id { get; set; }

    }
}