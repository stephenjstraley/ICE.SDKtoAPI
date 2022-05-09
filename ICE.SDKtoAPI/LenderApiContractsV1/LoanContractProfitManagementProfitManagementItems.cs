using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractProfitManagementProfitManagementItems
	{
		[DataMember(Name="atPercent", EmitDefaultValue=false)]
		public double? AtPercent { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="plusAmount", EmitDefaultValue=false)]
		public double? PlusAmount { get; set; }

		[DataMember(Name="profitManagementItemIndex", EmitDefaultValue=false)]
		public int? ProfitManagementItemIndex { get; set; }

		[DataMember(Name="total", EmitDefaultValue=false)]
		public double? Total { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

	}
}