// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PathsZ8Y5PeProvidersProviderIdAdministratorsPostResponses401ContentSchema :
        JumpCloud.SDK.V2.Models.IPathsZ8Y5PeProvidersProviderIdAdministratorsPostResponses401ContentSchema,
        JumpCloud.SDK.V2.Models.IPathsZ8Y5PeProvidersProviderIdAdministratorsPostResponses401ContentSchemaInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="PathsZ8Y5PeProvidersProviderIdAdministratorsPostResponses401ContentSchema" /> instance.
        /// </summary>
        public PathsZ8Y5PeProvidersProviderIdAdministratorsPostResponses401ContentSchema()
        {

        }
    }
    public partial interface IPathsZ8Y5PeProvidersProviderIdAdministratorsPostResponses401ContentSchema :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface IPathsZ8Y5PeProvidersProviderIdAdministratorsPostResponses401ContentSchemaInternal

    {
        string Message { get; set; }

    }
}