namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights System Info</summary>
    public partial class SystemInsightsSystemInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloudApiSdkV2.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloudApiSdkV2.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsSystemInfo FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new SystemInsightsSystemInfo(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsSystemInfo" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsSystemInfo(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_collectionTime = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_computerName = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("computer_name"), out var __jsonComputerName) ? (string)__jsonComputerName : (string)ComputerName;}
            {_cpuBrand = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("cpu_brand"), out var __jsonCpuBrand) ? (string)__jsonCpuBrand : (string)CpuBrand;}
            {_cpuLogicalCores = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("cpu_logical_cores"), out var __jsonCpuLogicalCores) ? (int?)__jsonCpuLogicalCores : CpuLogicalCores;}
            {_cpuMicrocode = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("cpu_microcode"), out var __jsonCpuMicrocode) ? (string)__jsonCpuMicrocode : (string)CpuMicrocode;}
            {_cpuPhysicalCores = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("cpu_physical_cores"), out var __jsonCpuPhysicalCores) ? (int?)__jsonCpuPhysicalCores : CpuPhysicalCores;}
            {_cpuSubtype = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("cpu_subtype"), out var __jsonCpuSubtype) ? (string)__jsonCpuSubtype : (string)CpuSubtype;}
            {_cpuType = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("cpu_type"), out var __jsonCpuType) ? (string)__jsonCpuType : (string)CpuType;}
            {_hardwareModel = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("hardware_model"), out var __jsonHardwareModel) ? (string)__jsonHardwareModel : (string)HardwareModel;}
            {_hardwareSerial = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("hardware_serial"), out var __jsonHardwareSerial) ? (string)__jsonHardwareSerial : (string)HardwareSerial;}
            {_hardwareVendor = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("hardware_vendor"), out var __jsonHardwareVendor) ? (string)__jsonHardwareVendor : (string)HardwareVendor;}
            {_hardwareVersion = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("hardware_version"), out var __jsonHardwareVersion) ? (string)__jsonHardwareVersion : (string)HardwareVersion;}
            {_hostname = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("hostname"), out var __jsonHostname) ? (string)__jsonHostname : (string)Hostname;}
            {_localHostname = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("local_hostname"), out var __jsonLocalHostname) ? (string)__jsonLocalHostname : (string)LocalHostname;}
            {_physicalMemory = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("physical_memory"), out var __jsonPhysicalMemory) ? (string)__jsonPhysicalMemory : (string)PhysicalMemory;}
            {_systemId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_uuid = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)Uuid;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsSystemInfo" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsSystemInfo" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloudApiSdkV2.Runtime.Json.JsonNode ToJson(JumpCloudApiSdkV2.Runtime.Json.JsonObject container, JumpCloudApiSdkV2.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloudApiSdkV2.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._computerName)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._computerName.ToString()) : null, "computer_name" ,container.Add );
            AddIf( null != (((object)this._cpuBrand)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._cpuBrand.ToString()) : null, "cpu_brand" ,container.Add );
            AddIf( null != this._cpuLogicalCores ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._cpuLogicalCores) : null, "cpu_logical_cores" ,container.Add );
            AddIf( null != (((object)this._cpuMicrocode)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._cpuMicrocode.ToString()) : null, "cpu_microcode" ,container.Add );
            AddIf( null != this._cpuPhysicalCores ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._cpuPhysicalCores) : null, "cpu_physical_cores" ,container.Add );
            AddIf( null != (((object)this._cpuSubtype)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._cpuSubtype.ToString()) : null, "cpu_subtype" ,container.Add );
            AddIf( null != (((object)this._cpuType)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._cpuType.ToString()) : null, "cpu_type" ,container.Add );
            AddIf( null != (((object)this._hardwareModel)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._hardwareModel.ToString()) : null, "hardware_model" ,container.Add );
            AddIf( null != (((object)this._hardwareSerial)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._hardwareSerial.ToString()) : null, "hardware_serial" ,container.Add );
            AddIf( null != (((object)this._hardwareVendor)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._hardwareVendor.ToString()) : null, "hardware_vendor" ,container.Add );
            AddIf( null != (((object)this._hardwareVersion)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._hardwareVersion.ToString()) : null, "hardware_version" ,container.Add );
            AddIf( null != (((object)this._hostname)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._hostname.ToString()) : null, "hostname" ,container.Add );
            AddIf( null != (((object)this._localHostname)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._localHostname.ToString()) : null, "local_hostname" ,container.Add );
            AddIf( null != (((object)this._physicalMemory)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._physicalMemory.ToString()) : null, "physical_memory" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != (((object)this._uuid)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._uuid.ToString()) : null, "uuid" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}