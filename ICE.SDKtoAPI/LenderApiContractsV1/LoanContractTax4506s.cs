using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTax4506s
	{
		[DataMember(Name="accountTranscript", EmitDefaultValue=false)]
		public bool? AccountTranscript { get; set; }

		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="costForEachPeriod", EmitDefaultValue=false)]
		public double? CostForEachPeriod { get; set; }

		[DataMember(Name="currentFirst", EmitDefaultValue=false)]
		public string CurrentFirst { get; set; }

		[DataMember(Name="currentLast", EmitDefaultValue=false)]
		public string CurrentLast { get; set; }

		[DataMember(Name="first", EmitDefaultValue=false)]
		public string First { get; set; }

		[DataMember(Name="formsSeriesTranscript", EmitDefaultValue=false)]
		public bool? FormsSeriesTranscript { get; set; }

		[DataMember(Name="historyId", EmitDefaultValue=false)]
		public string HistoryId { get; set; }

		[DataMember(Name="historyIndicator", EmitDefaultValue=false)]
		public bool? HistoryIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="ifTaxRecordNotFound", EmitDefaultValue=false)]
		public bool? IfTaxRecordNotFound { get; set; }

		[DataMember(Name="last", EmitDefaultValue=false)]
		public string Last { get; set; }

		[DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
		public DateTime? LastUpdatedDate { get; set; }

		[DataMember(Name="lastUpdatedHistory", EmitDefaultValue=false)]
		public int? LastUpdatedHistory { get; set; }

		[DataMember(Name="lastUpdatedTime", EmitDefaultValue=false)]
		public string LastUpdatedTime { get; set; }

		[DataMember(Name="notifiedIrsIdentityTheftIndicator", EmitDefaultValue=false)]
		public bool? NotifiedIrsIdentityTheftIndicator { get; set; }

		[DataMember(Name="numberOfPeriods", EmitDefaultValue=false)]
		public int? NumberOfPeriods { get; set; }

		[DataMember(Name="person", EmitDefaultValue=false)]
		public string Person { get; set; }

		[DataMember(Name="recordOfAccount", EmitDefaultValue=false)]
		public bool? RecordOfAccount { get; set; }

		[DataMember(Name="requestorPhoneNumber", EmitDefaultValue=false)]
		public string RequestorPhoneNumber { get; set; }

		[DataMember(Name="requestorTitle", EmitDefaultValue=false)]
		public string RequestorTitle { get; set; }

		[DataMember(Name="requestYear1", EmitDefaultValue=false)]
		public DateTime? RequestYear1 { get; set; }

		[DataMember(Name="requestYear2", EmitDefaultValue=false)]
		public DateTime? RequestYear2 { get; set; }

		[DataMember(Name="requestYear3", EmitDefaultValue=false)]
		public DateTime? RequestYear3 { get; set; }

		[DataMember(Name="requestYear4", EmitDefaultValue=false)]
		public DateTime? RequestYear4 { get; set; }

		[DataMember(Name="requestYear5", EmitDefaultValue=false)]
		public DateTime? RequestYear5 { get; set; }

		[DataMember(Name="requestYear6", EmitDefaultValue=false)]
		public DateTime? RequestYear6 { get; set; }

		[DataMember(Name="requestYear7", EmitDefaultValue=false)]
		public DateTime? RequestYear7 { get; set; }

		[DataMember(Name="requestYear8", EmitDefaultValue=false)]
		public DateTime? RequestYear8 { get; set; }

		[DataMember(Name="returnAddress", EmitDefaultValue=false)]
		public string ReturnAddress { get; set; }

		[DataMember(Name="returnCity", EmitDefaultValue=false)]
		public string ReturnCity { get; set; }

		[DataMember(Name="returnState", EmitDefaultValue=false)]
		public string ReturnState { get; set; }

		[DataMember(Name="returnTranscript", EmitDefaultValue=false)]
		public bool? ReturnTranscript { get; set; }

		[DataMember(Name="returnZip", EmitDefaultValue=false)]
		public string ReturnZip { get; set; }

		[DataMember(Name="selectedRecordNumber", EmitDefaultValue=false)]
		public string SelectedRecordNumber { get; set; }

		[DataMember(Name="sendAddress", EmitDefaultValue=false)]
		public string SendAddress { get; set; }

		[DataMember(Name="sendCity", EmitDefaultValue=false)]
		public string SendCity { get; set; }

		[DataMember(Name="sendFirst", EmitDefaultValue=false)]
		public string SendFirst { get; set; }

		[DataMember(Name="sendLast", EmitDefaultValue=false)]
		public string SendLast { get; set; }

		[DataMember(Name="sendPhone", EmitDefaultValue=false)]
		public string SendPhone { get; set; }

		[DataMember(Name="sendState", EmitDefaultValue=false)]
		public string SendState { get; set; }

		[DataMember(Name="sendZip", EmitDefaultValue=false)]
		public string SendZip { get; set; }

		[DataMember(Name="signatoryAttestation", EmitDefaultValue=false)]
		public bool? SignatoryAttestation { get; set; }

		[DataMember(Name="signatoryAttestationT", EmitDefaultValue=false)]
		public bool? SignatoryAttestationT { get; set; }

		[DataMember(Name="spouseFirst", EmitDefaultValue=false)]
		public string SpouseFirst { get; set; }

		[DataMember(Name="spouseLast", EmitDefaultValue=false)]
		public string SpouseLast { get; set; }

		[DataMember(Name="spouseSSN", EmitDefaultValue=false)]
		public string SpouseSSN { get; set; }

		[DataMember(Name="spouseUseEIN", EmitDefaultValue=false)]
		public bool? SpouseUseEIN { get; set; }

		[DataMember(Name="sSN", EmitDefaultValue=false)]
		public string SSN { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="tax4506Index", EmitDefaultValue=false)]
		public int? Tax4506Index { get; set; }

		[DataMember(Name="tax4506TIndicator", EmitDefaultValue=false)]
		public bool? Tax4506TIndicator { get; set; }

		[DataMember(Name="taxFormNumber", EmitDefaultValue=false)]
		public string TaxFormNumber { get; set; }

		[DataMember(Name="theseCopiesMustBeCertified", EmitDefaultValue=false)]
		public bool? TheseCopiesMustBeCertified { get; set; }

		[DataMember(Name="totalCost", EmitDefaultValue=false)]
		public double? TotalCost { get; set; }

		[DataMember(Name="useEIN", EmitDefaultValue=false)]
		public bool? UseEIN { get; set; }

		[DataMember(Name="useWellsFargoRules", EmitDefaultValue=false)]
		public bool? UseWellsFargoRules { get; set; }

		[DataMember(Name="verificationOfNonfiling", EmitDefaultValue=false)]
		public bool? VerificationOfNonfiling { get; set; }

		[DataMember(Name="zip", EmitDefaultValue=false)]
		public string Zip { get; set; }

	}
}