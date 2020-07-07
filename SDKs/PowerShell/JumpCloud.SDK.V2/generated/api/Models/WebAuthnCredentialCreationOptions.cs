// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Creation options for a WebAuthn credential.</summary>
    public partial class WebAuthnCredentialCreationOptions :
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptions,
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal
    {

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string AuthenticatorSelectionAuthenticatorAttachment { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelectionAuthenticatorAttachment; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelectionAuthenticatorAttachment = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? AuthenticatorSelectionRequireResidentKey { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelectionRequireResidentKey; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelectionRequireResidentKey = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string AuthenticatorSelectionUserVerification { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelectionUserVerification; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelectionUserVerification = value; }

        /// <summary>Internal Acessors for PublicKey</summary>
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKey JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal.PublicKey { get => (this._publicKey = this._publicKey ?? new JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKey()); set { {_publicKey = value;} } }

        /// <summary>Internal Acessors for PublicKeyAuthenticatorSelection</summary>
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyAuthenticatorSelection JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal.PublicKeyAuthenticatorSelection { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelection; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).AuthenticatorSelection = value; }

        /// <summary>Internal Acessors for PublicKeyRp</summary>
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyRp JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal.PublicKeyRp { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Rp; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Rp = value; }

        /// <summary>Internal Acessors for PublicKeyUser</summary>
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyUser JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal.PublicKeyUser { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).User; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).User = value; }

        /// <summary>Backing field for <see cref="PublicKey" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKey _publicKey;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKey PublicKey { get => (this._publicKey = this._publicKey ?? new JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKey()); set => this._publicKey = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string PublicKeyAttestation { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Attestation; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Attestation = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string PublicKeyChallenge { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Challenge; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Challenge = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem[] PublicKeyPubKeyCredParams { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).PubKeyCredParams; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).PubKeyCredParams = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public int? PublicKeyTimeout { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Timeout; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).Timeout = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string RpIcon { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).RpIcon; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).RpIcon = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string RpId { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).RpId; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).RpId = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string RpName { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).RpName; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).RpName = value; }

        /// <summary>Backing field for <see cref="Token" /> property.</summary>
        private string _token;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Token { get => this._token; set => this._token = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string UserDisplayName { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserDisplayName; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserDisplayName = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string UserIcon { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserIcon; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserIcon = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string UserId { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserId; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserId = value; }

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string UserName { get => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserName; set => ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyInternal)PublicKey).UserName = value; }

        /// <summary>Creates an new <see cref="WebAuthnCredentialCreationOptions" /> instance.</summary>
        public WebAuthnCredentialCreationOptions()
        {

        }
    }
    /// Creation options for a WebAuthn credential.
    public partial interface IWebAuthnCredentialCreationOptions :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"authenticatorAttachment",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticatorSelectionAuthenticatorAttachment { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"requireResidentKey",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AuthenticatorSelectionRequireResidentKey { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"userVerification",
        PossibleTypes = new [] { typeof(string) })]
        string AuthenticatorSelectionUserVerification { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attestation",
        PossibleTypes = new [] { typeof(string) })]
        string PublicKeyAttestation { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"challenge",
        PossibleTypes = new [] { typeof(string) })]
        string PublicKeyChallenge { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"pubKeyCredParams",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem) })]
        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem[] PublicKeyPubKeyCredParams { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(int) })]
        int? PublicKeyTimeout { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string RpIcon { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string RpId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RpName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"token",
        PossibleTypes = new [] { typeof(string) })]
        string Token { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string UserDisplayName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string UserIcon { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string UserId { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Creation options for a WebAuthn credential.
    internal partial interface IWebAuthnCredentialCreationOptionsInternal

    {
        string AuthenticatorSelectionAuthenticatorAttachment { get; set; }

        bool? AuthenticatorSelectionRequireResidentKey { get; set; }

        string AuthenticatorSelectionUserVerification { get; set; }

        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKey PublicKey { get; set; }

        string PublicKeyAttestation { get; set; }

        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyAuthenticatorSelection PublicKeyAuthenticatorSelection { get; set; }

        string PublicKeyChallenge { get; set; }

        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem[] PublicKeyPubKeyCredParams { get; set; }

        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyRp PublicKeyRp { get; set; }

        int? PublicKeyTimeout { get; set; }

        JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyUser PublicKeyUser { get; set; }

        string RpIcon { get; set; }

        string RpId { get; set; }

        string RpName { get; set; }

        string Token { get; set; }

        string UserDisplayName { get; set; }

        string UserIcon { get; set; }

        string UserId { get; set; }

        string UserName { get; set; }

    }
}