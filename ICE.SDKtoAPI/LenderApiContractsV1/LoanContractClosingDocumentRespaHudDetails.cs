using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocumentRespaHudDetails
	{
		[DataMember(Name="creditDebt")]
		public string CreditDebt { get; set; }

		[DataMember(Name="fWBC")]
		public string FWBC { get; set; }

		[DataMember(Name="hUD1LineItemFromDate")]
		public DateTime? HUD1LineItemFromDate { get; set; }

		[DataMember(Name="hUD1LineItemToDate")]
		public DateTime? HUD1LineItemToDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lineItemAmount")]
		public decimal? LineItemAmount { get; set; }

		[DataMember(Name="lineItemDescription")]
		public string LineItemDescription { get; set; }

		[DataMember(Name="lineNumber")]
		public int LineNumber { get; set; }

		[DataMember(Name="realValue")]
		public decimal? RealValue { get; set; }

	}
}