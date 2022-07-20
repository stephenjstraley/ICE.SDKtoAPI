using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class PlanCode
    {
        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "loanProgramtype")]
        public string LoanProgramType { get; set; }

        [DataMember(Name = "investorCode")]
        public string InvestorCode { get; set; }

        [DataMember(Name = "investorName")]
        public string InvestorName { get; set; }

        [DataMember(Name = "investorPlanCode")]
        public string InvestorPlanCode { get; set; }

        [DataMember(Name = "loanType")]
        public string LoanType { get; set; }

        [DataMember(Name = "amortizationType")]
        public string AmortizationType { get; set; }

        [DataMember(Name = "lienPosition")]
        public string LienPosition { get; set; }

        [DataMember(Name = "ballonLoan")]
        public bool? BallonLoan { get; set; }

        [DataMember(Name = "demandFeature")]
        public bool? DemandFeature { get; set; }

        [DataMember(Name = "biweeklylLoan")]
        public bool? BiWeeklyLoan { get; set; }

        [DataMember(Name = "interestOnly")]
        public bool? InterestOnly { get; set; }

        [DataMember(Name = "assumabilityType")]
        public bool? AssumabilityType { get; set; }

        [DataMember(Name = "planFirstChange")]
        public string PlanFirstchange { get; set; }

        [DataMember(Name = "subsequentChange")]
        public string SubsequentChange { get; set; }

        [DataMember(Name = "numberOfDaysPerYear")]
        public string NumberOfDasPerYear { get; set; }

        [DataMember(Name = "prepaymentPenalty")]
        public bool? PrepaymentPenalty { get; set; }

        [DataMember(Name = "roundingFactor")]
        public int? RoundingFactor { get; set; }

        [DataMember(Name = "roundingType")]
        public string RoundingType { get; set; }

        [DataMember(Name = "indexLookbackPeriod")]
        public string IndexLookbackPeriod { get; set; }

        [DataMember(Name = "isConvertible")]
        public bool? IsConvertible { get; set; }

        [DataMember(Name = "recordId")]
        public string RecordId { get; set; }

        [DataMember(Name = "isEmAlias")]
        public bool? isEmAlias { get; set; }

        [DataMember(Name = "importInvestorToLoan")]
        public bool? ImportInvestorToLoan { get; set; }

        [DataMember(Name = "isActive")]
        public bool? IsActive { get; set; }


    }
}
