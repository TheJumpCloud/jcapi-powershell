namespace JumpCloudApiSdkV1.Models
{
    using JumpCloudApiSdkV1.Runtime.PowerShell;

    /// <summary>CommandResult</summary>
    [System.ComponentModel.TypeConverter(typeof(CommandresultTypeConverter))]
    public partial class Commandresult
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Commandresult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Commandresult(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Response = (JumpCloudApiSdkV1.Models.ICommandresultResponse) content.GetValueForProperty("Response",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Response, JumpCloudApiSdkV1.Models.CommandresultResponseTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Command = (string) content.GetValueForProperty("Command",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Command, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Files = (string[]) content.GetValueForProperty("Files",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Files, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).RequestTime = (string) content.GetValueForProperty("RequestTime",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).RequestTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseTime = (string) content.GetValueForProperty("ResponseTime",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).System = (string) content.GetValueForProperty("System",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).System, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).User = (string) content.GetValueForProperty("User",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).User, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowId = (string) content.GetValueForProperty("WorkflowId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowInstanceId = (string) content.GetValueForProperty("WorkflowInstanceId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowInstanceId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseData = (JumpCloudApiSdkV1.Models.ICommandresultResponseData) content.GetValueForProperty("ResponseData",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseData, JumpCloudApiSdkV1.Models.CommandresultResponseDataTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseError = (string) content.GetValueForProperty("ResponseError",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseError, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseId = (string) content.GetValueForProperty("ResponseId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataExitCode = (int?) content.GetValueForProperty("DataExitCode",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataOutput = (string) content.GetValueForProperty("DataOutput",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataOutput, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloudApiSdkV1.Models.Commandresult"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal Commandresult(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Response = (JumpCloudApiSdkV1.Models.ICommandresultResponse) content.GetValueForProperty("Response",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Response, JumpCloudApiSdkV1.Models.CommandresultResponseTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Name = (string) content.GetValueForProperty("Name",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Name, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Command = (string) content.GetValueForProperty("Command",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Command, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Files = (string[]) content.GetValueForProperty("Files",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Files, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Organization = (string) content.GetValueForProperty("Organization",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Organization, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).RequestTime = (string) content.GetValueForProperty("RequestTime",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).RequestTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseTime = (string) content.GetValueForProperty("ResponseTime",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseTime, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Sudo = (bool?) content.GetValueForProperty("Sudo",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).Sudo, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).System = (string) content.GetValueForProperty("System",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).System, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).SystemId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).User = (string) content.GetValueForProperty("User",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).User, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowId = (string) content.GetValueForProperty("WorkflowId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowInstanceId = (string) content.GetValueForProperty("WorkflowInstanceId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).WorkflowInstanceId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseData = (JumpCloudApiSdkV1.Models.ICommandresultResponseData) content.GetValueForProperty("ResponseData",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseData, JumpCloudApiSdkV1.Models.CommandresultResponseDataTypeConverter.ConvertFrom);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseError = (string) content.GetValueForProperty("ResponseError",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseError, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseId = (string) content.GetValueForProperty("ResponseId",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).ResponseId, global::System.Convert.ToString);
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataExitCode = (int?) content.GetValueForProperty("DataExitCode",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataExitCode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataOutput = (string) content.GetValueForProperty("DataOutput",((JumpCloudApiSdkV1.Models.ICommandresultInternal)this).DataOutput, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Commandresult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ICommandresult" />.</returns>
        public static JumpCloudApiSdkV1.Models.ICommandresult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Commandresult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloudApiSdkV1.Models.Commandresult"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloudApiSdkV1.Models.ICommandresult" />.</returns>
        public static JumpCloudApiSdkV1.Models.ICommandresult DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new Commandresult(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Commandresult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloudApiSdkV1.Models.ICommandresult FromJsonString(string jsonText) => FromJson(JumpCloudApiSdkV1.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloudApiSdkV1.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// CommandResult
    [System.ComponentModel.TypeConverter(typeof(CommandresultTypeConverter))]
    public partial interface ICommandresult

    {

    }
}