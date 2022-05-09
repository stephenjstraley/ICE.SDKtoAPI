using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnhancedDisclosureTracking2015LogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "provider")]
        public string Provider { get; set; }

        [DataMember(Name = "providerDescription")]
        public string ProviderDescription { get; set; }

        [DataMember(Name = "contents")]
        public List<object> Contents { get; set; }

        [DataMember(Name = "includedInTimeline")]
        public bool? IncludedInTimeline { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "disclosureType")]
        public string DisclosureType { get; set; }

        [DataMember(Name = "disclosedDate")]
        public string DisclosedDate { get; set; }

        [DataMember(Name = "disclosedBy")]
        public string DisclosedBy { get; set; }

        [DataMember(Name = "disclosedMethod")]
        public string DisclosedMethod { get; set; }

        [DataMember(Name = "disclosedMethodDescription")]
        public string DisclosedMethodDescription { get; set; }

        [DataMember(Name = "intentToProceed")]
        public string IntentToProceed { get; set; }

        [DataMember(Name = "disclosureRecipients")]
        public List<DisclosureRecipientContract> DisclosureRecipients { get; set; }

        [DataMember(Name = "disclosedDailyInterest")]
        public string DisclosedDailyInterest { get; set; }

        [DataMember(Name = "disclosedApr")]
        public string DisclosedApr { get; set; }

        [DataMember(Name = "disclosedFinanceCharge")]
        public string DisclosedFinanceCharge { get; set; }

        [DataMember(Name = "loanProgram")]
        public string LoanProgram { get; set; }

        [DataMember(Name = "loanAmount")]
        public decimal? LoanAmount { get; set; }

        [DataMember(Name = "disclosureCreatedDate")]
        public string DisclosureCreatedDate { get; set; }

        [DataMember(Name = "applicationDate")]
        public string ApplicationDate { get; set; }

        [DataMember(Name = "propertyAddress")]
        public string PropertyAddress { get; set; }

        [DataMember(Name = "feeLevelDisclosuresIndicator")]
        public bool? FeeLevelDisclosuresIndicator { get; set; }

        [DataMember(Name = "changedCircumstanceIndicator")]
        public bool? ChangedCircumstanceIndicator { get; set; }

        [DataMember(Name = "changeInCircumstance")]
        public string ChangeInCircumstance { get; set; }

        [DataMember(Name = "changeInCircumstanceComments")]
        public string ChangeInCircumstanceComments { get; set; }

        [DataMember(Name = "loanEstimate")]
        public string LoanEstimate { get; set; }

        [DataMember(Name = "closingDisclosure")]
        public string ClosingDisclosure { get; set; }

        [DataMember(Name = "tracking")]
        public string Tracking { get; set; }

        [DataMember(Name = "fulfillments")]
        public List<FulfillmentContract> Fulfillments { get; set; }

        [DataMember(Name = "linkedLogId")]
        public string LinkedLogId { get; set; }

        [DataMember(Name = "feeChanges")]
        public List<DisclosureFeeChangeContract> FeeChanges { get; set; }

        [DataMember(Name = "documents")]
        public string Documents { get; set; }

        [DataMember(Name = "snapshot")]
        public object Snapshot { get; set; }

        [DataMember(Name = "loanXml")]
        public string LoanXml { get; set; }
    }
}
