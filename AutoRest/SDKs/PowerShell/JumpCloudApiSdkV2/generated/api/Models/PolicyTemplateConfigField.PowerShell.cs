namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>PolicyTemplateConfigField</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyTemplateConfigFieldTypeConverter))]
    public partial class PolicyTemplateConfigField
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplateConfigField"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyTemplateConfigField(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplateConfigField"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new PolicyTemplateConfigField(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyTemplateConfigField" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IPolicyTemplateConfigField FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplateConfigField"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyTemplateConfigField(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip = (JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltip) content.GetValueForProperty("Tooltip",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip, JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltipTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions = (JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldDisplayOptions) content.GetValueForProperty("DisplayOptions",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions, JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldDisplayOptionsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType = (string) content.GetValueForProperty("DisplayType",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Position = (float?) content.GetValueForProperty("Position",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Position, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables = (JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables, JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.PolicyTemplateConfigField"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyTemplateConfigField(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip = (JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltip) content.GetValueForProperty("Tooltip",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip, JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltipTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions = (JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldDisplayOptions) content.GetValueForProperty("DisplayOptions",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions, JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldDisplayOptionsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType = (string) content.GetValueForProperty("DisplayType",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Position = (float?) content.GetValueForProperty("Position",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Position, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables = (JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables, JumpCloudApiSdkV2.Models.PolicyTemplateConfigFieldTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloudApiSdkV2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// PolicyTemplateConfigField
    [System.ComponentModel.TypeConverter(typeof(PolicyTemplateConfigFieldTypeConverter))]
    public partial interface IPolicyTemplateConfigField

    {

    }
}