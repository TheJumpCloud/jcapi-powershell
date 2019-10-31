namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Logical Drvies</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsLogicalDrviesTypeConverter))]
    public partial class SystemInsightsLogicalDrvies
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsLogicalDrvies"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrvies" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrvies DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsLogicalDrvies(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsLogicalDrvies"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrvies" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrvies DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsLogicalDrvies(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsLogicalDrvies" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrvies FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsLogicalDrvies"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsLogicalDrvies(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).BootPartition = (int?) content.GetValueForProperty("BootPartition",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).BootPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).DeviceId = (string) content.GetValueForProperty("DeviceId",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).DeviceId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FileSystem = (string) content.GetValueForProperty("FileSystem",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FileSystem, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FreeSpace = (string) content.GetValueForProperty("FreeSpace",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FreeSpace, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Size = (string) content.GetValueForProperty("Size",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Size, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsLogicalDrvies"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsLogicalDrvies(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).BootPartition = (int?) content.GetValueForProperty("BootPartition",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).BootPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).DeviceId = (string) content.GetValueForProperty("DeviceId",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).DeviceId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FileSystem = (string) content.GetValueForProperty("FileSystem",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FileSystem, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FreeSpace = (string) content.GetValueForProperty("FreeSpace",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).FreeSpace, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Size = (string) content.GetValueForProperty("Size",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).Size, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsLogicalDrviesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Logical Drvies
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsLogicalDrviesTypeConverter))]
    public partial interface ISystemInsightsLogicalDrvies

    {

    }
}