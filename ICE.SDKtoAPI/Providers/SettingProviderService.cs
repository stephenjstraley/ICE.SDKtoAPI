using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class SettingProviderService : BaseProviderService
    {
        public SettingProviderService(AccessToken token) : base(token) { paths.SetV1(); }

        public async Task<Tuple<List<UserContract>, LenderApiResponse>> GetUsersAsync(int limit = 10000)
        {
            List<UserContract> users = null;

            var usePath = paths.UserPathFullLimit(limit);

            users = await Get<List<UserContract>>(usePath);

            return new Tuple<List<UserContract>, LenderApiResponse>(users, _response);
        }
        public async Task<Tuple<UserContract, LenderApiResponse>> GetUserAsync(string id)
        {
            UserContract user = null;

            var usePath = paths.UserPathFull + $"/{id}";

            user = await Get<UserContract>(usePath);

            return new Tuple<UserContract, LenderApiResponse>(user, _response);
        }
        public async Task<Tuple<UserProfileContract, LenderApiResponse>> GetUserProfileAsync(string userId)
        {
            UserProfileContract user = null;

            var usePath = paths.UserProfilePath(userId);

            user = await Get<UserProfileContract>(usePath);

            return new Tuple<UserProfileContract, LenderApiResponse>(user, _response);
        }
        public async Task<Tuple<List<UserGroupsContract>, LenderApiResponse>> GetUserGroupsAsync(string userId)
        {
            List<UserGroupsContract> userGroups = null;

            var usePath = paths.UserGroupPath(userId);

            userGroups = await Get<List<UserGroupsContract>>(usePath);

            return new Tuple<List<UserGroupsContract>, LenderApiResponse>(userGroups, _response);
        }
        public async Task<Tuple<List<UserCompensationPlanContract>, LenderApiResponse>> GetUserCompensationPlansAsync(string userId)
        {
            List<UserCompensationPlanContract> plans = null;

            var usePath = paths.UserCompensationPath(userId);

            plans = await Get<List<UserCompensationPlanContract>>(usePath);

            return new Tuple<List<UserCompensationPlanContract>, LenderApiResponse>(plans, _response);
        }
        public async Task<Tuple<List<UserLicenseContract>, LenderApiResponse>> GetLicensesAsync(string userId)
        {
            List<UserLicenseContract> licenses = null;

            var usePath = paths.UserLicensesPath(userId);

            licenses = await Get<List<UserLicenseContract>>(usePath);

            return new Tuple<List<UserLicenseContract>, LenderApiResponse>(licenses, _response);
        }
        public async Task<Tuple<List<object>, LenderApiResponse>> GetUserAssignedRightsAsync(string userId)
        {
            List<object> rights = null;

            var usePath = paths.UserPathFull + $"/{userId}/assignedRights";

            rights = await Get<List<object>>(usePath);

            return new Tuple<List<object>, LenderApiResponse>(rights, _response);
        }
        public async Task<Tuple<List<object>, LenderApiResponse>> GetUserEffectiveRightsAsync(string userId)
        {
            List<object> rights = null;

            var usePath = paths.UserPathFull + $"/{userId}/effectiveRights";

            rights = await Get<List<object>>(usePath);

            return new Tuple<List<object>, LenderApiResponse>(rights, _response);
        }
        public async Task<Tuple<List<EntityRefContract>, LenderApiResponse>> GetUserEligibleRolesAsync(string userId)
        {
            List<EntityRefContract> roles = null;

            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/users/{userId}/eligibleRoles";

            roles = await Get<List<EntityRefContract>>(usePath);

            paths.SetV1();

            return new Tuple<List<EntityRefContract>, LenderApiResponse>(roles, _response);
        }
        public async Task<Tuple<List<PersonaContract>, LenderApiResponse>> GetPersonasAsync()
        {
            List<PersonaContract> personas = null;

            var usePath = paths.Settings + "/personas";

            personas = await Get<List<PersonaContract>>(usePath);

            return new Tuple<List<PersonaContract>, LenderApiResponse>(personas, _response);
        }
        public async Task<Tuple<PersonaContract, LenderApiResponse>> GetPersonaAsync(string id)
        {
            PersonaContract persona = null;

            var usePath = paths.Settings + $"/personas/{id}";

            persona = await Get<PersonaContract>(usePath);

            return new Tuple<PersonaContract, LenderApiResponse>(persona, _response);
        }
        public async Task<Tuple<PersonaContract, LenderApiResponse>> GetPersonaCategoriesAsync(string id, string cats)
        {
            PersonaContract persona = null;

            var usePath = paths.Settings + $"/personas/{id}?categories={cats}";

            persona = await Get<PersonaContract>(usePath);

            return new Tuple<PersonaContract, LenderApiResponse>(persona, _response);
        }

        /// TODO
        /// Secondary Settings (v3)
        /// External Users (v3)
    }
}
