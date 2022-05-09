using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ApplicationContractLiabilities
	{
		[DataMember(Name="accountIdentifier", EmitDefaultValue=false)]
		public string AccountIdentifier { get; set; }

		[DataMember(Name="accountIndicator", EmitDefaultValue=false)]
		public bool? AccountIndicator { get; set; }

		[DataMember(Name="attention", EmitDefaultValue=false)]
		public string Attention { get; set; }

		[DataMember(Name="contact", EmitDefaultValue=false)]
		public ApplicationContractContact Contact { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="descriptionOfPurpose", EmitDefaultValue=false)]
		public string DescriptionOfPurpose { get; set; }

		[DataMember(Name="entityDeleted", EmitDefaultValue=false)]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="exclusionIndicator", EmitDefaultValue=false)]
		public bool? ExclusionIndicator { get; set; }

		[DataMember(Name="holderAddressCity", EmitDefaultValue=false)]
		public string HolderAddressCity { get; set; }

		[DataMember(Name="holderAddressPostalCode", EmitDefaultValue=false)]
		public string HolderAddressPostalCode { get; set; }

		[DataMember(Name="holderAddressState", EmitDefaultValue=false)]
		public string HolderAddressState { get; set; }

		[DataMember(Name="holderAddressStreetLine1", EmitDefaultValue=false)]
		public string HolderAddressStreetLine1 { get; set; }

		[DataMember(Name="holderComments", EmitDefaultValue=false)]
		public string HolderComments { get; set; }

		[DataMember(Name="holderEmail", EmitDefaultValue=false)]
		public string HolderEmail { get; set; }

		[DataMember(Name="holderFax", EmitDefaultValue=false)]
		public string HolderFax { get; set; }

		[DataMember(Name="holderName", EmitDefaultValue=false)]
		public string HolderName { get; set; }

		[DataMember(Name="holderPhone", EmitDefaultValue=false)]
		public string HolderPhone { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isDebtNotSecuredToSubjectPropertyIndicator", EmitDefaultValue=false)]
		public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get; set; }

		[DataMember(Name="lates12Month120Day", EmitDefaultValue=false)]
		public int? Lates12Month120Day { get; set; }

		[DataMember(Name="lates12Month150Day", EmitDefaultValue=false)]
		public int? Lates12Month150Day { get; set; }

		[DataMember(Name="lates12Month30Day", EmitDefaultValue=false)]
		public int? Lates12Month30Day { get; set; }

		[DataMember(Name="lates12Month60Day", EmitDefaultValue=false)]
		public int? Lates12Month60Day { get; set; }

		[DataMember(Name="lates12Month90Day", EmitDefaultValue=false)]
		public int? Lates12Month90Day { get; set; }

		[DataMember(Name="lates24Month120Day", EmitDefaultValue=false)]
		public int? Lates24Month120Day { get; set; }

		[DataMember(Name="lates24Month150Day", EmitDefaultValue=false)]
		public int? Lates24Month150Day { get; set; }

		[DataMember(Name="lates24Month30Day", EmitDefaultValue=false)]
		public int? Lates24Month30Day { get; set; }

		[DataMember(Name="lates24Month60Day", EmitDefaultValue=false)]
		public int? Lates24Month60Day { get; set; }

		[DataMember(Name="lates24Month90Day", EmitDefaultValue=false)]
		public int? Lates24Month90Day { get; set; }

		[DataMember(Name="lates25Month120Day", EmitDefaultValue=false)]
		public int? Lates25Month120Day { get; set; }

		[DataMember(Name="lates25Month150Day", EmitDefaultValue=false)]
		public int? Lates25Month150Day { get; set; }

		[DataMember(Name="lates25Month30Day", EmitDefaultValue=false)]
		public int? Lates25Month30Day { get; set; }

		[DataMember(Name="lates25Month60Day", EmitDefaultValue=false)]
		public int? Lates25Month60Day { get; set; }

		[DataMember(Name="lates25Month90Day", EmitDefaultValue=false)]
		public int? Lates25Month90Day { get; set; }

		[DataMember(Name="liabilityIndex", EmitDefaultValue=false)]
		public int? LiabilityIndex { get; set; }

		[DataMember(Name="liabilityType", EmitDefaultValue=false)]
		public string LiabilityType { get; set; }

		[DataMember(Name="monthlyPaymentAmount", EmitDefaultValue=false)]
		public double? MonthlyPaymentAmount { get; set; }

		[DataMember(Name="monthsToExclude", EmitDefaultValue=false)]
		public int? MonthsToExclude { get; set; }

		[DataMember(Name="nameInAccount", EmitDefaultValue=false)]
		public string NameInAccount { get; set; }

		[DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
		public bool? NoLinkToDocTrackIndicator { get; set; }

		[DataMember(Name="owner", EmitDefaultValue=false)]
		public string Owner { get; set; }

		[DataMember(Name="payoffIncludedIndicator", EmitDefaultValue=false)]
		public bool? PayoffIncludedIndicator { get; set; }

		[DataMember(Name="payoffStatusIndicator", EmitDefaultValue=false)]
		public bool? PayoffStatusIndicator { get; set; }

		[DataMember(Name="prepaymentPenaltyAmount", EmitDefaultValue=false)]
		public double? PrepaymentPenaltyAmount { get; set; }

		[DataMember(Name="printAttachmentIndicator", EmitDefaultValue=false)]
		public bool? PrintAttachmentIndicator { get; set; }

		[DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
		public bool? PrintUserNameIndicator { get; set; }

		[DataMember(Name="remainingTermMonths", EmitDefaultValue=false)]
		public int? RemainingTermMonths { get; set; }

		[DataMember(Name="reoId", EmitDefaultValue=false)]
		public string ReoId { get; set; }

		[DataMember(Name="requestId", EmitDefaultValue=false)]
		public string RequestId { get; set; }

		[DataMember(Name="subjectLoanResubordinationIndicator", EmitDefaultValue=false)]
		public bool? SubjectLoanResubordinationIndicator { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="titleFax", EmitDefaultValue=false)]
		public string TitleFax { get; set; }

		[DataMember(Name="titlePhone", EmitDefaultValue=false)]
		public string TitlePhone { get; set; }

		[DataMember(Name="toBePaidOffAmount", EmitDefaultValue=false)]
		public double? ToBePaidOffAmount { get; set; }

		[DataMember(Name="uCDPayoffType", EmitDefaultValue=false)]
		public string UCDPayoffType { get; set; }

		[DataMember(Name="unpaidBalanceAmount", EmitDefaultValue=false)]
		public double? UnpaidBalanceAmount { get; set; }

		[DataMember(Name="volIndex", EmitDefaultValue=false)]
		public int? VolIndex { get; set; }

	}
}