using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFundingFees
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="balanceChecked", EmitDefaultValue=false)]
		public bool? BalanceChecked { get; set; }

		[DataMember(Name="cdLineId", EmitDefaultValue=false)]
		public string CdLineId { get; set; }

		[DataMember(Name="feeDescription", EmitDefaultValue=false)]
		public string FeeDescription { get; set; }

		[DataMember(Name="feeDescription2015", EmitDefaultValue=false)]
		public string FeeDescription2015 { get; set; }

		[DataMember(Name="lineId", EmitDefaultValue=false)]
		public string LineId { get; set; }

		[DataMember(Name="lineNumber", EmitDefaultValue=false)]
		public int? LineNumber { get; set; }

		[DataMember(Name="pacBroker2015", EmitDefaultValue=false)]
		public double? PacBroker2015 { get; set; }

		[DataMember(Name="pacLender2015", EmitDefaultValue=false)]
		public double? PacLender2015 { get; set; }

		[DataMember(Name="pacOther2015", EmitDefaultValue=false)]
		public double? PacOther2015 { get; set; }

		[DataMember(Name="paidBy", EmitDefaultValue=false)]
		public string PaidBy { get; set; }

		[DataMember(Name="paidTo", EmitDefaultValue=false)]
		public string PaidTo { get; set; }

		[DataMember(Name="payee", EmitDefaultValue=false)]
		public string Payee { get; set; }

		[DataMember(Name="pocAmount", EmitDefaultValue=false)]
		public double? PocAmount { get; set; }

		[DataMember(Name="pocBorrower2015", EmitDefaultValue=false)]
		public double? PocBorrower2015 { get; set; }

		[DataMember(Name="pocBroker2015", EmitDefaultValue=false)]
		public double? PocBroker2015 { get; set; }

		[DataMember(Name="pocLender2015", EmitDefaultValue=false)]
		public double? PocLender2015 { get; set; }

		[DataMember(Name="pocOther2015", EmitDefaultValue=false)]
		public double? PocOther2015 { get; set; }

		[DataMember(Name="pocPaidBy", EmitDefaultValue=false)]
		public string PocPaidBy { get; set; }

		[DataMember(Name="pocSeller2015", EmitDefaultValue=false)]
		public double? PocSeller2015 { get; set; }

		[DataMember(Name="ptcAmount", EmitDefaultValue=false)]
		public double? PtcAmount { get; set; }

		[DataMember(Name="ptcPaidBy", EmitDefaultValue=false)]
		public string PtcPaidBy { get; set; }

		[DataMember(Name="tag", EmitDefaultValue=false)]
		public object Tag { get; set; }

	}
}