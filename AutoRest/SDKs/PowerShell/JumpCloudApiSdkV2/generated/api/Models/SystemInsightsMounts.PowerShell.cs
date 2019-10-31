namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Mounts</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsMountsTypeConverter))]
    public partial class SystemInsightsMounts
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsMounts"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsMounts" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsMounts DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsMounts(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsMounts"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsMounts" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsMounts DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsMounts(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsMounts" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsMounts FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsMounts"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsMounts(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Blocks = (string) content.GetValueForProperty("Blocks",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Blocks, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksAvailable = (string) content.GetValueForProperty("BlocksAvailable",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksAvailable, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksFree = (string) content.GetValueForProperty("BlocksFree",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksFree, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksSize = (string) content.GetValueForProperty("BlocksSize",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksSize, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Device = (string) content.GetValueForProperty("Device",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Device, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).DeviceAlias = (string) content.GetValueForProperty("DeviceAlias",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).DeviceAlias, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Flags = (string) content.GetValueForProperty("Flags",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Flags, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Inodes = (string) content.GetValueForProperty("Inodes",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Inodes, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).InodesFree = (string) content.GetValueForProperty("InodesFree",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).InodesFree, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsMounts"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsMounts(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Blocks = (string) content.GetValueForProperty("Blocks",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Blocks, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksAvailable = (string) content.GetValueForProperty("BlocksAvailable",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksAvailable, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksFree = (string) content.GetValueForProperty("BlocksFree",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksFree, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksSize = (string) content.GetValueForProperty("BlocksSize",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).BlocksSize, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Device = (string) content.GetValueForProperty("Device",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Device, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).DeviceAlias = (string) content.GetValueForProperty("DeviceAlias",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).DeviceAlias, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Flags = (string) content.GetValueForProperty("Flags",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Flags, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Inodes = (string) content.GetValueForProperty("Inodes",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).Inodes, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).InodesFree = (string) content.GetValueForProperty("InodesFree",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).InodesFree, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsMountsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Mounts
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsMountsTypeConverter))]
    public partial interface ISystemInsightsMounts

    {

    }
}