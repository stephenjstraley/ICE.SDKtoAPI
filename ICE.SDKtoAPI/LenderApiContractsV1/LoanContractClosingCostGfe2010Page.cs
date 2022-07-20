using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010Page
	{
		[DataMember(Name="balloonPaymentDueInYears")]
		public int? BalloonPaymentDueInYears { get; set; }

		[DataMember(Name="brokerCompensationFwbc")]
		public string BrokerCompensationFwbc { get; set; }

		[DataMember(Name="brokerCompensationFwsc")]
		public string BrokerCompensationFwsc { get; set; }

		[DataMember(Name="curedGfeTotalTolerance")]
		public decimal? CuredGfeTotalTolerance { get; set; }

		[DataMember(Name="firstArmChangeDate")]
		public DateTime? FirstArmChangeDate { get; set; }

		[DataMember(Name="gfe2010FwbcFwscs")]
		public List<LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs> Gfe2010FwbcFwscs { get; set; }

		[DataMember(Name="gfe2010GfeCharges")]
		public List<LoanContractClosingCostGfe2010PageGfe2010GfeCharges> Gfe2010GfeCharges { get; set; }

		[DataMember(Name="gfeRecordingCharges")]
		public string GfeRecordingCharges { get; set; }

		[DataMember(Name="gfeTotalTolerance")]
		public decimal? GfeTotalTolerance { get; set; }

		[DataMember(Name="hasEscrowAccountIndicator")]
		public bool? HasEscrowAccountIndicator { get; set; }

		[DataMember(Name="hasEscrowCityPropertyTaxesIndicator")]
		public bool? HasEscrowCityPropertyTaxesIndicator { get; set; }

		[DataMember(Name="hasEscrowFloodInsurancesIndicator")]
		public bool? HasEscrowFloodInsurancesIndicator { get; set; }

		[DataMember(Name="hasEscrowHomeownerInsurancesIndicator")]
		public bool? HasEscrowHomeownerInsurancesIndicator { get; set; }

		[DataMember(Name="hasEscrowPropertyTaxesIndicator")]
		public bool? HasEscrowPropertyTaxesIndicator { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator1")]
		public bool? HasEscrowUserDefinedIndicator1 { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator2")]
		public bool? HasEscrowUserDefinedIndicator2 { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator3")]
		public bool? HasEscrowUserDefinedIndicator3 { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator4")]
		public bool? HasEscrowUserDefinedIndicator4 { get; set; }

		[DataMember(Name="highestArmRate")]
		public decimal? HighestArmRate { get; set; }

		[DataMember(Name="hud1GovernmentRecordingCharge")]
		public decimal? Hud1GovernmentRecordingCharge { get; set; }

		[DataMember(Name="hud1Pg1SellerPaidClosingCostsAmount")]
		public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="hud1Pg1TotalSettlementCharges")]
		public decimal? Hud1Pg1TotalSettlementCharges { get; set; }

		[DataMember(Name="hud1Pg2SellerPaidClosingCostsAmount")]
		public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="hud1Pg2TotalSettlementCharges")]
		public decimal? Hud1Pg2TotalSettlementCharges { get; set; }

		[DataMember(Name="hudTotalTolerance")]
		public decimal? HudTotalTolerance { get; set; }

		[DataMember(Name="hudTotalToleranceIncreasePercent")]
		public decimal? HudTotalToleranceIncreasePercent { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="line1101SellerPaidTotal")]
		public decimal? Line1101SellerPaidTotal { get; set; }

		[DataMember(Name="line1201SellerPaidTotal")]
		public decimal? Line1201SellerPaidTotal { get; set; }

		[DataMember(Name="line1301SellerPaidTotal")]
		public decimal? Line1301SellerPaidTotal { get; set; }

		[DataMember(Name="line801BorrowerPaidTotal")]
		public decimal? Line801BorrowerPaidTotal { get; set; }

		[DataMember(Name="line801SellerPaidTotal")]
		public decimal? Line801SellerPaidTotal { get; set; }

		[DataMember(Name="line802BorrowerPaidTotal")]
		public decimal? Line802BorrowerPaidTotal { get; set; }

		[DataMember(Name="line803BorrowerPaidTotal")]
		public decimal? Line803BorrowerPaidTotal { get; set; }

		[DataMember(Name="line803SellerPaidTotal")]
		public decimal? Line803SellerPaidTotal { get; set; }

		[DataMember(Name="line818FwbcIndicator")]
		public bool? Line818FwbcIndicator { get; set; }

		[DataMember(Name="line818FwscIndicator")]
		public bool? Line818FwscIndicator { get; set; }

		[DataMember(Name="line819FwbcIndicator")]
		public bool? Line819FwbcIndicator { get; set; }

		[DataMember(Name="line819FwscIndicator")]
		public bool? Line819FwscIndicator { get; set; }

		[DataMember(Name="line820FwbcIndicator")]
		public bool? Line820FwbcIndicator { get; set; }

		[DataMember(Name="line820FwscIndicator")]
		public bool? Line820FwscIndicator { get; set; }

		[DataMember(Name="line821FwbcIndicator")]
		public bool? Line821FwbcIndicator { get; set; }

		[DataMember(Name="line821FwscIndicator")]
		public bool? Line821FwscIndicator { get; set; }

		[DataMember(Name="line822FwbcIndicator")]
		public bool? Line822FwbcIndicator { get; set; }

		[DataMember(Name="line822FwscIndicator")]
		public bool? Line822FwscIndicator { get; set; }

		[DataMember(Name="line823FwbcIndicator")]
		public bool? Line823FwbcIndicator { get; set; }

		[DataMember(Name="line823FwscIndicator")]
		public bool? Line823FwscIndicator { get; set; }

		[DataMember(Name="line824FwbcIndicator")]
		public bool? Line824FwbcIndicator { get; set; }

		[DataMember(Name="line824FwscIndicator")]
		public bool? Line824FwscIndicator { get; set; }

		[DataMember(Name="line825FwbcIndicator")]
		public bool? Line825FwbcIndicator { get; set; }

		[DataMember(Name="line825FwscIndicator")]
		public bool? Line825FwscIndicator { get; set; }

		[DataMember(Name="line826FwbcIndicator")]
		public bool? Line826FwbcIndicator { get; set; }

		[DataMember(Name="line826FwscIndicator")]
		public bool? Line826FwscIndicator { get; set; }

		[DataMember(Name="line827FwbcIndicator")]
		public bool? Line827FwbcIndicator { get; set; }

		[DataMember(Name="line827FwscIndicator")]
		public bool? Line827FwscIndicator { get; set; }

		[DataMember(Name="line828FwbcIndicator")]
		public bool? Line828FwbcIndicator { get; set; }

		[DataMember(Name="line828FwscIndicator")]
		public bool? Line828FwscIndicator { get; set; }

		[DataMember(Name="line829FwbcIndicator")]
		public bool? Line829FwbcIndicator { get; set; }

		[DataMember(Name="line829FwscIndicator")]
		public bool? Line829FwscIndicator { get; set; }

		[DataMember(Name="line830FwbcIndicator")]
		public bool? Line830FwbcIndicator { get; set; }

		[DataMember(Name="line830FwscIndicator")]
		public bool? Line830FwscIndicator { get; set; }

		[DataMember(Name="line831FwbcIndicator")]
		public bool? Line831FwbcIndicator { get; set; }

		[DataMember(Name="line831FwscIndicator")]
		public bool? Line831FwscIndicator { get; set; }

		[DataMember(Name="line832FwbcIndicator")]
		public bool? Line832FwbcIndicator { get; set; }

		[DataMember(Name="line832FwscIndicator")]
		public bool? Line832FwscIndicator { get; set; }

		[DataMember(Name="line833FwbcIndicator")]
		public bool? Line833FwbcIndicator { get; set; }

		[DataMember(Name="line833FwscIndicator")]
		public bool? Line833FwscIndicator { get; set; }

		[DataMember(Name="lineLFwbcIndicator")]
		public bool? LineLFwbcIndicator { get; set; }

		[DataMember(Name="lineLFwscIndicator")]
		public bool? LineLFwscIndicator { get; set; }

		[DataMember(Name="lineMFwbcIndicator")]
		public bool? LineMFwbcIndicator { get; set; }

		[DataMember(Name="lineMFwscIndicator")]
		public bool? LineMFwscIndicator { get; set; }

		[DataMember(Name="lineNFwbcIndicator")]
		public bool? LineNFwbcIndicator { get; set; }

		[DataMember(Name="lineNFwscIndicator")]
		public bool? LineNFwscIndicator { get; set; }

		[DataMember(Name="lineOFwbcIndicator")]
		public bool? LineOFwbcIndicator { get; set; }

		[DataMember(Name="lineOFwscIndicator")]
		public bool? LineOFwscIndicator { get; set; }

		[DataMember(Name="linePFwbcIndicator")]
		public bool? LinePFwbcIndicator { get; set; }

		[DataMember(Name="linePFwscIndicator")]
		public bool? LinePFwscIndicator { get; set; }

		[DataMember(Name="lineQFwbcIndicator")]
		public bool? LineQFwbcIndicator { get; set; }

		[DataMember(Name="lineQFwscIndicator")]
		public bool? LineQFwscIndicator { get; set; }

		[DataMember(Name="lineRFwbcIndicator")]
		public bool? LineRFwbcIndicator { get; set; }

		[DataMember(Name="lineRFwscIndicator")]
		public bool? LineRFwscIndicator { get; set; }

		[DataMember(Name="lowestArmRate")]
		public decimal? LowestArmRate { get; set; }

		[DataMember(Name="monthlyAmountIncludeInterestIndicator")]
		public bool? MonthlyAmountIncludeInterestIndicator { get; set; }

		[DataMember(Name="monthlyAmountIncludeMiIndicator")]
		public bool? MonthlyAmountIncludeMiIndicator { get; set; }

		[DataMember(Name="monthlyAmountIncludePrincipalIndicator")]
		public bool? MonthlyAmountIncludePrincipalIndicator { get; set; }

		[DataMember(Name="monthlyAmountWithEscrow")]
		public decimal? MonthlyAmountWithEscrow { get; set; }

		[DataMember(Name="monthlyEscrowPayment")]
		public decimal? MonthlyEscrowPayment { get; set; }

		[DataMember(Name="prepaidInterest")]
		public decimal? PrepaidInterest { get; set; }

		[DataMember(Name="totalToleranceIncreaseAmount")]
		public decimal? TotalToleranceIncreaseAmount { get; set; }

	}
}