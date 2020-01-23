namespace JumpCloud.SDK.V1.Runtime.Json
{
    internal interface IJsonConverter
    {
        JsonNode ToJson(object value);

        object FromJson(JsonNode node);
    }
}