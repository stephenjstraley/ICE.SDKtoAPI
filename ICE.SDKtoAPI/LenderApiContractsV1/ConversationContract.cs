using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ConversationContract
	{
		[DataMember(Name="alerts")]
		public List<DisclosureTracking2015ContractAlerts> Alerts { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="company")]
		public string Company { get; set; }

		[DataMember(Name="contactMethod")]
		public string ContactMethod { get; set; }

		[DataMember(Name="createdDate")]
		public DateTime? CreatedDate { get; set; }

		[DataMember(Name="email")]
		public string Email { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="phone")]
		public string Phone { get; set; }

		[DataMember(Name="showInLoanLog")]
		public bool? ShowInLoanLog { get; set; }

		[DataMember(Name="updatedDate")]
		public DateTime? UpdatedDate { get; set; }

		[DataMember(Name="user")]
		public EntityRefContract User { get; set; }

	}
}