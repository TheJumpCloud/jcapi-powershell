// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>UserPut</summary>
    [System.ComponentModel.TypeConverter(typeof(UserputTypeConverter))]
    public partial class Userput
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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

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
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Userput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IUserput" />.</returns>
        public static JumpCloud.SDK.V1.Models.IUserput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Userput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Userput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IUserput" />.</returns>
        public static JumpCloud.SDK.V1.Models.IUserput DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Userput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Userput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IUserput FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Userput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Userput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.IUserputInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableMultiFactor = (bool?) content.GetValueForProperty("EnableMultiFactor",((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableMultiFactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableWhatsNew = (bool?) content.GetValueForProperty("EnableWhatsNew",((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableWhatsNew, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).LastWhatsNewChecked = (global::System.DateTime?) content.GetValueForProperty("LastWhatsNewChecked",((JumpCloud.SDK.V1.Models.IUserputInternal)this).LastWhatsNewChecked, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).RoleName = (string) content.GetValueForProperty("RoleName",((JumpCloud.SDK.V1.Models.IUserputInternal)this).RoleName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Userput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Userput(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.IUserputInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableMultiFactor = (bool?) content.GetValueForProperty("EnableMultiFactor",((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableMultiFactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableWhatsNew = (bool?) content.GetValueForProperty("EnableWhatsNew",((JumpCloud.SDK.V1.Models.IUserputInternal)this).EnableWhatsNew, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).LastWhatsNewChecked = (global::System.DateTime?) content.GetValueForProperty("LastWhatsNewChecked",((JumpCloud.SDK.V1.Models.IUserputInternal)this).LastWhatsNewChecked, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V1.Models.IUserputInternal)this).RoleName = (string) content.GetValueForProperty("RoleName",((JumpCloud.SDK.V1.Models.IUserputInternal)this).RoleName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// UserPut
    [System.ComponentModel.TypeConverter(typeof(UserputTypeConverter))]
    public partial interface IUserput

    {

    }
}