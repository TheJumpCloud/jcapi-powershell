namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights USB Devices</summary>
    public partial class SystemInsightsUsbDevices :
        JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevices,
        JumpCloudApiSdkV2.Models.ISystemInsightsUsbDevicesInternal
    {

        /// <summary>Backing field for <see cref="Class" /> property.</summary>
        private string _class;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Class { get => this._class; set => this._class = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="ModelId" /> property.</summary>
        private string _modelId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ModelId { get => this._modelId; set => this._modelId = value; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Backing field for <see cref="Removable" /> property.</summary>
        private int? _removable;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? Removable { get => this._removable; set => this._removable = value; }

        /// <summary>Backing field for <see cref="Serial" /> property.</summary>
        private string _serial;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Serial { get => this._serial; set => this._serial = value; }

        /// <summary>Backing field for <see cref="Subclass" /> property.</summary>
        private string _subclass;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Subclass { get => this._subclass; set => this._subclass = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="UsbAddress" /> property.</summary>
        private int? _usbAddress;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? UsbAddress { get => this._usbAddress; set => this._usbAddress = value; }

        /// <summary>Backing field for <see cref="UsbPort" /> property.</summary>
        private int? _usbPort;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public int? UsbPort { get => this._usbPort; set => this._usbPort = value; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Backing field for <see cref="VendorId" /> property.</summary>
        private string _vendorId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string VendorId { get => this._vendorId; set => this._vendorId = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="SystemInsightsUsbDevices" /> instance.</summary>
        public SystemInsightsUsbDevices()
        {

        }
    }
    /// System Insights USB Devices
    public partial interface ISystemInsightsUsbDevices :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"class",
        PossibleTypes = new [] { typeof(string) })]
        string Class { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"collection_time",
        PossibleTypes = new [] { typeof(string) })]
        string CollectionTime { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"model_id",
        PossibleTypes = new [] { typeof(string) })]
        string ModelId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        string Protocol { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"removable",
        PossibleTypes = new [] { typeof(int) })]
        int? Removable { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"serial",
        PossibleTypes = new [] { typeof(string) })]
        string Serial { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subclass",
        PossibleTypes = new [] { typeof(string) })]
        string Subclass { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"usb_address",
        PossibleTypes = new [] { typeof(int) })]
        int? UsbAddress { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"usb_port",
        PossibleTypes = new [] { typeof(int) })]
        int? UsbPort { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"vendor_id",
        PossibleTypes = new [] { typeof(string) })]
        string VendorId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// System Insights USB Devices
    internal partial interface ISystemInsightsUsbDevicesInternal

    {
        string Class { get; set; }

        string CollectionTime { get; set; }

        string Model { get; set; }

        string ModelId { get; set; }

        string Protocol { get; set; }

        int? Removable { get; set; }

        string Serial { get; set; }

        string Subclass { get; set; }

        string SystemId { get; set; }

        int? UsbAddress { get; set; }

        int? UsbPort { get; set; }

        string Vendor { get; set; }

        string VendorId { get; set; }

        string Version { get; set; }

    }
}