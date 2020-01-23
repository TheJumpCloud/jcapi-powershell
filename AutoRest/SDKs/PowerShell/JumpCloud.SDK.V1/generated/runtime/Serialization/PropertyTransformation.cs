using System;

namespace JumpCloud.SDK.V1.Runtime.Json
{
    internal class PropertyTransformation
    {
        internal PropertyTransformation(string name, Func<object, object> transformer)
        {
            Name        = name        ?? throw new ArgumentNullException(nameof(name));
            Transformer = transformer ?? throw new ArgumentNullException(nameof(transformer));
        }

        internal string Name { get; }

        internal Func<object, object> Transformer { get; }
    }
}