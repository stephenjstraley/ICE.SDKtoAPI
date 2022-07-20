using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class Error
	{
		[DataMember(Name="details")]
		public string Details { get; set; }

		[DataMember(Name="errorCode")]
		public string ErrorCode { get; set; }

		[DataMember(Name="summary")]
		public string Summary { get; set; }

	}
}