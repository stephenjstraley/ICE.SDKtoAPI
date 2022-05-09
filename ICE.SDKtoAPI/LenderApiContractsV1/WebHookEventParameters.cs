using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class WebHookEventParameters
    {
        public string EventType { get; set; }
        public string Status { get; set; }
        public string ResourceType { get; set; }
        public string ResourceId { get; set; }
        public string SubscriptionId { get; set; }
        public string FilterText { get; set; } = "";
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Start { get; set; } = 0;
        public int Limit { get; set; } = 100;
    }

    public static class EvenTypeWebHook
    {
        public static string Create = "create";
        public static string Update = "update";
        public static string Submit = "submit";
        public static string Move = "move";
        public static string Document = "document";
        public static string Milestone = "milestone";
    }

    public static class ResouceTypeWebHook
    {
        public static string Loan = "Loan";
        public static string Transaction = "Transaction";
        public static string TaskGroup = "TaskGroup";
        public static string EnhancedConditionTemplate = "EnhancedConditionTemplate";
        public static string Task = "Task";
        public static string EnhancedConditionType = "EnhancedConditionType";
        public static string DocumentOrder = "DocumentOrder";
        public static string SubTask = "SubTask";
        public static string ExternalOrganization = "ExternalOrganization";
        public static string ServiceOrder = "ServiceOrder";
        public static string Trade = "Trade";
    }
    public static class StatusWebHook
    {
        public static string Received = "EventReceived";
        public static string Matched = "SubscriptionMatched";
        public static string Delievered = "NotificationDelivered";
        public static string Attempted = "DeliveryAttempted";
    }
}
