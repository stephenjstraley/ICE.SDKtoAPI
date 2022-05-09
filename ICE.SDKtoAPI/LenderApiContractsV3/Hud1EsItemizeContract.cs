using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Hud1EsItemizeContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "escrowPaymentBalance")]
        public decimal? EscrowPaymentBalance { get; set; }

        [DataMember(Name = "escrowPaymentDescription")]
        public string EscrowPaymentDescription { get; set; }

        [DataMember(Name = "escrowPaymentFrom")]
        public decimal? EscrowPaymentFrom { get; set; }

        [DataMember(Name = "escrowPaymentTo")]
        public decimal? EscrowPaymentTo { get; set; }

    }
}
