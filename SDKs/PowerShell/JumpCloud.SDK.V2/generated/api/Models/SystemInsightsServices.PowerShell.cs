// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Services</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsServicesTypeConverter))]
    public partial class SystemInsightsServices
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsServices" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsServices DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsServices(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsServices" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsServices DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemInsightsServices(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsServices" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsServices FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsServices(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ModulePath = (string) content.GetValueForProperty("ModulePath",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ModulePath, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Pid = (int?) content.GetValueForProperty("Pid",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Pid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceExitCode = (int?) content.GetValueForProperty("ServiceExitCode",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceType = (string) content.GetValueForProperty("ServiceType",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).StartType = (string) content.GetValueForProperty("StartType",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).StartType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Status = (string) content.GetValueForProperty("Status",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Status, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).UserAccount = (string) content.GetValueForProperty("UserAccount",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).UserAccount, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Win32ExitCode = (int?) content.GetValueForProperty("Win32ExitCode",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Win32ExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsServices"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsServices(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ModulePath = (string) content.GetValueForProperty("ModulePath",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ModulePath, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Pid = (int?) content.GetValueForProperty("Pid",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Pid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceExitCode = (int?) content.GetValueForProperty("ServiceExitCode",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceType = (string) content.GetValueForProperty("ServiceType",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).ServiceType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).StartType = (string) content.GetValueForProperty("StartType",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).StartType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Status = (string) content.GetValueForProperty("Status",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Status, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).UserAccount = (string) content.GetValueForProperty("UserAccount",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).UserAccount, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Win32ExitCode = (int?) content.GetValueForProperty("Win32ExitCode",((JumpCloud.SDK.V2.Models.ISystemInsightsServicesInternal)this).Win32ExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Services
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsServicesTypeConverter))]
    public partial interface ISystemInsightsServices

    {

    }
}