using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHomeCounselingProviders
	{
		[DataMember(Name="agencyAddress")]
		public string AgencyAddress { get; set; }

		[DataMember(Name="agencyAddressCity")]
		public string AgencyAddressCity { get; set; }

		[DataMember(Name="agencyAddressPostalCode")]
		public string AgencyAddressPostalCode { get; set; }

		[DataMember(Name="agencyAddressState")]
		public string AgencyAddressState { get; set; }

		[DataMember(Name="agencyAffiliationDescription")]
		public string AgencyAffiliationDescription { get; set; }

		[DataMember(Name="agencyAffiliationIndicator")]
		public bool? AgencyAffiliationIndicator { get; set; }

		[DataMember(Name="agencyEmail")]
		public string AgencyEmail { get; set; }

		[DataMember(Name="agencyFax")]
		public string AgencyFax { get; set; }

		[DataMember(Name="agencyId")]
		public string AgencyId { get; set; }

		[DataMember(Name="agencyName")]
		public string AgencyName { get; set; }

		[DataMember(Name="agencyPhoneDirect")]
		public string AgencyPhoneDirect { get; set; }

		[DataMember(Name="agencyPhoneTollFree")]
		public string AgencyPhoneTollFree { get; set; }

		[DataMember(Name="agencySource")]
		public string AgencySource { get; set; }

		[DataMember(Name="agencyWebAddress")]
		public string AgencyWebAddress { get; set; }

		[DataMember(Name="counselingServicesProvided")]
		public string CounselingServicesProvided { get; set; }

		[DataMember(Name="distanceMiles")]
		public decimal? DistanceMiles { get; set; }

		[DataMember(Name="homeCounselingProviderId")]
		public string HomeCounselingProviderId { get; set; }

		[DataMember(Name="homeCounselingProviderIndex")]
		public int? HomeCounselingProviderIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="languagesSupported")]
		public string LanguagesSupported { get; set; }

		[DataMember(Name="selectedIndicator")]
		public bool? SelectedIndicator { get; set; }

	}
}