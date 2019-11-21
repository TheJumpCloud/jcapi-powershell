namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Battery</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsBatteryTypeConverter))]
    public partial class SystemInsightsBattery
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsBattery"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsBattery" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsBattery DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsBattery(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsBattery"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsBattery" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsBattery DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsBattery(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsBattery" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsBattery FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsBattery"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsBattery(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Amgerage = (int?) content.GetValueForProperty("Amgerage",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Amgerage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charged = (int?) content.GetValueForProperty("Charged",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charged, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charging = (int?) content.GetValueForProperty("Charging",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charging, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Condition = (string) content.GetValueForProperty("Condition",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Condition, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity = (int?) content.GetValueForProperty("CurrentCapacity",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CycleCount = (int?) content.GetValueForProperty("CycleCount",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CycleCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity = (int?) content.GetValueForProperty("DesignedCapacity",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Health = (string) content.GetValueForProperty("Health",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Health, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate = (int?) content.GetValueForProperty("ManufactureDate",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Manufacturer, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity = (int?) content.GetValueForProperty("MaxCapacity",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge = (int?) content.GetValueForProperty("MinutesToFullCharge",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty = (int?) content.GetValueForProperty("MinutesUntilEmpty",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Model = (string) content.GetValueForProperty("Model",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Model, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining = (int?) content.GetValueForProperty("PercentRemaining",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SerialNumber, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).State, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Voltage = (int?) content.GetValueForProperty("Voltage",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Voltage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsBattery"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsBattery(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Amgerage = (int?) content.GetValueForProperty("Amgerage",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Amgerage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charged = (int?) content.GetValueForProperty("Charged",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charged, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charging = (int?) content.GetValueForProperty("Charging",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Charging, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Condition = (string) content.GetValueForProperty("Condition",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Condition, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity = (int?) content.GetValueForProperty("CurrentCapacity",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CycleCount = (int?) content.GetValueForProperty("CycleCount",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).CycleCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity = (int?) content.GetValueForProperty("DesignedCapacity",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Health = (string) content.GetValueForProperty("Health",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Health, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate = (int?) content.GetValueForProperty("ManufactureDate",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Manufacturer, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity = (int?) content.GetValueForProperty("MaxCapacity",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge = (int?) content.GetValueForProperty("MinutesToFullCharge",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty = (int?) content.GetValueForProperty("MinutesUntilEmpty",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Model = (string) content.GetValueForProperty("Model",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Model, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining = (int?) content.GetValueForProperty("PercentRemaining",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SerialNumber, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).State, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Voltage = (int?) content.GetValueForProperty("Voltage",((JumpCloudApiSdkV2.Models.ISystemInsightsBatteryInternal)this).Voltage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Battery
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsBatteryTypeConverter))]
    public partial interface ISystemInsightsBattery

    {

    }
}