namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>The graph connection's attributes</summary>
    [System.ComponentModel.TypeConverter(typeof(UserGraphManagementReqAttributesTypeConverter))]
    public partial class UserGraphManagementReqAttributes
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserGraphManagementReqAttributes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new UserGraphManagementReqAttributes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserGraphManagementReqAttributes" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserGraphManagementReqAttributes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).Sudo = (JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).Sudo, JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal UserGraphManagementReqAttributes(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).Sudo = (JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).Sudo, JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// The graph connection's attributes
    [System.ComponentModel.TypeConverter(typeof(UserGraphManagementReqAttributesTypeConverter))]
    public partial interface IUserGraphManagementReqAttributes

    {

    }
}