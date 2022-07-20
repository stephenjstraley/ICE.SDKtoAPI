using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSelfEmployedIncomes
	{
		[DataMember(Name="boolFieldValue")]
		public bool? BoolFieldValue { get; set; }

		[DataMember(Name="businessName")]
		public string BusinessName { get; set; }

		[DataMember(Name="fieldName")]
		public string FieldName { get; set; }

		[DataMember(Name="fieldValue")]
		public string FieldValue { get; set; }

		[DataMember(Name="firstYearAmount")]
		public decimal? FirstYearAmount { get; set; }

		[DataMember(Name="formType")]
		public string FormType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="secondYearAmount")]
		public decimal? SecondYearAmount { get; set; }

	}
}