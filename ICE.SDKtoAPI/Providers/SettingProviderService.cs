using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.LenderApiContractsV3;
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
            var usePath = paths.UserPathFullLimit(limit);

            var users = await Get<List<UserContract>>(usePath);

            return new Tuple<List<UserContract>, LenderApiResponse>(users, _response);
        }
        public async Task<Tuple<UserContract, LenderApiResponse>> GetUserAsync(string id)
        {
            var usePath = paths.UserPathFull + $"/{id}";

            var user = await Get<UserContract>(usePath);

            return new Tuple<UserContract, LenderApiResponse>(user, _response);
        }
        public async Task<Tuple<UserProfileContract, LenderApiResponse>> GetUserProfileAsync(string userId)
        {
            var usePath = paths.UserProfilePath(userId);

            var user = await Get<UserProfileContract>(usePath);

            return new Tuple<UserProfileContract, LenderApiResponse>(user, _response);
        }
        public async Task<Tuple<List<UserGroupsContract>, LenderApiResponse>> GetUserGroupsAsync(string userId)
        {
            var usePath = paths.UserGroupPath(userId);

            var userGroups = await Get<List<UserGroupsContract>>(usePath);

            return new Tuple<List<UserGroupsContract>, LenderApiResponse>(userGroups, _response);
        }
        public async Task<Tuple<List<UserCompensationPlanContract>, LenderApiResponse>> GetUserCompensationPlansAsync(string userId)
        {
            var usePath = paths.UserCompensationPath(userId);

            var plans = await Get<List<UserCompensationPlanContract>>(usePath);

            return new Tuple<List<UserCompensationPlanContract>, LenderApiResponse>(plans, _response);
        }
        public async Task<Tuple<List<UserLicenseContract>, LenderApiResponse>> GetLicensesAsync(string userId)
        {
            var usePath = paths.UserLicensesPath(userId);

            var licenses = await Get<List<UserLicenseContract>>(usePath);

            return new Tuple<List<UserLicenseContract>, LenderApiResponse>(licenses, _response);
        }
        public async Task<Tuple<List<object>, LenderApiResponse>> GetUserAssignedRightsAsync(string userId)
        {
            var usePath = paths.UserPathFull + $"/{userId}/assignedRights";

            var rights = await Get<List<object>>(usePath);

            return new Tuple<List<object>, LenderApiResponse>(rights, _response);
        }
        public async Task<Tuple<List<object>, LenderApiResponse>> GetUserEffectiveRightsAsync(string userId)
        {
            var usePath = paths.UserPathFull + $"/{userId}/effectiveRights";

            var rights = await Get<List<object>>(usePath);

            return new Tuple<List<object>, LenderApiResponse>(rights, _response);
        }
        public async Task<Tuple<List<EntityRefContract>, LenderApiResponse>> GetUserEligibleRolesAsync(string userId)
        {
            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/users/{userId}/eligibleRoles";

            var roles = await Get<List<EntityRefContract>>(usePath);

            paths.SetV1();

            return new Tuple<List<EntityRefContract>, LenderApiResponse>(roles, _response);
        }
        public async Task<Tuple<List<PersonaContract>, LenderApiResponse>> GetPersonasAsync()
        {
            var usePath = paths.Settings + "/personas";

            var personas = await Get<List<PersonaContract>>(usePath);

            return new Tuple<List<PersonaContract>, LenderApiResponse>(personas, _response);
        }
        public async Task<Tuple<PersonaContract, LenderApiResponse>> GetPersonaAsync(string id)
        {
            var usePath = paths.Settings + $"/personas/{id}";

            var persona = await Get<PersonaContract>(usePath);

            return new Tuple<PersonaContract, LenderApiResponse>(persona, _response);
        }
        public async Task<Tuple<PersonaContract, LenderApiResponse>> GetPersonaCategoriesAsync(string id, string cats)
        {
            var usePath = paths.Settings + $"/personas/{id}?categories={cats}";

            var persona = await Get<PersonaContract>(usePath);

            return new Tuple<PersonaContract, LenderApiResponse>(persona, _response);
        }
        public async Task<Tuple<UrlaConfiguration, LenderApiResponse>> GetUrlaConfiguration()
        {
            paths.SetV3();

            var usePath = paths.Settings + "/policies/urla";

            var config = await Get<UrlaConfiguration>(usePath);

            return new Tuple<UrlaConfiguration, LenderApiResponse>(config, _response);
        }

        public async Task<Tuple<DisclosureTrackingSettings, LenderApiResponse>> GetDisclosureTrackingSettingsAsync()
        {
            paths.SetV3();

            var usePath = paths.Settings + "/loan/disclosureTracking";

            var track = await Get<DisclosureTrackingSettings>(usePath);

            return new Tuple<DisclosureTrackingSettings, LenderApiResponse>(track, _response);
        }

        public async Task<Tuple<List<FundingTemplateContract>, LenderApiResponse>> GetFundingTemplatesAsync()
        {
            paths.SetV3();

            var usePath = paths.Settings + "/secondary/fundingTemplate";

            var temps = await Get<List<FundingTemplateContract>>(usePath);

            return new Tuple<List<FundingTemplateContract>, LenderApiResponse>(temps, _response);
        }

        public async Task<Tuple<List<InvestorTemplateContract>, LenderApiResponse>> GetInvestorTemplatesAsync()
        {
            paths.SetV3();

            var usePath = paths.Settings + "/secondary/investorTemplates";

            var temps = await Get<List<InvestorTemplateContract>>(usePath);

            return new Tuple<List<InvestorTemplateContract>, LenderApiResponse>(temps, _response);
        }
        public async Task<Tuple<InvestorTemplateContract, LenderApiResponse>> GetInvestorTemplateAsync(string guid)
        {
            paths.SetV3();

            var usePath = paths.Settings + $"/secondary/investorTemplates/{guid}";

            var temps = await Get<InvestorTemplateContract>(usePath);

            return new Tuple<InvestorTemplateContract, LenderApiResponse>(temps, _response);
        }
        public async Task<Tuple<List<ExternalOrganizationContract>, LenderApiResponse>> GetExternalOrganizationsAsync()
        {
            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/externalOrganizations/tpos";

            var exs = await Get<List<ExternalOrganizationContract>>(usePath);

            return new Tuple<List<ExternalOrganizationContract>, LenderApiResponse>(exs, _response);
        }
        public async Task<Tuple<ExternalOrganizationContract, LenderApiResponse>> GetExternalOrganizationAsync(string guid)
        {
            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/externalOrganizations/tpos/{guid}?entities=all";

            var exs = await Get<ExternalOrganizationContract>(usePath);

            return new Tuple<ExternalOrganizationContract, LenderApiResponse>(exs, _response);
        }
        public async Task<Tuple<List<ExternalUserContract>, LenderApiResponse>> GetExternalUsersAsync()
        {
            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/externalUsers";

            var exs = await Get<List<ExternalUserContract>>(usePath);

            return new Tuple<List<ExternalUserContract>, LenderApiResponse>(exs, _response);
        }
        public async Task<Tuple<ExternalUserContract, LenderApiResponse>> GetExternalUserAsync(string guid)
        {
            paths.SetV3();

            var usePath = paths.EncompassPathFull + $"/externalUsers/{guid}";

            var exs = await Get<ExternalUserContract>(usePath);

            return new Tuple<ExternalUserContract, LenderApiResponse>(exs, _response);
        }



        // get ecternal user effetive rights

    }
}
