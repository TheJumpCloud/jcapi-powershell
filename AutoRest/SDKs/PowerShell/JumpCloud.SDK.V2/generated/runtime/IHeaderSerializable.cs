
using System;

namespace JumpCloud.SDK.V2.Runtime
{
    public interface IHeaderSerializable
    {
        void ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers);
    }
}