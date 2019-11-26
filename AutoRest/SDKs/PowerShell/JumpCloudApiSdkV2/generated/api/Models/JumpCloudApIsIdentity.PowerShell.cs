namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>FIXME: Class JumpCloudApIsIdentity is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(JumpCloudApIsIdentityTypeConverter))]
    public partial class JumpCloudApIsIdentity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.JumpCloudApIsIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity" />.</returns>
        public static JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JumpCloudApIsIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.JumpCloudApIsIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity" />.</returns>
        public static JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new JumpCloudApIsIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JumpCloudApIsIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.JumpCloudApIsIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JumpCloudApIsIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).AccountId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ActivedirectoryId = (string) content.GetValueForProperty("ActivedirectoryId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ActivedirectoryId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ApplicationId = (string) content.GetValueForProperty("ApplicationId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ApplicationId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).CommandId = (string) content.GetValueForProperty("CommandId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).CommandId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GroupId = (string) content.GetValueForProperty("GroupId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GroupId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GsuiteId = (string) content.GetValueForProperty("GsuiteId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GsuiteId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).JobId = (string) content.GetValueForProperty("JobId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).JobId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).LdapserverId = (string) content.GetValueForProperty("LdapserverId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).LdapserverId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Office365Id = (string) content.GetValueForProperty("Office365Id",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Office365Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).PolicyId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ProviderId = (string) content.GetValueForProperty("ProviderId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ProviderId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).RadiusserverId = (string) content.GetValueForProperty("RadiusserverId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).RadiusserverId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).UserId = (string) content.GetValueForProperty("UserId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).UserId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).WorkdayId = (string) content.GetValueForProperty("WorkdayId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).WorkdayId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.JumpCloudApIsIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal JumpCloudApIsIdentity(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).AccountId = (string) content.GetValueForProperty("AccountId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).AccountId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ActivedirectoryId = (string) content.GetValueForProperty("ActivedirectoryId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ActivedirectoryId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ApplicationId = (string) content.GetValueForProperty("ApplicationId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ApplicationId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).CommandId = (string) content.GetValueForProperty("CommandId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).CommandId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GroupId = (string) content.GetValueForProperty("GroupId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GroupId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GsuiteId = (string) content.GetValueForProperty("GsuiteId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).GsuiteId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).JobId = (string) content.GetValueForProperty("JobId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).JobId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).LdapserverId = (string) content.GetValueForProperty("LdapserverId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).LdapserverId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Office365Id = (string) content.GetValueForProperty("Office365Id",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).Office365Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).PolicyId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ProviderId = (string) content.GetValueForProperty("ProviderId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).ProviderId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).RadiusserverId = (string) content.GetValueForProperty("RadiusserverId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).RadiusserverId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).UserId = (string) content.GetValueForProperty("UserId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).UserId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).WorkdayId = (string) content.GetValueForProperty("WorkdayId",((JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal)this).WorkdayId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IJumpCloudApIsIdentity is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(JumpCloudApIsIdentityTypeConverter))]
    public partial interface IJumpCloudApIsIdentity

    {

    }
}