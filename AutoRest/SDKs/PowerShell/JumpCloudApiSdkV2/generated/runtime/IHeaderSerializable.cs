
using System;

namespace JumpCloudApiSdkV2.Runtime
{
    public interface IHeaderSerializable
    {
        void ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers);
    }
}