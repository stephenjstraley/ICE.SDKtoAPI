using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ExternalOrganizationContract
    {
        [DataMember(Name = "basicInfo")]
        public ExternalOrgBasicInfoContract BasicInfo { get; set; }

        [DataMember(Name = "dba")]
        public ExternalOrgDbaContract Dba { get; set; }

        [DataMember(Name = "license")]
        public ExternalOrgLicenseContract License { get; set; }

        [DataMember(Name = "loanCriteria")]
        public ExternalOrgLoanCriteriaContract LoanCriteria { get; set; }

        [DataMember(Name = "tpoContacts")]
        public List<ExternalOrgTPOContactContract> TpoContacts { get; set; }

        [DataMember(Name = "salesRepAe")]
        public ExternalOrgSalesRepAEContract SalesRepAe { get; set; }

        [DataMember(Name = "lenderContacts")]
        public List<ExternalOrgLenderContactContract> LenderContacts { get; set; }

        [DataMember(Name = "warehouse")]
        public ExternalOrgWarehouseContract Warehouse { get; set; }

        [DataMember(Name = "fees")]
        public ExternalOrgFeesContract Fees { get; set; }

        [DataMember(Name = "loComp")]
        public ExternalOrgLoCompContract LoComp { get; set; }

        [DataMember(Name = "commitments")]
        public ExternalOrgCommitmentsContract Commitments { get; set; }

        [DataMember(Name = "tradeManagement")]
        public ExternalOrgTradeMgmtContract TradeManagement { get; set; }

        [DataMember(Name = "onrp")]
        public ExternalOrgOnrpContract Onrp { get; set; }

        [DataMember(Name = "notes")]
        public List<ExternalOrgNoteContract> Notes { get; set; }

        [DataMember(Name = "tpocSetup")]
        public ExternalOrgTpoSiteContract TpocSetup { get; set; }

        [DataMember(Name = "tpoDocs")]
        public ExternalOrgTpoDocsContract TpoDocs { get; set; }

        [DataMember(Name = "attachments")]
        public List<ExternalOrgAttachmentContract> Attachments { get; set; }

        [DataMember(Name = "customFields")]
        public ExternalOrgCustomFieldContract CustomFields { get; set; }
    }

    [DataContract]
    public class ExternalOrgBasicInfoContract
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "asd")]
        public bool? IsLoginDisabled { get; set; }

        [DataMember(Name = "isMfaEnabled")]
        public bool? IsMfaEnabled { get; set; }

        [DataMember(Name = "brokerSelection")]
        public string BrokerSelection { get; set; }

        [DataMember(Name = "parentOrg")]
        public EntityReferenceContract ParentOrg { get; set; }

        [DataMember(Name = "numberOfChildOrganizations")]
        public int? NumberOfChildOrganizations { get; set; }

        [DataMember(Name = "numberOfUsers")]
        public int? NumberOfUsers { get; set; }

        [DataMember(Name = "visibleOnTpoWcSite")]
        public bool? VisibleOnTpoWcSite { get; set; }

        [DataMember(Name = "hierarchyPath")]
        public string HierarchyPath { get; set; }

        [DataMember(Name = "childOrganizations")]
        public List<ExternalOrganizationContract> ChildOrganizations { get; set; }

        [DataMember(Name = "organizationName")]
        public string OrganizationName { get; set; }

        [DataMember(Name = "useParentInfoForCompanyDetails")]
        public bool? UseParentInfoForCompanyDetails { get; set; }

        [DataMember(Name = "organizationType")]
        public string OrganizationType { get; set; }

        [DataMember(Name = "channelTypes")]
        public List<string> ChannelTypes { get; set; }

        [DataMember(Name = "correspondentSelection")]
        public List<string> CorrespondentSelection { get; set; }

        [DataMember(Name = "timeZone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "noAfterHourWires")]
        public bool? NoAfterHourWires { get; set; }

        [DataMember(Name = "canAcceptFirstPayments")]
        public bool? CanAcceptFirstPayments { get; set; }

        [DataMember(Name = "tpoId")]
        public string TpoId { get; set; }

        [DataMember(Name = "orgId")]
        public string OrgId { get; set; }

        [DataMember(Name = "companyOwnerName")]
        public string CompanyOwnerName { get; set; }

        [DataMember(Name = "companyLegalName")]
        public string CompanyLegalName { get; set; }

        [DataMember(Name = "address")]
        public CompanyAddressContract Address { get; set; }

        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "faxNumber")]
        public string FaxNumber { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "website")]
        public string Website { get; set; }

        [DataMember(Name = "tpoManager")]
        public string TpoManager { get; set; }

        [DataMember(Name = "lastLoanSubmittedDate")]
        public string LastLoanSubmittedDate { get; set; }

        [DataMember(Name = "rateLockInfoContract")]
        public RateSheetAndLockInfoContract RateLockInfoContract { get; set; }

        [DataMember(Name = "productAndPricing")]
        public ProductAndPricingContract ProductAndPricing { get; set; }

        [DataMember(Name = "approvalStatus")]
        public ApprovalStatusContract ApprovalStatus { get; set; }

        [DataMember(Name = "businessInformation")]
        public BusinessInformationContract BusinessInformation { get; set; }

        [DataMember(Name = "primarySalesRepAe")]
        public PrimarySaleRepAeContract PrimarySalesRepAe { get; set; }
    }

    [DataContract]
    public class CompanyAddressContract
    {
        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "street1")]
        public string Street1 { get; set; }

        [DataMember(Name = "street2")]
        public string Street2 { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }
    }
    

    [DataContract]
    public class ExternalOrgDbaContract
    {
        [DataMember(Name = "useParentInfo")]
        public bool? UseParentInfo { get; set; }

        [DataMember(Name = "dbaDetails")]
        public EnternalOrgDbaDetailsContract DbaDetails { get; set; }
    }

    [DataContract]
    public class EnternalOrgDbaDetailsContract
    {
        [DataMember(Name = "externalOrgId")]
        public int ExternalOrgId { get; set; }

        [DataMember(Name = "dbaId")]
        public int DbaId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "isDefault")]
        public bool? IsDefault { get; set; }

        [DataMember(Name = "sortIndex")]
        public int SortIndex { get; set; }
    }

    [DataContract]
    public class ExternalOrgLicenseContract
    {
        [DataMember(Name = "useParentInfo")]
        public bool? UseParentInfo { get; set; }

        [DataMember(Name = "lenderType")]
        public string LenderType { get; set; }

        [DataMember(Name = "homeState")]
        public string HomeState { get; set; }

        [DataMember(Name = "dontApplyIntRateExportation")]
        public bool? DontApplyIntRateExportation { get; set; }

        [DataMember(Name = "loanPolicyForUnlicesedStates")]
        public string LoanPolicyForUnlicesedStates { get; set; }

        [DataMember(Name = "warningMessage")]
        public string WarningMessage { get; set; }

        [DataMember(Name = "statutoryElectionInMaryland")]
        public string StatutoryElectionInMaryland { get; set; }

        [DataMember(Name = "statutoryElectionInKansas")]
        public string StatutoryElectionInKansas { get; set; }

        [DataMember(Name = "atrSmallCreditor")]
        public string AtrSmallCreditor { get; set; }

        [DataMember(Name = "atrExemptCreditor")]
        public string AtrExemptCreditor { get; set; }

        [DataMember(Name = "stateLicenseTypes")]
        public StateLicenseTypeContract StateLicenseTypes { get; set; }
    }

    [DataContract]
    public class ExternalOrgLoanCriteriaContract
    {
        [DataMember(Name = "useParentInfo")]
        public bool? UseParentInfo { get; set; }

        [DataMember(Name = "fhaId")]
        public string FhaId { get; set; }

        [DataMember(Name = "fhaSponsorId")]
        public string FhaSponsorId { get; set; }

        [DataMember(Name = "fhaStatus")]
        public string FhaStatus { get; set; }

        [DataMember(Name = "fhaCompareRatio")]
        public int? FhaCompareRatio { get; set; }

        [DataMember(Name = "fhaApprovedDate")]
        public string FhaApprovedDate { get; set; }

        [DataMember(Name = "fhaExpirationDate")]
        public string FhaExpirationDate { get; set; }

        [DataMember(Name = "fhaDirectEndorsement")]
        public string FhaDirectEndorsement { get; set; }

        [DataMember(Name = "vaId")]
        public string VaId { get; set; }

        [DataMember(Name = "vaSponsorId")]
        public string VaSponsorId { get; set; }

        [DataMember(Name = "vaStatus")]
        public string VaStatus { get; set; }

        [DataMember(Name = "vaApprovedDate")]
        public string VaApprovedDate { get; set; }

        [DataMember(Name = "vaExpirationDate")]
        public string VaExpirationDate { get; set; }

        [DataMember(Name = "fnmaApproved")]
        public bool? FnmaApproved { get; set; }

        [DataMember(Name = "fannieMaeId")]
        public string FannieMaeId { get; set; }

        [DataMember(Name = "fhmlcApproved")]
        public bool? FhmlcApproved { get; set; }

        [DataMember(Name = "freddieMacId")]
        public string FreddieMacId { get; set; }

        [DataMember(Name = "ausMethod")]
        public string AusMethod { get; set; }

        [DataMember(Name = "broker")]
        public ExternalOrgChannelType Broker { get; set; }

        [DataMember(Name = "correspondent")]
        public CorrespondentCriteriaContract Correspondent { get; set; }
    }

    [DataContract]
    public class ExternalOrgChannelType
    {
        [DataMember(Name = "loanTypes")]
        public string LoanTypes { get; set; }

        [DataMember(Name = "loanPurposes")]
        public string LoanPurposes { get; set; }

        [DataMember(Name = "loanPolicyForUnlicesedStates")]
        public string LoanPolicyForUnlicesedStates { get; set; }

        [DataMember(Name = "warningMessage")]
        public string WarningMessage { get; set; }
    }

    [DataContract]
    public class CorrespondentCriteriaContract
    {
        [DataMember(Name = "underwriting")]
        public string Underwriting { get; set; }

        [DataMember(Name = "correspondentDelegated")]
        public ExternalOrgChannelType CorrespondentDelegated { get; set; }

        [DataMember(Name = "correspondentNonDelegated")]
        public ExternalOrgChannelType CorrespondentNonDelegated { get; set; }

        [DataMember(Name = "advancedCode")]
        public string AdvancedCode { get; set; }
    }

    [DataContract]
    public class ExternalOrgTPOContactContract
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }
    }

    [DataContract]
    public class ExternalOrgSalesRepAEContract
    {
        [DataMember(Name = "salesRepId")]
        public int SalesRepId { get; set; }

        [DataMember(Name = "userId")]
        public string UserId { get; set; }

        [DataMember(Name = "isPrimarySalesRep")]
        public bool? IsPrimarySalesRep { get; set; }

        [DataMember(Name = "isWholesaleChannelEnabled")]
        public bool? IsWholesaleChannelEnabled { get; set; }

        [DataMember(Name = "isDelegatedChannelEnabled")]
        public bool? IsDelegatedChannelEnabled { get; set; }

        [DataMember(Name = "isNonDelegatedChannelEnabled")]
        public bool? IsNonDelegatedChannelEnabled { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "persona")]
        public LenderApiContractsV1.PersonaContract Persona { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "orgAssignment")]
        public string OrgAssignment { get; set; }
    }

    [DataContract]
    public class ExternalOrgLenderContactContract
    {
        [DataMember(Name = "isWholesaleChannelEnabled")]
        public bool? IsWholesaleChannelEnabled { get; set; }

        [DataMember(Name = "isDelegatedChannelEnabled")]
        public bool? IsDelegatedChannelEnabled { get; set; }

        [DataMember(Name = "isNonDelegatedChannelEnabled")]
        public bool? IsNonDelegatedChannelEnabled { get; set; }

        [DataMember(Name = "isPrimarySalesRep")]
        public bool? IsPrimarySalesRep { get; set; }

        [DataMember(Name = "isHidden")]
        public bool? IsHidden { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "userId")]
        public string UserId { get; set; }

        [DataMember(Name = "name")]
        public string Mame { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }

    [DataContract]
    public class ExternalOrgWarehouseContract
    {
        [DataMember(Name = "useParentInfo")]
        public bool? UseParentInfo { get; set; }

        [DataMember(Name = "warehouseBankDetails")]
        public WarehouseBankDetailContract WarehouseBankDetails { get; set; }
    }

    [DataContract]
    public class WarehouseBankDetailContract
    {

        [DataMember(Name = "warehouseBankId")]
        public int WarehouseBankId { get; set; }

        [DataMember(Name = "bankName")]
        public string BankName { get; set; }

        [DataMember(Name = "address1")]
        public string Address1 { get; set; }

        [DataMember(Name = "address2")]
        public string Address2 { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataMember(Name = "abaNumber")]
        public string AbaNumber { get; set; }

        [DataMember(Name = "dateAdded")]
        public string DateAdded { get; set; }

        [DataMember(Name = "statusDate")]
        public string StatusDate { get; set; }

        [DataMember(Name = "isApproved")]
        public bool? IsApproved { get; set; }

        [DataMember(Name = "accountNumber")]
        public string AccountNumber { get; set; }

        [DataMember(Name = "accountName")]
        public string AccountName { get; set; }

        [DataMember(Name = "creditAccountNumber")]
        public string CreditAccountNumber { get; set; }

        [DataMember(Name = "creditAccountName")]
        public string CreditAccountName { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "baileeExpiration")]
        public string BaileeExpiration { get; set; }

        [DataMember(Name = "selfFunder")]
        public bool? SelfFunder { get; set; }

        [DataMember(Name = "baileeLetterReq")]
        public bool? BaileeLetterReq { get; set; }

        [DataMember(Name = "triParty")]
        public bool? TriParty { get; set; }

        [DataMember(Name = "useDefaultContact")]
        public bool? UseDefaultContact { get; set; }

        [DataMember(Name = "contactName")]
        public string ContactName { get; set; }

        [DataMember(Name = "contactEmail")]
        public string ContactEmail { get; set; }

        [DataMember(Name = "contactPhone")]
        public string ContactPhone { get; set; }

        [DataMember(Name = "contactFax")]
        public string ContactFax { get; set; }

        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        [DataMember(Name = "timeZone")]
        public string TimeZone { get; set; }
    }

    [DataContract]
    public class ExternalOrgFeesContract
    {
        [DataMember(Name = "lateFeeSettings")]
        public LateFeeSettingContract LateFeeSettings { get; set; }

        [DataMember(Name = "tpoFees")]
        public TpoFeeContract TpoFees { get; set; }
    }

    [DataContract]
    public class LateFeeSettingContract
    {
        [DataMember(Name = "globalTpoSettings")]
        public bool? GlobalTpoSettings { get; set; }

        [DataMember(Name = "lateFeeSettingId")]
        public int LateFeeSettingId { get; set; }

        [DataMember(Name = "gracePeriodDays")]
        public int? GracePeriodDays { get; set; }

        [DataMember(Name = "gracePeriodUses")]
        public string GracePeriodUses { get; set; }

        [DataMember(Name = "gracePeriodStarts")]
        public string GracePeriodStarts { get; set; }

        [DataMember(Name = "gracePeriodLaterOf")]
        public string GracePeriodLaterOf { get; set; }

        [DataMember(Name = "dayCleared")]
        public string DayCleared { get; set; }

        [DataMember(Name = "canStartOnWeekend")]
        public bool? CanStartOnWeekend { get; set; }

        [DataMember(Name = "includeDayAsLateDay")]
        public bool? IncludeDayAsLateDay { get; set; }

        [DataMember(Name = "feeHandledAs")]
        public string FeeHandledAs { get; set; }

        [DataMember(Name = "lateFeePercent")]
        public decimal? LateFeePercent { get; set; }

        [DataMember(Name = "lateFeeDollars")]
        public decimal? LateFeeDollars { get; set; }

        [DataMember(Name = "calculateAs")]
        public string CalculateAs { get; set; }

        [DataMember(Name = "maxLateDays")]
        public int? MaxLateDays { get; set; }

        [DataMember(Name = "dayClearedOtherDate")]
        public string DayClearedOtherDate { get; set; }

        [DataMember(Name = "gracePeriodLaterOfOtherDate")]
        public string GracePeriodLaterOfOtherDate { get; set; }
    }

    [DataContract]
    public class TpoFeeContract
    {
        [DataMember(Name = "feeId")]
        public int FeeId { get; set; }

        [DataMember(Name = "feeName")]
        public string FeeName { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "channel")]
        public string Channel { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "feePercent")]
        public decimal? FeePercent { get; set; }

        [DataMember(Name = "feeAmount")]
        public decimal? FeeAmount { get; set; }

        [DataMember(Name = "updatedBy")]
        public string UpdatedBy { get; set; }

        [DataMember(Name = "lastUpdated")]
        public string LastUpdated { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "externalOrgId")]
        public int? ExternalOrgId { get; set; }

        [DataMember(Name = "advancedCode")]
        public string AdvancedCode { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "feeCondition")]
        public string FeeCondition { get; set; }
    }

    [DataContract]
    public class ExternalOrgLoCompContract
    {
        [DataMember(Name = "useParentInfo")]
        public bool? UseParentInfo { get; set; }

        [DataMember(Name = "loCompHistory")]
        public LoCompHistoryDetailsContract LoCompHistory { get; set; }
    }

    [DataContract]
    public class LoCompHistoryDetailsContract
    {
        [DataMember(Name = "compPlanId")]
        public int? CompPlanId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "brokerValue")]
        public string BrokerValue { get; set; }

        [DataMember(Name = "triggerBasis")]
        public string TriggerBasis { get; set; }

        [DataMember(Name = "rounding")]
        public string Rounding { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "minTermDays")]
        public int? MinTermDays { get; set; }

        [DataMember(Name = "percentAmt")]
        public decimal? PercentAmt { get; set; }

        [DataMember(Name = "percentAmtIsOf")]
        public string PercentAmtIsOf { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "minAmount")]
        public decimal? MinAmount { get; set; }

        [DataMember(Name = "maxAmount")]
        public decimal? MaxAmount { get; set; }
    }

    [DataContract]
    public class ExternalOrgCommitmentsContract
    {
        [DataMember(Name = "bestEffort")]
        public bool? BestEffort { get; set; }

        [DataMember(Name = "limited")]
        public bool? Limited { get; set; }

        [DataMember(Name = "unlimited")]
        public bool? Unlimited { get; set; }

        [DataMember(Name = "maxCommitmentAuthority")]
        public decimal? MaxCommitmentAuthority { get; set; }

        [DataMember(Name = "bestEffortOutstandingCommitments")]
        public string BestEffortOutstandingCommitments { get; set; }

        [DataMember(Name = "bestEffortAvailableAmount")]
        public string BestEffortAvailableAmount { get; set; }

        [DataMember(Name = "bestEffortDailyVolumeLimit")]
        public decimal? BestEffortDailyVolumeLimit { get; set; }

        [DataMember(Name = "mandatory")]
        public bool? Mandatory { get; set; }

        [DataMember(Name = "maxCommitmentAmount")]
        public decimal? MaxCommitmentAmount { get; set; }

        [DataMember(Name = "mandatoryOutStandingCommitments")]
        public string MandatoryOutStandingCommitments { get; set; }

        [DataMember(Name = "mandatoryAvailableAmount")]
        public string MandatoryAvailableAmount { get; set; }

        [DataMember(Name = "commitmentsLoanPolicy")]
        public string CommitmentsLoanPolicy { get; set; }

        [DataMember(Name = "commitmentsTradePolicy")]
        public string CommitmentsTradePolicy { get; set; }

        [DataMember(Name = "bestEffortsDailyLimitPolicy")]
        public string BestEffortsDailyLimitPolicy { get; set; }

        [DataMember(Name = "dailyLimitWarningMessage")]
        public string DailyLimitWarningMessage { get; set; }

        [DataMember(Name = "commitmentWarningMessage")]
        public string CommitmentWarningMessage { get; set; }

        [DataMember(Name = "bestEffortToleranceControlOption")]
        public string BestEffortToleranceControlOption { get; set; }

        [DataMember(Name = "mandatoryToleranceControlOption")]
        public string MandatoryToleranceControlOption { get; set; }

        [DataMember(Name = "bestEffortTolerancePercent")]
        public decimal? BestEffortTolerancePercent { get; set; }

        [DataMember(Name = "bestEffortToleranceAmount")]
        public decimal? BestEffortToleranceAmount { get; set; }

        [DataMember(Name = "mandatoryTolerancePercent")]
        public decimal? MandatoryTolerancePercent { get; set; }

        [DataMember(Name = "mandatoryToleranceAmount")]
        public decimal? MandatoryToleranceAmount { get; set; }

        [DataMember(Name = "deliveryTypes")]
        public List<DeliveryTypeContract> dDliveryTypes { get; set; }
    }

    [DataContract]
    public class DeliveryTypeContract
    {
        [DataMember(Name = "deliveryType")]
        public string DeliveryType { get; set; }

        [DataMember(Name = "outStandingCommitments")]
        public string OutStandingCommitments { get; set; }

        [DataMember(Name = "percentageOfMax")]
        public string PercentageOfMax { get; set; }
    }

    [DataContract]
    public class ExternalOrgTradeMgmtContract
    {
        [DataMember(Name = "enableTradeManagement")]
        public bool? EnableTradeManagement { get; set; }

        [DataMember(Name = "useCompanyTradeManagementSettings")]
        public bool? UseCompanyTradeManagementSettings { get; set; }

        [DataMember(Name = "viewCorrespondentTrade")]
        public bool? ViewCorrespondentTrade { get; set; }

        [DataMember(Name = "viewCorrespondentMasterCommitment")]
        public bool? ViewCorrespondentMasterCommitment { get; set; }

        [DataMember(Name = "loanEligibilityToCorrespondentTrade")]
        public bool? LoanEligibilityToCorrespondentTrade { get; set; }

        [DataMember(Name = "eppsLoanProgramEligibilityPricing")]
        public bool? EppsLoanProgramEligibilityPricing { get; set; }

        [DataMember(Name = "loanAssignmentToCorrespondentTrade")]
        public bool? LoanAssignmentToCorrespondentTrade { get; set; }

        [DataMember(Name = "loanDeletionFromCorrespondentTrade")]
        public bool? LoanDeletionFromCorrespondentTrade { get; set; }
    }

    [DataContract]
    public class ExternalOrgOnrpContract
    {
        [DataMember(Name = "enableOnrpForTpo")]
        public bool? EnableOnrpForTpo { get; set; }

        [DataMember(Name = "useChannelDefaults")]
        public bool? UseChannelDefaults { get; set; }

        [DataMember(Name = "coverageSetting")]
        public string CoverageSetting { get; set; }

        [DataMember(Name = "weekendHolidayCoverage")]
        public bool? WeekendHolidayCoverage { get; set; }

        [DataMember(Name = "onrpWeekdayStartTime")]
        public string OnrpWeekdayStartTime { get; set; }

        [DataMember(Name = "onrpWeekDayEndTime")]
        public string OnrpWeekDayEndTime { get; set; }

        [DataMember(Name = "enableSatHours")]
        public bool? EnableSatHours { get; set; }

        [DataMember(Name = "onrpSatStartTime")]
        public string OnrpSatStartTime { get; set; }

        [DataMember(Name = "onrpSatEndTime")]
        public string OnrpSatEndTime { get; set; }

        [DataMember(Name = "enableSunHours")]
        public bool? EnableSunHours { get; set; }

        [DataMember(Name = "onrpSunStartTime")]
        public string OnrpSunStartTime { get; set; }

        [DataMember(Name = "onrpSunEndTime")]
        public string OnrpSunEndTime { get; set; }

        [DataMember(Name = "noMaximumLimit")]
        public bool? NoMaximumLimit { get; set; }

        [DataMember(Name = "dollarLimit")]
        public decimal? DollarLimit { get; set; }

        [DataMember(Name = "tolerancePercent")]
        public decimal? TolerancePercent { get; set; }
    }

    [DataContract]
    public class ExternalOrgNoteContract
    {
        [DataMember(Name = "noteId")]
        public int NoteId { get; set; }

        [DataMember(Name = "addedDate")]
        public string AddedDate { get; set; }

        [DataMember(Name = "addedBy")]
        public string AddedBy { get; set; }

        [DataMember(Name = "details")]
        public string Details { get; set; }
    }

    [DataContract]
    public class ExternalOrgTpoSiteContract
    {
        [DataMember(Name = "isTestAccount")]
        public bool? IsTestAccount { get; set; }

        [DataMember(Name = "tpoSiteDetails")]
        public ExternalOrgTpoSiteDetailsContract TpoSiteDetails { get; set; }
    }

    [DataContract]
    public class ExternalOrgTpoSiteDetailsContract
    {
        [DataMember(Name = "siteUrl")]
        public string SiteUrl { get; set; }

        [DataMember(Name = "channelTypes")]
        public string ChannelTypes { get; set; }

        [DataMember(Name = "siteId")]
        public string SiteId { get; set; }
    }

    [DataContract]
    public class ExternalOrgTpoDocsContract
    {
        [DataMember(Name = "tpoDocDetails")]
        public TPODocumentDetailsContract TpoDocDetails { get; set; }

        [DataMember(Name = "archivedDocs")]
        public List<ExternalOrgAttachmentContract> ArchivedDocs { get; set; }
    }

    [DataContract]
    public class TPODocumentDetailsContract
    {
        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "externalOrgId")]
        public int? ExternalOrgId { get; set; }

        [DataMember(Name = "addedBy")]
        public string AddedBy { get; set; }

        [DataMember(Name = "categoryName")]
        public string CategoryName { get; set; }

        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }

        [DataMember(Name = "channels")]
        List<object> Channels { get; set; }

        [DataMember(Name = "dateAdded")]
        public string DateAdded { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }
    }

    [DataContract]
    public class ExternalOrgAttachmentContract
    {
        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "externalOrgId")]
        public int? ExternalOrgId { get; set; }

        [DataMember(Name = "dateAdded")]
        public string DateAdded { get; set; }

        [DataMember(Name = "addedBy")]
        public string AddedBy { get; set; }

        [DataMember(Name = "attachmentName")]
        public string AttachmentName { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "fileDate")]
        public string FileDate { get; set; }

        [DataMember(Name = "categoryName")]
        public string CategoryName { get; set; }

        [DataMember(Name = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember(Name = "daysToExpire")]
        public int? DaysToExpire { get; set; }

        [DataMember(Name = "realFileName")]
        public string RealFileName { get; set; }
    }

    [DataContract]
    public class ExternalOrgCustomFieldContract
    {
        [DataMember(Name = "useParentInfo")]
        public bool? UseParentInfo { get; set; }

        [DataMember(Name = "fields")]
        public List<CustomFieldsContract> Fields { get; set;}
    }

    [DataContract]
    public class RateSheetAndLockInfoContract
    {
        [DataMember(Name = "useParentInfoForRateLock")]
        public bool? UseParentInfoForRateLock { get; set; }

        [DataMember(Name = "rateSheetEmail")]
        public string RateSheetEmail { get; set; }

        [DataMember(Name = "rateSheetFax")]
        public string RateSheetFax { get; set; }

        [DataMember(Name = "lockInfoEmail")]
        public string LockInfoEmail { get; set; }

        [DataMember(Name = "lockInfoFax")]
        public string LockInfoFax { get; set; }
    }

    [DataContract]
    public class ProductAndPricingContract
    {
        [DataMember(Name = "useParentInfoForEpps")]
        public bool? UseParentInfoForEpps { get; set; }

        [DataMember(Name = "priceGroups")]
        public List<object> PriceGroups { get; set; }

        [DataMember(Name = "eppsUserName")]
        public string EppsUserName { get; set; }

        [DataMember(Name = "eppsCompModel")]
        public string EppsCompModel { get; set; }
    }
    
    [DataContract]
    public class ApprovalStatusContract
    {
        [DataMember(Name = "useParentInfoApprovalStatus")]
        public bool? UseParentInfoApprovalStatus { get; set; }

        [DataMember(Name = "currentStatus")]
        public string CurrentStatus { get; set; }

        [DataMember(Name = "addToWatchlist")]
        public bool? AddToWatchlist { get; set; }

        [DataMember(Name = "currentStatusDate")]
        public string CurrentStatusDate { get; set; }

        [DataMember(Name = "approvedDate")]
        public string ApprovedDate { get; set; }

        [DataMember(Name = "applicationDate")]
        public string ApplicationDate { get; set; }

        [DataMember(Name = "companyRating")]
        public string CompanyRating { get; set; }
    }

    [DataContract]
    public class BusinessInformationContract
    {
        [DataMember(Name = "useParentInfoForBusinessInfo")]
        public bool? UseParentInfoForBusinessInfo { get; set; }

        [DataMember(Name = "isIncorporated")]
        public bool? IsIncorporated { get; set; }

        [DataMember(Name = "stateOfIncorporation")]
        public string StateOfIncorporation { get; set; }

        [DataMember(Name = "dateOfIncorporation")]
        public string DateOfIncorporation { get; set; }

        [DataMember(Name = "typeOfEntity")]
        public string TypeOfEntity { get; set; }

        [DataMember(Name = "otherEntityDescription")]
        public string OtherEntityDescription { get; set; }

        [DataMember(Name = "taxId")]
        public string TaxId { get; set; }

        [DataMember(Name = "useSsnFormat")]
        public bool? UseSsnFormat { get; set; }

        [DataMember(Name = "lei")]
        public string Lei { get; set; }

        [DataMember(Name = "nmlsId")]
        public string NmlsId { get; set; }

        [DataMember(Name = "financialsPeriod")]
        public string FinancialsPeriod { get; set; }

        [DataMember(Name = "financialsLastUpdate")]
        public string FinancialsLastUpdate { get; set; }

        [DataMember(Name = "companyNetWorth")]
        public decimal? CompanyNetWorth { get; set; }

        [DataMember(Name = "eoCompany")]
        public string EoCompany { get; set; }

        [DataMember(Name = "eoExpirationDate")]
        public string EoExpirationDate { get; set; }

        [DataMember(Name = "eoPolicyNumber")]
        public string EoPolicyNumber { get; set; }

        [DataMember(Name = "mersOriginatingOrgId")]
        public string MersOriginatingOrgId { get; set; }

        [DataMember(Name = "isDuSponsored")]
        public bool? IsDuSponsored { get; set; }

        [DataMember(Name = "isLpaSponsored")]
        public bool? IsLpaSponsored { get; set; }

        [DataMember(Name = "lpaSponsoredDetails")]
        public LpaSponsoredDetailsContract LpaSponsoredDetails { get; set; }

        [DataMember(Name = "canFundInOwnName")]
        public bool? CanFundInOwnName { get; set; }

        [DataMember(Name = "canCloseInOwnName")]
        public bool? CanCloseInOwnName { get; set; }
    }

    [DataContract]
    public class LpaSponsoredDetailsContract
    {
        [DataMember(Name = "lpaTpoNumber")]
        public string LpaTpoNumber { get; set; }

        [DataMember(Name = "tpoLpaPassword")]
        public string TpoLpaPassword { get; set; }
    }

    [DataContract]
    public class PrimarySaleRepAeContract
    {
        [DataMember(Name = "userId")]
        public string UserId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "persona")]
        public LenderApiContractsV1.PersonaContract Persona { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "assignedDate")]
        public string AssignedDate { get; set; }
    }

}
