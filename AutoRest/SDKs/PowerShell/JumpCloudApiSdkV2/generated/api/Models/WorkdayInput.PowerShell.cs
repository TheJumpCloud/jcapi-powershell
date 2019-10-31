namespace JumpCloudApiSdkV2.Models
{
    using JumpCloudApiSdkV2.Runtime.PowerShell;

    /// <summary>Workday Input</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkdayInputTypeConverter))]
    public partial class WorkdayInput
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IWorkdayInput" />.</returns>
        public static JumpCloudApiSdkV2.Models.IWorkdayInput DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkdayInput(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayInput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV2.Models.IWorkdayInput" />.</returns>
        public static JumpCloudApiSdkV2.Models.IWorkdayInput DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new WorkdayInput(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkdayInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV2.Models.IWorkdayInput FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV2.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayInput"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkdayInput(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Auth = (JumpCloudApiSdkV2.Models.IAuthInput) content.GetValueForProperty("Auth",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Auth, JumpCloudApiSdkV2.Models.AuthInputTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).ReportUrl = (string) content.GetValueForProperty("ReportUrl",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).ReportUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthBasic = (JumpCloudApiSdkV2.Models.IAuthInputBasic) content.GetValueForProperty("AuthBasic",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthBasic, JumpCloudApiSdkV2.Models.AuthInputBasicTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthOauth = (JumpCloudApiSdkV2.Models.IAuthInputOauth) content.GetValueForProperty("AuthOauth",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthOauth, JumpCloudApiSdkV2.Models.AuthInputOauthTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicPassword = (string) content.GetValueForProperty("BasicPassword",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicPassword, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicUsername = (string) content.GetValueForProperty("BasicUsername",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicUsername, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).OauthCode = (string) content.GetValueForProperty("OauthCode",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).OauthCode, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV2.Models.WorkdayInput"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal WorkdayInput(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Auth = (JumpCloudApiSdkV2.Models.IAuthInput) content.GetValueForProperty("Auth",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Auth, JumpCloudApiSdkV2.Models.AuthInputTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).ReportUrl = (string) content.GetValueForProperty("ReportUrl",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).ReportUrl, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthBasic = (JumpCloudApiSdkV2.Models.IAuthInputBasic) content.GetValueForProperty("AuthBasic",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthBasic, JumpCloudApiSdkV2.Models.AuthInputBasicTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthOauth = (JumpCloudApiSdkV2.Models.IAuthInputOauth) content.GetValueForProperty("AuthOauth",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).AuthOauth, JumpCloudApiSdkV2.Models.AuthInputOauthTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicPassword = (string) content.GetValueForProperty("BasicPassword",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicPassword, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicUsername = (string) content.GetValueForProperty("BasicUsername",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).BasicUsername, global::System.Convert.ToString);
            ((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).OauthCode = (string) content.GetValueForProperty("OauthCode",((JumpCloudApiSdkV2.Models.IWorkdayInputInternal)this).OauthCode, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Workday Input
    [System.ComponentModel.TypeConverter(typeof(WorkdayInputTypeConverter))]
    public partial interface IWorkdayInput

    {

    }
}