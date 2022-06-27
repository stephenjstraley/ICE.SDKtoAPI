using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<MilestoneContract> LastCompletedMilestoneAsync();
        Task<MilestoneContract> LastCompletedMilestoneAsync(string guid);
        Task<MilestoneContract> NextMilestoneAsync();
        Task<MilestoneContract> NextMilestoneAsync(string guid);
        Task<List<MilestoneContract>> GetMilestonesAsync();
        Task<List<MilestoneContract>> GetMilestonesAsync(string guid);
        Task<MilestoneContract> GetMilestoneByNameAsync(string name);
        Task<MilestoneContract> GetMilestoneByNameAsync(string guid, string name);
        Task<List<MilestoneFreeRoleContract>> GetMilestoneFreeRolesAsync();
        Task<List<MilestoneFreeRoleContract>> GetMilestoneFreeRolesAsync(string guid);
    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<MilestoneContract> LastCompletedMilestoneAsync() => await LastCompletedMilestoneAsync(LoanGuid);
        public async Task<MilestoneContract> LastCompletedMilestoneAsync(string guid)
        {
            var milestones = await GetMilestonesAsync(guid);
            if (milestones != null && _lastResponse.IsSuccess)
            {
                return milestones
                    .Where(x => x.DoneIndicator.HasValue && x.DoneIndicator.Value)
                    .OrderByDescending(x => x.StartDate)
                    .Take(1)
                    .SingleOrDefault();
            }
            return null;
        }
        public async Task<MilestoneContract> NextMilestoneAsync() => await NextMilestoneAsync(LoanGuid);
        public async Task<MilestoneContract> NextMilestoneAsync(string guid)
        {
            var milestones = await GetMilestonesAsync(guid);
            if (milestones != null && _lastResponse.IsSuccess)
            {
                return milestones
                        .Where(x => !x.DoneIndicator.HasValue || !x.DoneIndicator.Value)
                        .OrderBy(x => x.StartDate)
                        .Take(1)
                        .SingleOrDefault();
            }
            return null;
        }
        public async Task<List<MilestoneContract>> GetMilestonesAsync() => await GetMilestonesAsync(LoanGuid);
        public async Task<List<MilestoneContract>> GetMilestonesAsync(string guid)
        {
            if (guid != null)
            {
                SetResponse();

                var provider = new MilestoneProviderService(_accessToken);
                var results = await provider.GetAllMilestonesAsync(guid);
                _lastResponse = results.Item2;
                return results.Item1;
            }

            return null;
        }
        public async Task<MilestoneContract> GetMilestoneByNameAsync(string name) => await GetMilestoneByNameAsync(LoanGuid, name);
        public async Task<MilestoneContract> GetMilestoneByNameAsync(string guid, string name)
        {
            var items = await GetMilestonesAsync(guid);
            if (items != null)
                return items?.Where(t => t.MilestoneName.ToUpper() == name.ToUpper()).FirstOrDefault();
            else
                return null;
        }
        public async Task<List<MilestoneFreeRoleContract>> GetMilestoneFreeRolesAsync() => await GetMilestoneFreeRolesAsync(LoanGuid);
        public async Task<List<MilestoneFreeRoleContract>> GetMilestoneFreeRolesAsync(string guid)
        {
            SetResponse();
            var provider = new MilestoneProviderService(_accessToken);
            var results = await provider.GetMilestoneFreeRolesAsync(guid);
            _lastResponse = results.Item2;

            return results.Item1;
        }
    }
}
