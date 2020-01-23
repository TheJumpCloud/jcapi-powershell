namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>UserGroup</summary>
    [System.ComponentModel.TypeConverter(typeof(UserGroupTypeConverter))]
    public partial class UserGroup
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.UserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IUserGroup" />.</returns>
        public static JumpCloud.SDK.V2.Models.IUserGroup DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserGroup(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.UserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IUserGroup" />.</returns>
        public static JumpCloud.SDK.V2.Models.IUserGroup DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new UserGroup(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserGroup" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IUserGroup FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.UserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserGroup(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Attributes = (JumpCloud.SDK.V2.Models.IUserGroupAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Attributes, JumpCloud.SDK.V2.Models.UserGroupAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributePosixGroups = (JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[]) content.GetValueForProperty("AttributePosixGroups",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributePosixGroups, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem>(__y, JumpCloud.SDK.V2.Models.UserGroupAttributesPosixGroupsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributeSambaEnabled = (bool?) content.GetValueForProperty("AttributeSambaEnabled",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributeSambaEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.UserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal UserGroup(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Attributes = (JumpCloud.SDK.V2.Models.IUserGroupAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Attributes, JumpCloud.SDK.V2.Models.UserGroupAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributePosixGroups = (JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem[]) content.GetValueForProperty("AttributePosixGroups",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributePosixGroups, __y => TypeConverterExtensions.SelectToArray<JumpCloud.SDK.V2.Models.IUserGroupAttributesPosixGroupsItem>(__y, JumpCloud.SDK.V2.Models.UserGroupAttributesPosixGroupsItemTypeConverter.ConvertFrom));
            ((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributeSambaEnabled = (bool?) content.GetValueForProperty("AttributeSambaEnabled",((JumpCloud.SDK.V2.Models.IUserGroupInternal)this).AttributeSambaEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// UserGroup
    [System.ComponentModel.TypeConverter(typeof(UserGroupTypeConverter))]
    public partial interface IUserGroup

    {

    }
}