using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TpoContract
    {
        [DataMember(Name = "siteId")]
        public string SiteId { get; set; }

        [DataMember(Name = "registerDate")]
        public string RegisterDate { get; set; }

        [DataMember(Name = "submitDate")]
        public string SubmitDate { get; set; }

        [DataMember(Name = "underwriterReviewed")]
        public bool? UnderwriterReviewed { get; set; }

        [DataMember(Name = "feeReviewStatus")]
        public string FeeReviewStatus { get; set; }

        [DataMember(Name = "archived")]
        public bool? Archived { get; set; }

        [DataMember(Name = "importSource")]
        public string ImportSource { get; set; }

        [DataMember(Name = "documentsReadyDate")]
        public string DocumentsReadyDate { get; set; }

        [DataMember(Name = "feeReviewStatusDate")]
        public string FeeReviewStatusDate { get; set; }

        [DataMember(Name = "feeReviewComments")]
        public string FeeReviewComments { get; set; }

        [DataMember(Name = "leIssuedBy")]
        public string LeIssuedBy { get; set; }

        [DataMember(Name = "companyName")]
        public string CompanyName { get; set; }

        [DataMember(Name = "companyId")]
        public string CompanyId { get; set; }

        [DataMember(Name = "companyOrganizationId")]
        public string CompanyOrganizationId { get; set; }

        [DataMember(Name = "companyLegalName")]
        public string CompanyLegalName { get; set; }

        [DataMember(Name = "companyAddress")]
        public string CompanyAddress { get; set; }

        [DataMember(Name = "companyCity")]
        public string CompanyCity { get; set; }

        [DataMember(Name = "companyState")]
        public string CompanyState { get; set; }

        [DataMember(Name = "companyZip")]
        public string CompanyZip { get; set; }

        [DataMember(Name = "companyPhone")]
        public string CompanyPhone { get; set; }

        [DataMember(Name = "companyFax")]
        public string CompanyFax { get; set; }

        [DataMember(Name = "companyDbaName")]
        public string CompanyDbaName { get; set; }

        [DataMember(Name = "companyRating")]
        public string CompanyRating { get; set; }

        [DataMember(Name = "companyManagerName")]
        public string CompanyManagerName { get; set; }

        [DataMember(Name = "companyManagerEmail")]
        public string CompanyManagerEmail { get; set; }

        [DataMember(Name = "companyAeName")]
        public string CompanyAeName { get; set; }

        [DataMember(Name = "companyAeUserName")]
        public string CompanyAeUserName { get; set; }

        [DataMember(Name = "branchName")]
        public string BranchName { get; set; }

        [DataMember(Name = "branchId")]
        public string BranchId { get; set; }

        [DataMember(Name = "branchOrganizationId")]
        public string BranchOrganizationId { get; set; }

        [DataMember(Name = "branchLegalName")]
        public string BranchLegalName { get; set; }

        [DataMember(Name = "branchAddress")]
        public string BranchAddress { get; set; }

        [DataMember(Name = "branchCity")]
        public string BranchCity { get; set; }

        [DataMember(Name = "branchState")]
        public string BranchState { get; set; }

        [DataMember(Name = "branchZip")]
        public string BranchZip { get; set; }

        [DataMember(Name = "branchPhone")]
        public string BranchPhone { get; set; }

        [DataMember(Name = "branchFax")]
        public string BranchFax { get; set; }

        [DataMember(Name = "branchDbaName")]
        public string BranchDbaName { get; set; }

        [DataMember(Name = "branchRating")]
        public string BranchRating { get; set; }

        [DataMember(Name = "branchManagerName")]
        public string BranchManagerName { get; set; }

        [DataMember(Name = "branchManagerEmail")]
        public string BranchManagerEmail { get; set; }

        [DataMember(Name = "branchAeName")]
        public string BranchAeName { get; set; }

        [DataMember(Name = "branchAeUserName")]
        public string BranchAeUserName { get; set; }

        [DataMember(Name = "loName")]
        public string LoName { get; set; }

        [DataMember(Name = "loId")]
        public string LoId { get; set; }

        [DataMember(Name = "loEmail")]
        public string LoEmail { get; set; }

        [DataMember(Name = "loStatus")]
        public string LoStatus { get; set; }

        [DataMember(Name = "loBusinessPhone")]
        public string LoBusinessPhone { get; set; }

        [DataMember(Name = "loBusinessFax")]
        public string LoBusinessFax { get; set; }

        [DataMember(Name = "loCellPhone")]
        public string LoCellPhone { get; set; }

        [DataMember(Name = "loAddress")]
        public string LoAddress { get; set; }

        [DataMember(Name = "loCity")]
        public string LoCity { get; set; }

        [DataMember(Name = "loState")]
        public string LoState { get; set; }

        [DataMember(Name = "loZip")]
        public string LoZip { get; set; }

        [DataMember(Name = "loNotes")]
        public string LoNotes { get; set; }

        [DataMember(Name = "loAeName")]
        public string LoAeName { get; set; }

        [DataMember(Name = "loAeUserName")]
        public string LoAeUserName { get; set; }

        [DataMember(Name = "loanEstimateRequestedDate")]
        public string LoanEstimateRequestedDate { get; set; }

        [DataMember(Name = "lpName")]
        public string LpName { get; set; }

        [DataMember(Name = "lpId")]
        public string LpId { get; set; }

        [DataMember(Name = "lpEmail")]
        public string LpEmail { get; set; }

        [DataMember(Name = "lpStatus")]
        public string LpStatus { get; set; }

        [DataMember(Name = "lpBusinessPhone")]
        public string LpBusinessPhone { get; set; }

        [DataMember(Name = "lpBusinessFax")]
        public string LpBusinessFax { get; set; }

        [DataMember(Name = "lpCellPhone")]
        public string LpCellPhone { get; set; }

        [DataMember(Name = "lpAddress")]
        public string LpAddress { get; set; }

        [DataMember(Name = "lpCity")]
        public string LpCity { get; set; }

        [DataMember(Name = "lpState")]
        public string LpState { get; set; }

        [DataMember(Name = "lpZip")]
        public string LpZip { get; set; }

        [DataMember(Name = "lpNotes")]
        public string LpNotes { get; set; }

        [DataMember(Name = "lpAeName")]
        public string LpAeName { get; set; }

        [DataMember(Name = "lpAeUserName")]
        public string LpAeUserName { get; set; }

        [DataMember(Name = "watchListFlag")]
        public bool? WatchListFlag { get; set; }

        [DataMember(Name = "watchListReason")]
        public string WatchListReason { get; set; }

        [DataMember(Name = "underwritingDelegated")]
        public bool? UnderwritingDelegated { get; set; }

        [DataMember(Name = "wholesaleWithdrawalDate")]
        public string WholesaleWithdrawalDate { get; set; }

        [DataMember(Name = "initialApplicationDate")]
        public string InitialApplicationDate { get; set; }

        [DataMember(Name = "initialSubmitDate")]
        public string InitialSubmitDate { get; set; }

        [DataMember(Name = "testAccountField")]
        public bool? TestAccountField { get; set; }

        [DataMember(Name = "readytoDiscloseDate")]
        public string ReadytoDiscloseDate { get; set; }

        [DataMember(Name = "purchaseStepsReviewed")]
        public bool? PurchaseStepsReviewed { get; set; }

        [DataMember(Name = "purchaseStepsReadyDate")]
        public string PurchaseStepsReadyDate { get; set; }

        [DataMember(Name = "cfcName")]
        public string CfcName { get; set; }

        [DataMember(Name = "cfcUserId")]
        public string CfcUserId { get; set; }

        [DataMember(Name = "cfcEmail")]
        public string CfcEmail { get; set; }

        [DataMember(Name = "cfcStatus")]
        public string CfcStatus { get; set; }

        [DataMember(Name = "cfcBusinessPhone")]
        public string CfcBusinessPhone { get; set; }

        [DataMember(Name = "cfcBusinessFax")]
        public string CfcBusinessFax { get; set; }

        [DataMember(Name = "cfcCellPhone")]
        public string CfcCellPhone { get; set; }

        [DataMember(Name = "cfcAddress")]
        public string CfcAddress { get; set; }

        [DataMember(Name = "cfcCity")]
        public string CfcCity { get; set; }

        [DataMember(Name = "cfcState")]
        public string CfcState { get; set; }

        [DataMember(Name = "cfcZip")]
        public string CfcZip { get; set; }

        [DataMember(Name = "cfcNotes")]
        public string CfcNotes { get; set; }

        [DataMember(Name = "cfcRepAe")]
        public string CfcRepAe { get; set; }

        [DataMember(Name = "cfcSrAeUserName")]
        public string CfcSrAeUserName { get; set; }

        [DataMember(Name = "importSourceLastUpdatedDate")]
        public string ImportSourceLastUpdatedDate { get; set; }

        [DataMember(Name = "completeLoanPackageSubmissionDate")]
        public string CompleteLoanPackageSubmissionDate { get; set; }

        [DataMember(Name = "eligibilityPackageSubmissionDate")]
        public string EligibilityPackageSubmissionDate { get; set; }

        [DataMember(Name = "titleFeesRequestedDate")]
        public string TitleFeesRequestedDate { get; set; }

        [DataMember(Name = "leOrDisclosuresGeneratedDate")]
        public string LeOrDisclosuresGeneratedDate { get; set; }

        [DataMember(Name = "appraisalOrderedDate")]
        public string AppraisalOrderedDate { get; set; }

        [DataMember(Name = "ausOrderedDate")]
        public string AusOrderedDate { get; set; }

        [DataMember(Name = "preferredAus")]
        public string PreferredAus { get; set; }

        [DataMember(Name = "loanEstimateRequestComments")]
        public string LoanEstimateRequestComments { get; set; }

    }
}
