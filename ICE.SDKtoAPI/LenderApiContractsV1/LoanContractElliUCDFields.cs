using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractElliUCDFields
	{
		[DataMember(Name="cdFields")]
		public object CdFields { get; set; }

		[DataMember(Name="leFields")]
		public object LeFields { get; set; }

	}
}