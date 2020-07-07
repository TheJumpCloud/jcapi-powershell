// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>Creation options for a WebAuthn credential.</summary>
    [System.ComponentModel.TypeConverter(typeof(WebAuthnCredentialCreationOptionsTypeConverter))]
    public partial class WebAuthnCredentialCreationOptions
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptions" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WebAuthnCredentialCreationOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptions" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptions DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WebAuthnCredentialCreationOptions(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WebAuthnCredentialCreationOptions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptions FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WebAuthnCredentialCreationOptions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKey = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKey) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKey, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).Token = (string) content.GetValueForProperty("Token",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).Token, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAuthenticatorSelection = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyAuthenticatorSelection) content.GetValueForProperty("PublicKeyAuthenticatorSelection",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAuthenticatorSelection, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyAuthenticatorSelectionTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyRp = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyRp) content.GetValueForProperty("PublicKeyRp",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyRp, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyRpTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyUser = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyUser) content.GetValueForProperty("PublicKeyUser",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyUser, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyUserTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAttestation = (string) content.GetValueForProperty("PublicKeyAttestation",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAttestation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyChallenge = (string) content.GetValueForProperty("PublicKeyChallenge",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyChallenge, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyPubKeyCredParams = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem[]) content.GetValueForProperty("PublicKeyPubKeyCredParams",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyPubKeyCredParams, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem>(__y, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyTimeout = (int?) content.GetValueForProperty("PublicKeyTimeout",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyTimeout, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionAuthenticatorAttachment = (string) content.GetValueForProperty("AuthenticatorSelectionAuthenticatorAttachment",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionAuthenticatorAttachment, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionRequireResidentKey = (bool?) content.GetValueForProperty("AuthenticatorSelectionRequireResidentKey",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionRequireResidentKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionUserVerification = (string) content.GetValueForProperty("AuthenticatorSelectionUserVerification",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionUserVerification, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpName = (string) content.GetValueForProperty("RpName",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpIcon = (string) content.GetValueForProperty("RpIcon",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpId = (string) content.GetValueForProperty("RpId",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserName = (string) content.GetValueForProperty("UserName",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserDisplayName = (string) content.GetValueForProperty("UserDisplayName",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserDisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserIcon = (string) content.GetValueForProperty("UserIcon",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserId = (string) content.GetValueForProperty("UserId",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WebAuthnCredentialCreationOptions(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKey = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKey) content.GetValueForProperty("PublicKey",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKey, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).Token = (string) content.GetValueForProperty("Token",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).Token, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAuthenticatorSelection = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyAuthenticatorSelection) content.GetValueForProperty("PublicKeyAuthenticatorSelection",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAuthenticatorSelection, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyAuthenticatorSelectionTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyRp = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyRp) content.GetValueForProperty("PublicKeyRp",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyRp, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyRpTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyUser = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyUser) content.GetValueForProperty("PublicKeyUser",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyUser, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyUserTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAttestation = (string) content.GetValueForProperty("PublicKeyAttestation",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyAttestation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyChallenge = (string) content.GetValueForProperty("PublicKeyChallenge",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyChallenge, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyPubKeyCredParams = (JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem[]) content.GetValueForProperty("PublicKeyPubKeyCredParams",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyPubKeyCredParams, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItem>(__y, JumpCloud.SDK.V2.Models.WebAuthnCredentialCreationOptionsPublicKeyPubKeyCredParamsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyTimeout = (int?) content.GetValueForProperty("PublicKeyTimeout",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).PublicKeyTimeout, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionAuthenticatorAttachment = (string) content.GetValueForProperty("AuthenticatorSelectionAuthenticatorAttachment",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionAuthenticatorAttachment, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionRequireResidentKey = (bool?) content.GetValueForProperty("AuthenticatorSelectionRequireResidentKey",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionRequireResidentKey, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionUserVerification = (string) content.GetValueForProperty("AuthenticatorSelectionUserVerification",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).AuthenticatorSelectionUserVerification, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpName = (string) content.GetValueForProperty("RpName",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpIcon = (string) content.GetValueForProperty("RpIcon",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpId = (string) content.GetValueForProperty("RpId",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).RpId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserName = (string) content.GetValueForProperty("UserName",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserDisplayName = (string) content.GetValueForProperty("UserDisplayName",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserDisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserIcon = (string) content.GetValueForProperty("UserIcon",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserId = (string) content.GetValueForProperty("UserId",((JumpCloud.SDK.V2.Models.IWebAuthnCredentialCreationOptionsInternal)this).UserId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Creation options for a WebAuthn credential.
    [System.ComponentModel.TypeConverter(typeof(WebAuthnCredentialCreationOptionsTypeConverter))]
    public partial interface IWebAuthnCredentialCreationOptions

    {

    }
}