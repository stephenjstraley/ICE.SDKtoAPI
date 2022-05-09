using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractElliUCDFields
	{
		[DataMember(Name="cdFields", EmitDefaultValue=false)]
		public object CdFields { get; set; }

		[DataMember(Name="leFields", EmitDefaultValue=false)]
		public object LeFields { get; set; }

	}
}