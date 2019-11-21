namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>UserGraphManagementReq</summary>
    [System.ComponentModel.TypeConverter(typeof(UserGraphManagementReqTypeConverter))]
    public partial class UserGraphManagementReq
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IUserGraphManagementReq" />.</returns>
        public static JumpCloudApiSdkV1.Models.IUserGraphManagementReq DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserGraphManagementReq(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.IUserGraphManagementReq" />.</returns>
        public static JumpCloudApiSdkV1.Models.IUserGraphManagementReq DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new UserGraphManagementReq(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserGraphManagementReq" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.IUserGraphManagementReq FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserGraphManagementReq(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Attributes = (JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Attributes, JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Op, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).AttributeSudo = (JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo) content.GetValueForProperty("AttributeSudo",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).AttributeSudo, JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.UserGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal UserGraphManagementReq(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Attributes = (JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributes) content.GetValueForProperty("Attributes",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Attributes, JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).Op, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).AttributeSudo = (JumpCloudApiSdkV1.Models.IUserGraphManagementReqAttributesSudo) content.GetValueForProperty("AttributeSudo",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).AttributeSudo, JumpCloudApiSdkV1.Models.UserGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloudApiSdkV1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// UserGraphManagementReq
    [System.ComponentModel.TypeConverter(typeof(UserGraphManagementReqTypeConverter))]
    public partial interface IUserGraphManagementReq

    {

    }
}