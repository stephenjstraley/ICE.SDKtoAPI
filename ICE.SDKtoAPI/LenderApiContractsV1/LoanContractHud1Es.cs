using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1Es
	{
		[DataMember(Name="annualCityTax", EmitDefaultValue=false)]
		public double? AnnualCityTax { get; set; }

		[DataMember(Name="annualFeeCushion", EmitDefaultValue=false)]
		public int? AnnualFeeCushion { get; set; }

		[DataMember(Name="annualFloodInsurance", EmitDefaultValue=false)]
		public double? AnnualFloodInsurance { get; set; }

		[DataMember(Name="annualHazardInsurance", EmitDefaultValue=false)]
		public double? AnnualHazardInsurance { get; set; }

		[DataMember(Name="annualMortgageInsurance", EmitDefaultValue=false)]
		public double? AnnualMortgageInsurance { get; set; }

		[DataMember(Name="annualTax", EmitDefaultValue=false)]
		public double? AnnualTax { get; set; }

		[DataMember(Name="annualUserEscrow1", EmitDefaultValue=false)]
		public double? AnnualUserEscrow1 { get; set; }

		[DataMember(Name="annualUserEscrow2", EmitDefaultValue=false)]
		public double? AnnualUserEscrow2 { get; set; }

		[DataMember(Name="annualUserEscrow3", EmitDefaultValue=false)]
		public double? AnnualUserEscrow3 { get; set; }

		[DataMember(Name="biweeklyCityPropertyTaxes", EmitDefaultValue=false)]
		public double? BiweeklyCityPropertyTaxes { get; set; }

		[DataMember(Name="biweeklyCountyTaxes", EmitDefaultValue=false)]
		public double? BiweeklyCountyTaxes { get; set; }

		[DataMember(Name="biweeklyFloodInsurance", EmitDefaultValue=false)]
		public double? BiweeklyFloodInsurance { get; set; }

		[DataMember(Name="biweeklyHazardInsurance", EmitDefaultValue=false)]
		public double? BiweeklyHazardInsurance { get; set; }

		[DataMember(Name="biweeklyMortgageInsurance", EmitDefaultValue=false)]
		public double? BiweeklyMortgageInsurance { get; set; }

		[DataMember(Name="biweeklyPITI", EmitDefaultValue=false)]
		public double? BiweeklyPITI { get; set; }

		[DataMember(Name="biweeklyTotalBiweeklyPayment", EmitDefaultValue=false)]
		public double? BiweeklyTotalBiweeklyPayment { get; set; }

		[DataMember(Name="biweeklyTotalBiweeklyPaymentToEscrow", EmitDefaultValue=false)]
		public double? BiweeklyTotalBiweeklyPaymentToEscrow { get; set; }

		[DataMember(Name="biweeklyUSDAFee", EmitDefaultValue=false)]
		public double? BiweeklyUSDAFee { get; set; }

		[DataMember(Name="biweeklyUserDefinedEscrowFee1", EmitDefaultValue=false)]
		public double? BiweeklyUserDefinedEscrowFee1 { get; set; }

		[DataMember(Name="biweeklyUserDefinedEscrowFee2", EmitDefaultValue=false)]
		public double? BiweeklyUserDefinedEscrowFee2 { get; set; }

		[DataMember(Name="biweeklyUserDefinedEscrowFee3", EmitDefaultValue=false)]
		public double? BiweeklyUserDefinedEscrowFee3 { get; set; }

		[DataMember(Name="cityPropertyTaxAddress", EmitDefaultValue=false)]
		public string CityPropertyTaxAddress { get; set; }

		[DataMember(Name="cityPropertyTaxAmountLastPay", EmitDefaultValue=false)]
		public double? CityPropertyTaxAmountLastPay { get; set; }

		[DataMember(Name="cityPropertyTaxAmountNextDue", EmitDefaultValue=false)]
		public double? CityPropertyTaxAmountNextDue { get; set; }

		[DataMember(Name="cityPropertyTaxCity", EmitDefaultValue=false)]
		public string CityPropertyTaxCity { get; set; }

		[DataMember(Name="cityPropertyTaxContactName", EmitDefaultValue=false)]
		public string CityPropertyTaxContactName { get; set; }

		[DataMember(Name="cityPropertyTaxDatePaid", EmitDefaultValue=false)]
		public DateTime? CityPropertyTaxDatePaid { get; set; }

		[DataMember(Name="cityPropertyTaxDelinquentDate", EmitDefaultValue=false)]
		public DateTime? CityPropertyTaxDelinquentDate { get; set; }

		[DataMember(Name="cityPropertyTaxEmail", EmitDefaultValue=false)]
		public string CityPropertyTaxEmail { get; set; }

		[DataMember(Name="cityPropertyTaxFax", EmitDefaultValue=false)]
		public string CityPropertyTaxFax { get; set; }

		[DataMember(Name="cityPropertyTaxName", EmitDefaultValue=false)]
		public string CityPropertyTaxName { get; set; }

		[DataMember(Name="cityPropertyTaxNextDueDate", EmitDefaultValue=false)]
		public DateTime? CityPropertyTaxNextDueDate { get; set; }

		[DataMember(Name="cityPropertyTaxPaymentSchedule", EmitDefaultValue=false)]
		public string CityPropertyTaxPaymentSchedule { get; set; }

		[DataMember(Name="cityPropertyTaxPhone", EmitDefaultValue=false)]
		public string CityPropertyTaxPhone { get; set; }

		[DataMember(Name="cityPropertyTaxPostalCode", EmitDefaultValue=false)]
		public string CityPropertyTaxPostalCode { get; set; }

		[DataMember(Name="cityPropertyTaxState", EmitDefaultValue=false)]
		public string CityPropertyTaxState { get; set; }

		[DataMember(Name="endingBalance", EmitDefaultValue=false)]
		public double? EndingBalance { get; set; }

		[DataMember(Name="escrowFirstPaymentDate", EmitDefaultValue=false)]
		public DateTime? EscrowFirstPaymentDate { get; set; }

		[DataMember(Name="escrowFirstPaymentDateType", EmitDefaultValue=false)]
		public string EscrowFirstPaymentDateType { get; set; }

		[DataMember(Name="escrowPayment", EmitDefaultValue=false)]
		public double? EscrowPayment { get; set; }

		[DataMember(Name="escrowPaymentYearly", EmitDefaultValue=false)]
		public double? EscrowPaymentYearly { get; set; }

		[DataMember(Name="floodInsDisbCushion", EmitDefaultValue=false)]
		public int? FloodInsDisbCushion { get; set; }

		[DataMember(Name="hazInsDisbCushion", EmitDefaultValue=false)]
		public int? HazInsDisbCushion { get; set; }

		[DataMember(Name="hud1EsDates", EmitDefaultValue=false)]
		public List<LoanContractHud1EsHud1EsDates> Hud1EsDates { get; set; }

		[DataMember(Name="hud1EsDueDates", EmitDefaultValue=false)]
		public List<LoanContractHud1EsHud1EsDueDates> Hud1EsDueDates { get; set; }

		[DataMember(Name="hud1EsItemizes", EmitDefaultValue=false)]
		public List<LoanContractHud1EsHud1EsItemizes> Hud1EsItemizes { get; set; }

		[DataMember(Name="hud1EsItemizesTotalLines", EmitDefaultValue=false)]
		public int? Hud1EsItemizesTotalLines { get; set; }

		[DataMember(Name="hud1EsItemizesUseItemizeEscrowIndicator", EmitDefaultValue=false)]
		public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get; set; }

		[DataMember(Name="hud1EsPayTos", EmitDefaultValue=false)]
		public List<LoanContractHud1EsHud1EsPayTos> Hud1EsPayTos { get; set; }

		[DataMember(Name="hud1EsSetups", EmitDefaultValue=false)]
		public List<LoanContractHud1EsHud1EsSetups> Hud1EsSetups { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="mtgInsCushionTerminationIndicator", EmitDefaultValue=false)]
		public bool? MtgInsCushionTerminationIndicator { get; set; }

		[DataMember(Name="mtgInsDisbCushion", EmitDefaultValue=false)]
		public int? MtgInsDisbCushion { get; set; }

		[DataMember(Name="nonEscrowCostsYearly", EmitDefaultValue=false)]
		public double? NonEscrowCostsYearly { get; set; }

		[DataMember(Name="realEstateTaxAddress", EmitDefaultValue=false)]
		public string RealEstateTaxAddress { get; set; }

		[DataMember(Name="realEstateTaxAmountLastPay", EmitDefaultValue=false)]
		public double? RealEstateTaxAmountLastPay { get; set; }

		[DataMember(Name="realEstateTaxAmountNextDue", EmitDefaultValue=false)]
		public double? RealEstateTaxAmountNextDue { get; set; }

		[DataMember(Name="realEstateTaxCity", EmitDefaultValue=false)]
		public string RealEstateTaxCity { get; set; }

		[DataMember(Name="realEstateTaxContactName", EmitDefaultValue=false)]
		public string RealEstateTaxContactName { get; set; }

		[DataMember(Name="realEstateTaxDatePaid", EmitDefaultValue=false)]
		public DateTime? RealEstateTaxDatePaid { get; set; }

		[DataMember(Name="realEstateTaxDelinquentDate", EmitDefaultValue=false)]
		public DateTime? RealEstateTaxDelinquentDate { get; set; }

		[DataMember(Name="realEstateTaxEmail", EmitDefaultValue=false)]
		public string RealEstateTaxEmail { get; set; }

		[DataMember(Name="realEstateTaxFax", EmitDefaultValue=false)]
		public string RealEstateTaxFax { get; set; }

		[DataMember(Name="realEstateTaxName", EmitDefaultValue=false)]
		public string RealEstateTaxName { get; set; }

		[DataMember(Name="realEstateTaxNextDueDate", EmitDefaultValue=false)]
		public DateTime? RealEstateTaxNextDueDate { get; set; }

		[DataMember(Name="realEstateTaxPaymentSchedule", EmitDefaultValue=false)]
		public string RealEstateTaxPaymentSchedule { get; set; }

		[DataMember(Name="realEstateTaxPhone", EmitDefaultValue=false)]
		public string RealEstateTaxPhone { get; set; }

		[DataMember(Name="realEstateTaxPostalCode", EmitDefaultValue=false)]
		public string RealEstateTaxPostalCode { get; set; }

		[DataMember(Name="realEstateTaxState", EmitDefaultValue=false)]
		public string RealEstateTaxState { get; set; }

		[DataMember(Name="schoolTaxesCushion", EmitDefaultValue=false)]
		public int? SchoolTaxesCushion { get; set; }

		[DataMember(Name="servicerAddress", EmitDefaultValue=false)]
		public string ServicerAddress { get; set; }

		[DataMember(Name="servicerCity", EmitDefaultValue=false)]
		public string ServicerCity { get; set; }

		[DataMember(Name="servicerContactName", EmitDefaultValue=false)]
		public string ServicerContactName { get; set; }

		[DataMember(Name="servicerPhone", EmitDefaultValue=false)]
		public string ServicerPhone { get; set; }

		[DataMember(Name="servicerPostalCode", EmitDefaultValue=false)]
		public string ServicerPostalCode { get; set; }

		[DataMember(Name="servicerState", EmitDefaultValue=false)]
		public string ServicerState { get; set; }

		[DataMember(Name="singleLineAnalysis", EmitDefaultValue=false)]
		public double? SingleLineAnalysis { get; set; }

		[DataMember(Name="startingBalance", EmitDefaultValue=false)]
		public double? StartingBalance { get; set; }

		[DataMember(Name="taxDisbCushion", EmitDefaultValue=false)]
		public int? TaxDisbCushion { get; set; }

		[DataMember(Name="totalEscrowReserves", EmitDefaultValue=false)]
		public double? TotalEscrowReserves { get; set; }

		[DataMember(Name="usdaAnnualFee", EmitDefaultValue=false)]
		public double? UsdaAnnualFee { get; set; }

		[DataMember(Name="userDefinedCushion1", EmitDefaultValue=false)]
		public int? UserDefinedCushion1 { get; set; }

		[DataMember(Name="userDefinedCushion2", EmitDefaultValue=false)]
		public int? UserDefinedCushion2 { get; set; }

		[DataMember(Name="userDefinedCushion3", EmitDefaultValue=false)]
		public int? UserDefinedCushion3 { get; set; }

		[DataMember(Name="yearlyMortgageInsurance", EmitDefaultValue=false)]
		public double? YearlyMortgageInsurance { get; set; }

		[DataMember(Name="yearlyUsdaFee", EmitDefaultValue=false)]
		public double? YearlyUsdaFee { get; set; }

	}
}