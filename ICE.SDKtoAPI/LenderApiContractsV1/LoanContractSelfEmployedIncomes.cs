using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSelfEmployedIncomes
	{
		[DataMember(Name="boolFieldValue", EmitDefaultValue=false)]
		public bool? BoolFieldValue { get; set; }

		[DataMember(Name="businessName", EmitDefaultValue=false)]
		public string BusinessName { get; set; }

		[DataMember(Name="fieldName", EmitDefaultValue=false)]
		public string FieldName { get; set; }

		[DataMember(Name="fieldValue", EmitDefaultValue=false)]
		public string FieldValue { get; set; }

		[DataMember(Name="firstYearAmount", EmitDefaultValue=false)]
		public double? FirstYearAmount { get; set; }

		[DataMember(Name="formType", EmitDefaultValue=false)]
		public string FormType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="secondYearAmount", EmitDefaultValue=false)]
		public double? SecondYearAmount { get; set; }

	}
}