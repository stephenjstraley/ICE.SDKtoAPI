using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractVaLoanDataMilitaryServices
	{
		[DataMember(Name="branch", EmitDefaultValue=false)]
		public string Branch { get; set; }

		[DataMember(Name="endDate", EmitDefaultValue=false)]
		public DateTime? EndDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="militaryServiceIndex", EmitDefaultValue=false)]
		public int? MilitaryServiceIndex { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="officerOrEnlisted", EmitDefaultValue=false)]
		public string OfficerOrEnlisted { get; set; }

		[DataMember(Name="serviceNumber", EmitDefaultValue=false)]
		public string ServiceNumber { get; set; }

		[DataMember(Name="sSN", EmitDefaultValue=false)]
		public string SSN { get; set; }

		[DataMember(Name="startDate", EmitDefaultValue=false)]
		public DateTime? StartDate { get; set; }

	}
}