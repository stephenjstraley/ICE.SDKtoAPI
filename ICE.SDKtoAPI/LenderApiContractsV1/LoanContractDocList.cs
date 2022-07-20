using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocList
	{
		[DataMember(Name="docId")]
		public string DocId { get; set; }

		[DataMember(Name="docTitle")]
		public string DocTitle { get; set; }

	}
}