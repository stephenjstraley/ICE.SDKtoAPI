using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocumentRespaHudDetails
	{
		[DataMember(Name="creditDebt", EmitDefaultValue=false)]
		public string CreditDebt { get; set; }

		[DataMember(Name="fWBC", EmitDefaultValue=false)]
		public string FWBC { get; set; }

		[DataMember(Name="hUD1LineItemFromDate", EmitDefaultValue=false)]
		public DateTime? HUD1LineItemFromDate { get; set; }

		[DataMember(Name="hUD1LineItemToDate", EmitDefaultValue=false)]
		public DateTime? HUD1LineItemToDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lineItemAmount", EmitDefaultValue=false)]
		public double? LineItemAmount { get; set; }

		[DataMember(Name="lineItemDescription", EmitDefaultValue=false)]
		public string LineItemDescription { get; set; }

		[DataMember(Name="lineNumber", EmitDefaultValue=false)]
		public int? LineNumber { get; set; }

		[DataMember(Name="realValue", EmitDefaultValue=false)]
		public double? RealValue { get; set; }

	}
}