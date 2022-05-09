using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSection32
	{
		[DataMember(Name="appraisalFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? AppraisalFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="appraisalPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? AppraisalPortionOfFeeIndicator { get; set; }

		[DataMember(Name="aprExceedsTsyForFirstMortgage", EmitDefaultValue=false)]
		public double? AprExceedsTsyForFirstMortgage { get; set; }

		[DataMember(Name="aprExceedsTsyForSubordinateMortgage", EmitDefaultValue=false)]
		public double? AprExceedsTsyForSubordinateMortgage { get; set; }

		[DataMember(Name="assumptionFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? AssumptionFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="assumptionPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? AssumptionPortionOfFeeIndicator { get; set; }

		[DataMember(Name="attorneyFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? AttorneyFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="attorneyPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? AttorneyPortionOfFeeIndicator { get; set; }

		[DataMember(Name="cityCountyTaxStampsFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? CityCountyTaxStampsFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="cityCountyTaxStampsPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? CityCountyTaxStampsPortionOfFeeIndicator { get; set; }

		[DataMember(Name="closingFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? ClosingFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="closingPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? ClosingPortionOfFeeIndicator { get; set; }

		[DataMember(Name="creditReportFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? CreditReportFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="creditReportPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? CreditReportPortionOfFeeIndicator { get; set; }

		[DataMember(Name="docPrepFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? DocPrepFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="docPrepPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? DocPrepPortionOfFeeIndicator { get; set; }

		[DataMember(Name="exceed2PercentPrepayPenalty", EmitDefaultValue=false)]
		public string Exceed2PercentPrepayPenalty { get; set; }

		[DataMember(Name="hoepaAPR", EmitDefaultValue=false)]
		public double? HoepaAPR { get; set; }

		[DataMember(Name="hoepaFee", EmitDefaultValue=false)]
		public double? HoepaFee { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="jurisdications", EmitDefaultValue=false)]
		public string Jurisdications { get; set; }

		[DataMember(Name="lendersInspectionFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? LendersInspectionFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="lendersInspectionPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? LendersInspectionPortionOfFeeIndicator { get; set; }

		[DataMember(Name="loanDiscountFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? LoanDiscountFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="loanDiscountPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? LoanDiscountPortionOfFeeIndicator { get; set; }

		[DataMember(Name="loanOriginationFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? LoanOriginationFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="loanOriginationPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? LoanOriginationPortionOfFeeIndicator { get; set; }

		[DataMember(Name="loanQualifyAsHighCostMortgage", EmitDefaultValue=false)]
		public string LoanQualifyAsHighCostMortgage { get; set; }

		[DataMember(Name="maximumPercentageOfLoan", EmitDefaultValue=false)]
		public double? MaximumPercentageOfLoan { get; set; }

		[DataMember(Name="maximumPointsAndFees", EmitDefaultValue=false)]
		public double? MaximumPointsAndFees { get; set; }

		[DataMember(Name="mortgageBrokerFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? MortgageBrokerFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="mortgageBrokerPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? MortgageBrokerPortionOfFeeIndicator { get; set; }

		[DataMember(Name="mortgageInspectionFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? MortgageInspectionFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="mortgageInspectionPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? MortgageInspectionPortionOfFeeIndicator { get; set; }

		[DataMember(Name="mortgageInsuranceFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? MortgageInsuranceFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="mortgageInsurancePortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? MortgageInsurancePortionOfFeeIndicator { get; set; }

		[DataMember(Name="mortgageInsurancePremiumFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? MortgageInsurancePremiumFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="mortgageInsurancePremiumPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? MortgageInsurancePremiumPortionOfFeeIndicator { get; set; }

		[DataMember(Name="notaryFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? NotaryFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="notaryPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? NotaryPortionOfFeeIndicator { get; set; }

		[DataMember(Name="otherHighCostIndicator", EmitDefaultValue=false)]
		public bool? OtherHighCostIndicator { get; set; }

		[DataMember(Name="penaltyChargeMoreThan36Months", EmitDefaultValue=false)]
		public string PenaltyChargeMoreThan36Months { get; set; }

		[DataMember(Name="pestInspectionFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? PestInspectionFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="pestInspectionPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? PestInspectionPortionOfFeeIndicator { get; set; }

		[DataMember(Name="prepayPenaltyPercentofAmtPrepaid", EmitDefaultValue=false)]
		public double? PrepayPenaltyPercentofAmtPrepaid { get; set; }

		[DataMember(Name="processingFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? ProcessingFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="processingPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? ProcessingPortionOfFeeIndicator { get; set; }

		[DataMember(Name="rateSetIndex", EmitDefaultValue=false)]
		public double? RateSetIndex { get; set; }

		[DataMember(Name="recordingFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? RecordingFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="recordingPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? RecordingPortionOfFeeIndicator { get; set; }

		[DataMember(Name="resultOfPointAndFees", EmitDefaultValue=false)]
		public string ResultOfPointAndFees { get; set; }

		[DataMember(Name="resultOfSecurityYieldTest", EmitDefaultValue=false)]
		public string ResultOfSecurityYieldTest { get; set; }

		[DataMember(Name="section32Indicator", EmitDefaultValue=false)]
		public bool? Section32Indicator { get; set; }

		[DataMember(Name="section35AveragePrimeRate", EmitDefaultValue=false)]
		public double? Section35AveragePrimeRate { get; set; }

		[DataMember(Name="section35IsSecondAppraisalRequired", EmitDefaultValue=false)]
		public string Section35IsSecondAppraisalRequired { get; set; }

		[DataMember(Name="section35PriorAcquisitionDate", EmitDefaultValue=false)]
		public DateTime? Section35PriorAcquisitionDate { get; set; }

		[DataMember(Name="section35PriorAcquisitionPrice", EmitDefaultValue=false)]
		public double? Section35PriorAcquisitionPrice { get; set; }

		[DataMember(Name="section35PriorAcquisitionSource", EmitDefaultValue=false)]
		public string Section35PriorAcquisitionSource { get; set; }

		[DataMember(Name="section35ResultOfSecurityYieldTest", EmitDefaultValue=false)]
		public string Section35ResultOfSecurityYieldTest { get; set; }

		[DataMember(Name="section35SalesContractDate", EmitDefaultValue=false)]
		public DateTime? Section35SalesContractDate { get; set; }

		[DataMember(Name="stateTaxStampsFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? StateTaxStampsFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="stateTaxStampsPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? StateTaxStampsPortionOfFeeIndicator { get; set; }

		[DataMember(Name="surveyFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? SurveyFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="surveyPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? SurveyPortionOfFeeIndicator { get; set; }

		[DataMember(Name="taxServiceFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? TaxServiceFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="taxServicePortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? TaxServicePortionOfFeeIndicator { get; set; }

		[DataMember(Name="titleBinderFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? TitleBinderFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="titleBinderPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? TitleBinderPortionOfFeeIndicator { get; set; }

		[DataMember(Name="titleExaminationFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? TitleExaminationFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="titleExaminationPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? TitleExaminationPortionOfFeeIndicator { get; set; }

		[DataMember(Name="titleInsuranceFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? TitleInsuranceFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="titleInsurancePortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? TitleInsurancePortionOfFeeIndicator { get; set; }

		[DataMember(Name="titleSearchFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? TitleSearchFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="titleSearchPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? TitleSearchPortionOfFeeIndicator { get; set; }

		[DataMember(Name="totalPointsAndFees", EmitDefaultValue=false)]
		public double? TotalPointsAndFees { get; set; }

		[DataMember(Name="treasurySecurityYield", EmitDefaultValue=false)]
		public double? TreasurySecurityYield { get; set; }

		[DataMember(Name="underwritingFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UnderwritingFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="underwritingPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UnderwritingPortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1109BorPaidAmount", EmitDefaultValue=false)]
		public double? UserDefined1109BorPaidAmount { get; set; }

		[DataMember(Name="userDefined1109FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1109FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1109PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1109PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1110BorPaidAmount", EmitDefaultValue=false)]
		public double? UserDefined1110BorPaidAmount { get; set; }

		[DataMember(Name="userDefined1110FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1110FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1110PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1110PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1111FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1111FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1111PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1111PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1112FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1112FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1112PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1112PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1113FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1113FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1113PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1113PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1114FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1114FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1114PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1114PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1204FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1204FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1204PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1204PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1205FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1205FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1205PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1205PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1206FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1206FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1206PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1206PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1303FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1303FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1303PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1303PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1304FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1304FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1304PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1304PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1305FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1305FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1305PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1305PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1306FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1306FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1306PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1306PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1307FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1307FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1307PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1307PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1308FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1308FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1308PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1308PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined1309FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1309FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined1309PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined1309PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined813FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined813FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined813PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined813PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined814FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined814FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined814PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined814PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined815FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined815FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined815PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined815PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined816FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined816FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined816PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined816PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined817FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined817FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined817PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined817PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined818FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined818FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined818PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined818PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined819FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined819FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined819PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined819PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined820FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined820FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined820PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined820PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined821FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined821FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined821PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined821PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined822FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined822FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined822PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined822PortionOfFeeIndicator { get; set; }

		[DataMember(Name="userDefined823FeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? UserDefined823FeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="userDefined823PortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? UserDefined823PortionOfFeeIndicator { get; set; }

		[DataMember(Name="wireTransferFeeToBeFinancedIndicator", EmitDefaultValue=false)]
		public bool? WireTransferFeeToBeFinancedIndicator { get; set; }

		[DataMember(Name="wireTransferPortionOfFeeIndicator", EmitDefaultValue=false)]
		public bool? WireTransferPortionOfFeeIndicator { get; set; }

	}
}