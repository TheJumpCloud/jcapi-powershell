/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace JumpCloud.SDK.V2.Runtime.Json
{
    internal partial class JsonBoolean
    {
        internal static JsonBoolean Create(bool? value) => value is bool b ? new JsonBoolean(b) : null;
        internal bool ToBoolean() => Value;

        internal override object ToValue() => Value;
    }


}