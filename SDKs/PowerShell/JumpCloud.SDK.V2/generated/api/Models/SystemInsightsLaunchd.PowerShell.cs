// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights LaunchD</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsLaunchdTypeConverter))]
    public partial class SystemInsightsLaunchd
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsLaunchd"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsLaunchd" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsLaunchd DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsLaunchd(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsLaunchd"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsLaunchd" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsLaunchd DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SystemInsightsLaunchd(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsLaunchd" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsLaunchd FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsLaunchd"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsLaunchd(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Disabled = (string) content.GetValueForProperty("Disabled",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Disabled, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Groupname = (string) content.GetValueForProperty("Groupname",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Groupname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).InetdCompatibility = (string) content.GetValueForProperty("InetdCompatibility",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).InetdCompatibility, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).KeepAlive = (string) content.GetValueForProperty("KeepAlive",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).KeepAlive, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).OnDemand = (string) content.GetValueForProperty("OnDemand",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).OnDemand, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProcessType = (string) content.GetValueForProperty("ProcessType",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProcessType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Program = (string) content.GetValueForProperty("Program",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Program, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProgramArguments = (string) content.GetValueForProperty("ProgramArguments",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProgramArguments, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).QueueDirectories = (string) content.GetValueForProperty("QueueDirectories",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).QueueDirectories, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RootDirectory = (string) content.GetValueForProperty("RootDirectory",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RootDirectory, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RunAtLoad = (string) content.GetValueForProperty("RunAtLoad",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RunAtLoad, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartInterval = (string) content.GetValueForProperty("StartInterval",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartInterval, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartOnMount = (string) content.GetValueForProperty("StartOnMount",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartOnMount, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StderrPath = (string) content.GetValueForProperty("StderrPath",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StderrPath, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StdoutPath = (string) content.GetValueForProperty("StdoutPath",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StdoutPath, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WatchPaths = (string) content.GetValueForProperty("WatchPaths",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WatchPaths, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WorkingDirectory = (string) content.GetValueForProperty("WorkingDirectory",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WorkingDirectory, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsLaunchd"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsLaunchd(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Disabled = (string) content.GetValueForProperty("Disabled",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Disabled, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Groupname = (string) content.GetValueForProperty("Groupname",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Groupname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).InetdCompatibility = (string) content.GetValueForProperty("InetdCompatibility",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).InetdCompatibility, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).KeepAlive = (string) content.GetValueForProperty("KeepAlive",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).KeepAlive, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Label = (string) content.GetValueForProperty("Label",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Label, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).OnDemand = (string) content.GetValueForProperty("OnDemand",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).OnDemand, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProcessType = (string) content.GetValueForProperty("ProcessType",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProcessType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Program = (string) content.GetValueForProperty("Program",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Program, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProgramArguments = (string) content.GetValueForProperty("ProgramArguments",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).ProgramArguments, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).QueueDirectories = (string) content.GetValueForProperty("QueueDirectories",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).QueueDirectories, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RootDirectory = (string) content.GetValueForProperty("RootDirectory",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RootDirectory, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RunAtLoad = (string) content.GetValueForProperty("RunAtLoad",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).RunAtLoad, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartInterval = (string) content.GetValueForProperty("StartInterval",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartInterval, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartOnMount = (string) content.GetValueForProperty("StartOnMount",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StartOnMount, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StderrPath = (string) content.GetValueForProperty("StderrPath",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StderrPath, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StdoutPath = (string) content.GetValueForProperty("StdoutPath",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).StdoutPath, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WatchPaths = (string) content.GetValueForProperty("WatchPaths",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WatchPaths, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WorkingDirectory = (string) content.GetValueForProperty("WorkingDirectory",((JumpCloud.SDK.V2.Models.ISystemInsightsLaunchdInternal)this).WorkingDirectory, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights LaunchD
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsLaunchdTypeConverter))]
    public partial interface ISystemInsightsLaunchd

    {

    }
}