using System;
using System.Collections;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class AusTrackingLogContract
	{
		[DataMember(Name="application", EmitDefaultValue=false)]
		public EntityRefContract Application { get; set; }

		[DataMember(Name="docClass", EmitDefaultValue=false)]
		public string DocClass { get; set; }

		[DataMember(Name="duCaseIdOrLPAUSKey", EmitDefaultValue=false)]
		public string DuCaseIdOrLPAUSKey { get; set; }

		[DataMember(Name="firstSubmissionDate", EmitDefaultValue=false)]
		public DateTime? FirstSubmissionDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="recommendation", EmitDefaultValue=false)]
		public string Recommendation { get; set; }

		[DataMember(Name="submissionDate", EmitDefaultValue=false)]
		public DateTime? SubmissionDate { get; set; }

		[DataMember(Name="submissionNumber", EmitDefaultValue=false)]
		public string SubmissionNumber { get; set; }

		[DataMember(Name="submittedBy", EmitDefaultValue=false)]
		public string SubmittedBy { get; set; }

		[DataMember(Name="uwOtherRiskAssessType", EmitDefaultValue=false)]
		public string UwOtherRiskAssessType { get; set; }

		[DataMember(Name="uwRiskAssessType", EmitDefaultValue=false)]
		public string UwRiskAssessType { get; set; }

		[DataMember(Name="version", EmitDefaultValue=false)]
		public string Version { get; set; }
		
	}
}