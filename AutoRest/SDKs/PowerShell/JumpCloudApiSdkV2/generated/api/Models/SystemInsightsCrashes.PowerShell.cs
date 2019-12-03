namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Crashes</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsCrashesTypeConverter))]
    public partial class SystemInsightsCrashes
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsCrashes" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsCrashes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsCrashes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsCrashes" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsCrashes DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsCrashes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsCrashes" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsCrashes FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsCrashes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashPath = (string) content.GetValueForProperty("CrashPath",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashPath, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashedThread = (string) content.GetValueForProperty("CrashedThread",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashedThread, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Datetime = (string) content.GetValueForProperty("Datetime",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Datetime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionCodes = (string) content.GetValueForProperty("ExceptionCodes",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionCodes, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionNotes = (string) content.GetValueForProperty("ExceptionNotes",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionNotes, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionType = (string) content.GetValueForProperty("ExceptionType",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Parent = (string) content.GetValueForProperty("Parent",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Parent, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Pid = (string) content.GetValueForProperty("Pid",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Pid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Registers = (string) content.GetValueForProperty("Registers",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Registers, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Responsible = (string) content.GetValueForProperty("Responsible",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Responsible, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).StackTrace = (string) content.GetValueForProperty("StackTrace",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).StackTrace, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Uid = (int?) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Uid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsCrashes"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsCrashes(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Path = (string) content.GetValueForProperty("Path",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Path, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashPath = (string) content.GetValueForProperty("CrashPath",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashPath, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashedThread = (string) content.GetValueForProperty("CrashedThread",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).CrashedThread, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Datetime = (string) content.GetValueForProperty("Datetime",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Datetime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionCodes = (string) content.GetValueForProperty("ExceptionCodes",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionCodes, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionNotes = (string) content.GetValueForProperty("ExceptionNotes",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionNotes, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionType = (string) content.GetValueForProperty("ExceptionType",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).ExceptionType, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Identifier = (string) content.GetValueForProperty("Identifier",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Identifier, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Parent = (string) content.GetValueForProperty("Parent",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Parent, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Pid = (string) content.GetValueForProperty("Pid",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Pid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Registers = (string) content.GetValueForProperty("Registers",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Registers, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Responsible = (string) content.GetValueForProperty("Responsible",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Responsible, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).StackTrace = (string) content.GetValueForProperty("StackTrace",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).StackTrace, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Uid = (int?) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Uid, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.ISystemInsightsCrashesInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Crashes
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsCrashesTypeConverter))]
    public partial interface ISystemInsightsCrashes

    {

    }
}