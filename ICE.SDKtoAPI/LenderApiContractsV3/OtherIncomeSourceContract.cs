using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class OtherIncomeSourceContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "otherIncomeSourceDate")]
        public string OtherIncomeSourceDate { get; set; }

        [DataMember(Name = "printAttachmentIndicator")]
        public bool? PrintAttachmentIndicator { get; set; }

        [DataMember(Name = "holderName")]
        public string HolderName { get; set; }

        [DataMember(Name = "attention")]
        public string Attention { get; set; }

        [DataMember(Name = "holderAddressStreetLine1")]
        public string HolderAddressStreetLine1 { get; set; }

        [DataMember(Name = "holderAddressCity")]
        public string HolderAddressCity { get; set; }

        [DataMember(Name = "holderAddressState")]
        public string HolderAddressState { get; set; }

        [DataMember(Name = "holderAddressPostalCode")]
        public string HolderAddressPostalCode { get; set; }

        [DataMember(Name = "holderPhone")]
        public string HolderPhone { get; set; }

        [DataMember(Name = "holderFax")]
        public string HolderFax { get; set; }

        [DataMember(Name = "titlePhone")]
        public string TitlePhone { get; set; }

        [DataMember(Name = "titleFax")]
        public string TitleFax { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "otherDescription")]
        public string OtherDescription { get; set; }

        [DataMember(Name = "foreignIncomeIndicator")]
        public bool? ForeignIncomeIndicator { get; set; }

        [DataMember(Name = "seasonalIncomeIndicator")]
        public bool? SeasonalIncomeIndicator { get; set; }

        [DataMember(Name = "monthlyAmount")]
        public decimal? MonthlyAmount { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }
    }

    [DataContract]
    public class OtherIncomeSourceContractFull : OtherIncomeSourceContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
