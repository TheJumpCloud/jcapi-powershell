namespace JumpCloudApiSdkV2.Runtime.Json
{
    internal interface IJsonConverter
    {
        JsonNode ToJson(object value);

        object FromJson(JsonNode node);
    }
}