using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class SelfEmployedIncomeContract
    {
        [DataMember(Name = "boolFieldValue")]
        public bool? BoolFieldValue { get; set; }

        [DataMember(Name = "fieldName")]
        public string FieldName { get; set; }

        [DataMember(Name = "fieldValue")]
        public string FieldValue { get; set; }

        [DataMember(Name = "firstYearAmount")]
        public decimal? FirstYearAmount { get; set; }

        [DataMember(Name = "formType")]
        public string FormType { get; set; }

        [DataMember(Name = "secondYearAmount")]
        public decimal? SecondYearAmount { get; set; }

        [DataMember(Name = "businessName")]
        public string BusinessName { get; set; }

    }
}
