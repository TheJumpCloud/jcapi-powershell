namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>System Insights Users</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsUsersTypeConverter))]
    public partial class SystemInsightsUsers
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsers"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsUsers" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsUsers DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemInsightsUsers(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsers"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.ISystemInsightsUsers" />.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsUsers DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemInsightsUsers(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemInsightsUsers" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsUsers FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsers"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemInsightsUsers(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Directory = (string) content.GetValueForProperty("Directory",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Directory, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Gid = (string) content.GetValueForProperty("Gid",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Gid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).GidSigned = (string) content.GetValueForProperty("GidSigned",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).GidSigned, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Shell = (string) content.GetValueForProperty("Shell",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Shell, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).UidSigned = (string) content.GetValueForProperty("UidSigned",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).UidSigned, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uuid, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.SystemInsightsUsers"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemInsightsUsers(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Description = (string) content.GetValueForProperty("Description",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Description, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).CollectionTime = (string) content.GetValueForProperty("CollectionTime",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).CollectionTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Directory = (string) content.GetValueForProperty("Directory",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Directory, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Gid = (string) content.GetValueForProperty("Gid",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Gid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).GidSigned = (string) content.GetValueForProperty("GidSigned",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).GidSigned, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Shell = (string) content.GetValueForProperty("Shell",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Shell, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uid = (string) content.GetValueForProperty("Uid",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uid, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).UidSigned = (string) content.GetValueForProperty("UidSigned",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).UidSigned, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Username = (string) content.GetValueForProperty("Username",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Username, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((JumpCloudApiSdkV2.Models.ISystemInsightsUsersInternal)this).Uuid, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// System Insights Users
    [System.ComponentModel.TypeConverter(typeof(SystemInsightsUsersTypeConverter))]
    public partial interface ISystemInsightsUsers

    {

    }
}