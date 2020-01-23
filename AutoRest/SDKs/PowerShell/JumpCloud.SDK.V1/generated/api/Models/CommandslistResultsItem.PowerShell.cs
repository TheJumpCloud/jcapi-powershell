namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>FIXME: Class CommandslistResultsItem is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(CommandslistResultsItemTypeConverter))]
    public partial class CommandslistResultsItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.CommandslistResultsItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CommandslistResultsItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Command = (string) content.GetValueForProperty("Command",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Command, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).CommandType = (string) content.GetValueForProperty("CommandType",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).CommandType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).LaunchType = (string) content.GetValueForProperty("LaunchType",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).LaunchType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ListensTo = (string) content.GetValueForProperty("ListensTo",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ListensTo, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Schedule = (string) content.GetValueForProperty("Schedule",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Schedule, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ScheduleRepeatType = (string) content.GetValueForProperty("ScheduleRepeatType",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ScheduleRepeatType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Trigger = (string) content.GetValueForProperty("Trigger",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Trigger, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.CommandslistResultsItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal CommandslistResultsItem(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Command = (string) content.GetValueForProperty("Command",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Command, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).CommandType = (string) content.GetValueForProperty("CommandType",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).CommandType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).LaunchType = (string) content.GetValueForProperty("LaunchType",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).LaunchType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ListensTo = (string) content.GetValueForProperty("ListensTo",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ListensTo, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Schedule = (string) content.GetValueForProperty("Schedule",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Schedule, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ScheduleRepeatType = (string) content.GetValueForProperty("ScheduleRepeatType",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).ScheduleRepeatType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Trigger = (string) content.GetValueForProperty("Trigger",((JumpCloud.SDK.V1.Models.ICommandslistResultsItemInternal)this).Trigger, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.CommandslistResultsItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ICommandslistResultsItem" />.</returns>
        public static JumpCloud.SDK.V1.Models.ICommandslistResultsItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CommandslistResultsItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.CommandslistResultsItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ICommandslistResultsItem" />.</returns>
        public static JumpCloud.SDK.V1.Models.ICommandslistResultsItem DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new CommandslistResultsItem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CommandslistResultsItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ICommandslistResultsItem FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface ICommandslistResultsItem is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(CommandslistResultsItemTypeConverter))]
    public partial interface ICommandslistResultsItem

    {

    }
}