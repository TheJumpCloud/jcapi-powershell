namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class OrganizationslistResultsItem :
        JumpCloud.SDK.V1.Models.IOrganizationslistResultsItem,
        JumpCloud.SDK.V1.Models.IOrganizationslistResultsItemInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The name of the organization.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the organization.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LogoUrl" /> property.</summary>
        private string _logoUrl;

        /// <summary>The organization logo image URL.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string LogoUrl { get => this._logoUrl; set => this._logoUrl = value; }

        /// <summary>Creates an new <see cref="OrganizationslistResultsItem" /> instance.</summary>
        public OrganizationslistResultsItem()
        {

        }
    }
    public partial interface IOrganizationslistResultsItem :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>The name of the organization.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the organization.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The ID of the organization.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the organization.",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The organization logo image URL.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The organization logo image URL. ",
        SerializedName = @"logoUrl",
        PossibleTypes = new [] { typeof(string) })]
        string LogoUrl { get; set; }

    }
    internal partial interface IOrganizationslistResultsItemInternal

    {
        /// <summary>The name of the organization.</summary>
        string DisplayName { get; set; }
        /// <summary>The ID of the organization.</summary>
        string Id { get; set; }
        /// <summary>The organization logo image URL.</summary>
        string LogoUrl { get; set; }

    }
}