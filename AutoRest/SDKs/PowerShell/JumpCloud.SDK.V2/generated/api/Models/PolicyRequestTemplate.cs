// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PolicyRequestTemplate :
        JumpCloud.SDK.V2.Models.IPolicyRequestTemplate,
        JumpCloud.SDK.V2.Models.IPolicyRequestTemplateInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="PolicyRequestTemplate" /> instance.</summary>
        public PolicyRequestTemplate()
        {

        }
    }
    public partial interface IPolicyRequestTemplate :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>ObjectId uniquely identifying a Policy instance; only allowed on POST requests.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
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