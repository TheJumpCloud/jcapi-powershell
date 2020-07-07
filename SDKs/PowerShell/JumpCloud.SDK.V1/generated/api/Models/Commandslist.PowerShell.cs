// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>CommandsList</summary>
    [System.ComponentModel.TypeConverter(typeof(CommandslistTypeConverter))]
    public partial class Commandslist
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Commandslist"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Commandslist(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).Results = (JumpCloud.SDK.V1.Models.ICommandslistResultsItem[]) content.GetValueForProperty("Results",((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).Results, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ICommandslistResultsItem>(__y, JumpCloud.SDK.V1.Models.CommandslistResultsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).TotalCount = (int?) content.GetValueForProperty("TotalCount",((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).TotalCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Commandslist"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Commandslist(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).Results = (JumpCloud.SDK.V1.Models.ICommandslistResultsItem[]) content.GetValueForProperty("Results",((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).Results, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.ICommandslistResultsItem>(__y, JumpCloud.SDK.V1.Models.CommandslistResultsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).TotalCount = (int?) content.GetValueForProperty("TotalCount",((JumpCloud.SDK.V1.Models.ICommandslistInternal)this).TotalCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Commandslist"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ICommandslist" />.</returns>
        public static JumpCloud.SDK.V1.Models.ICommandslist DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Commandslist(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Commandslist"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.ICommandslist" />.</returns>
        public static JumpCloud.SDK.V1.Models.ICommandslist DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Commandslist(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Commandslist" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ICommandslist FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// CommandsList
    [System.ComponentModel.TypeConverter(typeof(CommandslistTypeConverter))]
    public partial interface ICommandslist

    {

    }
}