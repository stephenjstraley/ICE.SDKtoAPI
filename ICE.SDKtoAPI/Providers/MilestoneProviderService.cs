using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class MilestoneProviderService : BaseProviderService
    {
        public MilestoneProviderService(AccessToken token = null) : base(token) { paths.SetV1(); }

        public async Task<Tuple<List<MilestoneContract>, LenderApiResponse>> GetAllMilestonesAsync(string guid)
        {
            var usePath = paths.MilestonesPath(guid);

            var items = await Get<List<MilestoneContract>>(usePath);

            return new Tuple<List<MilestoneContract>, LenderApiResponse>(items, _response);
        }
        public async Task<Tuple<List<LoanContractLoanAssociate>, LenderApiResponse>> GetAllMilestoneAssociatesAsync(string guid)
        {
            var usePath = paths.AssociatesPath(guid);

            var items = await Get<List<LoanContractLoanAssociate>>(usePath);

            return new Tuple<List<LoanContractLoanAssociate>, LenderApiResponse>(items, _response);
        }
        public async Task<Tuple<LoanContractLoanAssociate, LenderApiResponse>> GetMilestoneAssociateAsync(string guid, string logId)
        {
            var usePath = paths.AssociatePath(guid, logId);

            var item = await Get<LoanContractLoanAssociate>(usePath);

            return new Tuple<LoanContractLoanAssociate, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<MilestoneContract, LenderApiResponse>> GetAllMilestonesAsync(string guid, string logId)
        {
            var usePath = paths.MilestonePath(guid, logId);

            var item = await Get<MilestoneContract>(usePath);

            return new Tuple<MilestoneContract, LenderApiResponse>(item, _response);
        }

        public async Task<LenderApiResponse> AssignMilestoneAssociateAsync(string guid, string logId, LoanContractLoanAssociate associate)
        {
            LenderApiResponse apiResponse;
            var usePath = paths.AssociatePath(guid, logId);

            try
            {
                var url = Authenticate(usePath);

                var response = await url.PutJsonAsync(associate);

                apiResponse = OkResponse(response, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath, "");
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath, "");
            }

            return apiResponse;
        }
        public async Task<Tuple<List<MilestoneFreeRoleContract>, LenderApiResponse>> GetMilestoneFreeRolesAsync(string guid)
        {
            var usePath = paths.MilestoneFreeRolesPath(guid);

            var items = await Get<List<MilestoneFreeRoleContract>>(usePath);

            return new Tuple<List<MilestoneFreeRoleContract>, LenderApiResponse>(items, _response);
        }
        public async Task<Tuple<MilestoneFreeRoleContract, LenderApiResponse>> GetMilestoneFreeRoleAsync(string guid, string logId)
        {
            var usePath = paths.MilestoneFreeRolePath(guid, logId);

            var item = await Get<MilestoneFreeRoleContract>(usePath);

            return new Tuple<MilestoneFreeRoleContract, LenderApiResponse>(item, _response);
        }

    }
}
