// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    /// <summary>Workday Worker</summary>
    public partial class WorkdayWorker :
        JumpCloud.SDK.V2.Models.IWorkdayWorker,
        JumpCloud.SDK.V2.Models.IWorkdayWorkerInternal
    {

        /// <summary>Backing field for <see cref="Attributes" /> property.</summary>
        private JumpCloud.SDK.V2.Models.IWorkdayWorkerAttributes _attributes;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public JumpCloud.SDK.V2.Models.IWorkdayWorkerAttributes Attributes { get => (this._attributes = this._attributes ?? new JumpCloud.SDK.V2.Models.WorkdayWorkerAttributes()); set => this._attributes = value; }

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Backing field for <see cref="FirstName" /> property.</summary>
        private string _firstName;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string FirstName { get => this._firstName; set => this._firstName = value; }

        /// <summary>Backing field for <see cref="LastName" /> property.</summary>
        private string _lastName;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string LastName { get => this._lastName; set => this._lastName = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="WorkdayWorker" /> instance.</summary>
        public WorkdayWorker()
        {

        }
    }
    /// Workday Worker
    public partial interface IWorkdayWorker :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V2.Models.IWorkdayWorkerAttributes) })]
        JumpCloud.SDK.V2.Models.IWorkdayWorkerAttributes Attributes { get; set; }

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
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string FirstName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string LastName { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// Workday Worker
    internal partial interface IWorkdayWorkerInternal

    {
        JumpCloud.SDK.V2.Models.IWorkdayWorkerAttributes Attributes { get; set; }

        string Email { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Username { get; set; }

    }
}