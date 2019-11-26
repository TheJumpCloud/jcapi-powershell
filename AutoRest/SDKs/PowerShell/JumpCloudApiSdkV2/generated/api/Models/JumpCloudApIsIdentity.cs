namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    public partial class JumpCloudApIsIdentity :
        JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentity,
        JumpCloudApiSdkV2.Models.IJumpCloudApIsIdentityInternal
    {

        /// <summary>Backing field for <see cref="AccountId" /> property.</summary>
        private string _accountId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string AccountId { get => this._accountId; set => this._accountId = value; }

        /// <summary>Backing field for <see cref="ActivedirectoryId" /> property.</summary>
        private string _activedirectoryId;

        /// <summary>ObjectID of the Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ActivedirectoryId { get => this._activedirectoryId; set => this._activedirectoryId = value; }

        /// <summary>Backing field for <see cref="ApplicationId" /> property.</summary>
        private string _applicationId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ApplicationId { get => this._applicationId; set => this._applicationId = value; }

        /// <summary>Backing field for <see cref="CommandId" /> property.</summary>
        private string _commandId;

        /// <summary>ObjectID of the Command.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string CommandId { get => this._commandId; set => this._commandId = value; }

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>ObjectID of the User Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Backing field for <see cref="GsuiteId" /> property.</summary>
        private string _gsuiteId;

        /// <summary>ObjectID of the G Suite instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string GsuiteId { get => this._gsuiteId; set => this._gsuiteId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectID of the User Group.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="JobId" /> property.</summary>
        private string _jobId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string JobId { get => this._jobId; set => this._jobId = value; }

        /// <summary>Backing field for <see cref="LdapserverId" /> property.</summary>
        private string _ldapserverId;

        /// <summary>ObjectID of the LDAP Server.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string LdapserverId { get => this._ldapserverId; set => this._ldapserverId = value; }

        /// <summary>Backing field for <see cref="Office365Id" /> property.</summary>
        private string _office365Id;

        /// <summary>ObjectID of the Office 365 instance.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string Office365Id { get => this._office365Id; set => this._office365Id = value; }

        /// <summary>Backing field for <see cref="PolicyId" /> property.</summary>
        private string _policyId;

        /// <summary>ObjectID of the Policy.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string PolicyId { get => this._policyId; set => this._policyId = value; }

        /// <summary>Backing field for <see cref="ProviderId" /> property.</summary>
        private string _providerId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string ProviderId { get => this._providerId; set => this._providerId = value; }

        /// <summary>Backing field for <see cref="RadiusserverId" /> property.</summary>
        private string _radiusserverId;

        /// <summary>ObjectID of the Radius Server.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string RadiusserverId { get => this._radiusserverId; set => this._radiusserverId = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>ObjectID of the User.</summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string UserId { get => this._userId; set => this._userId = value; }

        /// <summary>Backing field for <see cref="WorkdayId" /> property.</summary>
        private string _workdayId;

        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string WorkdayId { get => this._workdayId; set => this._workdayId = value; }

        /// <summary>Creates an new <see cref="JumpCloudApIsIdentity" /> instance.</summary>
        public JumpCloudApIsIdentity()
        {

        }
    }
    public partial interface IJumpCloudApIsIdentity :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"account_id",
        PossibleTypes = new [] { typeof(string) })]
        string AccountId { get; set; }
        /// <summary>ObjectID of the Active Directory instance.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the Active Directory instance.",
        SerializedName = @"activedirectory_id",
        PossibleTypes = new [] { typeof(string) })]
        string ActivedirectoryId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"application_id",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationId { get; set; }
        /// <summary>ObjectID of the Command.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the Command.",
        SerializedName = @"command_id",
        PossibleTypes = new [] { typeof(string) })]
        string CommandId { get; set; }
        /// <summary>ObjectID of the User Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the User Group.",
        SerializedName = @"group_id",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>ObjectID of the G Suite instance.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the G Suite instance.",
        SerializedName = @"gsuite_id",
        PossibleTypes = new [] { typeof(string) })]
        string GsuiteId { get; set; }
        /// <summary>ObjectID of the User Group.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the User Group.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"job_id",
        PossibleTypes = new [] { typeof(string) })]
        string JobId { get; set; }
        /// <summary>ObjectID of the LDAP Server.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the LDAP Server.",
        SerializedName = @"ldapserver_id",
        PossibleTypes = new [] { typeof(string) })]
        string LdapserverId { get; set; }
        /// <summary>ObjectID of the Office 365 instance.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the Office 365 instance.",
        SerializedName = @"office365_id",
        PossibleTypes = new [] { typeof(string) })]
        string Office365Id { get; set; }
        /// <summary>ObjectID of the Policy.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the Policy.",
        SerializedName = @"policy_id",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"provider_id",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderId { get; set; }
        /// <summary>ObjectID of the Radius Server.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the Radius Server.",
        SerializedName = @"radiusserver_id",
        PossibleTypes = new [] { typeof(string) })]
        string RadiusserverId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"system_id",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }
        /// <summary>ObjectID of the User.</summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectID of the User.",
        SerializedName = @"user_id",
        PossibleTypes = new [] { typeof(string) })]
        string UserId { get; set; }

        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"workday_id",
        PossibleTypes = new [] { typeof(string) })]
        string WorkdayId { get; set; }

    }
    internal partial interface IJumpCloudApIsIdentityInternal

    {
        string AccountId { get; set; }
        /// <summary>ObjectID of the Active Directory instance.</summary>
        string ActivedirectoryId { get; set; }

        string ApplicationId { get; set; }
        /// <summary>ObjectID of the Command.</summary>
        string CommandId { get; set; }
        /// <summary>ObjectID of the User Group.</summary>
        string GroupId { get; set; }
        /// <summary>ObjectID of the G Suite instance.</summary>
        string GsuiteId { get; set; }
        /// <summary>ObjectID of the User Group.</summary>
        string Id { get; set; }

        string JobId { get; set; }
        /// <summary>ObjectID of the LDAP Server.</summary>
        string LdapserverId { get; set; }
        /// <summary>ObjectID of the Office 365 instance.</summary>
        string Office365Id { get; set; }
        /// <summary>ObjectID of the Policy.</summary>
        string PolicyId { get; set; }

        string ProviderId { get; set; }
        /// <summary>ObjectID of the Radius Server.</summary>
        string RadiusserverId { get; set; }

        string SystemId { get; set; }
        /// <summary>ObjectID of the User.</summary>
        string UserId { get; set; }

        string WorkdayId { get; set; }

    }
}