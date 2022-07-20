using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractStatementCreditDenial
	{
		[DataMember(Name="additionalStatement")]
		public bool? AdditionalStatement { get; set; }

		[DataMember(Name="bankruptcy")]
		public bool? Bankruptcy { get; set; }

		[DataMember(Name="collateralNotSufficient")]
		public bool? CollateralNotSufficient { get; set; }

		[DataMember(Name="creditApplicationIncomplete")]
		public bool? CreditApplicationIncomplete { get; set; }

		[DataMember(Name="creditReportObtainedFromConsumerReportingAgency")]
		public bool? CreditReportObtainedFromConsumerReportingAgency { get; set; }

		[DataMember(Name="delinquentCreditObligations")]
		public bool? DelinquentCreditObligations { get; set; }

		[DataMember(Name="denialDate")]
		public DateTime? DenialDate { get; set; }

		[DataMember(Name="denialDescription")]
		public string DenialDescription { get; set; }

		[DataMember(Name="denialMailedOn")]
		public DateTime? DenialMailedOn { get; set; }

		[DataMember(Name="denialOther1")]
		public bool? DenialOther1 { get; set; }

		[DataMember(Name="denialOther2")]
		public bool? DenialOther2 { get; set; }

		[DataMember(Name="denialOtherDesc1")]
		public string DenialOtherDesc1 { get; set; }

		[DataMember(Name="denialOtherDesc2")]
		public string DenialOtherDesc2 { get; set; }

		[DataMember(Name="deniedBy")]
		public string DeniedBy { get; set; }

		[DataMember(Name="deniedByFhlmc")]
		public bool? DeniedByFhlmc { get; set; }

		[DataMember(Name="deniedByFnma")]
		public bool? DeniedByFnma { get; set; }

		[DataMember(Name="deniedByHud")]
		public bool? DeniedByHud { get; set; }

		[DataMember(Name="deniedByOther")]
		public bool? DeniedByOther { get; set; }

		[DataMember(Name="deniedByVa")]
		public bool? DeniedByVa { get; set; }

		[DataMember(Name="descriptionofAccount1")]
		public string DescriptionofAccount1 { get; set; }

		[DataMember(Name="descriptionofAccount2")]
		public string DescriptionofAccount2 { get; set; }

		[DataMember(Name="descriptionofAccount3")]
		public string DescriptionofAccount3 { get; set; }

		[DataMember(Name="descriptionofActionTaken1")]
		public string DescriptionofActionTaken1 { get; set; }

		[DataMember(Name="descriptionofActionTaken2")]
		public string DescriptionofActionTaken2 { get; set; }

		[DataMember(Name="ecoaAddress")]
		public string EcoaAddress { get; set; }

		[DataMember(Name="ecoaAddress2")]
		public string EcoaAddress2 { get; set; }

		[DataMember(Name="ecoaCity")]
		public string EcoaCity { get; set; }

		[DataMember(Name="ecoaName")]
		public string EcoaName { get; set; }

		[DataMember(Name="ecoaPhone")]
		public string EcoaPhone { get; set; }

		[DataMember(Name="ecoaPostalCode")]
		public string EcoaPostalCode { get; set; }

		[DataMember(Name="ecoaState")]
		public string EcoaState { get; set; }

		[DataMember(Name="excessiveObligations")]
		public bool? ExcessiveObligations { get; set; }

		[DataMember(Name="garnishment")]
		public bool? Garnishment { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="inadequateCollateral")]
		public bool? InadequateCollateral { get; set; }

		[DataMember(Name="informationFromAConsumerReportingAgency")]
		public bool? InformationFromAConsumerReportingAgency { get; set; }

		[DataMember(Name="informationObtainedFromOutsideSource")]
		public bool? InformationObtainedFromOutsideSource { get; set; }

		[DataMember(Name="informationObtainedInReportFromCra")]
		public bool? InformationObtainedInReportFromCra { get; set; }

		[DataMember(Name="insufficientCreditFile")]
		public bool? InsufficientCreditFile { get; set; }

		[DataMember(Name="insufficientCreditReference")]
		public bool? InsufficientCreditReference { get; set; }

		[DataMember(Name="insufficientData")]
		public bool? InsufficientData { get; set; }

		[DataMember(Name="insufficientFundsToCloseLoan")]
		public bool? InsufficientFundsToCloseLoan { get; set; }

		[DataMember(Name="insufficientIncomeForTotalObligations")]
		public bool? InsufficientIncomeForTotalObligations { get; set; }

		[DataMember(Name="insufficientStabilityOfIncome")]
		public bool? InsufficientStabilityOfIncome { get; set; }

		[DataMember(Name="lackOfCashReserves")]
		public bool? LackOfCashReserves { get; set; }

		[DataMember(Name="lenderInvestorAddress")]
		public string LenderInvestorAddress { get; set; }

		[DataMember(Name="lenderInvestorCity")]
		public string LenderInvestorCity { get; set; }

		[DataMember(Name="lenderInvestorName")]
		public string LenderInvestorName { get; set; }

		[DataMember(Name="lenderInvestorPhone")]
		public string LenderInvestorPhone { get; set; }

		[DataMember(Name="lenderInvestorPostalCode")]
		public string LenderInvestorPostalCode { get; set; }

		[DataMember(Name="lenderInvestorState")]
		public string LenderInvestorState { get; set; }

		[DataMember(Name="lengthOfEmployment")]
		public bool? LengthOfEmployment { get; set; }

		[DataMember(Name="noCreditFile")]
		public bool? NoCreditFile { get; set; }

		[DataMember(Name="numberRecentInquiriesCredit")]
		public bool? NumberRecentInquiriesCredit { get; set; }

		[DataMember(Name="otherDescription")]
		public string OtherDescription { get; set; }

		[DataMember(Name="poorCreditPerformance")]
		public bool? PoorCreditPerformance { get; set; }

		[DataMember(Name="temporaryOrIrregularEmployment")]
		public bool? TemporaryOrIrregularEmployment { get; set; }

		[DataMember(Name="temporaryResidence")]
		public bool? TemporaryResidence { get; set; }

		[DataMember(Name="toShortPeriodOfResidence")]
		public bool? ToShortPeriodOfResidence { get; set; }

		[DataMember(Name="unableToVerifyCreditReferences")]
		public bool? UnableToVerifyCreditReferences { get; set; }

		[DataMember(Name="unableToVerifyEmployment")]
		public bool? UnableToVerifyEmployment { get; set; }

		[DataMember(Name="unableToVerifyIncome")]
		public bool? UnableToVerifyIncome { get; set; }

		[DataMember(Name="unableToVerifyResidence")]
		public bool? UnableToVerifyResidence { get; set; }

		[DataMember(Name="unacceptableAppraisal")]
		public bool? UnacceptableAppraisal { get; set; }

		[DataMember(Name="unacceptableCreditReferencesProvided")]
		public bool? UnacceptableCreditReferencesProvided { get; set; }

		[DataMember(Name="unacceptableLeaseholdEstate")]
		public bool? UnacceptableLeaseholdEstate { get; set; }

		[DataMember(Name="unacceptablePaymentRecordOnPreviousMtg")]
		public bool? UnacceptablePaymentRecordOnPreviousMtg { get; set; }

		[DataMember(Name="unacceptableProperty")]
		public bool? UnacceptableProperty { get; set; }

		[DataMember(Name="weDoNotGrantCredit")]
		public bool? WeDoNotGrantCredit { get; set; }

		[DataMember(Name="withdrawnByApplicant")]
		public bool? WithdrawnByApplicant { get; set; }

	}
}