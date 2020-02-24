// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights SIP Config</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSipConfigTypeConverter))]
    public partial class SystemInsightsSipConfig
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSipConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsSipConfig" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSipConfig DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsSipConfig(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSipConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsSipConfig" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSipConfig DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemInsightsSipConfig(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsSipConfig" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSipConfig FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSipConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsSipConfig(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).ConfigFlag = (string) content.GetValueForProperty("ConfigFlag",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).ConfigFlag, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).Enabled = (int?) content.GetValueForProperty("Enabled",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).Enabled, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).EnabledNvram = (int?) content.GetValueForProperty("EnabledNvram",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).EnabledNvram, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSipConfig"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsSipConfig(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).ConfigFlag = (string) content.GetValueForProperty("ConfigFlag",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).ConfigFlag, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).Enabled = (int?) content.GetValueForProperty("Enabled",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).Enabled, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).EnabledNvram = (int?) content.GetValueForProperty("EnabledNvram",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).EnabledNvram, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsSipConfigInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights SIP Config
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSipConfigTypeConverter))]
    public partial interface ISystemInsightsSipConfig

    {

    }
}