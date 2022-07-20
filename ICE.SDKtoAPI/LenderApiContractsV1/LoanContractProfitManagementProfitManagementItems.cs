using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractProfitManagementProfitManagementItems
	{
		[DataMember(Name="atPercent")]
		public decimal? AtPercent { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="plusAmount")]
		public decimal? PlusAmount { get; set; }

		[DataMember(Name="profitManagementItemIndex")]
		public int? ProfitManagementItemIndex { get; set; }

		[DataMember(Name="total")]
		public decimal? Total { get; set; }

		[DataMember(Name="type")]
		public string Type { get; set; }

	}
}