namespace JumpCloud.SDK.V1.Runtime.Json
{
    internal partial class JsonBoolean
    {
        internal static JsonBoolean Create(bool? value) => value is bool b ? new JsonBoolean(b) : null;
        internal bool ToBoolean() => Value;

        internal override object ToValue() => Value;
    }


}