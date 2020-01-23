namespace JumpCloud.SDK.V2.Models
{
    using JumpCloud.SDK.V2.Runtime.PowerShell;

    /// <summary>PolicyResult</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyResultTypeConverter))]
    public partial class PolicyResult
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyResult" />.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyResult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into an instance of <see cref="JumpCloud.SDK.V2.Models.PolicyResult"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="JumpCloud.SDK.V2.Models.IPolicyResult" />.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyResult DeserializeFromPSObject(System.Management.Automation.PSObject content)
        {
            return new PolicyResult(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static JumpCloud.SDK.V2.Models.IPolicyResult FromJsonString(string jsonText) => FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyResult(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Detail = (string) content.GetValueForProperty("Detail",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Detail, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).EndedAt = (global::System.DateTime?) content.GetValueForProperty("EndedAt",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).EndedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).ExitStatus = (int?) content.GetValueForProperty("ExitStatus",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).ExitStatus, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).PolicyId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StartedAt = (global::System.DateTime?) content.GetValueForProperty("StartedAt",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StartedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).State, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdErr = (string) content.GetValueForProperty("StdErr",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdErr, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdOut = (string) content.GetValueForProperty("StdOut",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdOut, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Success = (bool?) content.GetValueForProperty("Success",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Success, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="System.Management.Automation.PSObject" /> into a new instance of <see cref="JumpCloud.SDK.V2.Models.PolicyResult"
        /// />.
        /// </summary>
        /// <param name="content">The System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyResult(System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Detail = (string) content.GetValueForProperty("Detail",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Detail, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).EndedAt = (global::System.DateTime?) content.GetValueForProperty("EndedAt",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).EndedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).ExitStatus = (int?) content.GetValueForProperty("ExitStatus",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).ExitStatus, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Id = (string) content.GetValueForProperty("Id",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Id, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).PolicyId = (string) content.GetValueForProperty("PolicyId",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).PolicyId, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StartedAt = (global::System.DateTime?) content.GetValueForProperty("StartedAt",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StartedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).State = (string) content.GetValueForProperty("State",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).State, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdErr = (string) content.GetValueForProperty("StdErr",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdErr, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdOut = (string) content.GetValueForProperty("StdOut",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).StdOut, global::System.Convert.ToString);
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Success = (bool?) content.GetValueForProperty("Success",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).Success, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).SystemId = (string) content.GetValueForProperty("SystemId",((JumpCloud.SDK.V2.Models.IPolicyResultInternal)this).SystemId, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, JumpCloud.SDK.V2.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// PolicyResult
    [System.ComponentModel.TypeConverter(typeof(PolicyResultTypeConverter))]
    public partial interface IPolicyResult

    {

    }
}