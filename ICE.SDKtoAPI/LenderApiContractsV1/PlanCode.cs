using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class PlanCode
    {
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "loanProgramtype", EmitDefaultValue = false)]
        public string LoanProgramType { get; set; }

        [DataMember(Name = "investorCode", EmitDefaultValue = false)]
        public string InvestorCode { get; set; }

        [DataMember(Name = "investorName", EmitDefaultValue = false)]
        public string InvestorName { get; set; }

        [DataMember(Name = "investorPlanCode", EmitDefaultValue = false)]
        public string InvestorPlanCode { get; set; }

        [DataMember(Name = "loanType", EmitDefaultValue = false)]
        public string LoanType { get; set; }

        [DataMember(Name = "amortizationType", EmitDefaultValue = false)]
        public string AmortizationType { get; set; }

        [DataMember(Name = "lienPosition", EmitDefaultValue = false)]
        public string LienPosition { get; set; }

        [DataMember(Name = "ballonLoan", EmitDefaultValue = false)]
        public bool? BallonLoan { get; set; }

        [DataMember(Name = "demandFeature", EmitDefaultValue = false)]
        public bool? DemandFeature { get; set; }

        [DataMember(Name = "biweeklylLoan", EmitDefaultValue = false)]
        public bool? BiWeeklyLoan { get; set; }

        [DataMember(Name = "interestOnly", EmitDefaultValue = false)]
        public bool? InterestOnly { get; set; }

        [DataMember(Name = "assumabilityType", EmitDefaultValue = false)]
        public bool? AssumabilityType { get; set; }

        [DataMember(Name = "planFirstChange", EmitDefaultValue = false)]
        public string PlanFirstchange { get; set; }

        [DataMember(Name = "subsequentChange", EmitDefaultValue = false)]
        public string SubsequentChange { get; set; }

        [DataMember(Name = "numberOfDaysPerYear", EmitDefaultValue = false)]
        public string NumberOfDasPerYear { get; set; }

        [DataMember(Name = "prepaymentPenalty", EmitDefaultValue = false)]
        public bool? PrepaymentPenalty { get; set; }

        [DataMember(Name = "roundingFactor", EmitDefaultValue = false)]
        public int? RoundingFactor { get; set; }

        [DataMember(Name = "roundingType", EmitDefaultValue = false)]
        public string RoundingType { get; set; }

        [DataMember(Name = "indexLookbackPeriod", EmitDefaultValue = false)]
        public string IndexLookbackPeriod { get; set; }

        [DataMember(Name = "isConvertible", EmitDefaultValue = false)]
        public bool? IsConvertible { get; set; }

        [DataMember(Name = "recordId", EmitDefaultValue = false)]
        public string RecordId { get; set; }

        [DataMember(Name = "isEmAlias", EmitDefaultValue = false)]
        public bool? isEmAlias { get; set; }

        [DataMember(Name = "importInvestorToLoan", EmitDefaultValue = false)]
        public bool? ImportInvestorToLoan { get; set; }

        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        public bool? IsActive { get; set; }


    }
}
