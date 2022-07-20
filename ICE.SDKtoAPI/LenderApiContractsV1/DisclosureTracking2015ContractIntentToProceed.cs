using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractIntentToProceed
	{
		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="date")]
		public DateTime? Date { get; set; }

		[DataMember(Name="intent")]
		public bool? Intent { get; set; }

		[DataMember(Name="receivedBy")]
		public string ReceivedBy { get; set; }

		[DataMember(Name="receivedMethod")]
		public string ReceivedMethod { get; set; }

		[DataMember(Name="receivedMethodOther")]
		public string ReceivedMethodOther { get; set; }

	}
}