using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractVaLoanDataMilitaryServices
	{
		[DataMember(Name="branch")]
		public string Branch { get; set; }

		[DataMember(Name="endDate")]
		public DateTime? EndDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="militaryServiceIndex")]
		public int? MilitaryServiceIndex { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="officerOrEnlisted")]
		public string OfficerOrEnlisted { get; set; }

		[DataMember(Name="serviceNumber")]
		public string ServiceNumber { get; set; }

		[DataMember(Name="sSN")]
		public string SSN { get; set; }

		[DataMember(Name="startDate")]
		public DateTime? StartDate { get; set; }

	}
}