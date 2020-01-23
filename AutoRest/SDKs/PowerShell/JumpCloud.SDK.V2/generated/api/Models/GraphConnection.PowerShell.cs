namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>
    /// Represents an edge between two graph objects. From can be omitted if it is clear from context.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(GraphConnectionTypeConverter))]
    public partial class GraphConnection
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.GraphConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IGraphConnection" />.</returns>
        public static JumpCloud.SDK.V2.Models.IGraphConnection DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GraphConnection(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.GraphConnection"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IGraphConnection" />.</returns>
        public static JumpCloud.SDK.V2.Models.IGraphConnection DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new GraphConnection(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GraphConnection" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IGraphConnection FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.GraphConnection"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GraphConnection(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).From = (JumpCloud.SDK.V2.Models.IGraphObject) content.GetValueForProperty("From",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).From, JumpCloud.SDK.V2.Models.GraphObjectTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).To = (JumpCloud.SDK.V2.Models.IGraphObject) content.GetValueForProperty("To",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).To, JumpCloud.SDK.V2.Models.GraphObjectTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).Attributes = (JumpCloud.SDK.V2.Models.IGraphConnectionAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).Attributes, JumpCloud.SDK.V2.Models.GraphConnectionAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromType = (string) content.GetValueForProperty("FromType",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromAttributes = (JumpCloud.SDK.V2.Models.IGraphObjectAttributes) content.GetValueForProperty("FromAttributes",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromAttributes, JumpCloud.SDK.V2.Models.GraphObjectAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromId = (string) content.GetValueForProperty("FromId",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToType = (string) content.GetValueForProperty("ToType",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToAttributes = (JumpCloud.SDK.V2.Models.IGraphObjectAttributes) content.GetValueForProperty("ToAttributes",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToAttributes, JumpCloud.SDK.V2.Models.GraphObjectAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToId = (string) content.GetValueForProperty("ToId",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.GraphConnection"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal GraphConnection(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).From = (JumpCloud.SDK.V2.Models.IGraphObject) content.GetValueForProperty("From",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).From, JumpCloud.SDK.V2.Models.GraphObjectTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).To = (JumpCloud.SDK.V2.Models.IGraphObject) content.GetValueForProperty("To",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).To, JumpCloud.SDK.V2.Models.GraphObjectTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).Attributes = (JumpCloud.SDK.V2.Models.IGraphConnectionAttributes) content.GetValueForProperty("Attributes",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).Attributes, JumpCloud.SDK.V2.Models.GraphConnectionAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromType = (string) content.GetValueForProperty("FromType",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromAttributes = (JumpCloud.SDK.V2.Models.IGraphObjectAttributes) content.GetValueForProperty("FromAttributes",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromAttributes, JumpCloud.SDK.V2.Models.GraphObjectAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromId = (string) content.GetValueForProperty("FromId",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).FromId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToType = (string) content.GetValueForProperty("ToType",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToType, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToAttributes = (JumpCloud.SDK.V2.Models.IGraphObjectAttributes) content.GetValueForProperty("ToAttributes",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToAttributes, JumpCloud.SDK.V2.Models.GraphObjectAttributesTypeConverter.ConvertFrom);
            ((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToId = (string) content.GetValueForProperty("ToId",((JumpCloud.SDK.V2.Models.IGraphConnectionInternal)this).ToId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents an edge between two graph objects. From can be omitted if it is clear from context.
    [System.ComponentModel.TypeConverter(typeof(GraphConnectionTypeConverter))]
    public partial interface IGraphConnection

    {

    }
}