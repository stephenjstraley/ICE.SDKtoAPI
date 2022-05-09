using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class SelectedHomeCounselingProviderContract
    {
        [DataMember(Name = "selectedGuid")]
        public string SelectedGuid { get; set; }

        [DataMember(Name = "agencyName")]
        public string AgencyName { get; set; }

        [DataMember(Name = "agencyAddress")]
        public string AgencyAddress { get; set; }

        [DataMember(Name = "agencyAddressCity")]
        public string AgencyAddressCity { get; set; }

        [DataMember(Name = "agencyAddressState")]
        public string AgencyAddressState { get; set; }

        [DataMember(Name = "agencyAddressPostalCode")]
        public string AgencyAddressPostalCode { get; set; }

        [DataMember(Name = "agencyPhoneDirect")]
        public string AgencyPhoneDirect { get; set; }

        [DataMember(Name = "agencyPhoneTollFree")]
        public string AgencyPhoneTollFree { get; set; }

        [DataMember(Name = "agencyFax")]
        public string AgencyFax { get; set; }

        [DataMember(Name = "agencyEmail")]
        public string AgencyEmail { get; set; }

        [DataMember(Name = "agencyWebAddress")]
        public string AgencyWebAddress { get; set; }

        [DataMember(Name = "languagesSupported")]
        public string LanguagesSupported { get; set; }

        [DataMember(Name = "counselingServicesProvided")]
        public string CounselingServicesProvided { get; set; }

        [DataMember(Name = "agencyAffiliationDescription")]
        public string AgencyAffiliationDescription { get; set; }

        [DataMember(Name = "homeCounselingRequiredIndicator")]
        public bool? HomeCounselingRequiredIndicator { get; set; }

        [DataMember(Name = "homeCounselingCompletionDate")]
        public string HomeCounselingCompletionDate { get; set; }

        [DataMember(Name = "certificationIssuedIndicator")]
        public bool? CertificationIssuedIndicator { get; set; }

        [DataMember(Name = "homeCounselingDisclosureDate")]
        public string HomeCounselingDisclosureDate { get; set; }

        [DataMember(Name = "distanceMiles")]
        public decimal? DistanceMiles { get; set; }

        [DataMember(Name = "affiliatedWithLenderIndicator")]
        public bool? AffiliatedWithLenderIndicator { get; set; }

        [DataMember(Name = "borrowerSelectCounselorIndicator")]
        public bool? BorrowerSelectCounselorIndicator { get; set; }

        [DataMember(Name = "explanation")]
        public string Explanation { get; set; }

        [DataMember(Name = "homeCounselingGeneratedDate")]
        public string HomeCounselingGeneratedDate { get; set; }

    }
}
