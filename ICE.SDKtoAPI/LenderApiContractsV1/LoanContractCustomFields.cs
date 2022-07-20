using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCustomFields
	{
		[DataMember(Name="dateValue")]
		public DateTime? DateValue { get; set; }

		[DataMember(Name="fieldName")]
		public string FieldName { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="numericValue")]
		public decimal? NumericValue { get; set; }

		[DataMember(Name="stringValue")]
		public string StringValue { get; set; }

	}
}