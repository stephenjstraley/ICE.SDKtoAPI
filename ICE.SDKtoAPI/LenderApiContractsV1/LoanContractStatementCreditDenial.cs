using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractStatementCreditDenial
	{
		[DataMember(Name="additionalStatement", EmitDefaultValue=false)]
		public bool? AdditionalStatement { get; set; }

		[DataMember(Name="bankruptcy", EmitDefaultValue=false)]
		public bool? Bankruptcy { get; set; }

		[DataMember(Name="collateralNotSufficient", EmitDefaultValue=false)]
		public bool? CollateralNotSufficient { get; set; }

		[DataMember(Name="creditApplicationIncomplete", EmitDefaultValue=false)]
		public bool? CreditApplicationIncomplete { get; set; }

		[DataMember(Name="creditReportObtainedFromConsumerReportingAgency", EmitDefaultValue=false)]
		public bool? CreditReportObtainedFromConsumerReportingAgency { get; set; }

		[DataMember(Name="delinquentCreditObligations", EmitDefaultValue=false)]
		public bool? DelinquentCreditObligations { get; set; }

		[DataMember(Name="denialDate", EmitDefaultValue=false)]
		public DateTime? DenialDate { get; set; }

		[DataMember(Name="denialDescription", EmitDefaultValue=false)]
		public string DenialDescription { get; set; }

		[DataMember(Name="denialMailedOn", EmitDefaultValue=false)]
		public DateTime? DenialMailedOn { get; set; }

		[DataMember(Name="denialOther1", EmitDefaultValue=false)]
		public bool? DenialOther1 { get; set; }

		[DataMember(Name="denialOther2", EmitDefaultValue=false)]
		public bool? DenialOther2 { get; set; }

		[DataMember(Name="denialOtherDesc1", EmitDefaultValue=false)]
		public string DenialOtherDesc1 { get; set; }

		[DataMember(Name="denialOtherDesc2", EmitDefaultValue=false)]
		public string DenialOtherDesc2 { get; set; }

		[DataMember(Name="deniedBy", EmitDefaultValue=false)]
		public string DeniedBy { get; set; }

		[DataMember(Name="deniedByFhlmc", EmitDefaultValue=false)]
		public bool? DeniedByFhlmc { get; set; }

		[DataMember(Name="deniedByFnma", EmitDefaultValue=false)]
		public bool? DeniedByFnma { get; set; }

		[DataMember(Name="deniedByHud", EmitDefaultValue=false)]
		public bool? DeniedByHud { get; set; }

		[DataMember(Name="deniedByOther", EmitDefaultValue=false)]
		public bool? DeniedByOther { get; set; }

		[DataMember(Name="deniedByVa", EmitDefaultValue=false)]
		public bool? DeniedByVa { get; set; }

		[DataMember(Name="descriptionofAccount1", EmitDefaultValue=false)]
		public string DescriptionofAccount1 { get; set; }

		[DataMember(Name="descriptionofAccount2", EmitDefaultValue=false)]
		public string DescriptionofAccount2 { get; set; }

		[DataMember(Name="descriptionofAccount3", EmitDefaultValue=false)]
		public string DescriptionofAccount3 { get; set; }

		[DataMember(Name="descriptionofActionTaken1", EmitDefaultValue=false)]
		public string DescriptionofActionTaken1 { get; set; }

		[DataMember(Name="descriptionofActionTaken2", EmitDefaultValue=false)]
		public string DescriptionofActionTaken2 { get; set; }

		[DataMember(Name="ecoaAddress", EmitDefaultValue=false)]
		public string EcoaAddress { get; set; }

		[DataMember(Name="ecoaAddress2", EmitDefaultValue=false)]
		public string EcoaAddress2 { get; set; }

		[DataMember(Name="ecoaCity", EmitDefaultValue=false)]
		public string EcoaCity { get; set; }

		[DataMember(Name="ecoaName", EmitDefaultValue=false)]
		public string EcoaName { get; set; }

		[DataMember(Name="ecoaPhone", EmitDefaultValue=false)]
		public string EcoaPhone { get; set; }

		[DataMember(Name="ecoaPostalCode", EmitDefaultValue=false)]
		public string EcoaPostalCode { get; set; }

		[DataMember(Name="ecoaState", EmitDefaultValue=false)]
		public string EcoaState { get; set; }

		[DataMember(Name="excessiveObligations", EmitDefaultValue=false)]
		public bool? ExcessiveObligations { get; set; }

		[DataMember(Name="garnishment", EmitDefaultValue=false)]
		public bool? Garnishment { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="inadequateCollateral", EmitDefaultValue=false)]
		public bool? InadequateCollateral { get; set; }

		[DataMember(Name="informationFromAConsumerReportingAgency", EmitDefaultValue=false)]
		public bool? InformationFromAConsumerReportingAgency { get; set; }

		[DataMember(Name="informationObtainedFromOutsideSource", EmitDefaultValue=false)]
		public bool? InformationObtainedFromOutsideSource { get; set; }

		[DataMember(Name="informationObtainedInReportFromCra", EmitDefaultValue=false)]
		public bool? InformationObtainedInReportFromCra { get; set; }

		[DataMember(Name="insufficientCreditFile", EmitDefaultValue=false)]
		public bool? InsufficientCreditFile { get; set; }

		[DataMember(Name="insufficientCreditReference", EmitDefaultValue=false)]
		public bool? InsufficientCreditReference { get; set; }

		[DataMember(Name="insufficientData", EmitDefaultValue=false)]
		public bool? InsufficientData { get; set; }

		[DataMember(Name="insufficientFundsToCloseLoan", EmitDefaultValue=false)]
		public bool? InsufficientFundsToCloseLoan { get; set; }

		[DataMember(Name="insufficientIncomeForTotalObligations", EmitDefaultValue=false)]
		public bool? InsufficientIncomeForTotalObligations { get; set; }

		[DataMember(Name="insufficientStabilityOfIncome", EmitDefaultValue=false)]
		public bool? InsufficientStabilityOfIncome { get; set; }

		[DataMember(Name="lackOfCashReserves", EmitDefaultValue=false)]
		public bool? LackOfCashReserves { get; set; }

		[DataMember(Name="lenderInvestorAddress", EmitDefaultValue=false)]
		public string LenderInvestorAddress { get; set; }

		[DataMember(Name="lenderInvestorCity", EmitDefaultValue=false)]
		public string LenderInvestorCity { get; set; }

		[DataMember(Name="lenderInvestorName", EmitDefaultValue=false)]
		public string LenderInvestorName { get; set; }

		[DataMember(Name="lenderInvestorPhone", EmitDefaultValue=false)]
		public string LenderInvestorPhone { get; set; }

		[DataMember(Name="lenderInvestorPostalCode", EmitDefaultValue=false)]
		public string LenderInvestorPostalCode { get; set; }

		[DataMember(Name="lenderInvestorState", EmitDefaultValue=false)]
		public string LenderInvestorState { get; set; }

		[DataMember(Name="lengthOfEmployment", EmitDefaultValue=false)]
		public bool? LengthOfEmployment { get; set; }

		[DataMember(Name="noCreditFile", EmitDefaultValue=false)]
		public bool? NoCreditFile { get; set; }

		[DataMember(Name="numberRecentInquiriesCredit", EmitDefaultValue=false)]
		public bool? NumberRecentInquiriesCredit { get; set; }

		[DataMember(Name="otherDescription", EmitDefaultValue=false)]
		public string OtherDescription { get; set; }

		[DataMember(Name="poorCreditPerformance", EmitDefaultValue=false)]
		public bool? PoorCreditPerformance { get; set; }

		[DataMember(Name="temporaryOrIrregularEmployment", EmitDefaultValue=false)]
		public bool? TemporaryOrIrregularEmployment { get; set; }

		[DataMember(Name="temporaryResidence", EmitDefaultValue=false)]
		public bool? TemporaryResidence { get; set; }

		[DataMember(Name="toShortPeriodOfResidence", EmitDefaultValue=false)]
		public bool? ToShortPeriodOfResidence { get; set; }

		[DataMember(Name="unableToVerifyCreditReferences", EmitDefaultValue=false)]
		public bool? UnableToVerifyCreditReferences { get; set; }

		[DataMember(Name="unableToVerifyEmployment", EmitDefaultValue=false)]
		public bool? UnableToVerifyEmployment { get; set; }

		[DataMember(Name="unableToVerifyIncome", EmitDefaultValue=false)]
		public bool? UnableToVerifyIncome { get; set; }

		[DataMember(Name="unableToVerifyResidence", EmitDefaultValue=false)]
		public bool? UnableToVerifyResidence { get; set; }

		[DataMember(Name="unacceptableAppraisal", EmitDefaultValue=false)]
		public bool? UnacceptableAppraisal { get; set; }

		[DataMember(Name="unacceptableCreditReferencesProvided", EmitDefaultValue=false)]
		public bool? UnacceptableCreditReferencesProvided { get; set; }

		[DataMember(Name="unacceptableLeaseholdEstate", EmitDefaultValue=false)]
		public bool? UnacceptableLeaseholdEstate { get; set; }

		[DataMember(Name="unacceptablePaymentRecordOnPreviousMtg", EmitDefaultValue=false)]
		public bool? UnacceptablePaymentRecordOnPreviousMtg { get; set; }

		[DataMember(Name="unacceptableProperty", EmitDefaultValue=false)]
		public bool? UnacceptableProperty { get; set; }

		[DataMember(Name="weDoNotGrantCredit", EmitDefaultValue=false)]
		public bool? WeDoNotGrantCredit { get; set; }

		[DataMember(Name="withdrawnByApplicant", EmitDefaultValue=false)]
		public bool? WithdrawnByApplicant { get; set; }

	}
}