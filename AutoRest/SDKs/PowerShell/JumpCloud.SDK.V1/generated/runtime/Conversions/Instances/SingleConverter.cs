namespace JumpCloud.SDK.V1.Runtime.Json
{
    public sealed class SingleConverter : JsonConverter<float>
    {
        internal override JsonNode ToJson(float value) => new JsonNumber(value.ToString());

        internal override float FromJson(JsonNode node) => (float)node;
    }
}