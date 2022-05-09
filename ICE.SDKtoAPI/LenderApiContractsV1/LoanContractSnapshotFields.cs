using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSnapshotFields
	{
		[DataMember(Name="fieldID", EmitDefaultValue=false)]
		public string FieldID { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="modalPath", EmitDefaultValue=false)]
		public string ModalPath { get; set; }

		[DataMember(Name="value", EmitDefaultValue=false)]
		public string Value { get; set; }

	}
}