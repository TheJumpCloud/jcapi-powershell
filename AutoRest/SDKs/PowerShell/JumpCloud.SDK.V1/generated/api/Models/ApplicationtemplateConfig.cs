namespace JumpCloud.SDK.V1.Models
{
    using static JumpCloud.SDK.V1.Runtime.Extensions;

    public partial class ApplicationtemplateConfig :
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfig,
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal
    {

        /// <summary>FIXME: Property AcUrlLabel is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcUrlLabel { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Label; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Label = value; }

        /// <summary>FIXME: Property AcUrlOptions is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcUrlOptions { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Options; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Options = value; }

        /// <summary>FIXME: Property AcUrlPosition is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? AcUrlPosition { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Position; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Position = value; }

        /// <summary>FIXME: Property AcUrlReadOnly is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? AcUrlReadOnly { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).ReadOnly; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).ReadOnly = value; }

        /// <summary>FIXME: Property AcUrlRequired is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? AcUrlRequired { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Required; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Required = value; }

        /// <summary>FIXME: Property AcUrlToggle is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcUrlToggle { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Toggle; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Toggle = value; }

        /// <summary>FIXME: Property AcUrlType is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcUrlType { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Type; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Type = value; }

        /// <summary>FIXME: Property AcUrlValue is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcUrlValue { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Value; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Value = value; }

        /// <summary>FIXME: Property AcUrlVisible is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? AcUrlVisible { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Visible; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Visible = value; }

        /// <summary>Backing field for <see cref="AcsUrl" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrl _acsUrl;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrl AcsUrl { get => (this._acsUrl = this._acsUrl ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrl()); set => this._acsUrl = value; }

        /// <summary>FIXME: Property AcsUrlTooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcsUrlTooltipTemplate { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).TooltipTemplate; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).TooltipTemplate = value; }

        /// <summary>FIXME: Property AcsUrlTooltipVariablesIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcsUrlTooltipVariablesIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).VariableIcon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).VariableIcon = value; }

        /// <summary>FIXME: Property AcsUrlTooltipVariablesMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string AcsUrlTooltipVariablesMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).VariableMessage; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).VariableMessage = value; }

        /// <summary>FIXME: Property ConstantAttributeLabel is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ConstantAttributeLabel { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Label; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Label = value; }

        /// <summary>FIXME: Property ConstantAttributeMutable is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? ConstantAttributeMutable { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Mutable; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Mutable = value; }

        /// <summary>FIXME: Property ConstantAttributeOptions is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ConstantAttributeOptions { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Options; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Options = value; }

        /// <summary>FIXME: Property ConstantAttributePosition is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? ConstantAttributePosition { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Position; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Position = value; }

        /// <summary>FIXME: Property ConstantAttributeReadOnly is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? ConstantAttributeReadOnly { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).ReadOnly; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).ReadOnly = value; }

        /// <summary>FIXME: Property ConstantAttributeRequired is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? ConstantAttributeRequired { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Required; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Required = value; }

        /// <summary>FIXME: Property ConstantAttributeToggle is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ConstantAttributeToggle { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Toggle; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Toggle = value; }

        /// <summary>FIXME: Property ConstantAttributeType is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ConstantAttributeType { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Type; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Type = value; }

        /// <summary>FIXME: Property ConstantAttributeValue is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem[] ConstantAttributeValue { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Value; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Value = value; }

        /// <summary>FIXME: Property ConstantAttributeVisible is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? ConstantAttributeVisible { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Visible; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Visible = value; }

        /// <summary>Backing field for <see cref="ConstantAttributes" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributes _constantAttributes;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributes ConstantAttributes { get => (this._constantAttributes = this._constantAttributes ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigConstantAttributes()); set => this._constantAttributes = value; }

        /// <summary>FIXME: Property ConstantAttributesTooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ConstantAttributesTooltipTemplate { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).TooltipTemplate; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).TooltipTemplate = value; }

        /// <summary>FIXME: Property ConstantAttributesTooltipVariablesIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ConstantAttributesTooltipVariablesIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).VariableIcon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).VariableIcon = value; }

        /// <summary>
        /// FIXME: Property ConstantAttributesTooltipVariablesMessage is MISSING DESCRIPTION
        /// </summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string ConstantAttributesTooltipVariablesMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).VariableMessage; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).VariableMessage = value; }

        /// <summary>FIXME: Property DatabaseAttributePosition is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? DatabaseAttributePosition { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributesInternal)DatabaseAttributes).Position; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributesInternal)DatabaseAttributes).Position = value; }

        /// <summary>Backing field for <see cref="DatabaseAttributes" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributes _databaseAttributes;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributes DatabaseAttributes { get => (this._databaseAttributes = this._databaseAttributes ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigDatabaseAttributes()); set => this._databaseAttributes = value; }

        /// <summary>Backing field for <see cref="IdpCertificate" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificate _idpCertificate;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificate IdpCertificate { get => (this._idpCertificate = this._idpCertificate ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpCertificate()); set => this._idpCertificate = value; }

        /// <summary>FIXME: Property IdpCertificateLabel is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateLabel { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Label; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Label = value; }

        /// <summary>FIXME: Property IdpCertificateOptions is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateOptions { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Options; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Options = value; }

        /// <summary>FIXME: Property IdpCertificatePosition is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? IdpCertificatePosition { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Position; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Position = value; }

        /// <summary>FIXME: Property IdpCertificateReadOnly is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpCertificateReadOnly { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).ReadOnly; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).ReadOnly = value; }

        /// <summary>FIXME: Property IdpCertificateRequired is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpCertificateRequired { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Required; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Required = value; }

        /// <summary>FIXME: Property IdpCertificateToggle is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateToggle { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Toggle; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Toggle = value; }

        /// <summary>FIXME: Property IdpCertificateTooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateTooltipTemplate { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).TooltipTemplate; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).TooltipTemplate = value; }

        /// <summary>FIXME: Property IdpCertificateTooltipVariablesIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateTooltipVariablesIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).VariableIcon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).VariableIcon = value; }

        /// <summary>FIXME: Property IdpCertificateTooltipVariablesMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateTooltipVariablesMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).VariableMessage; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).VariableMessage = value; }

        /// <summary>FIXME: Property IdpCertificateType is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateType { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Type; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Type = value; }

        /// <summary>FIXME: Property IdpCertificateValue is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpCertificateValue { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Value; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Value = value; }

        /// <summary>FIXME: Property IdpCertificateVisible is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpCertificateVisible { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Visible; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Visible = value; }

        /// <summary>Backing field for <see cref="IdpEntityId" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityId _idpEntityId;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityId IdpEntityId { get => (this._idpEntityId = this._idpEntityId ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpEntityId()); set => this._idpEntityId = value; }

        /// <summary>FIXME: Property IdpEntityIdLabel is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdLabel { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Label; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Label = value; }

        /// <summary>FIXME: Property IdpEntityIdOptions is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdOptions { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Options; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Options = value; }

        /// <summary>FIXME: Property IdpEntityIdPosition is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? IdpEntityIdPosition { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Position; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Position = value; }

        /// <summary>FIXME: Property IdpEntityIdReadOnly is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpEntityIdReadOnly { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).ReadOnly; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).ReadOnly = value; }

        /// <summary>FIXME: Property IdpEntityIdRequired is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpEntityIdRequired { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Required; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Required = value; }

        /// <summary>FIXME: Property IdpEntityIdToggle is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdToggle { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Toggle; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Toggle = value; }

        /// <summary>FIXME: Property IdpEntityIdTooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdTooltipTemplate { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).TooltipTemplate; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).TooltipTemplate = value; }

        /// <summary>FIXME: Property IdpEntityIdTooltipVariablesIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdTooltipVariablesIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).VariableIcon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).VariableIcon = value; }

        /// <summary>FIXME: Property IdpEntityIdTooltipVariablesMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdTooltipVariablesMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).VariableMessage; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).VariableMessage = value; }

        /// <summary>FIXME: Property IdpEntityIdType is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdType { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Type; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Type = value; }

        /// <summary>FIXME: Property IdpEntityIdValue is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpEntityIdValue { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Value; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Value = value; }

        /// <summary>FIXME: Property IdpEntityIdVisible is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpEntityIdVisible { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Visible; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Visible = value; }

        /// <summary>Backing field for <see cref="IdpPrivateKey" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKey _idpPrivateKey;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKey IdpPrivateKey { get => (this._idpPrivateKey = this._idpPrivateKey ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpPrivateKey()); set => this._idpPrivateKey = value; }

        /// <summary>FIXME: Property IdpPrivateKeyLabel is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyLabel { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Label; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Label = value; }

        /// <summary>FIXME: Property IdpPrivateKeyOptions is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyOptions { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Options; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Options = value; }

        /// <summary>FIXME: Property IdpPrivateKeyPosition is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? IdpPrivateKeyPosition { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Position; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Position = value; }

        /// <summary>FIXME: Property IdpPrivateKeyReadOnly is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpPrivateKeyReadOnly { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).ReadOnly; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).ReadOnly = value; }

        /// <summary>FIXME: Property IdpPrivateKeyRequired is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpPrivateKeyRequired { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Required; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Required = value; }

        /// <summary>FIXME: Property IdpPrivateKeyToggle is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyToggle { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Toggle; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Toggle = value; }

        /// <summary>FIXME: Property IdpPrivateKeyTooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyTooltipTemplate { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).TooltipTemplate; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).TooltipTemplate = value; }

        /// <summary>FIXME: Property IdpPrivateKeyTooltipVariablesIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyTooltipVariablesIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).VariableIcon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).VariableIcon = value; }

        /// <summary>FIXME: Property IdpPrivateKeyTooltipVariablesMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyTooltipVariablesMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).VariableMessage; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).VariableMessage = value; }

        /// <summary>FIXME: Property IdpPrivateKeyType is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyType { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Type; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Type = value; }

        /// <summary>FIXME: Property IdpPrivateKeyValue is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string IdpPrivateKeyValue { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Value; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Value = value; }

        /// <summary>FIXME: Property IdpPrivateKeyVisible is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? IdpPrivateKeyVisible { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Visible; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Visible = value; }

        /// <summary>Internal Acessors for AcUrlTooltip</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltip JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.AcUrlTooltip { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Tooltip; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).Tooltip = value; }

        /// <summary>Internal Acessors for AcsUrl</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrl JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.AcsUrl { get => (this._acsUrl = this._acsUrl ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigAcsUrl()); set { {_acsUrl = value;} } }

        /// <summary>Internal Acessors for AcsUrlTooltipVariables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.AcsUrlTooltipVariables { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).TooltipVariables; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlInternal)AcsUrl).TooltipVariables = value; }

        /// <summary>Internal Acessors for ConstantAttributeTooltip</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltip JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.ConstantAttributeTooltip { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Tooltip; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).Tooltip = value; }

        /// <summary>Internal Acessors for ConstantAttributes</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributes JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.ConstantAttributes { get => (this._constantAttributes = this._constantAttributes ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigConstantAttributes()); set { {_constantAttributes = value;} } }

        /// <summary>Internal Acessors for ConstantAttributesTooltipVariables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.ConstantAttributesTooltipVariables { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).TooltipVariables; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesInternal)ConstantAttributes).TooltipVariables = value; }

        /// <summary>Internal Acessors for DatabaseAttributes</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributes JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.DatabaseAttributes { get => (this._databaseAttributes = this._databaseAttributes ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigDatabaseAttributes()); set { {_databaseAttributes = value;} } }

        /// <summary>Internal Acessors for IdpCertificate</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificate JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpCertificate { get => (this._idpCertificate = this._idpCertificate ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpCertificate()); set { {_idpCertificate = value;} } }

        /// <summary>Internal Acessors for IdpCertificateTooltip</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateTooltip JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpCertificateTooltip { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Tooltip; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).Tooltip = value; }

        /// <summary>Internal Acessors for IdpCertificateTooltipVariables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpCertificateTooltipVariables { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).TooltipVariables; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateInternal)IdpCertificate).TooltipVariables = value; }

        /// <summary>Internal Acessors for IdpEntityId</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityId JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpEntityId { get => (this._idpEntityId = this._idpEntityId ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpEntityId()); set { {_idpEntityId = value;} } }

        /// <summary>Internal Acessors for IdpEntityIdTooltip</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdTooltip JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpEntityIdTooltip { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Tooltip; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).Tooltip = value; }

        /// <summary>Internal Acessors for IdpEntityIdTooltipVariables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpEntityIdTooltipVariables { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).TooltipVariables; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdInternal)IdpEntityId).TooltipVariables = value; }

        /// <summary>Internal Acessors for IdpPrivateKey</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKey JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpPrivateKey { get => (this._idpPrivateKey = this._idpPrivateKey ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigIdpPrivateKey()); set { {_idpPrivateKey = value;} } }

        /// <summary>Internal Acessors for IdpPrivateKeyTooltip</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltip JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpPrivateKeyTooltip { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Tooltip; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).Tooltip = value; }

        /// <summary>Internal Acessors for IdpPrivateKeyTooltipVariables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.IdpPrivateKeyTooltipVariables { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).TooltipVariables; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyInternal)IdpPrivateKey).TooltipVariables = value; }

        /// <summary>Internal Acessors for SpEntityId</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.SpEntityId { get => (this._spEntityId = this._spEntityId ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityId()); set { {_spEntityId = value;} } }

        /// <summary>Internal Acessors for SpEntityIdTooltip</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltip JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.SpEntityIdTooltip { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Tooltip; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Tooltip = value; }

        /// <summary>Internal Acessors for SpEntityIdTooltipVariables</summary>
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables JumpCloud.SDK.V1.Models.IApplicationtemplateConfigInternal.SpEntityIdTooltipVariables { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).TooltipVariables; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).TooltipVariables = value; }

        /// <summary>Backing field for <see cref="SpEntityId" /> property.</summary>
        private JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId _spEntityId;

        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Owned)]
        internal JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId SpEntityId { get => (this._spEntityId = this._spEntityId ?? new JumpCloud.SDK.V1.Models.ApplicationtemplateConfigSpEntityId()); set => this._spEntityId = value; }

        /// <summary>FIXME: Property SpEntityIdLabel is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdLabel { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Label; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Label = value; }

        /// <summary>FIXME: Property SpEntityIdOptions is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdOptions { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Options; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Options = value; }

        /// <summary>FIXME: Property SpEntityIdPosition is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public int? SpEntityIdPosition { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Position; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Position = value; }

        /// <summary>FIXME: Property SpEntityIdReadOnly is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SpEntityIdReadOnly { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).ReadOnly; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).ReadOnly = value; }

        /// <summary>FIXME: Property SpEntityIdRequired is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SpEntityIdRequired { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Required; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Required = value; }

        /// <summary>FIXME: Property SpEntityIdToggle is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdToggle { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Toggle; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Toggle = value; }

        /// <summary>FIXME: Property SpEntityIdTooltipTemplate is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdTooltipTemplate { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).TooltipTemplate; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).TooltipTemplate = value; }

        /// <summary>FIXME: Property SpEntityIdTooltipVariablesIcon is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdTooltipVariablesIcon { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).VariableIcon; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).VariableIcon = value; }

        /// <summary>FIXME: Property SpEntityIdTooltipVariablesMessage is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdTooltipVariablesMessage { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).VariableMessage; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).VariableMessage = value; }

        /// <summary>FIXME: Property SpEntityIdType is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdType { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Type; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Type = value; }

        /// <summary>FIXME: Property SpEntityIdValue is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public string SpEntityIdValue { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Value; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Value = value; }

        /// <summary>FIXME: Property SpEntityIdVisible is MISSING DESCRIPTION</summary>
        [JumpCloud.SDK.V1.Origin(JumpCloud.SDK.V1.PropertyOrigin.Inlined)]
        public bool? SpEntityIdVisible { get => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Visible; set => ((JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdInternal)SpEntityId).Visible = value; }

        /// <summary>Creates an new <see cref="ApplicationtemplateConfig" /> instance.</summary>
        public ApplicationtemplateConfig()
        {

        }
    }
    public partial interface IApplicationtemplateConfig :
        JumpCloud.SDK.V1.Runtime.IJsonSerializable
    {
        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string AcUrlLabel { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string AcUrlOptions { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? AcUrlPosition { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AcUrlReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AcUrlRequired { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string AcUrlToggle { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string AcUrlType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string AcUrlValue { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AcUrlVisible { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string AcsUrlTooltipTemplate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string AcsUrlTooltipVariablesIcon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string AcsUrlTooltipVariablesMessage { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string ConstantAttributeLabel { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"mutable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ConstantAttributeMutable { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string ConstantAttributeOptions { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? ConstantAttributePosition { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ConstantAttributeReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ConstantAttributeRequired { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string ConstantAttributeToggle { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string ConstantAttributeType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem) })]
        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem[] ConstantAttributeValue { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ConstantAttributeVisible { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string ConstantAttributesTooltipTemplate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string ConstantAttributesTooltipVariablesIcon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ConstantAttributesTooltipVariablesMessage { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabaseAttributePosition { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateLabel { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateOptions { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? IdpCertificatePosition { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpCertificateReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpCertificateRequired { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateToggle { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateTooltipTemplate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateTooltipVariablesIcon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateTooltipVariablesMessage { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string IdpCertificateValue { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpCertificateVisible { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdLabel { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdOptions { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? IdpEntityIdPosition { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpEntityIdReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpEntityIdRequired { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdToggle { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdTooltipTemplate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdTooltipVariablesIcon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdTooltipVariablesMessage { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string IdpEntityIdValue { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpEntityIdVisible { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyLabel { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyOptions { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? IdpPrivateKeyPosition { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpPrivateKeyReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpPrivateKeyRequired { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyToggle { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyTooltipTemplate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyTooltipVariablesIcon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyTooltipVariablesMessage { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string IdpPrivateKeyValue { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IdpPrivateKeyVisible { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdLabel { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"options",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdOptions { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"position",
        PossibleTypes = new [] { typeof(int) })]
        int? SpEntityIdPosition { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"readOnly",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SpEntityIdReadOnly { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"required",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SpEntityIdRequired { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"toggle",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdToggle { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"template",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdTooltipTemplate { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"icon",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdTooltipVariablesIcon { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdTooltipVariablesMessage { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdType { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string SpEntityIdValue { get; set; }

        [JumpCloud.SDK.V1.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"visible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SpEntityIdVisible { get; set; }

    }
    internal partial interface IApplicationtemplateConfigInternal

    {
        string AcUrlLabel { get; set; }

        string AcUrlOptions { get; set; }

        int? AcUrlPosition { get; set; }

        bool? AcUrlReadOnly { get; set; }

        bool? AcUrlRequired { get; set; }

        string AcUrlToggle { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltip AcUrlTooltip { get; set; }

        string AcUrlType { get; set; }

        string AcUrlValue { get; set; }

        bool? AcUrlVisible { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrl AcsUrl { get; set; }

        string AcsUrlTooltipTemplate { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigAcsUrlTooltipVariables AcsUrlTooltipVariables { get; set; }

        string AcsUrlTooltipVariablesIcon { get; set; }

        string AcsUrlTooltipVariablesMessage { get; set; }

        string ConstantAttributeLabel { get; set; }

        bool? ConstantAttributeMutable { get; set; }

        string ConstantAttributeOptions { get; set; }

        int? ConstantAttributePosition { get; set; }

        bool? ConstantAttributeReadOnly { get; set; }

        bool? ConstantAttributeRequired { get; set; }

        string ConstantAttributeToggle { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltip ConstantAttributeTooltip { get; set; }

        string ConstantAttributeType { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesValueItem[] ConstantAttributeValue { get; set; }

        bool? ConstantAttributeVisible { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributes ConstantAttributes { get; set; }

        string ConstantAttributesTooltipTemplate { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigConstantAttributesTooltipVariables ConstantAttributesTooltipVariables { get; set; }

        string ConstantAttributesTooltipVariablesIcon { get; set; }

        string ConstantAttributesTooltipVariablesMessage { get; set; }

        int? DatabaseAttributePosition { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigDatabaseAttributes DatabaseAttributes { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificate IdpCertificate { get; set; }

        string IdpCertificateLabel { get; set; }

        string IdpCertificateOptions { get; set; }

        int? IdpCertificatePosition { get; set; }

        bool? IdpCertificateReadOnly { get; set; }

        bool? IdpCertificateRequired { get; set; }

        string IdpCertificateToggle { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateTooltip IdpCertificateTooltip { get; set; }

        string IdpCertificateTooltipTemplate { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpCertificateTooltipVariables IdpCertificateTooltipVariables { get; set; }

        string IdpCertificateTooltipVariablesIcon { get; set; }

        string IdpCertificateTooltipVariablesMessage { get; set; }

        string IdpCertificateType { get; set; }

        string IdpCertificateValue { get; set; }

        bool? IdpCertificateVisible { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityId IdpEntityId { get; set; }

        string IdpEntityIdLabel { get; set; }

        string IdpEntityIdOptions { get; set; }

        int? IdpEntityIdPosition { get; set; }

        bool? IdpEntityIdReadOnly { get; set; }

        bool? IdpEntityIdRequired { get; set; }

        string IdpEntityIdToggle { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdTooltip IdpEntityIdTooltip { get; set; }

        string IdpEntityIdTooltipTemplate { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpEntityIdTooltipVariables IdpEntityIdTooltipVariables { get; set; }

        string IdpEntityIdTooltipVariablesIcon { get; set; }

        string IdpEntityIdTooltipVariablesMessage { get; set; }

        string IdpEntityIdType { get; set; }

        string IdpEntityIdValue { get; set; }

        bool? IdpEntityIdVisible { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKey IdpPrivateKey { get; set; }

        string IdpPrivateKeyLabel { get; set; }

        string IdpPrivateKeyOptions { get; set; }

        int? IdpPrivateKeyPosition { get; set; }

        bool? IdpPrivateKeyReadOnly { get; set; }

        bool? IdpPrivateKeyRequired { get; set; }

        string IdpPrivateKeyToggle { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltip IdpPrivateKeyTooltip { get; set; }

        string IdpPrivateKeyTooltipTemplate { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigIdpPrivateKeyTooltipVariables IdpPrivateKeyTooltipVariables { get; set; }

        string IdpPrivateKeyTooltipVariablesIcon { get; set; }

        string IdpPrivateKeyTooltipVariablesMessage { get; set; }

        string IdpPrivateKeyType { get; set; }

        string IdpPrivateKeyValue { get; set; }

        bool? IdpPrivateKeyVisible { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityId SpEntityId { get; set; }

        string SpEntityIdLabel { get; set; }

        string SpEntityIdOptions { get; set; }

        int? SpEntityIdPosition { get; set; }

        bool? SpEntityIdReadOnly { get; set; }

        bool? SpEntityIdRequired { get; set; }

        string SpEntityIdToggle { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltip SpEntityIdTooltip { get; set; }

        string SpEntityIdTooltipTemplate { get; set; }

        JumpCloud.SDK.V1.Models.IApplicationtemplateConfigSpEntityIdTooltipVariables SpEntityIdTooltipVariables { get; set; }

        string SpEntityIdTooltipVariablesIcon { get; set; }

        string SpEntityIdTooltipVariablesMessage { get; set; }

        string SpEntityIdType { get; set; }

        string SpEntityIdValue { get; set; }

        bool? SpEntityIdVisible { get; set; }

    }
}