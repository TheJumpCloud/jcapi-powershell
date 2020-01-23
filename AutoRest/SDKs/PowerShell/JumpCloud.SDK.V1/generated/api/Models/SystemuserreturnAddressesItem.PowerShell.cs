namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>FIXME: Class SystemuserreturnAddressesItem is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(SystemuserreturnAddressesItemTypeConverter))]
    public partial class SystemuserreturnAddressesItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SystemuserreturnAddressesItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem" />.
        /// </returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new SystemuserreturnAddressesItem(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SystemuserreturnAddressesItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItem FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SystemuserreturnAddressesItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Country = (string) content.GetValueForProperty("Country",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Country, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).ExtendedAddress = (string) content.GetValueForProperty("ExtendedAddress",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).ExtendedAddress, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Locality = (string) content.GetValueForProperty("Locality",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Locality, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PoBox = (string) content.GetValueForProperty("PoBox",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PoBox, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PostalCode, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Region = (string) content.GetValueForProperty("Region",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Region, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).StreetAddress, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.SystemuserreturnAddressesItem"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal SystemuserreturnAddressesItem(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Type = (string) content.GetValueForProperty("Type",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Type, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Country = (string) content.GetValueForProperty("Country",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Country, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).ExtendedAddress = (string) content.GetValueForProperty("ExtendedAddress",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).ExtendedAddress, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Locality = (string) content.GetValueForProperty("Locality",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Locality, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PoBox = (string) content.GetValueForProperty("PoBox",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PoBox, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).PostalCode, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Region = (string) content.GetValueForProperty("Region",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).Region, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).StreetAddress = (string) content.GetValueForProperty("StreetAddress",((JumpCloud.SDK.V1.Models.ISystemuserreturnAddressesItemInternal)this).StreetAddress, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface ISystemuserreturnAddressesItem is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(SystemuserreturnAddressesItemTypeConverter))]
    public partial interface ISystemuserreturnAddressesItem

    {

    }
}