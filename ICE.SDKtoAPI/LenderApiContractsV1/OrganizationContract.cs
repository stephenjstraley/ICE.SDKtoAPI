using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class OrganizationContract
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfChildOrganizations { get; set; }
        public int NumberOfChildUsers { get; set; }
        public OrgInformationContract OrgInformation { get; set; }
        public OrgNmls Nmls { get; set; }
        public OrgNmls MerMin { get; set; }
        public OrgLegalEntityIdentifier LegalEntityIdentifier { get; set; }
        public OrgSearch ConsumerConnectLOSearch { get; set; }
        public OrgOnrpSettings OnrpSettings { get; set; }
        public OrgLicense License { get; set; }
        public EntityRefContract ParentOrg { get; set; }
    }
    public class OrgInformationContract
    {
        public bool UseParentInformation { get; set; }
        public string Name { get; set; }
        public OrgAddressContract Address { get; set; }
        public string Phone { get; set; }
    }
    public class OrgAddressContract
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Zip { get; set; }
    }
    public class OrgNmls
    {
        public bool UseParentInformation { get; set; } = false;
        public string Code { get; set; }
    }
    public class OrgLegalEntityIdentifier
    {
        public bool UseParentInformation { get; set; } = false;
        public EntityRefContract HmdaProfile { get; set; }
        public string Lei { get; set; }
    }
    public class OrgSearch
    {
        public bool UseParentInformation { get; set; } = false;
        public bool ShowInSearch { get; set; } = false;
    }
    public class OrgOnrpSettings
    {
        public bool UseParentInformation { get; set; } = false;
        public bool EnableOnrp { get; set; } = false;
        public bool UseChannelDefault { get; set; } = false;
        public bool ContinuousCoverage { get; set; } = false;
        public string WeekdayStartTime { get; set; }
        public string WeekdayEndTime { get; set; }
        public bool WeekendHolidayCoverage { get; set; } = false;
        public bool EnableSunday { get; set; } = false;
        public string SundayStartTime { get; set; }
        public bool EnableSaturda { get; set; } = false;
        public string SaturdayStartTime { get; set; }
        public bool NoMaximumLimit { get; set; } = false;
    }
    public class OrgLicense
    {
        public string HomeState { get; set; }
        public string LenderType { get; set; }
        public string StatutoryStatusKansasType { get; set; }
        public string StatutoryStatusMarylandType { get; set; }
        public List<OrgStateLicenseExtType> StateLicenseExtTypes { get; set; }
        public bool DontApplyIntRateExportation { get; set; } = false;
    }
    public class OrgStateLicenseExtType
    {
        public string StateAbbrivation { get; set; }
        public string LicenseType { get; set; }
        public bool IsExempted { get; set; } = false;
        public string LicenseNo { get; set; }
        public string LicenseStatus { get; set; }
        public bool IsApproved { get; set; } = false;
        public bool IsSelected { get; set; } = false;
    }
}
