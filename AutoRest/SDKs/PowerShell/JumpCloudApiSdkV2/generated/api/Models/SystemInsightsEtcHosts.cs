namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>System Insights Etc Hosts</summary>
    public partial class SystemInsightsEtcHosts :
        JumpCloudApiSdkV2.Models.ISystemInsightsEtcHosts,
        JumpCloudApiSdkV2.Models.ISystemInsightsEtcHostsInternal
    {

        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private string _address;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Address { get => this._address; set => this._address = value; }

        /// <summary>Backing field for <see cref="CollectionTime" /> property.</summary>
        private string _collectionTime;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CollectionTime { get => this._collectionTime; set => this._collectionTime = value; }

        /// <summary>Backing field for <see cref="Hostnames" /> property.</summary>
        private string _hostnames;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Hostnames { get => this._hostnames; set => this._hostnames = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Creates an new <see cref="SystemInsightsEtcHosts" /> instance.</summary>
        public SystemInsightsEtcHosts()
        {

        }
    }
    /// System Insights Etc Hosts
    public partial interface ISystemInsightsEtcHosts :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"address",
        PossibleTypes = new [] { typeof(string) })]
        string Address { get; set; }

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
        SerializedName = @"hostnames",
        PossibleTypes = new [] { typeof(string) })]
        string Hostnames { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

    }
    /// System Insights Etc Hosts
    internal partial interface ISystemInsightsEtcHostsInternal

    {
        string Address { get; set; }

        string CollectionTime { get; set; }

        string Hostnames { get; set; }

        string SystemId { get; set; }

    }
}