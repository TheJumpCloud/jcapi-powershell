// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>Active Directory Agent Get Output</summary>
    [System.ComponentModel.TypeConverter(typeof(ActiveDirectoryAgentGetOutputTypeConverter))]
    public partial class ActiveDirectoryAgentGetOutput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.ActiveDirectoryAgentGetOutput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ActiveDirectoryAgentGetOutput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ConnectKey = (string) content.GetValueForProperty("ConnectKey",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ConnectKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ContactAt = (string) content.GetValueForProperty("ContactAt",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ContactAt, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).SourceIP, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).State, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.ActiveDirectoryAgentGetOutput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ActiveDirectoryAgentGetOutput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ConnectKey = (string) content.GetValueForProperty("ConnectKey",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ConnectKey, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ContactAt = (string) content.GetValueForProperty("ContactAt",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).ContactAt, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).SourceIP, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).State, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutputInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.ActiveDirectoryAgentGetOutput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutput" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ActiveDirectoryAgentGetOutput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.ActiveDirectoryAgentGetOutput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutput" />.
        /// </returns>
        public static JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ActiveDirectoryAgentGetOutput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ActiveDirectoryAgentGetOutput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IActiveDirectoryAgentGetOutput FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Active Directory Agent Get Output
    [System.ComponentModel.TypeConverter(typeof(ActiveDirectoryAgentGetOutputTypeConverter))]
    public partial interface IActiveDirectoryAgentGetOutput

    {

    }
}