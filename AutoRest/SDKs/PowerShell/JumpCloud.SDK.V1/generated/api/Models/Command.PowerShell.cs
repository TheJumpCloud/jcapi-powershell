namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>Command</summary>
    [System.ComponentModel.TypeConverter(typeof(CommandTypeConverter))]
    public partial class Command
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Command"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Command(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Command1 = (string) content.GetValueForProperty("Command1",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Command1, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandRunners = (string[]) content.GetValueForProperty("CommandRunners",((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandRunners, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandType = (string) content.GetValueForProperty("CommandType",((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Files = (string[]) content.GetValueForProperty("Files",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Files, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).LaunchType = (string) content.GetValueForProperty("LaunchType",((JumpCloud.SDK.V1.Models.ICommandInternal)this).LaunchType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).ListensTo = (string) content.GetValueForProperty("ListensTo",((JumpCloud.SDK.V1.Models.ICommandInternal)this).ListensTo, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Schedule = (string) content.GetValueForProperty("Schedule",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Schedule, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).ScheduleRepeatType = (string) content.GetValueForProperty("ScheduleRepeatType",((JumpCloud.SDK.V1.Models.ICommandInternal)this).ScheduleRepeatType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Systems = (string[]) content.GetValueForProperty("Systems",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Systems, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Timeout = (string) content.GetValueForProperty("Timeout",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Timeout, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Trigger = (string) content.GetValueForProperty("Trigger",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Trigger, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).User = (string) content.GetValueForProperty("User",((JumpCloud.SDK.V1.Models.ICommandInternal)this).User, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Command"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Command(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Command1 = (string) content.GetValueForProperty("Command1",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Command1, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandRunners = (string[]) content.GetValueForProperty("CommandRunners",((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandRunners, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandType = (string) content.GetValueForProperty("CommandType",((JumpCloud.SDK.V1.Models.ICommandInternal)this).CommandType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Files = (string[]) content.GetValueForProperty("Files",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Files, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).LaunchType = (string) content.GetValueForProperty("LaunchType",((JumpCloud.SDK.V1.Models.ICommandInternal)this).LaunchType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).ListensTo = (string) content.GetValueForProperty("ListensTo",((JumpCloud.SDK.V1.Models.ICommandInternal)this).ListensTo, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Schedule = (string) content.GetValueForProperty("Schedule",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Schedule, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).ScheduleRepeatType = (string) content.GetValueForProperty("ScheduleRepeatType",((JumpCloud.SDK.V1.Models.ICommandInternal)this).ScheduleRepeatType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Systems = (string[]) content.GetValueForProperty("Systems",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Systems, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Timeout = (string) content.GetValueForProperty("Timeout",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Timeout, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).Trigger = (string) content.GetValueForProperty("Trigger",((JumpCloud.SDK.V1.Models.ICommandInternal)this).Trigger, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandInternal)this).User = (string) content.GetValueForProperty("User",((JumpCloud.SDK.V1.Models.ICommandInternal)this).User, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Command"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ICommand" />.</returns>
        public static JumpCloud.SDK.V1.Models.ICommand DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Command(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Command"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ICommand" />.</returns>
        public static JumpCloud.SDK.V1.Models.ICommand DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Command(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Command" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ICommand FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Command
    [System.ComponentModel.TypeConverter(typeof(CommandTypeConverter))]
    public partial interface ICommand

    {

    }
}