/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
﻿namespace JumpCloud.SDK.DirectoryInsights.Runtime.Json
{
    public sealed class BooleanConverter : JsonConverter<bool>
    {
        internal override JsonNode ToJson(bool value) => new JsonBoolean(value);

        internal override bool FromJson(JsonNode node) => (bool)node;
    }
}