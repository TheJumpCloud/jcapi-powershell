// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>DuoApplication</summary>
    public partial class DuoApplication :
        JumpCloud.SDK.V2.Models.IDuoApplication,
        JumpCloud.SDK.V2.Models.IDuoApplicationInternal
    {

        /// <summary>Backing field for <see cref="ApiHost" /> property.</summary>
        private string _apiHost;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string ApiHost { get => this._apiHost; set => this._apiHost = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IntegrationKey" /> property.</summary>
        private string _integrationKey;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string IntegrationKey { get => this._integrationKey; set => this._integrationKey = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DuoApplication" /> instance.</summary>
        public DuoApplication()
        {

        }
    }
    /// DuoApplication
    public partial interface IDuoApplication :
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
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

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

    }
    /// DuoApplication
    internal partial interface IDuoApplicationInternal

    {
        string ApiHost { get; set; }

        string Id { get; set; }

        string IntegrationKey { get; set; }

        string Name { get; set; }

    }
}