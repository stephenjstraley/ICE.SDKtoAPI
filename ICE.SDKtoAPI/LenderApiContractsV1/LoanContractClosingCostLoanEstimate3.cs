using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostLoanEstimate3
	{
		[DataMember(Name="appraisal", EmitDefaultValue=false)]
		public string Appraisal { get; set; }

		[DataMember(Name="assumption", EmitDefaultValue=false)]
		public string Assumption { get; set; }

		[DataMember(Name="constructionLoan", EmitDefaultValue=false)]
		public bool? ConstructionLoan { get; set; }

		[DataMember(Name="homeownerInsurance", EmitDefaultValue=false)]
		public bool? HomeownerInsurance { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="in5YearsPrincipalYouWillHavePaidOff", EmitDefaultValue=false)]
		public int? In5YearsPrincipalYouWillHavePaidOff { get; set; }

		[DataMember(Name="in5YearsTotalYouWillHavePaid", EmitDefaultValue=false)]
		public int? In5YearsTotalYouWillHavePaid { get; set; }

		[DataMember(Name="lenderEmail", EmitDefaultValue=false)]
		public string LenderEmail { get; set; }

		[DataMember(Name="lenderLicenseID", EmitDefaultValue=false)]
		public string LenderLicenseID { get; set; }

		[DataMember(Name="lenderLicenseState", EmitDefaultValue=false)]
		public string LenderLicenseState { get; set; }

		[DataMember(Name="lenderLoanOfficer", EmitDefaultValue=false)]
		public string LenderLoanOfficer { get; set; }

		[DataMember(Name="lenderLoanOfficerLicenseState", EmitDefaultValue=false)]
		public string LenderLoanOfficerLicenseState { get; set; }

		[DataMember(Name="lenderLoanOfficerNMLSId", EmitDefaultValue=false)]
		public string LenderLoanOfficerNMLSId { get; set; }

		[DataMember(Name="lenderPhone", EmitDefaultValue=false)]
		public string LenderPhone { get; set; }

		[DataMember(Name="mortgageBrokerEmail", EmitDefaultValue=false)]
		public string MortgageBrokerEmail { get; set; }

		[DataMember(Name="mortgageBrokerLicenseID", EmitDefaultValue=false)]
		public string MortgageBrokerLicenseID { get; set; }

		[DataMember(Name="mortgageBrokerLicenseState", EmitDefaultValue=false)]
		public string MortgageBrokerLicenseState { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficer", EmitDefaultValue=false)]
		public string MortgageBrokerLoanOfficer { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficerLicenseID", EmitDefaultValue=false)]
		public string MortgageBrokerLoanOfficerLicenseID { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficerLicenseState", EmitDefaultValue=false)]
		public string MortgageBrokerLoanOfficerLicenseState { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficerNMLSId", EmitDefaultValue=false)]
		public string MortgageBrokerLoanOfficerNMLSId { get; set; }

		[DataMember(Name="mortgageBrokerPhone", EmitDefaultValue=false)]
		public string MortgageBrokerPhone { get; set; }

		[DataMember(Name="mortgageLenderLoanOfficerLicenseID", EmitDefaultValue=false)]
		public string MortgageLenderLoanOfficerLicenseID { get; set; }

		[DataMember(Name="servicing", EmitDefaultValue=false)]
		public string Servicing { get; set; }

		[DataMember(Name="signatureType", EmitDefaultValue=false)]
		public string SignatureType { get; set; }

		[DataMember(Name="totalInterestPercentage", EmitDefaultValue=false)]
		public double? TotalInterestPercentage { get; set; }

		[DataMember(Name="totalInterestPercentageUI", EmitDefaultValue=false)]
		public string TotalInterestPercentageUI { get; set; }

	}
}