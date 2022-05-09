using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCustomFields
	{
		[DataMember(Name="dateValue", EmitDefaultValue=false)]
		public DateTime? DateValue { get; set; }

		[DataMember(Name="fieldName", EmitDefaultValue=false)]
		public string FieldName { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="numericValue", EmitDefaultValue=false)]
		public double? NumericValue { get; set; }

		[DataMember(Name="stringValue", EmitDefaultValue=false)]
		public string StringValue { get; set; }

	}
}