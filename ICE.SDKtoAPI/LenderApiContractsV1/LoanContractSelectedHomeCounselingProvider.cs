using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSelectedHomeCounselingProvider
	{
		[DataMember(Name="affiliatedWithLenderIndicator", EmitDefaultValue=false)]
		public bool? AffiliatedWithLenderIndicator { get; set; }

		[DataMember(Name="agencyAddress", EmitDefaultValue=false)]
		public string AgencyAddress { get; set; }

		[DataMember(Name="agencyAddressCity", EmitDefaultValue=false)]
		public string AgencyAddressCity { get; set; }

		[DataMember(Name="agencyAddressPostalCode", EmitDefaultValue=false)]
		public string AgencyAddressPostalCode { get; set; }

		[DataMember(Name="agencyAddressState", EmitDefaultValue=false)]
		public string AgencyAddressState { get; set; }

		[DataMember(Name="agencyAffiliationDescription", EmitDefaultValue=false)]
		public string AgencyAffiliationDescription { get; set; }

		[DataMember(Name="agencyEmail", EmitDefaultValue=false)]
		public string AgencyEmail { get; set; }

		[DataMember(Name="agencyFax", EmitDefaultValue=false)]
		public string AgencyFax { get; set; }

		[DataMember(Name="agencyName", EmitDefaultValue=false)]
		public string AgencyName { get; set; }

		[DataMember(Name="agencyPhoneDirect", EmitDefaultValue=false)]
		public string AgencyPhoneDirect { get; set; }

		[DataMember(Name="agencyPhoneTollFree", EmitDefaultValue=false)]
		public string AgencyPhoneTollFree { get; set; }

		[DataMember(Name="agencyWebAddress", EmitDefaultValue=false)]
		public string AgencyWebAddress { get; set; }

		[DataMember(Name="brrowerSelectCounselorIndicator", EmitDefaultValue=false)]
		public bool? BrrowerSelectCounselorIndicator { get; set; }

		[DataMember(Name="certificationIssuedIndicator", EmitDefaultValue=false)]
		public bool? CertificationIssuedIndicator { get; set; }

		[DataMember(Name="counselingServicesProvided", EmitDefaultValue=false)]
		public string CounselingServicesProvided { get; set; }

		[DataMember(Name="distanceMiles", EmitDefaultValue=false)]
		public double? DistanceMiles { get; set; }

		[DataMember(Name="explanation", EmitDefaultValue=false)]
		public string Explanation { get; set; }

		[DataMember(Name="homeCounselingCompletionDate", EmitDefaultValue=false)]
		public DateTime? HomeCounselingCompletionDate { get; set; }

		[DataMember(Name="homeCounselingDisclosureDate", EmitDefaultValue=false)]
		public DateTime? HomeCounselingDisclosureDate { get; set; }

		[DataMember(Name="homeCounselingGeneratedDate", EmitDefaultValue=false)]
		public DateTime? HomeCounselingGeneratedDate { get; set; }

		[DataMember(Name="homeCounselingRequiredIndicator", EmitDefaultValue=false)]
		public bool? HomeCounselingRequiredIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="languagesSupported", EmitDefaultValue=false)]
		public string LanguagesSupported { get; set; }

		[DataMember(Name="selectedGUID", EmitDefaultValue=false)]
		public string SelectedGUID { get; set; }

	}
}