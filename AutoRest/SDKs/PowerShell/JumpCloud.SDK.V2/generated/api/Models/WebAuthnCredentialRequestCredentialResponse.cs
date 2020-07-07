// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class WebAuthnCredentialRequestCredentialResponse :
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialRequestCredentialResponse,
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialRequestCredentialResponseInternal
    {

        /// <summary>Backing field for <see cref="AttestationObject" /> property.</summary>
        private string _attestationObject;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string AttestationObject { get => this._attestationObject; set => this._attestationObject = value; }

        /// <summary>Backing field for <see cref="ClientDataJson" /> property.</summary>
        private string _clientDataJson;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string ClientDataJson { get => this._clientDataJson; set => this._clientDataJson = value; }

        /// <summary>
        /// Creates an new <see cref="WebAuthnCredentialRequestCredentialResponse" /> instance.
        /// </summary>
        public WebAuthnCredentialRequestCredentialResponse()
        {

        }
    }
    public partial interface IWebAuthnCredentialRequestCredentialResponse :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attestationObject",
        PossibleTypes = new [] { typeof(string) })]
        string AttestationObject { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clientDataJSON",
        PossibleTypes = new [] { typeof(string) })]
        string ClientDataJson { get; set; }

    }
    internal partial interface IWebAuthnCredentialRequestCredentialResponseInternal

    {
        string AttestationObject { get; set; }

        string ClientDataJson { get; set; }

    }
}