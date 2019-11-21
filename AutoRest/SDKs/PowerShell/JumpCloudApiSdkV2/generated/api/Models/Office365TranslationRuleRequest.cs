namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>Office 365 Translation Rule Request</summary>
    public partial class Office365TranslationRuleRequest :
        JumpCloudApiSdkV2.Models.IOffice365TranslationRuleRequest,
        JumpCloudApiSdkV2.Models.IOffice365TranslationRuleRequestInternal
    {

        /// <summary>Backing field for <see cref="BuiltIn" /> property.</summary>
        private string _builtIn;

        /// <summary>
        /// Built-in translations for Office 365 (Microsoft Graph) export:
        /// * `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of
        /// Microsoft Graph user
        /// * `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph
        /// user
        /// * `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph
        /// `user`
        /// * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft
        /// Graph `user`
        /// * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of
        /// Microsoft Graph `user`
        /// * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones`
        /// field of Microsoft Graph `user`
        /// * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone`
        /// field of Microsoft Graph `user`
        /// * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`
        /// * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`
        /// * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`
        /// </summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string BuiltIn { get => this._builtIn; set => this._builtIn = value; }

        /// <summary>Creates an new <see cref="Office365TranslationRuleRequest" /> instance.</summary>
        public Office365TranslationRuleRequest()
        {

        }
    }
    /// Office 365 Translation Rule Request
    public partial interface IOffice365TranslationRuleRequest :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Built-in translations for Office 365 (Microsoft Graph) export:
        /// * `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of
        /// Microsoft Graph user
        /// * `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph
        /// user
        /// * `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph
        /// `user`
        /// * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft
        /// Graph `user`
        /// * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of
        /// Microsoft Graph `user`
        /// * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones`
        /// field of Microsoft Graph `user`
        /// * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone`
        /// field of Microsoft Graph `user`
        /// * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`
        /// * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`
        /// * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`
        /// </summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Built-in translations for Office 365 (Microsoft Graph) export:
        * `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user
        * `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph user
        * `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph `user`
        * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft Graph `user`
        * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of Microsoft Graph `user`
        * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones` field of Microsoft Graph `user`
        * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone` field of Microsoft Graph `user`
        * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`
        * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`
        * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user` ",
        SerializedName = @"builtIn",
        PossibleTypes = new [] { typeof(string) })]
        string BuiltIn { get; set; }

    }
    /// Office 365 Translation Rule Request
    internal partial interface IOffice365TranslationRuleRequestInternal

    {
        /// <summary>
        /// Built-in translations for Office 365 (Microsoft Graph) export:
        /// * `user_street_address` - Translate `streetAddress` field of JumpCloud user address of type `work` to `city` field of
        /// Microsoft Graph user
        /// * `user_city` - Translate `locality` field of JumpCloud user address of type `work` to `city` field of Microsoft Graph
        /// user
        /// * `user_state` - Translate `region` field of JumpCloud user address of type `work` to `state` field of Microsoft Graph
        /// `user`
        /// * `user_country` - Translate `country` field of JumpCloud user address of type `work` to `country` field of Microsoft
        /// Graph `user`
        /// * `user_postal_code` - Translate `postalCode` field of JumpCloud user address of type `work` to `postalCode` field of
        /// Microsoft Graph `user`
        /// * `user_business_phones` - Translate `number` field of first JumpCloud user `phoneNumber` of type `work` to `businessPhones`
        /// field of Microsoft Graph `user`
        /// * `user_mobile_phone` - Translate `number` field of first JumpCloud user `phoneNumber` of type `mobile` to `mobilePhone`
        /// field of Microsoft Graph `user`
        /// * `user_department` - Translate `department` field of JumpCloud user to `department` field of Microsoft Graph `user`
        /// * `user_job_title` - Translate `jobTitle` field of JumpCloud user to `jobTitle` field of Microsoft Graph `user`
        /// * `user_office_location` - Translate `location` field of JumpCloud user to `officeLocation` field of Microsoft Graph `user`
        /// </summary>
        string BuiltIn { get; set; }

    }
}