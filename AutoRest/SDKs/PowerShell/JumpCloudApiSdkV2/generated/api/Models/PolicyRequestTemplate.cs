namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class PolicyRequestTemplate :
        JumpCloudApiSdkV2.Models.IPolicyRequestTemplate,
        JumpCloudApiSdkV2.Models.IPolicyRequestTemplateInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="PolicyRequestTemplate" /> instance.</summary>
        public PolicyRequestTemplate()
        {

        }
    }
    public partial interface IPolicyRequestTemplate :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy instance; only allowed on POST requests.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    internal partial interface IPolicyRequestTemplateInternal

    {
        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        string Id { get; set; }

    }
}