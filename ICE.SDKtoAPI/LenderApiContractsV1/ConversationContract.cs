using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ConversationContract
	{
		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<DisclosureTracking2015ContractAlerts> Alerts { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="company", EmitDefaultValue=false)]
		public string Company { get; set; }

		[DataMember(Name="contactMethod", EmitDefaultValue=false)]
		public string ContactMethod { get; set; }

		[DataMember(Name="createdDate", EmitDefaultValue=false)]
		public DateTime? CreatedDate { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="showInLoanLog", EmitDefaultValue=false)]
		public bool? ShowInLoanLog { get; set; }

		[DataMember(Name="updatedDate", EmitDefaultValue=false)]
		public DateTime? UpdatedDate { get; set; }

		[DataMember(Name="user", EmitDefaultValue=false)]
		public EntityRefContract User { get; set; }

	}
}