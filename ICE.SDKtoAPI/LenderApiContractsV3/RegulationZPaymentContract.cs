using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class RegulationZPaymentContract
    {
        [DataMember(Name = "regulationZPaymentIndex")]
        public int RegulationZPaymentIndex { get; set; }

        [DataMember(Name = "balance")]
        public decimal? Balance { get; set; }

        [DataMember(Name = "interestRatePercent")]
        public decimal? InterestRatePercent { get; set; }

        [DataMember(Name = "monthlyPayment")]
        public decimal? MonthlyPayment { get; set; }

        [DataMember(Name = "numberOfPayments")]
        public int? NumberOfPayments { get; set; }

        [DataMember(Name = "paymentDate")]
        public string PaymentDate { get; set; }

    }
}
