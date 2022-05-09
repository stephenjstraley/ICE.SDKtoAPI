using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class CreditReportContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }

        [DataMember(Name = "verifySsn")]
        public string VerifySsn { get; set; }

        [DataMember(Name = "dateOfBirth")]
        public string DateOfBirth { get; set; }

        [DataMember(Name = "creditReportCompany")]
        public string CreditReportCompany { get; set; }

        [DataMember(Name = "creditReportDate")]
        public string CreditReportDate { get; set; }

        [DataMember(Name = "creditReportId")]
        public string CreditReportId { get; set; }

        [DataMember(Name = "nonTraditionalCredit")]
        public bool? NonTraditionalCredit { get; set; }
    }
}
