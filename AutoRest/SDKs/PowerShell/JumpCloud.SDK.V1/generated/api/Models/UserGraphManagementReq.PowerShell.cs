namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IUserGraphManagementReq" />.</returns>
        public static JumpCloud.SDK.V1.Models.IUserGraphManagementReq DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserGraphManagementReq(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IUserGraphManagementReq" />.</returns>
        public static JumpCloud.SDK.V1.Models.IUserGraphManagementReq DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new UserGraphManagementReq(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserGraphManagementReq" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IUserGraphManagementReq FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReq"
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
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Attributes = (JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Attributes, JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Op, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).AttributeSudo = (JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo) content.GetValueForProperty("AttributeSudo",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).AttributeSudo, JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReq"
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
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Attributes = (JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Attributes, JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).Op, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).AttributeSudo = (JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo) content.GetValueForProperty("AttributeSudo",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).AttributeSudo, JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesSudoTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoEnabled = (bool?) content.GetValueForProperty("SudoEnabled",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword = (bool?) content.GetValueForProperty("SudoWithoutPassword",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqInternal)this).SudoWithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// UserGraphManagementReq
    [System.ComponentModel.TypeConverter(typeof(UserGraphManagementReqTypeConverter))]
    public partial interface IUserGraphManagementReq

    {

    }
}