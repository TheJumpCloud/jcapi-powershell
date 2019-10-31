namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>FIXME: Class ApplicationConfigIdpPrivateKey is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigIdpPrivateKeyTypeConverter))]
    public partial class ApplicationConfigIdpPrivateKey
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationConfigIdpPrivateKey(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Tooltip = (JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyTooltip) content.GetValueForProperty("Tooltip",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Tooltip, JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKeyTooltipTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Options = (string) content.GetValueForProperty("Options",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Options, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Position = (int?) content.GetValueForProperty("Position",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Position, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Toggle = (string) content.GetValueForProperty("Toggle",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Toggle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Value = (string) content.GetValueForProperty("Value",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Value, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipVariables = (JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipVariables, JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKeyTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKey"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationConfigIdpPrivateKey(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Tooltip = (JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyTooltip) content.GetValueForProperty("Tooltip",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Tooltip, JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKeyTooltipTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Options = (string) content.GetValueForProperty("Options",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Options, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Position = (int?) content.GetValueForProperty("Position",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Position, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Toggle = (string) content.GetValueForProperty("Toggle",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Toggle, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Value = (string) content.GetValueForProperty("Value",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Value, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipVariables = (JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipVariables, JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKeyTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKeyInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKey" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKey DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationConfigIdpPrivateKey(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.ApplicationConfigIdpPrivateKey"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKey" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKey DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new ApplicationConfigIdpPrivateKey(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationConfigIdpPrivateKey" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IApplicationConfigIdpPrivateKey FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IApplicationConfigIdpPrivateKey is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(ApplicationConfigIdpPrivateKeyTypeConverter))]
    public partial interface IApplicationConfigIdpPrivateKey

    {

    }
}