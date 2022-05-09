using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanFolderContract
	{
		[DataMember(Name="activityRules", EmitDefaultValue=false)]
		public List<LoanFolderContractActivityRules> ActivityRules { get; set; }

		[DataMember(Name="folderType", EmitDefaultValue=false)]
		public string FolderType { get; set; }

		[DataMember(Name="isExternalOrganization", EmitDefaultValue=false)]
		public bool? IsExternalOrganization { get; set; }

		[DataMember(Name="loanGuid", EmitDefaultValue=false)]
		public string LoanGuid { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

	}
}