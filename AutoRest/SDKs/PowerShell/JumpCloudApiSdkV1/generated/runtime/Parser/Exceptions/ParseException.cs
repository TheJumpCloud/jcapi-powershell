using System;

namespace JumpCloudApiSdkV1.Runtime.Json
{
    internal class ParserException : Exception
    {
        internal ParserException(string message)
            : base(message)
        { }

        internal ParserException(string message, SourceLocation location)
            : base(message)
        {

            Location = location;
        }

        internal SourceLocation Location { get; }
    }
}