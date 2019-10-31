namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>
    /// See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(BulkUserCreateTypeConverter))]
    public partial class BulkUserCreate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.BulkUserCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BulkUserCreate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Attributes = (JumpCloudApiSdkV2.Models.IBulkUserCreateAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.IBulkUserCreateAttributesItem>(__y, JumpCloudApiSdkV2.Models.BulkUserCreateAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Username, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.BulkUserCreate"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal BulkUserCreate(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Attributes = (JumpCloudApiSdkV2.Models.IBulkUserCreateAttributesItem[]) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Attributes, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV2.Models.IBulkUserCreateAttributesItem>(__y, JumpCloudApiSdkV2.Models.BulkUserCreateAttributesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.IBulkUserCreateInternal)this).Username, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.BulkUserCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IBulkUserCreate" />.</returns>
        public static JumpCloudApiSdkV2.Models.IBulkUserCreate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BulkUserCreate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.BulkUserCreate"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IBulkUserCreate" />.</returns>
        public static JumpCloudApiSdkV2.Models.IBulkUserCreate DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new BulkUserCreate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BulkUserCreate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IBulkUserCreate FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.
    [System.ComponentModel.TypeConverter(typeof(BulkUserCreateTypeConverter))]
    public partial interface IBulkUserCreate

    {

    }
}