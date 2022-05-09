using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureTrackingLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "alerts")]
        public List<LogAlertContract> Alerts { get; set; }

        [DataMember(Name = "borrowerPairId")]
        public string BorrowerPairId { get; set; }

        [DataMember(Name = "commentList")]
        public List<LogCommentContract> CommentList { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "containGfe")]
        public bool? ContainGfe { get; set; }

        [DataMember(Name = "containSafeHarbor")]
        public bool? ContainSafeHarbor { get; set; }

        [DataMember(Name = "containTil")]
        public bool? ContainTil { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "disclosedBy")]
        public string DisclosedBy { get; set; }

        [DataMember(Name = "disclosedByFullName")]
        public string DisclosedByFullName { get; set; }

        [DataMember(Name = "disclosedMethod")]
        public string DisclosedMethod { get; set; }

        [DataMember(Name = "disclosureCreatedDateTime")]
        public string DisclosureCreatedDateTime { get; set; }

        [DataMember(Name = "eDisclosureApplicationPackageIndicator")]
        public bool? EDisclosureApplicationPackageIndicator { get; set; }

        [DataMember(Name = "eDisclosureApprovalPackageIndicator")]
        public bool? EDisclosureApprovalPackageIndicator { get; set; }

        [DataMember(Name = "eDisclosureBorrowerAcceptConsentDate")]
        public string EDisclosureBorrowerAcceptConsentDate { get; set; }

        [DataMember(Name = "eDisclosureBorrowereSignedDate")]
        public string EDisclosureBorrowereSignedDate { get; set; }

        [DataMember(Name = "eDisclosureBorrowerRejectConsentDate")]
        public string EDisclosureBorrowerRejectConsentDate { get; set; }

        [DataMember(Name = "eDisclosureBorrowerViewConsentDate")]
        public string EDisclosureBorrowerViewConsentDate { get; set; }

        [DataMember(Name = "eDisclosureBorrowerViewMessageDate")]
        public string EDisclosureBorrowerViewMessageDate { get; set; }

        [DataMember(Name = "eDisclosureBorrowerWetSignedDate")]
        public string EDisclosureBorrowerWetSignedDate { get; set; }

        [DataMember(Name = "eDisclosureCoBorrowerAcceptConsentDate")]
        public string EDisclosureCoBorrowerAcceptConsentDate { get; set; }

        [DataMember(Name = "eDisclosureCoBorrowereSignedDate")]
        public string EDisclosureCoBorrowereSignedDate { get; set; }

        [DataMember(Name = "eDisclosureCoBorrowerRejectConsentDate")]
        public string EDisclosureCoBorrowerRejectConsentDate { get; set; }

        [DataMember(Name = "eDisclosureCoBorrowerViewConsentDate")]
        public string EDisclosureCoBorrowerViewConsentDate { get; set; }

        [DataMember(Name = "eDisclosureCoBorrowerViewMessageDate")]
        public string EDisclosureCoBorrowerViewMessageDate { get; set; }

        [DataMember(Name = "eDisclosureCoBorrowerWebSignedDate")]
        public string EDisclosureCoBorrowerWebSignedDate { get; set; }

        [DataMember(Name = "eDisclosureConsentPdf")]
        public string EDisclosureConsentPdf { get; set; }

        [DataMember(Name = "eDisclosureDisclosedMessage")]
        public string EDisclosureDisclosedMessage { get; set; }

        [DataMember(Name = "eDisclosureLockPackageIndicator")]
        public bool? EDisclosureLockPackageIndicator { get; set; }

        [DataMember(Name = "eDisclosureManualFulfillmentComment")]
        public string EDisclosureManualFulfillmentComment { get; set; }

        [DataMember(Name = "eDisclosureManualFulfillmentDate")]
        public string EDisclosureManualFulfillmentDate { get; set; }

        [DataMember(Name = "eDisclosureManualFulfillmentMethod")]
        public string EDisclosureManualFulfillmentMethod { get; set; }

        [DataMember(Name = "eDisclosureManuallyFulfilledBy")]
        public string EDisclosureManuallyFulfilledBy { get; set; }

        [DataMember(Name = "eDisclosurePackageCreatedDate")]
        public string EDisclosurePackageCreatedDate { get; set; }

        [DataMember(Name = "eDisclosurePackageId")]
        public string EDisclosurePackageId { get; set; }

        [DataMember(Name = "eDisclosurePackageViewableFile")]
        public string EDisclosurePackageViewableFile { get; set; }

        [DataMember(Name = "eDisclosureThreeDayPackageIndicator")]
        public bool? EDisclosureThreeDayPackageIndicator { get; set; }

        [DataMember(Name = "forms")]
        public List<DisclosureFormContract> Forms { get; set; }

        [DataMember(Name = "fulfillmentOrderedBy")]
        public string FulfillmentOrderedBy { get; set; }

        [DataMember(Name = "fulfillmentProcessedDate")]
        public string FulfillmentProcessedDate { get; set; }

        [DataMember(Name = "isDisclosed")]
        public string IsDisclosed { get; set; }

        [DataMember(Name = "isDisclosedAprLocked")]
        public string IsDisclosedAprLocked { get; set; }

        [DataMember(Name = "isDisclosedByLocked")]
        public string IsDisclosedByLocked { get; set; }

        [DataMember(Name = "isDisclosedFinanceChargeLocked")]
        public string IsDisclosedFinanceChargeLocked { get; set; }

        [DataMember(Name = "isDisclosedReceivedDateLocked")]
        public string IsDisclosedReceivedDateLocked { get; set; }

        [DataMember(Name = "isLocked")]
        public string IsLocked { get; set; }

        [DataMember(Name = "isWetSignedIndicator")]
        public bool? IsWetSignedIndicator { get; set; }

        [DataMember(Name = "lockedDisclosedAprField")]
        public string LockedDisclosedAprField { get; set; }

        [DataMember(Name = "lockedDisclosedByField")]
        public string LockedDisclosedByField { get; set; }

        [DataMember(Name = "lockedDisclosedFinanceChargeField")]
        public string LockedDisclosedFinanceChargeField { get; set; }

        [DataMember(Name = "lockedDisclosedReceivedDate")]
        public string LockedDisclosedReceivedDate { get; set; }

        [DataMember(Name = "manuallyCreated")]
        public string ManuallyCreated { get; set; }

        [DataMember(Name = "receivedDate")]
        public string ReceivedDate { get; set; }

        [DataMember(Name = "snapshotFields")]
        public List<LogSnapshotFieldContract> SnapshotFields { get; set; }

        [DataMember(Name = "applicationDate")]
        public string ApplicationDate { get; set; }

        [DataMember(Name = "borrowerName")]
        public string BorrowerName { get; set; }

        [DataMember(Name = "coBorrowerName")]
        public string CoBorrowerName { get; set; }

        [DataMember(Name = "disclosedApr")]
        public string DisclosedApr { get; set; }

        [DataMember(Name = "financeCharge")]
        public string FinanceCharge { get; set; }

        [DataMember(Name = "loanProgram")]
        public string LoanProgram { get; set; }

        [DataMember(Name = "loanAmount")]
        public string LoanAmount { get; set; }

        [DataMember(Name = "propertyAddress")]
        public string PropertyAddress { get; set; }

        [DataMember(Name = "propertyCity")]
        public string PropertyCity { get; set; }

        [DataMember(Name = "propertyState")]
        public string PropertyState { get; set; }

        [DataMember(Name = "propertyZip")]
        public string PropertyZip { get; set; }
    }
}
