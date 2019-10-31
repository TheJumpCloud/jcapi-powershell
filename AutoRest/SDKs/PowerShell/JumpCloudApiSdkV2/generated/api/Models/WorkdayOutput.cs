namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Workday Output</summary>
    public partial class WorkdayOutput :
        JumpCloudApiSdkV2.Models.IWorkdayOutput,
        JumpCloudApiSdkV2.Models.IWorkdayOutputInternal
    {

        /// <summary>Backing field for <see cref="Auth" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IWorkdayOutputAuth _auth;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IWorkdayOutputAuth Auth { get => (this._auth = this._auth ?? new JumpCloudApiSdkV2.Models.WorkdayOutputAuth()); set => this._auth = value; }

        /// <summary>FIXME: Property BasicExpiry is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicExpiry { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).BasicExpiry; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).BasicExpiry = value; }

        /// <summary>FIXME: Property BasicIsValid is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? BasicIsValid { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).BasicIsValid; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).BasicIsValid = value; }

        /// <summary>FIXME: Property BasicMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicMessage { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).BasicMessage; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).BasicMessage = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Auth</summary>
        JumpCloudApiSdkV2.Models.IWorkdayOutputAuth JumpCloudApiSdkV2.Models.IWorkdayOutputInternal.Auth { get => (this._auth = this._auth ?? new JumpCloudApiSdkV2.Models.WorkdayOutputAuth()); set { {_auth = value;} } }

        /// <summary>Internal Acessors for AuthBasic</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo JumpCloudApiSdkV2.Models.IWorkdayOutputInternal.AuthBasic { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).Basic; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).Basic = value; }

        /// <summary>Internal Acessors for AuthOauth</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo JumpCloudApiSdkV2.Models.IWorkdayOutputInternal.AuthOauth { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).Oauth; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).Oauth = value; }

        /// <summary>Backing field for <see cref="LastImport" /> property.</summary>
        private string _lastImport;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string LastImport { get => this._lastImport; set => this._lastImport = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>FIXME: Property OauthExpiry is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string OauthExpiry { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).OauthExpiry; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).OauthExpiry = value; }

        /// <summary>FIXME: Property OauthIsValid is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public bool? OauthIsValid { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).OauthIsValid; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).OauthIsValid = value; }

        /// <summary>FIXME: Property OauthMessage is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string OauthMessage { get => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).OauthMessage; set => ((JumpCloudApiSdkV2.Models.IWorkdayOutputAuthInternal)Auth).OauthMessage = value; }

        /// <summary>Backing field for <see cref="ReportUrl" /> property.</summary>
        private string _reportUrl;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ReportUrl { get => this._reportUrl; set => this._reportUrl = value; }

        /// <summary>Creates an new <see cref="WorkdayOutput" /> instance.</summary>
        public WorkdayOutput()
        {

        }
    }
    /// Workday Output
    public partial interface IWorkdayOutput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string BasicExpiry { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BasicIsValid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string BasicMessage { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastImport",
        PossibleTypes = new [] { typeof(string) })]
        string LastImport { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string OauthExpiry { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OauthIsValid { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string OauthMessage { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"reportUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ReportUrl { get; set; }

    }
    /// Workday Output
    internal partial interface IWorkdayOutputInternal

    {
        JumpCloudApiSdkV2.Models.IWorkdayOutputAuth Auth { get; set; }
        /// <summary>Auth Info</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo AuthBasic { get; set; }
        /// <summary>Auth Info</summary>
        JumpCloudApiSdkV2.Models.IAuthInfo AuthOauth { get; set; }

        string BasicExpiry { get; set; }

        bool? BasicIsValid { get; set; }

        string BasicMessage { get; set; }

        string Id { get; set; }

        string LastImport { get; set; }

        string Name { get; set; }

        string OauthExpiry { get; set; }

        bool? OauthIsValid { get; set; }

        string OauthMessage { get; set; }

        string ReportUrl { get; set; }

    }
}