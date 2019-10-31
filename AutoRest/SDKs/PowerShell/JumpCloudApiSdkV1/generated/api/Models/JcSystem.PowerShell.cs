namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>System</summary>
    [System.ComponentModel.TypeConverter(typeof(JcSystemTypeConverter))]
    public partial class JcSystem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.JcSystem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IJcSystem" />.</returns>
        public static JumpCloudApiSdkV1.Models.IJcSystem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JcSystem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.JcSystem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IJcSystem" />.</returns>
        public static JumpCloudApiSdkV1.Models.IJcSystem DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new JcSystem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JcSystem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IJcSystem FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.JcSystem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JcSystem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Fde = (JumpCloudApiSdkV1.Models.IFde) content.GetValueForProperty("Fde",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Fde, JumpCloudApiSdkV1.Models.FdeTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsights = (JumpCloudApiSdkV1.Models.IJcSystemInsights) content.GetValueForProperty("SystemInsights",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsights, JumpCloudApiSdkV1.Models.JcSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Active = (bool?) content.GetValueForProperty("Active",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AgentVersion, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication = (bool?) content.GetValueForProperty("AllowMultiFactorAuthentication",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication = (bool?) content.GetValueForProperty("AllowPublicKeyAuthentication",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication = (bool?) content.GetValueForProperty("AllowSshPasswordAuthentication",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshRootLogin = (bool?) content.GetValueForProperty("AllowSshRootLogin",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshRootLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AmazonInstanceId = (string) content.GetValueForProperty("AmazonInstanceId",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AmazonInstanceId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Arch = (string) content.GetValueForProperty("Arch",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Arch, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ConnectionHistory = (JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem[]) content.GetValueForProperty("ConnectionHistory",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ConnectionHistory, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem>(__y, JumpCloudApiSdkV1.Models.JcSystemConnectionHistoryItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).LastContact = (string) content.GetValueForProperty("LastContact",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).LastContact, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ModifySshdConfig = (bool?) content.GetValueForProperty("ModifySshdConfig",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ModifySshdConfig, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).NetworkInterfaces = (JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem[]) content.GetValueForProperty("NetworkInterfaces",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).NetworkInterfaces, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem>(__y, JumpCloudApiSdkV1.Models.JcSystemNetworkInterfacesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).OS = (string) content.GetValueForProperty("OS",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).OS, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).RemoteIP = (string) content.GetValueForProperty("RemoteIP",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).RemoteIP, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshRootEnabled = (bool?) content.GetValueForProperty("SshRootEnabled",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshRootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshdParams = (JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem[]) content.GetValueForProperty("SshdParams",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshdParams, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem>(__y, JumpCloudApiSdkV1.Models.JcSystemSshdParamsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemTimezone = (int?) content.GetValueForProperty("SystemTimezone",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemTimezone, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).TemplateName = (string) content.GetValueForProperty("TemplateName",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).TemplateName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Version, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeActive = (bool?) content.GetValueForProperty("FdeActive",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeKeyPresent = (bool?) content.GetValueForProperty("FdeKeyPresent",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeKeyPresent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsightState = (string) content.GetValueForProperty("SystemInsightState",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsightState, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.JcSystem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal JcSystem(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Fde = (JumpCloudApiSdkV1.Models.IFde) content.GetValueForProperty("Fde",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Fde, JumpCloudApiSdkV1.Models.FdeTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsights = (JumpCloudApiSdkV1.Models.IJcSystemInsights) content.GetValueForProperty("SystemInsights",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsights, JumpCloudApiSdkV1.Models.JcSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Active = (bool?) content.GetValueForProperty("Active",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AgentVersion, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication = (bool?) content.GetValueForProperty("AllowMultiFactorAuthentication",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication = (bool?) content.GetValueForProperty("AllowPublicKeyAuthentication",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication = (bool?) content.GetValueForProperty("AllowSshPasswordAuthentication",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshRootLogin = (bool?) content.GetValueForProperty("AllowSshRootLogin",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AllowSshRootLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AmazonInstanceId = (string) content.GetValueForProperty("AmazonInstanceId",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).AmazonInstanceId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Arch = (string) content.GetValueForProperty("Arch",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Arch, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ConnectionHistory = (JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem[]) content.GetValueForProperty("ConnectionHistory",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ConnectionHistory, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.IJcSystemConnectionHistoryItem>(__y, JumpCloudApiSdkV1.Models.JcSystemConnectionHistoryItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).LastContact = (string) content.GetValueForProperty("LastContact",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).LastContact, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ModifySshdConfig = (bool?) content.GetValueForProperty("ModifySshdConfig",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).ModifySshdConfig, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).NetworkInterfaces = (JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem[]) content.GetValueForProperty("NetworkInterfaces",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).NetworkInterfaces, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.IJcSystemNetworkInterfacesItem>(__y, JumpCloudApiSdkV1.Models.JcSystemNetworkInterfacesItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).OS = (string) content.GetValueForProperty("OS",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).OS, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).RemoteIP = (string) content.GetValueForProperty("RemoteIP",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).RemoteIP, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshRootEnabled = (bool?) content.GetValueForProperty("SshRootEnabled",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshRootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshdParams = (JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem[]) content.GetValueForProperty("SshdParams",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SshdParams, __y => TypeConverterExtensions.SelectToArray<JumpCloudApiSdkV1.Models.IJcSystemSshdParamsItem>(__y, JumpCloudApiSdkV1.Models.JcSystemSshdParamsItemTypeConverter.ConvertFrom));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemTimezone = (int?) content.GetValueForProperty("SystemTimezone",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemTimezone, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).TemplateName = (string) content.GetValueForProperty("TemplateName",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).TemplateName, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).Version, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeActive = (bool?) content.GetValueForProperty("FdeActive",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeKeyPresent = (bool?) content.GetValueForProperty("FdeKeyPresent",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).FdeKeyPresent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsightState = (string) content.GetValueForProperty("SystemInsightState",((JumpCloudApiSdkV1.Models.IJcSystemInternal)this).SystemInsightState, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System
    [System.ComponentModel.TypeConverter(typeof(JcSystemTypeConverter))]
    public partial interface IJcSystem

    {

    }
}