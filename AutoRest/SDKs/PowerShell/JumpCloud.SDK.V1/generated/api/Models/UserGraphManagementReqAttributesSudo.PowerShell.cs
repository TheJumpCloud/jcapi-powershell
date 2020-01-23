namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>FIXME: Class UserGraphManagementReqAttributesSudo is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(UserGraphManagementReqAttributesSudoTypeConverter))]
    public partial class UserGraphManagementReqAttributesSudo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesSudo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UserGraphManagementReqAttributesSudo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesSudo"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new UserGraphManagementReqAttributesSudo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UserGraphManagementReqAttributesSudo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudo FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesSudo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UserGraphManagementReqAttributesSudo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).WithoutPassword = (bool?) content.GetValueForProperty("WithoutPassword",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).WithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.UserGraphManagementReqAttributesSudo"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal UserGraphManagementReqAttributesSudo(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).WithoutPassword = (bool?) content.GetValueForProperty("WithoutPassword",((JumpCloud.SDK.V1.Models.IUserGraphManagementReqAttributesSudoInternal)this).WithoutPassword, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }
    }
    /// FIXME: Interface IUserGraphManagementReqAttributesSudo is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(UserGraphManagementReqAttributesSudoTypeConverter))]
    public partial interface IUserGraphManagementReqAttributesSudo

    {

    }
}