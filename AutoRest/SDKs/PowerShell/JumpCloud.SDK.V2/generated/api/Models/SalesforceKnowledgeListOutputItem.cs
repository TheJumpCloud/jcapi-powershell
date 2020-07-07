// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6282, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace JumpCloud.SDK.V2.Models
{
    using static JumpCloud.SDK.V2.Runtime.Extensions;

    public partial class SalesforceKnowledgeListOutputItem :
        JumpCloud.SDK.V2.Models.ISalesforceKnowledgeListOutputItem,
        JumpCloud.SDK.V2.Models.ISalesforceKnowledgeListOutputItemInternal
    {

        /// <summary>Backing field for <see cref="Body" /> property.</summary>
        private string _body;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Body { get => this._body; set => this._body = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IsWhatsNew" /> property.</summary>
        private bool? _isWhatsNew;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public bool? IsWhatsNew { get => this._isWhatsNew; set => this._isWhatsNew = value; }

        /// <summary>Backing field for <see cref="Language" /> property.</summary>
        private string _language;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Language { get => this._language; set => this._language = value; }

        /// <summary>Backing field for <see cref="PublishStatus" /> property.</summary>
        private string _publishStatus;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string PublishStatus { get => this._publishStatus; set => this._publishStatus = value; }

        /// <summary>Backing field for <see cref="PublishedDate" /> property.</summary>
        private string _publishedDate;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string PublishedDate { get => this._publishedDate; set => this._publishedDate = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Title { get => this._title; set => this._title = value; }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Backing field for <see cref="WhatsNewBlurb" /> property.</summary>
        private string _whatsNewBlurb;

        [JumpCloud.SDK.V2.Origin(JumpCloud.SDK.V2.PropertyOrigin.Owned)]
        public string WhatsNewBlurb { get => this._whatsNewBlurb; set => this._whatsNewBlurb = value; }

        /// <summary>Creates an new <see cref="SalesforceKnowledgeListOutputItem" /> instance.</summary>
        public SalesforceKnowledgeListOutputItem()
        {

        }
    }
    public partial interface ISalesforceKnowledgeListOutputItem :
        JumpCloud.SDK.V2.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"body",
        PossibleTypes = new [] { typeof(string) })]
        string Body { get; set; }

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
        SerializedName = @"isWhatsNew",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsWhatsNew { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"language",
        PossibleTypes = new [] { typeof(string) })]
        string Language { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"publishStatus",
        PossibleTypes = new [] { typeof(string) })]
        string PublishStatus { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"publishedDate",
        PossibleTypes = new [] { typeof(string) })]
        string PublishedDate { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

        [JumpCloud.SDK.V2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"whatsNewBlurb",
        PossibleTypes = new [] { typeof(string) })]
        string WhatsNewBlurb { get; set; }

    }
    internal partial interface ISalesforceKnowledgeListOutputItemInternal

    {
        string Body { get; set; }

        string Id { get; set; }

        bool? IsWhatsNew { get; set; }

        string Language { get; set; }

        string PublishStatus { get; set; }

        string PublishedDate { get; set; }

        string Title { get; set; }

        string Url { get; set; }

        string WhatsNewBlurb { get; set; }

    }
}