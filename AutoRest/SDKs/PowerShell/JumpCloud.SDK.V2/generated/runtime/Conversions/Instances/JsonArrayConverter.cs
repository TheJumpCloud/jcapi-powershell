﻿namespace JumpCloud.SDK.V2.Runtime.Json
{
    public sealed class JsonArrayConverter : JsonConverter<JsonArray>
    {
        internal override JsonNode ToJson(JsonArray value) => value;

        internal override JsonArray FromJson(JsonNode node) => (JsonArray)node;
    }
}