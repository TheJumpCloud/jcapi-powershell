namespace JumpCloud.SDK.V1.Runtime.Json
{
    public sealed class DoubleConverter : JsonConverter<double>
    {
        internal override JsonNode ToJson(double value) => new JsonNumber(value);

        internal override double FromJson(JsonNode node) => (double)node;
    }
}