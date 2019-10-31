namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>
    /// FIXME: Class PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema is MISSING DESCRIPTION
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaTypeConverter))]
    public partial class PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema"
        /// />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema"
        /// />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema"
        /// />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaInternal)this).Message = (string) content.GetValueForProperty("Message",((JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaInternal)this).Message, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaInternal)this).Message = (string) content.GetValueForProperty("Message",((JumpCloudApiSdkV2.Models.IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaInternal)this).Message, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(PathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchemaTypeConverter))]
    public partial interface IPathsProvidersProviderIdAdministratorsGetResponses401ContentApplicationJsonSchema

    {

    }
}