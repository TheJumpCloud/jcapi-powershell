// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>ErrorResponse</summary>
    public partial class Errorresponse :
        JumpCloud.SDK.V2.Models.IErrorresponse,
        JumpCloud.SDK.V2.Models.IErrorresponseInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="Errorresponse" /> instance.</summary>
        public Errorresponse()
        {

        }
    }
    /// ErrorResponse
    public partial interface IErrorresponse :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// ErrorResponse
    internal partial interface IErrorresponseInternal

    {
        string Message { get; set; }

    }
}