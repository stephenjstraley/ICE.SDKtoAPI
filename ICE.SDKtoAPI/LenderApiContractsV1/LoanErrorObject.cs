using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanErrorObject
	{
		[DataMember(Name = "summary")]
		public string Summary { get; set; }

		[DataMember(Name = "details")]
		public string Details { get; set; }

		[DataMember(Name = "errorCode")]
		public string ErrorCode { get; set; }

		[DataMember(Name = "error")]
		public List<Error> Error { get; set; }
	}
}