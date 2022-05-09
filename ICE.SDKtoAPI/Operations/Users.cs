using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        public async Task<List<UserContract>> GetUsersAsync(int limit = 1000)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetUsersAsync(limit);
            _lastResponse = values.Item2;
            _users = values.Item1;
            return values.Item1;
        }
        public async Task<UserContract> GetUserAsync(string id)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetUserAsync(id);
            _lastResponse = values.Item2;
            return values.Item1;
        }
        public async Task<UserProfileContract> GetUserProfileAsync(string userId)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetUserProfileAsync(userId);
            _lastResponse = values.Item2;
            return values.Item1;
        }
        public async Task<List<UserGroupsContract>> GetUserGroupsAsync(string userId)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetUserGroupsAsync(userId);
            _lastResponse = values.Item2;
            return values.Item1;
        }
        public async Task<List<UserCompensationPlanContract>> GetUserCompensationPlansAsync(string userId)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetUserCompensationPlansAsync(userId);
            _lastResponse = values.Item2;
            return values.Item1;
        }
        public async Task<List<UserLicenseContract>> GetUserLicensesAsync(string userId)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetLicensesAsync(userId);
            _lastResponse = values.Item2;
            return values.Item1;
        }
        public async Task<List<EntityRefContract>> GetUserEligibleRolesAsync(string userId)
        {
            SetResponse();
            var service = new SettingProviderService(_accessToken);
            var values = await service.GetUserEligibleRolesAsync(userId);
            _lastResponse = values.Item2;
            return values.Item1;
        }
    }
}
