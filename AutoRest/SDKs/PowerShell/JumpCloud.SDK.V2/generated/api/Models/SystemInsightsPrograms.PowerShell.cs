namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Programs</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsProgramsTypeConverter))]
    public partial class SystemInsightsPrograms
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPrograms"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsPrograms" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsPrograms DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsPrograms(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPrograms"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsPrograms" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsPrograms DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsPrograms(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsPrograms" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsPrograms FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPrograms"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsPrograms(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).IdentifyingNumber = (string) content.GetValueForProperty("IdentifyingNumber",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).IdentifyingNumber, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallLocation = (string) content.GetValueForProperty("InstallLocation",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallLocation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallSource = (string) content.GetValueForProperty("InstallSource",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallSource, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Language = (string) content.GetValueForProperty("Language",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Language, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Publisher, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).UninstallString = (string) content.GetValueForProperty("UninstallString",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).UninstallString, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsPrograms"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsPrograms(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).IdentifyingNumber = (string) content.GetValueForProperty("IdentifyingNumber",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).IdentifyingNumber, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallLocation = (string) content.GetValueForProperty("InstallLocation",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallLocation, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallSource = (string) content.GetValueForProperty("InstallSource",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).InstallSource, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Language = (string) content.GetValueForProperty("Language",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Language, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Publisher, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).UninstallString = (string) content.GetValueForProperty("UninstallString",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).UninstallString, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V2.Models.ISystemInsightsProgramsInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Programs
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsProgramsTypeConverter))]
    public partial interface ISystemInsightsPrograms

    {

    }
}