using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class VodContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "attention")]
        public string Attention { get; set; }

        [DataMember(Name = "depositoryRequestDate")]
        public string DepositoryRequestDate { get; set; }

        [DataMember(Name = "holderAddressCity")]
        public string HolderAddressCity { get; set; }

        [DataMember(Name = "holderAddressPostalCode")]
        public string HolderAddressPostalCode { get; set; }

        [DataMember(Name = "holderAddressState")]
        public string HolderAddressState { get; set; }

        [DataMember(Name = "holderAddressStreetLine1")]
        public string HolderAddressStreetLine1 { get; set; }

        [DataMember(Name = "holderComments")]
        public string HolderComments { get; set; }

        [DataMember(Name = "holderEmail")]
        public string HolderEmail { get; set; }

        [DataMember(Name = "holderFax")]
        public string HolderFax { get; set; }

        [DataMember(Name = "holderName")]
        public string HolderName { get; set; }

        [DataMember(Name = "holderPhone")]
        public string HolderPhone { get; set; }

        [DataMember(Name = "includeInAusExport")]
        public bool? IncludeInAusExport { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "printAttachmentIndicator")]
        public bool? PrintAttachmentIndicator { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }

        [DataMember(Name = "printUserNameIndicator")]
        public bool? PrintUserNameIndicator { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "titleFax")]
        public string TitleFax { get; set; }

        [DataMember(Name = "titlePhone")]
        public string TitlePhone { get; set; }

        [DataMember(Name = "total")]
        public decimal? Total { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "items")]
        public List<VodItemContract> Items { get; set; }
    }

    [DataContract]
    public class VodContractFull : VodContract
    {
        [DataMember(Name = "noLinkToDocTrackIndicator")]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }

    }
}
