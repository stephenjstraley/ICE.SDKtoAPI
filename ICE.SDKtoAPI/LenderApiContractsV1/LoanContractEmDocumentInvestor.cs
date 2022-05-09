using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEmDocumentInvestor
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="invAsgnCty", EmitDefaultValue=false)]
		public string InvAsgnCty { get; set; }

		[DataMember(Name="invAsgnJrsdctn", EmitDefaultValue=false)]
		public string InvAsgnJrsdctn { get; set; }

		[DataMember(Name="invAsgnNm", EmitDefaultValue=false)]
		public string InvAsgnNm { get; set; }

		[DataMember(Name="invAsgnOrgTyp", EmitDefaultValue=false)]
		public string InvAsgnOrgTyp { get; set; }

		[DataMember(Name="invAsgnStCd", EmitDefaultValue=false)]
		public string InvAsgnStCd { get; set; }

		[DataMember(Name="invAsgnStreetAddr1", EmitDefaultValue=false)]
		public string InvAsgnStreetAddr1 { get; set; }

		[DataMember(Name="invAsgnStreetAddr2", EmitDefaultValue=false)]
		public string InvAsgnStreetAddr2 { get; set; }

		[DataMember(Name="invAsgnZip", EmitDefaultValue=false)]
		public string InvAsgnZip { get; set; }

		[DataMember(Name="invCty", EmitDefaultValue=false)]
		public string InvCty { get; set; }

		[DataMember(Name="invFaxNum", EmitDefaultValue=false)]
		public string InvFaxNum { get; set; }

		[DataMember(Name="invJrsdctn", EmitDefaultValue=false)]
		public string InvJrsdctn { get; set; }

		[DataMember(Name="invLossPayeeAdtlTxt", EmitDefaultValue=false)]
		public string InvLossPayeeAdtlTxt { get; set; }

		[DataMember(Name="invLossPayeeCntctEmail", EmitDefaultValue=false)]
		public string InvLossPayeeCntctEmail { get; set; }

		[DataMember(Name="invLossPayeeCntctFax", EmitDefaultValue=false)]
		public string InvLossPayeeCntctFax { get; set; }

		[DataMember(Name="invLossPayeeCntctNm", EmitDefaultValue=false)]
		public string InvLossPayeeCntctNm { get; set; }

		[DataMember(Name="invLossPayeeCntctPhone", EmitDefaultValue=false)]
		public string InvLossPayeeCntctPhone { get; set; }

		[DataMember(Name="invLossPayeeCty", EmitDefaultValue=false)]
		public string InvLossPayeeCty { get; set; }

		[DataMember(Name="invLossPayeeJrsdctn", EmitDefaultValue=false)]
		public string InvLossPayeeJrsdctn { get; set; }

		[DataMember(Name="invLossPayeeNm", EmitDefaultValue=false)]
		public string InvLossPayeeNm { get; set; }

		[DataMember(Name="invLossPayeeOrgTyp", EmitDefaultValue=false)]
		public string InvLossPayeeOrgTyp { get; set; }

		[DataMember(Name="invLossPayeeScsrClausTxtDesc", EmitDefaultValue=false)]
		public string InvLossPayeeScsrClausTxtDesc { get; set; }

		[DataMember(Name="invLossPayeeStCd", EmitDefaultValue=false)]
		public string InvLossPayeeStCd { get; set; }

		[DataMember(Name="invLossPayeeStreetAddr1", EmitDefaultValue=false)]
		public string InvLossPayeeStreetAddr1 { get; set; }

		[DataMember(Name="invLossPayeeStreetAddr2", EmitDefaultValue=false)]
		public string InvLossPayeeStreetAddr2 { get; set; }

		[DataMember(Name="invLossPayeeZip", EmitDefaultValue=false)]
		public string InvLossPayeeZip { get; set; }

		[DataMember(Name="invNm", EmitDefaultValue=false)]
		public string InvNm { get; set; }

		[DataMember(Name="invOrgTyp", EmitDefaultValue=false)]
		public string InvOrgTyp { get; set; }

		[DataMember(Name="invPhoneNum", EmitDefaultValue=false)]
		public string InvPhoneNum { get; set; }

		[DataMember(Name="invPmtCpn2PayToAdtlTxt", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpn2PayToAdtlTxt2", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToAdtlTxt2 { get; set; }

		[DataMember(Name="invPmtCpn2PayToCty", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToCty { get; set; }

		[DataMember(Name="invPmtCpn2PayToNm", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToNm { get; set; }

		[DataMember(Name="invPmtCpn2PayToStCd", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToStCd { get; set; }

		[DataMember(Name="invPmtCpn2PayToStreetAddr1", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpn2PayToStreetAddr2", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpn2PayToZip", EmitDefaultValue=false)]
		public string InvPmtCpn2PayToZip { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToAdtlTxt", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToCty", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToCty { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToNm", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToNm { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToStCd", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToStCd { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToStreetAddr1", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToStreetAddr2", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcAdtlTxt", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToSvcAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcCty", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToSvcCty { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcNm", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToSvcNm { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcStCd", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToSvcStCd { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcStreetAddr1", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToSvcStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcStreetAddr2", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToSvcStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToSvcZip", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToSvcZip { get; set; }

		[DataMember(Name="invPmtCpnLoanTrsfToZip", EmitDefaultValue=false)]
		public string InvPmtCpnLoanTrsfToZip { get; set; }

		[DataMember(Name="invPmtCpnPayToAdtlTxt", EmitDefaultValue=false)]
		public string InvPmtCpnPayToAdtlTxt { get; set; }

		[DataMember(Name="invPmtCpnPayToAdtlTxt2", EmitDefaultValue=false)]
		public string InvPmtCpnPayToAdtlTxt2 { get; set; }

		[DataMember(Name="invPmtCpnPayToCty", EmitDefaultValue=false)]
		public string InvPmtCpnPayToCty { get; set; }

		[DataMember(Name="invPmtCpnPayToNm", EmitDefaultValue=false)]
		public string InvPmtCpnPayToNm { get; set; }

		[DataMember(Name="invPmtCpnPayToStCd", EmitDefaultValue=false)]
		public string InvPmtCpnPayToStCd { get; set; }

		[DataMember(Name="invPmtCpnPayToStreetAddr1", EmitDefaultValue=false)]
		public string InvPmtCpnPayToStreetAddr1 { get; set; }

		[DataMember(Name="invPmtCpnPayToStreetAddr2", EmitDefaultValue=false)]
		public string InvPmtCpnPayToStreetAddr2 { get; set; }

		[DataMember(Name="invPmtCpnPayToZip", EmitDefaultValue=false)]
		public string InvPmtCpnPayToZip { get; set; }

		[DataMember(Name="invStCd", EmitDefaultValue=false)]
		public string InvStCd { get; set; }

		[DataMember(Name="invStreetAddr1", EmitDefaultValue=false)]
		public string InvStreetAddr1 { get; set; }

		[DataMember(Name="invStreetAddr2", EmitDefaultValue=false)]
		public string InvStreetAddr2 { get; set; }

		[DataMember(Name="invSvcrAdtlTxt", EmitDefaultValue=false)]
		public string InvSvcrAdtlTxt { get; set; }

		[DataMember(Name="invSvcrCntctNm", EmitDefaultValue=false)]
		public string InvSvcrCntctNm { get; set; }

		[DataMember(Name="invSvcrCntctPhoneNum", EmitDefaultValue=false)]
		public string InvSvcrCntctPhoneNum { get; set; }

		[DataMember(Name="invSvcrCntctTollFreePhoneNum", EmitDefaultValue=false)]
		public string InvSvcrCntctTollFreePhoneNum { get; set; }

		[DataMember(Name="invSvcrCty", EmitDefaultValue=false)]
		public string InvSvcrCty { get; set; }

		[DataMember(Name="invSvcrDayOp", EmitDefaultValue=false)]
		public string InvSvcrDayOp { get; set; }

		[DataMember(Name="invSvcrDayOpAddl", EmitDefaultValue=false)]
		public string InvSvcrDayOpAddl { get; set; }

		[DataMember(Name="invSvcrHrsOp", EmitDefaultValue=false)]
		public string InvSvcrHrsOp { get; set; }

		[DataMember(Name="invSvcrHrsOpAddl", EmitDefaultValue=false)]
		public string InvSvcrHrsOpAddl { get; set; }

		[DataMember(Name="invSvcrJrsdctn", EmitDefaultValue=false)]
		public string InvSvcrJrsdctn { get; set; }

		[DataMember(Name="invSvcrNm", EmitDefaultValue=false)]
		public string InvSvcrNm { get; set; }

		[DataMember(Name="invSvcrOrgTyp", EmitDefaultValue=false)]
		public string InvSvcrOrgTyp { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToAdtlTxt", EmitDefaultValue=false)]
		public string InvSvcrQlfdWrtnRqstMailToAdtlTxt { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToCty", EmitDefaultValue=false)]
		public string InvSvcrQlfdWrtnRqstMailToCty { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToNm", EmitDefaultValue=false)]
		public string InvSvcrQlfdWrtnRqstMailToNm { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToStCd", EmitDefaultValue=false)]
		public string InvSvcrQlfdWrtnRqstMailToStCd { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToStreetAddr1", EmitDefaultValue=false)]
		public string InvSvcrQlfdWrtnRqstMailToStreetAddr1 { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToStreetAddr2", EmitDefaultValue=false)]
		public string InvSvcrQlfdWrtnRqstMailToStreetAddr2 { get; set; }

		[DataMember(Name="invSvcrQlfdWrtnRqstMailToZip", EmitDefaultValue=false)]
		public string InvSvcrQlfdWrtnRqstMailToZip { get; set; }

		[DataMember(Name="invSvcrStCd", EmitDefaultValue=false)]
		public string InvSvcrStCd { get; set; }

		[DataMember(Name="invSvcrStreetAddr1", EmitDefaultValue=false)]
		public string InvSvcrStreetAddr1 { get; set; }

		[DataMember(Name="invSvcrStreetAddr2", EmitDefaultValue=false)]
		public string InvSvcrStreetAddr2 { get; set; }

		[DataMember(Name="invSvcrZip", EmitDefaultValue=false)]
		public string InvSvcrZip { get; set; }

		[DataMember(Name="invTaxIDNum", EmitDefaultValue=false)]
		public string InvTaxIDNum { get; set; }

		[DataMember(Name="invTollFreePhoneNum", EmitDefaultValue=false)]
		public string InvTollFreePhoneNum { get; set; }

		[DataMember(Name="invUrl", EmitDefaultValue=false)]
		public string InvUrl { get; set; }

		[DataMember(Name="invZip", EmitDefaultValue=false)]
		public string InvZip { get; set; }

	}
}