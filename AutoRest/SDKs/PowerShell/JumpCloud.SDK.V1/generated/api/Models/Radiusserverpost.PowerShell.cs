// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6231, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V1.Models
{
    using JumpCloud.SDK.V1.Runtime.PowerShell;

    /// <summary>RadiusServerPost</summary>
    [System.ComponentModel.TypeConverter(typeof(RadiusserverpostTypeConverter))]
    public partial class Radiusserverpost
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Radiusserverpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IRadiusserverpost" />.</returns>
        public static JumpCloud.SDK.V1.Models.IRadiusserverpost DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Radiusserverpost(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V1.Models.Radiusserverpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V1.Models.IRadiusserverpost" />.</returns>
        public static JumpCloud.SDK.V1.Models.IRadiusserverpost DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Radiusserverpost(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Radiusserverpost" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V1.Models.IRadiusserverpost FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Radiusserverpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Radiusserverpost(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Mfa = (string) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Mfa, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).NetworkSourceIP = (string) content.GetValueForProperty("NetworkSourceIP",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).NetworkSourceIP, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).SharedSecret = (string) content.GetValueForProperty("SharedSecret",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).SharedSecret, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).TagNames = (string[]) content.GetValueForProperty("TagNames",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).TagNames, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserLockoutAction = (string) content.GetValueForProperty("UserLockoutAction",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserLockoutAction, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserPasswordExpirationAction = (string) content.GetValueForProperty("UserPasswordExpirationAction",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserPasswordExpirationAction, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V1.Models.Radiusserverpost"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Radiusserverpost(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Mfa = (string) content.GetValueForProperty("Mfa",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).Mfa, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).NetworkSourceIP = (string) content.GetValueForProperty("NetworkSourceIP",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).NetworkSourceIP, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).SharedSecret = (string) content.GetValueForProperty("SharedSecret",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).SharedSecret, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).TagNames = (string[]) content.GetValueForProperty("TagNames",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).TagNames, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserLockoutAction = (string) content.GetValueForProperty("UserLockoutAction",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserLockoutAction, global::System.Convert.ToString);
            ((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserPasswordExpirationAction = (string) content.GetValueForProperty("UserPasswordExpirationAction",((JumpCloud.SDK.V1.Models.IRadiusserverpostInternal)this).UserPasswordExpirationAction, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// RadiusServerPost
    [System.ComponentModel.TypeConverter(typeof(RadiusserverpostTypeConverter))]
    public partial interface IRadiusserverpost

    {

    }
}