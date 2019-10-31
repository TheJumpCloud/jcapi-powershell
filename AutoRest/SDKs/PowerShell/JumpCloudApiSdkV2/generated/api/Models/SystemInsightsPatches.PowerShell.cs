namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsPatches"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsPatches" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsPatches DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsPatches(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsPatches"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsPatches" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsPatches DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsPatches(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsPatches" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsPatches FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsPatches"
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
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Caption = (string) content.GetValueForProperty("Caption",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Caption, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Csname = (string) content.GetValueForProperty("Csname",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Csname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).FixComments = (string) content.GetValueForProperty("FixComments",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).FixComments, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).HotfixId = (string) content.GetValueForProperty("HotfixId",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).HotfixId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledBy = (string) content.GetValueForProperty("InstalledBy",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledBy, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledOn = (string) content.GetValueForProperty("InstalledOn",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledOn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsPatches"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsPatches(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Caption = (string) content.GetValueForProperty("Caption",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Caption, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Csname = (string) content.GetValueForProperty("Csname",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).Csname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).FixComments = (string) content.GetValueForProperty("FixComments",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).FixComments, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).HotfixId = (string) content.GetValueForProperty("HotfixId",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).HotfixId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledBy = (string) content.GetValueForProperty("InstalledBy",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledBy, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledOn = (string) content.GetValueForProperty("InstalledOn",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).InstalledOn, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsPatchesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Patches
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsPatchesTypeConverter))]
    public partial interface ISystemInsightsPatches

    {

    }
}