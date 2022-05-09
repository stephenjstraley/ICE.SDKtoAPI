using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractOverflows
	{
		[DataMember(Name="coordinateBottom", EmitDefaultValue=false)]
		public string CoordinateBottom { get; set; }

		[DataMember(Name="coordinateLeft", EmitDefaultValue=false)]
		public string CoordinateLeft { get; set; }

		[DataMember(Name="coordinateRight", EmitDefaultValue=false)]
		public string CoordinateRight { get; set; }

		[DataMember(Name="coordinateTop", EmitDefaultValue=false)]
		public string CoordinateTop { get; set; }

		[DataMember(Name="originalText", EmitDefaultValue=false)]
		public string OriginalText { get; set; }

		[DataMember(Name="pageNumber", EmitDefaultValue=false)]
		public int? PageNumber { get; set; }

		[DataMember(Name="templateFieldName", EmitDefaultValue=false)]
		public string TemplateFieldName { get; set; }

	}
}