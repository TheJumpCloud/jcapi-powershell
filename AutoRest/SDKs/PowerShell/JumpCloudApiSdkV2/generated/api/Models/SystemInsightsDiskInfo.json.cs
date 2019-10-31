namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Disk Info</summary>
    public partial class SystemInsightsDiskInfo
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
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemInsightsDiskInfo.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemInsightsDiskInfo.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsDiskInfo FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new SystemInsightsDiskInfo(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsDiskInfo" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsDiskInfo(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_type = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_description = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;}
            {_collectionTime = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_diskIndex = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("disk_index"), out var __jsonDiskIndex) ? (int?)__jsonDiskIndex : DiskIndex;}
            {_diskSize = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("disk_size"), out var __jsonDiskSize) ? (string)__jsonDiskSize : (string)DiskSize;}
            {_hardwareModel = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("hardware_model"), out var __jsonHardwareModel) ? (string)__jsonHardwareModel : (string)HardwareModel;}
            {_id = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_manufacturer = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("manufacturer"), out var __jsonManufacturer) ? (string)__jsonManufacturer : (string)Manufacturer;}
            {_partitions = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("partitions"), out var __jsonPartitions) ? (int?)__jsonPartitions : Partitions;}
            {_pnpDeviceId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("pnp_device_id"), out var __jsonPnpDeviceId) ? (string)__jsonPnpDeviceId : (string)PnpDeviceId;}
            {_serial = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("serial"), out var __jsonSerial) ? (string)__jsonSerial : (string)Serial;}
            {_systemId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsDiskInfo" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsDiskInfo" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._name)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != this._diskIndex ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._diskIndex) : null, "disk_index" ,container.Add );
            AddIf( null != (((object)this._diskSize)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._diskSize.ToString()) : null, "disk_size" ,container.Add );
            AddIf( null != (((object)this._hardwareModel)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._hardwareModel.ToString()) : null, "hardware_model" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != (((object)this._manufacturer)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._manufacturer.ToString()) : null, "manufacturer" ,container.Add );
            AddIf( null != this._partitions ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._partitions) : null, "partitions" ,container.Add );
            AddIf( null != (((object)this._pnpDeviceId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._pnpDeviceId.ToString()) : null, "pnp_device_id" ,container.Add );
            AddIf( null != (((object)this._serial)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._serial.ToString()) : null, "serial" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}