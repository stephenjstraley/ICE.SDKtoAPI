using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanFolderContractActivityRules
	{
		[DataMember(Name="action", EmitDefaultValue=false)]
		public string Action { get; set; }

		[DataMember(Name="ruleValue", EmitDefaultValue=false)]
		public string RuleValue { get; set; }

	}
}