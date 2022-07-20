using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostLoanEstimate3
	{
		[DataMember(Name="appraisal")]
		public string Appraisal { get; set; }

		[DataMember(Name="assumption")]
		public string Assumption { get; set; }

		[DataMember(Name="constructionLoan")]
		public bool? ConstructionLoan { get; set; }

		[DataMember(Name="homeownerInsurance")]
		public bool? HomeownerInsurance { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="in5YearsPrincipalYouWillHavePaidOff")]
		public int? In5YearsPrincipalYouWillHavePaidOff { get; set; }

		[DataMember(Name="in5YearsTotalYouWillHavePaid")]
		public int? In5YearsTotalYouWillHavePaid { get; set; }

		[DataMember(Name="lenderEmail")]
		public string LenderEmail { get; set; }

		[DataMember(Name="lenderLicenseID")]
		public string LenderLicenseID { get; set; }

		[DataMember(Name="lenderLicenseState")]
		public string LenderLicenseState { get; set; }

		[DataMember(Name="lenderLoanOfficer")]
		public string LenderLoanOfficer { get; set; }

		[DataMember(Name="lenderLoanOfficerLicenseState")]
		public string LenderLoanOfficerLicenseState { get; set; }

		[DataMember(Name="lenderLoanOfficerNMLSId")]
		public string LenderLoanOfficerNMLSId { get; set; }

		[DataMember(Name="lenderPhone")]
		public string LenderPhone { get; set; }

		[DataMember(Name="mortgageBrokerEmail")]
		public string MortgageBrokerEmail { get; set; }

		[DataMember(Name="mortgageBrokerLicenseID")]
		public string MortgageBrokerLicenseID { get; set; }

		[DataMember(Name="mortgageBrokerLicenseState")]
		public string MortgageBrokerLicenseState { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficer")]
		public string MortgageBrokerLoanOfficer { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficerLicenseID")]
		public string MortgageBrokerLoanOfficerLicenseID { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficerLicenseState")]
		public string MortgageBrokerLoanOfficerLicenseState { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficerNMLSId")]
		public string MortgageBrokerLoanOfficerNMLSId { get; set; }

		[DataMember(Name="mortgageBrokerPhone")]
		public string MortgageBrokerPhone { get; set; }

		[DataMember(Name="mortgageLenderLoanOfficerLicenseID")]
		public string MortgageLenderLoanOfficerLicenseID { get; set; }

		[DataMember(Name="servicing")]
		public string Servicing { get; set; }

		[DataMember(Name="signatureType")]
		public string SignatureType { get; set; }

		[DataMember(Name="totalInterestPercentage")]
		public decimal? TotalInterestPercentage { get; set; }

		[DataMember(Name="totalInterestPercentageUI")]
		public string TotalInterestPercentageUI { get; set; }

	}
}