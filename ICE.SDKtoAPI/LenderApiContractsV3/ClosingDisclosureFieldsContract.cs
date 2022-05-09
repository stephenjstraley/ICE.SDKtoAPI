using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ClosingDisclosureFieldsContract
    {
        [DataMember(Name = "isChangeInAPR")]
        public bool? IsChangeInAPR { get; set; }

        [DataMember(Name = "isChangeInLoanProduct")]
        public bool? IsChangeInLoanProduct { get; set; }

        [DataMember(Name = "isPrepaymentPenaltyAdded")]
        public bool? IsPrepaymentPenaltyAdded { get; set; }

        [DataMember(Name = "isChangeInSettlementCharges")]
        public bool? IsChangeInSettlementCharges { get; set; }

        [DataMember(Name = "is24HourAdvancePreview")]
        public bool? Is24HourAdvancePreview { get; set; }

        [DataMember(Name = "isToleranceCure")]
        public bool? IsToleranceCure { get; set; }

        [DataMember(Name = "isClericalErrorCorrection")]
        public bool? IsClericalErrorCorrection { get; set; }

        [DataMember(Name = "isChangedCircumstanceEligibility")]
        public bool? IsChangedCircumstanceEligibility { get; set; }

        [DataMember(Name = "isInterestRateDependentCharges")]
        public bool? IsInterestRateDependentCharges { get; set; }

        [DataMember(Name = "isRevisionsRequestedByConsumer")]
        public bool? IsRevisionsRequestedByConsumer { get; set; }

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
