using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFieldLockData
	{
		[DataMember(Name="lockRemoved")]
		public bool? LockRemoved { get; set; }

		[DataMember(Name="modelPath")]
		public string ModelPath { get; set; }

	}
}