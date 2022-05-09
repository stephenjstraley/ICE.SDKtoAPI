using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class PersonaContract : BaseEncompassModel
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "defaultAccess", EmitDefaultValue = false)]
        public string DefaultAccess { get; set; }

        [DataMember(Name = "isInternal", EmitDefaultValue = false)]
        public bool IsInternal { get; set; }

        [DataMember(Name = "isExternal", EmitDefaultValue = false)]
        public bool IsExternal { get; set; }

        [DataMember(Name = "displayOrder", EmitDefaultValue = false)]
        public int DisplayOrder { get; set; }

        [DataMember(Name = "aclRights", EmitDefaultValue = false)]
        public AclRightsContract AclRights { get; set; }
    }

    [DataContract]
    public class AclRightsContract : BaseEncompassModel
    {
        public List<string> Access { get; set; }
        public AccessRights AditionalService { get; set; }
        public AccessRights AusTracking { get; set; }
        public AccessRights BorrowContacts { get; set; }
        public AccessRights BusinessRules { get; set; }
        public List<string> ClosingDocs { get; set; }
        public AccessRights CompanyUserSetup { get; set; }
        public AccessRights Contacts { get; set; }
        public List<string> ConsumerConnect { get; set; }
        public AccessRights Dashboard { get; set; }
        public AccessRights DisclosureTracking { get; set; }
        public AccessRights DeliveryConditions { get; set; }
        public AccessRights DocsSetup { get; set; }
        public DocumentAccessRights Documents { get; set; }
        public AccessRights DuplicateLoans { get; set; }
        public AccessRights DynamicDataManagement { get; set; }
        public AccessRights EDisclosures { get; set; }
        public AccessRights EFolderHistory { get; set; }
        public AccessRights EFolderSetup { get; set; }
        public AccessRights EncompassWebServices { get; set; }
        public AccessRights EnhancedConditions { get; set; }
        public List<string> ExternalSettings { get; set; }
        public GrantWriteAccess FileContacts { get; set; }
        public List<EntityRefContract> Forms { get; set; }
        public AccessRights GseServices { get; set; }
        public List<string> Loan { get; set; }
        public AccessRights LoConnectTasks { get; set; }
        public AccessRights LoanSetup { get; set; }
        public AccessRights ManageServiceProviders { get; set; }
        public MilestoneWorkFlowRights MilestoneWorkFlowManagement { get; set; }
        public MoveLoansContract MoveLoans { get; set; }
        public List<string> PersonalSettings { get; set; }
        public ExportServiceRights ExportServices { get; set; }
        public AccessRights PersonalTemplates { get; set; }
        public AccessRights PostClosingConditions { get; set; }
        public AccessRights PreliminaryConditions { get; set; }
        public PipelineRights Pipeline { get; set; }
        public AccessRights Print { get; set; }
        public AccessRights PurchaseConditions { get; set; }
        public List<string> Reports { get; set; }
        public ServiceRights Services { get; set; }
        public AccessRights SecondarySetup { get; set; }
        public List<string> SmartClient { get; set; }
        public AccessRights SystemAdminitration { get; set; }
        public AccessRights TablesAndFees { get; set; }
        public List<EntityRefContract> Tools  { get; set; }
        public AccessRights TpoCompanyDetails { get; set; }
        public AccessRights TpoConnectSiteSettings { get; set; }
        public AccessRights TpoContacts { get; set; }
        public AccessRights TpoFees { get; set; }
        public AccessRights TpoInformation { get; set; }
        public AccessRights TpoOrganizationSettings { get; set; }
        public AccessRights TqlServices { get; set; }
        public AccessRights Trades { get; set; }
        public AccessRights UnderwritingConditions { get; set; }
        public AccessRights UnderwritingCenter { get; set; }
    }

    [DataContract]
    public class AccessRights : BaseEncompassModel
    {
        public bool Access { get; set; } = true;
        public List<string> Rights { get; set; }
    }

    [DataContract]
    public class FillAccessRights : AccessRights
    {
        public GrantWriteAccess GrantWriteAccess { get; set; }
    }

    [DataContract]
    public class GrantWriteAccess
    {
        public bool Access { get; set; } = true;
        public List<LoanTeamAccess> LoanTeam { get; set; }
    }

    [DataContract]
    public class LoanTeamAccess
    {
        public EntityRefContract Role { get; set; }
        public EntityRefContract Milestone { get; set; }
    }

    [DataContract]
    public class DocumentAccessRights : AccessRights
    {
        List<string> ProtectedDocuments { get; set; }
        List<string> UnprotectedDocuments { get; set; }
        List<string> unassignedFiles { get; set; }
    }
    
    [DataContract]
    public class ServiceRights
    {
        public string Category { get; set; }
        public string AccessSetting { get; set; }
        public string DefaultAccess { get; set; }
    }

    [DataContract]
    public class MilestoneWorkFlowRights
    {
        public List<EntityRefContract> AcceptFiles { get; set; }
        public List<EntityRefContract> ReturnFiles { get; set; }
        public List<EntityRefContract> ChangeExpectedDate { get; set; }
        public List<EntityRefContract> FinishMilestones { get; set; }
        public List<EntityRefContract> AssignLoanTeamMembers { get; set; }
        public List<EntityRefContract> EditComments { get; set; }
    }

    [DataContract]
    public class MoveLoansContract
    {
        public bool Access { get; set; }
        public List<EntityRefContract> MoveFrom { get; set; }
        public List<EntityRefContract> MoveTo { get; set; }
    }

    [DataContract]
    public class PipelineRights
    {
        public bool Access { get; set; }
        public List<string> PipelineTasks { get; set; }
        public List<string> PipelineViews { get; set; }
        public List<string> NonAccessibleColumns { get; set; }
    }

    [DataContract]
    public class ExportServiceRights
    {
        public string AccessSetting { get; set; }
        public string DefaultAccess { get; set; }
    }
}
