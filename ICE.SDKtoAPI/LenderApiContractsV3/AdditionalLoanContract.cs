using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AdditionalLoanContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "borrowerType")]
        public string BorrowerType { get; set; }

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

        [DataMember(Name = "additionalLoanRequestDate")]
        public string AdditionalLoanRequestDate { get; set; }

        [DataMember(Name = "printAttachmentIndicator")]
        public bool? PrintAttachmentIndicator { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }

        [DataMember(Name = "accountType")]
        public string AccountType { get; set; }

        [DataMember(Name = "lienPosition")]
        public string LienPosition { get; set; }

        [DataMember(Name = "monthlyPrincipalAndInterest")]
        public decimal? MonthlyPrincipalAndInterest { get; set; }

        [DataMember(Name = "maximumPrincipalAndInterestIn5Years")]
        public decimal? MaximumPrincipalAndInterestIn5Years { get; set; }

        [DataMember(Name = "helocCreditLimitAmount")]
        public decimal? HelocCreditLimitAmount { get; set; }

        [DataMember(Name = "helocInitialDraw")]
        public decimal? HelocInitialDraw { get; set; }

        [DataMember(Name = "amountAppliedToDownpayment")]
        public decimal? AmountAppliedToDownpayment { get; set; }

        [DataMember(Name = "paymentDeferredFirstFiveYears")]
        public bool? PaymentDeferredFirstFiveYears { get; set; }
        [DataMember(Name = "affordableLoan")]
        public bool? AffordableLoan { get; set; }

        [DataMember(Name = "monthlyPiTerm")]
        public int? MonthlyPiTerm { get; set; }

        [DataMember(Name = "monthlyPiLoanAmount")]
        public decimal? MonthlyPiLoanAmount { get; set; }

        [DataMember(Name = "maximumPiNoteRate")]
        public decimal? MaximumPiNoteRate { get; set; }

        [DataMember(Name = "maximumPiTerm")]
        public int? MaximumPiTerm { get; set; }

        [DataMember(Name = "maximumPiLoanAmount")]
        public decimal? MaximumPiLoanAmount { get; set; }

        [DataMember(Name = "individualCreditorIndicator")]
        public bool? IndividualCreditorIndicator { get; set; }

        [DataMember(Name = "sourceOfFunds")]
        public string SourceOfFunds { get; set; }
    }

    [DataContract]
    public class AdditionalLoanContractFull : AdditionalLoanContract
    {
        [DataMember(Name = "linkedPiggybackIndicator")]
        public bool? LinkedPiggybackIndicator { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
