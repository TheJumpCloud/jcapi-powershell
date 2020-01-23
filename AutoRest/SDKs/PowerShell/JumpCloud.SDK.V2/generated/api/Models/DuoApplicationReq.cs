namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>DuoApplicationReq</summary>
    public partial class DuoApplicationReq :
        JumpCloud.SDK.V2.Models.IDuoApplicationReq,
        JumpCloud.SDK.V2.Models.IDuoApplicationReqInternal
    {

        /// <summary>Backing field for <see cref="ApiHost" /> property.</summary>
        private string _apiHost;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string ApiHost { get => this._apiHost; set => this._apiHost = value; }

        /// <summary>Backing field for <see cref="IntegrationKey" /> property.</summary>
        private string _integrationKey;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string IntegrationKey { get => this._integrationKey; set => this._integrationKey = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SecretKey" /> property.</summary>
        private string _secretKey;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SecretKey { get => this._secretKey; set => this._secretKey = value; }

        /// <summary>Creates an new <see cref="DuoApplicationReq" /> instance.</summary>
        public DuoApplicationReq()
        {

        }
    }
    /// DuoApplicationReq
    public partial interface IDuoApplicationReq :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"apiHost",
        PossibleTypes = new [] { typeof(string) })]
        string ApiHost { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"integrationKey",
        PossibleTypes = new [] { typeof(string) })]
        string IntegrationKey { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"secretKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecretKey { get; set; }

    }
    /// DuoApplicationReq
    internal partial interface IDuoApplicationReqInternal

    {
        string ApiHost { get; set; }

        string IntegrationKey { get; set; }

        string Name { get; set; }

        string SecretKey { get; set; }

    }
}