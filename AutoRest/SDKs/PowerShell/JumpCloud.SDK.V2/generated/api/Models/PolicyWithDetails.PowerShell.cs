namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>An instance of a policy template.</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyWithDetailsTypeConverter))]
    public partial class PolicyWithDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyWithDetails" />.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyWithDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyWithDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyWithDetails" />.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyWithDetails DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new PolicyWithDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyWithDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyWithDetails FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyWithDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Template = (JumpCloud.SDK.V2.Models.IPolicyTemplate) content.GetValueForProperty("Template",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Template, JumpCloud.SDK.V2.Models.PolicyTemplateTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).ConfigFields = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField[]) content.GetValueForProperty("ConfigFields",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).ConfigFields, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField>(__y, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Values = (JumpCloud.SDK.V2.Models.IPolicyValue[]) content.GetValueForProperty("Values",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Values, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IPolicyValue>(__y, JumpCloud.SDK.V2.Models.PolicyValueTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateName = (string) content.GetValueForProperty("TemplateName",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDescription = (string) content.GetValueForProperty("TemplateDescription",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDescription, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateActivation = (string) content.GetValueForProperty("TemplateActivation",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateActivation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateBehavior = (string) content.GetValueForProperty("TemplateBehavior",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateBehavior, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDisplayName = (string) content.GetValueForProperty("TemplateDisplayName",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateId = (string) content.GetValueForProperty("TemplateId",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateOSMetaFamily = (string) content.GetValueForProperty("TemplateOSMetaFamily",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateOSMetaFamily, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateState = (string) content.GetValueForProperty("TemplateState",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateState, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyWithDetails"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyWithDetails(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Template = (JumpCloud.SDK.V2.Models.IPolicyTemplate) content.GetValueForProperty("Template",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Template, JumpCloud.SDK.V2.Models.PolicyTemplateTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).ConfigFields = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField[]) content.GetValueForProperty("ConfigFields",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).ConfigFields, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField>(__y, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Values = (JumpCloud.SDK.V2.Models.IPolicyValue[]) content.GetValueForProperty("Values",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).Values, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IPolicyValue>(__y, JumpCloud.SDK.V2.Models.PolicyValueTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateName = (string) content.GetValueForProperty("TemplateName",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDescription = (string) content.GetValueForProperty("TemplateDescription",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDescription, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateActivation = (string) content.GetValueForProperty("TemplateActivation",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateActivation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateBehavior = (string) content.GetValueForProperty("TemplateBehavior",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateBehavior, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDisplayName = (string) content.GetValueForProperty("TemplateDisplayName",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateDisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateId = (string) content.GetValueForProperty("TemplateId",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateOSMetaFamily = (string) content.GetValueForProperty("TemplateOSMetaFamily",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateOSMetaFamily, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateState = (string) content.GetValueForProperty("TemplateState",((JumpCloud.SDK.V2.Models.IPolicyWithDetailsInternal)this).TemplateState, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An instance of a policy template.
    [System.ComponentModel.TypeConverter(typeof(PolicyWithDetailsTypeConverter))]
    public partial interface IPolicyWithDetails

    {

    }
}