namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>FIXME: Class WorkdayOutputAuth is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkdayOutputAuthTypeConverter))]
    public partial class WorkdayOutputAuth
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayOutputAuth"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IWorkdayOutputAuth" />.</returns>
        public static JumpCloudApiSdkV2.Models.IWorkdayOutputAuth DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkdayOutputAuth(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayOutputAuth"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IWorkdayOutputAuth" />.</returns>
        public static JumpCloudApiSdkV2.Models.IWorkdayOutputAuth DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new WorkdayOutputAuth(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkdayOutputAuth" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IWorkdayOutputAuth FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayOutputAuth"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkdayOutputAuth(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Basic = (JumpCloudApiSdkV2.Models.IAuthInfo) content.GetValueForProperty("Basic",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Basic, JumpCloudApiSdkV2.Models.AuthInfoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Oauth = (JumpCloudApiSdkV2.Models.IAuthInfo) content.GetValueForProperty("Oauth",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Oauth, JumpCloudApiSdkV2.Models.AuthInfoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicExpiry = (string) content.GetValueForProperty("BasicExpiry",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicExpiry, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicIsValid = (bool?) content.GetValueForProperty("BasicIsValid",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicIsValid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicMessage = (string) content.GetValueForProperty("BasicMessage",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicMessage, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthExpiry = (string) content.GetValueForProperty("OauthExpiry",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthExpiry, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthIsValid = (bool?) content.GetValueForProperty("OauthIsValid",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthIsValid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthMessage = (string) content.GetValueForProperty("OauthMessage",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayOutputAuth"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal WorkdayOutputAuth(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Basic = (JumpCloudApiSdkV2.Models.IAuthInfo) content.GetValueForProperty("Basic",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Basic, JumpCloudApiSdkV2.Models.AuthInfoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Oauth = (JumpCloudApiSdkV2.Models.IAuthInfo) content.GetValueForProperty("Oauth",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).Oauth, JumpCloudApiSdkV2.Models.AuthInfoTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicExpiry = (string) content.GetValueForProperty("BasicExpiry",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicExpiry, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicIsValid = (bool?) content.GetValueForProperty("BasicIsValid",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicIsValid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicMessage = (string) content.GetValueForProperty("BasicMessage",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).BasicMessage, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthExpiry = (string) content.GetValueForProperty("OauthExpiry",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthExpiry, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthIsValid = (bool?) content.GetValueForProperty("OauthIsValid",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthIsValid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthMessage = (string) content.GetValueForProperty("OauthMessage",((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)this).OauthMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// FIXME: Interface IWorkdayOutputAuth is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(WorkdayOutputAuthTypeConverter))]
    public partial interface IWorkdayOutputAuth

    {

    }
}