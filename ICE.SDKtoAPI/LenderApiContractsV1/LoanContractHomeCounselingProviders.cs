using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHomeCounselingProviders
	{
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

		[DataMember(Name="agencyAffiliationIndicator", EmitDefaultValue=false)]
		public bool? AgencyAffiliationIndicator { get; set; }

		[DataMember(Name="agencyEmail", EmitDefaultValue=false)]
		public string AgencyEmail { get; set; }

		[DataMember(Name="agencyFax", EmitDefaultValue=false)]
		public string AgencyFax { get; set; }

		[DataMember(Name="agencyId", EmitDefaultValue=false)]
		public string AgencyId { get; set; }

		[DataMember(Name="agencyName", EmitDefaultValue=false)]
		public string AgencyName { get; set; }

		[DataMember(Name="agencyPhoneDirect", EmitDefaultValue=false)]
		public string AgencyPhoneDirect { get; set; }

		[DataMember(Name="agencyPhoneTollFree", EmitDefaultValue=false)]
		public string AgencyPhoneTollFree { get; set; }

		[DataMember(Name="agencySource", EmitDefaultValue=false)]
		public string AgencySource { get; set; }

		[DataMember(Name="agencyWebAddress", EmitDefaultValue=false)]
		public string AgencyWebAddress { get; set; }

		[DataMember(Name="counselingServicesProvided", EmitDefaultValue=false)]
		public string CounselingServicesProvided { get; set; }

		[DataMember(Name="distanceMiles", EmitDefaultValue=false)]
		public double? DistanceMiles { get; set; }

		[DataMember(Name="homeCounselingProviderId", EmitDefaultValue=false)]
		public string HomeCounselingProviderId { get; set; }

		[DataMember(Name="homeCounselingProviderIndex", EmitDefaultValue=false)]
		public int? HomeCounselingProviderIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="languagesSupported", EmitDefaultValue=false)]
		public string LanguagesSupported { get; set; }

		[DataMember(Name="selectedIndicator", EmitDefaultValue=false)]
		public bool? SelectedIndicator { get; set; }

	}
}