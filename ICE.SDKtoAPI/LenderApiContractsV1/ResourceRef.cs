using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ResourceRef
	{
		[DataMember(Name="iD", EmitDefaultValue=false)]
		public string ID { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

		[DataMember(Name="uri", EmitDefaultValue=false)]
		public string Uri { get; set; }

	}
}