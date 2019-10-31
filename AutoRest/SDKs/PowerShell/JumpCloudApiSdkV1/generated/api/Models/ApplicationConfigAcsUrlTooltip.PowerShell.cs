namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>FIXME: Class ApplicationConfigAcsUrlTooltip is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigAcsUrlTooltipTypeConverter))]
    public partial class ApplicationConfigAcsUrlTooltip
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationConfigAcsUrlTooltip(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Variables = (JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipVariables) content.GetValueForProperty("Variables",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Variables, JumpCloudApiSdkV1.Models.ApplicationConfigAcsUrlTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Template = (string) content.GetValueForProperty("Template",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Template, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationConfigAcsUrlTooltip(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Variables = (JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipVariables) content.GetValueForProperty("Variables",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Variables, JumpCloudApiSdkV1.Models.ApplicationConfigAcsUrlTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Template = (string) content.GetValueForProperty("Template",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).Template, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltipInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltip" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltip DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationConfigAcsUrlTooltip(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigAcsUrlTooltip"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltip" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltip DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new ApplicationConfigAcsUrlTooltip(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationConfigAcsUrlTooltip" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IApplicationConfigAcsUrlTooltip FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IApplicationConfigAcsUrlTooltip is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigAcsUrlTooltipTypeConverter))]
    public partial interface IApplicationConfigAcsUrlTooltip

    {

    }
}