using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class VolContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "accountIdentifier")]
        public string AccountIdentifier { get; set; }

        [DataMember(Name = "attention")]
        public string Attention { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "exclusionIndicator")]
        public bool? ExclusionIndicator { get; set; }

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

        [DataMember(Name = "liabilityType")]
        public string LiabilityType { get; set; }

        [DataMember(Name = "monthlyPaymentAmount")]
        public decimal? MonthlyPaymentAmount { get; set; }

        [DataMember(Name = "monthsToExclude")]
        public int? MonthsToExclude { get; set; }

        [DataMember(Name = "nameInAccount")]
        public string NameInAccount { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "payoffStatusIndicator")]
        public bool? PayoffStatusIndicator { get; set; }

        [DataMember(Name = "prepaymentPenaltyAmount")]
        public decimal? PrepaymentPenaltyAmount { get; set; }

        [DataMember(Name = "printAttachmentIndicator")]
        public bool? PrintAttachmentIndicator { get; set; }

        [DataMember(Name = "remainingTermMonths")]
        public int? RemainingTermMonths { get; set; }

        [DataMember(Name = "reoProperty")]
        public EntityReferenceContract ReoProperty { get; set; }

        [DataMember(Name = "subjectLoanResubordinationIndicator")]
        public bool? SubjectLoanResubordinationIndicator { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "titleFax")]
        public string TitleFax { get; set; }

        [DataMember(Name = "titlePhone")]
        public string TitlePhone { get; set; }

        [DataMember(Name = "toBePaidOffAmount")]
        public decimal? ToBePaidOffAmount { get; set; }

        [DataMember(Name = "unpaidBalanceAmount")]
        public decimal? UnpaidBalanceAmount { get; set; }

        [DataMember(Name = "descriptionOfPurpose")]
        public string DescriptionOfPurpose { get; set; }

        [DataMember(Name = "isDebtNotSecuredToSubjectPropertyIndicator")]
        public bool? IsDebtNotSecuredToSubjectPropertyIndicator { get; set; }

        [DataMember(Name = "ucdPayoffType")]
        public string UcdPayoffType { get; set; }

        [DataMember(Name = "payoffIncludedIndicator")]
        public bool? PayoffIncludedIndicator { get; set; }

        [DataMember(Name = "printUserNameIndicator")]
        public bool? PrintUserNameIndicator { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }

        [DataMember(Name = "lates12Month30Day")]
        public int? Lates12Month30Day { get; set; }

        [DataMember(Name = "lates24Month30Day")]
        public int? Lates24Month30Day { get; set; }

        [DataMember(Name = "lates25Month30Day")]
        public int? Lates25Month30Day { get; set; }

        [DataMember(Name = "lates12Month60Day")]
        public int? Lates12Month60Day { get; set; }

        [DataMember(Name = "lates24Month60Day")]
        public int? Lates24Month60Day { get; set; }

        [DataMember(Name = "lates25Month60Day")]
        public int? Lates25Month60Day { get; set; }

        [DataMember(Name = "lates12Month90Day")]
        public int? Lates12Month90Day { get; set; }

        [DataMember(Name = "lates24Month90Day")]
        public int? Lates24Month90Day { get; set; }

        [DataMember(Name = "lates25Month90Day")]
        public int? Lates25Month90Day { get; set; }

        [DataMember(Name = "lates12Month120Day")]
        public int? Lates12Month120Day { get; set; }

        [DataMember(Name = "lates24Month120Day")]
        public int? Lates24Month120Day { get; set; }

        [DataMember(Name = "lates25Month120Day")]
        public int? Lates25Month120Day { get; set; }

        [DataMember(Name = "lates12Month150Day")]
        public int? Lates12Month150Day { get; set; }

        [DataMember(Name = "lates24Month150Day")]
        public int? Lates24Month150Day { get; set; }

        [DataMember(Name = "lates25Month150Day")]
        public int? Lates25Month150Day { get; set; }

        [DataMember(Name = "subjectPropertyIndicator")]
        public bool? SubjectPropertyIndicator { get; set; }

        [DataMember(Name = "currentLienPosition")]
        public string CurrentLienPosition { get; set; }

        [DataMember(Name = "proposedLienPosition")]
        public string ProposedLienPosition { get; set; }

        [DataMember(Name = "bankLiabilityConsideredIndicator")]
        public bool? BankLiabilityConsideredIndicator { get; set; }

        [DataMember(Name = "creditLimit")]
        public decimal? CreditLimit { get; set; }

        [DataMember(Name = "includeTaxesAndInsuranceIndicator")]
        public bool? IncludeTaxesAndInsuranceIndicator { get; set; }

        [DataMember(Name = "mortgageType")]
        public string MortgageType { get; set; }

        [DataMember(Name = "otherDescription")]
        public string OtherDescription { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }
    }

    [DataContract]
    public class VolContractFull : VolContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }

        [DataMember(Name = "noLinkToDocTrackIndicator")]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        [DataMember(Name = "requestId")]
        public string RequestId { get; set; }

    }
}
