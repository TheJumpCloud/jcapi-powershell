
using System;

namespace JumpCloud.SDK.V1.Runtime
{
    public interface IHeaderSerializable
    {
        void ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers);
    }
}