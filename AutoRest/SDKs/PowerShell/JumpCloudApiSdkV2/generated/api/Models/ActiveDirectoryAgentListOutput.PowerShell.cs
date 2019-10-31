namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>Active Directory Agent List Output</summary>
    [System.ComponentModel.TypeConverter(typeof(ActiveDirectoryAgentListOutputTypeConverter))]
    public partial class ActiveDirectoryAgentListOutput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.ActiveDirectoryAgentListOutput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ActiveDirectoryAgentListOutput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).ContactAt = (string) content.GetValueForProperty("ContactAt",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).ContactAt, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).SourceIP, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).State, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.ActiveDirectoryAgentListOutput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal ActiveDirectoryAgentListOutput(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).ContactAt = (string) content.GetValueForProperty("ContactAt",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).ContactAt, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).SourceIP, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).State, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutputInternal)this).Version, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.ActiveDirectoryAgentListOutput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutput" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ActiveDirectoryAgentListOutput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.ActiveDirectoryAgentListOutput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutput" />.
        /// </returns>
        public static JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutput DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new ActiveDirectoryAgentListOutput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ActiveDirectoryAgentListOutput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IActiveDirectoryAgentListOutput FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Active Directory Agent List Output
    [System.ComponentModel.TypeConverter(typeof(ActiveDirectoryAgentListOutputTypeConverter))]
    public partial interface IActiveDirectoryAgentListOutput

    {

    }
}