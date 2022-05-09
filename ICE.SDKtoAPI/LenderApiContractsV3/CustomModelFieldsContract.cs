using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class CustomModelFieldsContract
    {
        [DataMember(Name = "provideAmortizationScenario")]
        public bool? ProvideAmortizationScenario { get; set; }

        [DataMember(Name = "provideWorstCaseScenario")]
        public bool? ProvideWorstCaseScenario { get; set; }

        [DataMember(Name = "provideBestCaseScenario")]
        public bool? ProvideBestCaseScenario { get; set; }

        [DataMember(Name = "provideFhaScenario")]
        public bool? ProvideFhaScenario { get; set; }

        [DataMember(Name = "provideHelocExampleSchedules")]
        public bool? ProvideHelocExampleSchedules { get; set; }

        [DataMember(Name = "helocExampleScheduleData")]
        public object HelocExampleScheduleData { get; set; }

        [DataMember(Name = "helocHistoricalPaymentSchedule")]
        public List<object> HelocHistoricalPaymentSchedule { get; set; }

        [DataMember(Name = "helocMaximumPaymentSchedule")]
        public List<object> HelocMaximumPaymentSchedule { get; set; }

        [DataMember(Name = "helocMaximumScheduleOnFullLoanAmount")]
        public List<object> HelocMaximumScheduleOnFullLoanAmount { get; set; }

        [DataMember(Name = "helocMinimumPaymentSchedule")]
        public List<object> HelocMinimumPaymentSchedule { get; set; }

        [DataMember(Name = "provideCpaPaymentSchedule")]
        public bool? ProvideCpaPaymentSchedule { get; set; }

        [DataMember(Name = "cpaPaymentSchedule")]
        public List<object> CpaPaymentSchedule { get; set; }

        [DataMember(Name = "provideQmPaymentSchedule")]
        public bool? ProvideQmPaymentSchedule { get; set; }

        [DataMember(Name = "qmPaymentSchedule")]
        public List<object> QmPaymentSchedule { get; set; }
    }
}
