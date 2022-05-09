using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockLockRequestBorrowers
	{
		[DataMember(Name="equifaxScore", EmitDefaultValue=false)]
		public string EquifaxScore { get; set; }

		[DataMember(Name="experianScore", EmitDefaultValue=false)]
		public string ExperianScore { get; set; }

		[DataMember(Name="firstName", EmitDefaultValue=false)]
		public string FirstName { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isEmpty", EmitDefaultValue=false)]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="lastName", EmitDefaultValue=false)]
		public string LastName { get; set; }

		[DataMember(Name="lrbIndex", EmitDefaultValue=false)]
		public int? LrbIndex { get; set; }

		[DataMember(Name="sSN", EmitDefaultValue=false)]
		public string SSN { get; set; }

		[DataMember(Name="transUnionScore", EmitDefaultValue=false)]
		public string TransUnionScore { get; set; }

	}
}