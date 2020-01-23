namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>PolicyResult</summary>
    public partial class PolicyResult :
        JumpCloud.SDK.V2.Models.IPolicyResult,
        JumpCloud.SDK.V2.Models.IPolicyResultInternal
    {

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private string _detail;

        /// <summary>Details pertaining to the policy result.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Backing field for <see cref="EndedAt" /> property.</summary>
        private global::System.DateTime? _endedAt;

        /// <summary>The end of the policy application.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public global::System.DateTime? EndedAt { get => this._endedAt; set => this._endedAt = value; }

        /// <summary>Backing field for <see cref="ExitStatus" /> property.</summary>
        private int? _exitStatus;

        /// <summary>The 32-bit unsigned exit status from the applying the policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public int? ExitStatus { get => this._exitStatus; set => this._exitStatus = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ObjectId uniquely identifying a Policy Result.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="PolicyId" /> property.</summary>
        private string _policyId;

        /// <summary>ObjectId uniquely identifying the parent Policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string PolicyId { get => this._policyId; set => this._policyId = value; }

        /// <summary>Backing field for <see cref="StartedAt" /> property.</summary>
        private global::System.DateTime? _startedAt;

        /// <summary>The start of the policy application.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public global::System.DateTime? StartedAt { get => this._startedAt; set => this._startedAt = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Enumeration describing the state of the policy. Success, failed, or pending.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="StdErr" /> property.</summary>
        private string _stdErr;

        /// <summary>The STDERR output from applying the policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string StdErr { get => this._stdErr; set => this._stdErr = value; }

        /// <summary>Backing field for <see cref="StdOut" /> property.</summary>
        private string _stdOut;

        /// <summary>The STDOUT output from applying the policy.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string StdOut { get => this._stdOut; set => this._stdOut = value; }

        /// <summary>Backing field for <see cref="Success" /> property.</summary>
        private bool? _success;

        /// <summary>True if the policy was successfully applied; false otherwise.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public bool? Success { get => this._success; set => this._success = value; }

        /// <summary>Backing field for <see cref="SystemId" /> property.</summary>
        private string _systemId;

        /// <summary>ObjectId uniquely identifying the parent System.</summary>
        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string SystemId { get => this._systemId; set => this._systemId = value; }

        /// <summary>Creates an new <see cref="PolicyResult" /> instance.</summary>
        public PolicyResult()
        {

        }
    }
    /// PolicyResult
    public partial interface IPolicyResult :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        /// <summary>Details pertaining to the policy result.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Details pertaining to the policy result.",
        SerializedName = @"detail",
        PossibleTypes = new [] { typeof(string) })]
        string Detail { get; set; }
        /// <summary>The end of the policy application.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end of the policy application.",
        SerializedName = @"endedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndedAt { get; set; }
        /// <summary>The 32-bit unsigned exit status from the applying the policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The 32-bit unsigned exit status from the applying the policy.",
        SerializedName = @"exitStatus",
        PossibleTypes = new [] { typeof(int) })]
        int? ExitStatus { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Result.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying a Policy Result.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>ObjectId uniquely identifying the parent Policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying the parent Policy.",
        SerializedName = @"policyID",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get; set; }
        /// <summary>The start of the policy application.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start of the policy application.",
        SerializedName = @"startedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartedAt { get; set; }
        /// <summary>Enumeration describing the state of the policy. Success, failed, or pending.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enumeration describing the state of the policy. Success, failed, or pending.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>The STDERR output from applying the policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The STDERR output from applying the policy.",
        SerializedName = @"stdErr",
        PossibleTypes = new [] { typeof(string) })]
        string StdErr { get; set; }
        /// <summary>The STDOUT output from applying the policy.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The STDOUT output from applying the policy.",
        SerializedName = @"stdOut",
        PossibleTypes = new [] { typeof(string) })]
        string StdOut { get; set; }
        /// <summary>True if the policy was successfully applied; false otherwise.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the policy was successfully applied; false otherwise.",
        SerializedName = @"success",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Success { get; set; }
        /// <summary>ObjectId uniquely identifying the parent System.</summary>
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ObjectId uniquely identifying the parent System.",
        SerializedName = @"systemID",
        PossibleTypes = new [] { typeof(string) })]
        string SystemId { get; set; }

    }
    /// PolicyResult
    internal partial interface IPolicyResultInternal

    {
        /// <summary>Details pertaining to the policy result.</summary>
        string Detail { get; set; }
        /// <summary>The end of the policy application.</summary>
        global::System.DateTime? EndedAt { get; set; }
        /// <summary>The 32-bit unsigned exit status from the applying the policy.</summary>
        int? ExitStatus { get; set; }
        /// <summary>ObjectId uniquely identifying a Policy Result.</summary>
        string Id { get; set; }
        /// <summary>ObjectId uniquely identifying the parent Policy.</summary>
        string PolicyId { get; set; }
        /// <summary>The start of the policy application.</summary>
        global::System.DateTime? StartedAt { get; set; }
        /// <summary>Enumeration describing the state of the policy. Success, failed, or pending.</summary>
        string State { get; set; }
        /// <summary>The STDERR output from applying the policy.</summary>
        string StdErr { get; set; }
        /// <summary>The STDOUT output from applying the policy.</summary>
        string StdOut { get; set; }
        /// <summary>True if the policy was successfully applied; false otherwise.</summary>
        bool? Success { get; set; }
        /// <summary>ObjectId uniquely identifying the parent System.</summary>
        string SystemId { get; set; }

    }
}