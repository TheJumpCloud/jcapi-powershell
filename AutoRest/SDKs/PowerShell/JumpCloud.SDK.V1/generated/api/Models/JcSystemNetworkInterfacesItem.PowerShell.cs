namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>FIXME: Class JcSystemNetworkInterfacesItem is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(JcSystemNetworkInterfacesItemTypeConverter))]
    public partial class JcSystemNetworkInterfacesItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JcSystemNetworkInterfacesItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new JcSystemNetworkInterfacesItem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JcSystemNetworkInterfacesItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItem FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JcSystemNetworkInterfacesItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Address = (string) content.GetValueForProperty("Address",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Address, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Family = (string) content.GetValueForProperty("Family",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Family, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Internal = (bool?) content.GetValueForProperty("Internal",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Internal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.JcSystemNetworkInterfacesItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal JcSystemNetworkInterfacesItem(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Address = (string) content.GetValueForProperty("Address",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Address, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Family = (string) content.GetValueForProperty("Family",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Family, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Internal = (bool?) content.GetValueForProperty("Internal",((JumpCloud.SDK.V1.Models.IJcSystemNetworkInterfacesItemInternal)this).Internal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IJcSystemNetworkInterfacesItem is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(JcSystemNetworkInterfacesItemTypeConverter))]
    public partial interface IJcSystemNetworkInterfacesItem

    {

    }
}