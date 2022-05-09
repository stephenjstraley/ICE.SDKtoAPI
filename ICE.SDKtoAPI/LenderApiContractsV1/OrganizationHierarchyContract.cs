using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class OrganizationHierarchyContract
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberOfChildOrganizations { get; set; }
        public int NumberOfChildUsers { get; set; }
        public EntityRefContract ParentOrg { get; set; }
        public List<EntityRefContract> Children { get; set; }
    }
}
