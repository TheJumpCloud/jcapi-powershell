namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class CommandfilereturnResults :
        JumpCloud.SDK.V1.Models.ICommandfilereturnResults,
        JumpCloud.SDK.V1.Models.ICommandfilereturnResultsInternal
    {

        /// <summary>Backing field for <see cref="Destination" /> property.</summary>
        private string _destination;

        /// <summary>The location where the file will be stored.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Destination { get => this._destination; set => this._destination = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the file.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The file name.</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="CommandfilereturnResults" /> instance.</summary>
        public CommandfilereturnResults()
        {

        }
    }
    public partial interface ICommandfilereturnResults :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        /// <summary>The location where the file will be stored.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location where the file will be stored.",
        SerializedName = @"destination",
        PossibleTypes = new [] { typeof(string) })]
        string Destination { get; set; }
        /// <summary>The ID of the file.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID of the file.",
        SerializedName = @"_id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The file name.</summary>
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The file name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    internal partial interface ICommandfilereturnResultsInternal

    {
        /// <summary>The location where the file will be stored.</summary>
        string Destination { get; set; }
        /// <summary>The ID of the file.</summary>
        string Id { get; set; }
        /// <summary>The file name.</summary>
        string Name { get; set; }

    }
}