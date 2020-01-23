namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.JcSystem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IJcSystem" />.</returns>
        public static JumpCloud.SDK.V1.Models.IJcSystem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JcSystem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.JcSystem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IJcSystem" />.</returns>
        public static JumpCloud.SDK.V1.Models.IJcSystem DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new JcSystem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JcSystem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IJcSystem FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.JcSystem"
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
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Fde = (JumpCloud.SDK.V1.Models.IFde) content.GetValueForProperty("Fde",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Fde, JumpCloud.SDK.V1.Models.FdeTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsights = (JumpCloud.SDK.V1.Models.IJcSystemInsights) content.GetValueForProperty("SystemInsights",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsights, JumpCloud.SDK.V1.Models.JcSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Active = (bool?) content.GetValueForProperty("Active",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AgentVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication = (bool?) content.GetValueForProperty("AllowMultiFactorAuthentication",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication = (bool?) content.GetValueForProperty("AllowPublicKeyAuthentication",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication = (bool?) content.GetValueForProperty("AllowSshPasswordAuthentication",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshRootLogin = (bool?) content.GetValueForProperty("AllowSshRootLogin",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshRootLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AmazonInstanceId = (string) content.GetValueForProperty("AmazonInstanceId",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AmazonInstanceId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Arch = (string) content.GetValueForProperty("Arch",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Arch, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ConnectionHistory = (JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem[]) content.GetValueForProperty("ConnectionHistory",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ConnectionHistory, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem>(__y, JumpCloud.SDK.V1.Models.JcSystemConnectionHistoryItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FileSystem = (string) content.GetValueForProperty("FileSystem",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FileSystem, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).HasServiceAccount = (bool?) content.GetValueForProperty("HasServiceAccount",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).HasServiceAccount, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).LastContact = (string) content.GetValueForProperty("LastContact",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).LastContact, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ModifySshdConfig = (bool?) content.GetValueForProperty("ModifySshdConfig",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ModifySshdConfig, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).NetworkInterfaces = (JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem[]) content.GetValueForProperty("NetworkInterfaces",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).NetworkInterfaces, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem>(__y, JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).OS = (string) content.GetValueForProperty("OS",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).OS, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).RemoteIP = (string) content.GetValueForProperty("RemoteIP",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).RemoteIP, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshRootEnabled = (bool?) content.GetValueForProperty("SshRootEnabled",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshRootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshdParams = (JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem[]) content.GetValueForProperty("SshdParams",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshdParams, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem>(__y, JumpCloud.SDK.V1.Models.JcSystemSshdParamsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemTimezone = (int?) content.GetValueForProperty("SystemTimezone",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemTimezone, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).TemplateName = (string) content.GetValueForProperty("TemplateName",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).TemplateName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Version, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeActive = (bool?) content.GetValueForProperty("FdeActive",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeKeyPresent = (bool?) content.GetValueForProperty("FdeKeyPresent",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeKeyPresent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsightState = (string) content.GetValueForProperty("SystemInsightState",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsightState, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.JcSystem"
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
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Fde = (JumpCloud.SDK.V1.Models.IFde) content.GetValueForProperty("Fde",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Fde, JumpCloud.SDK.V1.Models.FdeTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsights = (JumpCloud.SDK.V1.Models.IJcSystemInsights) content.GetValueForProperty("SystemInsights",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsights, JumpCloud.SDK.V1.Models.JcSystemInsightsTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Active = (bool?) content.GetValueForProperty("Active",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Active, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AgentVersion, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication = (bool?) content.GetValueForProperty("AllowMultiFactorAuthentication",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowMultiFactorAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication = (bool?) content.GetValueForProperty("AllowPublicKeyAuthentication",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowPublicKeyAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication = (bool?) content.GetValueForProperty("AllowSshPasswordAuthentication",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshPasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshRootLogin = (bool?) content.GetValueForProperty("AllowSshRootLogin",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AllowSshRootLogin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AmazonInstanceId = (string) content.GetValueForProperty("AmazonInstanceId",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).AmazonInstanceId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Arch = (string) content.GetValueForProperty("Arch",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Arch, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ConnectionHistory = (JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem[]) content.GetValueForProperty("ConnectionHistory",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ConnectionHistory, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IJcSystemConnectionHistoryItem>(__y, JumpCloud.SDK.V1.Models.JcSystemConnectionHistoryItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).DisplayName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FileSystem = (string) content.GetValueForProperty("FileSystem",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FileSystem, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).HasServiceAccount = (bool?) content.GetValueForProperty("HasServiceAccount",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).HasServiceAccount, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Hostname = (string) content.GetValueForProperty("Hostname",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Hostname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).LastContact = (string) content.GetValueForProperty("LastContact",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).LastContact, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ModifySshdConfig = (bool?) content.GetValueForProperty("ModifySshdConfig",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).ModifySshdConfig, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).NetworkInterfaces = (JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem[]) content.GetValueForProperty("NetworkInterfaces",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).NetworkInterfaces, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem>(__y, JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).OS = (string) content.GetValueForProperty("OS",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).OS, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).RemoteIP = (string) content.GetValueForProperty("RemoteIP",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).RemoteIP, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshRootEnabled = (bool?) content.GetValueForProperty("SshRootEnabled",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshRootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshdParams = (JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem[]) content.GetValueForProperty("SshdParams",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SshdParams, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V1.Models.IJcSystemSshdParamsItem>(__y, JumpCloud.SDK.V1.Models.JcSystemSshdParamsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemTimezone = (int?) content.GetValueForProperty("SystemTimezone",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemTimezone, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Tags = (string[]) content.GetValueForProperty("Tags",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).TemplateName = (string) content.GetValueForProperty("TemplateName",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).TemplateName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Version = (string) content.GetValueForProperty("Version",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).Version, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeActive = (bool?) content.GetValueForProperty("FdeActive",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeKeyPresent = (bool?) content.GetValueForProperty("FdeKeyPresent",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).FdeKeyPresent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsightState = (string) content.GetValueForProperty("SystemInsightState",((JumpCloud.SDK.V1.Models.IJcSystemInternal)this).SystemInsightState, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System
    [System.ComponentModel.TypeConverter(typeof(JcSystemTypeConverter))]
    public partial interface IJcSystem

    {

    }
}