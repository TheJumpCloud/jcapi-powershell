// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsBattery"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsBattery" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsBattery DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsBattery(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsBattery"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsBattery" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsBattery DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemInsightsBattery(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsBattery" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsBattery FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsBattery"
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
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Amperage = (int?) content.GetValueForProperty("Amperage",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Amperage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charged = (int?) content.GetValueForProperty("Charged",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charged, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charging = (int?) content.GetValueForProperty("Charging",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charging, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Condition = (string) content.GetValueForProperty("Condition",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Condition, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity = (int?) content.GetValueForProperty("CurrentCapacity",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CycleCount = (int?) content.GetValueForProperty("CycleCount",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CycleCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity = (int?) content.GetValueForProperty("DesignedCapacity",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Health = (string) content.GetValueForProperty("Health",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Health, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate = (int?) content.GetValueForProperty("ManufactureDate",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Manufacturer, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity = (int?) content.GetValueForProperty("MaxCapacity",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge = (int?) content.GetValueForProperty("MinutesToFullCharge",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty = (int?) content.GetValueForProperty("MinutesUntilEmpty",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Model = (string) content.GetValueForProperty("Model",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Model, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining = (int?) content.GetValueForProperty("PercentRemaining",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SerialNumber, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).State, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Voltage = (int?) content.GetValueForProperty("Voltage",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Voltage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsBattery"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsBattery(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Amperage = (int?) content.GetValueForProperty("Amperage",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Amperage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charged = (int?) content.GetValueForProperty("Charged",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charged, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charging = (int?) content.GetValueForProperty("Charging",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Charging, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Condition = (string) content.GetValueForProperty("Condition",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Condition, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity = (int?) content.GetValueForProperty("CurrentCapacity",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CurrentCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CycleCount = (int?) content.GetValueForProperty("CycleCount",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).CycleCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity = (int?) content.GetValueForProperty("DesignedCapacity",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).DesignedCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Health = (string) content.GetValueForProperty("Health",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Health, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate = (int?) content.GetValueForProperty("ManufactureDate",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).ManufactureDate, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Manufacturer = (string) content.GetValueForProperty("Manufacturer",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Manufacturer, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity = (int?) content.GetValueForProperty("MaxCapacity",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MaxCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge = (int?) content.GetValueForProperty("MinutesToFullCharge",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesToFullCharge, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty = (int?) content.GetValueForProperty("MinutesUntilEmpty",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).MinutesUntilEmpty, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Model = (string) content.GetValueForProperty("Model",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Model, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining = (int?) content.GetValueForProperty("PercentRemaining",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).PercentRemaining, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SerialNumber = (string) content.GetValueForProperty("SerialNumber",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SerialNumber, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).State, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Voltage = (int?) content.GetValueForProperty("Voltage",((JumpCloud.SDK.V2.Models.ISystemInsightsBatteryInternal)this).Voltage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Battery
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsBatteryTypeConverter))]
    public partial interface ISystemInsightsBattery

    {

    }
}