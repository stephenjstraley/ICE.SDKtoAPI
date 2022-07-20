using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSnapshotFields
	{
		[DataMember(Name="fieldID")]
		public string FieldID { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="modalPath")]
		public string ModalPath { get; set; }

		[DataMember(Name="value")]
		public string Value { get; set; }

	}
}