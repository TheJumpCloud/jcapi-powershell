namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>The shallow information about a Policy Template.</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyTemplateWithDetailsTypeConverter))]
    public partial class PolicyTemplateWithDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetails" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyTemplateWithDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetails" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetails DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new PolicyTemplateWithDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyTemplateWithDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetails FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyTemplateWithDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Activation = (string) content.GetValueForProperty("Activation",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Activation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Behavior = (string) content.GetValueForProperty("Behavior",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Behavior, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).ConfigFields = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField[]) content.GetValueForProperty("ConfigFields",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).ConfigFields, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField>(__y, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).OSMetaFamily = (string) content.GetValueForProperty("OSMetaFamily",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).OSMetaFamily, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyTemplateWithDetails(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Activation = (string) content.GetValueForProperty("Activation",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Activation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Behavior = (string) content.GetValueForProperty("Behavior",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Behavior, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).ConfigFields = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField[]) content.GetValueForProperty("ConfigFields",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).ConfigFields, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField>(__y, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).OSMetaFamily = (string) content.GetValueForProperty("OSMetaFamily",((JumpCloud.SDK.V2.Models.IPolicyTemplateWithDetailsInternal)this).OSMetaFamily, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The shallow information about a Policy Template.
    [System.ComponentModel.TypeConverter(typeof(PolicyTemplateWithDetailsTypeConverter))]
    public partial interface IPolicyTemplateWithDetails

    {

    }
}