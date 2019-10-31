namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>SystemPut</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemputTypeConverter))]
    public partial class Systemput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Systemput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemput" />.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Systemput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Systemput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemput" />.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemput DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Systemput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Systemput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemput FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Systemput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Systemput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AgentBoundMessages = (JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem[]) content.GetValueForProperty("AgentBoundMessages",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AgentBoundMessages, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem>(__y, JumpCloudApiSdkV1.Models.SystemputAgentBoundMessagesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowMultiFactorAuthentication = (bool?) content.GetValueForProperty("AllowMultiFactorAuthentication",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowMultiFactorAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowPublicKeyAuthentication = (bool?) content.GetValueForProperty("AllowPublicKeyAuthentication",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowPublicKeyAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshPasswordAuthentication = (bool?) content.GetValueForProperty("AllowSshPasswordAuthentication",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshPasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshRootLogin = (bool?) content.GetValueForProperty("AllowSshRootLogin",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshRootLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Systemput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Systemput(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AgentBoundMessages = (JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem[]) content.GetValueForProperty("AgentBoundMessages",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AgentBoundMessages, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.ISystemputAgentBoundMessagesItem>(__y, JumpCloudApiSdkV1.Models.SystemputAgentBoundMessagesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowMultiFactorAuthentication = (bool?) content.GetValueForProperty("AllowMultiFactorAuthentication",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowMultiFactorAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowPublicKeyAuthentication = (bool?) content.GetValueForProperty("AllowPublicKeyAuthentication",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowPublicKeyAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshPasswordAuthentication = (bool?) content.GetValueForProperty("AllowSshPasswordAuthentication",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshPasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshRootLogin = (bool?) content.GetValueForProperty("AllowSshRootLogin",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).AllowSshRootLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemputInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.ISystemputInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemPut
    [System.ComponentModel.TypeConverter(typeof(SystemputTypeConverter))]
    public partial interface ISystemput

    {

    }
}