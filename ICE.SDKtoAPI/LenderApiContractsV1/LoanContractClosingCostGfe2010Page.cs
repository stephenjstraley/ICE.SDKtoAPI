using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010Page
	{
		[DataMember(Name="balloonPaymentDueInYears", EmitDefaultValue=false)]
		public int? BalloonPaymentDueInYears { get; set; }

		[DataMember(Name="brokerCompensationFwbc", EmitDefaultValue=false)]
		public string BrokerCompensationFwbc { get; set; }

		[DataMember(Name="brokerCompensationFwsc", EmitDefaultValue=false)]
		public string BrokerCompensationFwsc { get; set; }

		[DataMember(Name="curedGfeTotalTolerance", EmitDefaultValue=false)]
		public double? CuredGfeTotalTolerance { get; set; }

		[DataMember(Name="firstArmChangeDate", EmitDefaultValue=false)]
		public DateTime? FirstArmChangeDate { get; set; }

		[DataMember(Name="gfe2010FwbcFwscs", EmitDefaultValue=false)]
		public List<LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs> Gfe2010FwbcFwscs { get; set; }

		[DataMember(Name="gfe2010GfeCharges", EmitDefaultValue=false)]
		public List<LoanContractClosingCostGfe2010PageGfe2010GfeCharges> Gfe2010GfeCharges { get; set; }

		[DataMember(Name="gfeRecordingCharges", EmitDefaultValue=false)]
		public string GfeRecordingCharges { get; set; }

		[DataMember(Name="gfeTotalTolerance", EmitDefaultValue=false)]
		public double? GfeTotalTolerance { get; set; }

		[DataMember(Name="hasEscrowAccountIndicator", EmitDefaultValue=false)]
		public bool? HasEscrowAccountIndicator { get; set; }

		[DataMember(Name="hasEscrowCityPropertyTaxesIndicator", EmitDefaultValue=false)]
		public bool? HasEscrowCityPropertyTaxesIndicator { get; set; }

		[DataMember(Name="hasEscrowFloodInsurancesIndicator", EmitDefaultValue=false)]
		public bool? HasEscrowFloodInsurancesIndicator { get; set; }

		[DataMember(Name="hasEscrowHomeownerInsurancesIndicator", EmitDefaultValue=false)]
		public bool? HasEscrowHomeownerInsurancesIndicator { get; set; }

		[DataMember(Name="hasEscrowPropertyTaxesIndicator", EmitDefaultValue=false)]
		public bool? HasEscrowPropertyTaxesIndicator { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator1", EmitDefaultValue=false)]
		public bool? HasEscrowUserDefinedIndicator1 { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator2", EmitDefaultValue=false)]
		public bool? HasEscrowUserDefinedIndicator2 { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator3", EmitDefaultValue=false)]
		public bool? HasEscrowUserDefinedIndicator3 { get; set; }

		[DataMember(Name="hasEscrowUserDefinedIndicator4", EmitDefaultValue=false)]
		public bool? HasEscrowUserDefinedIndicator4 { get; set; }

		[DataMember(Name="highestArmRate", EmitDefaultValue=false)]
		public double? HighestArmRate { get; set; }

		[DataMember(Name="hud1GovernmentRecordingCharge", EmitDefaultValue=false)]
		public double? Hud1GovernmentRecordingCharge { get; set; }

		[DataMember(Name="hud1Pg1SellerPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? Hud1Pg1SellerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="hud1Pg1TotalSettlementCharges", EmitDefaultValue=false)]
		public double? Hud1Pg1TotalSettlementCharges { get; set; }

		[DataMember(Name="hud1Pg2SellerPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? Hud1Pg2SellerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="hud1Pg2TotalSettlementCharges", EmitDefaultValue=false)]
		public double? Hud1Pg2TotalSettlementCharges { get; set; }

		[DataMember(Name="hudTotalTolerance", EmitDefaultValue=false)]
		public double? HudTotalTolerance { get; set; }

		[DataMember(Name="hudTotalToleranceIncreasePercent", EmitDefaultValue=false)]
		public double? HudTotalToleranceIncreasePercent { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="line1101SellerPaidTotal", EmitDefaultValue=false)]
		public double? Line1101SellerPaidTotal { get; set; }

		[DataMember(Name="line1201SellerPaidTotal", EmitDefaultValue=false)]
		public double? Line1201SellerPaidTotal { get; set; }

		[DataMember(Name="line1301SellerPaidTotal", EmitDefaultValue=false)]
		public double? Line1301SellerPaidTotal { get; set; }

		[DataMember(Name="line801BorrowerPaidTotal", EmitDefaultValue=false)]
		public double? Line801BorrowerPaidTotal { get; set; }

		[DataMember(Name="line801SellerPaidTotal", EmitDefaultValue=false)]
		public double? Line801SellerPaidTotal { get; set; }

		[DataMember(Name="line802BorrowerPaidTotal", EmitDefaultValue=false)]
		public double? Line802BorrowerPaidTotal { get; set; }

		[DataMember(Name="line803BorrowerPaidTotal", EmitDefaultValue=false)]
		public double? Line803BorrowerPaidTotal { get; set; }

		[DataMember(Name="line803SellerPaidTotal", EmitDefaultValue=false)]
		public double? Line803SellerPaidTotal { get; set; }

		[DataMember(Name="line818FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line818FwbcIndicator { get; set; }

		[DataMember(Name="line818FwscIndicator", EmitDefaultValue=false)]
		public bool? Line818FwscIndicator { get; set; }

		[DataMember(Name="line819FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line819FwbcIndicator { get; set; }

		[DataMember(Name="line819FwscIndicator", EmitDefaultValue=false)]
		public bool? Line819FwscIndicator { get; set; }

		[DataMember(Name="line820FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line820FwbcIndicator { get; set; }

		[DataMember(Name="line820FwscIndicator", EmitDefaultValue=false)]
		public bool? Line820FwscIndicator { get; set; }

		[DataMember(Name="line821FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line821FwbcIndicator { get; set; }

		[DataMember(Name="line821FwscIndicator", EmitDefaultValue=false)]
		public bool? Line821FwscIndicator { get; set; }

		[DataMember(Name="line822FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line822FwbcIndicator { get; set; }

		[DataMember(Name="line822FwscIndicator", EmitDefaultValue=false)]
		public bool? Line822FwscIndicator { get; set; }

		[DataMember(Name="line823FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line823FwbcIndicator { get; set; }

		[DataMember(Name="line823FwscIndicator", EmitDefaultValue=false)]
		public bool? Line823FwscIndicator { get; set; }

		[DataMember(Name="line824FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line824FwbcIndicator { get; set; }

		[DataMember(Name="line824FwscIndicator", EmitDefaultValue=false)]
		public bool? Line824FwscIndicator { get; set; }

		[DataMember(Name="line825FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line825FwbcIndicator { get; set; }

		[DataMember(Name="line825FwscIndicator", EmitDefaultValue=false)]
		public bool? Line825FwscIndicator { get; set; }

		[DataMember(Name="line826FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line826FwbcIndicator { get; set; }

		[DataMember(Name="line826FwscIndicator", EmitDefaultValue=false)]
		public bool? Line826FwscIndicator { get; set; }

		[DataMember(Name="line827FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line827FwbcIndicator { get; set; }

		[DataMember(Name="line827FwscIndicator", EmitDefaultValue=false)]
		public bool? Line827FwscIndicator { get; set; }

		[DataMember(Name="line828FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line828FwbcIndicator { get; set; }

		[DataMember(Name="line828FwscIndicator", EmitDefaultValue=false)]
		public bool? Line828FwscIndicator { get; set; }

		[DataMember(Name="line829FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line829FwbcIndicator { get; set; }

		[DataMember(Name="line829FwscIndicator", EmitDefaultValue=false)]
		public bool? Line829FwscIndicator { get; set; }

		[DataMember(Name="line830FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line830FwbcIndicator { get; set; }

		[DataMember(Name="line830FwscIndicator", EmitDefaultValue=false)]
		public bool? Line830FwscIndicator { get; set; }

		[DataMember(Name="line831FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line831FwbcIndicator { get; set; }

		[DataMember(Name="line831FwscIndicator", EmitDefaultValue=false)]
		public bool? Line831FwscIndicator { get; set; }

		[DataMember(Name="line832FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line832FwbcIndicator { get; set; }

		[DataMember(Name="line832FwscIndicator", EmitDefaultValue=false)]
		public bool? Line832FwscIndicator { get; set; }

		[DataMember(Name="line833FwbcIndicator", EmitDefaultValue=false)]
		public bool? Line833FwbcIndicator { get; set; }

		[DataMember(Name="line833FwscIndicator", EmitDefaultValue=false)]
		public bool? Line833FwscIndicator { get; set; }

		[DataMember(Name="lineLFwbcIndicator", EmitDefaultValue=false)]
		public bool? LineLFwbcIndicator { get; set; }

		[DataMember(Name="lineLFwscIndicator", EmitDefaultValue=false)]
		public bool? LineLFwscIndicator { get; set; }

		[DataMember(Name="lineMFwbcIndicator", EmitDefaultValue=false)]
		public bool? LineMFwbcIndicator { get; set; }

		[DataMember(Name="lineMFwscIndicator", EmitDefaultValue=false)]
		public bool? LineMFwscIndicator { get; set; }

		[DataMember(Name="lineNFwbcIndicator", EmitDefaultValue=false)]
		public bool? LineNFwbcIndicator { get; set; }

		[DataMember(Name="lineNFwscIndicator", EmitDefaultValue=false)]
		public bool? LineNFwscIndicator { get; set; }

		[DataMember(Name="lineOFwbcIndicator", EmitDefaultValue=false)]
		public bool? LineOFwbcIndicator { get; set; }

		[DataMember(Name="lineOFwscIndicator", EmitDefaultValue=false)]
		public bool? LineOFwscIndicator { get; set; }

		[DataMember(Name="linePFwbcIndicator", EmitDefaultValue=false)]
		public bool? LinePFwbcIndicator { get; set; }

		[DataMember(Name="linePFwscIndicator", EmitDefaultValue=false)]
		public bool? LinePFwscIndicator { get; set; }

		[DataMember(Name="lineQFwbcIndicator", EmitDefaultValue=false)]
		public bool? LineQFwbcIndicator { get; set; }

		[DataMember(Name="lineQFwscIndicator", EmitDefaultValue=false)]
		public bool? LineQFwscIndicator { get; set; }

		[DataMember(Name="lineRFwbcIndicator", EmitDefaultValue=false)]
		public bool? LineRFwbcIndicator { get; set; }

		[DataMember(Name="lineRFwscIndicator", EmitDefaultValue=false)]
		public bool? LineRFwscIndicator { get; set; }

		[DataMember(Name="lowestArmRate", EmitDefaultValue=false)]
		public double? LowestArmRate { get; set; }

		[DataMember(Name="monthlyAmountIncludeInterestIndicator", EmitDefaultValue=false)]
		public bool? MonthlyAmountIncludeInterestIndicator { get; set; }

		[DataMember(Name="monthlyAmountIncludeMiIndicator", EmitDefaultValue=false)]
		public bool? MonthlyAmountIncludeMiIndicator { get; set; }

		[DataMember(Name="monthlyAmountIncludePrincipalIndicator", EmitDefaultValue=false)]
		public bool? MonthlyAmountIncludePrincipalIndicator { get; set; }

		[DataMember(Name="monthlyAmountWithEscrow", EmitDefaultValue=false)]
		public double? MonthlyAmountWithEscrow { get; set; }

		[DataMember(Name="monthlyEscrowPayment", EmitDefaultValue=false)]
		public double? MonthlyEscrowPayment { get; set; }

		[DataMember(Name="prepaidInterest", EmitDefaultValue=false)]
		public double? PrepaidInterest { get; set; }

		[DataMember(Name="totalToleranceIncreaseAmount", EmitDefaultValue=false)]
		public double? TotalToleranceIncreaseAmount { get; set; }

	}
}