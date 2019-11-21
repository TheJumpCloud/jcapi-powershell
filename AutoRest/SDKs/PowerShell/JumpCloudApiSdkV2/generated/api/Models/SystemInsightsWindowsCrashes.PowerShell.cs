namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Windows Crashes</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsWindowsCrashesTypeConverter))]
    public partial class SystemInsightsWindowsCrashes
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsWindowsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashes" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsWindowsCrashes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsWindowsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashes" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashes DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsWindowsCrashes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsWindowsCrashes" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashes FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsWindowsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsWindowsCrashes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).BuildNumber = (int?) content.GetValueForProperty("BuildNumber",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).BuildNumber, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CommandLine = (string) content.GetValueForProperty("CommandLine",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CommandLine, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CrashPath = (string) content.GetValueForProperty("CrashPath",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CrashPath, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CurrentDirectory = (string) content.GetValueForProperty("CurrentDirectory",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CurrentDirectory, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Datetime = (string) content.GetValueForProperty("Datetime",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Datetime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionAddress = (string) content.GetValueForProperty("ExceptionAddress",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionAddress, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionCode = (string) content.GetValueForProperty("ExceptionCode",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionCode, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionMessage = (string) content.GetValueForProperty("ExceptionMessage",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionMessage, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MachineName = (string) content.GetValueForProperty("MachineName",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MachineName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MajorVersion = (int?) content.GetValueForProperty("MajorVersion",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MajorVersion, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MinorVersion = (int?) content.GetValueForProperty("MinorVersion",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MinorVersion, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Module = (string) content.GetValueForProperty("Module",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Module, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Pid = (string) content.GetValueForProperty("Pid",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Pid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ProcessUptime = (string) content.GetValueForProperty("ProcessUptime",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ProcessUptime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Registers = (string) content.GetValueForProperty("Registers",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Registers, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).StackTrace = (string) content.GetValueForProperty("StackTrace",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).StackTrace, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Tid = (string) content.GetValueForProperty("Tid",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Tid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsWindowsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsWindowsCrashes(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).BuildNumber = (int?) content.GetValueForProperty("BuildNumber",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).BuildNumber, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CommandLine = (string) content.GetValueForProperty("CommandLine",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CommandLine, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CrashPath = (string) content.GetValueForProperty("CrashPath",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CrashPath, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CurrentDirectory = (string) content.GetValueForProperty("CurrentDirectory",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).CurrentDirectory, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Datetime = (string) content.GetValueForProperty("Datetime",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Datetime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionAddress = (string) content.GetValueForProperty("ExceptionAddress",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionAddress, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionCode = (string) content.GetValueForProperty("ExceptionCode",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionCode, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionMessage = (string) content.GetValueForProperty("ExceptionMessage",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ExceptionMessage, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MachineName = (string) content.GetValueForProperty("MachineName",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MachineName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MajorVersion = (int?) content.GetValueForProperty("MajorVersion",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MajorVersion, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MinorVersion = (int?) content.GetValueForProperty("MinorVersion",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).MinorVersion, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Module = (string) content.GetValueForProperty("Module",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Module, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Pid = (string) content.GetValueForProperty("Pid",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Pid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ProcessUptime = (string) content.GetValueForProperty("ProcessUptime",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).ProcessUptime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Registers = (string) content.GetValueForProperty("Registers",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Registers, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).StackTrace = (string) content.GetValueForProperty("StackTrace",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).StackTrace, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Tid = (string) content.GetValueForProperty("Tid",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Tid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsWindowsCrashesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Windows Crashes
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsWindowsCrashesTypeConverter))]
    public partial interface ISystemInsightsWindowsCrashes

    {

    }
}