using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTPO
	{
		[DataMember(Name="archived", EmitDefaultValue=false)]
		public bool? Archived { get; set; }

		[DataMember(Name="branchAddress", EmitDefaultValue=false)]
		public string BranchAddress { get; set; }

		[DataMember(Name="branchAEName", EmitDefaultValue=false)]
		public string BranchAEName { get; set; }

		[DataMember(Name="branchAEUserName", EmitDefaultValue=false)]
		public string BranchAEUserName { get; set; }

		[DataMember(Name="branchCity", EmitDefaultValue=false)]
		public string BranchCity { get; set; }

		[DataMember(Name="branchDBAName", EmitDefaultValue=false)]
		public string BranchDBAName { get; set; }

		[DataMember(Name="branchFax", EmitDefaultValue=false)]
		public string BranchFax { get; set; }

		[DataMember(Name="branchID", EmitDefaultValue=false)]
		public string BranchID { get; set; }

		[DataMember(Name="branchLegalName", EmitDefaultValue=false)]
		public string BranchLegalName { get; set; }

		[DataMember(Name="branchManagerEmail", EmitDefaultValue=false)]
		public string BranchManagerEmail { get; set; }

		[DataMember(Name="branchManagerName", EmitDefaultValue=false)]
		public string BranchManagerName { get; set; }

		[DataMember(Name="branchName", EmitDefaultValue=false)]
		public string BranchName { get; set; }

		[DataMember(Name="branchOrganizationID", EmitDefaultValue=false)]
		public string BranchOrganizationID { get; set; }

		[DataMember(Name="branchPhone", EmitDefaultValue=false)]
		public string BranchPhone { get; set; }

		[DataMember(Name="branchRating", EmitDefaultValue=false)]
		public string BranchRating { get; set; }

		[DataMember(Name="branchState", EmitDefaultValue=false)]
		public string BranchState { get; set; }

		[DataMember(Name="branchZip", EmitDefaultValue=false)]
		public string BranchZip { get; set; }

		[DataMember(Name="cFCAddress", EmitDefaultValue=false)]
		public string CFCAddress { get; set; }

		[DataMember(Name="cFCBusinessFax", EmitDefaultValue=false)]
		public string CFCBusinessFax { get; set; }

		[DataMember(Name="cFCBusinessPhone", EmitDefaultValue=false)]
		public string CFCBusinessPhone { get; set; }

		[DataMember(Name="cFCCellPhone", EmitDefaultValue=false)]
		public string CFCCellPhone { get; set; }

		[DataMember(Name="cFCCity", EmitDefaultValue=false)]
		public string CFCCity { get; set; }

		[DataMember(Name="cFCEmail", EmitDefaultValue=false)]
		public string CFCEmail { get; set; }

		[DataMember(Name="cFCName", EmitDefaultValue=false)]
		public string CFCName { get; set; }

		[DataMember(Name="cFCNotes", EmitDefaultValue=false)]
		public string CFCNotes { get; set; }

		[DataMember(Name="cFCRepAE", EmitDefaultValue=false)]
		public string CFCRepAE { get; set; }

		[DataMember(Name="cFCSRAEUserName", EmitDefaultValue=false)]
		public string CFCSRAEUserName { get; set; }

		[DataMember(Name="cFCState", EmitDefaultValue=false)]
		public string CFCState { get; set; }

		[DataMember(Name="cFCStatus", EmitDefaultValue=false)]
		public string CFCStatus { get; set; }

		[DataMember(Name="cFCUserID", EmitDefaultValue=false)]
		public string CFCUserID { get; set; }

		[DataMember(Name="cFCZip", EmitDefaultValue=false)]
		public string CFCZip { get; set; }

		[DataMember(Name="companyAddress", EmitDefaultValue=false)]
		public string CompanyAddress { get; set; }

		[DataMember(Name="companyAEName", EmitDefaultValue=false)]
		public string CompanyAEName { get; set; }

		[DataMember(Name="companyAEUserName", EmitDefaultValue=false)]
		public string CompanyAEUserName { get; set; }

		[DataMember(Name="companyCity", EmitDefaultValue=false)]
		public string CompanyCity { get; set; }

		[DataMember(Name="companyDBAName", EmitDefaultValue=false)]
		public string CompanyDBAName { get; set; }

		[DataMember(Name="companyFax", EmitDefaultValue=false)]
		public string CompanyFax { get; set; }

		[DataMember(Name="companyID", EmitDefaultValue=false)]
		public string CompanyID { get; set; }

		[DataMember(Name="companyLegalName", EmitDefaultValue=false)]
		public string CompanyLegalName { get; set; }

		[DataMember(Name="companyManagerEmail", EmitDefaultValue=false)]
		public string CompanyManagerEmail { get; set; }

		[DataMember(Name="companyManagerName", EmitDefaultValue=false)]
		public string CompanyManagerName { get; set; }

		[DataMember(Name="companyName", EmitDefaultValue=false)]
		public string CompanyName { get; set; }

		[DataMember(Name="companyOrganizationID", EmitDefaultValue=false)]
		public string CompanyOrganizationID { get; set; }

		[DataMember(Name="companyPhone", EmitDefaultValue=false)]
		public string CompanyPhone { get; set; }

		[DataMember(Name="companyRating", EmitDefaultValue=false)]
		public string CompanyRating { get; set; }

		[DataMember(Name="companyState", EmitDefaultValue=false)]
		public string CompanyState { get; set; }

		[DataMember(Name="companyZip", EmitDefaultValue=false)]
		public string CompanyZip { get; set; }

		[DataMember(Name="documentsReadyDate", EmitDefaultValue=false)]
		public DateTime? DocumentsReadyDate { get; set; }

		[DataMember(Name="feeReviewComments", EmitDefaultValue=false)]
		public string FeeReviewComments { get; set; }

		[DataMember(Name="feeReviewStatus", EmitDefaultValue=false)]
		public string FeeReviewStatus { get; set; }

		[DataMember(Name="feeReviewStatusDate", EmitDefaultValue=false)]
		public DateTime? FeeReviewStatusDate { get; set; }

		[DataMember(Name="importSource", EmitDefaultValue=false)]
		public string ImportSource { get; set; }

		[DataMember(Name="initialApplicationDate", EmitDefaultValue=false)]
		public DateTime? InitialApplicationDate { get; set; }

		[DataMember(Name="initialSubmitDate", EmitDefaultValue=false)]
		public DateTime? InitialSubmitDate { get; set; }

		[DataMember(Name="lEIssuedBy", EmitDefaultValue=false)]
		public string LEIssuedBy { get; set; }

		[DataMember(Name="lOAddress", EmitDefaultValue=false)]
		public string LOAddress { get; set; }

		[DataMember(Name="lOAEName", EmitDefaultValue=false)]
		public string LOAEName { get; set; }

		[DataMember(Name="lOAEUserName", EmitDefaultValue=false)]
		public string LOAEUserName { get; set; }

		[DataMember(Name="lOBusinessFax", EmitDefaultValue=false)]
		public string LOBusinessFax { get; set; }

		[DataMember(Name="lOBusinessPhone", EmitDefaultValue=false)]
		public string LOBusinessPhone { get; set; }

		[DataMember(Name="lOCellPhone", EmitDefaultValue=false)]
		public string LOCellPhone { get; set; }

		[DataMember(Name="lOCity", EmitDefaultValue=false)]
		public string LOCity { get; set; }

		[DataMember(Name="lOEmail", EmitDefaultValue=false)]
		public string LOEmail { get; set; }

		[DataMember(Name="lOID", EmitDefaultValue=false)]
		public string LOID { get; set; }

		[DataMember(Name="lOName", EmitDefaultValue=false)]
		public string LOName { get; set; }

		[DataMember(Name="lONotes", EmitDefaultValue=false)]
		public string LONotes { get; set; }

		[DataMember(Name="lOState", EmitDefaultValue=false)]
		public string LOState { get; set; }

		[DataMember(Name="lOStatus", EmitDefaultValue=false)]
		public string LOStatus { get; set; }

		[DataMember(Name="lOZip", EmitDefaultValue=false)]
		public string LOZip { get; set; }

		[DataMember(Name="lPAddress", EmitDefaultValue=false)]
		public string LPAddress { get; set; }

		[DataMember(Name="lPAEName", EmitDefaultValue=false)]
		public string LPAEName { get; set; }

		[DataMember(Name="lPAEUserName", EmitDefaultValue=false)]
		public string LPAEUserName { get; set; }

		[DataMember(Name="lPBusinessFax", EmitDefaultValue=false)]
		public string LPBusinessFax { get; set; }

		[DataMember(Name="lPBusinessPhone", EmitDefaultValue=false)]
		public string LPBusinessPhone { get; set; }

		[DataMember(Name="lPCellPhone", EmitDefaultValue=false)]
		public string LPCellPhone { get; set; }

		[DataMember(Name="lPCity", EmitDefaultValue=false)]
		public string LPCity { get; set; }

		[DataMember(Name="lPEmail", EmitDefaultValue=false)]
		public string LPEmail { get; set; }

		[DataMember(Name="lPID", EmitDefaultValue=false)]
		public string LPID { get; set; }

		[DataMember(Name="lPName", EmitDefaultValue=false)]
		public string LPName { get; set; }

		[DataMember(Name="lPNotes", EmitDefaultValue=false)]
		public string LPNotes { get; set; }

		[DataMember(Name="lPState", EmitDefaultValue=false)]
		public string LPState { get; set; }

		[DataMember(Name="lPStatus", EmitDefaultValue=false)]
		public string LPStatus { get; set; }

		[DataMember(Name="lPZip", EmitDefaultValue=false)]
		public string LPZip { get; set; }

		[DataMember(Name="purchaseStipsReadyDate", EmitDefaultValue=false)]
		public DateTime? PurchaseStipsReadyDate { get; set; }

		[DataMember(Name="purchaseStipsReviewed", EmitDefaultValue=false)]
		public bool? PurchaseStipsReviewed { get; set; }

		[DataMember(Name="readytoDiscloseDateUtc", EmitDefaultValue=false)]
		public DateTime? ReadytoDiscloseDateUtc { get; set; }

		[DataMember(Name="registerDate", EmitDefaultValue=false)]
		public DateTime? RegisterDate { get; set; }

		[DataMember(Name="sITEID", EmitDefaultValue=false)]
		public string SITEID { get; set; }

		[DataMember(Name="submitDate", EmitDefaultValue=false)]
		public DateTime? SubmitDate { get; set; }

		[DataMember(Name="testAccountField", EmitDefaultValue=false)]
		public bool? TestAccountField { get; set; }

		[DataMember(Name="underwriterReviewed", EmitDefaultValue=false)]
		public bool? UnderwriterReviewed { get; set; }

		[DataMember(Name="underwritingDelegated", EmitDefaultValue=false)]
		public bool? UnderwritingDelegated { get; set; }

		[DataMember(Name="watchListFlag", EmitDefaultValue=false)]
		public bool? WatchListFlag { get; set; }

		[DataMember(Name="watchListReason", EmitDefaultValue=false)]
		public string WatchListReason { get; set; }

	}
}