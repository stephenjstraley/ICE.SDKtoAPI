using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEmDocumentLender
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lndBrchCty", EmitDefaultValue=false)]
		public string LndBrchCty { get; set; }

		[DataMember(Name="lndBrchFax", EmitDefaultValue=false)]
		public string LndBrchFax { get; set; }

		[DataMember(Name="lndBrchJrsdctn", EmitDefaultValue=false)]
		public string LndBrchJrsdctn { get; set; }

		[DataMember(Name="lndBrchNm", EmitDefaultValue=false)]
		public string LndBrchNm { get; set; }

		[DataMember(Name="lndBrchOrgTyp", EmitDefaultValue=false)]
		public string LndBrchOrgTyp { get; set; }

		[DataMember(Name="lndBrchPhone", EmitDefaultValue=false)]
		public string LndBrchPhone { get; set; }

		[DataMember(Name="lndBrchStCd", EmitDefaultValue=false)]
		public string LndBrchStCd { get; set; }

		[DataMember(Name="lndBrchStreetAddr1", EmitDefaultValue=false)]
		public string LndBrchStreetAddr1 { get; set; }

		[DataMember(Name="lndBrchStreetAddr2", EmitDefaultValue=false)]
		public string LndBrchStreetAddr2 { get; set; }

		[DataMember(Name="lndBrchTollFreePhone", EmitDefaultValue=false)]
		public string LndBrchTollFreePhone { get; set; }

		[DataMember(Name="lndBrchUrl", EmitDefaultValue=false)]
		public string LndBrchUrl { get; set; }

		[DataMember(Name="lndBrchZip", EmitDefaultValue=false)]
		public string LndBrchZip { get; set; }

		[DataMember(Name="lndCnty", EmitDefaultValue=false)]
		public string LndCnty { get; set; }

		[DataMember(Name="lndCty", EmitDefaultValue=false)]
		public string LndCty { get; set; }

		[DataMember(Name="lndFaxNum", EmitDefaultValue=false)]
		public string LndFaxNum { get; set; }

		[DataMember(Name="lndFhaOrgntrId", EmitDefaultValue=false)]
		public string LndFhaOrgntrId { get; set; }

		[DataMember(Name="lndFhaSpnsrId", EmitDefaultValue=false)]
		public string LndFhaSpnsrId { get; set; }

		[DataMember(Name="lndJrsdctn", EmitDefaultValue=false)]
		public string LndJrsdctn { get; set; }

		[DataMember(Name="lndLossPayeeAdtlTxt", EmitDefaultValue=false)]
		public string LndLossPayeeAdtlTxt { get; set; }

		[DataMember(Name="lndLossPayeeCntctEmail", EmitDefaultValue=false)]
		public string LndLossPayeeCntctEmail { get; set; }

		[DataMember(Name="lndLossPayeeCntctFax", EmitDefaultValue=false)]
		public string LndLossPayeeCntctFax { get; set; }

		[DataMember(Name="lndLossPayeeCntctNm", EmitDefaultValue=false)]
		public string LndLossPayeeCntctNm { get; set; }

		[DataMember(Name="lndLossPayeeCntctPhone", EmitDefaultValue=false)]
		public string LndLossPayeeCntctPhone { get; set; }

		[DataMember(Name="lndLossPayeeCty", EmitDefaultValue=false)]
		public string LndLossPayeeCty { get; set; }

		[DataMember(Name="lndLossPayeeJrsdctn", EmitDefaultValue=false)]
		public string LndLossPayeeJrsdctn { get; set; }

		[DataMember(Name="lndLossPayeeNm", EmitDefaultValue=false)]
		public string LndLossPayeeNm { get; set; }

		[DataMember(Name="lndLossPayeeOrgTyp", EmitDefaultValue=false)]
		public string LndLossPayeeOrgTyp { get; set; }

		[DataMember(Name="lndLossPayeeScsrsClausTxtDesc", EmitDefaultValue=false)]
		public string LndLossPayeeScsrsClausTxtDesc { get; set; }

		[DataMember(Name="lndLossPayeeStCd", EmitDefaultValue=false)]
		public string LndLossPayeeStCd { get; set; }

		[DataMember(Name="lndLossPayeeStreetAddr1", EmitDefaultValue=false)]
		public string LndLossPayeeStreetAddr1 { get; set; }

		[DataMember(Name="lndLossPayeeStreetAddr2", EmitDefaultValue=false)]
		public string LndLossPayeeStreetAddr2 { get; set; }

		[DataMember(Name="lndLossPayeeZip", EmitDefaultValue=false)]
		public string LndLossPayeeZip { get; set; }

		[DataMember(Name="lndMersIdNum", EmitDefaultValue=false)]
		public string LndMersIdNum { get; set; }

		[DataMember(Name="lndNm", EmitDefaultValue=false)]
		public string LndNm { get; set; }

		[DataMember(Name="lndNmlsIdNum", EmitDefaultValue=false)]
		public string LndNmlsIdNum { get; set; }

		[DataMember(Name="lndNtryCmsnBndNumIdntfr", EmitDefaultValue=false)]
		public string LndNtryCmsnBndNumIdntfr { get; set; }

		[DataMember(Name="lndNtryCmsnCnty", EmitDefaultValue=false)]
		public string LndNtryCmsnCnty { get; set; }

		[DataMember(Name="lndNtryCmsnExprDt", EmitDefaultValue=false)]
		public DateTime? LndNtryCmsnExprDt { get; set; }

		[DataMember(Name="lndNtryCmsnNumIdntfr", EmitDefaultValue=false)]
		public string LndNtryCmsnNumIdntfr { get; set; }

		[DataMember(Name="lndNtryCmsnSt", EmitDefaultValue=false)]
		public string LndNtryCmsnSt { get; set; }

		[DataMember(Name="lndNtryCty", EmitDefaultValue=false)]
		public string LndNtryCty { get; set; }

		[DataMember(Name="lndNtryNm", EmitDefaultValue=false)]
		public string LndNtryNm { get; set; }

		[DataMember(Name="lndNtryStCd", EmitDefaultValue=false)]
		public string LndNtryStCd { get; set; }

		[DataMember(Name="lndNtryStreetAddr1", EmitDefaultValue=false)]
		public string LndNtryStreetAddr1 { get; set; }

		[DataMember(Name="lndNtryStreetAddr2", EmitDefaultValue=false)]
		public string LndNtryStreetAddr2 { get; set; }

		[DataMember(Name="lndNtryTtlOrRank", EmitDefaultValue=false)]
		public string LndNtryTtlOrRank { get; set; }

		[DataMember(Name="lndNtryZip", EmitDefaultValue=false)]
		public string LndNtryZip { get; set; }

		[DataMember(Name="lndOrgTyp", EmitDefaultValue=false)]
		public string LndOrgTyp { get; set; }

		[DataMember(Name="lndPhoneNum", EmitDefaultValue=false)]
		public string LndPhoneNum { get; set; }

		[DataMember(Name="lndStCd", EmitDefaultValue=false)]
		public string LndStCd { get; set; }

		[DataMember(Name="lndStreetAddr1", EmitDefaultValue=false)]
		public string LndStreetAddr1 { get; set; }

		[DataMember(Name="lndStreetAddr2", EmitDefaultValue=false)]
		public string LndStreetAddr2 { get; set; }

		[DataMember(Name="lndSvcrAdtlTxt", EmitDefaultValue=false)]
		public string LndSvcrAdtlTxt { get; set; }

		[DataMember(Name="lndSvcrCntctNm", EmitDefaultValue=false)]
		public string LndSvcrCntctNm { get; set; }

		[DataMember(Name="lndSvcrCntctPhoneNum", EmitDefaultValue=false)]
		public string LndSvcrCntctPhoneNum { get; set; }

		[DataMember(Name="lndSvcrCntctTollFreePhoneNum", EmitDefaultValue=false)]
		public string LndSvcrCntctTollFreePhoneNum { get; set; }

		[DataMember(Name="lndSvcrCty", EmitDefaultValue=false)]
		public string LndSvcrCty { get; set; }

		[DataMember(Name="lndSvcrDayOp", EmitDefaultValue=false)]
		public string LndSvcrDayOp { get; set; }

		[DataMember(Name="lndSvcrDayOpAddl", EmitDefaultValue=false)]
		public string LndSvcrDayOpAddl { get; set; }

		[DataMember(Name="lndSvcrHrsOp", EmitDefaultValue=false)]
		public string LndSvcrHrsOp { get; set; }

		[DataMember(Name="lndSvcrHrsOpAddl", EmitDefaultValue=false)]
		public string LndSvcrHrsOpAddl { get; set; }

		[DataMember(Name="lndSvcrJrsdctn", EmitDefaultValue=false)]
		public string LndSvcrJrsdctn { get; set; }

		[DataMember(Name="lndSvcrNm", EmitDefaultValue=false)]
		public string LndSvcrNm { get; set; }

		[DataMember(Name="lndSvcrOrgTyp", EmitDefaultValue=false)]
		public string LndSvcrOrgTyp { get; set; }

		[DataMember(Name="lndSvcrStCd", EmitDefaultValue=false)]
		public string LndSvcrStCd { get; set; }

		[DataMember(Name="lndSvcrStreetAddr1", EmitDefaultValue=false)]
		public string LndSvcrStreetAddr1 { get; set; }

		[DataMember(Name="lndSvcrStreetAddr2", EmitDefaultValue=false)]
		public string LndSvcrStreetAddr2 { get; set; }

		[DataMember(Name="lndSvcrZip", EmitDefaultValue=false)]
		public string LndSvcrZip { get; set; }

		[DataMember(Name="lndTaxIDNum", EmitDefaultValue=false)]
		public string LndTaxIDNum { get; set; }

		[DataMember(Name="lndTollFreePhoneNum", EmitDefaultValue=false)]
		public string LndTollFreePhoneNum { get; set; }

		[DataMember(Name="lndUrl", EmitDefaultValue=false)]
		public string LndUrl { get; set; }

		[DataMember(Name="lndVaIdNum", EmitDefaultValue=false)]
		public string LndVaIdNum { get; set; }

		[DataMember(Name="lndZip", EmitDefaultValue=false)]
		public string LndZip { get; set; }

	}
}