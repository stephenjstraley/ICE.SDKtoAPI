using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTax4506
	{
		[DataMember(Name="accountTranscript")]
		public bool? AccountTranscript { get; set; }

		[DataMember(Name="address")]
		public string Address { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="costForEachPeriod")]
		public decimal? CostForEachPeriod { get; set; }

		[DataMember(Name="currentFirst")]
		public string CurrentFirst { get; set; }

		[DataMember(Name="currentLast")]
		public string CurrentLast { get; set; }

		[DataMember(Name="first")]
		public string First { get; set; }

		[DataMember(Name="formsSeriesTranscript")]
		public bool? FormsSeriesTranscript { get; set; }

		[DataMember(Name="historyId")]
		public string HistoryId { get; set; }

		[DataMember(Name="historyIndicator")]
		public bool? HistoryIndicator { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="ifTaxRecordNotFound")]
		public bool? IfTaxRecordNotFound { get; set; }

		[DataMember(Name="last")]
		public string Last { get; set; }

		[DataMember(Name="lastUpdatedDate")]
		public DateTime? LastUpdatedDate { get; set; }

		[DataMember(Name="lastUpdatedHistory")]
		public int? LastUpdatedHistory { get; set; }

		[DataMember(Name="lastUpdatedTime")]
		public string LastUpdatedTime { get; set; }

		[DataMember(Name="notifiedIrsIdentityTheftIndicator")]
		public bool? NotifiedIrsIdentityTheftIndicator { get; set; }

		[DataMember(Name="numberOfPeriods")]
		public int? NumberOfPeriods { get; set; }

		[DataMember(Name="person")]
		public string Person { get; set; }

		[DataMember(Name="recordOfAccount")]
		public bool? RecordOfAccount { get; set; }

		[DataMember(Name="requestorPhoneNumber")]
		public string RequestorPhoneNumber { get; set; }

		[DataMember(Name="requestorTitle")]
		public string RequestorTitle { get; set; }

		[DataMember(Name="requestYear1")]
		public DateTime? RequestYear1 { get; set; }

		[DataMember(Name="requestYear2")]
		public DateTime? RequestYear2 { get; set; }

		[DataMember(Name="requestYear3")]
		public DateTime? RequestYear3 { get; set; }

		[DataMember(Name="requestYear4")]
		public DateTime? RequestYear4 { get; set; }

		[DataMember(Name="requestYear5")]
		public DateTime? RequestYear5 { get; set; }

		[DataMember(Name="requestYear6")]
		public DateTime? RequestYear6 { get; set; }

		[DataMember(Name="requestYear7")]
		public DateTime? RequestYear7 { get; set; }

		[DataMember(Name="requestYear8")]
		public DateTime? RequestYear8 { get; set; }

		[DataMember(Name="returnAddress")]
		public string ReturnAddress { get; set; }

		[DataMember(Name="returnCity")]
		public string ReturnCity { get; set; }

		[DataMember(Name="returnState")]
		public string ReturnState { get; set; }

		[DataMember(Name="returnTranscript")]
		public bool? ReturnTranscript { get; set; }

		[DataMember(Name="returnZip")]
		public string ReturnZip { get; set; }

		[DataMember(Name="selectedRecordNumber")]
		public string SelectedRecordNumber { get; set; }

		[DataMember(Name="sendAddress")]
		public string SendAddress { get; set; }

		[DataMember(Name="sendCity")]
		public string SendCity { get; set; }

		[DataMember(Name="sendFirst")]
		public string SendFirst { get; set; }

		[DataMember(Name="sendLast")]
		public string SendLast { get; set; }

		[DataMember(Name="sendPhone")]
		public string SendPhone { get; set; }

		[DataMember(Name="sendState")]
		public string SendState { get; set; }

		[DataMember(Name="sendZip")]
		public string SendZip { get; set; }

		[DataMember(Name="signatoryAttestation")]
		public bool? SignatoryAttestation { get; set; }

		[DataMember(Name="signatoryAttestationT")]
		public bool? SignatoryAttestationT { get; set; }

		[DataMember(Name="spouseFirst")]
		public string SpouseFirst { get; set; }

		[DataMember(Name="spouseLast")]
		public string SpouseLast { get; set; }

		[DataMember(Name="spouseSSN")]
		public string SpouseSSN { get; set; }

		[DataMember(Name="spouseUseEIN")]
		public bool? SpouseUseEIN { get; set; }

		[DataMember(Name="sSN")]
		public string SSN { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

		[DataMember(Name="tax4506Index")]
		public int? Tax4506Index { get; set; }

		[DataMember(Name="tax4506TIndicator")]
		public bool? Tax4506TIndicator { get; set; }

		[DataMember(Name="taxFormNumber")]
		public string TaxFormNumber { get; set; }

		[DataMember(Name="theseCopiesMustBeCertified")]
		public bool? TheseCopiesMustBeCertified { get; set; }

		[DataMember(Name="totalCost")]
		public decimal? TotalCost { get; set; }

		[DataMember(Name="useEIN")]
		public bool? UseEIN { get; set; }

		[DataMember(Name="useWellsFargoRules")]
		public bool? UseWellsFargoRules { get; set; }

		[DataMember(Name="verificationOfNonfiling")]
		public bool? VerificationOfNonfiling { get; set; }

		[DataMember(Name="zip")]
		public string Zip { get; set; }

		[DataMember(Name = "irs4506C")]
		public bool? Irs4506C { get; set; }

	}
}