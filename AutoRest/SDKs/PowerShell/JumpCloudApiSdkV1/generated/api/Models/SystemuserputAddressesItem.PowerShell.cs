namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>FIXME: Class SystemuserputAddressesItem is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemuserputAddressesItemTypeConverter))]
    public partial class SystemuserputAddressesItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.SystemuserputAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemuserputAddressesItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.SystemuserputAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem" />.
        /// </returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemuserputAddressesItem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemuserputAddressesItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.ISystemuserputAddressesItem FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.SystemuserputAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemuserputAddressesItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Country = (string) content.GetValueForProperty("Country",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Country, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).ExtendedAddress = (string) content.GetValueForProperty("ExtendedAddress",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).ExtendedAddress, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Locality = (string) content.GetValueForProperty("Locality",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Locality, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PoBox = (string) content.GetValueForProperty("PoBox",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PoBox, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PostalCode, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Region = (string) content.GetValueForProperty("Region",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Region, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).StreetAddress, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.SystemuserputAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemuserputAddressesItem(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Country = (string) content.GetValueForProperty("Country",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Country, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).ExtendedAddress = (string) content.GetValueForProperty("ExtendedAddress",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).ExtendedAddress, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Locality = (string) content.GetValueForProperty("Locality",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Locality, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PoBox = (string) content.GetValueForProperty("PoBox",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PoBox, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).PostalCode, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Region = (string) content.GetValueForProperty("Region",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).Region, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((JumpCloudApiSdkV1.Models.ISystemuserputAddressesItemInternal)this).StreetAddress, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface ISystemuserputAddressesItem is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(SystemuserputAddressesItemTypeConverter))]
    public partial interface ISystemuserputAddressesItem

    {

    }
}