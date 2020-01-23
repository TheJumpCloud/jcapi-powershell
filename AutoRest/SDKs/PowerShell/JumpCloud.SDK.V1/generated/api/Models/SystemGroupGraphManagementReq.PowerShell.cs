namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>SystemGroupGraphManagementReq</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemGroupGraphManagementReqTypeConverter))]
    public partial class SystemGroupGraphManagementReq
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.SystemGroupGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReq" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReq DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemGroupGraphManagementReq(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.SystemGroupGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReq" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReq DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemGroupGraphManagementReq(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemGroupGraphManagementReq" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReq FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.SystemGroupGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemGroupGraphManagementReq(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Attributes = (JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Attributes, JumpCloud.SDK.V1.Models.SystemGroupGraphManagementReqAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Op, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.SystemGroupGraphManagementReq"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemGroupGraphManagementReq(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Attributes = (JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Attributes, JumpCloud.SDK.V1.Models.SystemGroupGraphManagementReqAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Op = (string) content.GetValueForProperty("Op",((JumpCloud.SDK.V1.Models.ISystemGroupGraphManagementReqInternal)this).Op, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SystemGroupGraphManagementReq
    [System.ComponentModel.TypeConverter(typeof(SystemGroupGraphManagementReqTypeConverter))]
    public partial interface ISystemGroupGraphManagementReq

    {

    }
}