using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractIntentToProceed
	{
		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="intent", EmitDefaultValue=false)]
		public bool? Intent { get; set; }

		[DataMember(Name="receivedBy", EmitDefaultValue=false)]
		public string ReceivedBy { get; set; }

		[DataMember(Name="receivedMethod", EmitDefaultValue=false)]
		public string ReceivedMethod { get; set; }

		[DataMember(Name="receivedMethodOther", EmitDefaultValue=false)]
		public string ReceivedMethodOther { get; set; }

	}
}