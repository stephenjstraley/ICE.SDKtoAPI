using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.SupportingClasses
{
    public static class SDKAPIHealth
    {
        public static bool Check(string instance, string apiClient, string userName, string password, string secret)
        {
            using (var api = new LenderAPI(instance, apiClient, userName, password, secret))
            {
                return api.GetToken();
            }
        }
    }
}
