using System;

namespace JumpCloud.SDK.V2.Runtime.Json
{
    public sealed class JsonConverterAttribute : Attribute
    {
        internal JsonConverterAttribute(Type type)
        {
            Converter = (IJsonConverter)Activator.CreateInstance(type);
        }

        internal IJsonConverter Converter { get; }
    }
}