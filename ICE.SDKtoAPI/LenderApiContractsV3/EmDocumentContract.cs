using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EmDocumentContract
    {
        [DataMember(Name = "allngToNtPayToJrsdctn")]
        public string AllngToNtPayToJrsdctn { get; set; }

        [DataMember(Name = "allngToNtPayToOrdNm")]
        public string AllngToNtPayToOrdNm { get; set; }

        [DataMember(Name = "allngToNtPayToOrgTyp")]
        public string AllngToNtPayToOrgTyp { get; set; }

        [DataMember(Name = "allngToNtPayToScsrsClaus")]
        public string AllngToNtPayToScsrsClaus { get; set; }

        [DataMember(Name = "allngToNtSignedByNm")]
        public string AllngToNtSignedByNm { get; set; }

        [DataMember(Name = "allngToNtSignedByNm2")]
        public string AllngToNtSignedByNm2 { get; set; }

        [DataMember(Name = "allngToNtSignedByNm3")]
        public string AllngToNtSignedByNm3 { get; set; }

        [DataMember(Name = "allngToNtSignedByTtl")]
        public string AllngToNtSignedByTtl { get; set; }

        [DataMember(Name = "allngToNtSignedByTtl2")]
        public string AllngToNtSignedByTtl2 { get; set; }

        [DataMember(Name = "allngToNtSignedByTtl3")]
        public string AllngToNtSignedByTtl3 { get; set; }

        [DataMember(Name = "allngToNtSignedByTyp")]
        public string AllngToNtSignedByTyp { get; set; }

        [DataMember(Name = "allngToNtWithoutRcrse")]
        public string AllngToNtWithoutRcrse { get; set; }

        [DataMember(Name = "apnLbl")]
        public string ApnLbl { get; set; }

        [DataMember(Name = "asgnPrepByLblTxtDesc")]
        public bool? AsgnPrepByLblTxtDesc { get; set; }

        [DataMember(Name = "asgnRecRtrnLblTxtDesc")]
        public bool? AsgnRecRtrnLblTxtDesc { get; set; }

        [DataMember(Name = "benCty")]
        public string BenCty { get; set; }

        [DataMember(Name = "benJrsdctn")]
        public string BenJrsdctn { get; set; }

        [DataMember(Name = "benNm")]
        public string BenNm { get; set; }

        [DataMember(Name = "benOrgTyp")]
        public string BenOrgTyp { get; set; }

        [DataMember(Name = "benStCd")]
        public string BenStCd { get; set; }

        [DataMember(Name = "benStreetAddr1")]
        public string BenStreetAddr1 { get; set; }

        [DataMember(Name = "benStreetAddr2")]
        public string BenStreetAddr2 { get; set; }

        [DataMember(Name = "benZip")]
        public string BenZip { get; set; }

        [DataMember(Name = "closInstrPrtInvLossPayee")]
        public bool? ClosInstrPrtInvLossPayee { get; set; }

        [DataMember(Name = "closInstrStlmtAgtUseLndHud1")]
        public bool? ClosInstrStlmtAgtUseLndHud1 { get; set; }

        [DataMember(Name = "closInstrTtlPlcyTyp")]
        public string ClosInstrTtlPlcyTyp { get; set; }

        [DataMember(Name = "emxmlVersionId")]
        public string EmxmlVersionId { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToCty")]
        public string ExeClosDocDlvrdToCty { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToMiscTxtDesc")]
        public string ExeClosDocDlvrdToMiscTxtDesc { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToNm")]
        public string ExeClosDocDlvrdToNm { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToStCd")]
        public string ExeClosDocDlvrdToStCd { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToStreetAddr1")]
        public string ExeClosDocDlvrdToStreetAddr1 { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToStreetAddr2")]
        public string ExeClosDocDlvrdToStreetAddr2 { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToZip")]
        public string ExeClosDocDlvrdToZip { get; set; }

        [DataMember(Name = "exeClosDocExprDt")]
        public string ExeClosDocExprDt { get; set; }

        [DataMember(Name = "exeClosDocToBeRtrnd")]
        public string ExeClosDocToBeRtrnd { get; set; }

        [DataMember(Name = "exeClosDocToBeRtrndHrs")]
        public string ExeClosDocToBeRtrndHrs { get; set; }

        [DataMember(Name = "hazInsurEndsmtMailToAdtlTxt")]
        public string HazInsurEndsmtMailToAdtlTxt { get; set; }

        [DataMember(Name = "hazInsurEndsmtMailToCty")]
        public string HazInsurEndsmtMailToCty { get; set; }

        [DataMember(Name = "hazInsurEndsmtMailToNm")]
        public string HazInsurEndsmtMailToNm { get; set; }

        [DataMember(Name = "hazInsurEndsmtMailToStCd")]
        public string HazInsurEndsmtMailToStCd { get; set; }

        [DataMember(Name = "hazInsurEndsmtMailToStreetAddr1")]
        public string HazInsurEndsmtMailToStreetAddr1 { get; set; }

        [DataMember(Name = "hazInsurEndsmtMailToStreetAddr2")]
        public string HazInsurEndsmtMailToStreetAddr2 { get; set; }

        [DataMember(Name = "hazInsurEndsmtMailToZip")]
        public string HazInsurEndsmtMailToZip { get; set; }

        [DataMember(Name = "mersAdtlCity")]
        public string MersAdtlCity { get; set; }

        [DataMember(Name = "mersAdtlStCd")]
        public string MersAdtlStCd { get; set; }

        [DataMember(Name = "mersAdtlStreetAddr1")]
        public string MersAdtlStreetAddr1 { get; set; }

        [DataMember(Name = "mersAdtlStreetAddr2")]
        public string MersAdtlStreetAddr2 { get; set; }

        [DataMember(Name = "mersAdtlZip")]
        public string MersAdtlZip { get; set; }

        [DataMember(Name = "mersCty")]
        public string MersCty { get; set; }

        [DataMember(Name = "mersJrsdctn")]
        public string MersJrsdctn { get; set; }

        [DataMember(Name = "mersName")]
        public string MersName { get; set; }

        [DataMember(Name = "mersOrgTyp")]
        public string MersOrgTyp { get; set; }

        [DataMember(Name = "mersPhoneNum")]
        public string MersPhoneNum { get; set; }

        [DataMember(Name = "mersStCd")]
        public string MersStCd { get; set; }

        [DataMember(Name = "mersStreetAddr1")]
        public string MersStreetAddr1 { get; set; }

        [DataMember(Name = "mersStreetAddr2")]
        public string MersStreetAddr2 { get; set; }

        [DataMember(Name = "mersZip")]
        public string MersZip { get; set; }

        [DataMember(Name = "ntEndrsmtPayToJrsdctn")]
        public string NtEndrsmtPayToJrsdctn { get; set; }

        [DataMember(Name = "ntEndrsmtPayToOrdNm")]
        public string NtEndrsmtPayToOrdNm { get; set; }

        [DataMember(Name = "ntEndrsmtPayToOrgTyp")]
        public string NtEndrsmtPayToOrgTyp { get; set; }

        [DataMember(Name = "ntEndrsmtPayToScsrsClaus")]
        public string NtEndrsmtPayToScsrsClaus { get; set; }

        [DataMember(Name = "ntEndrsmtSignedByNm")]
        public string NtEndrsmtSignedByNm { get; set; }

        [DataMember(Name = "ntEndrsmtSignedByNm2")]
        public string NtEndrsmtSignedByNm2 { get; set; }

        [DataMember(Name = "ntEndrsmtSignedByNm3")]
        public string NtEndrsmtSignedByNm3 { get; set; }

        [DataMember(Name = "ntEndrsmtSignedByTtl")]
        public string NtEndrsmtSignedByTtl { get; set; }

        [DataMember(Name = "ntEndrsmtSignedByTtl2")]
        public string NtEndrsmtSignedByTtl2 { get; set; }

        [DataMember(Name = "ntEndrsmtSignedByTtl3")]
        public string NtEndrsmtSignedByTtl3 { get; set; }

        [DataMember(Name = "ntEndrsmtSignedByTyp")]
        public string NtEndrsmtSignedByTyp { get; set; }

        [DataMember(Name = "ntEndrsmtWithoutRcrse")]
        public string NtEndrsmtWithoutRcrse { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyAddr1")]
        public string NtEndsmtThrdPtyAddr1 { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyAddr2")]
        public string NtEndsmtThrdPtyAddr2 { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyCty")]
        public string NtEndsmtThrdPtyCty { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyJrsdctn")]
        public string NtEndsmtThrdPtyJrsdctn { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyName")]
        public string NtEndsmtThrdPtyName { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyOrgTyp")]
        public string NtEndsmtThrdPtyOrgTyp { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyPhone")]
        public string NtEndsmtThrdPtyPhone { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyScsrClaus")]
        public string NtEndsmtThrdPtyScsrClaus { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyStCd")]
        public string NtEndsmtThrdPtyStCd { get; set; }

        [DataMember(Name = "ntEndsmtThrdPtyZip")]
        public string NtEndsmtThrdPtyZip { get; set; }

        [DataMember(Name = "ntPayToAdtlTxt")]
        public string NtPayToAdtlTxt { get; set; }

        [DataMember(Name = "ntPayToCty")]
        public string NtPayToCty { get; set; }

        [DataMember(Name = "ntPayToJrsdctn")]
        public string NtPayToJrsdctn { get; set; }

        [DataMember(Name = "ntPayToNm")]
        public string NtPayToNm { get; set; }

        [DataMember(Name = "ntPayToOrgTyp")]
        public string NtPayToOrgTyp { get; set; }

        [DataMember(Name = "ntPayToStCd")]
        public string NtPayToStCd { get; set; }

        [DataMember(Name = "ntPayToStreetAddr1")]
        public string NtPayToStreetAddr1 { get; set; }

        [DataMember(Name = "ntPayToStreetAddr2")]
        public string NtPayToStreetAddr2 { get; set; }

        [DataMember(Name = "ntPayToZip")]
        public string NtPayToZip { get; set; }

        [DataMember(Name = "pmtCpn2PayToAdtlTxt")]
        public string PmtCpn2PayToAdtlTxt { get; set; }

        [DataMember(Name = "pmtCpn2PayToAdtlTxt2")]
        public string PmtCpn2PayToAdtlTxt2 { get; set; }

        [DataMember(Name = "pmtCpn2PayToCty")]
        public string PmtCpn2PayToCty { get; set; }

        [DataMember(Name = "pmtCpn2PayToNm")]
        public string PmtCpn2PayToNm { get; set; }

        [DataMember(Name = "pmtCpn2PayToStCd")]
        public string PmtCpn2PayToStCd { get; set; }

        [DataMember(Name = "pmtCpn2PayToStreetAddr1")]
        public string PmtCpn2PayToStreetAddr1 { get; set; }

        [DataMember(Name = "pmtCpn2PayToStreetAddr2")]
        public string PmtCpn2PayToStreetAddr2 { get; set; }

        [DataMember(Name = "pmtCpn2PayToZip")]
        public string PmtCpn2PayToZip { get; set; }

        [DataMember(Name = "pmtCpnPayToAdtlTxt")]
        public string PmtCpnPayToAdtlTxt { get; set; }

        [DataMember(Name = "pmtCpnPayToAdtlTxt2")]
        public string PmtCpnPayToAdtlTxt2 { get; set; }

        [DataMember(Name = "pmtCpnPayToCty")]
        public string PmtCpnPayToCty { get; set; }

        [DataMember(Name = "pmtCpnPayToNm")]
        public string PmtCpnPayToNm { get; set; }

        [DataMember(Name = "pmtCpnPayToStCd")]
        public string PmtCpnPayToStCd { get; set; }

        [DataMember(Name = "pmtCpnPayToStreetAddr1")]
        public string PmtCpnPayToStreetAddr1 { get; set; }

        [DataMember(Name = "pmtCpnPayToStreetAddr2")]
        public string PmtCpnPayToStreetAddr2 { get; set; }

        [DataMember(Name = "pmtCpnPayToZip")]
        public string PmtCpnPayToZip { get; set; }

        [DataMember(Name = "prtAdtlDateHud1")]
        public string PrtAdtlDateHud1 { get; set; }

        [DataMember(Name = "prtAllngToNtBool")]
        public bool? PrtAllngToNtBool { get; set; }

        [DataMember(Name = "prtCorpMsgAsgnBool")]
        public bool? PrtCorpMsgAsgnBool { get; set; }

        [DataMember(Name = "prtDocDtSctyIstrmtNtryAprncDt")]
        public string PrtDocDtSctyIstrmtNtryAprncDt { get; set; }

        [DataMember(Name = "prtIndxTilBool")]
        public bool? PrtIndxTilBool { get; set; }

        [DataMember(Name = "prtInitBlckNtBool")]
        public bool? PrtInitBlckNtBool { get; set; }

        [DataMember(Name = "prtInitBlckSctyIstrmtBool")]
        public bool? PrtInitBlckSctyIstrmtBool { get; set; }

        [DataMember(Name = "prtInvLoanNumBool")]
        public bool? PrtInvLoanNumBool { get; set; }

        [DataMember(Name = "prtInvLoanNumPmtCpn2Ind")]
        public bool? PrtInvLoanNumPmtCpn2Ind { get; set; }

        [DataMember(Name = "prtInvLoanNumPmtCpnInd")]
        public bool? PrtInvLoanNumPmtCpnInd { get; set; }

        [DataMember(Name = "prtInvLossPayeeHazInsurDisBool")]
        public bool? PrtInvLossPayeeHazInsurDisBool { get; set; }

        [DataMember(Name = "prtLoanNumDeedBool")]
        public bool? PrtLoanNumDeedBool { get; set; }

        [DataMember(Name = "prtNtEndsmtBool")]
        public bool? PrtNtEndsmtBool { get; set; }

        [DataMember(Name = "prtNtPayToCorpMsgBool")]
        public bool? PrtNtPayToCorpMsgBool { get; set; }

        [DataMember(Name = "prtScsrsClausClosInstBool")]
        public bool? PrtScsrsClausClosInstBool { get; set; }

        [DataMember(Name = "prtScsrsClausHazInsurDisBool")]
        public bool? PrtScsrsClausHazInsurDisBool { get; set; }

        [DataMember(Name = "prtScsrsClausHazInsurLtrBool")]
        public bool? PrtScsrsClausHazInsurLtrBool { get; set; }

        [DataMember(Name = "prtScsrsClausPmtCpnBool")]
        public bool? PrtScsrsClausPmtCpnBool { get; set; }

        [DataMember(Name = "prtSctyIstrmtCorpMsgBool")]
        public bool? PrtSctyIstrmtCorpMsgBool { get; set; }

        [DataMember(Name = "recRtrnAttnLnNmTxtDesc")]
        public string RecRtrnAttnLnNmTxtDesc { get; set; }

        [DataMember(Name = "recRtrnCty")]
        public string RecRtrnCty { get; set; }

        [DataMember(Name = "recRtrnLblTxtDesc")]
        public string RecRtrnLblTxtDesc { get; set; }

        [DataMember(Name = "recRtrnNm")]
        public string RecRtrnNm { get; set; }

        [DataMember(Name = "recRtrnPhoneNum")]
        public string RecRtrnPhoneNum { get; set; }

        [DataMember(Name = "recRtrnStCd")]
        public string RecRtrnStCd { get; set; }

        [DataMember(Name = "recRtrnStreetAddr1")]
        public string RecRtrnStreetAddr1 { get; set; }

        [DataMember(Name = "recRtrnStreetAddr2")]
        public string RecRtrnStreetAddr2 { get; set; }

        [DataMember(Name = "recRtrnTollFreePhoneNum")]
        public string RecRtrnTollFreePhoneNum { get; set; }

        [DataMember(Name = "recRtrnZip")]
        public string RecRtrnZip { get; set; }

        [DataMember(Name = "rtrnExeClosPkgToLndBrchBool")]
        public bool? RtrnExeClosPkgToLndBrchBool { get; set; }

        [DataMember(Name = "rtToCancelNtfcAdtlTxt")]
        public string RtToCancelNtfcAdtlTxt { get; set; }

        [DataMember(Name = "rtToCancelNtfcCty")]
        public string RtToCancelNtfcCty { get; set; }

        [DataMember(Name = "rtToCancelNtfcEmail")]
        public string RtToCancelNtfcEmail { get; set; }

        [DataMember(Name = "rtToCancelNtfcFax")]
        public string RtToCancelNtfcFax { get; set; }

        [DataMember(Name = "rtToCancelNtfcNm")]
        public string RtToCancelNtfcNm { get; set; }

        [DataMember(Name = "rtToCancelNtfcStCd")]
        public string RtToCancelNtfcStCd { get; set; }

        [DataMember(Name = "rtToCancelNtfcStreetAddr1")]
        public string RtToCancelNtfcStreetAddr1 { get; set; }

        [DataMember(Name = "rtToCancelNtfcStreetAddr2")]
        public string RtToCancelNtfcStreetAddr2 { get; set; }

        [DataMember(Name = "rtToCancelNtfcZip")]
        public string RtToCancelNtfcZip { get; set; }

        [DataMember(Name = "rtToCancelTransDtTyp")]
        public string RtToCancelTransDtTyp { get; set; }

        [DataMember(Name = "sctyIstrmtDcTrstFeePct")]
        public string SctyIstrmtDcTrstFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtDeAttyFeePct")]
        public string SctyIstrmtDeAttyFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtLaAttyFeePct")]
        public decimal? SctyIstrmtLaAttyFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtLaMinAttyFeeAmt")]
        public decimal? SctyIstrmtLaMinAttyFeeAmt { get; set; }

        [DataMember(Name = "sctyIstrmtMdTrstFeePct")]
        public string SctyIstrmtMdTrstFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtMsTrstFeePct")]
        public string SctyIstrmtMsTrstFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtNcAttyFeePct")]
        public string SctyIstrmtNcAttyFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtNeTrstFeePct")]
        public string SctyIstrmtNeTrstFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtNvAssmFeeAmt")]
        public string SctyIstrmtNvAssmFeeAmt { get; set; }

        [DataMember(Name = "sctyIstrmtNvTrstFeePct")]
        public string SctyIstrmtNvTrstFeePct { get; set; }

        [DataMember(Name = "sctyIstrmtOkAssmFeeAmt")]
        public string SctyIstrmtOkAssmFeeAmt { get; set; }

        [DataMember(Name = "sctyIstrmtPoBoxAddr1")]
        public string SctyIstrmtPoBoxAddr1 { get; set; }

        [DataMember(Name = "sctyIstrmtPoBoxAddr2")]
        public string SctyIstrmtPoBoxAddr2 { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByAdtlTxt")]
        public string SctyIstrmtPrepByAdtlTxt { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByCoNm")]
        public string SctyIstrmtPrepByCoNm { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByCty")]
        public string SctyIstrmtPrepByCty { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByIndvNm")]
        public string SctyIstrmtPrepByIndvNm { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByIndvTtl")]
        public string SctyIstrmtPrepByIndvTtl { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByPhone")]
        public string SctyIstrmtPrepByPhone { get; set; }

        [DataMember(Name = "sctyIstrmtPrepBySamePtyTypDesc")]
        public string SctyIstrmtPrepBySamePtyTypDesc { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByStCd")]
        public string SctyIstrmtPrepByStCd { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByStreetAddr1")]
        public string SctyIstrmtPrepByStreetAddr1 { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByStreetAddr2")]
        public string SctyIstrmtPrepByStreetAddr2 { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByTxt")]
        public string SctyIstrmtPrepByTxt { get; set; }

        [DataMember(Name = "sctyIstrmtPrepByZip")]
        public string SctyIstrmtPrepByZip { get; set; }

        [DataMember(Name = "sctyIstrmtTtlAdtlTxt")]
        public string SctyIstrmtTtlAdtlTxt { get; set; }

        [DataMember(Name = "sctyIstrmtTtlAdtlTxtAbvTtl")]
        public bool? SctyIstrmtTtlAdtlTxtAbvTtl { get; set; }

        [DataMember(Name = "sctyIstrmtVaTrstFeePct")]
        public string SctyIstrmtVaTrstFeePct { get; set; }

        [DataMember(Name = "trst1Cnty")]
        public string Trst1Cnty { get; set; }

        [DataMember(Name = "trst1Cty")]
        public string Trst1Cty { get; set; }

        [DataMember(Name = "trst1IndvBool")]
        public bool? Trst1IndvBool { get; set; }

        [DataMember(Name = "trst1Jrsdctn")]
        public string Trst1Jrsdctn { get; set; }

        [DataMember(Name = "trst1Nm")]
        public string Trst1Nm { get; set; }

        [DataMember(Name = "trst1OrgTyp")]
        public string Trst1OrgTyp { get; set; }

        [DataMember(Name = "trst1Phone")]
        public string Trst1Phone { get; set; }

        [DataMember(Name = "trst1RsdtTxtDesc")]
        public string Trst1RsdtTxtDesc { get; set; }

        [DataMember(Name = "trst1SamePtyTypDesc")]
        public string Trst1SamePtyTypDesc { get; set; }

        [DataMember(Name = "trst1StCd")]
        public string Trst1StCd { get; set; }

        [DataMember(Name = "trst1StreetAddr1")]
        public string Trst1StreetAddr1 { get; set; }

        [DataMember(Name = "trst1StreetAddr2")]
        public string Trst1StreetAddr2 { get; set; }

        [DataMember(Name = "trst1Zip")]
        public string Trst1Zip { get; set; }

        [DataMember(Name = "trst2Cnty")]
        public string Trst2Cnty { get; set; }

        [DataMember(Name = "trst2Cty")]
        public string Trst2Cty { get; set; }

        [DataMember(Name = "trst2IndvBool")]
        public bool? Trst2IndvBool { get; set; }

        [DataMember(Name = "trst2Jrsdctn")]
        public string Trst2Jrsdctn { get; set; }

        [DataMember(Name = "trst2Nm")]
        public string Trst2Nm { get; set; }

        [DataMember(Name = "trst2OrgTyp")]
        public string Trst2OrgTyp { get; set; }

        [DataMember(Name = "trst2Phone")]
        public string Trst2Phone { get; set; }

        [DataMember(Name = "trst2RsdtTxtDesc")]
        public string Trst2RsdtTxtDesc { get; set; }

        [DataMember(Name = "trst2SamePtyTypDesc")]
        public string Trst2SamePtyTypDesc { get; set; }

        [DataMember(Name = "trst2StCd")]
        public string Trst2StCd { get; set; }

        [DataMember(Name = "trst2StreetAddr1")]
        public string Trst2StreetAddr1 { get; set; }

        [DataMember(Name = "trst2StreetAddr2")]
        public string Trst2StreetAddr2 { get; set; }

        [DataMember(Name = "trst2Zip")]
        public string Trst2Zip { get; set; }

        [DataMember(Name = "closInstrLndCntcInfoCity")]
        public string ClosInstrLndCntcInfoCity { get; set; }

        [DataMember(Name = "closInstrLndCntcInfoCoNm")]
        public string ClosInstrLndCntcInfoCoNm { get; set; }

        [DataMember(Name = "closInstrLndCntcInfoSamePtyTypDesc")]
        public string ClosInstrLndCntcInfoSamePtyTypDesc { get; set; }

        [DataMember(Name = "closInstrLndCntcInfoStCd")]
        public string ClosInstrLndCntcInfoStCd { get; set; }

        [DataMember(Name = "closInstrLndCntcInfoStreetAddr1")]
        public string ClosInstrLndCntcInfoStreetAddr1 { get; set; }

        [DataMember(Name = "closInstrLndCntcInfoStreetAddr2")]
        public string ClosInstrLndCntcInfoStreetAddr2 { get; set; }

        [DataMember(Name = "closInstrLndCntcInfoZip")]
        public string ClosInstrLndCntcInfoZip { get; set; }

        [DataMember(Name = "exeClosDocDlvrdToSamePtyTypDesc")]
        public string ExeClosDocDlvrdToSamePtyTypDesc { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToAddlLine1")]
        public string FnlTtlePcyRecDocsSentToAddlLine1 { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToAddlLine2")]
        public string FnlTtlePcyRecDocsSentToAddlLine2 { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToCty")]
        public string FnlTtlePcyRecDocsSentToCty { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToNm")]
        public string FnlTtlePcyRecDocsSentToNm { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToSamePtyTypDesc")]
        public string FnlTtlePcyRecDocsSentToSamePtyTypDesc { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToStcd")]
        public string FnlTtlePcyRecDocsSentToStcd { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToStreetAddr1")]
        public string FnlTtlePcyRecDocsSentToStreetAddr1 { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToStreetAddr2")]
        public string FnlTtlePcyRecDocsSentToStreetAddr2 { get; set; }

        [DataMember(Name = "fnlTtlePcyRecDocsSentToZip")]
        public string FnlTtlePcyRecDocsSentToZip { get; set; }

        [DataMember(Name = "ntEndrsmtSgndBy1MiscTxt")]
        public string NtEndrsmtSgndBy1MiscTxt { get; set; }

        [DataMember(Name = "ntEndrsmtSgndBy2MiscTxt")]
        public string NtEndrsmtSgndBy2MiscTxt { get; set; }

        [DataMember(Name = "recRtrnNmSamePtyTypDesc")]
        public string RecRtrnNmSamePtyTypDesc { get; set; }
    }
}
