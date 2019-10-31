namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Error</summary>
    public partial class Error :
        JumpCloudApiSdkV2.Models.IError,
        JumpCloudApiSdkV2.Models.IErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private int? _code;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Fields" /> property.</summary>
        private string _fields;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Fields { get => this._fields; set => this._fields = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="Error" /> instance.</summary>
        public Error()
        {

        }
    }
    /// Error
    public partial interface IError :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(int) })]
        int? Code { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"fields",
        PossibleTypes = new [] { typeof(string) })]
        string Fields { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Error
    internal partial interface IErrorInternal

    {
        int? Code { get; set; }

        string Fields { get; set; }

        string Message { get; set; }

    }
}