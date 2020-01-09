namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>Case</summary>
    [System.ComponentModel.TypeConverter(typeof(CaseTypeConverter))]
    public partial class Case
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Case"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Case(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Subject = (string) content.GetValueForProperty("Subject",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Subject, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Case"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Case(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICaseInternal)this).Subject = (string) content.GetValueForProperty("Subject",((JumpCloudApiSdkV1.Models.ICaseInternal)this).Subject, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Case"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ICase" />.</returns>
        public static JumpCloudApiSdkV1.Models.ICase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Case(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Case"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ICase" />.</returns>
        public static JumpCloudApiSdkV1.Models.ICase DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Case(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Case" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.ICase FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Case
    [System.ComponentModel.TypeConverter(typeof(CaseTypeConverter))]
    public partial interface ICase

    {

    }
}