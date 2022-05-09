using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class CorrOtherInsuranceContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }

        [DataMember(Name = "includedInMasterPolicyFlag")]
        public bool? IncludedInMasterPolicyFlag { get; set; }

        [DataMember(Name = "companyName")]
        public string CompanyName { get; set; }

        [DataMember(Name = "streetAddress")]
        public string StreetAddress { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "zipCode")]
        public string ZipCode { get; set; }

        [DataMember(Name = "contactName")]
        public string ContactName { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

        [DataMember(Name = "policyType")]
        public string PolicyType { get; set; }

        [DataMember(Name = "policyTypeOtherDesc")]
        public string PolicyTypeOtherDesc { get; set; }

        [DataMember(Name = "premiumAmount")]
        public decimal? PremiumAmount { get; set; }

        [DataMember(Name = "premiumDueDate")]
        public string PremiumDueDate { get; set; }

        [DataMember(Name = "replacementValue")]
        public decimal? ReplacementValue { get; set; }

        [DataMember(Name = "escrowedFlag")]
        public bool? EscrowedFlag { get; set; }

        [DataMember(Name = "addlCoverageAmount")]
        public decimal? AddlCoverageAmount { get; set; }

        [DataMember(Name = "propertyValueUsed")]
        public decimal? PropertyValueUsed { get; set; }

        [DataMember(Name = "guaranteedReplacementCostFlag")]
        public bool? GuaranteedReplacementCostFlag { get; set; }

        [DataMember(Name = "insuranceEstimatorFlag")]
        public bool? InsuranceEstimatorFlag { get; set; }

        [DataMember(Name = "maxDeductiblePerc")]
        public decimal? MaxDeductiblePerc { get; set; }

        [DataMember(Name = "maxDeductibleAmount")]
        public decimal? MaxDeductibleAmount { get; set; }

        [DataMember(Name = "policyNumber")]
        public string PolicyNumber { get; set; }

        [DataMember(Name = "effectiveDate")]
        public string EffectiveDate { get; set; }

        [DataMember(Name = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember(Name = "coverageAmount")]
        public decimal? CoverageAmount { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }
    }
}
