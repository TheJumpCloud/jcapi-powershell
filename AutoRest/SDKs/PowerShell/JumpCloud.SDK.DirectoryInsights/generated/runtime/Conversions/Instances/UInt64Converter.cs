/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace JumpCloud.SDK.DirectoryInsights.Runtime.Json
{
    public sealed class UInt64Converter : JsonConverter<ulong>
    {
        internal override JsonNode ToJson(ulong value) => new JsonNumber(value.ToString());

        internal override ulong FromJson(JsonNode node) => (ulong)node;
    }
}