namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>
    /// FIXME: Class Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema is MISSING DESCRIPTION
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaTypeConverter))]
    public partial class Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema"
        /// />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema"
        /// />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema" />, deserializing
        /// the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserLockoutAction = (string) content.GetValueForProperty("UserLockoutAction",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserLockoutAction, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserPasswordExpirationAction = (string) content.GetValueForProperty("UserPasswordExpirationAction",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserPasswordExpirationAction, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserLockoutAction = (string) content.GetValueForProperty("UserLockoutAction",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserLockoutAction, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserPasswordExpirationAction = (string) content.GetValueForProperty("UserPasswordExpirationAction",((JumpCloud.SDK.V2.Models.IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaInternal)this).UserPasswordExpirationAction, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(Paths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchemaTypeConverter))]
    public partial interface IPaths1Dvt4UsLdapserversIdPatchResponses200ContentApplicationJsonSchema

    {

    }
}