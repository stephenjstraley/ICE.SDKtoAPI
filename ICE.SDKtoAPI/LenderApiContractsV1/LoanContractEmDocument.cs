using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEmDocument
	{
		[DataMember(Name="allngToNtPayToJrsdctn", EmitDefaultValue=false)]
		public string AllngToNtPayToJrsdctn { get; set; }

		[DataMember(Name="allngToNtPayToOrdNm", EmitDefaultValue=false)]
		public string AllngToNtPayToOrdNm { get; set; }

		[DataMember(Name="allngToNtPayToOrgTyp", EmitDefaultValue=false)]
		public string AllngToNtPayToOrgTyp { get; set; }

		[DataMember(Name="allngToNtPayToScsrsClaus", EmitDefaultValue=false)]
		public string AllngToNtPayToScsrsClaus { get; set; }

		[DataMember(Name="allngToNtSignedByNm", EmitDefaultValue=false)]
		public string AllngToNtSignedByNm { get; set; }

		[DataMember(Name="allngToNtSignedByNm2", EmitDefaultValue=false)]
		public string AllngToNtSignedByNm2 { get; set; }

		[DataMember(Name="allngToNtSignedByNm3", EmitDefaultValue=false)]
		public string AllngToNtSignedByNm3 { get; set; }

		[DataMember(Name="allngToNtSignedByTtl", EmitDefaultValue=false)]
		public string AllngToNtSignedByTtl { get; set; }

		[DataMember(Name="allngToNtSignedByTtl2", EmitDefaultValue=false)]
		public string AllngToNtSignedByTtl2 { get; set; }

		[DataMember(Name="allngToNtSignedByTtl3", EmitDefaultValue=false)]
		public string AllngToNtSignedByTtl3 { get; set; }

		[DataMember(Name="allngToNtSignedByTyp", EmitDefaultValue=false)]
		public string AllngToNtSignedByTyp { get; set; }

		[DataMember(Name="allngToNtWithoutRcrse", EmitDefaultValue=false)]
		public string AllngToNtWithoutRcrse { get; set; }

		[DataMember(Name="apnLbl", EmitDefaultValue=false)]
		public string ApnLbl { get; set; }

		[DataMember(Name="asgnPrepByLblTxtDesc", EmitDefaultValue=false)]
		public bool? AsgnPrepByLblTxtDesc { get; set; }

		[DataMember(Name="asgnRecRtrnLblTxtDesc", EmitDefaultValue=false)]
		public bool? AsgnRecRtrnLblTxtDesc { get; set; }

		[DataMember(Name="benCty", EmitDefaultValue=false)]
		public string BenCty { get; set; }

		[DataMember(Name="benJrsdctn", EmitDefaultValue=false)]
		public string BenJrsdctn { get; set; }

		[DataMember(Name="benNm", EmitDefaultValue=false)]
		public string BenNm { get; set; }

		[DataMember(Name="benOrgTyp", EmitDefaultValue=false)]
		public string BenOrgTyp { get; set; }

		[DataMember(Name="benStCd", EmitDefaultValue=false)]
		public string BenStCd { get; set; }

		[DataMember(Name="benStreetAddr1", EmitDefaultValue=false)]
		public string BenStreetAddr1 { get; set; }

		[DataMember(Name="benStreetAddr2", EmitDefaultValue=false)]
		public string BenStreetAddr2 { get; set; }

		[DataMember(Name="benZip", EmitDefaultValue=false)]
		public string BenZip { get; set; }

		[DataMember(Name="closInstrLndCntcInfoCity", EmitDefaultValue=false)]
		public string ClosInstrLndCntcInfoCity { get; set; }

		[DataMember(Name="closInstrLndCntcInfoCoNm", EmitDefaultValue=false)]
		public string ClosInstrLndCntcInfoCoNm { get; set; }

		[DataMember(Name="closInstrLndCntcInfoSamePtyTypDesc", EmitDefaultValue=false)]
		public string ClosInstrLndCntcInfoSamePtyTypDesc { get; set; }

		[DataMember(Name="closInstrLndCntcInfoStCd", EmitDefaultValue=false)]
		public string ClosInstrLndCntcInfoStCd { get; set; }

		[DataMember(Name="closInstrLndCntcInfoStreetAddr1", EmitDefaultValue=false)]
		public string ClosInstrLndCntcInfoStreetAddr1 { get; set; }

		[DataMember(Name="closInstrLndCntcInfoStreetAddr2", EmitDefaultValue=false)]
		public string ClosInstrLndCntcInfoStreetAddr2 { get; set; }

		[DataMember(Name="closInstrLndCntcInfoZip", EmitDefaultValue=false)]
		public string ClosInstrLndCntcInfoZip { get; set; }

		[DataMember(Name="closInstrPrtInvLossPayee", EmitDefaultValue=false)]
		public bool? ClosInstrPrtInvLossPayee { get; set; }

		[DataMember(Name="closInstrStlmtAgtUseLndHud1", EmitDefaultValue=false)]
		public bool? ClosInstrStlmtAgtUseLndHud1 { get; set; }

		[DataMember(Name="closInstrTtlPlcyTyp", EmitDefaultValue=false)]
		public string ClosInstrTtlPlcyTyp { get; set; }

		[DataMember(Name="emxmlVersionId", EmitDefaultValue=false)]
		public string EmxmlVersionId { get; set; }

		[DataMember(Name="exeClosDocDlvrdToCty", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToCty { get; set; }

		[DataMember(Name="exeClosDocDlvrdToMiscTxtDesc", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToMiscTxtDesc { get; set; }

		[DataMember(Name="exeClosDocDlvrdToNm", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToNm { get; set; }

		[DataMember(Name="exeClosDocDlvrdToSamePtyTypDesc", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToSamePtyTypDesc { get; set; }

		[DataMember(Name="exeClosDocDlvrdToStCd", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToStCd { get; set; }

		[DataMember(Name="exeClosDocDlvrdToStreetAddr1", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToStreetAddr1 { get; set; }

		[DataMember(Name="exeClosDocDlvrdToStreetAddr2", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToStreetAddr2 { get; set; }

		[DataMember(Name="exeClosDocDlvrdToZip", EmitDefaultValue=false)]
		public string ExeClosDocDlvrdToZip { get; set; }

		[DataMember(Name="exeClosDocExprDt", EmitDefaultValue=false)]
		public string ExeClosDocExprDt { get; set; }

		[DataMember(Name="exeClosDocToBeRtrnd", EmitDefaultValue=false)]
		public string ExeClosDocToBeRtrnd { get; set; }

		[DataMember(Name="exeClosDocToBeRtrndHrs", EmitDefaultValue=false)]
		public string ExeClosDocToBeRtrndHrs { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToAddlLine1", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToAddlLine1 { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToAddlLine2", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToAddlLine2 { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToCty", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToCty { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToNm", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToNm { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToSamePtyTypDesc", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToSamePtyTypDesc { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToStcd", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToStcd { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToStreetAddr1", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToStreetAddr1 { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToStreetAddr2", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToStreetAddr2 { get; set; }

		[DataMember(Name="fnlTtlePcyRecDocsSentToZip", EmitDefaultValue=false)]
		public string FnlTtlePcyRecDocsSentToZip { get; set; }

		[DataMember(Name="hazInsurEndsmtMailToAdtlTxt", EmitDefaultValue=false)]
		public string HazInsurEndsmtMailToAdtlTxt { get; set; }

		[DataMember(Name="hazInsurEndsmtMailToCty", EmitDefaultValue=false)]
		public string HazInsurEndsmtMailToCty { get; set; }

		[DataMember(Name="hazInsurEndsmtMailToNm", EmitDefaultValue=false)]
		public string HazInsurEndsmtMailToNm { get; set; }

		[DataMember(Name="hazInsurEndsmtMailToStCd", EmitDefaultValue=false)]
		public string HazInsurEndsmtMailToStCd { get; set; }

		[DataMember(Name="hazInsurEndsmtMailToStreetAddr1", EmitDefaultValue=false)]
		public string HazInsurEndsmtMailToStreetAddr1 { get; set; }

		[DataMember(Name="hazInsurEndsmtMailToStreetAddr2", EmitDefaultValue=false)]
		public string HazInsurEndsmtMailToStreetAddr2 { get; set; }

		[DataMember(Name="hazInsurEndsmtMailToZip", EmitDefaultValue=false)]
		public string HazInsurEndsmtMailToZip { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="mersAdtlCity", EmitDefaultValue=false)]
		public string MersAdtlCity { get; set; }

		[DataMember(Name="mersAdtlStCd", EmitDefaultValue=false)]
		public string MersAdtlStCd { get; set; }

		[DataMember(Name="mersAdtlStreetAddr1", EmitDefaultValue=false)]
		public string MersAdtlStreetAddr1 { get; set; }

		[DataMember(Name="mersAdtlStreetAddr2", EmitDefaultValue=false)]
		public string MersAdtlStreetAddr2 { get; set; }

		[DataMember(Name="mersAdtlZip", EmitDefaultValue=false)]
		public string MersAdtlZip { get; set; }

		[DataMember(Name="mersCty", EmitDefaultValue=false)]
		public string MersCty { get; set; }

		[DataMember(Name="mersJrsdctn", EmitDefaultValue=false)]
		public string MersJrsdctn { get; set; }

		[DataMember(Name="mersName", EmitDefaultValue=false)]
		public string MersName { get; set; }

		[DataMember(Name="mersOrgTyp", EmitDefaultValue=false)]
		public string MersOrgTyp { get; set; }

		[DataMember(Name="mersPhoneNum", EmitDefaultValue=false)]
		public string MersPhoneNum { get; set; }

		[DataMember(Name="mersStCd", EmitDefaultValue=false)]
		public string MersStCd { get; set; }

		[DataMember(Name="mersStreetAddr1", EmitDefaultValue=false)]
		public string MersStreetAddr1 { get; set; }

		[DataMember(Name="mersStreetAddr2", EmitDefaultValue=false)]
		public string MersStreetAddr2 { get; set; }

		[DataMember(Name="mersZip", EmitDefaultValue=false)]
		public string MersZip { get; set; }

		[DataMember(Name="ntEndrsmtPayToJrsdctn", EmitDefaultValue=false)]
		public string NtEndrsmtPayToJrsdctn { get; set; }

		[DataMember(Name="ntEndrsmtPayToOrdNm", EmitDefaultValue=false)]
		public string NtEndrsmtPayToOrdNm { get; set; }

		[DataMember(Name="ntEndrsmtPayToOrgTyp", EmitDefaultValue=false)]
		public string NtEndrsmtPayToOrgTyp { get; set; }

		[DataMember(Name="ntEndrsmtPayToScsrsClaus", EmitDefaultValue=false)]
		public string NtEndrsmtPayToScsrsClaus { get; set; }

		[DataMember(Name="ntEndrsmtSgndBy1MiscTxt", EmitDefaultValue=false)]
		public string NtEndrsmtSgndBy1MiscTxt { get; set; }

		[DataMember(Name="ntEndrsmtSgndBy2MiscTxt", EmitDefaultValue=false)]
		public string NtEndrsmtSgndBy2MiscTxt { get; set; }

		[DataMember(Name="ntEndrsmtSignedByNm", EmitDefaultValue=false)]
		public string NtEndrsmtSignedByNm { get; set; }

		[DataMember(Name="ntEndrsmtSignedByNm2", EmitDefaultValue=false)]
		public string NtEndrsmtSignedByNm2 { get; set; }

		[DataMember(Name="ntEndrsmtSignedByNm3", EmitDefaultValue=false)]
		public string NtEndrsmtSignedByNm3 { get; set; }

		[DataMember(Name="ntEndrsmtSignedByTtl", EmitDefaultValue=false)]
		public string NtEndrsmtSignedByTtl { get; set; }

		[DataMember(Name="ntEndrsmtSignedByTtl2", EmitDefaultValue=false)]
		public string NtEndrsmtSignedByTtl2 { get; set; }

		[DataMember(Name="ntEndrsmtSignedByTtl3", EmitDefaultValue=false)]
		public string NtEndrsmtSignedByTtl3 { get; set; }

		[DataMember(Name="ntEndrsmtSignedByTyp", EmitDefaultValue=false)]
		public string NtEndrsmtSignedByTyp { get; set; }

		[DataMember(Name="ntEndrsmtWithoutRcrse", EmitDefaultValue=false)]
		public string NtEndrsmtWithoutRcrse { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyAddr1", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyAddr1 { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyAddr2", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyAddr2 { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyCty", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyCty { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyJrsdctn", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyJrsdctn { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyName", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyName { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyOrgTyp", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyOrgTyp { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyPhone", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyPhone { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyScsrClaus", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyScsrClaus { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyStCd", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyStCd { get; set; }

		[DataMember(Name="ntEndsmtThrdPtyZip", EmitDefaultValue=false)]
		public string NtEndsmtThrdPtyZip { get; set; }

		[DataMember(Name="ntPayToAdtlTxt", EmitDefaultValue=false)]
		public string NtPayToAdtlTxt { get; set; }

		[DataMember(Name="ntPayToCty", EmitDefaultValue=false)]
		public string NtPayToCty { get; set; }

		[DataMember(Name="ntPayToJrsdctn", EmitDefaultValue=false)]
		public string NtPayToJrsdctn { get; set; }

		[DataMember(Name="ntPayToNm", EmitDefaultValue=false)]
		public string NtPayToNm { get; set; }

		[DataMember(Name="ntPayToOrgTyp", EmitDefaultValue=false)]
		public string NtPayToOrgTyp { get; set; }

		[DataMember(Name="ntPayToStCd", EmitDefaultValue=false)]
		public string NtPayToStCd { get; set; }

		[DataMember(Name="ntPayToStreetAddr1", EmitDefaultValue=false)]
		public string NtPayToStreetAddr1 { get; set; }

		[DataMember(Name="ntPayToStreetAddr2", EmitDefaultValue=false)]
		public string NtPayToStreetAddr2 { get; set; }

		[DataMember(Name="ntPayToZip", EmitDefaultValue=false)]
		public string NtPayToZip { get; set; }

		[DataMember(Name="pmtCpn2PayToAdtlTxt", EmitDefaultValue=false)]
		public string PmtCpn2PayToAdtlTxt { get; set; }

		[DataMember(Name="pmtCpn2PayToAdtlTxt2", EmitDefaultValue=false)]
		public string PmtCpn2PayToAdtlTxt2 { get; set; }

		[DataMember(Name="pmtCpn2PayToCty", EmitDefaultValue=false)]
		public string PmtCpn2PayToCty { get; set; }

		[DataMember(Name="pmtCpn2PayToNm", EmitDefaultValue=false)]
		public string PmtCpn2PayToNm { get; set; }

		[DataMember(Name="pmtCpn2PayToStCd", EmitDefaultValue=false)]
		public string PmtCpn2PayToStCd { get; set; }

		[DataMember(Name="pmtCpn2PayToStreetAddr1", EmitDefaultValue=false)]
		public string PmtCpn2PayToStreetAddr1 { get; set; }

		[DataMember(Name="pmtCpn2PayToStreetAddr2", EmitDefaultValue=false)]
		public string PmtCpn2PayToStreetAddr2 { get; set; }

		[DataMember(Name="pmtCpn2PayToZip", EmitDefaultValue=false)]
		public string PmtCpn2PayToZip { get; set; }

		[DataMember(Name="pmtCpnPayToAdtlTxt", EmitDefaultValue=false)]
		public string PmtCpnPayToAdtlTxt { get; set; }

		[DataMember(Name="pmtCpnPayToAdtlTxt2", EmitDefaultValue=false)]
		public string PmtCpnPayToAdtlTxt2 { get; set; }

		[DataMember(Name="pmtCpnPayToCty", EmitDefaultValue=false)]
		public string PmtCpnPayToCty { get; set; }

		[DataMember(Name="pmtCpnPayToNm", EmitDefaultValue=false)]
		public string PmtCpnPayToNm { get; set; }

		[DataMember(Name="pmtCpnPayToStCd", EmitDefaultValue=false)]
		public string PmtCpnPayToStCd { get; set; }

		[DataMember(Name="pmtCpnPayToStreetAddr1", EmitDefaultValue=false)]
		public string PmtCpnPayToStreetAddr1 { get; set; }

		[DataMember(Name="pmtCpnPayToStreetAddr2", EmitDefaultValue=false)]
		public string PmtCpnPayToStreetAddr2 { get; set; }

		[DataMember(Name="pmtCpnPayToZip", EmitDefaultValue=false)]
		public string PmtCpnPayToZip { get; set; }

		[DataMember(Name="prtAdtlDateHud1", EmitDefaultValue=false)]
		public string PrtAdtlDateHud1 { get; set; }

		[DataMember(Name="prtAllngToNtBool", EmitDefaultValue=false)]
		public bool? PrtAllngToNtBool { get; set; }

		[DataMember(Name="prtCorpMsgAsgnBool", EmitDefaultValue=false)]
		public bool? PrtCorpMsgAsgnBool { get; set; }

		[DataMember(Name="prtDocDtSctyIstrmtNtryAprncDt", EmitDefaultValue=false)]
		public string PrtDocDtSctyIstrmtNtryAprncDt { get; set; }

		[DataMember(Name="prtIndxTilBool", EmitDefaultValue=false)]
		public bool? PrtIndxTilBool { get; set; }

		[DataMember(Name="prtInitBlckNtBool", EmitDefaultValue=false)]
		public bool? PrtInitBlckNtBool { get; set; }

		[DataMember(Name="prtInitBlckSctyIstrmtBool", EmitDefaultValue=false)]
		public bool? PrtInitBlckSctyIstrmtBool { get; set; }

		[DataMember(Name="prtInvLoanNumBool", EmitDefaultValue=false)]
		public bool? PrtInvLoanNumBool { get; set; }

		[DataMember(Name="prtInvLoanNumPmtCpn2Ind", EmitDefaultValue=false)]
		public bool? PrtInvLoanNumPmtCpn2Ind { get; set; }

		[DataMember(Name="prtInvLoanNumPmtCpnInd", EmitDefaultValue=false)]
		public bool? PrtInvLoanNumPmtCpnInd { get; set; }

		[DataMember(Name="prtInvLossPayeeHazInsurDisBool", EmitDefaultValue=false)]
		public bool? PrtInvLossPayeeHazInsurDisBool { get; set; }

		[DataMember(Name="prtLoanNumDeedBool", EmitDefaultValue=false)]
		public bool? PrtLoanNumDeedBool { get; set; }

		[DataMember(Name="prtNtEndsmtBool", EmitDefaultValue=false)]
		public bool? PrtNtEndsmtBool { get; set; }

		[DataMember(Name="prtNtPayToCorpMsgBool", EmitDefaultValue=false)]
		public bool? PrtNtPayToCorpMsgBool { get; set; }

		[DataMember(Name="prtScsrsClausClosInstBool", EmitDefaultValue=false)]
		public bool? PrtScsrsClausClosInstBool { get; set; }

		[DataMember(Name="prtScsrsClausHazInsurDisBool", EmitDefaultValue=false)]
		public bool? PrtScsrsClausHazInsurDisBool { get; set; }

		[DataMember(Name="prtScsrsClausHazInsurLtrBool", EmitDefaultValue=false)]
		public bool? PrtScsrsClausHazInsurLtrBool { get; set; }

		[DataMember(Name="prtScsrsClausPmtCpnBool", EmitDefaultValue=false)]
		public bool? PrtScsrsClausPmtCpnBool { get; set; }

		[DataMember(Name="prtSctyIstrmtCorpMsgBool", EmitDefaultValue=false)]
		public bool? PrtSctyIstrmtCorpMsgBool { get; set; }

		[DataMember(Name="recRtrnAttnLnNmTxtDesc", EmitDefaultValue=false)]
		public string RecRtrnAttnLnNmTxtDesc { get; set; }

		[DataMember(Name="recRtrnCty", EmitDefaultValue=false)]
		public string RecRtrnCty { get; set; }

		[DataMember(Name="recRtrnLblTxtDesc", EmitDefaultValue=false)]
		public string RecRtrnLblTxtDesc { get; set; }

		[DataMember(Name="recRtrnNm", EmitDefaultValue=false)]
		public string RecRtrnNm { get; set; }

		[DataMember(Name="recRtrnNmSamePtyTypDesc", EmitDefaultValue=false)]
		public string RecRtrnNmSamePtyTypDesc { get; set; }

		[DataMember(Name="recRtrnPhoneNum", EmitDefaultValue=false)]
		public string RecRtrnPhoneNum { get; set; }

		[DataMember(Name="recRtrnStCd", EmitDefaultValue=false)]
		public string RecRtrnStCd { get; set; }

		[DataMember(Name="recRtrnStreetAddr1", EmitDefaultValue=false)]
		public string RecRtrnStreetAddr1 { get; set; }

		[DataMember(Name="recRtrnStreetAddr2", EmitDefaultValue=false)]
		public string RecRtrnStreetAddr2 { get; set; }

		[DataMember(Name="recRtrnTollFreePhoneNum", EmitDefaultValue=false)]
		public string RecRtrnTollFreePhoneNum { get; set; }

		[DataMember(Name="recRtrnZip", EmitDefaultValue=false)]
		public string RecRtrnZip { get; set; }

		[DataMember(Name="rtrnExeClosPkgToLndBrchBool", EmitDefaultValue=false)]
		public bool? RtrnExeClosPkgToLndBrchBool { get; set; }

		[DataMember(Name="rtToCancelNtfcAdtlTxt", EmitDefaultValue=false)]
		public string RtToCancelNtfcAdtlTxt { get; set; }

		[DataMember(Name="rtToCancelNtfcCty", EmitDefaultValue=false)]
		public string RtToCancelNtfcCty { get; set; }

		[DataMember(Name="rtToCancelNtfcEmail", EmitDefaultValue=false)]
		public string RtToCancelNtfcEmail { get; set; }

		[DataMember(Name="rtToCancelNtfcFax", EmitDefaultValue=false)]
		public string RtToCancelNtfcFax { get; set; }

		[DataMember(Name="rtToCancelNtfcNm", EmitDefaultValue=false)]
		public string RtToCancelNtfcNm { get; set; }

		[DataMember(Name="rtToCancelNtfcStCd", EmitDefaultValue=false)]
		public string RtToCancelNtfcStCd { get; set; }

		[DataMember(Name="rtToCancelNtfcStreetAddr1", EmitDefaultValue=false)]
		public string RtToCancelNtfcStreetAddr1 { get; set; }

		[DataMember(Name="rtToCancelNtfcStreetAddr2", EmitDefaultValue=false)]
		public string RtToCancelNtfcStreetAddr2 { get; set; }

		[DataMember(Name="rtToCancelNtfcZip", EmitDefaultValue=false)]
		public string RtToCancelNtfcZip { get; set; }

		[DataMember(Name="rtToCancelTransDtTyp", EmitDefaultValue=false)]
		public string RtToCancelTransDtTyp { get; set; }

		[DataMember(Name="sctyIstrmtDCTrstFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtDCTrstFeePct { get; set; }

		[DataMember(Name="sctyIstrmtDEAttyFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtDEAttyFeePct { get; set; }

		[DataMember(Name="sctyIstrmtLAAttyFeePct", EmitDefaultValue=false)]
		public double? SctyIstrmtLAAttyFeePct { get; set; }

		[DataMember(Name="sctyIstrmtLAMinAttyFeeAmt", EmitDefaultValue=false)]
		public double? SctyIstrmtLAMinAttyFeeAmt { get; set; }

		[DataMember(Name="sctyIstrmtMDTrstFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtMDTrstFeePct { get; set; }

		[DataMember(Name="sctyIstrmtMSTrstFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtMSTrstFeePct { get; set; }

		[DataMember(Name="sctyIstrmtNCAttyFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtNCAttyFeePct { get; set; }

		[DataMember(Name="sctyIstrmtNETrstFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtNETrstFeePct { get; set; }

		[DataMember(Name="sctyIstrmtNVAssmFeeAmt", EmitDefaultValue=false)]
		public string SctyIstrmtNVAssmFeeAmt { get; set; }

		[DataMember(Name="sctyIstrmtNVTrstFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtNVTrstFeePct { get; set; }

		[DataMember(Name="sctyIstrmtOKAssmFeeAmt", EmitDefaultValue=false)]
		public string SctyIstrmtOKAssmFeeAmt { get; set; }

		[DataMember(Name="sctyIstrmtPOBoxAddr1", EmitDefaultValue=false)]
		public string SctyIstrmtPOBoxAddr1 { get; set; }

		[DataMember(Name="sctyIstrmtPOBoxAddr2", EmitDefaultValue=false)]
		public string SctyIstrmtPOBoxAddr2 { get; set; }

		[DataMember(Name="sctyIstrmtPrepByAdtlTxt", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByAdtlTxt { get; set; }

		[DataMember(Name="sctyIstrmtPrepByCoNm", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByCoNm { get; set; }

		[DataMember(Name="sctyIstrmtPrepByCty", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByCty { get; set; }

		[DataMember(Name="sctyIstrmtPrepByIndvNm", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByIndvNm { get; set; }

		[DataMember(Name="sctyIstrmtPrepByIndvTtl", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByIndvTtl { get; set; }

		[DataMember(Name="sctyIstrmtPrepByPhone", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByPhone { get; set; }

		[DataMember(Name="sctyIstrmtPrepBySamePtyTypDesc", EmitDefaultValue=false)]
		public string SctyIstrmtPrepBySamePtyTypDesc { get; set; }

		[DataMember(Name="sctyIstrmtPrepByStCd", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByStCd { get; set; }

		[DataMember(Name="sctyIstrmtPrepByStreetAddr1", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByStreetAddr1 { get; set; }

		[DataMember(Name="sctyIstrmtPrepByStreetAddr2", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByStreetAddr2 { get; set; }

		[DataMember(Name="sctyIstrmtPrepByTxt", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByTxt { get; set; }

		[DataMember(Name="sctyIstrmtPrepByZip", EmitDefaultValue=false)]
		public string SctyIstrmtPrepByZip { get; set; }

		[DataMember(Name="sctyIstrmtTtlAdtlTxt", EmitDefaultValue=false)]
		public string SctyIstrmtTtlAdtlTxt { get; set; }

		[DataMember(Name="sctyIstrmtTtlAdtlTxtAbvTtl", EmitDefaultValue=false)]
		public bool? SctyIstrmtTtlAdtlTxtAbvTtl { get; set; }

		[DataMember(Name="sctyIstrmtVATrstFeePct", EmitDefaultValue=false)]
		public string SctyIstrmtVATrstFeePct { get; set; }

		[DataMember(Name="trst1Cnty", EmitDefaultValue=false)]
		public string Trst1Cnty { get; set; }

		[DataMember(Name="trst1Cty", EmitDefaultValue=false)]
		public string Trst1Cty { get; set; }

		[DataMember(Name="trst1IndvBool", EmitDefaultValue=false)]
		public bool? Trst1IndvBool { get; set; }

		[DataMember(Name="trst1Jrsdctn", EmitDefaultValue=false)]
		public string Trst1Jrsdctn { get; set; }

		[DataMember(Name="trst1Nm", EmitDefaultValue=false)]
		public string Trst1Nm { get; set; }

		[DataMember(Name="trst1OrgTyp", EmitDefaultValue=false)]
		public string Trst1OrgTyp { get; set; }

		[DataMember(Name="trst1Phone", EmitDefaultValue=false)]
		public string Trst1Phone { get; set; }

		[DataMember(Name="trst1RsdtTxtDesc", EmitDefaultValue=false)]
		public string Trst1RsdtTxtDesc { get; set; }

		[DataMember(Name="trst1SamePtyTypDesc", EmitDefaultValue=false)]
		public string Trst1SamePtyTypDesc { get; set; }

		[DataMember(Name="trst1StCd", EmitDefaultValue=false)]
		public string Trst1StCd { get; set; }

		[DataMember(Name="trst1StreetAddr1", EmitDefaultValue=false)]
		public string Trst1StreetAddr1 { get; set; }

		[DataMember(Name="trst1StreetAddr2", EmitDefaultValue=false)]
		public string Trst1StreetAddr2 { get; set; }

		[DataMember(Name="trst1Zip", EmitDefaultValue=false)]
		public string Trst1Zip { get; set; }

		[DataMember(Name="trst2Cnty", EmitDefaultValue=false)]
		public string Trst2Cnty { get; set; }

		[DataMember(Name="trst2Cty", EmitDefaultValue=false)]
		public string Trst2Cty { get; set; }

		[DataMember(Name="trst2IndvBool", EmitDefaultValue=false)]
		public bool? Trst2IndvBool { get; set; }

		[DataMember(Name="trst2Jrsdctn", EmitDefaultValue=false)]
		public string Trst2Jrsdctn { get; set; }

		[DataMember(Name="trst2Nm", EmitDefaultValue=false)]
		public string Trst2Nm { get; set; }

		[DataMember(Name="trst2OrgTyp", EmitDefaultValue=false)]
		public string Trst2OrgTyp { get; set; }

		[DataMember(Name="trst2Phone", EmitDefaultValue=false)]
		public string Trst2Phone { get; set; }

		[DataMember(Name="trst2RsdtTxtDesc", EmitDefaultValue=false)]
		public string Trst2RsdtTxtDesc { get; set; }

		[DataMember(Name="trst2SamePtyTypDesc", EmitDefaultValue=false)]
		public string Trst2SamePtyTypDesc { get; set; }

		[DataMember(Name="trst2StCd", EmitDefaultValue=false)]
		public string Trst2StCd { get; set; }

		[DataMember(Name="trst2StreetAddr1", EmitDefaultValue=false)]
		public string Trst2StreetAddr1 { get; set; }

		[DataMember(Name="trst2StreetAddr2", EmitDefaultValue=false)]
		public string Trst2StreetAddr2 { get; set; }

		[DataMember(Name="trst2Zip", EmitDefaultValue=false)]
		public string Trst2Zip { get; set; }

	}
}