using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocList
	{
		[DataMember(Name="docId", EmitDefaultValue=false)]
		public string DocId { get; set; }

		[DataMember(Name="docTitle", EmitDefaultValue=false)]
		public string DocTitle { get; set; }

	}
}