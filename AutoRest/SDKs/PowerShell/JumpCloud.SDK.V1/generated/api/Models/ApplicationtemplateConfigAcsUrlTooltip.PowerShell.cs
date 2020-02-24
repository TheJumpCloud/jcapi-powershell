// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ApplicationtemplateConfigAcsUrlTooltipTypeConverter))]
    public partial class ApplicationtemplateConfigAcsUrlTooltip
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationtemplateConfigAcsUrlTooltip(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Variables = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables) content.GetValueForProperty("Variables",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Variables, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrlTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Template = (string) content.GetValueForProperty("Template",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Template, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationtemplateConfigAcsUrlTooltip(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Variables = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables) content.GetValueForProperty("Variables",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Variables, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrlTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Template = (string) content.GetValueForProperty("Template",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).Template, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltip" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltip DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationtemplateConfigAcsUrlTooltip(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltip" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltip DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationtemplateConfigAcsUrlTooltip(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationtemplateConfigAcsUrlTooltip" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltip FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ApplicationtemplateConfigAcsUrlTooltipTypeConverter))]
    public partial interface IApplicationtemplateConfigAcsUrlTooltip

    {

    }
}