namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights System Info</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSystemInfoTypeConverter))]
    public partial class SystemInsightsSystemInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSystemInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsSystemInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSystemInfo"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsSystemInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsSystemInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSystemInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsSystemInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).ComputerName = (string) content.GetValueForProperty("ComputerName",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).ComputerName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuBrand = (string) content.GetValueForProperty("CpuBrand",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuBrand, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuLogicalCores = (int?) content.GetValueForProperty("CpuLogicalCores",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuLogicalCores, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuMicrocode = (string) content.GetValueForProperty("CpuMicrocode",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuMicrocode, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuPhysicalCores = (int?) content.GetValueForProperty("CpuPhysicalCores",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuPhysicalCores, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuSubtype = (string) content.GetValueForProperty("CpuSubtype",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuSubtype, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuType = (string) content.GetValueForProperty("CpuType",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareModel = (string) content.GetValueForProperty("HardwareModel",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareModel, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareSerial = (string) content.GetValueForProperty("HardwareSerial",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareSerial, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVendor = (string) content.GetValueForProperty("HardwareVendor",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVendor, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVersion = (string) content.GetValueForProperty("HardwareVersion",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVersion, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).LocalHostname = (string) content.GetValueForProperty("LocalHostname",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).LocalHostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).PhysicalMemory = (string) content.GetValueForProperty("PhysicalMemory",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).PhysicalMemory, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Uuid, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsSystemInfo"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsSystemInfo(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).ComputerName = (string) content.GetValueForProperty("ComputerName",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).ComputerName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuBrand = (string) content.GetValueForProperty("CpuBrand",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuBrand, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuLogicalCores = (int?) content.GetValueForProperty("CpuLogicalCores",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuLogicalCores, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuMicrocode = (string) content.GetValueForProperty("CpuMicrocode",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuMicrocode, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuPhysicalCores = (int?) content.GetValueForProperty("CpuPhysicalCores",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuPhysicalCores, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuSubtype = (string) content.GetValueForProperty("CpuSubtype",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuSubtype, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuType = (string) content.GetValueForProperty("CpuType",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).CpuType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareModel = (string) content.GetValueForProperty("HardwareModel",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareModel, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareSerial = (string) content.GetValueForProperty("HardwareSerial",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareSerial, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVendor = (string) content.GetValueForProperty("HardwareVendor",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVendor, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVersion = (string) content.GetValueForProperty("HardwareVersion",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).HardwareVersion, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).LocalHostname = (string) content.GetValueForProperty("LocalHostname",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).LocalHostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).PhysicalMemory = (string) content.GetValueForProperty("PhysicalMemory",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).PhysicalMemory, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfoInternal)this).Uuid, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights System Info
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSystemInfoTypeConverter))]
    public partial interface ISystemInsightsSystemInfo

    {

    }
}