using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDisclosureNotices
	{
		[DataMember(Name="antiCoercionStatementIndicator", EmitDefaultValue=false)]
		public bool? AntiCoercionStatementIndicator { get; set; }

		[DataMember(Name="commitmentIssuedByAddress", EmitDefaultValue=false)]
		public string CommitmentIssuedByAddress { get; set; }

		[DataMember(Name="commitmentIssuedByCity", EmitDefaultValue=false)]
		public string CommitmentIssuedByCity { get; set; }

		[DataMember(Name="commitmentIssuedByContactName", EmitDefaultValue=false)]
		public string CommitmentIssuedByContactName { get; set; }

		[DataMember(Name="commitmentIssuedByName", EmitDefaultValue=false)]
		public string CommitmentIssuedByName { get; set; }

		[DataMember(Name="commitmentIssuedByPhone", EmitDefaultValue=false)]
		public string CommitmentIssuedByPhone { get; set; }

		[DataMember(Name="commitmentIssuedByPostalCode", EmitDefaultValue=false)]
		public string CommitmentIssuedByPostalCode { get; set; }

		[DataMember(Name="commitmentIssuedByState", EmitDefaultValue=false)]
		public string CommitmentIssuedByState { get; set; }

		[DataMember(Name="consumerHandbookOnAdjustableRateMortgages", EmitDefaultValue=false)]
		public string ConsumerHandbookOnAdjustableRateMortgages { get; set; }

		[DataMember(Name="daysToReceiveWrittenRequest", EmitDefaultValue=false)]
		public string DaysToReceiveWrittenRequest { get; set; }

		[DataMember(Name="daysToReturnToLender", EmitDefaultValue=false)]
		public int? DaysToReturnToLender { get; set; }

		[DataMember(Name="discloseNonPublicPersonalInformation", EmitDefaultValue=false)]
		public string DiscloseNonPublicPersonalInformation { get; set; }

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

		[DataMember(Name="fairLendingNoticeDescription1", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription1 { get; set; }

		[DataMember(Name="fairLendingNoticeDescription2", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription2 { get; set; }

		[DataMember(Name="fairLendingNoticeDescription3", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription3 { get; set; }

		[DataMember(Name="fairLendingNoticeDescription4", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription4 { get; set; }

		[DataMember(Name="fairLendingNoticeDescription5", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription5 { get; set; }

		[DataMember(Name="fairLendingNoticeDescription6", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription6 { get; set; }

		[DataMember(Name="fairLendingNoticeDescription7", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription7 { get; set; }

		[DataMember(Name="fairLendingNoticeDescription8", EmitDefaultValue=false)]
		public string FairLendingNoticeDescription8 { get; set; }

		[DataMember(Name="femaCommunityName", EmitDefaultValue=false)]
		public string FemaCommunityName { get; set; }

		[DataMember(Name="floodInsuranceNotificationIndicator", EmitDefaultValue=false)]
		public bool? FloodInsuranceNotificationIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="informationDisclosureAuthorizationIndicator", EmitDefaultValue=false)]
		public bool? InformationDisclosureAuthorizationIndicator { get; set; }

		[DataMember(Name="licensedMortgageBrokerUnder", EmitDefaultValue=false)]
		public string LicensedMortgageBrokerUnder { get; set; }

		[DataMember(Name="locatedInNfipIndicator", EmitDefaultValue=false)]
		public bool? LocatedInNfipIndicator { get; set; }

		[DataMember(Name="lossPayeeClause", EmitDefaultValue=false)]
		public string LossPayeeClause { get; set; }

		[DataMember(Name="mapPanelNumber", EmitDefaultValue=false)]
		public string MapPanelNumber { get; set; }

		[DataMember(Name="nFIPCommunityNumber", EmitDefaultValue=false)]
		public string NFIPCommunityNumber { get; set; }

		[DataMember(Name="nFIPMapEffectiveRevisedDate", EmitDefaultValue=false)]
		public DateTime? NFIPMapEffectiveRevisedDate { get; set; }

		[DataMember(Name="nFIPParticipationStatus", EmitDefaultValue=false)]
		public string NFIPParticipationStatus { get; set; }

		[DataMember(Name="nonFinancialCompaniesDescription1", EmitDefaultValue=false)]
		public string NonFinancialCompaniesDescription1 { get; set; }

		[DataMember(Name="nonFinancialCompaniesDescription2", EmitDefaultValue=false)]
		public string NonFinancialCompaniesDescription2 { get; set; }

		[DataMember(Name="nonFinancialCompaniesDescription3", EmitDefaultValue=false)]
		public string NonFinancialCompaniesDescription3 { get; set; }

		[DataMember(Name="nonFinancialCompaniesDescription4", EmitDefaultValue=false)]
		public string NonFinancialCompaniesDescription4 { get; set; }

		[DataMember(Name="notLocatedInNfipIndicator", EmitDefaultValue=false)]
		public bool? NotLocatedInNfipIndicator { get; set; }

		[DataMember(Name="occupancyStatementIndicator", EmitDefaultValue=false)]
		public bool? OccupancyStatementIndicator { get; set; }

		[DataMember(Name="optOut", EmitDefaultValue=false)]
		public string OptOut { get; set; }

		[DataMember(Name="optOutPhone", EmitDefaultValue=false)]
		public string OptOutPhone { get; set; }

		[DataMember(Name="releaseBankingInformationIndicator", EmitDefaultValue=false)]
		public bool? ReleaseBankingInformationIndicator { get; set; }

		[DataMember(Name="releaseEmploymentInformationIndicator", EmitDefaultValue=false)]
		public bool? ReleaseEmploymentInformationIndicator { get; set; }

		[DataMember(Name="releaseInformationInConnectionWithCreditReportIndicator", EmitDefaultValue=false)]
		public bool? ReleaseInformationInConnectionWithCreditReportIndicator { get; set; }

		[DataMember(Name="releaseMortgageInformationIndicator", EmitDefaultValue=false)]
		public bool? ReleaseMortgageInformationIndicator { get; set; }

		[DataMember(Name="rightToFinancialPrivacyActIndicator", EmitDefaultValue=false)]
		public bool? RightToFinancialPrivacyActIndicator { get; set; }

	}
}