using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<RoleExtended>> GetRolesAsync();
        Task<RoleExtended> GetRoleByNameAsync(string name);
        Task<RoleExtended> GetRoleByAbbr(string abv);
        Task<List<RoleExtended>> GetRoleLikeByNameAsync(string name);

    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<RoleExtended>> GetRolesAsync()
        {
            SetResponse();
            List<RoleExtended> roles = new List<RoleExtended>();
            var provider = new RoleProviderService(_accessToken);
            var results = await provider.GetRolesAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<RoleExtended> GetRoleByNameAsync(string name)
        {
            SetResponse();
            List<RoleExtended> roles = await GetRolesAsync();
            if (LastStatus == HttpStatusCode.OK)
                foreach (var role in roles)
                    if (role.RoleName.ToUpper() == name.ToUpper())
                        return role;

            return null;
        }
        public async Task<RoleExtended> GetRoleByAbbr(string abv)
        {
            List<RoleExtended> roles = await GetRolesAsync();
            if (LastStatus == HttpStatusCode.OK)
                foreach (var role in roles)
                    if (role.RoleAbbr.ToUpper() == abv.ToUpper())
                        return role;

            return null;
        }
        public async Task<List<RoleExtended>> GetRoleLikeByNameAsync(string name)
        {
            SetResponse();
            List<RoleExtended> roles = new List<RoleExtended>();
            List<RoleExtended> allRoles = await GetRolesAsync();
            if (LastStatus == HttpStatusCode.OK)
                foreach (var role in allRoles)
                    if (role.RoleName.ToUpper().Contains(name.ToUpper()))
                        roles.Add(role);
            return roles;
        }
    }
}
