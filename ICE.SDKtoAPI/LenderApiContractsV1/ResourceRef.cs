using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ResourceRef
	{
		[DataMember(Name="iD")]
		public string ID { get; set; }

		[DataMember(Name="type")]
		public string Type { get; set; }

		[DataMember(Name="uri")]
		public string Uri { get; set; }

	}
}