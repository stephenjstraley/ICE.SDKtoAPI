using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTPO
	{
		[DataMember(Name="archived")]
		public bool? Archived { get; set; }

		[DataMember(Name="branchAddress")]
		public string BranchAddress { get; set; }

		[DataMember(Name="branchAEName")]
		public string BranchAEName { get; set; }

		[DataMember(Name="branchAEUserName")]
		public string BranchAEUserName { get; set; }

		[DataMember(Name="branchCity")]
		public string BranchCity { get; set; }

		[DataMember(Name="branchDBAName")]
		public string BranchDBAName { get; set; }

		[DataMember(Name="branchFax")]
		public string BranchFax { get; set; }

		[DataMember(Name="branchID")]
		public string BranchID { get; set; }

		[DataMember(Name="branchLegalName")]
		public string BranchLegalName { get; set; }

		[DataMember(Name="branchManagerEmail")]
		public string BranchManagerEmail { get; set; }

		[DataMember(Name="branchManagerName")]
		public string BranchManagerName { get; set; }

		[DataMember(Name="branchName")]
		public string BranchName { get; set; }

		[DataMember(Name="branchOrganizationID")]
		public string BranchOrganizationID { get; set; }

		[DataMember(Name="branchPhone")]
		public string BranchPhone { get; set; }

		[DataMember(Name="branchRating")]
		public string BranchRating { get; set; }

		[DataMember(Name="branchState")]
		public string BranchState { get; set; }

		[DataMember(Name="branchZip")]
		public string BranchZip { get; set; }

		[DataMember(Name="cFCAddress")]
		public string CFCAddress { get; set; }

		[DataMember(Name="cFCBusinessFax")]
		public string CFCBusinessFax { get; set; }

		[DataMember(Name="cFCBusinessPhone")]
		public string CFCBusinessPhone { get; set; }

		[DataMember(Name="cFCCellPhone")]
		public string CFCCellPhone { get; set; }

		[DataMember(Name="cFCCity")]
		public string CFCCity { get; set; }

		[DataMember(Name="cFCEmail")]
		public string CFCEmail { get; set; }

		[DataMember(Name="cFCName")]
		public string CFCName { get; set; }

		[DataMember(Name="cFCNotes")]
		public string CFCNotes { get; set; }

		[DataMember(Name="cFCRepAE")]
		public string CFCRepAE { get; set; }

		[DataMember(Name="cFCSRAEUserName")]
		public string CFCSRAEUserName { get; set; }

		[DataMember(Name="cFCState")]
		public string CFCState { get; set; }

		[DataMember(Name="cFCStatus")]
		public string CFCStatus { get; set; }

		[DataMember(Name="cFCUserID")]
		public string CFCUserID { get; set; }

		[DataMember(Name="cFCZip")]
		public string CFCZip { get; set; }

		[DataMember(Name="companyAddress")]
		public string CompanyAddress { get; set; }

		[DataMember(Name="companyAEName")]
		public string CompanyAEName { get; set; }

		[DataMember(Name="companyAEUserName")]
		public string CompanyAEUserName { get; set; }

		[DataMember(Name="companyCity")]
		public string CompanyCity { get; set; }

		[DataMember(Name="companyDBAName")]
		public string CompanyDBAName { get; set; }

		[DataMember(Name="companyFax")]
		public string CompanyFax { get; set; }

		[DataMember(Name="companyID")]
		public string CompanyID { get; set; }

		[DataMember(Name="companyLegalName")]
		public string CompanyLegalName { get; set; }

		[DataMember(Name="companyManagerEmail")]
		public string CompanyManagerEmail { get; set; }

		[DataMember(Name="companyManagerName")]
		public string CompanyManagerName { get; set; }

		[DataMember(Name="companyName")]
		public string CompanyName { get; set; }

		[DataMember(Name="companyOrganizationID")]
		public string CompanyOrganizationID { get; set; }

		[DataMember(Name="companyPhone")]
		public string CompanyPhone { get; set; }

		[DataMember(Name="companyRating")]
		public string CompanyRating { get; set; }

		[DataMember(Name="companyState")]
		public string CompanyState { get; set; }

		[DataMember(Name="companyZip")]
		public string CompanyZip { get; set; }

		[DataMember(Name="documentsReadyDate")]
		public DateTime? DocumentsReadyDate { get; set; }

		[DataMember(Name="feeReviewComments")]
		public string FeeReviewComments { get; set; }

		[DataMember(Name="feeReviewStatus")]
		public string FeeReviewStatus { get; set; }

		[DataMember(Name="feeReviewStatusDate")]
		public DateTime? FeeReviewStatusDate { get; set; }

		[DataMember(Name="importSource")]
		public string ImportSource { get; set; }

		[DataMember(Name="initialApplicationDate")]
		public DateTime? InitialApplicationDate { get; set; }

		[DataMember(Name="initialSubmitDate")]
		public DateTime? InitialSubmitDate { get; set; }

		[DataMember(Name="lEIssuedBy")]
		public string LEIssuedBy { get; set; }

		[DataMember(Name="lOAddress")]
		public string LOAddress { get; set; }

		[DataMember(Name="lOAEName")]
		public string LOAEName { get; set; }

		[DataMember(Name="lOAEUserName")]
		public string LOAEUserName { get; set; }

		[DataMember(Name="lOBusinessFax")]
		public string LOBusinessFax { get; set; }

		[DataMember(Name="lOBusinessPhone")]
		public string LOBusinessPhone { get; set; }

		[DataMember(Name="lOCellPhone")]
		public string LOCellPhone { get; set; }

		[DataMember(Name="lOCity")]
		public string LOCity { get; set; }

		[DataMember(Name="lOEmail")]
		public string LOEmail { get; set; }

		[DataMember(Name="lOID")]
		public string LOID { get; set; }

		[DataMember(Name="lOName")]
		public string LOName { get; set; }

		[DataMember(Name="lONotes")]
		public string LONotes { get; set; }

		[DataMember(Name="lOState")]
		public string LOState { get; set; }

		[DataMember(Name="lOStatus")]
		public string LOStatus { get; set; }

		[DataMember(Name="lOZip")]
		public string LOZip { get; set; }

		[DataMember(Name="lPAddress")]
		public string LPAddress { get; set; }

		[DataMember(Name="lPAEName")]
		public string LPAEName { get; set; }

		[DataMember(Name="lPAEUserName")]
		public string LPAEUserName { get; set; }

		[DataMember(Name="lPBusinessFax")]
		public string LPBusinessFax { get; set; }

		[DataMember(Name="lPBusinessPhone")]
		public string LPBusinessPhone { get; set; }

		[DataMember(Name="lPCellPhone")]
		public string LPCellPhone { get; set; }

		[DataMember(Name="lPCity")]
		public string LPCity { get; set; }

		[DataMember(Name="lPEmail")]
		public string LPEmail { get; set; }

		[DataMember(Name="lPID")]
		public string LPID { get; set; }

		[DataMember(Name="lPName")]
		public string LPName { get; set; }

		[DataMember(Name="lPNotes")]
		public string LPNotes { get; set; }

		[DataMember(Name="lPState")]
		public string LPState { get; set; }

		[DataMember(Name="lPStatus")]
		public string LPStatus { get; set; }

		[DataMember(Name="lPZip")]
		public string LPZip { get; set; }

		[DataMember(Name="purchaseStipsReadyDate")]
		public DateTime? PurchaseStipsReadyDate { get; set; }

		[DataMember(Name="purchaseStipsReviewed")]
		public bool? PurchaseStipsReviewed { get; set; }

		[DataMember(Name="readytoDiscloseDateUtc")]
		public DateTime? ReadytoDiscloseDateUtc { get; set; }

		[DataMember(Name="registerDate")]
		public DateTime? RegisterDate { get; set; }

		[DataMember(Name="sITEID")]
		public string SITEID { get; set; }

		[DataMember(Name="submitDate")]
		public DateTime? SubmitDate { get; set; }

		[DataMember(Name="testAccountField")]
		public bool? TestAccountField { get; set; }

		[DataMember(Name="underwriterReviewed")]
		public bool? UnderwriterReviewed { get; set; }

		[DataMember(Name="underwritingDelegated")]
		public bool? UnderwritingDelegated { get; set; }

		[DataMember(Name="watchListFlag")]
		public bool? WatchListFlag { get; set; }

		[DataMember(Name="watchListReason")]
		public string WatchListReason { get; set; }

	}
}