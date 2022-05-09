using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanBatchUpdateRequestContractFilter
	{
		[DataMember(Name="operator", EmitDefaultValue=false)]
		public object _Operator { get; set; }

		[DataMember(Name="canonicalName", EmitDefaultValue=false)]
		public string CanonicalName { get; set; }

		[DataMember(Name="include", EmitDefaultValue=false)]
		public bool? Include { get; set; }

		[DataMember(Name="matchType", EmitDefaultValue=false)]
		public string MatchType { get; set; }

		[DataMember(Name="precision", EmitDefaultValue=false)]
		public object Precision { get; set; }

		[DataMember(Name="terms", EmitDefaultValue=false)]
		public List<object> Terms { get; set; }

		[DataMember(Name="value", EmitDefaultValue=false)]
		public object Value { get; set; }

	}
}