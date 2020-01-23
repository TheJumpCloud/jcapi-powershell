namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights System Controls</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSystemControlsTypeConverter))]
    public partial class SystemInsightsSystemControls
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSystemControls"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsSystemControls" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSystemControls DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsSystemControls(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSystemControls"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsSystemControls" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSystemControls DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsSystemControls(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsSystemControls" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSystemControls FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSystemControls"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsSystemControls(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).ConfigValue = (string) content.GetValueForProperty("ConfigValue",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).ConfigValue, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CurrentValue = (string) content.GetValueForProperty("CurrentValue",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CurrentValue, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).FieldName = (string) content.GetValueForProperty("FieldName",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).FieldName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Oid = (string) content.GetValueForProperty("Oid",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Oid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Subsystem = (string) content.GetValueForProperty("Subsystem",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Subsystem, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSystemControls"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsSystemControls(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).ConfigValue = (string) content.GetValueForProperty("ConfigValue",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).ConfigValue, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CurrentValue = (string) content.GetValueForProperty("CurrentValue",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).CurrentValue, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).FieldName = (string) content.GetValueForProperty("FieldName",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).FieldName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Oid = (string) content.GetValueForProperty("Oid",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Oid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Subsystem = (string) content.GetValueForProperty("Subsystem",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).Subsystem, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsSystemControlsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights System Controls
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSystemControlsTypeConverter))]
    public partial interface ISystemInsightsSystemControls

    {

    }
}