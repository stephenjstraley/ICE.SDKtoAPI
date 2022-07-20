using System;
using System.Collections;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class AusTrackingLogContract
	{
		[DataMember(Name="application")]
		public EntityRefContract Application { get; set; }

		[DataMember(Name="docClass")]
		public string DocClass { get; set; }

		[DataMember(Name="duCaseIdOrLPAUSKey")]
		public string DuCaseIdOrLPAUSKey { get; set; }

		[DataMember(Name="firstSubmissionDate")]
		public DateTime? FirstSubmissionDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="recommendation")]
		public string Recommendation { get; set; }

		[DataMember(Name="submissionDate")]
		public DateTime? SubmissionDate { get; set; }

		[DataMember(Name="submissionNumber")]
		public string SubmissionNumber { get; set; }

		[DataMember(Name="submittedBy")]
		public string SubmittedBy { get; set; }

		[DataMember(Name="uwOtherRiskAssessType")]
		public string UwOtherRiskAssessType { get; set; }

		[DataMember(Name="uwRiskAssessType")]
		public string UwRiskAssessType { get; set; }

		[DataMember(Name="version")]
		public string Version { get; set; }
		
	}
}