namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>Group</summary>
    [System.ComponentModel.TypeConverter(typeof(GroupTypeConverter))]
    public partial class Group
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.Group"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IGroup" />.</returns>
        public static JumpCloudApiSdkV2.Models.IGroup DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Group(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.Group"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IGroup" />.</returns>
        public static JumpCloudApiSdkV2.Models.IGroup DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Group(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Group" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IGroup FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.Group"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Group(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Attributes = (JumpCloudApiSdkV2.Models.IGroupAttributes) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Attributes, JumpCloudApiSdkV2.Models.GroupAttributesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.Group"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Group(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Attributes = (JumpCloudApiSdkV2.Models.IGroupAttributes) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Attributes, JumpCloudApiSdkV2.Models.GroupAttributesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IGroupInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IGroupInternal)this).Id, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Group
    [System.ComponentModel.TypeConverter(typeof(GroupTypeConverter))]
    public partial interface IGroup

    {

    }
}