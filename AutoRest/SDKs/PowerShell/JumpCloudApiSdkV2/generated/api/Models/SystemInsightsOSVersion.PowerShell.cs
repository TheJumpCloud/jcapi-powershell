namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights OS Version</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsOSVersionTypeConverter))]
    public partial class SystemInsightsOSVersion
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsOSVersion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsOSVersion" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsOSVersion DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsOSVersion(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsOSVersion"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsOSVersion" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsOSVersion DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsOSVersion(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsOSVersion" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsOSVersion FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsOSVersion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsOSVersion(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Build = (string) content.GetValueForProperty("Build",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Build, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Codename = (string) content.GetValueForProperty("Codename",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Codename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Major = (int?) content.GetValueForProperty("Major",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Major, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Minor = (int?) content.GetValueForProperty("Minor",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Minor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Patch = (int?) content.GetValueForProperty("Patch",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Patch, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Platform = (string) content.GetValueForProperty("Platform",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Platform, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).PlatformLike = (string) content.GetValueForProperty("PlatformLike",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).PlatformLike, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsOSVersion"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsOSVersion(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Build = (string) content.GetValueForProperty("Build",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Build, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Codename = (string) content.GetValueForProperty("Codename",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Codename, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).InstallDate = (string) content.GetValueForProperty("InstallDate",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).InstallDate, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Major = (int?) content.GetValueForProperty("Major",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Major, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Minor = (int?) content.GetValueForProperty("Minor",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Minor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Patch = (int?) content.GetValueForProperty("Patch",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Patch, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Platform = (string) content.GetValueForProperty("Platform",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Platform, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).PlatformLike = (string) content.GetValueForProperty("PlatformLike",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).PlatformLike, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsOSVersionInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights OS Version
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsOSVersionTypeConverter))]
    public partial interface ISystemInsightsOSVersion

    {

    }
}