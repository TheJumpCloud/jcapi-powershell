// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>EmailRequest</summary>
    public partial class Emailrequest :
        JumpCloud.SDK.V2.Models.IEmailrequest,
        JumpCloud.SDK.V2.Models.IEmailrequestInternal
    {

        /// <summary>Backing field for <see cref="EmailType" /> property.</summary>
        private string _emailType;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string EmailType { get => this._emailType; set => this._emailType = value; }

        /// <summary>Creates an new <see cref="Emailrequest" /> instance.</summary>
        public Emailrequest()
        {

        }
    }
    /// EmailRequest
    public partial interface IEmailrequest :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"emailType",
        PossibleTypes = new [] { typeof(string) })]
        string EmailType { get; set; }

    }
    /// EmailRequest
    internal partial interface IEmailrequestInternal

    {
        string EmailType { get; set; }

    }
}