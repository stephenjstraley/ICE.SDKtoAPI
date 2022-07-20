using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanFolderContract
	{
		[DataMember(Name="activityRules")]
		public List<LoanFolderContractActivityRules> ActivityRules { get; set; }

		[DataMember(Name="folderType")]
		public string FolderType { get; set; }

		[DataMember(Name="isExternalOrganization")]
		public bool? IsExternalOrganization { get; set; }

		[DataMember(Name="loanGuid")]
		public string LoanGuid { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

	}
}