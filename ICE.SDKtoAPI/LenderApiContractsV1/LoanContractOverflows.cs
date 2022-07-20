using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractOverflows
	{
		[DataMember(Name="coordinateBottom")]
		public string CoordinateBottom { get; set; }

		[DataMember(Name="coordinateLeft")]
		public string CoordinateLeft { get; set; }

		[DataMember(Name="coordinateRight")]
		public string CoordinateRight { get; set; }

		[DataMember(Name="coordinateTop")]
		public string CoordinateTop { get; set; }

		[DataMember(Name="originalText")]
		public string OriginalText { get; set; }

		[DataMember(Name="pageNumber")]
		public int? PageNumber { get; set; }

		[DataMember(Name="templateFieldName")]
		public string TemplateFieldName { get; set; }

	}
}