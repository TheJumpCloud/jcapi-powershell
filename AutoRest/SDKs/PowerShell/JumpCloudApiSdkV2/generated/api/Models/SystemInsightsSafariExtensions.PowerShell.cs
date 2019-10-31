namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Safari Extensions</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSafariExtensionsTypeConverter))]
    public partial class SystemInsightsSafariExtensions
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSafariExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensions" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsSafariExtensions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSafariExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensions" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensions DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsSafariExtensions(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsSafariExtensions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensions FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSafariExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsSafariExtensions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Author = (string) content.GetValueForProperty("Author",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Author, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).DeveloperId = (string) content.GetValueForProperty("DeveloperId",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).DeveloperId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Sdk = (string) content.GetValueForProperty("Sdk",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Sdk, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).UpdateUrl = (string) content.GetValueForProperty("UpdateUrl",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).UpdateUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSafariExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsSafariExtensions(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Author = (string) content.GetValueForProperty("Author",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Author, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).DeveloperId = (string) content.GetValueForProperty("DeveloperId",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).DeveloperId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Sdk = (string) content.GetValueForProperty("Sdk",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Sdk, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).UpdateUrl = (string) content.GetValueForProperty("UpdateUrl",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).UpdateUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsSafariExtensionsInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Safari Extensions
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSafariExtensionsTypeConverter))]
    public partial interface ISystemInsightsSafariExtensions

    {

    }
}