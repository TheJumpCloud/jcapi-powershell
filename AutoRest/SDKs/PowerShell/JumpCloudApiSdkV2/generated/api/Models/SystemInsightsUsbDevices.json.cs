namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights USB Devices</summary>
    public partial class SystemInsightsUsbDevices
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
        /// Deserializes a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode"/> into an instance of JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices.
        /// </summary>
        /// <param name="node">a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices.</returns>
        public static JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices FromJson(JumpCloudApiSdkV2.Runtime.Json.JsonNode node)
        {
            return node is JumpCloudApiSdkV2.Runtime.Json.JsonObject json ? new SystemInsightsUsbDevices(json) : null;
        }

        /// <summary>
        /// Deserializes a JumpCloudApiSdkV2.Runtime.Json.JsonObject into a new instance of <see cref="SystemInsightsUsbDevices" />.
        /// </summary>
        /// <param name="json">A JumpCloudApiSdkV2.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SystemInsightsUsbDevices(JumpCloudApiSdkV2.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_class = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("class"), out var __jsonClass) ? (string)__jsonClass : (string)Class;}
            {_collectionTime = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("collection_time"), out var __jsonCollectionTime) ? (string)__jsonCollectionTime : (string)CollectionTime;}
            {_model = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("model"), out var __jsonModel) ? (string)__jsonModel : (string)Model;}
            {_modelId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("model_id"), out var __jsonModelId) ? (string)__jsonModelId : (string)ModelId;}
            {_protocol = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("protocol"), out var __jsonProtocol) ? (string)__jsonProtocol : (string)Protocol;}
            {_removable = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("removable"), out var __jsonRemovable) ? (int?)__jsonRemovable : Removable;}
            {_serial = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("serial"), out var __jsonSerial) ? (string)__jsonSerial : (string)Serial;}
            {_subclass = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("subclass"), out var __jsonSubclass) ? (string)__jsonSubclass : (string)Subclass;}
            {_systemId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("system_id"), out var __jsonSystemId) ? (string)__jsonSystemId : (string)SystemId;}
            {_usbAddress = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("usb_address"), out var __jsonUsbAddress) ? (int?)__jsonUsbAddress : UsbAddress;}
            {_usbPort = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonNumber>("usb_port"), out var __jsonUsbPort) ? (int?)__jsonUsbPort : UsbPort;}
            {_vendor = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("vendor"), out var __jsonVendor) ? (string)__jsonVendor : (string)Vendor;}
            {_vendorId = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("vendor_id"), out var __jsonVendorId) ? (string)__jsonVendorId : (string)VendorId;}
            {_version = If( json?.PropertyT<JumpCloudApiSdkV2.Runtime.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SystemInsightsUsbDevices" /> into a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="JumpCloudApiSdkV2.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SystemInsightsUsbDevices" /> as a <see cref="JumpCloudApiSdkV2.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)this._class)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._class.ToString()) : null, "class" ,container.Add );
            AddIf( null != (((object)this._collectionTime)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._collectionTime.ToString()) : null, "collection_time" ,container.Add );
            AddIf( null != (((object)this._model)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._model.ToString()) : null, "model" ,container.Add );
            AddIf( null != (((object)this._modelId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._modelId.ToString()) : null, "model_id" ,container.Add );
            AddIf( null != (((object)this._protocol)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._protocol.ToString()) : null, "protocol" ,container.Add );
            AddIf( null != this._removable ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._removable) : null, "removable" ,container.Add );
            AddIf( null != (((object)this._serial)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._serial.ToString()) : null, "serial" ,container.Add );
            AddIf( null != (((object)this._subclass)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._subclass.ToString()) : null, "subclass" ,container.Add );
            AddIf( null != (((object)this._systemId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._systemId.ToString()) : null, "system_id" ,container.Add );
            AddIf( null != this._usbAddress ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._usbAddress) : null, "usb_address" ,container.Add );
            AddIf( null != this._usbPort ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode)new JumpCloudApiSdkV2.Runtime.Json.JsonNumber((int)this._usbPort) : null, "usb_port" ,container.Add );
            AddIf( null != (((object)this._vendor)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._vendor.ToString()) : null, "vendor" ,container.Add );
            AddIf( null != (((object)this._vendorId)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._vendorId.ToString()) : null, "vendor_id" ,container.Add );
            AddIf( null != (((object)this._version)?.ToString()) ? (JumpCloudApiSdkV2.Runtime.Json.JsonNode) new JumpCloudApiSdkV2.Runtime.Json.JsonString(this._version.ToString()) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}