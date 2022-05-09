using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTsum
	{
		[DataMember(Name="aboveOrBelowRatePercent", EmitDefaultValue=false)]
		public double? AboveOrBelowRatePercent { get; set; }

		[DataMember(Name="adjustorCoverage", EmitDefaultValue=false)]
		public string AdjustorCoverage { get; set; }

		[DataMember(Name="ausRecommendation", EmitDefaultValue=false)]
		public string AusRecommendation { get; set; }

		[DataMember(Name="bedroomsUnit1", EmitDefaultValue=false)]
		public int? BedroomsUnit1 { get; set; }

		[DataMember(Name="bedroomsUnit2", EmitDefaultValue=false)]
		public int? BedroomsUnit2 { get; set; }

		[DataMember(Name="bedroomsUnit3", EmitDefaultValue=false)]
		public int? BedroomsUnit3 { get; set; }

		[DataMember(Name="bedroomsUnit4", EmitDefaultValue=false)]
		public int? BedroomsUnit4 { get; set; }

		[DataMember(Name="certificateNumber", EmitDefaultValue=false)]
		public string CertificateNumber { get; set; }

		[DataMember(Name="commitmentNumber", EmitDefaultValue=false)]
		public string CommitmentNumber { get; set; }

		[DataMember(Name="communityLendingAfordableHousingInitiative", EmitDefaultValue=false)]
		public bool? CommunityLendingAfordableHousingInitiative { get; set; }

		[DataMember(Name="contactTitle", EmitDefaultValue=false)]
		public string ContactTitle { get; set; }

		[DataMember(Name="contractNumber", EmitDefaultValue=false)]
		public string ContractNumber { get; set; }

		[DataMember(Name="cpmProjectId", EmitDefaultValue=false)]
		public string CpmProjectId { get; set; }

		[DataMember(Name="duCaseIdLpAusKey", EmitDefaultValue=false)]
		public string DuCaseIdLpAusKey { get; set; }

		[DataMember(Name="formNumber", EmitDefaultValue=false)]
		public string FormNumber { get; set; }

		[DataMember(Name="grossRentUnit1", EmitDefaultValue=false)]
		public int? GrossRentUnit1 { get; set; }

		[DataMember(Name="grossRentUnit2", EmitDefaultValue=false)]
		public int? GrossRentUnit2 { get; set; }

		[DataMember(Name="grossRentUnit3", EmitDefaultValue=false)]
		public int? GrossRentUnit3 { get; set; }

		[DataMember(Name="grossRentUnit4", EmitDefaultValue=false)]
		public int? GrossRentUnit4 { get; set; }

		[DataMember(Name="homeBuyersOwnershipEducationCertificateInFile", EmitDefaultValue=false)]
		public string HomeBuyersOwnershipEducationCertificateInFile { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="insurerCode", EmitDefaultValue=false)]
		public string InsurerCode { get; set; }

		[DataMember(Name="interestedPartyContributions", EmitDefaultValue=false)]
		public double? InterestedPartyContributions { get; set; }

		[DataMember(Name="investorLoanNumber", EmitDefaultValue=false)]
		public string InvestorLoanNumber { get; set; }

		[DataMember(Name="levelOfPropertyReviewType", EmitDefaultValue=false)]
		public string LevelOfPropertyReviewType { get; set; }

		[DataMember(Name="lpDocClass", EmitDefaultValue=false)]
		public string LpDocClass { get; set; }

		[DataMember(Name="mortgageOriginator", EmitDefaultValue=false)]
		public string MortgageOriginator { get; set; }

		[DataMember(Name="noteDate", EmitDefaultValue=false)]
		public DateTime? NoteDate { get; set; }

		[DataMember(Name="noteRateType", EmitDefaultValue=false)]
		public string NoteRateType { get; set; }

		[DataMember(Name="numberOfBorrowers", EmitDefaultValue=false)]
		public int? NumberOfBorrowers { get; set; }

		[DataMember(Name="numberOfMonthsReserves", EmitDefaultValue=false)]
		public int? NumberOfMonthsReserves { get; set; }

		[DataMember(Name="originalAmountOfFirstMortgage", EmitDefaultValue=false)]
		public double? OriginalAmountOfFirstMortgage { get; set; }

		[DataMember(Name="otherTypeDescription", EmitDefaultValue=false)]
		public string OtherTypeDescription { get; set; }

		[DataMember(Name="percentageofCoverage", EmitDefaultValue=false)]
		public string PercentageofCoverage { get; set; }

		[DataMember(Name="projectName", EmitDefaultValue=false)]
		public string ProjectName { get; set; }

		[DataMember(Name="propertyFormType", EmitDefaultValue=false)]
		public string PropertyFormType { get; set; }

		[DataMember(Name="propertyType", EmitDefaultValue=false)]
		public string PropertyType { get; set; }

		[DataMember(Name="required", EmitDefaultValue=false)]
		public double? Required { get; set; }

		[DataMember(Name="riskAssessmentType", EmitDefaultValue=false)]
		public string RiskAssessmentType { get; set; }

		[DataMember(Name="sellerAddress", EmitDefaultValue=false)]
		public string SellerAddress { get; set; }

		[DataMember(Name="sellerCity", EmitDefaultValue=false)]
		public string SellerCity { get; set; }

		[DataMember(Name="sellerContactName", EmitDefaultValue=false)]
		public string SellerContactName { get; set; }

		[DataMember(Name="sellerName", EmitDefaultValue=false)]
		public string SellerName { get; set; }

		[DataMember(Name="sellerNumber", EmitDefaultValue=false)]
		public string SellerNumber { get; set; }

		[DataMember(Name="sellerPhone", EmitDefaultValue=false)]
		public string SellerPhone { get; set; }

		[DataMember(Name="sellerPostalCode", EmitDefaultValue=false)]
		public string SellerPostalCode { get; set; }

		[DataMember(Name="sellerState", EmitDefaultValue=false)]
		public string SellerState { get; set; }

		[DataMember(Name="specialFeatureCode1", EmitDefaultValue=false)]
		public string SpecialFeatureCode1 { get; set; }

		[DataMember(Name="specialFeatureCode2", EmitDefaultValue=false)]
		public string SpecialFeatureCode2 { get; set; }

		[DataMember(Name="specialFeatureCode3", EmitDefaultValue=false)]
		public string SpecialFeatureCode3 { get; set; }

		[DataMember(Name="specialFeatureCode4", EmitDefaultValue=false)]
		public string SpecialFeatureCode4 { get; set; }

		[DataMember(Name="specialFeatureCode5", EmitDefaultValue=false)]
		public string SpecialFeatureCode5 { get; set; }

		[DataMember(Name="specialFeatureCode6", EmitDefaultValue=false)]
		public string SpecialFeatureCode6 { get; set; }

		[DataMember(Name="thirdPartyName1", EmitDefaultValue=false)]
		public string ThirdPartyName1 { get; set; }

		[DataMember(Name="thirdPartyName2", EmitDefaultValue=false)]
		public string ThirdPartyName2 { get; set; }

		[DataMember(Name="typeOfCommitment", EmitDefaultValue=false)]
		public string TypeOfCommitment { get; set; }

		[DataMember(Name="underwritingComment1", EmitDefaultValue=false)]
		public string UnderwritingComment1 { get; set; }

		[DataMember(Name="underwritingComment2", EmitDefaultValue=false)]
		public string UnderwritingComment2 { get; set; }

		[DataMember(Name="underwritingComment3", EmitDefaultValue=false)]
		public string UnderwritingComment3 { get; set; }

		[DataMember(Name="underwritingComment4", EmitDefaultValue=false)]
		public string UnderwritingComment4 { get; set; }

		[DataMember(Name="underwritingComment5", EmitDefaultValue=false)]
		public string UnderwritingComment5 { get; set; }

		[DataMember(Name="underwritingComment6", EmitDefaultValue=false)]
		public string UnderwritingComment6 { get; set; }

		[DataMember(Name="underwritingComment7", EmitDefaultValue=false)]
		public string UnderwritingComment7 { get; set; }

		[DataMember(Name="underwritingComment8", EmitDefaultValue=false)]
		public string UnderwritingComment8 { get; set; }

		[DataMember(Name="unpaidBalance", EmitDefaultValue=false)]
		public double? UnpaidBalance { get; set; }

		[DataMember(Name="verified", EmitDefaultValue=false)]
		public double? Verified { get; set; }

	}
}