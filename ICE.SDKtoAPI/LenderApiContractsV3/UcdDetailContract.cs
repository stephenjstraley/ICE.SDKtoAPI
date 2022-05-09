using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class UcdDetailContract
    {
        [DataMember(Name = "lineNumber")]
        public int LineNumber { get; set; }

        [DataMember(Name = "section")]
        public string Section { get; set; }

        [DataMember(Name = "feeIndex")]
        public int? FeeIndex { get; set; }

        [DataMember(Name = "feeAccountType")]
        public string FeeAccountType { get; set; }

        [DataMember(Name = "feeAmount")]
        public decimal? FeeAmount { get; set; }

        [DataMember(Name = "feeDateFrom")]
        public string FeeDateFrom { get; set; }

        [DataMember(Name = "feeDateTo")]
        public string FeeDateTo { get; set; }

        [DataMember(Name = "feeDesc")]
        public string FeeDesc { get; set; }

        [DataMember(Name = "feePoc")]
        public bool? FeePoc { get; set; }

        [DataMember(Name = "feePaidTo")]
        public string FeePaidTo { get; set; }

        [DataMember(Name = "feePaidBy")]
        public string FeePaidBy { get; set; }

    }
}
