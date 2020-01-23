namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Chrome Extensions</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsChromeExtensionsTypeConverter))]
    public partial class SystemInsightsChromeExtensions
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsChromeExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensions" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsChromeExtensions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsChromeExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensions" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensions DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsChromeExtensions(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsChromeExtensions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensions FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsChromeExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsChromeExtensions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Author = (string) content.GetValueForProperty("Author",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Author, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Locale = (string) content.GetValueForProperty("Locale",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Locale, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Permissions = (string) content.GetValueForProperty("Permissions",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Permissions, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Persistent = (int?) content.GetValueForProperty("Persistent",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Persistent, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).UpdateUrl = (string) content.GetValueForProperty("UpdateUrl",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).UpdateUrl, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsChromeExtensions"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsChromeExtensions(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Author = (string) content.GetValueForProperty("Author",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Author, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Locale = (string) content.GetValueForProperty("Locale",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Locale, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Permissions = (string) content.GetValueForProperty("Permissions",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Permissions, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Persistent = (int?) content.GetValueForProperty("Persistent",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Persistent, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).UpdateUrl = (string) content.GetValueForProperty("UpdateUrl",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).UpdateUrl, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V2.Models.ISystemInsightsChromeExtensionsInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Chrome Extensions
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsChromeExtensionsTypeConverter))]
    public partial interface ISystemInsightsChromeExtensions

    {

    }
}