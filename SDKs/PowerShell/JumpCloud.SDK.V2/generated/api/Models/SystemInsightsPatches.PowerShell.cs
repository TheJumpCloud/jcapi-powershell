// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Patches</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsPatchesTypeConverter))]
    public partial class SystemInsightsPatches
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPatches"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsPatches" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsPatches DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsPatches(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPatches"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsPatches" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsPatches DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemInsightsPatches(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsPatches" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsPatches FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPatches"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsPatches(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Caption = (string) content.GetValueForProperty("Caption",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Caption, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Csname = (string) content.GetValueForProperty("Csname",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Csname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).FixComments = (string) content.GetValueForProperty("FixComments",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).FixComments, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).HotfixId = (string) content.GetValueForProperty("HotfixId",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).HotfixId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledBy = (string) content.GetValueForProperty("InstalledBy",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledBy, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledOn = (string) content.GetValueForProperty("InstalledOn",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledOn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPatches"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsPatches(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Caption = (string) content.GetValueForProperty("Caption",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Caption, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Csname = (string) content.GetValueForProperty("Csname",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).Csname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).FixComments = (string) content.GetValueForProperty("FixComments",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).FixComments, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).HotfixId = (string) content.GetValueForProperty("HotfixId",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).HotfixId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledBy = (string) content.GetValueForProperty("InstalledBy",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledBy, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledOn = (string) content.GetValueForProperty("InstalledOn",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).InstalledOn, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsPatchesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Patches
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsPatchesTypeConverter))]
    public partial interface ISystemInsightsPatches

    {

    }
}