namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>System Insights Groups</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsGroupsTypeConverter))]
    public partial class SystemInsightsGroups
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsGroups"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsGroups" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsGroups DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsGroups(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsGroups"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.ISystemInsightsGroups" />.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsGroups DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsGroups(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsGroups" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsGroups FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsGroups"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsGroups(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Comment = (string) content.GetValueForProperty("Comment",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Comment, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Gid = (string) content.GetValueForProperty("Gid",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Gid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GidSigned = (string) content.GetValueForProperty("GidSigned",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GidSigned, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GroupSid = (string) content.GetValueForProperty("GroupSid",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GroupSid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Groupname = (string) content.GetValueForProperty("Groupname",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Groupname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.SystemInsightsGroups"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsGroups(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Comment = (string) content.GetValueForProperty("Comment",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Comment, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Gid = (string) content.GetValueForProperty("Gid",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Gid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GidSigned = (string) content.GetValueForProperty("GidSigned",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GidSigned, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GroupSid = (string) content.GetValueForProperty("GroupSid",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).GroupSid, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Groupname = (string) content.GetValueForProperty("Groupname",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).Groupname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.ISystemInsightsGroupsInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Groups
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsGroupsTypeConverter))]
    public partial interface ISystemInsightsGroups

    {

    }
}