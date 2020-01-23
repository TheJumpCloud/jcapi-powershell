namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>Auth Input Object</summary>
    [System.ComponentModel.TypeConverter(typeof(AuthInputObjectTypeConverter))]
    public partial class AuthInputObject
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
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(System.Management.Automation.PSObject content);

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
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.AuthInputObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AuthInputObject(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).Auth = (JumpCloud.SDK.V2.Models.IAuthInput) content.GetValueForProperty("Auth",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).Auth, JumpCloud.SDK.V2.Models.AuthInputTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthBasic = (JumpCloud.SDK.V2.Models.IAuthInputBasic) content.GetValueForProperty("AuthBasic",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthBasic, JumpCloud.SDK.V2.Models.AuthInputBasicTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthOauth = (JumpCloud.SDK.V2.Models.IAuthInputOauth) content.GetValueForProperty("AuthOauth",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthOauth, JumpCloud.SDK.V2.Models.AuthInputOauthTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicPassword = (string) content.GetValueForProperty("BasicPassword",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicPassword, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicUsername = (string) content.GetValueForProperty("BasicUsername",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicUsername, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).OauthCode = (string) content.GetValueForProperty("OauthCode",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).OauthCode, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.AuthInputObject"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal AuthInputObject(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).Auth = (JumpCloud.SDK.V2.Models.IAuthInput) content.GetValueForProperty("Auth",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).Auth, JumpCloud.SDK.V2.Models.AuthInputTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthBasic = (JumpCloud.SDK.V2.Models.IAuthInputBasic) content.GetValueForProperty("AuthBasic",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthBasic, JumpCloud.SDK.V2.Models.AuthInputBasicTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthOauth = (JumpCloud.SDK.V2.Models.IAuthInputOauth) content.GetValueForProperty("AuthOauth",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).AuthOauth, JumpCloud.SDK.V2.Models.AuthInputOauthTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicPassword = (string) content.GetValueForProperty("BasicPassword",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicPassword, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicUsername = (string) content.GetValueForProperty("BasicUsername",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).BasicUsername, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).OauthCode = (string) content.GetValueForProperty("OauthCode",((JumpCloud.SDK.V2.Models.IAuthInputObjectInternal)this).OauthCode, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.AuthInputObject"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IAuthInputObject" />.</returns>
        public static JumpCloud.SDK.V2.Models.IAuthInputObject DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AuthInputObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.AuthInputObject"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IAuthInputObject" />.</returns>
        public static JumpCloud.SDK.V2.Models.IAuthInputObject DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new AuthInputObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AuthInputObject" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IAuthInputObject FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Auth Input Object
    [System.ComponentModel.TypeConverter(typeof(AuthInputObjectTypeConverter))]
    public partial interface IAuthInputObject

    {

    }
}