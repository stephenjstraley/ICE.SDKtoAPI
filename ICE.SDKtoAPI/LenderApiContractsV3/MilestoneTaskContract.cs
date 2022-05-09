using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MilestoneTaskContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "addedBy")]
        public string AddedBy { get; set; }

        [DataMember(Name = "addedByUserId")]
        public string AddedByUserId { get; set; }

        [DataMember(Name = "completedBy")]
        public string CompletedBy { get; set; }

        [DataMember(Name = "completedByUserId")]
        public string CompletedByUserId { get; set; }

        [DataMember(Name = "completedDate")]
        public string CompletedDate { get; set; }

        [DataMember(Name = "contacts")]
        public List<MilestoneTaskContactContract> Contacts { get; set; }

        [DataMember(Name = "daysToComplete")]
        public int DaysToComplete { get; set; }

        [DataMember(Name = "daysToCompleteFromSetting")]
        public int DaysToCompleteFromSetting { get; set; }

        [DataMember(Name = "isRequiredIndicator")]
        public bool? IsRequiredIndicator { get; set; }

        [DataMember(Name = "priority")]
        public string Priority { get; set; }

        [DataMember(Name = "milestoneRef")]
        public EntityReferenceContract MilestoneRef { get; set; }

        [DataMember(Name = "taskDescription")]
        public string TaskDescription { get; set; }

        [DataMember(Name = "taskGuid")]
        public string TaskGuid { get; set; }

        [DataMember(Name = "taskName")]
        public string TaskName { get; set; }

        [DataMember(Name = "completed")]
        public bool Completed { get; set; }

        [DataMember(Name = "contactCount")]
        public int ContactCount { get; set; }

        [DataMember(Name = "expectedDate")]
        public string ExpectedDate { get; set; }

        [DataMember(Name = "addDate")]
        public string AddDate { get; set; }

        [DataMember(Name = "milestoneTaskLogDate")]
        public string MilestoneTaskLogDate { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "alerts")]
        public List<LogAlertContract> Alerts { get; set; }

    }
}
