// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>UserReturn</summary>
    [System.ComponentModel.TypeConverter(typeof(UserreturnTypeConverter))]
    public partial class Userreturn
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Userreturn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IUserreturn" />.</returns>
        public static JumpCloud.SDK.V1.Models.IUserreturn DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Userreturn(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Userreturn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IUserreturn" />.</returns>
        public static JumpCloud.SDK.V1.Models.IUserreturn DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Userreturn(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Userreturn" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IUserreturn FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Userreturn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Userreturn(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).DisableIntroduction = (bool?) content.GetValueForProperty("DisableIntroduction",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).DisableIntroduction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableMultiFactor = (bool?) content.GetValueForProperty("EnableMultiFactor",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableMultiFactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableWhatsNew = (bool?) content.GetValueForProperty("EnableWhatsNew",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableWhatsNew, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).LastWhatsNewChecked = (string) content.GetValueForProperty("LastWhatsNewChecked",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).LastWhatsNewChecked, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Provider = (string) content.GetValueForProperty("Provider",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Provider, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Role = (string) content.GetValueForProperty("Role",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Role, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).RoleName = (string) content.GetValueForProperty("RoleName",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).RoleName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).UsersTimeZone = (string) content.GetValueForProperty("UsersTimeZone",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).UsersTimeZone, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Userreturn"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Userreturn(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Created = (string) content.GetValueForProperty("Created",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Created, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).DisableIntroduction = (bool?) content.GetValueForProperty("DisableIntroduction",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).DisableIntroduction, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Email = (string) content.GetValueForProperty("Email",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Email, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableMultiFactor = (bool?) content.GetValueForProperty("EnableMultiFactor",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableMultiFactor, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableWhatsNew = (bool?) content.GetValueForProperty("EnableWhatsNew",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).EnableWhatsNew, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Firstname = (string) content.GetValueForProperty("Firstname",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Firstname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).LastWhatsNewChecked = (string) content.GetValueForProperty("LastWhatsNewChecked",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).LastWhatsNewChecked, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Lastname = (string) content.GetValueForProperty("Lastname",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Lastname, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Provider = (string) content.GetValueForProperty("Provider",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Provider, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Role = (string) content.GetValueForProperty("Role",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).Role, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).RoleName = (string) content.GetValueForProperty("RoleName",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).RoleName, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).UsersTimeZone = (string) content.GetValueForProperty("UsersTimeZone",((JumpCloud.SDK.V1.Models.IUserreturnInternal)this).UsersTimeZone, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// UserReturn
    [System.ComponentModel.TypeConverter(typeof(UserreturnTypeConverter))]
    public partial interface IUserreturn

    {

    }
}