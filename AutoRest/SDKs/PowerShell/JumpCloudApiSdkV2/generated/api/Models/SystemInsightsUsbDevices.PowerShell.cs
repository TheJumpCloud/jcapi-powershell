namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights USB Devices</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsUsbDevicesTypeConverter))]
    public partial class SystemInsightsUsbDevices
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsbDevices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsUsbDevices(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsbDevices"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsUsbDevices(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsUsbDevices" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsbDevices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsUsbDevices(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Class = (string) content.GetValueForProperty("Class",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Class, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Model = (string) content.GetValueForProperty("Model",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Model, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).ModelId = (string) content.GetValueForProperty("ModelId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).ModelId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Protocol = (string) content.GetValueForProperty("Protocol",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Protocol, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Removable = (int?) content.GetValueForProperty("Removable",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Removable, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Serial = (string) content.GetValueForProperty("Serial",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Serial, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Subclass = (string) content.GetValueForProperty("Subclass",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Subclass, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbAddress = (int?) content.GetValueForProperty("UsbAddress",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbAddress, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbPort = (int?) content.GetValueForProperty("UsbPort",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Vendor = (string) content.GetValueForProperty("Vendor",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Vendor, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).VendorId = (string) content.GetValueForProperty("VendorId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).VendorId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsbDevices"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsUsbDevices(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Class = (string) content.GetValueForProperty("Class",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Class, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Model = (string) content.GetValueForProperty("Model",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Model, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).ModelId = (string) content.GetValueForProperty("ModelId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).ModelId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Protocol = (string) content.GetValueForProperty("Protocol",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Protocol, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Removable = (int?) content.GetValueForProperty("Removable",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Removable, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Serial = (string) content.GetValueForProperty("Serial",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Serial, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Subclass = (string) content.GetValueForProperty("Subclass",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Subclass, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbAddress = (int?) content.GetValueForProperty("UsbAddress",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbAddress, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbPort = (int?) content.GetValueForProperty("UsbPort",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).UsbPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Vendor = (string) content.GetValueForProperty("Vendor",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Vendor, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).VendorId = (string) content.GetValueForProperty("VendorId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).VendorId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights USB Devices
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsUsbDevicesTypeConverter))]
    public partial interface ISystemInsightsUsbDevices

    {

    }
}