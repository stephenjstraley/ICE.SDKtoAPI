using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFieldLockData
	{
		[DataMember(Name="lockRemoved", EmitDefaultValue=false)]
		public bool? LockRemoved { get; set; }

		[DataMember(Name="modelPath", EmitDefaultValue=false)]
		public string ModelPath { get; set; }

	}
}