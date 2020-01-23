namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>
    /// See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.
    /// </summary>
    public partial class BulkUserCreate :
        JumpCloud.SDK.V2.Models.IBulkUserCreate,
        JumpCloud.SDK.V2.Models.IBulkUserCreateInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IBulkUserCreateAttributesItem[] _attributes;

        /// <summary>Map of additional attributes.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IBulkUserCreateAttributesItem[] Attributes { get => this._attributes; set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="Firstname" /> property.</summary>
        private string _firstname;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Firstname { get => this._firstname; set => this._firstname = value; }

        /// <summary>Backing field for <see cref="Lastname" /> property.</summary>
        private string _lastname;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Lastname { get => this._lastname; set => this._lastname = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="BulkUserCreate" /> instance.</summary>
        public BulkUserCreate()
        {

        }
    }
    /// See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.
    public partial interface IBulkUserCreate :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>Map of additional attributes.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Map of additional attributes.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IBulkUserCreateAttributesItem) })]
        JumpCloud.SDK.V2.Models.IBulkUserCreateAttributesItem[] Attributes { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"firstname",
        PossibleTypes = new [] { typeof(string) })]
        string Firstname { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastname",
        PossibleTypes = new [] { typeof(string) })]
        string Lastname { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// See [V1 system user creation](https://docs.jumpcloud.com/1.0/systemusers/create-a-system-user) for full list of attributes.
    internal partial interface IBulkUserCreateInternal

    {
        /// <summary>Map of additional attributes.</summary>
        JumpCloud.SDK.V2.Models.IBulkUserCreateAttributesItem[] Attributes { get; set; }

        string Email { get; set; }

        string Firstname { get; set; }

        string Lastname { get; set; }

        string Username { get; set; }

    }
}