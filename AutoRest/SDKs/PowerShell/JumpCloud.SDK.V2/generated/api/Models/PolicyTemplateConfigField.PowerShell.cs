namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateConfigField"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyTemplateConfigField(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateConfigField"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new PolicyTemplateConfigField(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyTemplateConfigField" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyTemplateConfigField FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateConfigField"
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
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltip) content.GetValueForProperty("Tooltip",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTooltipTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldDisplayOptions) content.GetValueForProperty("DisplayOptions",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldDisplayOptionsTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType = (string) content.GetValueForProperty("DisplayType",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Position = (float?) content.GetValueForProperty("Position",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Position, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyTemplateConfigField"
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
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltip) content.GetValueForProperty("Tooltip",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Tooltip, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTooltipTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DefaultValue, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldDisplayOptions) content.GetValueForProperty("DisplayOptions",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayOptions, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldDisplayOptionsTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType = (string) content.GetValueForProperty("DisplayType",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).DisplayType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Position = (float?) content.GetValueForProperty("Position",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Position, (__y)=> (float) global::System.Convert.ChangeType(__y, typeof(float)));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables = (JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipVariables, JumpCloud.SDK.V2.Models.PolicyTemplateConfigFieldTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V2.Models.IPolicyTemplateConfigFieldInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// PolicyTemplateConfigField
    [System.ComponentModel.TypeConverter(typeof(PolicyTemplateConfigFieldTypeConverter))]
    public partial interface IPolicyTemplateConfigField

    {

    }
}