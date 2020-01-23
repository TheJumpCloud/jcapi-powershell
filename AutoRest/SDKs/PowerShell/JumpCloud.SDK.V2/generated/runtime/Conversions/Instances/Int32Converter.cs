namespace JumpCloud.SDK.V2.Runtime.Json
{
    public sealed class Int32Converter : JsonConverter<int>
    {
        internal override JsonNode ToJson(int value) => new JsonNumber(value);

        internal override int FromJson(JsonNode node) => (int)node;
    }
}