namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Workday Input</summary>
    public partial class WorkdayInput :
        JumpCloudApiSdkV2.Models.IWorkdayInput,
        JumpCloudApiSdkV2.Models.IWorkdayInputInternal
    {

        /// <summary>Backing field for <see cref="Auth" /> property.</summary>
        private JumpCloudApiSdkV2.Models.IAuthInput _auth;

        /// <summary>Auth Input</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        internal JumpCloudApiSdkV2.Models.IAuthInput Auth { get => (this._auth = this._auth ?? new JumpCloudApiSdkV2.Models.AuthInput()); set => this._auth = value; }

        /// <summary>FIXME: Property BasicPassword is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicPassword { get => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).BasicPassword; set => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).BasicPassword = value; }

        /// <summary>FIXME: Property BasicUsername is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string BasicUsername { get => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).BasicUsername; set => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).BasicUsername = value; }

        /// <summary>Internal Acessors for Auth</summary>
        JumpCloudApiSdkV2.Models.IAuthInput JumpCloudApiSdkV2.Models.IWorkdayInputInternal.Auth { get => (this._auth = this._auth ?? new JumpCloudApiSdkV2.Models.AuthInput()); set { {_auth = value;} } }

        /// <summary>Internal Acessors for AuthBasic</summary>
        JumpCloudApiSdkV2.Models.IAuthInputBasic JumpCloudApiSdkV2.Models.IWorkdayInputInternal.AuthBasic { get => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).Basic; set => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).Basic = value; }

        /// <summary>Internal Acessors for AuthOauth</summary>
        JumpCloudApiSdkV2.Models.IAuthInputOauth JumpCloudApiSdkV2.Models.IWorkdayInputInternal.AuthOauth { get => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).Oauth; set => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).Oauth = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>FIXME: Property OauthCode is MISSING DESCRIPTION</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Inlined)]
        public string OauthCode { get => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).OauthCode; set => ((JumpCloudApiSdkV2.Models.IAuthInputInternal)Auth).OauthCode = value; }

        /// <summary>Backing field for <see cref="ReportUrl" /> property.</summary>
        private string _reportUrl;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ReportUrl { get => this._reportUrl; set => this._reportUrl = value; }

        /// <summary>Creates an new <see cref="WorkdayInput" /> instance.</summary>
        public WorkdayInput()
        {

        }
    }
    /// Workday Input
    public partial interface IWorkdayInput :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string BasicPassword { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string BasicUsername { get; set; }

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
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string OauthCode { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"reportUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ReportUrl { get; set; }

    }
    /// Workday Input
    internal partial interface IWorkdayInputInternal

    {
        /// <summary>Auth Input</summary>
        JumpCloudApiSdkV2.Models.IAuthInput Auth { get; set; }

        JumpCloudApiSdkV2.Models.IAuthInputBasic AuthBasic { get; set; }

        JumpCloudApiSdkV2.Models.IAuthInputOauth AuthOauth { get; set; }

        string BasicPassword { get; set; }

        string BasicUsername { get; set; }

        string Name { get; set; }

        string OauthCode { get; set; }

        string ReportUrl { get; set; }

    }
}