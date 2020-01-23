namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>System Insights Mounts</summary>
    public partial class SystemInsightsMounts
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref JumpCloud.SDK.V2.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref JumpCloud.SDK.V2.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode"/> into an instance of JumpCloud.SDK.V2.Models.ISystemInsightsMounts.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloud.SDK.V2.Models.ISystemInsightsMounts.</returns>
        public static JumpCloud.SDK.V2.Models.ISystemInsightsMounts FromJson(JumpCloud.SDK.V2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloud.SDK.V2.Runtime.Json.JsonObject json ? new SystemInsightsMounts(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloud.SDK.V2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsMounts" />.
        /// </summary>
        /// <param name="json">A JumpCloud.SDK.V2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsMounts(JumpCloud.SDK.V2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_type = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_path = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("path"), out var __jsonPath) ? (string)__jsonPath : (string)Path;}
            {_blocks = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("blocks"), out var __jsonBlocks) ? (string)__jsonBlocks : (string)Blocks;}
            {_blocksAvailable = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("blocks_available"), out var __jsonBlocksAvailable) ? (string)__jsonBlocksAvailable : (string)BlocksAvailable;}
            {_blocksFree = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("blocks_free"), out var __jsonBlocksFree) ? (string)__jsonBlocksFree : (string)BlocksFree;}
            {_blocksSize = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("blocks_size"), out var __jsonBlocksSize) ? (string)__jsonBlocksSize : (string)BlocksSize;}
            {_collectionTime = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_device = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("device"), out var __jsonDevice) ? (string)__jsonDevice : (string)Device;}
            {_deviceAlias = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("device_alias"), out var __jsonDeviceAlias) ? (string)__jsonDeviceAlias : (string)DeviceAlias;}
            {_flags = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("flags"), out var __jsonFlags) ? (string)__jsonFlags : (string)Flags;}
            {_inodes = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("inodes"), out var __jsonInodes) ? (string)__jsonInodes : (string)Inodes;}
            {_inodesFree = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("inodes_free"), out var __jsonInodesFree) ? (string)__jsonInodesFree : (string)InodesFree;}
            {_systemId = If( json?.PropertyT<JumpCloud.SDK.V2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsMounts" /> into a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloud.SDK.V2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsMounts" /> as a <see cref="JumpCloud.SDK.V2.Runtime.Json.JsonNode" />.
        /// </returns>
        public JumpCloud.SDK.V2.Runtime.Json.JsonNode ToJson(JumpCloud.SDK.V2.Runtime.Json.JsonObject container, JumpCloud.SDK.V2.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new JumpCloud.SDK.V2.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._type)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._path)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._path.ToString()) : null, "path" ,container.Add );
            AddIf( null != (((object)this._blocks)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._blocks.ToString()) : null, "blocks" ,container.Add );
            AddIf( null != (((object)this._blocksAvailable)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._blocksAvailable.ToString()) : null, "blocks_available" ,container.Add );
            AddIf( null != (((object)this._blocksFree)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._blocksFree.ToString()) : null, "blocks_free" ,container.Add );
            AddIf( null != (((object)this._blocksSize)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._blocksSize.ToString()) : null, "blocks_size" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._device)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._device.ToString()) : null, "device" ,container.Add );
            AddIf( null != (((object)this._deviceAlias)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._deviceAlias.ToString()) : null, "device_alias" ,container.Add );
            AddIf( null != (((object)this._flags)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._flags.ToString()) : null, "flags" ,container.Add );
            AddIf( null != (((object)this._inodes)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._inodes.ToString()) : null, "inodes" ,container.Add );
            AddIf( null != (((object)this._inodesFree)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._inodesFree.ToString()) : null, "inodes_free" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloud.SDK.V2.Runtime.Json.JsonNode) new JumpCloud.SDK.V2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}