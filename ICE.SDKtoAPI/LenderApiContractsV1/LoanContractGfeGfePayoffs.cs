using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfePayoffs
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="gfePayoffIndex", EmitDefaultValue=false)]
		public int? GfePayoffIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

	}
}