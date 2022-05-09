using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureRecipientTrackingContract
    {
        [DataMember(Name = "viewConsentDate")]
        public string ViewConsentDate { get; set; }

        [DataMember(Name = "viewMessageDate")]
        public string ViewMessageDate { get; set; }

        [DataMember(Name = "viewESignedDate")]
        public string ViewESignedDate { get; set; }

        [DataMember(Name = "viewWetSignedDate")]
        public string ViewWetSignedDate { get; set; }

        [DataMember(Name = "acceptConsentDate")]
        public string AcceptConsentDate { get; set; }

        [DataMember(Name = "acceptConsentIP")]
        public string AcceptConsentIP { get; set; }

        [DataMember(Name = "rejectConsentDate")]
        public string RejectConsentDate { get; set; }

        [DataMember(Name = "rejectConsentIP")]
        public string RejectConsentIP { get; set; }

        [DataMember(Name = "authenticatedDate")]
        public string AuthenticatedDate { get; set; }

        [DataMember(Name = "authenticatedIP")]
        public string AuthenticatedIP { get; set; }

        [DataMember(Name = "eSignedDate")]
        public string ESignedDate { get; set; }

        [DataMember(Name = "eSignedIP")]
        public string ESignedIP { get; set; }

        [DataMember(Name = "wetSignedDate")]
        public string WetSignedDate { get; set; }

        [DataMember(Name = "loanLevelConsent")]
        public string LoanLevelConsent { get; set; }
    }
}
