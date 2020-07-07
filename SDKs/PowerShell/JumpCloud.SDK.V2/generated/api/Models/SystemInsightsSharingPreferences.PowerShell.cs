// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Sharing Preferences</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSharingPreferencesTypeConverter))]
    public partial class SystemInsightsSharingPreferences
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSharingPreferences"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferences" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferences DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsSharingPreferences(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSharingPreferences"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferences" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferences DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemInsightsSharingPreferences(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsSharingPreferences" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferences FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSharingPreferences"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsSharingPreferences(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).BluetoothSharing = (int?) content.GetValueForProperty("BluetoothSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).BluetoothSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ContentCaching = (int?) content.GetValueForProperty("ContentCaching",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ContentCaching, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).DiscSharing = (int?) content.GetValueForProperty("DiscSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).DiscSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).FileSharing = (int?) content.GetValueForProperty("FileSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).FileSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).InternetSharing = (int?) content.GetValueForProperty("InternetSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).InternetSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).PrinterSharing = (int?) content.GetValueForProperty("PrinterSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).PrinterSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteAppleEvents = (int?) content.GetValueForProperty("RemoteAppleEvents",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteAppleEvents, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteLogin = (int?) content.GetValueForProperty("RemoteLogin",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteLogin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteManagement = (int?) content.GetValueForProperty("RemoteManagement",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteManagement, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ScreenSharing = (int?) content.GetValueForProperty("ScreenSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ScreenSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsSharingPreferences"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsSharingPreferences(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).BluetoothSharing = (int?) content.GetValueForProperty("BluetoothSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).BluetoothSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ContentCaching = (int?) content.GetValueForProperty("ContentCaching",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ContentCaching, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).DiscSharing = (int?) content.GetValueForProperty("DiscSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).DiscSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).FileSharing = (int?) content.GetValueForProperty("FileSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).FileSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).InternetSharing = (int?) content.GetValueForProperty("InternetSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).InternetSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).PrinterSharing = (int?) content.GetValueForProperty("PrinterSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).PrinterSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteAppleEvents = (int?) content.GetValueForProperty("RemoteAppleEvents",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteAppleEvents, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteLogin = (int?) content.GetValueForProperty("RemoteLogin",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteLogin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteManagement = (int?) content.GetValueForProperty("RemoteManagement",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).RemoteManagement, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ScreenSharing = (int?) content.GetValueForProperty("ScreenSharing",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).ScreenSharing, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsSharingPreferencesInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Sharing Preferences
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsSharingPreferencesTypeConverter))]
    public partial interface ISystemInsightsSharingPreferences

    {

    }
}