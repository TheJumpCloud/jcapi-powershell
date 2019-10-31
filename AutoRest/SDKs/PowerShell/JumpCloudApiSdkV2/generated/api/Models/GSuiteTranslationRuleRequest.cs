namespace JumpCloudApiSdkV2.Models
{
    using static JumpCloudApiSdkV2.Runtime.Extensions;

    /// <summary>G Suite Translation Rule Request</summary>
    public partial class GSuiteTranslationRuleRequest :
        JumpCloudApiSdkV2.Models.IGSuiteTranslationRuleRequest,
        JumpCloudApiSdkV2.Models.IGSuiteTranslationRuleRequestInternal
    {

        /// <summary>Backing field for <see cref="BuiltIn" /> property.</summary>
        private string _builtIn;

        /// <summary>
        /// Built-in translations for G Suite export:
        /// * `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of
        /// type `home`
        /// * `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of
        /// type `work`
        /// * `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses
        /// of type `other`
        /// * `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones
        /// of type `home`
        /// * `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones
        /// of type `mobile`
        /// * `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones
        /// of type `other`
        /// * `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones
        /// of type `work`
        /// * `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user
        /// phones of type `work_fax`
        /// * `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory
        /// user phones of type `work_mobile`
        /// * `user_primary_organization_cost_center` - Translate JumpCloud user `costCenter` to G Suite Directory user `costCenter`
        /// for `primary` organization
        /// * `user_primary_organization_department` - Translate JumpCloud user `department` to G Suite Directory user `department`
        /// for `primary` organization
        /// * `user_primary_organization_description` - Translate JumpCloud user `employeeType` to G Suite Directory user `description`
        /// for `primary` organization
        /// * `user_primary_organization_employee_id` - Translate JumpCloud user `employeeIdentifier` to G Suite Directory user `externalIds`
        /// element of type `organization`
        /// * `user_primary_organization_title` - Translate JumpCloud user `jobTitle` to G Suite Directory user `title` for `primary`
        /// organization
        /// </summary>
        [JumpCloudApiSdkV2.Origin(JumpCloudApiSdkV2.PropertyOrigin.Owned)]
        public string BuiltIn { get => this._builtIn; set => this._builtIn = value; }

        /// <summary>Creates an new <see cref="GSuiteTranslationRuleRequest" /> instance.</summary>
        public GSuiteTranslationRuleRequest()
        {

        }
    }
    /// G Suite Translation Rule Request
    public partial interface IGSuiteTranslationRuleRequest :
        JumpCloudApiSdkV2.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Built-in translations for G Suite export:
        /// * `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of
        /// type `home`
        /// * `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of
        /// type `work`
        /// * `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses
        /// of type `other`
        /// * `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones
        /// of type `home`
        /// * `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones
        /// of type `mobile`
        /// * `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones
        /// of type `other`
        /// * `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones
        /// of type `work`
        /// * `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user
        /// phones of type `work_fax`
        /// * `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory
        /// user phones of type `work_mobile`
        /// * `user_primary_organization_cost_center` - Translate JumpCloud user `costCenter` to G Suite Directory user `costCenter`
        /// for `primary` organization
        /// * `user_primary_organization_department` - Translate JumpCloud user `department` to G Suite Directory user `department`
        /// for `primary` organization
        /// * `user_primary_organization_description` - Translate JumpCloud user `employeeType` to G Suite Directory user `description`
        /// for `primary` organization
        /// * `user_primary_organization_employee_id` - Translate JumpCloud user `employeeIdentifier` to G Suite Directory user `externalIds`
        /// element of type `organization`
        /// * `user_primary_organization_title` - Translate JumpCloud user `jobTitle` to G Suite Directory user `title` for `primary`
        /// organization
        /// </summary>
        [JumpCloudApiSdkV2.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Built-in translations for G Suite export:
        * `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of type `home`
        * `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of type `work`
        * `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses of type `other`
        * `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones of type `home`
        * `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones of type `mobile`
        * `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones of type `other`
        * `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones of type `work`
        * `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user phones of type `work_fax`
        * `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory user phones of type `work_mobile`
        * `user_primary_organization_cost_center` - Translate JumpCloud user  `costCenter` to G Suite Directory user `costCenter` for `primary` organization
        * `user_primary_organization_department` - Translate JumpCloud user  `department` to G Suite Directory user `department` for `primary` organization
        * `user_primary_organization_description` - Translate JumpCloud user  `employeeType` to G Suite Directory user `description` for `primary` organization
        * `user_primary_organization_employee_id` - Translate JumpCloud user  `employeeIdentifier` to G Suite Directory user `externalIds` element of type `organization`
        * `user_primary_organization_title` - Translate JumpCloud user  `jobTitle` to G Suite Directory user `title` for `primary` organization
        ",
        SerializedName = @"builtIn",
        PossibleTypes = new [] { typeof(string) })]
        string BuiltIn { get; set; }

    }
    /// G Suite Translation Rule Request
    internal partial interface IGSuiteTranslationRuleRequestInternal

    {
        /// <summary>
        /// Built-in translations for G Suite export:
        /// * `user_home_addresses` - Translate all JumpCloud user addresses of type `home` to G Suite Directory user addresses of
        /// type `home`
        /// * `user_work_addresses` - Translate all JumpCloud user addresses of type `work` to G Suite Directory user addresses of
        /// type `work`
        /// * `user_other_addresses` - Translate all JumpCloud user addresses of type `other` to G Suite Directory user addresses
        /// of type `other`
        /// * `user_home_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `home` to G Suite Directory user phones
        /// of type `home`
        /// * `user_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `mobile` to G Suite Directory user phones
        /// of type `mobile`
        /// * `user_other_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `other` to G Suite Directory user phones
        /// of type `other`
        /// * `user_work_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work` to G Suite Directory user phones
        /// of type `work`
        /// * `user_work_fax_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_fax` to G Suite Directory user
        /// phones of type `work_fax`
        /// * `user_work_mobile_phone_numbers` - Translate all JumpCloud user phoneNumbers of type `work_mobile` to G Suite Directory
        /// user phones of type `work_mobile`
        /// * `user_primary_organization_cost_center` - Translate JumpCloud user `costCenter` to G Suite Directory user `costCenter`
        /// for `primary` organization
        /// * `user_primary_organization_department` - Translate JumpCloud user `department` to G Suite Directory user `department`
        /// for `primary` organization
        /// * `user_primary_organization_description` - Translate JumpCloud user `employeeType` to G Suite Directory user `description`
        /// for `primary` organization
        /// * `user_primary_organization_employee_id` - Translate JumpCloud user `employeeIdentifier` to G Suite Directory user `externalIds`
        /// element of type `organization`
        /// * `user_primary_organization_title` - Translate JumpCloud user `jobTitle` to G Suite Directory user `title` for `primary`
        /// organization
        /// </summary>
        string BuiltIn { get; set; }

    }
}