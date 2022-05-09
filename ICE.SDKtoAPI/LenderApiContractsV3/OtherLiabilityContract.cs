using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class OtherLiabilityContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "borrowerType")]
        public string BorrowerType { get; set; }

        [DataMember(Name = "liabilityOrExpenseType")]
        public string LiabilityOrExpenseType { get; set; }

        [DataMember(Name = "monthlyPayment")]
        public decimal? MonthlyPayment { get; set; }

        [DataMember(Name = "otherDescription")]
        public string OtherDescription { get; set; }

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

        [DataMember(Name = "holderEmail")]
        public string HolderEmail { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "printUserNameIndicator")]
        public bool? PrintUserNameIndicator { get; set; }

        [DataMember(Name = "titlePhone")]
        public string TitlePhone { get; set; }

        [DataMember(Name = "titleFax")]
        public string TitleFax { get; set; }

        [DataMember(Name = "printAttachmentIndicator")]
        public bool? PrintAttachmentIndicator { get; set; }

        [DataMember(Name = "depositoryRequestDate")]
        public string DepositoryRequestDate { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }

        [DataMember(Name = "monthsLeft")]
        public int? MonthsLeft { get; set; }

        [DataMember(Name = "balance")]
        public decimal? Balance { get; set; }

        [DataMember(Name = "creditLimit")]
        public decimal? CreditLimit { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }
    }

    [DataContract]
    public class OtherLiabilityContractFull : OtherAssetContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
