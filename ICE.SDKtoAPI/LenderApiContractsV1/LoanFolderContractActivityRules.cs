using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanFolderContractActivityRules
	{
		[DataMember(Name="action")]
		public string Action { get; set; }

		[DataMember(Name="ruleValue")]
		public string RuleValue { get; set; }

	}
}