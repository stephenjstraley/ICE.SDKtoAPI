using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AiqContract
    {
        [DataMember(Name = "folderId")]
        public string FolderId { get; set; }

        [DataMember(Name = "threadId")]
        public string ThreadId { get; set; }

        [DataMember(Name = "cabinetId")]
        public string CabinetId { get; set; }

        [DataMember(Name = "inFlightLoanId")]
        public string InFlightLoanId { get; set; }

        [DataMember(Name = "segmentId")]
        public string SegmentId { get; set; }

        [DataMember(Name = "loanWasMirroredOnPst")]
        public string LoanWasMirroredOnPst { get; set; }

        [DataMember(Name = "lastUpdateByLisInPst")]
        public string LastUpdateByLisInPst { get; set; }

        [DataMember(Name = "propagateData")]
        public string PropagateData { get; set; }

        [DataMember(Name = "docMirrorInFlight")]
        public string DocMirrorInFlight { get; set; }

        [DataMember(Name = "aiqSiteId")]
        public string AiqSiteId { get; set; }
    }
}
