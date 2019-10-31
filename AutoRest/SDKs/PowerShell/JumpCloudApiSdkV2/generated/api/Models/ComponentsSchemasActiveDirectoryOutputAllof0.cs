namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class ComponentsSchemasActiveDirectoryOutputAllof0 :
        JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0,
        JumpCloudApiSdkV2.Models.IComponentsSchemasActiveDirectoryOutputAllof0Internal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectID of this Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>
        /// Creates an new <see cref="ComponentsSchemasActiveDirectoryOutputAllof0" /> instance.
        /// </summary>
        public ComponentsSchemasActiveDirectoryOutputAllof0()
        {

        }
    }
    public partial interface IComponentsSchemasActiveDirectoryOutputAllof0 :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>ObjectID of this Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"ObjectID of this Active Directory instance.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    internal partial interface IComponentsSchemasActiveDirectoryOutputAllof0Internal

    {
        /// <summary>ObjectID of this Active Directory instance.</summary>
        string Id { get; set; }

    }
}