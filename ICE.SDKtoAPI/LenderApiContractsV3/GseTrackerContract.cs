using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GseTrackerContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "duFindingsMessageId")]
        public string DuFindingsMessageId { get; set; }

        [DataMember(Name = "duFindingsMessageText")]
        public string DuFindingsMessageText { get; set; }

        [DataMember(Name = "gseCloseByDate")]
        public string GseCloseByDate { get; set; }

        [DataMember(Name = "recordTypeId")]
        public string RecordTypeId { get; set; }

        [DataMember(Name = "gseCloseByDate2")]
        public string GseCloseByDate2 { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
