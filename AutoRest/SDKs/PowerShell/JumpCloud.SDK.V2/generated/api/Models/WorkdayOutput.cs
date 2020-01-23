namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Workday Output</summary>
    public partial class WorkdayOutput :
        JumpCloud.SDK.V2.Models.IWorkdayOutput,
        JumpCloud.SDK.V2.Models.IWorkdayOutputInternal
    {

        /// <summary>Backing field for <see cref="Auth" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IWorkdayOutputAuth _auth;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V2.Models.IWorkdayOutputAuth Auth { get => (this._auth = this._auth ?? new JumpCloud.SDK.V2.Models.WorkdayOutputAuth()); set => this._auth = value; }

        /// <summary>FIXME: Property BasicExpiry is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicExpiry { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).BasicExpiry; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).BasicExpiry = value; }

        /// <summary>FIXME: Property BasicIsValid is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? BasicIsValid { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).BasicIsValid; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).BasicIsValid = value; }

        /// <summary>FIXME: Property BasicMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string BasicMessage { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).BasicMessage; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).BasicMessage = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Auth</summary>
        JumpCloud.SDK.V2.Models.IWorkdayOutputAuth JumpCloud.SDK.V2.Models.IWorkdayOutputInternal.Auth { get => (this._auth = this._auth ?? new JumpCloud.SDK.V2.Models.WorkdayOutputAuth()); set { {_auth = value;} } }

        /// <summary>Internal Acessors for AuthBasic</summary>
        JumpCloud.SDK.V2.Models.IAuthInfo JumpCloud.SDK.V2.Models.IWorkdayOutputInternal.AuthBasic { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).Basic; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).Basic = value; }

        /// <summary>Internal Acessors for AuthOauth</summary>
        JumpCloud.SDK.V2.Models.IAuthInfo JumpCloud.SDK.V2.Models.IWorkdayOutputInternal.AuthOauth { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).Oauth; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).Oauth = value; }

        /// <summary>Backing field for <see cref="LastImport" /> property.</summary>
        private string _lastImport;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string LastImport { get => this._lastImport; set => this._lastImport = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>FIXME: Property OauthExpiry is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string OauthExpiry { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).OauthExpiry; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).OauthExpiry = value; }

        /// <summary>FIXME: Property OauthIsValid is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public bool? OauthIsValid { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).OauthIsValid; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).OauthIsValid = value; }

        /// <summary>FIXME: Property OauthMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Inlined)]
        public string OauthMessage { get => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).OauthMessage; set => ((JumpCloud.SDK.V2.Models.IWorkdayOutputAuthInternal)Auth).OauthMessage = value; }

        /// <summary>Backing field for <see cref="ReportUrl" /> property.</summary>
        private string _reportUrl;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string ReportUrl { get => this._reportUrl; set => this._reportUrl = value; }

        /// <summary>Creates an new <see cref="WorkdayOutput" /> instance.</summary>
        public WorkdayOutput()
        {

        }
    }
    /// Workday Output
    public partial interface IWorkdayOutput :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string BasicExpiry { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BasicIsValid { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string BasicMessage { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastImport",
        PossibleTypes = new [] { typeof(string) })]
        string LastImport { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string OauthExpiry { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? OauthIsValid { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string OauthMessage { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
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
        JumpCloud.SDK.V2.Models.IWorkdayOutputAuth Auth { get; set; }
        /// <summary>Auth Info</summary>
        JumpCloud.SDK.V2.Models.IAuthInfo AuthBasic { get; set; }
        /// <summary>Auth Info</summary>
        JumpCloud.SDK.V2.Models.IAuthInfo AuthOauth { get; set; }

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