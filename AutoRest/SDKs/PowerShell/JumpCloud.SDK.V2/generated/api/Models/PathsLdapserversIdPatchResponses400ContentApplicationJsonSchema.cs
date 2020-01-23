namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class PathsLdapserversIdPatchResponses400ContentApplicationJsonSchema :
        JumpCloud.SDK.V2.Models.IPathsLdapserversIdPatchResponses400ContentApplicationJsonSchema,
        JumpCloud.SDK.V2.Models.IPathsLdapserversIdPatchResponses400ContentApplicationJsonSchemaInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>
        /// Creates an new <see cref="PathsLdapserversIdPatchResponses400ContentApplicationJsonSchema" /> instance.
        /// </summary>
        public PathsLdapserversIdPatchResponses400ContentApplicationJsonSchema()
        {

        }
    }
    public partial interface IPathsLdapserversIdPatchResponses400ContentApplicationJsonSchema :
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
    internal partial interface IPathsLdapserversIdPatchResponses400ContentApplicationJsonSchemaInternal

    {
        string Message { get; set; }

    }
}