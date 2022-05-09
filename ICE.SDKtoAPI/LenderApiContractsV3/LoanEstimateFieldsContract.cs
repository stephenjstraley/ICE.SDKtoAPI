using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LoanEstimateFieldsContract
    {
        [DataMember(Name = "isDisclosedByBroker")]
        public bool? IsDisclosedByBroker { get; set; }

        [DataMember(Name = "isChangedCircumstanceSettlementCharges")]
        public bool? IsChangedCircumstanceSettlementCharges { get; set; }

        [DataMember(Name = "isChangedCircumstanceEligibility")]
        public bool? IsChangedCircumstanceEligibility { get; set; }

        [DataMember(Name = "isRevisionsRequestedByConsumer")]
        public bool? IsRevisionsRequestedByConsumer { get; set; }

        [DataMember(Name = "isInterestRateDependentCharges")]
        public bool? IsInterestRateDependentCharges { get; set; }

        [DataMember(Name = "isExpiration")]
        public bool? IsExpiration { get; set; }

        [DataMember(Name = "isDelayedSettlementOnConstructionLoans")]
        public bool? IsDelayedSettlementOnConstructionLoans { get; set; }

        [DataMember(Name = "isOther")]
        public bool? IsOther { get; set; }

        [DataMember(Name = "otherDescription")]
        public string OtherDescription { get; set; }

        [DataMember(Name = "changesReceivedDate")]
        public string ChangesReceivedDate { get; set; }

        [DataMember(Name = "revisedDueDate")]
        public string RevisedDueDate { get; set; }

    }
}
