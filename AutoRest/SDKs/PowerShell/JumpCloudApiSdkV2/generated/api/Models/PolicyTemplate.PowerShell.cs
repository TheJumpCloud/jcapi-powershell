namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>The shallow information about a Policy Template.</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyTemplateTypeConverter))]
    public partial class PolicyTemplate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IPolicyTemplate" />.</returns>
        public static JumpCloudApiSdkV2.Models.IPolicyTemplate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyTemplate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplate"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IPolicyTemplate" />.</returns>
        public static JumpCloudApiSdkV2.Models.IPolicyTemplate DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new PolicyTemplate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyTemplate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IPolicyTemplate FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyTemplate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Activation = (string) content.GetValueForProperty("Activation",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Activation, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Behavior = (string) content.GetValueForProperty("Behavior",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Behavior, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).OSMetaFamily = (string) content.GetValueForProperty("OSMetaFamily",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).OSMetaFamily, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).State, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplate"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyTemplate(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Activation = (string) content.GetValueForProperty("Activation",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Activation, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Behavior = (string) content.GetValueForProperty("Behavior",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Behavior, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).OSMetaFamily = (string) content.GetValueForProperty("OSMetaFamily",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).OSMetaFamily, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloudApiSdkV2.Models.IPolicyTemplateInternal)this).State, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The shallow information about a Policy Template.
    [System.ComponentModel.TypeConverter(typeof(PolicyTemplateTypeConverter))]
    public partial interface IPolicyTemplate

    {

    }
}