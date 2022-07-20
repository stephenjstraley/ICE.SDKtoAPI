using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEmDocumentInvestor
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="invAsgnCty")]
		public string InvAsgnCty { get; set; }

		[DataMember(Name="invAsgnJrsdctn")]
		public string InvAsgnJrsdctn { get; set; }

		[DataMember(Name="invAsgnNm")]
		public string InvAsgnNm { get; set; }

		[DataMember(Name="invAsgnOrgTyp")]
		public string InvAsgnOrgTyp { get; set; }

		[DataMember(Name="invAsgnStCd")]
		public string InvAsgnStCd { get; set; }

		[DataMember(Name="invAsgnStreetAddr1")]
		public string InvAsgnStreetAddr1 { get; set; }

		[DataMember(Name="invAsgnStreetAddr2")]
		public string InvAsgnStreetAddr2 { get; set; }

		[DataMember(Name="invAsgnZip")]
		public string InvAsgnZip { get; set; }

		[DataMember(Name="invCty")]
		public string InvCty { get; set; }

		[DataMember(Name="invFaxNum")]
		public string InvFaxNum { get; set; }

		[DataMember(Name="invJrsdctn")]
		public string InvJrsdctn { get; set; }

		[DataMember(Name="invLossPayeeAdtlTxt")]
		public string InvLossPayeeAdtlTxt { get; set; }

		[DataMember(Name="invLossPayeeCntctEmail")]
		public string InvLossPayeeCntctEmail { get; set; }

		[DataMember(Name="invLossPayeeCntctFax")]
		public string InvLossPayeeCntctFax { get; set; }

		[DataMember(Name="invLossPayeeCntctNm")]
		public string InvLossPayeeCntctNm { get; set; }

		[DataMember(Name="invLossPayeeCntctPhone")]
		public string InvLossPayeeCntctPhone { get; set; }

		[DataMember(Name="invLossPayeeCty")]
		public string InvLossPayeeCty { get; set; }

		[DataMember(Name="invLossPayeeJrsdctn")]
		public string InvLossPayeeJrsdctn { get; set; }

		[DataMember(Name="invLossPayeeNm")]
		public string InvLossPayeeNm { get; set; }

		[DataMember(Name="invLossPayeeOrgTyp")]
		public string InvLossPayeeOrgTyp { get; set; }

		[DataMember(Name="invLossPayeeScsrClausTxtDesc")]
		public string InvLossPayeeScsrClausTxtDesc { get; set; }

		[DataMember(Name="invLossPayeeStCd")]
		public string InvLossPayeeStCd { get; set; }

		[DataMember(Name="invLossPayeeStreetAddr1")]
		public string InvLossPayeeStreetAddr1 { get; set; }

		[DataMember(Name="invLossPayeeStreetAddr2")]
		public string InvLossPayeeStreetAddr2 { get; set; }

		[DataMember(Name="invLossPayeeZip")]
		public string InvLossPayeeZip { get; set; }

		[DataMember(Name="invNm")]
		public string InvNm { get; set; }

		[DataMember(Name="invOrgTyp")]
		public string InvOrgTyp { get; set; }

		[DataMember(Name="invPhoneNum")]
		public string InvPhoneNum { get; set; }

		[DataMember(Name="invPmtCpn2PayToAdtlTxt")]
		public string InvPmtCpn2PayToAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpn2PayToAdtlTxt2")]
		public string InvPmtCpn2PayToAdtlTxt2 { get; set; }

		[DataMember(Name="invPmtCpn2PayToCty")]
		public string InvPmtCpn2PayToCty { get; set; }

		[DataMember(Name="invPmtCpn2PayToNm")]
		public string InvPmtCpn2PayToNm { get; set; }

		[DataMember(Name="invPmtCpn2PayToStCd")]
		public string InvPmtCpn2PayToStCd { get; set; }

		[DataMember(Name="invPmtCpn2PayToStreetAddr1")]
		public string InvPmtCpn2PayToStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpn2PayToStreetAddr2")]
		public string InvPmtCpn2PayToStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpn2PayToZip")]
		public string InvPmtCpn2PayToZip { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToAdtlTxt")]
		public string InvPmtCpnLoanTrsfToAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToCty")]
		public string InvPmtCpnLoanTrsfToCty { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToNm")]
		public string InvPmtCpnLoanTrsfToNm { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToStCd")]
		public string InvPmtCpnLoanTrsfToStCd { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToStreetAddr1")]
		public string InvPmtCpnLoanTrsfToStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToStreetAddr2")]
		public string InvPmtCpnLoanTrsfToStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcAdtlTxt")]
		public string InvPmtCpnLoanTrsfToSvcAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcCty")]
		public string InvPmtCpnLoanTrsfToSvcCty { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcNm")]
		public string InvPmtCpnLoanTrsfToSvcNm { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcStCd")]
		public string InvPmtCpnLoanTrsfToSvcStCd { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcStreetAddr1")]
		public string InvPmtCpnLoanTrsfToSvcStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcStreetAddr2")]
		public string InvPmtCpnLoanTrsfToSvcStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcZip")]
		public string InvPmtCpnLoanTrsfToSvcZip { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToZip")]
		public string InvPmtCpnLoanTrsfToZip { get; set; }

		[DataMember(Name="invPmtCpnPayToAdtlTxt")]
		public string InvPmtCpnPayToAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpnPayToAdtlTxt2")]
		public string InvPmtCpnPayToAdtlTxt2 { get; set; }

		[DataMember(Name="invPmtCpnPayToCty")]
		public string InvPmtCpnPayToCty { get; set; }

		[DataMember(Name="invPmtCpnPayToNm")]
		public string InvPmtCpnPayToNm { get; set; }

		[DataMember(Name="invPmtCpnPayToStCd")]
		public string InvPmtCpnPayToStCd { get; set; }

		[DataMember(Name="invPmtCpnPayToStreetAddr1")]
		public string InvPmtCpnPayToStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpnPayToStreetAddr2")]
		public string InvPmtCpnPayToStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpnPayToZip")]
		public string InvPmtCpnPayToZip { get; set; }

		[DataMember(Name="invStCd")]
		public string InvStCd { get; set; }

		[DataMember(Name="invStreetAddr1")]
		public string InvStreetAddr1 { get; set; }

		[DataMember(Name="invStreetAddr2")]
		public string InvStreetAddr2 { get; set; }

		[DataMember(Name="invSvcrAdtlTxt")]
		public string InvSvcrAdtlTxt { get; set; }

		[DataMember(Name="invSvcrCntctNm")]
		public string InvSvcrCntctNm { get; set; }

		[DataMember(Name="invSvcrCntctPhoneNum")]
		public string InvSvcrCntctPhoneNum { get; set; }

		[DataMember(Name="invSvcrCntctTollFreePhoneNum")]
		public string InvSvcrCntctTollFreePhoneNum { get; set; }

		[DataMember(Name="invSvcrCty")]
		public string InvSvcrCty { get; set; }

		[DataMember(Name="invSvcrDayOp")]
		public string InvSvcrDayOp { get; set; }

		[DataMember(Name="invSvcrDayOpAddl")]
		public string InvSvcrDayOpAddl { get; set; }

		[DataMember(Name="invSvcrHrsOp")]
		public string InvSvcrHrsOp { get; set; }

		[DataMember(Name="invSvcrHrsOpAddl")]
		public string InvSvcrHrsOpAddl { get; set; }

		[DataMember(Name="invSvcrJrsdctn")]
		public string InvSvcrJrsdctn { get; set; }

		[DataMember(Name="invSvcrNm")]
		public string InvSvcrNm { get; set; }

		[DataMember(Name="invSvcrOrgTyp")]
		public string InvSvcrOrgTyp { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToAdtlTxt")]
		public string InvSvcrQlfdWrtnRqstMailToAdtlTxt { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToCty")]
		public string InvSvcrQlfdWrtnRqstMailToCty { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToNm")]
		public string InvSvcrQlfdWrtnRqstMailToNm { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToStCd")]
		public string InvSvcrQlfdWrtnRqstMailToStCd { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToStreetAddr1")]
		public string InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToStreetAddr2")]
		public string InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToZip")]
		public string InvSvcrQlfdWrtnRqstMailToZip { get; set; }

		[DataMember(Name="invSvcrStCd")]
		public string InvSvcrStCd { get; set; }

		[DataMember(Name="invSvcrStreetAddr1")]
		public string InvSvcrStreetAddr1 { get; set; }

		[DataMember(Name="invSvcrStreetAddr2")]
		public string InvSvcrStreetAddr2 { get; set; }

		[DataMember(Name="invSvcrZip")]
		public string InvSvcrZip { get; set; }

		[DataMember(Name="invTaxIDNum")]
		public string InvTaxIDNum { get; set; }

		[DataMember(Name="invTollFreePhoneNum")]
		public string InvTollFreePhoneNum { get; set; }

		[DataMember(Name="invUrl")]
		public string InvUrl { get; set; }

		[DataMember(Name="invZip")]
		public string InvZip { get; set; }

	}
}