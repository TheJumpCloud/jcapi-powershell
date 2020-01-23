namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Disk Info</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsDiskInfoTypeConverter))]
    public partial class SystemInsightsDiskInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsDiskInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfo" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsDiskInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsDiskInfo"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfo" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfo DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsDiskInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsDiskInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfo FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsDiskInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsDiskInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskIndex = (int?) content.GetValueForProperty("DiskIndex",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskIndex, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskSize = (string) content.GetValueForProperty("DiskSize",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskSize, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).HardwareModel = (string) content.GetValueForProperty("HardwareModel",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).HardwareModel, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Manufacturer, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Partitions = (int?) content.GetValueForProperty("Partitions",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Partitions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).PnpDeviceId = (string) content.GetValueForProperty("PnpDeviceId",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).PnpDeviceId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Serial = (string) content.GetValueForProperty("Serial",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Serial, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsDiskInfo"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsDiskInfo(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskIndex = (int?) content.GetValueForProperty("DiskIndex",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskIndex, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskSize = (string) content.GetValueForProperty("DiskSize",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).DiskSize, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).HardwareModel = (string) content.GetValueForProperty("HardwareModel",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).HardwareModel, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Manufacturer, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Partitions = (int?) content.GetValueForProperty("Partitions",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Partitions, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).PnpDeviceId = (string) content.GetValueForProperty("PnpDeviceId",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).PnpDeviceId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Serial = (string) content.GetValueForProperty("Serial",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).Serial, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsDiskInfoInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Disk Info
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsDiskInfoTypeConverter))]
    public partial interface ISystemInsightsDiskInfo

    {

    }
}