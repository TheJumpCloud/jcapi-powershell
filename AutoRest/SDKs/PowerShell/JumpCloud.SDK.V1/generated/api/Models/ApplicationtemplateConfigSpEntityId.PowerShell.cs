namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>FIXME: Class ApplicationtemplateConfigSpEntityId is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationtemplateConfigSpEntityIdTypeConverter))]
    public partial class ApplicationtemplateConfigSpEntityId
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityId"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationtemplateConfigSpEntityId(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Tooltip = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltip) content.GetValueForProperty("Tooltip",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Tooltip, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityIdTooltipTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Options = (string) content.GetValueForProperty("Options",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Options, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Position = (int?) content.GetValueForProperty("Position",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Position, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Toggle = (string) content.GetValueForProperty("Toggle",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Toggle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Value = (string) content.GetValueForProperty("Value",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Value, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipVariables = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipVariables, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityIdTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityId"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationtemplateConfigSpEntityId(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Tooltip = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltip) content.GetValueForProperty("Tooltip",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Tooltip, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityIdTooltipTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Options = (string) content.GetValueForProperty("Options",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Options, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Position = (int?) content.GetValueForProperty("Position",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Position, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).ReadOnly = (bool?) content.GetValueForProperty("ReadOnly",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).ReadOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Required = (bool?) content.GetValueForProperty("Required",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Required, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Toggle = (string) content.GetValueForProperty("Toggle",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Toggle, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Value = (string) content.GetValueForProperty("Value",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Value, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Visible = (bool?) content.GetValueForProperty("Visible",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).Visible, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipVariables = (JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables) content.GetValueForProperty("TooltipVariables",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipVariables, JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityIdTooltipVariablesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipTemplate = (string) content.GetValueForProperty("TooltipTemplate",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).TooltipTemplate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableIcon = (string) content.GetValueForProperty("VariableIcon",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableIcon, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableMessage = (string) content.GetValueForProperty("VariableMessage",((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)this).VariableMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityId"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationtemplateConfigSpEntityId(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityId"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new ApplicationtemplateConfigSpEntityId(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationtemplateConfigSpEntityId" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IApplicationtemplateConfigSpEntityId is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(ApplicationtemplateConfigSpEntityIdTypeConverter))]
    public partial interface IApplicationtemplateConfigSpEntityId

    {

    }
}