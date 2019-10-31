namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>The graph connection's attributes</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemGraphManagementReqAttributesTypeConverter))]
    public partial class SystemGraphManagementReqAttributes
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemGraphManagementReqAttributes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemGraphManagementReqAttributes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemGraphManagementReqAttributes" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributes FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemGraphManagementReqAttributes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).Sudo = (JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).Sudo, JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemGraphManagementReqAttributes(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).Sudo = (JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesSudo) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).Sudo, JumpCloudApiSdkV2.Models.SystemGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloudApiSdkV2.Models.ISystemGraphManagementReqAttributesInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The graph connection's attributes
    [System.ComponentModel.TypeConverter(typeof(SystemGraphManagementReqAttributesTypeConverter))]
    public partial interface ISystemGraphManagementReqAttributes

    {

    }
}