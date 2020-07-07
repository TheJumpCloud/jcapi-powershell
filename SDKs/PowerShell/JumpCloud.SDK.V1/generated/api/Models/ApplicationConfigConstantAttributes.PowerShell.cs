// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigConstantAttributesTypeConverter))]
    public partial class ApplicationConfigConstantAttributes
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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationConfigConstantAttributes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Tooltip = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltip) content.GetValueForProperty("Tooltip",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Tooltip, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltipTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Mutable = (bool?) content.GetValueForProperty("Mutable",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Mutable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Options = (string) content.GetValueForProperty("Options",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Options, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Position = (int?) content.GetValueForProperty("Position",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Position, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Toggle = (string) content.GetValueForProperty("Toggle",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Toggle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Value = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesValueItem[]) content.GetValueForProperty("Value",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Value, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesValueItem>(__y, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesValueItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipVariables = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipVariables, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationConfigConstantAttributes(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Tooltip = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltip) content.GetValueForProperty("Tooltip",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Tooltip, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltipTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Mutable = (bool?) content.GetValueForProperty("Mutable",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Mutable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Options = (string) content.GetValueForProperty("Options",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Options, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Position = (int?) content.GetValueForProperty("Position",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Position, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Toggle = (string) content.GetValueForProperty("Toggle",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Toggle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Value = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesValueItem[]) content.GetValueForProperty("Value",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Value, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesValueItem>(__y, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesValueItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipVariables = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipVariables, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributes" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationConfigConstantAttributes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributes" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributes DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationConfigConstantAttributes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationConfigConstantAttributes" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributes FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigConstantAttributesTypeConverter))]
    public partial interface IApplicationConfigConstantAttributes

    {

    }
}