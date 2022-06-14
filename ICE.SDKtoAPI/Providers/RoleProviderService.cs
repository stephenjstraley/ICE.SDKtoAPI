using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class RoleProviderService : BaseProviderService
    {
        public RoleProviderService(AccessToken token) : base(token) { paths.SetV1(); }

        public async Task<Tuple<List<RoleExtended>, LenderApiResponse>> GetRolesAsync()
        {
            List<RoleExtended> roles = null;

            var usePath = paths.Settings + "/roles";

            roles = await Get<List<RoleExtended>>(usePath);

            return new Tuple<List<RoleExtended>, LenderApiResponse>(roles, _response);
        }
    }
}
