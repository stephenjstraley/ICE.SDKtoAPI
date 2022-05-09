using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FundingContract
    {
        [DataMember(Name = "collateralSentDate")]
        public string CollateralSentDate { get; set; }

        [DataMember(Name = "funderName")]
        public string FunderName { get; set; }

        [DataMember(Name = "funderUrl")]
        public string FunderUrl { get; set; }

        [DataMember(Name = "fundingClearedBy")]
        public string FundingClearedBy { get; set; }

        [DataMember(Name = "fundingCloseDate")]
        public string FundingCloseDate { get; set; }

        [DataMember(Name = "fundingOrderDate")]
        public string FundingOrderDate { get; set; }

        [DataMember(Name = "fundingType")]
        public string FundingType { get; set; }

        [DataMember(Name = "fundsReleasedDate")]
        public string FundsReleasedDate { get; set; }

        [DataMember(Name = "fundsReleaseNumber")]
        public string FundsReleaseNumber { get; set; }

        [DataMember(Name = "fundsSentDate")]
        public string FundsSentDate { get; set; }

        [DataMember(Name = "fundsWireTo")]
        public string FundsWireTo { get; set; }

        [DataMember(Name = "sentToFunderDate")]
        public string SentToFunderDate { get; set; }

        [DataMember(Name = "wiredToAbaNumber")]
        public string WiredToAbaNumber { get; set; }

        [DataMember(Name = "wiredToAccountNumber")]
        public string WiredToAccountNumber { get; set; }

        [DataMember(Name = "wiredToForCreditTo")]
        public string WiredToForCreditTo { get; set; }

        [DataMember(Name = "wiredToForCreditTo1")]
        public string WiredToForCreditTo1 { get; set; }

        [DataMember(Name = "wiredToForCreditTo2")]
        public string WiredToForCreditTo2 { get; set; }

        [DataMember(Name = "wiredToForFurtherCreditTo1")]
        public string WiredToForFurtherCreditTo1 { get; set; }

        [DataMember(Name = "wiredToForFurtherCreditTo2")]
        public string WiredToForFurtherCreditTo2 { get; set; }

        [DataMember(Name = "fundingFees")]
        public string FundingFees { get; set; }

        [DataMember(Name = "wireAmount")]
        public decimal? WireAmount { get; set; }
    }
}
