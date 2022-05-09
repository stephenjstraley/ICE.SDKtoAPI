using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Tax4506ClassicContract
    {
        [DataMember(Name = "accountTranscript")]
        public bool? AccountTranscript { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "authorizedSignor")]
        public string AuthorizedSignor { get; set; }

        [DataMember(Name = "authorizedSignorSpouse")]
        public string AuthorizedSignorSpouse { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "costForEachPeriod")]
        public decimal? CostForEachPeriod { get; set; }

        [DataMember(Name = "currentFirst")]
        public string CurrentFirst { get; set; }

        [DataMember(Name = "currentLast")]
        public string CurrentLast { get; set; }

        [DataMember(Name = "first")]
        public string First { get; set; }

        [DataMember(Name = "formsSeriesTranscript")]
        public bool? FormsSeriesTranscript { get; set; }

        [DataMember(Name = "historyId")]
        public string HistoryId { get; set; }

        [DataMember(Name = "ifTaxRecordNotFound")]
        public bool? IfTaxRecordNotFound { get; set; }

        [DataMember(Name = "irs4506C")]
        public bool? Irs4506C { get; set; }

        [DataMember(Name = "last")]
        public string Last { get; set; }

        [DataMember(Name = "lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [DataMember(Name = "lastUpdatedHistory")]
        public int? LastUpdatedHistory { get; set; }

        [DataMember(Name = "lastUpdatedTime")]
        public string LastUpdatedTime { get; set; }

        [DataMember(Name = "notifiedIrsIdentityTheftIndicator")]
        public bool? NotifiedIrsIdentityTheftIndicator { get; set; }

        [DataMember(Name = "numberOfPeriods")]
        public int? NumberOfPeriods { get; set; }

        [DataMember(Name = "person")]
        public string Person { get; set; }

        [DataMember(Name = "recordOfAccount")]
        public bool? RecordOfAccount { get; set; }

        [DataMember(Name = "requestorPhoneNumber")]
        public string RequestorPhoneNumber { get; set; }

        [DataMember(Name = "requestYear1")]
        public string RequestYear1 { get; set; }

        [DataMember(Name = "requestYear2")]
        public string RequestYear2 { get; set; }

        [DataMember(Name = "requestYear3")]
        public string RequestYear3 { get; set; }

        [DataMember(Name = "requestYear4")]
        public string RequestYear4 { get; set; }

        [DataMember(Name = "requestYear5")]
        public string RequestYear5 { get; set; }

        [DataMember(Name = "requestYear6")]
        public string RequestYear6 { get; set; }

        [DataMember(Name = "requestYear7")]
        public string RequestYear7 { get; set; }

        [DataMember(Name = "requestYear8")]
        public string RequestYear8 { get; set; }

        [DataMember(Name = "returnAddress")]
        public string ReturnAddress { get; set; }

        [DataMember(Name = "returnCity")]
        public string ReturnCity { get; set; }

        [DataMember(Name = "returnState")]
        public string ReturnState { get; set; }

        [DataMember(Name = "returnTranscript")]
        public bool? ReturnTranscript { get; set; }

        [DataMember(Name = "returnZip")]
        public string ReturnZip { get; set; }

        [DataMember(Name = "selectedRecordNumber")]
        public string SelectedRecordNumber { get; set; }

        [DataMember(Name = "sendAddress")]
        public string SendAddress { get; set; }

        [DataMember(Name = "sendCity")]
        public string SendCity { get; set; }

        [DataMember(Name = "sendFirst")]
        public string SendFirst { get; set; }

        [DataMember(Name = "sendLast")]
        public string SendLast { get; set; }

        [DataMember(Name = "sendPhone")]
        public string SendPhone { get; set; }

        [DataMember(Name = "sendState")]
        public string SendState { get; set; }

        [DataMember(Name = "sendZip")]
        public string SendZip { get; set; }

        [DataMember(Name = "spouseFirst")]
        public string SpouseFirst { get; set; }

        [DataMember(Name = "spouseLast")]
        public string SpouseLast { get; set; }

        [DataMember(Name = "spouseSsn")]
        public string SpouseSsn { get; set; }

        [DataMember(Name = "spouseUseEin")]
        public bool? SpouseUseEin { get; set; }

        [DataMember(Name = "ssn")]
        public string Ssn { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "taxFormNumber")]
        public string TaxFormNumber { get; set; }

        [DataMember(Name = "theseCopiesMustBeCertified")]
        public bool? TheseCopiesMustBeCertified { get; set; }

        [DataMember(Name = "totalCost")]
        public decimal? TotalCost { get; set; }

        [DataMember(Name = "useEin")]
        public bool? UseEin { get; set; }

        [DataMember(Name = "useWellsFargoRules")]
        public bool? UseWellsFargoRules { get; set; }

        [DataMember(Name = "verificationOfNonfiling")]
        public bool? VerificationOfNonfiling { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataMember(Name = "signatoryAttestation")]
        public bool? SignatoryAttestation { get; set; }

        [DataMember(Name = "signatoryAttestationT")]
        public bool? SignatoryAttestationT { get; set; }

        [DataMember(Name = "requestorTitle")]
        public string RequestorTitle { get; set; }

    }
}
