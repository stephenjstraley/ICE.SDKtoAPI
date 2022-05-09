using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ClosingDisclosure5Contract
    {
        [DataMember(Name = "totalPayments")]
        public decimal? TotalPayments { get; set; }

        [DataMember(Name = "cdLiabilityAfterForeclosure")]
        public string CdLiabilityAfterForeclosure { get; set; }

        [DataMember(Name = "lenderName")]
        public string LenderName { get; set; }

        [DataMember(Name = "lenderAddress")]
        public string LenderAddress { get; set; }

        [DataMember(Name = "lenderCity")]
        public string LenderCity { get; set; }

        [DataMember(Name = "lenderState")]
        public string LenderState { get; set; }

        [DataMember(Name = "lenderZip")]
        public string LenderZip { get; set; }

        [DataMember(Name = "lenderNmlsId")]
        public string LenderNmlsId { get; set; }

        [DataMember(Name = "lenderStLicenseId")]
        public string LenderStLicenseId { get; set; }

        [DataMember(Name = "lenderContact")]
        public string LenderContact { get; set; }

        [DataMember(Name = "lenderContactNmlsId")]
        public string LenderContactNmlsId { get; set; }

        [DataMember(Name = "lenderContactAtLicenseId")]
        public string LenderContactAtLicenseId { get; set; }

        [DataMember(Name = "lenderEmail")]
        public string LenderEmail { get; set; }

        [DataMember(Name = "lenderPhone")]
        public string LenderPhone { get; set; }

        [DataMember(Name = "mortgageBrokerName")]
        public string MortgageBrokerName { get; set; }

        [DataMember(Name = "mortgageBrokerAddress")]
        public string MortgageBrokerAddress { get; set; }

        [DataMember(Name = "mortgageBrokerCity")]
        public string MortgageBrokerCity { get; set; }

        [DataMember(Name = "mortgageBrokerState")]
        public string MortgageBrokerState { get; set; }

        [DataMember(Name = "mortgageBrokerZip")]
        public string MortgageBrokerZip { get; set; }

        [DataMember(Name = "mortgageBrokerNmlsId")]
        public string MortgageBrokerNmlsId { get; set; }

        [DataMember(Name = "mortgageBrokerStLicenseId")]
        public string MortgageBrokerStLicenseId { get; set; }

        [DataMember(Name = "mortgageBrokerContact")]
        public string MortgageBrokerContact { get; set; }

        [DataMember(Name = "mortgageBrokerContactNmlsId")]
        public string MortgageBrokerContactNmlsId { get; set; }

        [DataMember(Name = "mortgageBrokerContactAtLicenseId")]
        public string MortgageBrokerContactAtLicenseId { get; set; }

        [DataMember(Name = "mortgageBrokerEmail")]
        public string MortgageBrokerEmail { get; set; }

        [DataMember(Name = "mortgageBrokerPhone")]
        public string MortgageBrokerPhone { get; set; }

        [DataMember(Name = "realEstateBrokerBName")]
        public string RealEstateBrokerBName { get; set; }

        [DataMember(Name = "realEstateBrokerBAddress")]
        public string RealEstateBrokerBAddress { get; set; }

        [DataMember(Name = "realEstateBrokerBCity")]
        public string RealEstateBrokerBCity { get; set; }

        [DataMember(Name = "realEstateBrokerBState")]
        public string RealEstateBrokerBState { get; set; }

        [DataMember(Name = "realEstateBrokerBZip")]
        public string RealEstateBrokerBZip { get; set; }

        [DataMember(Name = "realEstateBrokerBNmlsId")]
        public string RealEstateBrokerBNmlsId { get; set; }

        [DataMember(Name = "realEstateBrokerBStLicenseId")]
        public string RealEstateBrokerBStLicenseId { get; set; }

        [DataMember(Name = "realEstateBrokerBContact")]
        public string RealEstateBrokerBContact { get; set; }

        [DataMember(Name = "realEstateBrokerBContactNmlsId")]
        public string RealEstateBrokerBContactNmlsId { get; set; }

        [DataMember(Name = "realEstateBrokerBContactAtLicenseId")]
        public string RealEstateBrokerBContactAtLicenseId { get; set; }

        [DataMember(Name = "realEstateBrokerBEmail")]
        public string RealEstateBrokerBEmail { get; set; }

        [DataMember(Name = "realEstateBrokerBPhone")]
        public string RealEstateBrokerBPhone { get; set; }

        [DataMember(Name = "realEstateBrokerSName")]
        public string RealEstateBrokerSName { get; set; }

        [DataMember(Name = "realEstateBrokerSAddress")]
        public string RealEstateBrokerSAddress { get; set; }

        [DataMember(Name = "realEstateBrokerSCity")]
        public string RealEstateBrokerSCity { get; set; }

        [DataMember(Name = "realEstateBrokerSState")]
        public string RealEstateBrokerSState { get; set; }

        [DataMember(Name = "realEstateBrokerSZip")]
        public string RealEstateBrokerSZip { get; set; }

        [DataMember(Name = "realEstateBrokerSNmlsId")]
        public string RealEstateBrokerSNmlsId { get; set; }

        [DataMember(Name = "realEstateBrokerSStLicenseId")]
        public string RealEstateBrokerSStLicenseId { get; set; }

        [DataMember(Name = "realEstateBrokerSContact")]
        public string RealEstateBrokerSContact { get; set; }

        [DataMember(Name = "realEstateBrokerSContactNmlsId")]
        public string RealEstateBrokerSContactNmlsId { get; set; }

        [DataMember(Name = "realEstateBrokerSContactAtLicenseId")]
        public string RealEstateBrokerSContactAtLicenseId { get; set; }

        [DataMember(Name = "realEstateBrokerSEmail")]
        public string RealEstateBrokerSEmail { get; set; }

        [DataMember(Name = "realEstateBrokerSPhone")]
        public string RealEstateBrokerSPhone { get; set; }

        [DataMember(Name = "settlementAgentName")]
        public string SettlementAgentName { get; set; }

        [DataMember(Name = "settlementAgentAddress")]
        public string SettlementAgentAddress { get; set; }

        [DataMember(Name = "settlementAgentCity")]
        public string SettlementAgentCity { get; set; }

        [DataMember(Name = "settlementAgentState")]
        public string SettlementAgentState { get; set; }

        [DataMember(Name = "settlementAgentZip")]
        public string SettlementAgentZip { get; set; }

        [DataMember(Name = "settlementAgentNmlsId")]
        public string SettlementAgentNmlsId { get; set; }

        [DataMember(Name = "settlementAgentStLicenseId")]
        public string SettlementAgentStLicenseId { get; set; }

        [DataMember(Name = "settlementAgentContact")]
        public string SettlementAgentContact { get; set; }

        [DataMember(Name = "settlementAgentContactNmlsId")]
        public string SettlementAgentContactNmlsId { get; set; }

        [DataMember(Name = "settlementAgentContactAtLicenseId")]
        public string SettlementAgentContactAtLicenseId { get; set; }

        [DataMember(Name = "settlementAgentEmail")]
        public string SettlementAgentEmail { get; set; }

        [DataMember(Name = "settlementAgentPhone")]
        public string SettlementAgentPhone { get; set; }

        [DataMember(Name = "signatureType")]
        public string SignatureType { get; set; }
    }
}
