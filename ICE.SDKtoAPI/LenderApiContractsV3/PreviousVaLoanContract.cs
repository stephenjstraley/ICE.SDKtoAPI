using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PreviousVaLoanContract
    {
        [DataMember(Name = "previousVaLoanIndex")]
        public int PreviousVaLoanIndex { get; set; }

        [DataMember(Name = "loanDate")]
        public string LoanDate { get; set; }

        [DataMember(Name = "soldDate")]
        public string SoldDate { get; set; }

        [DataMember(Name = "loanType")]
        public string LoanType { get; set; }

        [DataMember(Name = "propertyAddress")]
        public string PropertyAddress { get; set; }

        [DataMember(Name = "propertyCity")]
        public string PropertyCity { get; set; }

        [DataMember(Name = "propertyOwned")]
        public bool? PropertyOwned { get; set; }

        [DataMember(Name = "propertyPostalCode")]
        public string PropertyPostalCode { get; set; }

        [DataMember(Name = "propertyState")]
        public string PropertyState { get; set; }

        [DataMember(Name = "vaLoanNumber")]
        public string VaLoanNumber { get; set; }

    }
}
