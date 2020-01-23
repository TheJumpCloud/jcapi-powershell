namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PathsProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema :
        JumpCloud.SDK.V2.Models.IPathsProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema,
        JumpCloud.SDK.V2.Models.IPathsProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="PathsProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public PathsProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchema :
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
    internal partial interface IPathsProvidersProviderIdAdministratorsPostResponses401ContentApplicationJsonSchemaInternal

    {
        string Message { get; set; }

    }
}