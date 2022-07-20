using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockLockRequestBorrowers
	{
		[DataMember(Name="equifaxScore")]
		public string EquifaxScore { get; set; }

		[DataMember(Name="experianScore")]
		public string ExperianScore { get; set; }

		[DataMember(Name="firstName")]
		public string FirstName { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isEmpty")]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="lastName")]
		public string LastName { get; set; }

		[DataMember(Name="lrbIndex")]
		public int? LrbIndex { get; set; }

		[DataMember(Name="sSN")]
		public string SSN { get; set; }

		[DataMember(Name="transUnionScore")]
		public string TransUnionScore { get; set; }

	}
}