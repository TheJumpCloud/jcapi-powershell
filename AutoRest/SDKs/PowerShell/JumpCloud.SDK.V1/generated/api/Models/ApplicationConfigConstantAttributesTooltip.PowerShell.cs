namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>FIXME: Class ApplicationConfigConstantAttributesTooltip is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigConstantAttributesTooltipTypeConverter))]
    public partial class ApplicationConfigConstantAttributesTooltip
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationConfigConstantAttributesTooltip(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Variables = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipVariables) content.GetValueForProperty("Variables",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Variables, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Template = (string) content.GetValueForProperty("Template",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Template, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationConfigConstantAttributesTooltip(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Variables = (JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipVariables) content.GetValueForProperty("Variables",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Variables, JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Template = (string) content.GetValueForProperty("Template",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).Template, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltipInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltip" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltip DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationConfigConstantAttributesTooltip(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationConfigConstantAttributesTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltip" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltip DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new ApplicationConfigConstantAttributesTooltip(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationConfigConstantAttributesTooltip" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationConfigConstantAttributesTooltip FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IApplicationConfigConstantAttributesTooltip is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigConstantAttributesTooltipTypeConverter))]
    public partial interface IApplicationConfigConstantAttributesTooltip

    {

    }
}