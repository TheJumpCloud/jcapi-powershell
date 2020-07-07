// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>PaymentParams</summary>
    public partial class PaymentParams :
        JumpCloud.SDK.V2.Models.IPaymentParams,
        JumpCloud.SDK.V2.Models.IPaymentParamsInternal
    {

        /// <summary>Backing field for <see cref="PublishableKey" /> property.</summary>
        private string _publishableKey;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string PublishableKey { get => this._publishableKey; set => this._publishableKey = value; }

        /// <summary>Creates an new <see cref="PaymentParams" /> instance.</summary>
        public PaymentParams()
        {

        }
    }
    /// PaymentParams
    public partial interface IPaymentParams :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"publishableKey",
        PossibleTypes = new [] { typeof(string) })]
        string PublishableKey { get; set; }

    }
    /// PaymentParams
    internal partial interface IPaymentParamsInternal

    {
        string PublishableKey { get; set; }

    }
}