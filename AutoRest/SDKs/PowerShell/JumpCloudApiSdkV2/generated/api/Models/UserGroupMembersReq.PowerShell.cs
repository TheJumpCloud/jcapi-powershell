namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>UserGroupMembersReq</summary>
    [System.ComponentModel.TypeConverter(typeof(UserGroupMembersReqTypeConverter))]
    public partial class UserGroupMembersReq
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.UserGroupMembersReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IUserGroupMembersReq" />.</returns>
        public static JumpCloudApiSdkV2.Models.IUserGroupMembersReq DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserGroupMembersReq(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.UserGroupMembersReq"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IUserGroupMembersReq" />.</returns>
        public static JumpCloudApiSdkV2.Models.IUserGroupMembersReq DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new UserGroupMembersReq(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserGroupMembersReq" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IUserGroupMembersReq FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.UserGroupMembersReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserGroupMembersReq(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Op, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.UserGroupMembersReq"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal UserGroupMembersReq(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloudApiSdkV2.Models.IUserGroupMembersReqInternal)this).Op, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// UserGroupMembersReq
    [System.ComponentModel.TypeConverter(typeof(UserGroupMembersReqTypeConverter))]
    public partial interface IUserGroupMembersReq

    {

    }
}