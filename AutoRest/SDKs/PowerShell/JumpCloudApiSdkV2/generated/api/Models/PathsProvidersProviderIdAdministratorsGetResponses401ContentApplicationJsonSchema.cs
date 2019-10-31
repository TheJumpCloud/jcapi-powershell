namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema :
        JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema,
        JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaInternal

    {
        string Message { get; set; }

    }
}