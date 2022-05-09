using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        public async Task<List<LoanContractLoanAssociate>> GetLoanAssociatesAsync() => await GetLoanAssociatesAsync(LoanGuid);
        public async Task<List<LoanContractLoanAssociate>> GetLoanAssociatesAsync(string guid)
        {
            if (guid != null)
            {
                SetResponse();
                var provider = new MilestoneProviderService(_accessToken);
                var results = await provider.GetAllMilestoneAssociatesAsync(_guid);
                _lastResponse = results.Item2;
                return results.Item1;
            }

            return null;
        }
        public async Task<List<LoanContractLoanAssociate>> GetLoanAssociatesByRoleNameAsync(string roleName) => await GetLoanAssociatesByRoleNameAsync(LoanGuid, roleName);

        public async Task<List<LoanContractLoanAssociate>> GetLoanAssociatesByRoleNameAsync(string guid, string roleName)
        {
            List<LoanContractLoanAssociate> associates = new List<LoanContractLoanAssociate>();
            var results = await GetLoanAssociatesAsync(guid);
            if (LastStatus == HttpStatusCode.OK)
            {
                foreach (var assoc in results)
                    if (assoc.RoleName.ToUpper() == roleName.ToUpper())
                        associates.Add(assoc);
            }
            return associates;
        }
        public async Task<bool> AssignLoanAssociateAsync(string logId, LoanContractLoanAssociate user) => await AssignLoanAssociateAsync(LoanGuid, logId, user);
        public async Task<bool> AssignLoanAssociateAsync(string logId, string associateType, string userId) => await AssignLoanAssociateAsync(LoanGuid, logId, associateType, userId);
        public async Task<bool> AssignLoanAssociateAsync(string guid, string logId, string associateType, string userId)
        {
            var contract = new LoanContractLoanAssociate()
            {
                LoanAssociateType = associateType,
                Id = userId
            };

            return await AssignLoanAssociateAsync(guid, logId, contract);
        }
        public async Task<bool> AssignLoanAssociateAsync(string guid, string logId, LoanContractLoanAssociate user)
        {
            if (guid != null && logId != null)
            {
                SetResponse();
                var provider = new MilestoneProviderService(_accessToken);
                var results = await provider.AssignMilestoneAssociateAsync(guid, logId, user);
                _lastResponse = results;
                return results.IsSuccess;
            }

            return false;
        }

    }
}
