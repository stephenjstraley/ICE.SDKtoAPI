using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEmDocumentLender
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lndBrchCty")]
		public string LndBrchCty { get; set; }

		[DataMember(Name="lndBrchFax")]
		public string LndBrchFax { get; set; }

		[DataMember(Name="lndBrchJrsdctn")]
		public string LndBrchJrsdctn { get; set; }

		[DataMember(Name="lndBrchNm")]
		public string LndBrchNm { get; set; }

		[DataMember(Name="lndBrchOrgTyp")]
		public string LndBrchOrgTyp { get; set; }

		[DataMember(Name="lndBrchPhone")]
		public string LndBrchPhone { get; set; }

		[DataMember(Name="lndBrchStCd")]
		public string LndBrchStCd { get; set; }

		[DataMember(Name="lndBrchStreetAddr1")]
		public string LndBrchStreetAddr1 { get; set; }

		[DataMember(Name="lndBrchStreetAddr2")]
		public string LndBrchStreetAddr2 { get; set; }

		[DataMember(Name="lndBrchTollFreePhone")]
		public string LndBrchTollFreePhone { get; set; }

		[DataMember(Name="lndBrchUrl")]
		public string LndBrchUrl { get; set; }

		[DataMember(Name="lndBrchZip")]
		public string LndBrchZip { get; set; }

		[DataMember(Name="lndCnty")]
		public string LndCnty { get; set; }

		[DataMember(Name="lndCty")]
		public string LndCty { get; set; }

		[DataMember(Name="lndFaxNum")]
		public string LndFaxNum { get; set; }

		[DataMember(Name="lndFhaOrgntrId")]
		public string LndFhaOrgntrId { get; set; }

		[DataMember(Name="lndFhaSpnsrId")]
		public string LndFhaSpnsrId { get; set; }

		[DataMember(Name="lndJrsdctn")]
		public string LndJrsdctn { get; set; }

		[DataMember(Name="lndLossPayeeAdtlTxt")]
		public string LndLossPayeeAdtlTxt { get; set; }

		[DataMember(Name="lndLossPayeeCntctEmail")]
		public string LndLossPayeeCntctEmail { get; set; }

		[DataMember(Name="lndLossPayeeCntctFax")]
		public string LndLossPayeeCntctFax { get; set; }

		[DataMember(Name="lndLossPayeeCntctNm")]
		public string LndLossPayeeCntctNm { get; set; }

		[DataMember(Name="lndLossPayeeCntctPhone")]
		public string LndLossPayeeCntctPhone { get; set; }

		[DataMember(Name="lndLossPayeeCty")]
		public string LndLossPayeeCty { get; set; }

		[DataMember(Name="lndLossPayeeJrsdctn")]
		public string LndLossPayeeJrsdctn { get; set; }

		[DataMember(Name="lndLossPayeeNm")]
		public string LndLossPayeeNm { get; set; }

		[DataMember(Name="lndLossPayeeOrgTyp")]
		public string LndLossPayeeOrgTyp { get; set; }

		[DataMember(Name="lndLossPayeeScsrsClausTxtDesc")]
		public string LndLossPayeeScsrsClausTxtDesc { get; set; }

		[DataMember(Name="lndLossPayeeStCd")]
		public string LndLossPayeeStCd { get; set; }

		[DataMember(Name="lndLossPayeeStreetAddr1")]
		public string LndLossPayeeStreetAddr1 { get; set; }

		[DataMember(Name="lndLossPayeeStreetAddr2")]
		public string LndLossPayeeStreetAddr2 { get; set; }

		[DataMember(Name="lndLossPayeeZip")]
		public string LndLossPayeeZip { get; set; }

		[DataMember(Name="lndMersIdNum")]
		public string LndMersIdNum { get; set; }

		[DataMember(Name="lndNm")]
		public string LndNm { get; set; }

		[DataMember(Name="lndNmlsIdNum")]
		public string LndNmlsIdNum { get; set; }

		[DataMember(Name="lndNtryCmsnBndNumIdntfr")]
		public string LndNtryCmsnBndNumIdntfr { get; set; }

		[DataMember(Name="lndNtryCmsnCnty")]
		public string LndNtryCmsnCnty { get; set; }

		[DataMember(Name="lndNtryCmsnExprDt")]
		public DateTime? LndNtryCmsnExprDt { get; set; }

		[DataMember(Name="lndNtryCmsnNumIdntfr")]
		public string LndNtryCmsnNumIdntfr { get; set; }

		[DataMember(Name="lndNtryCmsnSt")]
		public string LndNtryCmsnSt { get; set; }

		[DataMember(Name="lndNtryCty")]
		public string LndNtryCty { get; set; }

		[DataMember(Name="lndNtryNm")]
		public string LndNtryNm { get; set; }

		[DataMember(Name="lndNtryStCd")]
		public string LndNtryStCd { get; set; }

		[DataMember(Name="lndNtryStreetAddr1")]
		public string LndNtryStreetAddr1 { get; set; }

		[DataMember(Name="lndNtryStreetAddr2")]
		public string LndNtryStreetAddr2 { get; set; }

		[DataMember(Name="lndNtryTtlOrRank")]
		public string LndNtryTtlOrRank { get; set; }

		[DataMember(Name="lndNtryZip")]
		public string LndNtryZip { get; set; }

		[DataMember(Name="lndOrgTyp")]
		public string LndOrgTyp { get; set; }

		[DataMember(Name="lndPhoneNum")]
		public string LndPhoneNum { get; set; }

		[DataMember(Name="lndStCd")]
		public string LndStCd { get; set; }

		[DataMember(Name="lndStreetAddr1")]
		public string LndStreetAddr1 { get; set; }

		[DataMember(Name="lndStreetAddr2")]
		public string LndStreetAddr2 { get; set; }

		[DataMember(Name="lndSvcrAdtlTxt")]
		public string LndSvcrAdtlTxt { get; set; }

		[DataMember(Name="lndSvcrCntctNm")]
		public string LndSvcrCntctNm { get; set; }

		[DataMember(Name="lndSvcrCntctPhoneNum")]
		public string LndSvcrCntctPhoneNum { get; set; }

		[DataMember(Name="lndSvcrCntctTollFreePhoneNum")]
		public string LndSvcrCntctTollFreePhoneNum { get; set; }

		[DataMember(Name="lndSvcrCty")]
		public string LndSvcrCty { get; set; }

		[DataMember(Name="lndSvcrDayOp")]
		public string LndSvcrDayOp { get; set; }

		[DataMember(Name="lndSvcrDayOpAddl")]
		public string LndSvcrDayOpAddl { get; set; }

		[DataMember(Name="lndSvcrHrsOp")]
		public string LndSvcrHrsOp { get; set; }

		[DataMember(Name="lndSvcrHrsOpAddl")]
		public string LndSvcrHrsOpAddl { get; set; }

		[DataMember(Name="lndSvcrJrsdctn")]
		public string LndSvcrJrsdctn { get; set; }

		[DataMember(Name="lndSvcrNm")]
		public string LndSvcrNm { get; set; }

		[DataMember(Name="lndSvcrOrgTyp")]
		public string LndSvcrOrgTyp { get; set; }

		[DataMember(Name="lndSvcrStCd")]
		public string LndSvcrStCd { get; set; }

		[DataMember(Name="lndSvcrStreetAddr1")]
		public string LndSvcrStreetAddr1 { get; set; }

		[DataMember(Name="lndSvcrStreetAddr2")]
		public string LndSvcrStreetAddr2 { get; set; }

		[DataMember(Name="lndSvcrZip")]
		public string LndSvcrZip { get; set; }

		[DataMember(Name="lndTaxIDNum")]
		public string LndTaxIDNum { get; set; }

		[DataMember(Name="lndTollFreePhoneNum")]
		public string LndTollFreePhoneNum { get; set; }

		[DataMember(Name="lndUrl")]
		public string LndUrl { get; set; }

		[DataMember(Name="lndVaIdNum")]
		public string LndVaIdNum { get; set; }

		[DataMember(Name="lndZip")]
		public string LndZip { get; set; }

	}
}