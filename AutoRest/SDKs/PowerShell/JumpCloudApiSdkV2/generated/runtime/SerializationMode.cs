namespace JumpCloudApiSdkV2.Runtime
{
    [System.Flags]
    public enum SerializationMode
    {
        None = 0,
        IncludeHeaders = 1 << 0,
        IncludeReadOnly = 1 << 1,

        IncludeAll = IncludeHeaders | IncludeReadOnly
    }
}