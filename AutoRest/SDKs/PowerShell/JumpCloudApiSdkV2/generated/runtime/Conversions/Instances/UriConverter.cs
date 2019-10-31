using System;

namespace JumpCloudApiSdkV2.Runtime.Json
{
    public sealed class UriConverter : JsonConverter<Uri>
    {
        internal override JsonNode ToJson(Uri value) => new JsonString(value.AbsoluteUri);

        internal override Uri FromJson(JsonNode node) => (Uri)node;
    }
}