using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureFeeChangeContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "fieldId")]
        public string FieldId { get; set; }

        [DataMember(Name = "feeDescription")]
        public string FeeDescription { get; set; }

        [DataMember(Name = "changedCircumstance")]
        public string ChangedCircumstance { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "amount")]
        public string Amount { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }

        [DataMember(Name = "changesReceivedDate")]
        public string ChangesReceivedDate { get; set; }
    }
}
