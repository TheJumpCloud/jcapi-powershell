namespace JumpCloud.SDK.V1.Runtime.Json
{
    public sealed class JsonObjectConverter : JsonConverter<JsonObject>
    {
        internal override JsonNode ToJson(JsonObject value) => value;

        internal override JsonObject FromJson(JsonNode node) => (JsonObject)node;
    }
}